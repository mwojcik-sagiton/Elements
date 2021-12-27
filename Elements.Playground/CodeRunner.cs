using System;
using Microsoft.CodeAnalysis;
using Microsoft.JSInterop;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Reflection;
using System.Diagnostics;
using System.IO;
using Elements.Serialization.glTF;

namespace Elements.Playground
{
    public static class CodeRunner
    {
        public static string Output = "<p class=\"message\">Nothing to see yet. Try adding and connecting nodes.</p>";
        public static string Code = "// No code available yet. Try adding and connecting nodes.";
        public static long ExecutionTime = 0;
        public static long CompilationTime = 0;
        public static long GeometryGenerationTime = 0;
        public static long DrawingTime = 0;
        public static string Error = string.Empty;
        public static IJSUnmarshalledRuntime Runtime;
        private static Dictionary<string, double> context;
        private static Assembly asm;
        private static Compilation compilation;

        public static event Action ExecutionComplete;
        public static void OnExecutionComplete()
        {
            ExecutionComplete?.Invoke();
        }

        public static event Action CompilationComplete;
        public static void OnCompilationComplete()
        {
            CompilationComplete?.Invoke();
        }

        [JSInvokable]
        public static void SetCodeValue(string code)
        {
            Console.WriteLine(code);
            Code = code;
            OnCompilationComplete();
        }

        [JSInvokable]
        public static void SetCodeContext(Dictionary<string, double> value)
        {
            context = value;
        }

        [JSInvokable]
        public static Task Run()
        {
            return Compiler.WhenReady(RunInternal);
        }

        [JSInvokable]
        public static async Task Compile()
        {
            Output = string.Empty;

            var currentOut = Console.Out;
            var writer = new StringWriter();
            Console.SetOut(writer);
            var sw = Stopwatch.StartNew();
            try
            {
                asm = null;
                compilation = null;
                var (success, newAsm, newCompilation) = Compiler.LoadSource(Code);
                if (success)
                {
                    Error = string.Empty;
                    asm = newAsm;
                    compilation = newCompilation;
                    CompilationTime = sw.ElapsedMilliseconds;
                    await RunInternal();
                }
                else
                {
                    Error = "Compilation failed";
                }
                Output += writer.ToString();
                OnCompilationComplete();
            }
            catch (Exception ex)
            {
                Error = ex.ToString();
            }
            finally
            {
                Console.SetOut(currentOut);
            }
            sw.Stop();
        }

        static async Task RunInternal()
        {
            var globals = new Globals(context);

            var currentOut = Console.Out;
            var writer = new StringWriter();
            Console.SetOut(writer);
            var sw = Stopwatch.StartNew();
            try
            {
                var entryPoint = compilation.GetEntryPoint(CancellationToken.None);
                var type = asm.GetType($"{entryPoint.ContainingNamespace.MetadataName}.{entryPoint.ContainingType.MetadataName}");
                var entryPointMethod = type.GetMethod(entryPoint.MetadataName);

                var submission = (Func<object[], Task>)entryPointMethod.CreateDelegate(typeof(Func<object[], Task>));
                var model = await (Task<object>)submission(new object[] { globals, null });

                ExecutionTime = sw.ElapsedMilliseconds;
                sw.Reset();

                await Task.Run(() =>
                {
                    sw.Start();
                    Error = string.Empty;
                    Output = string.Empty;
                    var m = (Elements.Model)model;
                    if (m.Elements.Count > 0)
                    {
                        var glb = m.ToGlTF();
                        GeometryGenerationTime = sw.ElapsedMilliseconds;
                        sw.Reset();

                        sw.Start();
                        Runtime.InvokeUnmarshalled<byte[], bool>("model.loadModel", glb);
                        DrawingTime = sw.ElapsedMilliseconds;
                    }
                });

                Output += writer.ToString();
                OnExecutionComplete();
            }
            catch (Exception ex)
            {
                Error = ex.ToString();
            }
            finally
            {
                Console.SetOut(currentOut);
            }
            sw.Stop();
        }
    }
}
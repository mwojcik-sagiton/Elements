using System;
using System.Collections.Generic;
using Hypar.Elements;
using Hypar.Geometry;
using Xunit;

namespace Hypar.Tests
{
    public class WallTests
    {
        [Fact]
        public void Example()
        {
            var model = new Model();

            var triangle = Polygon.Ngon(7, 15.0);
            var openings = new List<Opening>();
            openings.Add(new Opening(1.0, 1.0, 2.0, 1.0));
            openings.Add(new Opening(4.0, 0.0, 2.0, 1.0));
            foreach(var l in triangle.Segments())
            {
                var w = new Wall(l, 0.1, 5.0, openings);
                model.AddElement(w);
            }
            
            model.SaveGlb("wall.glb");
        }

        [Fact]
        public void ZeroHeight_ThrowsException()
        {
            var a = Vector3.Origin;
            var b = new Vector3(0.0, 5.0);
            var line = new Line(a,b);
            Assert.Throws<ArgumentOutOfRangeException>(()=>new Wall(line, 0.1, 0.0));
        }

        [Fact]
        public void ZeroThickness_ThrowsException()
        {
            var a = Vector3.Origin;
            var b = new Vector3(0.0, 5.0);
            var line = new Line(a,b);
            Assert.Throws<ArgumentOutOfRangeException>(()=>new Wall(line, 0.0, 5.0));
        }

        [Fact]
        public void NonPlanarCenterLine_ThrowsException()
        {
            var a = Vector3.Origin;
            var b = new Vector3(0.0, 5.0, 5.0);
            var line = new Line(a,b);
            Assert.Throws<ArgumentException>(()=>new Wall(line, 0.1, 5.0));
        }

        [Fact]
        public void NullOpenings_ProfileWithNoVoids()
        {
            var a = Vector3.Origin;
            var b = new Vector3(0.0, 5.0);
            var line = new Line(a,b);
            var wall = new Wall(line, 0.1, 4.0);
            Assert.Equal(0, wall.Profile.Voids.Count);
        }

        [Fact]
        public void TwoOpenings_ProfileWithTwoOpenings()
        {
            var a = Vector3.Origin;
            var b = new Vector3(0.0, 5.0);
            var line = new Line(a,b);
            var o1 = new Opening(1.0, 0.0, 2.0, 1.0);
            var o2 = new Opening(3.0, 1.0, 1.0, 1.0);
            var wall = new Wall(line, 0.1, 4.0, new []{o1,o2});
            Assert.Equal(2, wall.Profile.Voids.Count);
        }
    }
}
﻿namespace PositionerTests
{
    using AlbumWordAddin;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class PositionerTestsBendUpDown
    {
        static readonly Positioner.Parms BendDownPos  = new Positioner.Parms { Cols = 2, Rows = 1, HShape = HShape.Flat, VShape = VShape.Benddown, Margin = 0, Padding = 0};
        static readonly Positioner.Parms BendUpPos    = new Positioner.Parms { Cols = 2, Rows = 1, HShape = HShape.Flat, VShape = VShape.Bendup  , Margin = 0, Padding = 0};

        [TestMethod]
        public void TestPositioner_BendDown2Shapes()
        {
            PositionerTests.Run(PositionerTests.R1X1.Grow(2), PositionerTests.R1X1.Range(2), BendDownPos.WithRowsCols(1, 2), PositionerTests.R1X1.Range(2, 1, 0), nameof(PositionerTests.R1X1));
        }

        [TestMethod]
        public void TestPositioner_BendDown3Shapes()
        {
            PositionerTests.Run(PositionerTests.R1X1.Grow(3), PositionerTests.R1X1.Range(3), BendDownPos.WithRowsCols(1, 3), new []{PositionerTests.R1X1.Move(0, 0), PositionerTests.R1X1.Move(1, 2) , PositionerTests.R1X1.Move(2, 0) } , nameof(PositionerTests.R1X1));
        }

        [TestMethod]
        public void TestPositioner_BendDown4Shapes()
        {
            PositionerTests.Run(PositionerTests.R1X1.Grow(4), PositionerTests.R1X1.Range(4), BendDownPos.WithRowsCols(1, 4), new[] {PositionerTests.R1X1.Move(0, 0), PositionerTests.R1X1.Move(1, 3), PositionerTests.R1X1.Move(2, 3), PositionerTests.R1X1.Move(3, 0) }, nameof(PositionerTests.R1X1));
        }

        [TestMethod]
        public void TestPositioner_BendDown5Shapes()
        {
            PositionerTests.Run(PositionerTests.R1X1.Grow(5), PositionerTests.R1X1.Range(5), BendDownPos.WithRowsCols(1, 5), new[] {PositionerTests.R1X1.Move(0, 0), PositionerTests.R1X1.Move(1, 2), PositionerTests.R1X1.Move(2, 4), PositionerTests.R1X1.Move(3, 2), PositionerTests.R1X1.Move(4, 0) }, nameof(PositionerTests.R1X1));
        }

        [TestMethod]
        public void TestPositioner_BendDown6Shapes()
        {
            PositionerTests.Run(PositionerTests.R1X1.Grow(6), PositionerTests.R1X1.Range(6), BendDownPos.WithRowsCols(1, 6), new[] {PositionerTests.R1X1.Move(0, 0), PositionerTests.R1X1.Move(1, 2.5f), PositionerTests.R1X1.Move(2, 5), PositionerTests.R1X1.Move(3, 5), PositionerTests.R1X1.Move(4, 2.5f), PositionerTests.R1X1.Move(5, 0) }, nameof(PositionerTests.R1X1));
        }

        [TestMethod]
        public void TestPositioner_BendUp2Shapes()
        {
            PositionerTests.Run(PositionerTests.R1X1.Grow(2), PositionerTests.R1X1.Range(2), BendUpPos.WithRowsCols(1, 2), PositionerTests.R1X1.Move(0, 1).Range(2, 1, 0), nameof(PositionerTests.R1X1));
        }

        [TestMethod]
        public void TestPositioner_BendUp3Shapes()
        {
            PositionerTests.Run(PositionerTests.R1X1.Grow(3), PositionerTests.R1X1.Range(3), BendUpPos.WithRowsCols(1, 3), new[] {PositionerTests.R1X1.Move(0, 2), PositionerTests.R1X1.Move(1, 0), PositionerTests.R1X1.Move(2, 2) }, nameof(PositionerTests.R1X1));
        }

        [TestMethod]
        public void TestPositioner_BendUp4Shapes()
        {
            PositionerTests.Run(PositionerTests.R1X1.Grow(4), PositionerTests.R1X1.Range(4), BendUpPos.WithRowsCols(1, 4), new[] {PositionerTests.R1X1.Move(0, 3), PositionerTests.R1X1.Move(1, 0), PositionerTests.R1X1.Move(2, 0), PositionerTests.R1X1.Move(3, 3) }, nameof(PositionerTests.R1X1));
        }

        [TestMethod]
        public void TestPositioner_BendUp5Shapes()
        {
            PositionerTests.Run(PositionerTests.R1X1.Grow(5), PositionerTests.R1X1.Range(5), BendUpPos.WithRowsCols(1, 5), new[] {PositionerTests.R1X1.Move(0, 4), PositionerTests.R1X1.Move(1, 2), PositionerTests.R1X1.Move(2, 0), PositionerTests.R1X1.Move(3, 2), PositionerTests.R1X1.Move(4, 4) }, nameof(PositionerTests.R1X1));
        }

        [TestMethod]
        public void TestPositioner_BendUp6Shapes()
        {
            PositionerTests.Run(PositionerTests.R1X1.Grow(6), PositionerTests.R1X1.Range(6), BendUpPos.WithRowsCols(1, 6), new[] {PositionerTests.R1X1.Move(0, 5), PositionerTests.R1X1.Move(1, 2.5f), PositionerTests.R1X1.Move(2, 0), PositionerTests.R1X1.Move(3, 0), PositionerTests.R1X1.Move(4, 2.5f), PositionerTests.R1X1.Move(5, 5) }, nameof(PositionerTests.R1X1));
        }
    }
}
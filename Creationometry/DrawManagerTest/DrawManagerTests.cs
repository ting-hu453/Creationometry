using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Windows.Forms;
using Creationometry;
using System.Drawing;
using System.Collections.Generic;

namespace DrawManagerTest
{
    [TestClass]
    public class DrawManagerTests
    {


        [TestMethod]
        public void TestMethod1()
        {
            DrawManager drawer = new Creationometry.DrawManager();
            Assert.AreEqual(false, drawer.getIsDrawing());
        }

        [TestMethod]
        public void DrawPolygonTest_1()
        {
            DrawManager drawer = new Creationometry.DrawManager();
            drawer.drawPolygon();
            Assert.AreEqual(true, drawer.getIsDrawing());
        }

        [TestMethod]
        public void DrawPolygonTest_2()
        {
            DrawManager drawer = new Creationometry.DrawManager();
            drawer.setIsDrawing(true);
            drawer.drawPolygon();
            Assert.AreEqual(false, drawer.getIsDrawing());
        }

        [TestMethod]
        public void GetPointsTest()
        {
            DrawManager drawer = new Creationometry.DrawManager();
            System.Drawing.Point p = new System.Drawing.Point();
            Assert.AreEqual(drawer.getPoints()[0].X, p.X);
        }

        [TestMethod]
        public void AddPointTest()
        {
            DrawManager drawer = new Creationometry.DrawManager();

            drawer.drawPolygon();
            drawer.addPoint(10, 15);
            drawer.addPoint(15, 15);
            drawer.addPoint(20, 60);
            drawer.drawPolygon();

            System.Drawing.Point[] points = new System.Drawing.Point[3];
            points[0].X = 10;
            points[0].Y = 15;
            points[1].X = 15;
            points[1].Y = 15;
            points[2].X = 20;
            points[2].Y = 60;

            System.Drawing.Point[] resultArray = drawer.getPoints();

            CollectionAssert.AreEqual(points, resultArray);
        }


        //Note: Can't test DrawManager.addPoint method due to lack of access to appropriate MouseEventArgs parameter.
    }
}

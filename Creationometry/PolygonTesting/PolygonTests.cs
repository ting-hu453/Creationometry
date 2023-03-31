using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Creationometry;
using System.Drawing;
using System.Windows.Forms;

namespace PolygonTesting
{
    //------------------------------------------------------------------
    // Name:    Brandon Bandholz
    // Project: Creationometry
    // Purpose: This Test will test the methods of the Polygon and RegularPolygon Classes.
    //          All methods are covered in this test, except the methods 
    //          show (UI components), changeWeight (UI components), and
    //          calculatePoints (private). The forst two methods are covered by GUI
    //          testing, while calculatePoints is called in the RegularPolygon constructors.
    //------------------------------------------------------------------
    [TestClass]
    public class PolygonTests
    {
        //[TestMethod]
        //public void TestMethod1()
        //{
        //    RegularPolygon p = new RegularPolygon(50, 6);
        //    int side = p.distance(p.getPoints()[0], p.getPoints()[1]);
        //    Assert.AreEqual(side, p.getSideLength());
        //}


        [TestMethod]
        public void RegPolygonConstructorTest_1()
        {
            /*RegularPolygon p = new RegularPolygon(50, 6);
            System.Drawing.Point p2 = new System.Drawing.Point();
            p2.X = 200;
            p2.Y = 250;*/

            RegularPolygon p = new RegularPolygon(50, 6);
            System.Drawing.Point[] points = new System.Drawing.Point[6];
            points[0].X = 200;
            points[0].Y = 250;
            points[1].X = 157;
            points[1].Y = 225;
            points[2].X = 157;
            points[2].Y = 175;
            points[3].X = 200;
            points[3].Y = 150;
            points[4].X = 243;
            points[4].Y = 175;
            points[5].X = 243;
            points[5].Y = 225;

            //Assert.AreEqual(p.getPoints()[0], p2);//edit with CollectionAssert.Equal
            CollectionAssert.AreEqual(points, p.getPoints());
        }

        [TestMethod]
        public void RegPolygonConstructorTest_2()
        {
            RegularPolygon p = new RegularPolygon(50, 6);
            RegularPolygon p1 = new RegularPolygon(p);
            CollectionAssert.AreEqual(p.getPoints(), p1.getPoints());
        }

        [TestMethod]
        public void RegPolygonConstructorTest_3()
        {
            RegularPolygon p1 = new RegularPolygon();
            System.Drawing.Point point = new System.Drawing.Point();
            point.X = 200;
            point.Y = 200;
            Assert.AreEqual(point, p1.getCenter());
        }


        [TestMethod]
        public void RegPolygonConstructorTest_4()
        {
            RegularPolygon p1 = new RegularPolygon(true, false, false);
            Assert.AreEqual(5, p1.getNumSides());
        }


        [TestMethod]
        public void RegPolygonConstructorTest_5()
        {
            RegularPolygon p1 = new RegularPolygon(false, true, false);
            Assert.AreEqual(3, p1.getNumSides());
        }


        [TestMethod]
        public void RegPolygonConstructorTest_6()
        {
            RegularPolygon p1 = new RegularPolygon(false, false, true);
            Assert.AreEqual(4, p1.getNumSides());
        }

        [TestMethod]
        public void RegPolygonConstructorTest_7()
        {
            RegularPolygon p1 = new RegularPolygon(false, false, false);
            Assert.AreEqual(3, p1.getNumSides());
        }


        [TestMethod]
        public void RegPolygonConstructorTest_8()
        {
            RegularPolygon p = new RegularPolygon(50, 2);
            System.Drawing.Point[] points = new System.Drawing.Point[3];
            points[0].X = 200;
            points[0].Y = 229;
            points[1].X = 175;
            points[1].Y = 186;
            points[2].X = 225;
            points[2].Y = 186;
            CollectionAssert.AreEqual(points, p.getPoints());
        }

        [TestMethod]
        public void PolygonConstructorTest_1()
        {
            System.Drawing.Point[] points = new System.Drawing.Point[3];
            points[0].X = 5;
            points[0].Y = 10;
            points[1].X = 20;
            points[1].Y = 20;
            Polygon p = new Polygon(points);
            CollectionAssert.AreEqual(p.getPoints(), points);
        }

        [TestMethod]
        public void PolygonConstructorTest_2()
        {
            System.Drawing.Point[] points = new System.Drawing.Point[3];
            points[0].X = 0;
            points[0].Y = 0;
            points[1].X = 20;
            points[1].Y = 0;
            points[2].X = 10;
            points[2].Y = 10;

            Polygon p = new Polygon(points);

            Polygon p1 = new Polygon(p);
            CollectionAssert.AreEqual(p.getPoints(), p1.getPoints());
        }


        [TestMethod]
        public void PolygonConstructorTest_3()
        {
            Polygon p1 = new Polygon();
            Assert.AreEqual(3, p1.getNumSides());
        }


        [TestMethod]
        public void RegPolygonInnerAngleTest()
        {
            RegularPolygon p = new RegularPolygon(50, 5);
            Assert.AreEqual(p.innerAngleDeg(), 108);
        }

        [TestMethod]
        public void moveRegPolygonTest()
        {
            RegularPolygon p = new RegularPolygon(50, 5);
            System.Drawing.Point center = new System.Drawing.Point();
            center.X = 300;
            center.Y = 300;
            p.move(center.X, center.Y);
            Assert.AreEqual(p.getCenter(), center);
        }


        [TestMethod]
        public void movePolygonTest()
        {
            System.Drawing.Point[] points = new System.Drawing.Point[3];
            points[0].X = 0;
            points[0].Y = 0;
            points[1].X = 20;
            points[1].Y = 0;
            points[2].X = 10;
            points[2].Y = 10;

            Polygon p = new Polygon(points);


            System.Drawing.Point center = new System.Drawing.Point();
            center.X = 300;
            center.Y = 300;
            p.move(center.X, center.Y);

            System.Drawing.Point[] newPoints = new System.Drawing.Point[3];
            newPoints[0].X = 290;
            newPoints[0].Y = 295;
            newPoints[1].X = 310;
            newPoints[1].Y = 295;
            newPoints[2].X = 300;
            newPoints[2].Y = 305;

            CollectionAssert.AreEqual(p.getPoints(), newPoints);

        }

        [TestMethod]
        public void PolygonBorderColorTest()
        {
            Polygon p = new Polygon();
            p.changeColor(Color.Blue);

            Assert.AreEqual(Color.Blue, p.getBorderColor());
        }

        [TestMethod]
        public void RegPolygonBorderColorTest()
        {
            RegularPolygon p = new RegularPolygon();
            p.changeColor(Color.Blue);

            Assert.AreEqual(Color.Blue, p.getBorderColor());
        }

        [TestMethod]
        public void PolygonCalculateCenterTest()
        {
            System.Drawing.Point[] points = new System.Drawing.Point[3];
            points[0].X = 0;
            points[0].Y = 0;
            points[1].X = 20;
            points[1].Y = 0;
            points[2].X = 10;
            points[2].Y = 10;

            Polygon p = new Polygon(points);
            p.calculateCenter();

            System.Drawing.Point temp = new System.Drawing.Point();
            temp.X = 10;
            temp.Y = 5;

            Assert.AreEqual(temp, p.getCenter());


        }


        [TestMethod]
        public void PolygonCalculateCenterTest_2()
        {
            System.Drawing.Point[] points = new System.Drawing.Point[3];
            points[0].X = 10;
            points[0].Y = 10;
            points[1].X = 20;
            points[1].Y = 0;
            points[2].X = 0;
            points[2].Y = 0;

            Polygon p = new Polygon(points);
            p.calculateCenter();

            System.Drawing.Point temp = new System.Drawing.Point();
            temp.X = 10;
            temp.Y = 5;

            Assert.AreEqual(temp, p.getCenter());
        }


        [TestMethod]
        public void SetOrientationTest()
        {
            System.Drawing.Point[] points = new System.Drawing.Point[3];
            points[0].X = 0;
            points[0].Y = 0;
            points[1].X = 20;
            points[1].Y = 0;
            points[2].X = 10;
            points[2].Y = 10;

            Polygon p = new Polygon(points);
            p.setOrientationAngle(45);
            Assert.AreEqual(45, p.getOrientationAngle());
        }

        [TestMethod]
        public void GetLineWeightTest()
        {
            Polygon p = new Polygon();
            Assert.AreEqual(1, p.getLineWeight());
        }


        [TestMethod]
        public void PolygonMouseDownTrueTest()
        {
            System.Drawing.Point[] points = new System.Drawing.Point[3];
            points[0].X = 0;
            points[0].Y = 0;
            points[1].X = 20;
            points[1].Y = 0;
            points[2].X = 10;
            points[2].Y = 10;

            Polygon p = new Polygon(points);
            Assert.AreEqual(true, p.checkMouseDownSelection(10, 5));
        }

        [TestMethod]
        public void PolygonMouseDownFalseTest()
        {
            System.Drawing.Point[] points = new System.Drawing.Point[3];
            points[0].X = 0;
            points[0].Y = 0;
            points[1].X = 20;
            points[1].Y = 0;
            points[2].X = 10;
            points[2].Y = 10;

            Polygon p = new Polygon(points);

            Assert.AreEqual(false, p.checkMouseDownSelection(20, 20));
        }

        [TestMethod]
        public void RegPolygonMouseDownTrueTest()
        {
            RegularPolygon p = new RegularPolygon(50, 5);
            Assert.AreEqual(true, p.checkMouseDownSelection(200, 200));
        }

        [TestMethod]
        public void RegPolygonMouseDownFalseTest()
        {
            RegularPolygon p = new RegularPolygon(50, 5);
            Assert.AreEqual(false, p.checkMouseDownSelection(20, 20));
        }

        [TestMethod]
        public void PolygonSetIsSelectedTest()
        {
            System.Drawing.Point[] points = new System.Drawing.Point[3];
            points[0].X = 0;
            points[0].Y = 0;
            points[1].X = 20;
            points[1].Y = 0;
            points[2].X = 10;
            points[2].Y = 10;

            Polygon p = new Polygon(points);

            p.setIsSelected(true);
            Assert.AreEqual(true, p.getIsSelected());
        }

        [TestMethod]
        public void RegPolygonSetIsSelectedTest()
        {
            RegularPolygon p = new RegularPolygon(50, 5);

            p.setIsSelected(true);
            Assert.AreEqual(true, p.getIsSelected());
        }


        [TestMethod]
        public void PolygonDuplicationOffsetTest()
        {
            System.Drawing.Point[] points = new System.Drawing.Point[3];
            points[0].X = 0;
            points[0].Y = 0;
            points[1].X = 20;
            points[1].Y = 0;
            points[2].X = 10;
            points[2].Y = 10;

            Polygon p = new Polygon(points);
            p.duplicationOffset(10);

            Assert.AreEqual(10, p.getPoints()[0].X, 1);    //If one value offsets, all others do -> can't test all because variance is needed for floats.
        }


        [TestMethod]
        public void RegPolygonDuplicationOffsetTest()
        {
            RegularPolygon p = new RegularPolygon(50, 5); //Note: default center is (200, 200)
            p.duplicationOffset(10);

            System.Drawing.Point temp = new System.Drawing.Point();
            temp.X = 210;
            temp.Y = 210;

            Assert.AreEqual(temp, p.getCenter());
        }


        [TestMethod]
        public void PolygonRotateTest()
        {
            System.Drawing.Point[] points = new System.Drawing.Point[3];
            points[0].X = 0;
            points[0].Y = 0;
            points[1].X = 20;
            points[1].Y = 0;
            points[2].X = 10;
            points[2].Y = 10;

            Polygon p = new Polygon(points);

            p.rotateTransformAngle(30);
            Assert.AreEqual(30, p.getOrientationAngle(), .01); //Can't check GraphicsPath here....
        }

        [TestMethod]
        public void RegPolygonRotateTest()
        {
            RegularPolygon p = new RegularPolygon(50, 4);

            p.rotateTransformAngle(30);
            Assert.AreEqual(30, p.getOrientationAngle(), .01); //Can't check GraphicsPath here....
        }


        [TestMethod]
        public void PolygonChangeWeightTest_1()
        {
            Polygon p = new Polygon();
            TextBox expectedTextBox = new TextBox();
            Label expectedLabel = new Label();
            expectedTextBox.Text = "2";
            float expected = float.Parse(expectedTextBox.Text);
            p.changeWeight(expectedTextBox, expectedLabel);
            float actual = p.getLineWeight();
            Assert.AreEqual(expected, actual, 1, "Change the weight_Valid Number");
        }

        [TestMethod]
        public void PolygonChangeWeightTest_2()
        {
            Polygon p = new Polygon();
            TextBox expectedTextBox = new TextBox();
            Label expectedLabel = new Label();
            expectedTextBox.Text = "0";
            float expected = float.Parse(expectedTextBox.Text);
            p.changeWeight(expectedTextBox, expectedLabel);
            float actual = p.getLineWeight();
            Assert.AreEqual(expected, actual, 1, "Change the weight_Invalid Number");
        }

        [TestMethod]
        public void PolygonChangeWeightTest_3()
        {
            Polygon p = new Polygon();
            TextBox expectedTextBox = new TextBox();
            Label expectedLabel = new Label();
            expectedTextBox.Text = "";
            bool expected = true;
            p.changeWeight(expectedTextBox, expectedLabel);
            bool actual = expectedLabel.Visible;
            Assert.AreEqual(expected, actual, "Change the weight_Label");
        }

        [TestMethod]
        public void RegPolygonChangeWeightTest_1()
        {
            RegularPolygon p = new RegularPolygon();
            TextBox expectedTextBox = new TextBox();
            Label expectedLabel = new Label();
            expectedTextBox.Text = "2";
            float expected = float.Parse(expectedTextBox.Text);
            p.changeWeight(expectedTextBox, expectedLabel);
            float actual = p.getLineWeight();
            Assert.AreEqual(expected, actual, 1, "Change the weight_Valid Number");
        }

        [TestMethod]
        public void RegPolygonChangeWeightTest_2()
        {
            RegularPolygon p = new RegularPolygon();
            TextBox expectedTextBox = new TextBox();
            Label expectedLabel = new Label();
            expectedTextBox.Text = "0";
            float expected = float.Parse(expectedTextBox.Text);
            p.changeWeight(expectedTextBox, expectedLabel);
            float actual = p.getLineWeight();
            Assert.AreEqual(expected, actual, 1, "Change the weight_Invalid Number");
        }

        [TestMethod]
        public void RegPolygonChangeWeightTest_3()
        {
            RegularPolygon p = new RegularPolygon();
            TextBox expectedTextBox = new TextBox();
            Label expectedLabel = new Label();
            expectedTextBox.Text = "";
            bool expected = true;
            p.changeWeight(expectedTextBox, expectedLabel);
            bool actual = expectedLabel.Visible;
            Assert.AreEqual(expected, actual, "Change the weight_Label");
        }



        [TestMethod]
        public void RegPolygonNumSidesTest()
        {
            RegularPolygon p = new RegularPolygon(50, 4);
            Assert.AreEqual(p.getNumSides(), 4);
        }

        [TestMethod]
        public void RegPolygonSideLengthTest()
        {
            RegularPolygon p = new RegularPolygon(50, 4);
            p.setSideLength(75);
            Assert.AreEqual(p.getSideLength(), 75);
        }
    }
}

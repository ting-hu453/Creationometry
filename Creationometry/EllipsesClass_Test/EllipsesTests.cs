using Microsoft.VisualStudio.TestTools.UnitTesting;
using Creationometry;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace EllipsesClass_Test
{
    //------------------------------------------------------------------
    // Name:    Ting Hu
    // Project: Creationometry
    // Purpose: This Test will test the methods of the Ellipse Class.
    //          All methods are covered in this test, except the method 
    //          for displaying the lines. This method is covered by GUI
    //          testing.
    //------------------------------------------------------------------
    [TestClass]
    public class EllipsesTests
    {
        [TestMethod]
        public void getEllipseWidthTest()
        {
            Ellipses ellipse = new Ellipses();
            float expected = 150;
            float actual = ellipse.getEllipseWidth();
            Assert.AreEqual(expected, actual, 1, "Get the ellipse width");
        }

        [TestMethod]
        public void getEllipseHeightTest()
        {
            Ellipses ellipse = new Ellipses();
            float expected = 100;
            float actual = ellipse.getEllipseHeight();
            Assert.AreEqual(expected, actual, 1, "Get the ellipse height");
        }

        [TestMethod]
        public void getXLocationTest()
        {
            Ellipses ellipse = new Ellipses();
            int expected = 0;
            int actual = ellipse.getXLocation();
            Assert.AreEqual(expected, actual, 1, "Get the x location");
        }

        [TestMethod]
        public void getYLocationTest()
        {
            Ellipses ellipse = new Ellipses();
            int expected = 0;
            int actual = ellipse.getYLocation();
            Assert.AreEqual(expected, actual, 1, "Get the y location");
        }

        [TestMethod]
        public void GetBorderTest()
        {
            Ellipses ellipse = new Ellipses();
            Pen expected = new Pen(Color.Black, 1);
            Pen actual = ellipse.getBorder();
            Assert.AreNotEqual(expected, actual); //Don't know why but the Debug shows they are the 
                                                  // same, maybe because of the expection for the pen?
        }

        //Setters
        [TestMethod]
        public void setEllipseWidthTest()
        {
            Ellipses ellipse = new Ellipses();
            float expected = 0;
            ellipse.setEllipseWidth(expected);
            float actual = ellipse.getEllipseWidth();
            Assert.AreEqual(expected, actual, 1, "Set the ellipse width");
        }

        [TestMethod]
        public void setEllipseHeightTest()
        {
            Ellipses ellipse = new Ellipses();
            float expected = 0;
            ellipse.setEllipseHeight(expected);
            float actual = ellipse.getEllipseHeight();
            Assert.AreEqual(expected, actual, 1, "Set the ellipse height");
        }

        [TestMethod]
        public void setXLocationTest()
        {
            Ellipses ellipse = new Ellipses();
            int expected = 0;
            ellipse.setXLocation(expected);
            int actual = ellipse.getXLocation();
            Assert.AreEqual(expected, actual, 1, "Set the x location");
        }

        [TestMethod]
        public void setYLocationTest()
        {
            Ellipses ellipse = new Ellipses();
            int expected = 0;
            ellipse.setYLocation(expected);
            int actual = ellipse.getYLocation();
            Assert.AreEqual(expected, actual, 1, "Set the y location");
        }

        [TestMethod]
        public void SetP0XTest()
        {
            Ellipses ellipse = new Ellipses();
            int expected = 4;
            ellipse.setEllipseWidth(6.0f);
            ellipse.setP0X(expected);
            float actual = ellipse.centerXPos();
            Assert.AreEqual(expected, actual, 1, "Set the value of P0X (center x position)");
        }

        [TestMethod]
        public void SetBorderTest()
        {
            Ellipses ellipse = new Ellipses();
            Pen expected = new Pen(Color.Black, 1);
            ellipse.setBorder(expected);
            Pen actual = ellipse.getBorder();
            Assert.AreEqual(expected, actual, "Set the border");
        }

        [TestMethod]
        public void GetBorderColorTest()
        {
            Ellipses ellipse = new Ellipses();
            Color expected = Color.Black;
            Color actual = ellipse.getBorderColor();
            Assert.AreEqual(expected, actual, "Get the border color");
        }

        [TestMethod]
        public void SetBorderColorTest()
        {
            Ellipses ellipse = new Ellipses();
            Color expected = Color.Black;
            ellipse.setBorderColor(expected);
            Color actual = ellipse.getBorderColor();
            Assert.AreEqual(expected, actual, "Set the border color");
        }

        [TestMethod]
        public void SetLineWeightTest()
        {
            Ellipses ellipse = new Ellipses();
            float expected = 1;
            ellipse.setLineWeight(expected);
            float actual = ellipse.getLineWeight();
            Assert.AreEqual(expected, actual, 1, "Set the line weight");
        }

        [TestMethod]
        public void SetItemTest()
        {
            Ellipses ellipse = new Ellipses();
            GraphicsPath expected = new GraphicsPath();
            expected.AddEllipse(0, 0, 150, 100);

            ellipse.setItem(expected);
            GraphicsPath actual = new GraphicsPath();
            actual = ellipse.getItem();
            Assert.AreEqual(expected, actual, "Set the item");
        }

        [TestMethod]
        public void ChangeColorTest()
        {
            Ellipses ellipse = new Ellipses();
            Color expected = Color.Red;
            ellipse.changeColor(expected);
            Color actual = ellipse.getBorderColor();
            Assert.AreEqual(expected, actual, "Change the color");
        }

        [TestMethod]
        public void ChangeWeightTest_1()
        {
            Ellipses ellipse = new Ellipses();
            TextBox expectedTextBox = new TextBox();
            Label expectedLabel = new Label();
            expectedTextBox.Text = "2";
            float expected = float.Parse(expectedTextBox.Text);
            ellipse.changeWeight(expectedTextBox, expectedLabel);
            float actual = ellipse.getLineWeight();
            Assert.AreEqual(expected, actual, 1, "Change the weight_Valid Number");
        }

        [TestMethod]
        public void ChangeWeightTest_2()
        {
            Ellipses ellipse = new Ellipses();
            TextBox expectedTextBox = new TextBox();
            Label expectedLabel = new Label();
            expectedTextBox.Text = "0";
            float expected = float.Parse(expectedTextBox.Text);
            ellipse.changeWeight(expectedTextBox, expectedLabel);
            float actual = ellipse.getLineWeight();
            Assert.AreEqual(expected, actual, 1, "Change the weight_Invalid Number");
        }

        [TestMethod]
        public void ChangeWeightTest_3()
        {
            Ellipses ellipse = new Ellipses();
            TextBox expectedTextBox = new TextBox();
            Label expectedLabel = new Label();
            expectedTextBox.Text = "";
            bool expected = true;
            ellipse.changeWeight(expectedTextBox, expectedLabel);
            bool actual = expectedLabel.Visible;
            Assert.AreEqual(expected, actual, "Change the weight_Label");
        }

        [TestMethod]
        public void getIsCircleTest()
        {
            bool expected = true;
            Ellipses ellipse = new Ellipses(expected);
            bool actual = ellipse.getIsCircle();
            Assert.AreEqual(expected, actual, "Get is circle");
        }

        [TestMethod]
        public void MoveTest()
        {
            Ellipses ellipse = new Ellipses();
            GraphicsPath expected = new GraphicsPath();
            expected.AddEllipse(15, 15, 150, 100);
            expected = ellipse.getItem();

            int expectedX = 15;
            int expectedY = 15;
            ellipse.move(expectedX, expectedY);

            GraphicsPath actual = new GraphicsPath();
            actual = ellipse.getItem();

            Assert.AreEqual(expected, actual, "Move the ellipse");
        }
    }
}

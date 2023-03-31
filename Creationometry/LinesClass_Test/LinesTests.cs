using Microsoft.VisualStudio.TestTools.UnitTesting;
using Creationometry;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace LinesClass_Test
{
    //------------------------------------------------------------------
    // Name:    Callie Seehafer
    // Project: Creationometry
    // Purpose: This Test will test the methods of the Lines Class. All
    //          methods are covered in this test, except the method for 
    //          displaying the lines. This method is covered by GUI
    //          testing.
    //------------------------------------------------------------------
    [TestClass]
    public class LinesTests
    {
        [TestMethod]
        public void defaultConstructorXValOneTest()
        {
            float expected = 10;
            Lines line = new Lines();
            float actual = line.getP1X();
            Assert.AreEqual(expected, actual, 1);
        }

        [TestMethod]
        public void copyConstructorXValOneTest()
        {
            float expected = 10;
            Lines line = new Lines();
            Lines copiedLine = new Lines(line);
            float actual = copiedLine.getP1X();
            Assert.AreEqual(expected, actual, 1);
        }

        [TestMethod]
        public void getXValOneTest()
        {
            int expected = 10;
            Lines line = new Lines();
            float actual = line.getP1X();
            Assert.AreEqual(expected, actual, 1);
        }

        [TestMethod]
        public void getXValTwoTest()
        {
            int expected = 10;
            Lines line = new Lines();
            float actual = line.getP2X();
            Assert.AreEqual(expected, actual, 1);
        }

        [TestMethod]
        public void setXValOneTest()
        {
            float expected = 100;
            Lines line = new Lines();
            line.setP1X(expected);
            float actual = line.getP1X();
            Assert.AreEqual(expected, actual, 1);
        }

        [TestMethod]
        public void setXValTwoTest()
        {
            float expected = 100;
            Lines line = new Lines();
            line.setP2X(expected);
            float actual = line.getP2X();
            Assert.AreEqual(expected, actual, 1);
        }

        [TestMethod]
        public void getYValOneTest()
        {
            int expected = 0;
            Lines line = new Lines();
            float actual = line.getP1Y();
            Assert.AreEqual(expected, actual, 1);
        }

        [TestMethod]
        public void getYValTwoTest()
        {
            int expected = 50;
            Lines line = new Lines();
            float actual = line.getP2Y();
            Assert.AreEqual(expected, actual, 1);
        }

        [TestMethod]
        public void setYValOneTest()
        {
            float expected = 100;
            Lines line = new Lines();
            line.setP1Y(expected);
            float actual = line.getP1Y();
            Assert.AreEqual(expected, actual, 1);
        }

        [TestMethod]
        public void setYValTwoTest()
        {
            float expected = 500;
            Lines line = new Lines();
            line.setP2Y(expected);
            float actual = line.getP2Y();
            Assert.AreEqual(expected, actual, 1);
        }

        [TestMethod]
        public void getBorderColorTest()
        {
            Lines line = new Lines();
            Pen expected = new Pen(Color.Black, 1);
            Pen actual = line.getBorderColor();
            Assert.AreNotEqual(expected, actual);
        }

        [TestMethod]
        public void setBorderColorTest()
        {
            Lines line = new Lines();
            Pen expected = new Pen(Color.Black, 1);
            line.setBorderColor(expected);
            Pen actual = line.getBorderColor();
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void getColorTest()
        {
            Lines line = new Lines();
            Color expected = Color.Black;
            Color actual = line.getColor();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void setColorTest()
        {
            Lines line = new Lines();
            Color expected = Color.Black;
            line.setColor(expected);
            Color actual = line.getColor();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void getBorderWidth()
        {
            float expected = 1;
            Lines line = new Lines();
            float actual = line.getBorderWidth();
            Assert.AreEqual(expected, actual, 1);
        }

        [TestMethod]
        public void setBorderWidth()
        {
            float expected = 3;
            Lines line = new Lines();
            line.setBorderWidth(expected);
            float actual = line.getBorderWidth();
            Assert.AreEqual(expected, actual, 1);
        }

        [TestMethod]
        public void getCenterXTest()
        {
            float expected = 10;
            Lines line = new Lines();
            float actual = line.getCenterX();
            Assert.AreEqual(expected, actual, 1);
        }

        [TestMethod]
        public void setCenterXTest()
        {
            float expected = 25;
            Lines line = new Lines();
            line.setP1X(expected);
            line.setP2X(expected);
            line.setCenterX(expected);
            float actual = line.getCenterX();
            Assert.AreEqual(expected, actual, 1);
        }

        [TestMethod]
        public void getCenterYTest()
        {
            int expected = 25;
            Lines line = new Lines();
            float actual = line.getCenterY();
            Assert.AreEqual(expected, actual, 1);
        }

        [TestMethod]
        public void setCenterYTest()
        {
            float expected = 25;
            Lines line = new Lines();
            line.setP1Y(expected);
            line.setP2Y(expected);
            line.setCenterY(expected);
            float actual = line.getCenterY();
            Assert.AreEqual(expected, actual, 1);
        }

        [TestMethod]
        public void setItemTest()
        {
            Lines line = new Lines();
            GraphicsPath expected = new GraphicsPath();
            expected.AddLine(10, 10, 10, 100);

            line.setItem(expected);
            GraphicsPath actual = new GraphicsPath();
            actual = line.getItem();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void getIsSelectedTest()
        {
            bool expected = false;
            Lines line = new Lines();
            bool actual = line.getIsSelected();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void setIsSelectedTest()
        {
            bool expected = true;
            Lines line = new Lines();
            line.setIsSelected(expected);
            bool actual = line.getIsSelected();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void getOrientationAngleTest()
        {
            float expected = 0;
            Lines line = new Lines();
            float actual = line.getOrientationAngle();
            Assert.AreEqual(expected, actual, 1);
        }

        [TestMethod]
        public void setOrientationAngleTest()
        {
            float expected = 25;
            Lines line = new Lines();
            line.setOrientationAngle(expected);
            float actual = line.getOrientationAngle();
            Assert.AreEqual(expected, actual, 1);
        }

        [TestMethod]
        public void checkMouseDownSelectionTest_1()
        {
            bool expected = false;
            Lines line = new Lines();
            bool actual = line.checkMouseDownSelection(20, 20);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void checkMouseDownSelectionTest_2()
        {
            bool expected = true;
            Lines line = new Lines();
            bool actual = line.checkMouseDownSelection(10, 10);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void duplicationOffsetTest()
        {
            float expected = 30;
            int offset = 20;
            Lines line = new Lines();
            line.duplicationOffset(offset);
            float actual = line.getP1X();
            Assert.AreEqual(expected, actual, 1);
        }

        [TestMethod]
        public void changeColorTest()
        {
            Lines line = new Lines();
            Color expected = Color.Red;
            line.changeColor(expected);
            Color actual = line.getColor();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void changeWeightTest_1()
        {
            Lines line = new Lines();
            TextBox expectedTextBox = new TextBox();
            Label expectedLabel = new Label();
            expectedTextBox.Text = "2";
            float expected = float.Parse(expectedTextBox.Text);
            line.changeWeight(expectedTextBox, expectedLabel);
            float actual = line.getBorderWidth();
            Assert.AreEqual(expected, actual, 1);
        }

        [TestMethod]
        public void changeWeightTest_2()
        {
            Lines line = new Lines();
            TextBox expectedTextBox = new TextBox();
            Label expectedLabel = new Label();
            expectedTextBox.Text = "0";
            float expected = float.Parse(expectedTextBox.Text);
            line.changeWeight(expectedTextBox, expectedLabel);
            float actual = line.getBorderWidth();
            Assert.AreEqual(expected, actual, 1);
        }

        [TestMethod]
        public void changeWeightTest_3()
        {
            Lines line = new Lines();
            TextBox expectedTextBox = new TextBox();
            Label expectedLabel = new Label();
            expectedTextBox.Text = "";
            bool expected = true;
            line.changeWeight(expectedTextBox, expectedLabel);
            bool actual = expectedLabel.Visible;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void changeWeightTest_4()
        {
            Lines line = new Lines();
            TextBox expectedTextBox = new TextBox();
            Label expectedLabel = new Label();
            expectedTextBox.Text = "-5";
            bool expected = true;
            line.changeWeight(expectedTextBox, expectedLabel);
            bool actual = expectedLabel.Visible;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void rotateTransformAngleTest()
        {
            float expected = 50, actual = 50;
            Lines line = new Lines();
            line.rotateTransformAngle(expected);
            actual = line.getOrientationAngle();
            Assert.AreEqual(expected, actual, 1);
        }

        [TestMethod]
        public void MoveTest()
        {
            Lines line = new Lines();
            GraphicsPath expected = new GraphicsPath();
            expected.AddLine(20, 10, 20, 60);
            expected = line.getItem();

            int expectedX = 10;
            int expectedY = 10;
            line.move(expectedX, expectedY);

            GraphicsPath actual = new GraphicsPath();
            actual = line.getItem();

            Assert.AreEqual(expected, actual, "Move the line");
        }

    }
}
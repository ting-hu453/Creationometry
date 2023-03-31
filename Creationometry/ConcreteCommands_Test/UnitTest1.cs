using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Creationometry;
using System.Windows.Forms;
using System.Drawing;

namespace Command_Test
{
    //------------------------------------------------------------------
    // Name:    Megan Baxter
    // Project: Creationometry
    // Purpose: This Test will test the methods of the AddCommand Class.
    //------------------------------------------------------------------
    [TestClass]
    public class AddCommandTest
    {
        [TestMethod]
        public void executeTest()
        {
            CanvasElementList elementList = new CanvasElementList();
            ICommand addCommand = new AddCommand(elementList);
            Assert.AreEqual(false, addCommand.execute());
        }

        [TestMethod]
        public void partialParamxecuteTest()
        {
            CanvasElementList elementList = new CanvasElementList();
            ICommand addCommand = new AddCommand(elementList);
            Assert.AreEqual(false, addCommand.execute(null));
        }

        [TestMethod]
        public void circleParamExecuteTest()
        {
            CanvasElementList elementList = new CanvasElementList();
            ICommand addCommand = new AddCommand(elementList);
            addCommand.execute(DesignElementTypes.CIRCLE, null);
            Assert.AreEqual(true, typeof(Ellipses).IsInstanceOfType(elementList.getElement(0)));
        }

        [TestMethod]
        public void ellipseParamExecuteTest()
        {
            CanvasElementList elementList = new CanvasElementList();
            ICommand addCommand = new AddCommand(elementList);
            addCommand.execute(DesignElementTypes.ELLIPSE, null);
            Assert.AreEqual(true, typeof(Ellipses).IsInstanceOfType(elementList.getElement(0)));
        }

        [TestMethod]
        public void lineParamExecuteTest()
        {
            CanvasElementList elementList = new CanvasElementList();
            ICommand addCommand = new AddCommand(elementList);
            addCommand.execute(DesignElementTypes.LINE, null);
            Assert.AreEqual(true, typeof(Lines).IsInstanceOfType(elementList.getElement(0)));
        }

        [TestMethod]
        public void regPolyParamExecuteTest()
        {
            CanvasElementList elementList = new CanvasElementList();
            ICommand addCommand = new AddCommand(elementList);
            addCommand.execute(DesignElementTypes.REG_POLYGON, null);
            Assert.AreEqual(true, typeof(RegularPolygon).IsInstanceOfType(elementList.getElement(0)));
        }

        [TestMethod]
        public void triangleParamExecuteTest()
        {
            CanvasElementList elementList = new CanvasElementList();
            ICommand addCommand = new AddCommand(elementList);
            addCommand.execute(DesignElementTypes.TRIANGLE, null);
            Assert.AreEqual(true, typeof(RegularPolygon).IsInstanceOfType(elementList.getElement(0)));
        }

        [TestMethod]
        public void rectangleParamExecuteTest()
        {
            CanvasElementList elementList = new CanvasElementList();
            ICommand addCommand = new AddCommand(elementList);
            addCommand.execute(DesignElementTypes.RECTANGLE, null);
            Assert.AreEqual(true, typeof(RegularPolygon).IsInstanceOfType(elementList.getElement(0)));
        }

        [TestMethod]
        public void drawnPolyParamExecuteTest()
        {
            CanvasElementList elementList = new CanvasElementList();
            ICommand addCommand = new AddCommand(elementList);
            System.Drawing.Point[] points = { new System.Drawing.Point(0,0), new System.Drawing.Point(0,5),
                new System.Drawing.Point(5, 5), new System.Drawing.Point(5, 0) };
            addCommand.execute(DesignElementTypes.DRAWN_POLYGON, points);
            Assert.AreEqual(true, typeof(Polygon).IsInstanceOfType(elementList.getElement(0)));
        }

        [TestMethod]
        public void nullParamExecuteTest()
        {
            CanvasElementList elementList = new CanvasElementList();
            ICommand addCommand = new AddCommand(elementList);
            Assert.AreEqual(false, addCommand.execute(DesignElementTypes.NONE, null));
        }

        [TestMethod]
        public void undoTest()
        {
            CanvasElementList elementList = new CanvasElementList();
            ICommand addCommand = new AddCommand(elementList);
            System.Drawing.Point[] points = null;
            addCommand.execute(DesignElementTypes.ELLIPSE, points);
            addCommand.undo();
            Assert.AreEqual(0, elementList.getListSize());
        }

        [TestMethod]
        public void redoTest()
        {
            CanvasElementList elementList = new CanvasElementList();
            ICommand addCommand = new AddCommand(elementList);
            System.Drawing.Point[] points = null;
            addCommand.execute(DesignElementTypes.ELLIPSE, points);
            addCommand.undo();
            addCommand.redo();
            Assert.AreEqual(1, elementList.getListSize());
        }

        [TestMethod]
        public void copyElementStateTest()
        {
            CanvasElementList elementList = new CanvasElementList();
            ICommand addCommand = new AddCommand(elementList);
            DesignElement obj1 = new Polygon();
            DesignElement obj2 = addCommand.copyElementState(obj1);

            Assert.AreEqual(true, typeof(Polygon).IsInstanceOfType(obj2));
        }
    }

    //------------------------------------------------------------------
    // Name:    Megan Baxter
    // Project: Creationometry
    // Purpose: This Test will test the methods of the
    //          CanvasColorCommand Class. Only able to test non-GUI
    //          methods.
    //------------------------------------------------------------------
    [TestClass]
    public class CanvasColorCommandTest
    {
        [TestMethod]
        public void partialParamExecuteTest()
        {
            Panel Canvas = new Panel();
            ICommand canvasColorCommand = new CanvasColorCommand(Canvas);
            Assert.AreEqual(false, canvasColorCommand.execute(null));
        }

        [TestMethod]
        public void paramExecuteTest()
        {
            Panel Canvas = new Panel();
            ICommand canvasColorCommand = new CanvasColorCommand(Canvas);
            Assert.AreEqual(false, canvasColorCommand.execute(DesignElementTypes.CIRCLE, null));
        }

        [TestMethod]
        public void emptyUndoTest()
        {
            Panel Canvas = new Panel();
            ICommand canvasColorCommand = new CanvasColorCommand(Canvas);

            canvasColorCommand.undo();
            Assert.AreEqual(Color.White, Canvas.BackColor);
        }

        [TestMethod]
        public void undoTest()
        {
            Panel Canvas = new Panel();
            ICommand canvasColorCommand = new CanvasColorCommand(Canvas);

            Canvas.BackColor = Color.Black;
            canvasColorCommand.redo();
            canvasColorCommand.undo();
            Assert.AreEqual(Color.Black, Canvas.BackColor);
        }

        [TestMethod]
        public void emptyRedoTest()
        {
            Panel Canvas = new Panel();
            ICommand canvasColorCommand = new CanvasColorCommand(Canvas);

            canvasColorCommand.redo();
            Assert.AreEqual(Color.White, Canvas.BackColor);
        }

        [TestMethod]
        public void redoTest()
        {
            Panel Canvas = new Panel();
            ICommand canvasColorCommand = new CanvasColorCommand(Canvas);

            Canvas.BackColor = Color.Red;
            canvasColorCommand.undo();
            canvasColorCommand.redo();
            Assert.AreEqual(Color.Red, Canvas.BackColor);
        }


        [TestMethod]
        public void copyElementTest()
        {
            Panel Canvas = new Panel();
            ICommand canvasColorCommand = new CanvasColorCommand(Canvas);
            DesignElement obj1 = new Ellipses();
            Assert.AreEqual(null, canvasColorCommand.copyElementState(obj1));
        }
    }

    //------------------------------------------------------------------
    // Name:    Megan Baxter
    // Project: Creationometry
    // Purpose: This Test will test the methods of the DuplicateCommand
    //          Class.
    //------------------------------------------------------------------
    [TestClass]
    public class DuplicateCommandTest
    {
        [TestMethod]
        public void nullExecuteTest()
        {
            CanvasElementList elementList = new CanvasElementList();
            ICommand addCommand = new AddCommand(elementList);
            ICommand duplicateCommand = new DuplicateCommand(elementList);

            //Add an element to be duplicated
            System.Drawing.Point[] points = null;
            addCommand.execute(DesignElementTypes.NONE, points);

            Assert.AreEqual(false, duplicateCommand.execute());
        }

        [TestMethod]
        public void partialParamExecuteTest()
        {
            CanvasElementList elementList = new CanvasElementList();
            ICommand addCommand = new AddCommand(elementList);
            ICommand duplicateCommand = new DuplicateCommand(elementList);

            Assert.AreEqual(false, duplicateCommand.execute(null));
        }

        [TestMethod]
        public void paramExecuteTest()
        {
            CanvasElementList elementList = new CanvasElementList();
            ICommand addCommand = new AddCommand(elementList);
            ICommand duplicateCommand = new DuplicateCommand(elementList);

            Assert.AreEqual(false, duplicateCommand.execute(DesignElementTypes.CIRCLE, null));
        }

        [TestMethod]
        public void ellipseExecuteTest()
        {
            const int DUP_ELEMENT_IDX = 1;
            CanvasElementList elementList = new CanvasElementList();
            ICommand addCommand = new AddCommand(elementList);
            ICommand duplicateCommand = new DuplicateCommand(elementList);

            //Add an element to be duplicated
            System.Drawing.Point[] points = null;
            addCommand.execute(DesignElementTypes.ELLIPSE, points);

            //Select the element
            elementList.getElement(0).setIsSelected(true);

            //Duplicate the element
            duplicateCommand.execute();

            Assert.AreEqual(true, typeof(Ellipses).IsInstanceOfType(elementList.getElement(DUP_ELEMENT_IDX)));
        }

        [TestMethod]
        public void linesExecuteTest()
        {
            const int DUP_ELEMENT_IDX = 1;
            CanvasElementList elementList = new CanvasElementList();
            ICommand addCommand = new AddCommand(elementList);
            ICommand duplicateCommand = new DuplicateCommand(elementList);

            //Add an element to be duplicated
            System.Drawing.Point[] points = null;
            addCommand.execute(DesignElementTypes.LINE, points);

            //Select the element
            elementList.getElement(0).setIsSelected(true);

            //Duplicate the element
            duplicateCommand.execute();

            Assert.AreEqual(true, typeof(Lines).IsInstanceOfType(elementList.getElement(DUP_ELEMENT_IDX)));
        }

        [TestMethod]
        public void regPolyExecuteTest()
        {
            const int DUP_ELEMENT_IDX = 1;
            CanvasElementList elementList = new CanvasElementList();
            ICommand addCommand = new AddCommand(elementList);
            ICommand duplicateCommand = new DuplicateCommand(elementList);

            //Add an element to be duplicated
            System.Drawing.Point[] points = null;
            addCommand.execute(DesignElementTypes.REG_POLYGON, points);

            //Select the element
            elementList.getElement(0).setIsSelected(true);

            //Duplicate the element
            duplicateCommand.execute();

            Assert.AreEqual(true, typeof(RegularPolygon).IsInstanceOfType(elementList.getElement(DUP_ELEMENT_IDX)));
        }

        [TestMethod]
        public void drawnPolyExecuteTest()
        {
            const int DUP_ELEMENT_IDX = 1;
            CanvasElementList elementList = new CanvasElementList();
            ICommand addCommand = new AddCommand(elementList);
            ICommand duplicateCommand = new DuplicateCommand(elementList);

            //Add an element to be duplicated
            System.Drawing.Point[] points = { new System.Drawing.Point(0,0), new System.Drawing.Point(0,5),
                new System.Drawing.Point(5, 5), new System.Drawing.Point(5, 0) };
            addCommand.execute(DesignElementTypes.DRAWN_POLYGON, points);

            //Select the element
            elementList.getElement(0).setIsSelected(true);

            //Duplicate the element
            duplicateCommand.execute();

            Assert.AreEqual(true, typeof(Polygon).IsInstanceOfType(elementList.getElement(DUP_ELEMENT_IDX)));
        }

        [TestMethod]
        public void undoTest()
        {
            CanvasElementList elementList = new CanvasElementList();
            ICommand addCommand = new AddCommand(elementList);
            ICommand duplicateCommand = new DuplicateCommand(elementList);

            //Add an element to be duplicated
            System.Drawing.Point[] points = null;
            addCommand.execute(DesignElementTypes.ELLIPSE, points);

            //Select the element
            elementList.getElement(0).setIsSelected(true);

            //Duplicate the element and undo it
            duplicateCommand.execute();
            duplicateCommand.undo();

            Assert.AreEqual(1, elementList.getListSize());
        }

        [TestMethod]
        public void redoTest()
        {
            const int DUP_ELEMENT_IDX = 1;
            CanvasElementList elementList = new CanvasElementList();
            ICommand addCommand = new AddCommand(elementList);
            ICommand duplicateCommand = new DuplicateCommand(elementList);

            //Add an element to be duplicated
            System.Drawing.Point[] points = null;
            addCommand.execute(DesignElementTypes.ELLIPSE, points);

            //Select the element
            elementList.getElement(0).setIsSelected(true);

            //Duplicate the element, undo it, and then redo it
            duplicateCommand.execute();
            duplicateCommand.undo();
            duplicateCommand.redo();

            Assert.AreEqual(true, typeof(Ellipses).IsInstanceOfType(elementList.getElement(DUP_ELEMENT_IDX)));
        }

        [TestMethod]
        public void copyElementTest()
        {
            DesignElement obj1 = new Ellipses();
            CanvasElementList elementList = new CanvasElementList();
            ICommand duplicateCommand = new DuplicateCommand(elementList);
            Assert.AreEqual(null, duplicateCommand.copyElementState(obj1));
        }
    }

    //------------------------------------------------------------------
    // Name:    Megan Baxter
    // Project: Creationometry
    // Purpose: This Test will test the methods of the
    //          ModifyElementCommand Class.
    //------------------------------------------------------------------
    [TestClass]
    public class ModifyElementCommandTest
    {
        [TestMethod]
        public void executeTest()
        {
            CanvasElementList elementList = new CanvasElementList();
            ICommand modifyCommand = new ModifyElementCommand(elementList);

            Assert.AreEqual(false, modifyCommand.execute());
        }

        [TestMethod]
        public void nullPartialParamExecuteTest()
        {
            CanvasElementList elementList = new CanvasElementList();
            ICommand modifyCommand = new ModifyElementCommand(elementList);

            DesignElement selectedElement = null;

            Assert.AreEqual(false, modifyCommand.execute(selectedElement));
        }

        [TestMethod]
        public void partialParamExecuteTest()
        {
            CanvasElementList elementList = new CanvasElementList();
            ICommand modifyCommand = new ModifyElementCommand(elementList);
            ICommand addCommand = new AddCommand(elementList);

            addCommand.execute(DesignElementTypes.ELLIPSE, null);
            elementList.getElement(0).setIsSelected(true);

            DesignElement selectedElement = elementList.getSelectedElement();

            Assert.AreEqual(true, modifyCommand.execute(selectedElement));
        }

        [TestMethod]
        public void paramExecuteTest()
        {
            CanvasElementList elementList = new CanvasElementList();
            ICommand modifyCommand = new ModifyElementCommand(elementList);

            Assert.AreEqual(false, modifyCommand.execute(DesignElementTypes.CIRCLE, null));
        }

        [TestMethod]
        public void emptyUndoTest()
        {
            CanvasElementList elementList = new CanvasElementList();
            ICommand addCommand = new AddCommand(elementList);
            ICommand modifyCommand = new ModifyElementCommand(elementList);

            //Add an element to be modified
            addCommand.execute(DesignElementTypes.ELLIPSE, null);

            //Select the element
            elementList.getElement(0).setIsSelected(true);

            modifyCommand.undo();

            Assert.AreEqual(false, elementList.getElement(0).getIsSelected());
        }

        [TestMethod]
        public void undoTest()
        {
            CanvasElementList elementList = new CanvasElementList();
            ICommand addCommand = new AddCommand(elementList);
            ICommand modifyCommand = new ModifyElementCommand(elementList);

            //Add an element to be modified
            addCommand.execute(DesignElementTypes.ELLIPSE, null);

            //Select the element
            elementList.getElement(0).setIsSelected(true);
            DesignElement selectedElement = elementList.getSelectedElement();

            modifyCommand.execute(selectedElement);

            elementList.getElement(0).setOrientationAngle(90);

            modifyCommand.undo();

            Assert.AreEqual(0, elementList.getElement(0).getOrientationAngle());
        }

        [TestMethod]
        public void emptyRedoTest()
        {
            CanvasElementList elementList = new CanvasElementList();
            ICommand addCommand = new AddCommand(elementList);
            ICommand modifyCommand = new ModifyElementCommand(elementList);

            //Add an element to be modified
            addCommand.execute(DesignElementTypes.ELLIPSE, null);

            //Select the element
            elementList.getElement(0).setIsSelected(true);

            modifyCommand.redo();

            Assert.AreEqual(false, elementList.getElement(0).getIsSelected());
        }

        [TestMethod]
        public void redoTest()
        {
            CanvasElementList elementList = new CanvasElementList();
            ICommand addCommand = new AddCommand(elementList);
            ICommand modifyCommand = new ModifyElementCommand(elementList);

            //Add an element to be modified
            addCommand.execute(DesignElementTypes.ELLIPSE, null);

            //Select the element
            elementList.getElement(0).setIsSelected(true);
            DesignElement selectedElement = elementList.getSelectedElement();

            modifyCommand.execute(selectedElement);

            elementList.getElement(0).setOrientationAngle(90);

            modifyCommand.undo();
            modifyCommand.redo();

            Assert.AreEqual(90, elementList.getElement(0).getOrientationAngle());
        }

        [TestMethod]
        public void linesCopyElementStateTest()
        {
            CanvasElementList elementList = new CanvasElementList();
            ICommand modifyCommand = new ModifyElementCommand(elementList);
            DesignElement obj1 = new Lines();
            DesignElement obj2 = modifyCommand.copyElementState(obj1);
            Assert.AreEqual(true, typeof(Lines).IsInstanceOfType(obj2));
        }

        [TestMethod]
        public void regPolyCopyElementStateTest()
        {
            CanvasElementList elementList = new CanvasElementList();
            ICommand modifyCommand = new ModifyElementCommand(elementList);
            DesignElement obj1 = new RegularPolygon();
            DesignElement obj2 = modifyCommand.copyElementState(obj1);
            Assert.AreEqual(true, typeof(RegularPolygon).IsInstanceOfType(obj2));
        }

        [TestMethod]
        public void polyCopyElementStateTest()
        {
            CanvasElementList elementList = new CanvasElementList();
            ICommand modifyCommand = new ModifyElementCommand(elementList);
            DesignElement obj1 = new Polygon();
            DesignElement obj2 = modifyCommand.copyElementState(obj1);
            Assert.AreEqual(true, typeof(Polygon).IsInstanceOfType(obj2));
        }
    }

    //------------------------------------------------------------------
    // Name:    Megan Baxter
    // Project: Creationometry
    // Purpose: This Test will test the methods of the RemoveCommand
    //          Class.
    //------------------------------------------------------------------
    [TestClass]
    public class RemoveCommandTest
    {
        [TestMethod]
        public void executeTest()
        {
            CanvasElementList elementList = new CanvasElementList();
            ICommand addCommand = new AddCommand(elementList);
            ICommand removeCommand = new RemoveCommand(elementList);

            //Add an element to be removed
            System.Drawing.Point[] points = null;
            addCommand.execute(DesignElementTypes.ELLIPSE, points);

            //Select the element
            elementList.getElement(0).setIsSelected(true);

            //Remove the element
            removeCommand.execute();
            Assert.AreEqual(0, elementList.getListSize());
        }

        [TestMethod]
        public void nullExecuteTest()
        {
            CanvasElementList elementList = new CanvasElementList();
            ICommand removeCommand = new RemoveCommand(elementList);

            Assert.AreEqual(false, removeCommand.execute());
        }

        [TestMethod]
        public void partialParamExecuteTest()
        {
            CanvasElementList elementList = new CanvasElementList();
            ICommand removeCommand = new RemoveCommand(elementList);

            Assert.AreEqual(false, removeCommand.execute(null));
        }

        [TestMethod]
        public void paramExecuteTest()
        {
            CanvasElementList elementList = new CanvasElementList();
            ICommand removeCommand = new RemoveCommand(elementList);
            Assert.AreEqual(false, removeCommand.execute(DesignElementTypes.CIRCLE, null));
        }

        [TestMethod]
        public void undoTest()
        {
            CanvasElementList elementList = new CanvasElementList();
            ICommand addCommand = new AddCommand(elementList);
            ICommand removeCommand = new RemoveCommand(elementList);

            //Add an element to be removed
            System.Drawing.Point[] points = null;
            addCommand.execute(DesignElementTypes.ELLIPSE, points);

            //Select the element
            elementList.getElement(0).setIsSelected(true);

            //Remove the element
            removeCommand.execute();
            removeCommand.undo();

            Assert.AreEqual(1, elementList.getListSize());
        }

        [TestMethod]
        public void redoTest()
        {
            CanvasElementList elementList = new CanvasElementList();
            ICommand addCommand = new AddCommand(elementList);
            ICommand removeCommand = new RemoveCommand(elementList);

            //Add an element to be removed
            System.Drawing.Point[] points = null;
            addCommand.execute(DesignElementTypes.ELLIPSE, points);

            //Select the element
            elementList.getElement(0).setIsSelected(true);

            //Remove the element
            removeCommand.execute();
            removeCommand.undo();
            removeCommand.redo();

            Assert.AreEqual(0, elementList.getListSize());
        }

        [TestMethod]
        public void copyElementTest()
        {
            DesignElement obj1 = new Ellipses();
            CanvasElementList elementList = new CanvasElementList();
            ICommand removeCommand = new RemoveCommand(elementList);
            Assert.AreEqual(null, removeCommand.copyElementState(obj1));
        }
    }

    //------------------------------------------------------------------
    // Name:    Megan Baxter, Callie Seehafer
    // Project: Creationometry
    // Purpose: This Test will test the methods of the
    //          RotateElementCommand Class.
    //------------------------------------------------------------------
    [TestClass]
    public class RotateCommandTest
    {
        [TestMethod]
        public void executeTest()
        {
            CanvasElementList elementList = new CanvasElementList();
            TextBox inputRotateAngle = new TextBox();
            inputRotateAngle.Text = "90";
            ICommand addCommand = new AddCommand(elementList);
            ICommand rotateCommand = new RotateElementCommand(elementList, inputRotateAngle);

            //Add an element to be rotated
            System.Drawing.Point[] points = null;
            addCommand.execute(DesignElementTypes.ELLIPSE, points);

            //Select the element
            elementList.getElement(0).setIsSelected(true);

            //Rotate the element
            rotateCommand.execute();
            Assert.AreEqual(90, elementList.getElement(0).getOrientationAngle());
        }

        [TestMethod]
        public void nullExecuteTest()
        {
            CanvasElementList elementList = new CanvasElementList();
            TextBox inputRotateAngle = new TextBox();
            ICommand rotateCommand = new RotateElementCommand(elementList, inputRotateAngle);

            Assert.AreEqual(false, rotateCommand.execute());
        }

        [TestMethod]
        public void invalidExecuteTest()
        {
            CanvasElementList elementList = new CanvasElementList();
            TextBox inputRotateAngle = new TextBox();
            inputRotateAngle.Text = "90";
            ICommand addCommand = new AddCommand(elementList);
            ICommand rotateCommand = new RotateElementCommand(elementList, inputRotateAngle);

            //Add an element to be removed
            System.Drawing.Point[] points = null;
            addCommand.execute(DesignElementTypes.ELLIPSE, points);

            //Select the element
            elementList.getElement(0).setIsSelected(true);
            elementList.getElement(0).setOrientationAngle(90);

            //Rotate the element
            rotateCommand.execute();
            Assert.AreEqual(false, rotateCommand.execute());
        }

        [TestMethod]
        public void partialParamExecuteTest()
        {
            CanvasElementList elementList = new CanvasElementList();
            TextBox inputRotateAngle = new TextBox();
            ICommand rotateCommand = new RotateElementCommand(elementList, inputRotateAngle);
            Assert.AreEqual(false, rotateCommand.execute(null));
        }

        [TestMethod]
        public void paramExecuteTest()
        {
            CanvasElementList elementList = new CanvasElementList();
            TextBox inputRotateAngle = new TextBox();
            ICommand rotateCommand = new RotateElementCommand(elementList, inputRotateAngle);
            Assert.AreEqual(false, rotateCommand.execute(DesignElementTypes.CIRCLE, null));
        }

        [TestMethod]
        public void emptyUndoTest()
        {
            CanvasElementList elementList = new CanvasElementList();
            TextBox inputRotateAngle = new TextBox();
            inputRotateAngle.Text = "90";
            ICommand addCommand = new AddCommand(elementList);
            ICommand rotateCommand = new RotateElementCommand(elementList, inputRotateAngle);

            //Add an element to be rotated
            System.Drawing.Point[] points = null;
            addCommand.execute(DesignElementTypes.ELLIPSE, points);

            //Select the element
            elementList.getElement(0).setIsSelected(true);

            rotateCommand.undo();

            Assert.AreEqual(false, elementList.getElement(0).getIsSelected());
        }

        [TestMethod]
        public void undoTest()
        {
            CanvasElementList elementList = new CanvasElementList();
            TextBox inputRotateAngle = new TextBox();
            inputRotateAngle.Text = "90";
            ICommand addCommand = new AddCommand(elementList);
            ICommand rotateCommand = new RotateElementCommand(elementList, inputRotateAngle);

            //Add an element to be rotated
            System.Drawing.Point[] points = null;
            addCommand.execute(DesignElementTypes.ELLIPSE, points);

            //Select the element
            elementList.getElement(0).setIsSelected(true);

            //Rotate the element and then undo it
            rotateCommand.execute();
            rotateCommand.undo();

            Assert.AreEqual(0, elementList.getElement(0).getOrientationAngle());
        }

        [TestMethod]
        public void emptyRedoTest()
        {
            CanvasElementList elementList = new CanvasElementList();
            TextBox inputRotateAngle = new TextBox();
            inputRotateAngle.Text = "90";
            ICommand addCommand = new AddCommand(elementList);
            ICommand rotateCommand = new RotateElementCommand(elementList, inputRotateAngle);

            //Add an element to be rotated
            System.Drawing.Point[] points = null;
            addCommand.execute(DesignElementTypes.ELLIPSE, points);

            //Select the element
            elementList.getElement(0).setIsSelected(true);

            rotateCommand.redo();

            Assert.AreEqual(false, elementList.getElement(0).getIsSelected());
        }

        [TestMethod]
        public void redoTest()
        {
            CanvasElementList elementList = new CanvasElementList();
            TextBox inputRotateAngle = new TextBox();
            inputRotateAngle.Text = "90";
            ICommand addCommand = new AddCommand(elementList);
            ICommand rotateCommand = new RotateElementCommand(elementList, inputRotateAngle);

            // Add an element to be rotated
            System.Drawing.Point[] points = null;
            addCommand.execute(DesignElementTypes.ELLIPSE, points);

            // Select the element
            elementList.getElement(0).setIsSelected(true);

            // Rotate the element, undo it, and then redo it
            rotateCommand.execute();
            rotateCommand.undo();
            rotateCommand.redo();

            Assert.AreEqual(90, elementList.getElement(0).getOrientationAngle());
        }

        [TestMethod]
        public void ellipseCopyElementStateTest()
        {
            CanvasElementList elementList = new CanvasElementList();
            TextBox inputRotateAngle = new TextBox();
            ICommand rotateCommand = new RotateElementCommand(elementList, inputRotateAngle);
            DesignElement obj1 = new Ellipses();
            DesignElement obj2 = rotateCommand.copyElementState(obj1);
            Assert.AreEqual(true, typeof(Ellipses).IsInstanceOfType(obj2));
        }

        [TestMethod]
        public void linesCopyElementStateTest()
        {
            CanvasElementList elementList = new CanvasElementList();
            TextBox inputRotateAngle = new TextBox();
            ICommand rotateCommand = new RotateElementCommand(elementList, inputRotateAngle);
            DesignElement obj1 = new Lines();
            DesignElement obj2 = rotateCommand.copyElementState(obj1);
            Assert.AreEqual(true, typeof(Lines).IsInstanceOfType(obj2));
        }

        [TestMethod]
        public void regPolyCopyElementStateTest()
        {
            CanvasElementList elementList = new CanvasElementList();
            TextBox inputRotateAngle = new TextBox();
            ICommand rotateCommand = new RotateElementCommand(elementList, inputRotateAngle);
            DesignElement obj1 = new RegularPolygon();
            DesignElement obj2 = rotateCommand.copyElementState(obj1);
            Assert.AreEqual(true, typeof(RegularPolygon).IsInstanceOfType(obj2));
        }

        [TestMethod]
        public void polyCopyElementStateTest()
        {
            CanvasElementList elementList = new CanvasElementList();
            TextBox inputRotateAngle = new TextBox();
            ICommand rotateCommand = new RotateElementCommand(elementList, inputRotateAngle);
            DesignElement obj1 = new Polygon();
            DesignElement obj2 = rotateCommand.copyElementState(obj1);
            Assert.AreEqual(true, typeof(Polygon).IsInstanceOfType(obj2));
        }
    }
}

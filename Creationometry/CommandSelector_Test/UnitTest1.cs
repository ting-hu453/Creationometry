using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Creationometry;
using System.Windows.Forms;
using System.Drawing;

namespace CommandSelector_Test
{
    //------------------------------------------------------------------
    // Name:    Megan Baxter
    // Project: Creationometry
    // Purpose: This Test will test the methods of the
    //          CommandSelector Class.
    //------------------------------------------------------------------
    [TestClass]
    public class CommandSelectorTest
    {
        [TestMethod]
        public void setCommandTest()
        {
            Label undoLabel = new Label();
            Label redoLabel = new Label();
            CommandSelector commandSelector = new CommandSelector(undoLabel, redoLabel);
            CanvasElementList elementList = new CanvasElementList();
            ICommand addCommand = new AddCommand(elementList);

            commandSelector.setCommand(addCommand);
            Assert.AreEqual(addCommand, commandSelector.slot);
        }

        [TestMethod]
        public void doActionTest()
        {
            Label undoLabel = new Label();
            Label redoLabel = new Label();
            CommandSelector commandSelector = new CommandSelector(undoLabel, redoLabel);
            CanvasElementList elementList = new CanvasElementList();
            ICommand addCommand = new AddCommand(elementList);
            ICommand removeCommand = new RemoveCommand(elementList);

            commandSelector.setCommand(addCommand);
            commandSelector.doAction(DesignElementTypes.LINE, null);

            elementList.getElement(0).setIsSelected(true);

            commandSelector.setCommand(removeCommand);
            commandSelector.doAction();

            Assert.AreEqual(0, elementList.getListSize());
        }

        [TestMethod]
        public void paramDoActionTest()
        {
            Label undoLabel = new Label();
            Label redoLabel = new Label();
            CommandSelector commandSelector = new CommandSelector(undoLabel, redoLabel);
            CanvasElementList elementList = new CanvasElementList();
            ICommand addCommand = new AddCommand(elementList);

            commandSelector.setCommand(addCommand);
            commandSelector.doAction(DesignElementTypes.LINE, null);
            Assert.AreEqual(true, typeof(Lines).IsInstanceOfType(elementList.getElement(0)));
        }

        [TestMethod]
        public void undoActionTest()
        {
            Label undoLabel = new Label();
            Label redoLabel = new Label();
            CommandSelector commandSelector = new CommandSelector(undoLabel, redoLabel);
            CanvasElementList elementList = new CanvasElementList();
            ICommand addCommand = new AddCommand(elementList);

            commandSelector.setCommand(addCommand);
            commandSelector.doAction(DesignElementTypes.LINE, null);

            commandSelector.undoAction();

            Assert.AreEqual(0, elementList.getListSize());
        }

        [TestMethod]
        public void redoActionTest()
        {
            Label undoLabel = new Label();
            Label redoLabel = new Label();
            CommandSelector commandSelector = new CommandSelector(undoLabel, redoLabel);
            CanvasElementList elementList = new CanvasElementList();
            ICommand addCommand = new AddCommand(elementList);

            commandSelector.setCommand(addCommand);
            commandSelector.doAction(DesignElementTypes.LINE, null);

            commandSelector.undoAction();
            commandSelector.redoAction();

            Assert.AreEqual(1, elementList.getListSize());
        }

        [TestMethod]
        public void emptyUndoUpdateDisplayTest()
        {
            Label undoLabel = new Label();
            Label redoLabel = new Label();
            CommandSelector commandSelector = new CommandSelector(undoLabel, redoLabel);

            commandSelector.updateDisplay();

            Assert.AreEqual("Undo: No Action", undoLabel.Text);
        }

        [TestMethod]
        public void addUndoUpdateDisplayTest()
        {
            Label undoLabel = new Label();
            Label redoLabel = new Label();
            CommandSelector commandSelector = new CommandSelector(undoLabel, redoLabel);
            CanvasElementList elementList = new CanvasElementList();
            ICommand addCommand = new AddCommand(elementList);

            commandSelector.setCommand(addCommand);
            commandSelector.doAction(DesignElementTypes.LINE, null);

            Assert.AreEqual("Undo: Remove Element", undoLabel.Text);
        }

        [TestMethod]
        public void removeUndoUpdateDisplayTest()
        {
            Label undoLabel = new Label();
            Label redoLabel = new Label();
            CommandSelector commandSelector = new CommandSelector(undoLabel, redoLabel);
            CanvasElementList elementList = new CanvasElementList();
            ICommand addCommand = new AddCommand(elementList);
            ICommand removeCommand = new RemoveCommand(elementList);

            commandSelector.setCommand(addCommand);
            commandSelector.doAction(DesignElementTypes.LINE, null);

            elementList.getElement(0).setIsSelected(true);

            commandSelector.setCommand(removeCommand);
            commandSelector.doAction();

            Assert.AreEqual("Undo: Add Element", undoLabel.Text);
        }

        [TestMethod]
        public void duplicateUndoUpdateDisplayTest()
        {
            Label undoLabel = new Label();
            Label redoLabel = new Label();
            CommandSelector commandSelector = new CommandSelector(undoLabel, redoLabel);
            CanvasElementList elementList = new CanvasElementList();
            ICommand addCommand = new AddCommand(elementList);
            ICommand duplicateCommand = new DuplicateCommand(elementList);

            commandSelector.setCommand(addCommand);
            commandSelector.doAction(DesignElementTypes.LINE, null);

            elementList.getElement(0).setIsSelected(true);

            commandSelector.setCommand(duplicateCommand);
            commandSelector.doAction();

            Assert.AreEqual("Undo: Remove Element", undoLabel.Text);
        }

        [TestMethod]
        public void modifyUndoUpdateDisplayTest()
        {
            Label undoLabel = new Label();
            Label redoLabel = new Label();
            CommandSelector commandSelector = new CommandSelector(undoLabel, redoLabel);
            CanvasElementList elementList = new CanvasElementList();
            ICommand addCommand = new AddCommand(elementList);
            ICommand modifyCommand = new ModifyElementCommand(elementList);

            commandSelector.setCommand(addCommand);
            commandSelector.doAction(DesignElementTypes.LINE, null);

            elementList.getElement(0).setIsSelected(true);
            DesignElement selectedElement = elementList.getSelectedElement();
            commandSelector.setCommand(modifyCommand);
            commandSelector.doAction(selectedElement);

            Assert.AreEqual("Undo: Restore Element", undoLabel.Text);
        }

        [TestMethod]
        public void rotateUndoUpdateDisplayTest()
        {
            Label undoLabel = new Label();
            Label redoLabel = new Label();
            TextBox inputRotateAngle = new TextBox();
            CommandSelector commandSelector = new CommandSelector(undoLabel, redoLabel);
            CanvasElementList elementList = new CanvasElementList();
            ICommand addCommand = new AddCommand(elementList);
            ICommand rotateCommand = new RotateElementCommand(elementList, inputRotateAngle);

            commandSelector.setCommand(addCommand);
            commandSelector.doAction(DesignElementTypes.LINE, null);

            elementList.getElement(0).setIsSelected(true);
            inputRotateAngle.Text = "90";

            commandSelector.setCommand(rotateCommand);
            commandSelector.doAction();

            Assert.AreEqual("Undo: Restore Element Orientation", undoLabel.Text);
        }

        [TestMethod]
        public void emptyRedoUpdateDisplayTest()
        {
            Label undoLabel = new Label();
            Label redoLabel = new Label();
            CommandSelector commandSelector = new CommandSelector(undoLabel, redoLabel);

            commandSelector.updateDisplay();

            Assert.AreEqual("Redo: No Action", redoLabel.Text);
        }

        [TestMethod]
        public void addRedoUpdateDisplayTest()
        {
            Label undoLabel = new Label();
            Label redoLabel = new Label();
            CommandSelector commandSelector = new CommandSelector(undoLabel, redoLabel);
            CanvasElementList elementList = new CanvasElementList();
            ICommand addCommand = new AddCommand(elementList);

            commandSelector.setCommand(addCommand);
            commandSelector.doAction(DesignElementTypes.LINE, null);
            commandSelector.undoAction();

            Assert.AreEqual("Redo: Add Element", redoLabel.Text);
        }

        [TestMethod]
        public void removeRedoUpdateDisplayTest()
        {
            Label undoLabel = new Label();
            Label redoLabel = new Label();
            CommandSelector commandSelector = new CommandSelector(undoLabel, redoLabel);
            CanvasElementList elementList = new CanvasElementList();
            ICommand addCommand = new AddCommand(elementList);
            ICommand removeCommand = new RemoveCommand(elementList);

            commandSelector.setCommand(addCommand);
            commandSelector.doAction(DesignElementTypes.LINE, null);

            elementList.getElement(0).setIsSelected(true);

            commandSelector.setCommand(removeCommand);
            commandSelector.doAction();
            commandSelector.undoAction();

            Assert.AreEqual("Redo: Remove Element", redoLabel.Text);
        }

        [TestMethod]
        public void duplicateRedoUpdateDisplayTest()
        {
            Label undoLabel = new Label();
            Label redoLabel = new Label();
            CommandSelector commandSelector = new CommandSelector(undoLabel, redoLabel);
            CanvasElementList elementList = new CanvasElementList();
            ICommand addCommand = new AddCommand(elementList);
            ICommand duplicateCommand = new DuplicateCommand(elementList);

            commandSelector.setCommand(addCommand);
            commandSelector.doAction(DesignElementTypes.LINE, null);

            elementList.getElement(0).setIsSelected(true);

            commandSelector.setCommand(duplicateCommand);
            commandSelector.doAction();
            commandSelector.undoAction();

            Assert.AreEqual("Redo: Duplicate Element", redoLabel.Text);
        }

        [TestMethod]
        public void modifyRedoUpdateDisplayTest()
        {
            Label undoLabel = new Label();
            Label redoLabel = new Label();
            CommandSelector commandSelector = new CommandSelector(undoLabel, redoLabel);
            CanvasElementList elementList = new CanvasElementList();
            ICommand addCommand = new AddCommand(elementList);
            ICommand modifyCommand = new ModifyElementCommand(elementList);

            commandSelector.setCommand(addCommand);
            commandSelector.doAction(DesignElementTypes.LINE, null);

            elementList.getElement(0).setIsSelected(true);
            DesignElement selectedElement = elementList.getSelectedElement();
            commandSelector.setCommand(modifyCommand);
            commandSelector.doAction(selectedElement);
            commandSelector.undoAction();

            Assert.AreEqual("Redo: Modify Element", redoLabel.Text);
        }

        [TestMethod]
        public void rotateRedoUpdateDisplayTest()
        {
            Label undoLabel = new Label();
            Label redoLabel = new Label();
            TextBox inputRotateAngle = new TextBox();
            CommandSelector commandSelector = new CommandSelector(undoLabel, redoLabel);
            CanvasElementList elementList = new CanvasElementList();
            ICommand addCommand = new AddCommand(elementList);
            ICommand rotateCommand = new RotateElementCommand(elementList, inputRotateAngle);

            commandSelector.setCommand(addCommand);
            commandSelector.doAction(DesignElementTypes.LINE, null);

            elementList.getElement(0).setIsSelected(true);
            inputRotateAngle.Text = "90";

            commandSelector.setCommand(rotateCommand);
            commandSelector.doAction();
            commandSelector.undoAction();

            Assert.AreEqual("Redo: Rotate Element", redoLabel.Text);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Creationometry
{
    //------------------------------------------------------------------
    // Name:    Megan Baxter, Callie Seehafer
    // Project: Creationometry
    // Purpose: This class will invoke the various concrete commands. It
    //          will maintain the order of the commands within 2 stacks
    //          so that the undo and redo method of each command may be
    //          called. It will also update the UI feedback.
    //------------------------------------------------------------------
    public class CommandSelector
    {
        // Attributes
        public ICommand slot;
        private Stack<ICommand> undoStack;
        private Stack<ICommand> redoStack;
        private Label undoLabel;
        private Label redoLabel;

        // Constructor
        public CommandSelector(Label undoLabel, Label redoLabel)
        {
            this.undoLabel = undoLabel;
            this.redoLabel = redoLabel;
            undoStack = new Stack<ICommand>();
            redoStack = new Stack<ICommand>();
        }

        //------------------------------------------------------------------
        // Sets the command slot to the passed command from the Driver.
        //------------------------------------------------------------------
        public void setCommand(ICommand command)
        {
            slot = command;
        }

        //------------------------------------------------------------------
        // Executes the command and adds the command to the undo stack.
        //------------------------------------------------------------------
        public void doAction()
        {
            if (slot.execute())
            {
                undoStack.Push(slot);
                updateDisplay();
            }
        }

        //------------------------------------------------------------------
        // Executes the command and adds the command to the undo stack.
        // Overloaded doAction for certain circumstances.
        //------------------------------------------------------------------
        public void doAction(DesignElement selectedElement)
        {
            if (slot.execute(selectedElement))
            {
                undoStack.Push(slot);
                updateDisplay();
            }
        }

        //------------------------------------------------------------------
        // Executes the command and adds the command to the undo stack.
        // Overloaded doAction for certain circumstances.
        //------------------------------------------------------------------
        public void doAction(DesignElementTypes elementType,
            System.Drawing.Point[] points = null)
        {
            if (slot.execute(elementType, points))
            {
                undoStack.Push(slot);
                updateDisplay();
            }
        }

        //------------------------------------------------------------------
        // Calls the undo command of the command object at the top of the
        // undo stack. Transfers the command to the redo stack.
        //------------------------------------------------------------------
        public void undoAction()
        {
            if (undoStack.Count > 0)
            {
                undoStack.Peek().undo();
                redoStack.Push(undoStack.Pop());
                updateDisplay();
            }
        }

        //------------------------------------------------------------------
        // Calls the redo command of the command object at the top of the
        // redo stack. Transfers the command to the undo stack.
        //------------------------------------------------------------------
        public void redoAction()
        {
            if (redoStack.Count > 0)
            {
                redoStack.Peek().redo();
                undoStack.Push(redoStack.Pop());
                updateDisplay();
            }
        }

        //------------------------------------------------------------------
        // Updates the display on the GUI for communicating the status.
        //------------------------------------------------------------------
        public void updateDisplay()
        {
            if (undoStack.Count > 0)
            {
                if (typeof(AddCommand).IsInstanceOfType(undoStack.Peek()))
                    undoLabel.Text = "Undo: Remove Element";
                else if (typeof(RemoveCommand).IsInstanceOfType(undoStack.Peek()))
                    undoLabel.Text = "Undo: Add Element";
                else if (typeof(DuplicateCommand).IsInstanceOfType(undoStack.Peek()))
                    undoLabel.Text = "Undo: Remove Element";
                else if (typeof(CanvasColorCommand).IsInstanceOfType(undoStack.Peek()))
                    undoLabel.Text = "Undo: Restore Canvas Color";
                else if (typeof(ModifyElementCommand).IsInstanceOfType(undoStack.Peek()))
                    undoLabel.Text = "Undo: Restore Element";
                else if (typeof(RotateElementCommand).IsInstanceOfType(undoStack.Peek()))
                    undoLabel.Text = "Undo: Restore Element Orientation";
            }
            else
                undoLabel.Text = "Undo: No Action";

            if (redoStack.Count > 0)
            {
                if (typeof(AddCommand).IsInstanceOfType(redoStack.Peek()))
                    redoLabel.Text = "Redo: Add Element";
                else if (typeof(RemoveCommand).IsInstanceOfType(redoStack.Peek()))
                    redoLabel.Text = "Redo: Remove Element";
                else if (typeof(DuplicateCommand).IsInstanceOfType(redoStack.Peek()))
                    redoLabel.Text = "Redo: Duplicate Element";
                else if (typeof(CanvasColorCommand).IsInstanceOfType(redoStack.Peek()))
                    redoLabel.Text = "Redo: Change Canvas Color";
                else if (typeof(ModifyElementCommand).IsInstanceOfType(redoStack.Peek()))
                    redoLabel.Text = "Redo: Modify Element";
                else if (typeof(RotateElementCommand).IsInstanceOfType(redoStack.Peek()))
                    redoLabel.Text = "Redo: Rotate Element";
            }
            else
                redoLabel.Text = "Redo: No Action";
        }
    }
}
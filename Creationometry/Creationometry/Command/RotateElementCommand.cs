using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Creationometry
{
    //------------------------------------------------------------------
    // Name:    Ting Hu, Megan Baxter, Callie Seehafer
    // Project: Creationometry
    // Purpose: This class will rotate a Design Element from the Canvas
    //          element list. It will keep a record of all the
    //          elements rotated so that the element can be rotated, the
    //          rotate can be undone by restoring that element in the
    //          list, and the rotate can be redone by adding the
    //          modified element back into the list.This class
    //          implements the ICommand interface.
    //------------------------------------------------------------------
    public class RotateElementCommand : ICommand
    {
        // Attributes - state
        private CanvasElementList elementList;
        private Stack<DesignElement> undoStack;
        private Stack<DesignElement> redoStack;
        private Stack<int> undoIndexStack;
        private Stack<int> redoIndexStack;
        TextBox inputRotateAngle;

        // Constructor
        public RotateElementCommand(CanvasElementList elementList,
            TextBox inputRotateAngle)
        {
            this.elementList = elementList;
            this.inputRotateAngle = inputRotateAngle;
            undoStack = new Stack<DesignElement>();
            redoStack = new Stack<DesignElement>();
            undoIndexStack = new Stack<int>();
            redoIndexStack = new Stack<int>();
        }

        //------------------------------------------------------------------
        // Finds the element that was selected and stores a copy to the undo
        // stack before the element is rotated.
        //------------------------------------------------------------------
        public bool execute()
        {
            bool isSuccess = true;
            DesignElement tempElement = elementList.getSelectedElement();
            if (inputRotateAngle.Text != "")
            {
                if (float.Parse(inputRotateAngle.Text)
                    != tempElement.getOrientationAngle() && tempElement != null)
                {
                    undoStack.Push(copyElementState(tempElement));
                    undoIndexStack.Push(elementList.getIndex(tempElement));
                    tempElement.rotateTransformAngle(float.Parse(inputRotateAngle.Text));
                }
                else
                    isSuccess = false;
            }
            else
                isSuccess = false;

            inputRotateAngle.Clear();
            return isSuccess;
        }

        //------------------------------------------------------------------
        // Unused overloaded execute method.
        //------------------------------------------------------------------
        public bool execute(DesignElement selectedElement)
        {
            return false;
        }

        //------------------------------------------------------------------
        // Unused overloaded execute method.
        //------------------------------------------------------------------
        public bool execute(DesignElementTypes elementType, System.Drawing.Point[] points)
        {
            return false;
        }

        //------------------------------------------------------------------
        // Restores the previously rotated element by taking the copy of it
        // from the undo stack and setting that as the element in the element
        // list at the location from the undo index stack. Stores the
        // element and index in the redo stacks.
        //------------------------------------------------------------------
        public void undo()
        {
            if (undoIndexStack.Count > 0 && undoStack.Count > 0)
            {
                redoStack.Push(copyElementState(elementList.getElement(undoIndexStack.Peek())));
                redoIndexStack.Push(undoIndexStack.Peek());
                elementList.restoreElement(undoIndexStack.Pop(), undoStack.Pop());
            }
            elementList.clearSelection();
        }

        //------------------------------------------------------------------
        // Restores the element to its rotated state by taking the copy of
        // it from the redo stack and setting that as the element in the
        // element list at the location from the redo index stack. Stores
        // the element and index in the undo stacks.
        //------------------------------------------------------------------
        public void redo()
        {
            if (redoIndexStack.Count > 0 && redoStack.Count > 0)
            {
                undoStack.Push(copyElementState(elementList.getElement(redoIndexStack.Peek())));
                undoIndexStack.Push(redoIndexStack.Peek());
                elementList.restoreElement(redoIndexStack.Pop(), redoStack.Pop());
            }
            elementList.clearSelection();
        }

        //------------------------------------------------------------------
        // Takes an original element and creates a deep copy of that
        // element. The duplicated element is returned.
        //------------------------------------------------------------------
        public DesignElement copyElementState(DesignElement elementToCopy)
        {
            DesignElement elementToStore = null;

            if (typeof(Ellipses).IsInstanceOfType(elementToCopy))
                elementToStore = new Ellipses((Ellipses)elementToCopy);
            else if (typeof(Lines).IsInstanceOfType(elementToCopy))
                elementToStore = new Lines((Lines)elementToCopy);
            else if (typeof(RegularPolygon).IsInstanceOfType(elementToCopy))
                elementToStore = new RegularPolygon((RegularPolygon)elementToCopy);
            else if (typeof(Polygon).IsInstanceOfType(elementToCopy))
                elementToStore = new Polygon((Polygon)elementToCopy);

            return elementToStore;
        }
    }
}
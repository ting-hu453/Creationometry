using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creationometry
{
    //------------------------------------------------------------------
    // Name:    Megan Baxter, Callie Seehafer
    // Project: Creationometry
    // Purpose: This class will remove a Design Element from the list of
    //          Canvas Design Elements. It will keep a record of all the
    //          elements removed so that the element can be removed, the 
    //          removal can be undone by adding the element to the list,
    //          and the removal can be redone by removing the element
    //          from the list again. This class implements the ICommand
    //          interface.
    //------------------------------------------------------------------
    public class RemoveCommand : ICommand
    {
        // Attributes
        private CanvasElementList elementList;
        private Stack<DesignElement> undoStack;
        private Stack<DesignElement> redoStack;
        private Stack<int> undoIndexStack;
        private Stack<int> redoIndexStack;

        // Constructor
        public RemoveCommand(CanvasElementList elementList)
        {
            this.elementList = elementList;
            undoStack = new Stack<DesignElement>();
            redoStack = new Stack<DesignElement>();
            undoIndexStack = new Stack<int>();
            redoIndexStack = new Stack<int>();
        }

        //------------------------------------------------------------------
        // Determins which element is selected and then calls the
        // CanvasElementList function for removing that element. Stores the 
        // removed element to the undo stack and the original index of that
        // element to the undo index stack.
        //------------------------------------------------------------------
        public bool execute()
        {
            DesignElement elementToDelete = elementList.getSelectedElement();
            bool isSuccess = true;
            if (elementToDelete != null)
            {
                undoStack.Push(elementToDelete);
                undoIndexStack.Push(elementList.removeElement(elementToDelete));
            }
            else
                isSuccess = false;
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
        // Inserts the previously removed element back to original location
        // within list of elements. Stores the element into the redo stack,
        // the index into the redo index stack, and clears the selection
        // attribute of the item that was selected.
        //------------------------------------------------------------------
        public void undo()
        {
            if (undoStack.Count > 0)
            {
                elementList.insertElement(undoIndexStack.Peek(), undoStack.Peek());
                redoStack.Push(undoStack.Pop());
                redoIndexStack.Push(undoIndexStack.Pop());
                elementList.clearSelection();
            }
            elementList.clearSelection();
        }

        //------------------------------------------------------------------
        // Removes the previously added element from list of elements.
        // Stores the element into the undo stack and the index into the
        // undo index stack. Clears the selection
        // attribute of the item that was selected.
        //------------------------------------------------------------------
        public void redo()
        {
            if (redoStack.Count > 0)
            {
                elementList.removeElement(redoStack.Peek());
                undoStack.Push(redoStack.Pop());
                undoIndexStack.Push(redoIndexStack.Pop());
                elementList.clearSelection();
            }
            elementList.clearSelection();
        }

        //------------------------------------------------------------------
        // Unused copy state method.
        //------------------------------------------------------------------
        public DesignElement copyElementState(DesignElement elementToCopy)
        {
            return null;
        }
    }
}
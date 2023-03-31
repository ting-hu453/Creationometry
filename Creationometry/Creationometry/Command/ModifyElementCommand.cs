using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Creationometry.Presenters;

namespace Creationometry
{
    //------------------------------------------------------------------
    // Name:    Megan Baxter, Callie Seehafer, Reese Wunderlich
    // Project: Creationometry
    // Purpose: This class will be called by the EMMenu classes to
    //          create a memento of an object before modifications. It
    //          will keep a record of the mementos so that the
    //          modification can be undone by replacing the modified
    //          element in the list with the memento and the
    //          modification can be redone by adding the modified 
    //          element back into the list. This class implements the
    //          ICommand interface.
    //------------------------------------------------------------------
    public class ModifyElementCommand : ICommand
    {
        // Attributes - state
        private CanvasElementList elementList;
        private Stack<DesignElement> undoStack;
        private Stack<DesignElement> redoStack;
        private Stack<int> undoIndexStack;
        private Stack<int> redoIndexStack;

        // Constructor
        public ModifyElementCommand(CanvasElementList elementList)
        {
            this.elementList = elementList;
            undoStack = new Stack<DesignElement>();
            redoStack = new Stack<DesignElement>();
            undoIndexStack = new Stack<int>();
            redoIndexStack = new Stack<int>();
        }

        //------------------------------------------------------------------
        // Unused execute method.
        //------------------------------------------------------------------
        public bool execute()
        {
            return false;
        }

        //------------------------------------------------------------------
        // Stores a copy of the passed element to the undo stack before the 
        // element may be modified.
        // The memento pattern is being used within the command pattern,
        // so modification is handled by the invoker.
        //------------------------------------------------------------------
        public bool execute(DesignElement selectedElement)
        {
            bool isSuccess = true;

            if (selectedElement != null)
            {
                // Make copy of original element before modifications
                int index = elementList.getIndex(selectedElement);
                if (index != -1)
                {
                    undoIndexStack.Push(index);
                    undoStack.Push(copyElementState(selectedElement));
                }
                isSuccess = true;
            }
            else
                isSuccess = false;

            return isSuccess;
        }

        //------------------------------------------------------------------
        // Unused overloaded execute method.
        //------------------------------------------------------------------
        public bool execute(DesignElementTypes elementType, System.Drawing.Point[] points)
        {
            return false;
        }

        //------------------------------------------------------------------
        // Restores the previously modified element by taking the copy of it
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
        // Restores the element to its modified state by taking the copy of
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
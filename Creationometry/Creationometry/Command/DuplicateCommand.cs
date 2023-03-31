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
    // Purpose: This class will duplicate a Design Element and add it to
    //          the list of Canvas Design Elements. It will keep a
    //          record of all the elements added so that the element can
    //          be duplicated and added, the duplication can be undone by
    //          removing the element from the list, and the duplication
    //          can be redone by adding the element back into the list.
    //          This class implements the ICommand interface.
    //------------------------------------------------------------------
    public class DuplicateCommand : ICommand
    {
        // Attributes
        private const int OFFSET = 5;
        private CanvasElementList elementList;
        private Stack<DesignElement> undoStack;
        private Stack<DesignElement> redoStack;

        // Constructor
        public DuplicateCommand(CanvasElementList elementList)
        {
            this.elementList = elementList;
            undoStack = new Stack<DesignElement>();
            redoStack = new Stack<DesignElement>();
        }

        //------------------------------------------------------------------
        // Determins which element is selected and then creates a deep copy
        // of that element and adds it to the list. All of the elements are
        // then deselected.
        //------------------------------------------------------------------
        public bool execute()
        {
            DesignElement elementToCopy = elementList.getSelectedElement();
            DesignElement elementToAdd = null;
            bool isSuccess = true;

            if (typeof(Ellipses).IsInstanceOfType(elementToCopy))
            {
                elementToAdd = new Ellipses((Ellipses)elementToCopy);
                elementToAdd.duplicationOffset(OFFSET);
            }
            else if (typeof(Lines).IsInstanceOfType(elementToCopy))
            {
                elementToAdd = new Lines((Lines)elementToCopy);
                elementToAdd.duplicationOffset(OFFSET);
            }
            else if (typeof(RegularPolygon).IsInstanceOfType(elementToCopy))
            {
                elementToAdd = new RegularPolygon((RegularPolygon)elementToCopy);
                elementToAdd.duplicationOffset(OFFSET);
            }
            else if (typeof(Polygon).IsInstanceOfType(elementToCopy))
            {
                elementToAdd = new Polygon((Polygon)elementToCopy);
                elementToAdd.duplicationOffset(OFFSET);
            }
            else
                isSuccess = false;

            if (elementToCopy != null)
            {
                // Add created element to the list
                elementList.addElement(elementToAdd);

                // Deselect all of the elements
                elementList.clearSelection();

                undoStack.Push(elementToAdd);
            }
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
        // Removes the most recently added item. Stores that item from the 
        // undo stack into the redo stack.
        //------------------------------------------------------------------
        public void undo()
        {
            if (undoStack.Count > 0)
            {
                elementList.removeLastElement();
                redoStack.Push(undoStack.Pop());
            }
            elementList.clearSelection();
        }

        //------------------------------------------------------------------
        // Adds the most recently removed item back into the list. Stores
        // that item from the redo stack into the undo stack.
        //------------------------------------------------------------------
        public void redo()
        {
            if (redoStack.Count > 0)
            {
                elementList.addElement(redoStack.Peek());
                undoStack.Push(redoStack.Pop());
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
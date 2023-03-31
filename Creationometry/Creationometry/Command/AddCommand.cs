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
    // Purpose: This class will add a Design Element to the list of
    //          Canvas Design Elements. It will keep a record of all the
    //          elements added so that the element can be added, the 
    //          add can be undone by removing the element from the list,
    //          and the add can be redone by adding the element back
    //          into the list. This class implements the ICommand
    //          interface.
    //------------------------------------------------------------------
    public class AddCommand : ICommand
    {
        // Attributes - state
        private CanvasElementList elementList;
        private Stack<DesignElement> undoStack;
        private Stack<DesignElement> redoStack;

        // Constructor
        public AddCommand(CanvasElementList elementList)
        {
            this.elementList = elementList;
            undoStack = new Stack<DesignElement>();
            redoStack = new Stack<DesignElement>();
        }

        //------------------------------------------------------------------
        // Unused overloaded execute method.
        //------------------------------------------------------------------
        public bool execute()
        {
            return false;
        }

        //------------------------------------------------------------------
        // Unused overloaded execute method.
        //------------------------------------------------------------------
        public bool execute(DesignElement selectedElement)
        {
            return false;
        }

        //------------------------------------------------------------------
        // Creates a single design element of the specified type by calling
        // the default constructor. The element is then added
        // to the list of elements and the undo stack.
        //------------------------------------------------------------------
        public bool execute(DesignElementTypes elementType, System.Drawing.Point[] points)
        {
            DesignElement elementToAdd = null;
            bool isSuccess = true;

            // Determine which type of element to create
            if (elementType == DesignElementTypes.CIRCLE)
                elementToAdd = new Ellipses(isCircle: true);
            else if (elementType == DesignElementTypes.ELLIPSE)
                elementToAdd = new Ellipses(isCircle: false);
            else if (elementType == DesignElementTypes.LINE)
                elementToAdd = new Lines();
            else if (elementType == DesignElementTypes.REG_POLYGON)
                elementToAdd = new RegularPolygon(isPolygon: true, isTriangle: false, isRectangle: false);
            else if (elementType == DesignElementTypes.TRIANGLE)
                elementToAdd = new RegularPolygon(isPolygon: false, isTriangle: true, isRectangle: false);
            else if (elementType == DesignElementTypes.RECTANGLE)
                elementToAdd = new RegularPolygon(isPolygon: false, isTriangle: false, isRectangle: true);
            else if (elementType == DesignElementTypes.DRAWN_POLYGON)
                elementToAdd = new Polygon(points);
            else
                isSuccess = false;

            if (elementToAdd != null)
            {
                // Add created element to the list and local stack
                elementList.addElement(elementToAdd);
                undoStack.Push(copyElementState(elementToAdd));
            }
            return isSuccess;
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
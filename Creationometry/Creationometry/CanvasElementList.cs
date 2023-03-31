using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Creationometry.Presenters;

namespace Creationometry
{
    //------------------------------------------------------------------
    // Name:    Megan Baxter
    // Project: Creationometry
    // Purpose: This class will manage the list that holds all of the 
    //          Design Elements of the system. It is the receiver of
    //          of Commands from the Command Pattern.
    //------------------------------------------------------------------
    public class CanvasElementList
    {
        // Local list for storing canvas elements
        private List<DesignElement> elementList;

        // EMMenuPresenterManager
        private EMMenuPresenterManager eMMenuPresenterManager;

        // Border Panel to hide and show when selecting/deselecting
        private Panel borderPanel;

        // Constructor
        public CanvasElementList()
        {
            elementList = new List<DesignElement>();
        }

        // Parameterized Constructor
        public CanvasElementList(EMMenuPresenterManager eMMenuPresenterManager, Panel borderPanel)
        {
            elementList = new List<DesignElement>();
            this.eMMenuPresenterManager = eMMenuPresenterManager;
            this.borderPanel = borderPanel;
        }

        //------------------------------------------------------------------
        // Returns the eMMenuPresenterManager attribute.
        //------------------------------------------------------------------
        public EMMenuPresenterManager getEMMenuPresenterManager()
        {
            return eMMenuPresenterManager;
        }

        //------------------------------------------------------------------
        // Checks if the local list is empty.
        // Returns true if the list is empty, or false if it is not.
        //------------------------------------------------------------------
        public bool isEmpty()
        {
            bool empty = false;
            if (elementList.Count() == 0)
                empty = true;
            return empty;
        }

        //------------------------------------------------------------------
        // Checks the count of elements within the list.
        // Returns the size of the list.
        //------------------------------------------------------------------
        public int getListSize()
        {
            return elementList.Count;
        }

        //------------------------------------------------------------------
        // Returns the index of a specific element.
        //------------------------------------------------------------------
        public int getIndex(DesignElement elementToFind)
        {
            return elementList.IndexOf(elementToFind);
        }

        //------------------------------------------------------------------
        // Adds an element to the local list.
        // Reads in an element to add to the end of the local list.
        // Returns true if successful, or false if unsuccessful.
        //------------------------------------------------------------------
        public bool addElement(DesignElement inElement)
        {
            int originalSize = elementList.Count;
            elementList.Add(inElement);
            return elementList.Count > originalSize;
        }

        //------------------------------------------------------------------
        // Inserts an element to the local list.
        // Reads in an element to add to and the index of where it should be
        // located within the local list.
        // Returns the current index of the new item.
        //------------------------------------------------------------------
        public int insertElement(int inIndex, DesignElement inElement)
        {
            elementList.Insert(inIndex, inElement);
            return elementList.IndexOf(inElement);
        }

        //------------------------------------------------------------------
        // Removes an element from the local list.
        // Reads in an element to be removed from the local list.
        // Returns the index of the element that was removed.
        //------------------------------------------------------------------
        public int removeElement(DesignElement inElement)
        {
            int index = elementList.IndexOf(inElement);
            elementList.Remove(inElement);
            return index;
        }

        //------------------------------------------------------------------
        // Removes an element from the local list.
        // Reads in an element to be removed from the local list.
        // Returns the index of the element that was removed.
        //------------------------------------------------------------------
        public int removeLastElement()
        {
            int index = -1;
            if (elementList.Count > 0)
            {
                index = elementList.Count - 1;
                elementList.Remove(elementList[index]);
            }
            return index;
        }

        //------------------------------------------------------------------
        // Removes all elements from the local list.
        // Returns true if successful, or false if unsuccessful.
        //------------------------------------------------------------------
        public bool clearList()
        {
            bool successful = false;

            elementList.Clear();
            if (elementList.Count == 0)
                successful = true;

            return successful;
        }

        //------------------------------------------------------------------
        // Displays all elements from the local list.
        // Calls the show method from the DesignElement class.
        //------------------------------------------------------------------
        public void showList(PaintEventArgs e)
        {
            for (int i = 0; i < elementList.Count(); i++)
                elementList[i].show(e);
        }

        //------------------------------------------------------------------
        // Finds the element at a specific index and returns it..
        //------------------------------------------------------------------
        public DesignElement getElement(int index)
        {
            DesignElement tempElement = null;
            if (index < elementList.Count && index >= 0)
                tempElement = elementList[index];

            return tempElement;
        }

        //------------------------------------------------------------------
        // Finds the element that is selected.
        // Returns the most recently added element that is selected.
        //------------------------------------------------------------------
        public DesignElement getSelectedElement()
        {
            DesignElement tempElement = null;
            for (int i = elementList.Count() - 1; i >= 0; i--)
            {
                if (elementList[i].getIsSelected())
                    tempElement = elementList[i];
            }

            return tempElement;
        }

        //------------------------------------------------------------------
        // Determines which element in the list is selected starting with
        // the most recently added element.
        //------------------------------------------------------------------
        public void selectElement(int mouseX, int mouseY)
        {
            DesignElement selectedElement = null;
            for (int i = elementList.Count() - 1; i >= 0; i--)
            {
                if (elementList[i].checkMouseDownSelection(mouseX, mouseY))
                {
                    selectedElement = elementList[i];
                    break;
                }
            }

            if (eMMenuPresenterManager != null)
            {
                // Will show EMMenu if a shape was selected
                // Will hide EMMenu if nothing was selected
                if (selectedElement != null)
                {
                    eMMenuPresenterManager.setSelectedElement(selectedElement);
                    eMMenuPresenterManager.showEMMenu();
                }
                else
                {
                    eMMenuPresenterManager.hideEMMenu();
                }
            }

            if (selectedElement != null && borderPanel != null)
            {
                // Hide border panel if it is an ellipse
                if (typeof(Ellipses).IsInstanceOfType(selectedElement))
                    borderPanel.Visible = false;
                else
                    borderPanel.Visible = true;
            }
        }

        //------------------------------------------------------------------
        // Clears any selected elements by updating the isSelected attribute
        // for all of the DesignElements.
        //------------------------------------------------------------------
        public void clearSelection()
        {
            for (int i = 0; i < elementList.Count; i++)
                elementList[i].setIsSelected(false);
            if (eMMenuPresenterManager != null)
                eMMenuPresenterManager.hideEMMenu();
            if (borderPanel != null)
                borderPanel.Visible = false;
        }

        //------------------------------------------------------------------
        // Replaces the element at a specific location with the element
        // that has been passed.
        //------------------------------------------------------------------
        public void restoreElement(int index, DesignElement restorationElement)
        {
            elementList[index] = restorationElement;
        }
    }
}
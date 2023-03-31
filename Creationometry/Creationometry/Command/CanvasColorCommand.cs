using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Creationometry
{
    //------------------------------------------------------------------
    // Name:    Megan Baxter, Callie Seehafer
    // Project: Creationometry
    // Purpose: This class will update the color of the Canvas. It will
    //          keep a record of all the colors used so that the color
    //          can be modified, the color modification can be undone,
    //          and the color modification can be redone. This class
    //          implements the ICommand interface.
    //------------------------------------------------------------------
    public class CanvasColorCommand : ICommand
    {
        // Attributes - state
        private ColorDialog canvasColorSelection;
        private Panel Canvas;
        private Color canvasColor;
        private Stack<Color> undoStack;
        private Stack<Color> redoStack;

        // Constructor
        public CanvasColorCommand(Panel Canvas)
        {
            canvasColorSelection = new ColorDialog();
            this.Canvas = Canvas;
            undoStack = new Stack<Color>();
            redoStack = new Stack<Color>();
            Canvas.BackColor = Color.White;
            canvasColor = Canvas.BackColor;
        }

        //------------------------------------------------------------------
        // Stores current color to undo stack and updates color of Canvas.
        //------------------------------------------------------------------
        public bool execute()
        {
            bool isSuccess = true;
            if (canvasColorSelection.ShowDialog() == DialogResult.OK)
            {
                canvasColor = canvasColorSelection.Color;
                undoStack.Push(Canvas.BackColor);
                Canvas.BackColor = canvasColor;
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
        // Stores current color to redo stack and update color of Canvas from
        // undo stack.
        //------------------------------------------------------------------
        public void undo()
        {
            redoStack.Push(Canvas.BackColor);

            if (undoStack.Count > 0)
                Canvas.BackColor = undoStack.Pop();
        }

        //------------------------------------------------------------------
        // Stores current color to undo stack and update color of Canvas
        // from redo stack.
        //------------------------------------------------------------------
        public void redo()
        {
            undoStack.Push(Canvas.BackColor);

            if (redoStack.Count > 0)
                Canvas.BackColor = redoStack.Pop();
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
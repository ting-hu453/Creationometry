using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Creationometry
{
    //------------------------------------------------------------------
    // Name:    Megan Baxter
    // Project: Creationometry
    // Purpose: This class is an abstract class to manage some methods
    //          in Ellipse, Line, Polygon, and RegularPolygon classes.
    //-----------------------------------------------------------------
    public abstract class DesignElement
    {
        // Attribute for tracking selection
        public bool isSelected;

        // Attribute for tracking rotation angle
        public float orientationAngle;

        //------------------------------------------------------------------
        // Updates the isSelected attribute to match the passed parameter.
        //------------------------------------------------------------------
        public abstract void setIsSelected(bool isSelected);

        //------------------------------------------------------------------
        // Updates the orientationAngle attribute to match the passed
        // parameter.
        //------------------------------------------------------------------
        public abstract void setOrientationAngle(float orientationAngle);

        //------------------------------------------------------------------
        // Returns the status of the isSelected attribute.
        //------------------------------------------------------------------
        public abstract bool getIsSelected();

        //------------------------------------------------------------------
        // Returns the status of the isSelected attribute.
        //------------------------------------------------------------------
        public abstract float getOrientationAngle();

        //------------------------------------------------------------------
        // Displays the object using the passed paint event.
        //------------------------------------------------------------------
        public abstract void show(PaintEventArgs e);

        //------------------------------------------------------------------
        // Determines if the mouse parameters are within the object and 
        // update the isSelected attribute.
        //------------------------------------------------------------------
        public abstract bool checkMouseDownSelection(int mouseX, int mouseY);

        //------------------------------------------------------------------
        // Update the color attribute of each shape to match the passed
        // parameter.
        //------------------------------------------------------------------
        public abstract void changeColor(Color inputColor);

        //------------------------------------------------------------------
        // Update the lineWeight attribute of each shape to match the passed
        // parameter and the label will be visible when the user input is
        // not valid. 
        //------------------------------------------------------------------
        public abstract bool changeWeight(TextBox inputChangeWeight, 
            Label errorMessageForWeight);

        //------------------------------------------------------------------
        // Reads in an offset value and modifies certain attributes to
        // create an appropriate placement of the element.
        //------------------------------------------------------------------
        public abstract void duplicationOffset(int offset);

        //------------------------------------------------------------------
        // Reads in a rotation value and modifies certain attributes to
        // create an appropriate rotation of the element.
        //------------------------------------------------------------------
        public abstract void rotateTransformAngle(float inputRotateAngle);

        //------------------------------------------------------------------
        // Reads in an x and y coordiantes for relocating the element. 
        //------------------------------------------------------------------
        public abstract void move(int x, int y);
    }
}
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Creationometry
{
    //------------------------------------------------------------------
    // Name:    Ting Hu
    // Project: Creationometry
    // Purpose: This class will manage the ellipses and the circles from 
    //          editing them to relocating them.
    //------------------------------------------------------------------
    public class Ellipses : Shape
    {
        // Constants
        private const float DEFAULT_ELLIPSE_WIDTH = 150;
        private const float DEFAULT_ELLIPSE_HEIGHT = 100;
        private const float DEFAULT_DIAMETER = 20;
        private const int DEFAULT_X_LOCATION = 0;
        private const int DEFAULT_Y_LOCATION = 0;
        private const float DEFAULT_WEIGHT = 1;

        // Attributes
        private Boolean isCircle;
        private float ellipseWidth, ellipseHeight;
        private int xLocation, yLocation;
        private float centerX, centerY;
        private float lineWeight;

        private GraphicsPath item;
        private Pen border;
        private Color borderColor;

        // Default Constructor
        public Ellipses()
        {
            ellipseWidth = DEFAULT_ELLIPSE_WIDTH;
            ellipseHeight = DEFAULT_ELLIPSE_HEIGHT;
            xLocation = DEFAULT_X_LOCATION;
            yLocation = DEFAULT_Y_LOCATION;
            lineWeight = DEFAULT_WEIGHT;
            borderColor = Color.Black;
            border = new Pen(borderColor, lineWeight);
            item = new GraphicsPath();
            isSelected = false;
            orientationAngle = 0;
            item.AddEllipse(xLocation, yLocation, ellipseWidth, ellipseHeight);
        }

        // Copy Constructor
        public Ellipses(Ellipses ellipseToCopy)
        {
            this.ellipseWidth = ellipseToCopy.ellipseWidth;
            this.ellipseHeight = ellipseToCopy.ellipseHeight;
            this.xLocation = ellipseToCopy.xLocation;
            this.yLocation = ellipseToCopy.yLocation;
            this.lineWeight = ellipseToCopy.lineWeight;
            this.borderColor = ellipseToCopy.borderColor;
            this.border = ellipseToCopy.border;
            this.centerX = ellipseToCopy.centerX;
            this.centerY = ellipseToCopy.centerY;
            this.isCircle = ellipseToCopy.isCircle;
            this.isSelected = ellipseToCopy.isSelected;
            this.orientationAngle = ellipseToCopy.orientationAngle;
            this.item = new GraphicsPath();
            this.item.AddEllipse(this.xLocation, this.yLocation, this.ellipseWidth, this.ellipseHeight);
        }

        // Circle Constructor
        public Ellipses(bool isCircle)
        {
            this.isCircle = isCircle;
            if (isCircle)
            {
                ellipseHeight = DEFAULT_DIAMETER;
                ellipseWidth = DEFAULT_DIAMETER;
            }
            else
            {
                ellipseWidth = DEFAULT_ELLIPSE_WIDTH;
                ellipseHeight = DEFAULT_ELLIPSE_HEIGHT;
            }
            xLocation = DEFAULT_X_LOCATION;
            yLocation = DEFAULT_Y_LOCATION;
            lineWeight = DEFAULT_WEIGHT;
            borderColor = Color.Black;
            border = new Pen(borderColor, lineWeight);
            isSelected = false;
            orientationAngle = 0;
            item = new GraphicsPath();
            item.AddEllipse(xLocation, yLocation, ellipseWidth, ellipseHeight);
        }

        //------------------------------------------------------------------
        // Reads in an offset value and modifies certain attributes to
        // create an appropriate placement of the object.
        //------------------------------------------------------------------
        public override void duplicationOffset(int offset)
        {
            item.Reset();
            xLocation += offset;
            yLocation += offset;
            item.AddEllipse(xLocation, yLocation, ellipseWidth, ellipseHeight);
        }

        //------------------------------------------------------------------
        // Return the value of the ellipseWidth attribute.
        //------------------------------------------------------------------  
        public float getEllipseWidth()
        {
            return ellipseWidth;
        }

        //------------------------------------------------------------------
        // Return the value of the ellipseHeight attribute.
        //------------------------------------------------------------------  
        public float getEllipseHeight()
        {
            return ellipseHeight;
        }

        //------------------------------------------------------------------
        // Return the value of the xLocation attribute.
        //------------------------------------------------------------------  
        public int getXLocation()
        {
            return xLocation;
        }
        //------------------------------------------------------------------
        // Return the value of the yLocation attribute.
        //------------------------------------------------------------------  
        public int getYLocation()
        {
            return yLocation;
        }
        //------------------------------------------------------------------
        // Return the value of the border attribute.
        //------------------------------------------------------------------
        public Pen getBorder()
        {
            return border;
        }
        //------------------------------------------------------------------
        // Return the value of the isSelected attribute.
        //------------------------------------------------------------------
        public override bool getIsSelected()
        {
            return isSelected;
        }
        //------------------------------------------------------------------
        // Return the value of the isCircle attribute.
        //------------------------------------------------------------------
        public bool getIsCircle()
        {
            return isCircle;
        }

        //------------------------------------------------------------------
        // Return the value of the borderColor attribute.
        //------------------------------------------------------------------
        public Color getBorderColor()
        {
            return borderColor;
        }

        //------------------------------------------------------------------
        // Return the value of the lineWeight attribute.
        //------------------------------------------------------------------
        public float getLineWeight()
        {
            return lineWeight;
        }
        //------------------------------------------------------------------
        // Return the value of the item attribute.
        //------------------------------------------------------------------
        public GraphicsPath getItem()
        {
            return item;
        }

        //------------------------------------------------------------------
        // Return the status of the isSelected attribute.
        //------------------------------------------------------------------
        public override float getOrientationAngle()
        {
            return orientationAngle;
        }

        //------------------------------------------------------------------
        // Update the ellipseWidth attribute to match the passed parameter.
        //------------------------------------------------------------------ 
        public void setEllipseWidth(float ellipseWidth)
        {
            this.ellipseWidth = ellipseWidth;
        }
        //------------------------------------------------------------------
        // Update the ellipseHeight attribute to match the passed parameter.
        //------------------------------------------------------------------ 
        public void setEllipseHeight(float ellipseHeight)
        {
            this.ellipseHeight = ellipseHeight;
        }
        //------------------------------------------------------------------
        // Update the xLocation attribute to match the passed parameter.
        //------------------------------------------------------------------ 
        public void setXLocation(int xLocation)
        {
            this.xLocation = xLocation;
        }
        //------------------------------------------------------------------
        // Update the yLocation attribute to match the passed parameter.
        //------------------------------------------------------------------ 
        public void setYLocation(int yLocation)
        {
            this.yLocation = yLocation;
        }
        //------------------------------------------------------------------
        // Sets the x position of p0 (center point), temporary
        //------------------------------------------------------------------ 
        public void setP0X(float value)
        {
            setXLocation((int)(value - (ellipseWidth / 2)));
            centerXPos();
            centerYPos();
        }
        //------------------------------------------------------------------
        // Update the border attribute to match the passed parameter.
        //------------------------------------------------------------------ 
        public void setBorder(Pen border)
        {
            this.border = border;
        }
        //------------------------------------------------------------------
        // Update the borderColor attribute to match the passed parameter.
        //------------------------------------------------------------------ 
        public void setBorderColor(Color borderColor)
        {
            this.borderColor = borderColor;
        }
        //------------------------------------------------------------------
        // Update the lineWeight attribute to match the passed parameter.
        //------------------------------------------------------------------ 
        public void setLineWeight(float lineWeight)
        {
            this.lineWeight = lineWeight;
        }

        //------------------------------------------------------------------
        // Update the item attribute to match the passed parameter.
        //------------------------------------------------------------------ 
        public void setItem(GraphicsPath item)
        {
            this.item = item;
        }

        //------------------------------------------------------------------
        // Update the isSelected attribute to match the passed parameter and 
        // change the color of the border.
        //------------------------------------------------------------------ 
        public override void setIsSelected(bool isSelected)
        {
            this.isSelected = isSelected;
            if (isSelected)
                border = new Pen(Color.Red, lineWeight);
            else
                border = new Pen(borderColor, lineWeight);
        }

        //------------------------------------------------------------------
        // Update the orientationAngle attribute to match the passed
        // parameter.
        //------------------------------------------------------------------
        public override void setOrientationAngle(float orientationAngle)
        {
            this.orientationAngle = orientationAngle;
        }

        //------------------------------------------------------------------
        // Display the object using the passed paint event.
        //------------------------------------------------------------------
        public override void show(PaintEventArgs e)
        {
            item.Reset();
            item.AddEllipse(xLocation, yLocation, ellipseWidth, ellipseHeight);
            System.Drawing.Point temp = new System.Drawing.Point((int)centerX, (int)centerY);
            item.Transform(RotateAroundPoint(orientationAngle, temp));
            e.Graphics.DrawPath(border, item);
        }
        //------------------------------------------------------------------
        // Method to get the x-coordinate of center of the ellipse. 
        //------------------------------------------------------------------
        public float centerXPos()
        {
            centerX = (getEllipseWidth() / 2) + getXLocation();
            return centerX;
        }
        //------------------------------------------------------------------
        // Method to get the y-coordinate of center of the ellipse. 
        //------------------------------------------------------------------
        public float centerYPos()
        {
            centerY = (getEllipseHeight() / 2) + getYLocation();
            return centerY;
        }
        //------------------------------------------------------------------
        // Method to change the borderColor to red when the mouse down event 
        // is inside of the object or on the border of the obejct. 
        //------------------------------------------------------------------
        public override bool checkMouseDownSelection(int mouseX, int mouseY)
        {
            isSelected = false;
            if (item.IsVisible(mouseX, mouseY) == true)
            {
                isSelected = true;
                border = new Pen(Color.Red, lineWeight);
                return true;
            }
            return false;
        }

        //------------------------------------------------------------------
        // Method to change the borderColor by the user input from the color
        // dialog. 
        //------------------------------------------------------------------
        public override void changeColor(Color inputColor)
        {
            borderColor = inputColor;
        }

        //------------------------------------------------------------------
        // Method to change the weight of the border by the user input from
        // the text box and the label shows if the user input is not valid. 
        //------------------------------------------------------------------
        public override bool changeWeight(TextBox inputChangeWeight, Label errorMessageForWeight)
        {
            bool isSuccess = true;
            if (inputChangeWeight.Text != "")
            {
                float temp = float.Parse(inputChangeWeight.Text);
                if (temp > 0)
                {
                    lineWeight = float.Parse(inputChangeWeight.Text);
                    errorMessageForWeight.Visible = false;
                }
                else
                {
                    errorMessageForWeight.Visible = true;
                    isSuccess = false;
                }

                inputChangeWeight.Clear();
            }
            else
            {
                errorMessageForWeight.Visible = true;
                isSuccess = false;
            }

            return isSuccess;
        }

        //------------------------------------------------------------------
        // Method to rotate a angle of the shape by the user input from
        // the text box.
        //------------------------------------------------------------------
        public override void rotateTransformAngle(float inputRotateAngle)
        {
            orientationAngle += inputRotateAngle;
            System.Drawing.Point temp = new System.Drawing.Point((int)centerX, (int)centerY);
            this.item.Transform(RotateAroundPoint(orientationAngle, temp));
        }

        //------------------------------------------------------------------
        // Method is to translate the point to the origin. 
        //------------------------------------------------------------------
        private Matrix RotateAroundPoint(float angle, System.Drawing.Point center)
        {
            Matrix result = new Matrix();
            result.RotateAt(angle, center);
            return result;
        }

        //------------------------------------------------------------------
        // Method to move the shape by the user input from the mouse down
        // event. 
        //------------------------------------------------------------------
        public override void move(int x, int y)
        {
            item.Reset();

            xLocation = x;
            yLocation = y;
            centerXPos();
            centerYPos();

            this.item.AddEllipse(x, y, ellipseWidth, ellipseHeight);
        }
    }
}
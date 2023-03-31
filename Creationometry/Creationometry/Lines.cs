using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Creationometry
{
    //------------------------------------------------------------------
    // Name:    Callie Seehafer
    // Project: Creationometry
    // Purpose: This class will manage the lines from editing them to
    //          relocating them.
    //------------------------------------------------------------------
    public class Lines : DesignElement
    {
        // Constants
        private const float DEFAUALT_LINE_VAL_ONE_X = 10;
        private const float DEFAUALT_LINE_VAL_ONE_Y = 0;
        private const float DEFAUALT_LINE_VAL_TWO_X = 10;
        private const float DEFAUALT_LINE_VAL_TWO_Y = 50;
        private const float DEFAULT_WEIGHT = 1;
        private const float DIVISOR = 2;

        // Attributes
        private float xValOne, yValOne, xValTwo, yValTwo;
        private float centerX, centerY, lineWeight;
        private GraphicsPath item;
        private Pen borderColor;
        private Color color;

        //------------------------------------------------------------------
        // Default Constructor
        //------------------------------------------------------------------
        public Lines()
        {
            xValOne = DEFAUALT_LINE_VAL_ONE_X;
            yValOne = DEFAUALT_LINE_VAL_ONE_Y;
            xValTwo = DEFAUALT_LINE_VAL_TWO_X;
            yValTwo = DEFAUALT_LINE_VAL_TWO_Y;
            centerX = DEFAUALT_LINE_VAL_ONE_X;
            centerY = DEFAUALT_LINE_VAL_TWO_Y / DIVISOR;
            lineWeight = DEFAULT_WEIGHT;
            color = Color.Black;
            borderColor = new Pen(color, lineWeight);
            item = new GraphicsPath();
            isSelected = false;
            orientationAngle = 0;
            item.AddLine(xValOne, yValOne, xValTwo, yValTwo);
        }

        //------------------------------------------------------------------
        // Copy Constructor
        //------------------------------------------------------------------
        public Lines(Lines linesToCopy)
        {
            this.xValOne = linesToCopy.xValOne;
            this.yValOne = linesToCopy.yValOne;
            this.xValTwo = linesToCopy.xValTwo;
            this.yValTwo = linesToCopy.yValTwo;
            this.lineWeight = linesToCopy.lineWeight;
            this.borderColor = linesToCopy.borderColor;
            this.color = linesToCopy.color;
            this.isSelected = linesToCopy.isSelected;
            this.orientationAngle = linesToCopy.orientationAngle;
            this.item = new GraphicsPath();
            this.item.AddLine(this.xValOne, this.yValOne, this.xValTwo, this.yValTwo);

            this.centerX = linesToCopy.getCenterX();
            this.centerY = linesToCopy.getCenterY();
        }

        //------------------------------------------------------------------
        // Return the value of the xValOne attribute.
        //------------------------------------------------------------------        
        public float getP1X()
        {
            return xValOne;
        }

        //------------------------------------------------------------------
        // Return the value of the xValTwo attribute.
        //------------------------------------------------------------------  
        public float getP2X()
        {
            return xValTwo;
        }

        //------------------------------------------------------------------
        // Update the xValOne attribute to match the passed parameter.
        //------------------------------------------------------------------  
        public void setP1X(float xValOne)
        {
            this.xValOne = xValOne;
        }

        //------------------------------------------------------------------
        // Update the xValTwo attribute to match the passed parameter.
        //------------------------------------------------------------------  
        public void setP2X(float xValTwo)
        {
            this.xValTwo = xValTwo;
        }

        //------------------------------------------------------------------
        // Return the value of the yValOne attribute.
        //------------------------------------------------------------------ 
        public float getP1Y()
        {
            return yValOne;
        }

        //------------------------------------------------------------------
        // Return the value of the yValTwo attribute.
        //------------------------------------------------------------------ 
        public float getP2Y()
        {
            return yValTwo;
        }

        //------------------------------------------------------------------
        // Update the yValOne attribute to match the passed parameter.
        //------------------------------------------------------------------
        public void setP1Y(float yValOne)
        {
            this.yValOne = yValOne;
        }

        //------------------------------------------------------------------
        // Update the yValTwo attribute to match the passed parameter.
        //------------------------------------------------------------------
        public void setP2Y(float yValTwo)
        {
            this.yValTwo = yValTwo;
        }

        //------------------------------------------------------------------
        // Return the value of the borderColor attribute.
        //------------------------------------------------------------------
        public Pen getBorderColor()
        {
            return borderColor;
        }

        //------------------------------------------------------------------
        // Update the borderColor attribute to match the passed parameter.
        //------------------------------------------------------------------
        public void setBorderColor(Pen borderColor)
        {
            this.borderColor = borderColor;
        }

        //------------------------------------------------------------------
        // Return the value of the color attribute.
        //------------------------------------------------------------------
        public Color getColor()
        {
            return color;
        }

        //------------------------------------------------------------------
        // Update the color attribute to match the passed parameter.
        //------------------------------------------------------------------ 
        public void setColor(Color color)
        {
            this.color = color;
        }

        //------------------------------------------------------------------
        // Return the value of the lineWeight attribute.
        //------------------------------------------------------------------
        public float getBorderWidth()
        {
            return lineWeight;
        }

        //------------------------------------------------------------------
        // Update the lineWeight attribute to match the passed parameter.
        //------------------------------------------------------------------ 
        public void setBorderWidth(float lineWeight)
        {
            this.lineWeight = lineWeight;
        }

        //------------------------------------------------------------------
        // Return the value of the centerX attribute.
        //------------------------------------------------------------------
        public float getCenterX()
        {
            centerX = (xValOne + xValTwo) / DIVISOR;
            return centerX;
        }

        //------------------------------------------------------------------
        // Update the centerX attribute to match the passed parameter.
        //------------------------------------------------------------------
        public void setCenterX(float centerX)
        {
            this.centerX = centerX;
        }

        //------------------------------------------------------------------
        // Return the value of the centerY attribute.
        //------------------------------------------------------------------
        public float getCenterY()
        {
            centerY = (yValOne + yValTwo) / DIVISOR;
            return centerY;
        }

        //------------------------------------------------------------------
        // Update the centerY attribute to match the passed parameter.
        //------------------------------------------------------------------
        public void setCenterY(float centerY)
        {
            this.centerY = centerY;
        }

        //------------------------------------------------------------------
        // Return the value of the item attribute.
        //------------------------------------------------------------------
        public GraphicsPath getItem()
        {
            return item;
        }

        //------------------------------------------------------------------
        // Update the item attribute to match the passed parameter.
        //------------------------------------------------------------------ 
        public void setItem(GraphicsPath item)
        {
            this.item = item;
        }

        //------------------------------------------------------------------
        // Return the value of the isSelected attribute.
        //------------------------------------------------------------------
        public override bool getIsSelected()
        {
            return this.isSelected;
        }

        //------------------------------------------------------------------
        // Update the isSelected attribute to match the passed parameter
        // and update the borderColor depending on if the line is selected 
        // or not selected.
        //------------------------------------------------------------------
        public override void setIsSelected(bool isSelected)
        {
            this.isSelected = isSelected;
            if (isSelected)
                borderColor = new Pen(Color.Red, lineWeight);
            else
                borderColor = new Pen(color, lineWeight);
        }

        //------------------------------------------------------------------
        // Return the status of the isSelected attribute.
        //------------------------------------------------------------------
        public override float getOrientationAngle()
        {
            return orientationAngle;
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
        // Method to display a line using the passed paint event parameter.
        //------------------------------------------------------------------
        public override void show(PaintEventArgs e)
        {
            item.Reset();
            item.AddLine(xValOne, yValOne, xValTwo, yValTwo);
            System.Drawing.Point temp = new System.Drawing.Point((int)centerX, (int)centerY);
            item.Transform(RotateAroundPoint(orientationAngle, temp));
            e.Graphics.DrawPath(borderColor, item);
        }

        //------------------------------------------------------------------
        // Method to change the borderColor to red if the mouse is on the
        // line by checking the passed mouse coordinate parameters. Also
        // changes the isSelected attribute to true if the line is selected.
        //------------------------------------------------------------------
        public override bool checkMouseDownSelection(int mouseX, int mouseY)
        {
            isSelected = false;
            if (item.IsOutlineVisible(mouseX, mouseY, borderColor))
            {
                isSelected = true;
                borderColor = new Pen(Color.Red, lineWeight);
                return true;
            }
            return false;
        }

        //------------------------------------------------------------------
        // Method that modifies certain attributes by the passed in 
        // parameter in order to create an appropriate placement of a line.
        //------------------------------------------------------------------
        public override void duplicationOffset(int offset)
        {
            item.Reset();
            xValOne += offset;
            xValTwo += offset;
            yValOne += offset;
            yValTwo += offset;
            item.AddLine(xValOne, yValOne, xValTwo, yValTwo);
        }

        //------------------------------------------------------------------
        // Method to change the borderColor to match the passed parameter. 
        //------------------------------------------------------------------
        public override void changeColor(Color inputColor)
        {
            color = inputColor;
        }

        //------------------------------------------------------------------
        // Method to change the lineWeight attribute to match the passed
        // parameter that comes from the text box but shows a label if the
        // passed parameter is not valid. Returns true if the lineWeight
        // change was successful and false if it was not successful.
        //------------------------------------------------------------------
        public override bool changeWeight(TextBox inputChangeWeight, Label errorMessageForWeight)
        {
            bool isSuccess = true;
            if (inputChangeWeight.Text != "")
            {
                float temp = float.Parse(inputChangeWeight.Text);
                if (temp < 0 || temp == 0)
                {
                    errorMessageForWeight.Visible = true;
                    isSuccess = false;
                }
                else
                {
                    lineWeight = float.Parse(inputChangeWeight.Text);
                    errorMessageForWeight.Visible = false;
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
        // Method to change the orientationAngle to match the passed 
        // parameter.
        //------------------------------------------------------------------
        public override void rotateTransformAngle(float inputRotateAngle)
        {
            orientationAngle += inputRotateAngle;
            System.Drawing.Point temp = new System.Drawing.Point((int)centerX, (int)centerY);
            this.item.Transform(RotateAroundPoint(orientationAngle, temp));
        }

        //------------------------------------------------------------------
        // Method to rotate a line using the passed parameters.
        //------------------------------------------------------------------
        private Matrix RotateAroundPoint(float angle, System.Drawing.Point center)
        {
            Matrix result = new Matrix();
            result.RotateAt(angle, center);
            return result;
        }

        //------------------------------------------------------------------
        // Method that modifies certain attributes by the passed 
        // parameters in order to move a line.
        //------------------------------------------------------------------
        public override void move(int x, int y)
        {
            item.Reset();

            int changeX = x - (int)centerX;
            int changeY = y - (int)centerY;

            xValOne += changeX;
            xValTwo += changeX;
            yValOne += changeY;
            yValTwo += changeY;
            centerX = x;
            centerY = y;

            this.item.AddLine(xValOne, yValOne, xValTwo, yValTwo);
        }
    }
}
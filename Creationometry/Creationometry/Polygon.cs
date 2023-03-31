using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Creationometry
{
    public class Polygon : Shape
    {
        // private attributes
        private const int MIN_SIDES = 3;
        private const int MIN_POINTS = 3;
        private const float DEFAULT_WEIGHT = 1;
        protected int numSides;
        private int pointCount;
        protected System.Drawing.Point[] points;
        protected System.Drawing.Point center = new System.Drawing.Point();

        // private SolidBrush fillColor = new SolidBrush(Color.LightSkyBlue);

        private GraphicsPath item;
        private Pen border;
        private Color borderColor;
        private float lineWeight;

        //------------------------------------------------------------------
        // Default Constructor
        //------------------------------------------------------------------
        public Polygon()
        {
            this.numSides = MIN_SIDES;
            this.pointCount = MIN_POINTS;
            this.points = new System.Drawing.Point[pointCount];
            lineWeight = DEFAULT_WEIGHT;

            for (int x = 0; x < this.pointCount; x++)
            {
                points[x] = new System.Drawing.Point();
            }

            borderColor = Color.Black;
            border = new Pen(borderColor, lineWeight);
            item = new GraphicsPath();
            item.AddPolygon(points);
            isSelected = false;
            orientationAngle = 0;
        }

        //------------------------------------------------------------------
        // Parameterized Constructor
        //------------------------------------------------------------------
        public Polygon(System.Drawing.Point[] points)
        {
            if (points != null)
            {
                this.points = new System.Drawing.Point[points.Length];
                this.pointCount = numSides;
                for (int x = 0; x < points.Length; x++)
                {
                    this.points[x] = points[x];
                }
                
                borderColor = Color.Black;
                border = new Pen(borderColor, lineWeight);
                item = new GraphicsPath();
                item.AddPolygon(this.points);//test
                calculateCenter();
                isSelected = false;
                orientationAngle = 0;
            }
        }

        //------------------------------------------------------------------
        // Copy Constructor
        //------------------------------------------------------------------
        public Polygon(Polygon polygonToCopy)
        {
            this.numSides = polygonToCopy.numSides;
            this.center.X = polygonToCopy.getCenter().X;
            this.center.Y = polygonToCopy.getCenter().Y;
            this.points = new System.Drawing.Point[polygonToCopy.getPoints().Length];
            for (int i = 0; i < polygonToCopy.getPoints().Length; i++)
                this.points[i] = polygonToCopy.getPoints()[i];
            this.borderColor = polygonToCopy.borderColor;
            this.border = polygonToCopy.border;
            this.lineWeight = polygonToCopy.lineWeight;
            this.item = new GraphicsPath();
            this.isSelected = polygonToCopy.isSelected;
            this.orientationAngle = polygonToCopy.orientationAngle;
            this.item.AddPolygon(points);
        }

        //------------------------------------------------------------------
        // Reads in an offset value and modifies certain attributes to
        // create an appropriate placement of the object.
        //------------------------------------------------------------------
        public override void duplicationOffset(int offset)
        {
            item.Reset();
            center.X += offset;
            center.Y += offset;
            for (int i = 0; i < points.Length; i++)
            {
                points[i].X = points[i].X + offset;
                points[i].Y = points[i].Y + offset;
            }
            item.AddPolygon(points);
        }

        //------------------------------------------------------------------
        // Return the value of the points array attribute.
        //------------------------------------------------------------------
        public System.Drawing.Point[] getPoints()
        {
            return this.points;
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
        // Return the value of the numSides attribute.
        //------------------------------------------------------------------
        public int getNumSides()
        {
            return numSides;
        }

        //------------------------------------------------------------------
        // Return the value of the center point attribute.
        //------------------------------------------------------------------
        public System.Drawing.Point getCenter()
        {
            return center;
        }

        //------------------------------------------------------------------
        // Return the value of the isSelected attribute.
        //------------------------------------------------------------------
        public override bool getIsSelected()
        {
            return this.isSelected;
        }

        //------------------------------------------------------------------
        // Return the status of the isSelected attribute.
        //------------------------------------------------------------------
        public override float getOrientationAngle()
        {
            return orientationAngle;
        }

        //------------------------------------------------------------------
        // Sets the isSelected variable to match the parameter.
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
        // Calculates the center of a polygon
        //------------------------------------------------------------------
        public void calculateCenter()
        {
            RectangleF boundRect = item.GetBounds();
            float tempX, tempY;
            tempX = boundRect.Width / 2 + boundRect.X;
            tempY = boundRect.Height / 2 + boundRect.Y;
            center.X = (int)tempX;
            center.Y = (int)tempY;
        }

        //------------------------------------------------------------------
        // Draws the polygon
        //------------------------------------------------------------------
        public override void show(System.Windows.Forms.PaintEventArgs e)
        {
            item.Reset();
            item.AddPolygon(points);
            System.Drawing.Point temp = new System.Drawing.Point(center.X, center.Y);
            item.Transform(RotateAroundPoint(orientationAngle, temp));
            e.Graphics.DrawPath(border, item);
        }


        //------------------------------------------------------------------
        // Checks if an object is selected.
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

        public override void rotateTransformAngle(float inputRotateAngle)
        {
            orientationAngle += inputRotateAngle;
            RectangleF boundRect = item.GetBounds();
            float tempX, tempY;
            tempX = boundRect.Width / 2 + boundRect.X;
            tempY = boundRect.Height / 2 + boundRect.Y;
            System.Drawing.Point temp = new System.Drawing.Point((int)tempX,(int)tempY);
            this.item.Transform(RotateAroundPoint(orientationAngle, temp));
        }

        private Matrix RotateAroundPoint(float angle, System.Drawing.Point center)
        {
            // Translate the point to the origin.
            Matrix result = new Matrix();
            result.RotateAt(angle, center);
            return result;
        }

        public override void move(int x, int y)
        {
            item.Reset();

            int changeX = x - center.X;
            int changeY = y - center.Y;

            for (int i = 0; i < points.Length; i++)
            {
                points[i].X += changeX;
                points[i].Y += changeY;
            }

            center.X = x;
            center.Y = y;

            this.item.AddPolygon(points);
        }
    }
}

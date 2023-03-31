using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Creationometry
{
    public class RegularPolygon : Polygon
    {
        //Private attributes
        private int sideLength;
        //private int numSides;
        private double startOrientationAngle;

        private const int MIN_SIDES = 3;

        private const int DEFAULT_X = 200;
        private const int DEFAULT_Y = 200;

        private const int DEFAULT_X_3 = 100;
        private const int DEFAULT_Y_3 = 150;

        private const int DEFAULT_X_4 = 200;
        private const int DEFAULT_Y_4 = 150;

        private const int DEFAULT_X_5 = 300;
        private const int DEFAULT_Y_5 = 150;

        private const double START_ANGLE = Math.PI / 2;
        private const int DEFAULT_SIDE_LENGTH = 50;
        private const int POLYGON_NUM_SIDES = 5;
        private const int TRIANGLE_NUM_SIDES = 3;
        private const int RECTANGLE_NUM_SIDES = 4;
        private const float DEFAULT_WEIGHT = 1;

        //private System.Drawing.Point center = new System.Drawing.Point();
        //private ArrayList points = new ArrayList();
        //private System.Drawing.Point[] points;

        private SolidBrush fillColor = new SolidBrush(Color.LightSkyBlue);
       // private bool isPolygon;
       // private bool isTriangle;
       // private bool isRectangle;

        private GraphicsPath item;
        private Pen border;
        private Color borderColor;
        private float lineWeight;


        //------------------------------------------------------------------
        // Default constructor
        //------------------------------------------------------------------
        public RegularPolygon()
        {
            this.sideLength = 1;
            this.numSides = MIN_SIDES;
            center.X = DEFAULT_X;
            center.Y = DEFAULT_Y;
            lineWeight = DEFAULT_WEIGHT;
            points = new System.Drawing.Point[this.numSides];
            startOrientationAngle = START_ANGLE;
            calculatePoints(startOrientationAngle);
            borderColor = Color.Black;
            border = new Pen(borderColor, lineWeight);
            item = new GraphicsPath();
            isSelected = false;
            orientationAngle = 0;
        }

        //------------------------------------------------------------------
        // Copy constructor
        //------------------------------------------------------------------
        public RegularPolygon(RegularPolygon regularPolygonToCopy)
        {
            this.sideLength = regularPolygonToCopy.sideLength;
            this.numSides = regularPolygonToCopy.numSides;
            this.center.X = regularPolygonToCopy.center.X;
            this.center.Y = regularPolygonToCopy.center.Y;
            this.points = new System.Drawing.Point[this.numSides];
            this.startOrientationAngle = regularPolygonToCopy.startOrientationAngle;
            this.calculatePoints(this.startOrientationAngle);
            this.lineWeight = regularPolygonToCopy.lineWeight;
            this.borderColor = regularPolygonToCopy.borderColor;
            this.border = regularPolygonToCopy.border;
            this.item = new GraphicsPath();
            this.isSelected = regularPolygonToCopy.isSelected;
            this.orientationAngle = regularPolygonToCopy.orientationAngle;
            this.item.AddPolygon(points);
        }

        //------------------------------------------------------------------
        // Parameterized Constructor
        //------------------------------------------------------------------
        public RegularPolygon(bool isPolygon, bool isTriangle, bool isRectangle)
        {
            this.sideLength = DEFAULT_SIDE_LENGTH;
            center.X = DEFAULT_X;
            center.Y = DEFAULT_Y;
            lineWeight = DEFAULT_WEIGHT;
            if (isPolygon)
            {
                this.numSides = POLYGON_NUM_SIDES;
                center.X = DEFAULT_X_5;
                center.Y = DEFAULT_Y_5;
                //this.isPolygon = true;
            }
            else if (isTriangle)
            {
                this.numSides = TRIANGLE_NUM_SIDES;
                center.X = DEFAULT_X_3;
                center.Y = DEFAULT_Y_3;
                //this.isTriangle = true;
            }
            else if (isRectangle)
            {
                this.numSides = RECTANGLE_NUM_SIDES;
                center.X = DEFAULT_X_4;
                center.Y = DEFAULT_Y_4;
                //this.isRectangle = true;
            }
            else
            {
                this.numSides = MIN_SIDES;
                //this.isTriangle = true;
            }

            points = new System.Drawing.Point[this.numSides];
            startOrientationAngle = START_ANGLE;
            calculatePoints(startOrientationAngle);
            borderColor = Color.Black;
            border = new Pen(borderColor, lineWeight);
            item = new GraphicsPath();
            item.AddPolygon(points);
            isSelected = false;
            orientationAngle = 0;
        }

        //------------------------------------------------------------------
        // Parameterized constructor
        //------------------------------------------------------------------
        public RegularPolygon(int sideLength, int numSides)
        {
            this.sideLength = sideLength;

            if (numSides >= MIN_SIDES)
                this.numSides = numSides;
            else
                this.numSides = MIN_SIDES;

            center.X = DEFAULT_X;
            center.Y = DEFAULT_Y;
            points = new System.Drawing.Point[this.numSides];
            startOrientationAngle = START_ANGLE;
            calculatePoints(startOrientationAngle);
            item = new GraphicsPath();
            item.AddPolygon(points);
            isSelected = false;
            orientationAngle = 0;
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
            calculatePoints(startOrientationAngle);
            item.AddPolygon(points);
        }
        
        //------------------------------------------------------------------
        // Return the point array attribute.
        //------------------------------------------------------------------
        /*public System.Drawing.Point[] getPoints()
        {
            return this.points;
        }*/

        //------------------------------------------------------------------
        // Calculates the points to make a polygon regular based on the 
        // center point at the rotaion angle given as the parameter.
        //------------------------------------------------------------------
        private void calculatePoints(double orientationAngle)
        {
            int radius = Convert.ToInt32(this.sideLength / (2 * Math.Sin(Math.PI / this.numSides)));
            //            Console.WriteLine(orientationAngle);
            for (int i = 0; i < numSides; i++)
            {
                System.Drawing.Point p = new System.Drawing.Point();
                p.X = Convert.ToInt32(center.X + radius * Math.Cos(2 * Math.PI * i / numSides + orientationAngle));

                p.Y = Convert.ToInt32(center.Y + radius * Math.Sin(2 * Math.PI * i / numSides + orientationAngle));
                points[i] = p;
                /*Console.WriteLine(p.X);
                Console.WriteLine(p.Y);
                Console.WriteLine();*/
            }
        }

        //------------------------------------------------------------------
        // Return the value of the numSides attribute.
        //------------------------------------------------------------------
        /*public int getNumSides()
        {
            return numSides;
        }*/

        //------------------------------------------------------------------
        // Return the value of the sideLength attribute.
        //------------------------------------------------------------------
        public int getSideLength()
        {
            return sideLength;
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
       /* public float getLineWeight()
        {
            return lineWeight;
        }*/

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
        /*public override float getOrientationAngle()
        {
            return orientationAngle;
        }
       **************************************************************************************************************************** */
        //------------------------------------------------------------------
        // Sets the side length to the parameter.
        //------------------------------------------------------------------
        public void setSideLength(int sideLength)
        {
            this.sideLength = sideLength;
            Array.Clear(points, 0, points.Length);
            calculatePoints(startOrientationAngle);
        }

        //------------------------------------------------------------------
        // Update the borderColor attribute to match the passed parameter.
        //------------------------------------------------------------------ 
       /* public void setBorderColor(Color borderColor)
        {
            this.borderColor = borderColor;
        }*/
        //------------------------------------------------------------------
        // Update the lineWeight attribute to match the passed parameter.
        //------------------------------------------------------------------ 
       /* public void setLineWeight(float lineWeight)
        {
            this.lineWeight = lineWeight;
        }*/

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
       /* public override void setOrientationAngle(float orientationAngle)
        {
            this.orientationAngle = orientationAngle;
        }*/

        //------------------------------------------------------------------
        // Return the value of the distance between two points, adjusted
        // to round to the correct int side length.
        //------------------------------------------------------------------
        //TODO: Was this not supposed to be overriden?
        //public override int distance(System.Drawing.Point p1, System.Drawing.Point p2)
        //public int distance(System.Drawing.Point p1, System.Drawing.Point p2)
        //{
        //    int distance = 0;
        //    int x = p2.X - p1.X;
        //    int y = p2.Y - p1.Y;

        //    double realDistance = Math.Sqrt((x * x) + (y * y));

        //    if (realDistance < this.sideLength)
        //        //distance = Convert.ToInt32(Math.Sqrt((x * x) + (y * y)));
        //        distance = Convert.ToInt32(Math.Ceiling(Math.Sqrt((x * x) + (y * y))));
        //    else
        //        distance = Convert.ToInt32(Math.Floor(Math.Sqrt((x * x) + (y * y))));

        //    return distance;
        //}

        //------------------------------------------------------------------
        // Returns the value of an innerAngle.
        //------------------------------------------------------------------
        public double innerAngleDeg()
        {
            return (numSides - 2) * 180 / numSides;
        }

        //------------------------------------------------------------------
        // Moves the polygon to the specified new center point.
        //------------------------------------------------------------------
       /* public void moveRegPolygon(System.Drawing.Point newCenter) // goes in Polygon
        {
            center.X = newCenter.X;
            center.Y = newCenter.Y;
            Array.Clear(points, 0, points.Length);
            calculatePoints(startOrientationAngle);
        }*/

        //------------------------------------------------------------------
        // Rotates the regular polygon.
        //------------------------------------------------------------------
       /* public void rotateRegPolygon(double rotationAngle) //Angle in radians
        {
            Array.Clear(points, 0, points.Length);
            this.startOrientationAngle += rotationAngle;
            calculatePoints(startOrientationAngle);
        }*/

        //------------------------------------------------------------------
        // Return the value of the center attribute.
        //------------------------------------------------------------------
        /*public System.Drawing.Point getCenter()
        {
            return center;
        }*/

        //------------------------------------------------------------------
        // Draws the polygon.
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

        //------------------------------------------------------------------
        // Method to  
        //------------------------------------------------------------------
        public override void rotateTransformAngle(float inputRotateAngle)
        {
            //float tempInput = float.Parse(inputRotateAngle.Text);
            orientationAngle += inputRotateAngle;

            System.Drawing.Point temp = new System.Drawing.Point(center.X, center.Y);
            //  this.item.Transform(RotateAroundPoint(tempInput, temp));
            this.item.Transform(RotateAroundPoint(orientationAngle, temp));
        }

        //------------------------------------------------------------------
        // Method to  
        //------------------------------------------------------------------
        private Matrix RotateAroundPoint(float angle, System.Drawing.Point center)
        {
            // Translate the point to the origin.
            Matrix result = new Matrix();
            result.RotateAt(angle, center);
            return result;
        }

        //------------------------------------------------------------------
        // Method to  
        //------------------------------------------------------------------
        public override void move(int x, int y)
        {
            //item = new GraphicsPath();
            //System.Drawing.Point temp = new System.Drawing.Point((int)center.X, (int)center.Y);
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

            //item.Reset();
            this.item.AddPolygon(points);
            //this.item.Transform(RotateAroundPoint(orientationAngle, center));
            // e.Graphics.DrawPath(border, item);
        }
    }
}

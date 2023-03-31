using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Creationometry
{
    public class DrawManager
    {
        //Private attributes
        private bool isDrawing;
        System.Drawing.Point[] points;
        List<System.Drawing.Point> pointList;
        private int MIN_POINTS = 3;

        //------------------------------------------------------------------
        // Constructor
        //------------------------------------------------------------------
        public DrawManager()
        {
            isDrawing = false;
            pointList = new List<System.Drawing.Point>();
            points = new System.Drawing.Point[MIN_POINTS];
        }

        //------------------------------------------------------------------
        // Starts or stops the drawing process and creates the complete
        // list of points if there are at least three points.
        //------------------------------------------------------------------
        public void drawPolygon()
        {
            if (!isDrawing)
            {
                isDrawing = true;
            }
            else
            {
                isDrawing = false;
                if (pointList.Count >= MIN_POINTS)
                {
                    points = pointList.ToArray();

                }
                pointList.Clear();
            }
        }

        //------------------------------------------------------------------
        // Adds a point at the location of a mouse click to the point list
        //------------------------------------------------------------------
        public void addPoint(int x, int y)
        {
            if (isDrawing)
            {
                System.Drawing.Point tempPoint = new System.Drawing.Point();
                tempPoint.X = x;
                tempPoint.Y = y;
                pointList.Add(tempPoint);

            }
        }

        //------------------------------------------------------------------
        // Return the array of points attribute.
        //------------------------------------------------------------------
        public System.Drawing.Point[] getPoints()
        {
            return points;
        }

        public void setIsDrawing(bool isDrawing)
        {
            this.isDrawing = isDrawing;
        }

        //------------------------------------------------------------------
        // Return the value of the isDrawing attribute.
        //------------------------------------------------------------------
        public bool getIsDrawing()
        {
            return isDrawing;
        }
    }
}

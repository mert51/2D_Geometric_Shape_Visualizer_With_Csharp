using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _241202071
{
    internal class Polygon
    {

        public double length;            //lenght data member of polygon class 
        public Color color;              // color data member of polygon class 
        public double numberofEdges;     // numberofEdges data member of polygon class 
        public double numberofedges;     // numberofedges data member of polygon class 
        public double angle;             // angle data member of polygon class 



        public Point2D firstvertexpoint = new Point2D(0, 0);    // this is first point of polygon. it start from here
        public Point2D Center { get; set; } = new Point2D(0, 0);  // this is center. polygon rotates around  this center coordinates 
        public Point2D[]? vertex { get; private set; }         // all vertex points of the polygon

        public double Length

        {
            get { return length; }
            set { length = value; }

        }   // property for length
        public double Angle
        {
            get { return angle; }
            set { angle = value; }
        }  // property for angle 
        public Color Color

        {
            get { return color; }
            set { color = value; }

        }     //property for color 
        public double NumberofEdges

        {
            get { return numberofEdges; }
            set { numberofEdges = value; }

        }   // property for numberofedges 

        public Polygon()
        {



        }    // constructor with no parameter 
        public Polygon(Point2D center, double length)
        {

            Center = center;
            Length = length;


        }   // second constructor for set/get the  inital center and length as parameter


        public void calculateEdgeCoordinates()
        {

            Random rnd = new Random();           //  to make random angle 
            double randomAngle = rnd.NextDouble() * 360.0; 
            double angleRadian = randomAngle * Math.PI / 180;   // to change angle to radian 

            double x = Center.X + Length * Math.Cos(angleRadian);  // with center and length and angle we calculate x
            double y = Center.Y + Length * Math.Sin(angleRadian);  // with center and length and angle we calculate y 

            firstvertexpoint = new Point2D(x, y);    // new first point with x and y 

        }  // method that calculates the firstvertexpoint 

        private bool isFirstVertexSet = false;
        public void CalculateAllEdgeCoordinates()
        {
            if (!isFirstVertexSet)
            {
                calculateEdgeCoordinates(); // Calculates the first vertex randomly
                isFirstVertexSet = true;
            }

            int n = (int)numberofEdges; // Number of edges of the polygon
            double angleStepDeg = 360.0 / n; // Angle between each vertex

            Point2D[] vertices = new Point2D[n]; // Array to hold the vertex coordinates
            vertices[0] = firstvertexpoint; // First vertex is already defined

            // Calculate vector from center to the first vertex
            double dx = firstvertexpoint.X - Center.X;
            double dy = firstvertexpoint.Y - Center.Y;

            for (int i = 1; i < n; i++)
            {
                double angleRad = (angleStepDeg * i) * Math.PI / 180.0;

                // Rotate the vector by the angle
                double rotatedX = dx * Math.Cos(angleRad) - dy * Math.Sin(angleRad);
                double rotatedY = dx * Math.Sin(angleRad) + dy * Math.Cos(angleRad);

                // Compute the new vertex position
                double newX = Center.X + rotatedX;
                double newY = Center.Y + rotatedY;

                vertices[i] = new Point2D(newX, newY); // Store the new vertex
            }

            vertex = vertices; // Assign the calculated vertices
        }  // with firstvertexpoint this method calculates other vertex points 

        public void rotatePolygon(bool Clockwise)
        {
            if (vertex == null || vertex.Length == 0)     // no points no rotation
                return;

            double angleToRotate = Angle;     // get angle for rotate

            if (!Clockwise)    // if not clockwise then rotate other side
                angleToRotate = -angleToRotate;

            double angleRadian = angleToRotate * Math.PI / 180;

            // new array for save rotated points
            Point2D[] rotatedVertices = new Point2D[vertex.Length];

            for (int i = 0; i < vertex.Length; i++)  // rotate all points
            {

                // find position from center
                double dx = vertex[i].X - Center.X;
                double dy = vertex[i].Y - Center.Y;


                // rotate x and y
                double rotatedX = dx * Math.Cos(angleRadian) - dy * Math.Sin(angleRadian);
                double rotatedY = dx * Math.Sin(angleRadian) + dy * Math.Cos(angleRadian);

                rotatedVertices[i] = new Point2D(rotatedX + Center.X, rotatedY + Center.Y);  // add center to rotated point and save
            }

            vertex = rotatedVertices;
        } // method that recalculates the vertex points of the polygon depending on the cw and ccw 

    }
}


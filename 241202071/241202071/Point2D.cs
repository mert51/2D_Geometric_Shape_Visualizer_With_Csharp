//************************************************************************************
//**                                                                                **
//**                              NAME: MERT                                        ** 
//**                              SURNAME: ÖNDER                                    **
//**                              NUMBER: B241202071                                **
//**                                                                                **
//************************************************************************************

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _241202071           //B241202071 
{
    internal class Point2D
    {
        public double x, y;   //data members of cartesian coordinates (x and y)
        public double r;      // data member of polar coordinates r
        public double a;      // data member of polar coordinates a
        public Point2D? Center { get; set; }

        public double X
        {
            get { return x; }
            set { x = value; }
        } // property for x

        public double Y
        {
            get { return y; }
            set { y = value; }
        } // property for y 

        public Point2D()
        {

        }    //default constructor with no parameters

        public Point2D(bool random)
        {
            Random rnd = new Random();  // to set random for x and y values we use this code line 
             x = rnd.Next(0, 4);
             y = rnd.Next(0, 4);

        }  // constructor that setting initial 2d coordiantes with random values

        public Point2D(double x, double y)
        {
            this.X = x;
            this.Y = y;
            this.r = Math.Sqrt(x * x + y * y);  // square root function 
            this.a = Math.Atan2(y, x);          // arctan function 
        }  // constructor sets x and y values and help us to calculate corresponding polar coordinates 

        public string printCoordinates()
        {
            return "X: " + x.ToString("F2") + "  Y: " + y.ToString("F2");
        }  // prints the coordinates of the point 2d 

        public (double r, double a) calculatePolarCoordinates()
        {


            r = Math.Sqrt(x * x + y * y);
            a = Math.Atan2(y, x);
            return (r, a);

        } //  method that calculates polar coordinates with x and y values and returns it 

        public void calculateCartesianCoordinates()
        {

            this.x = r * Math.Cos(a);
            this.y = r * Math.Sin(a);

        } // method that calculates caetesian coordinates with the help of r and a 

        public string printPolarCoordinates()
        {
            (double r, double a) = calculatePolarCoordinates();
            return "P(r=" + r.ToString("F2") + ", a=" + a.ToString("F2") + ")";
        }    // creates string for calcutated values of r and a 


    }
}

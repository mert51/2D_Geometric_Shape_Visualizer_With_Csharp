using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _241202071           // B241202071
{
    internal class ColorRGB
    {
        public double red;     // red data member of colorRGB 
        public double green;   // green data member of colorRGB 
        public double blue;    // blue  data member of colorRGB 

        public double RED
        {
            get { return red; }
            set { red = value; }
        }   // property for red 
        public double GREEN
        {

            get { return green; }
            set { green = value; }

        } // property for green
        public double BLUE
        {

            get { return blue; }
            set { blue = value; }

        }  //property for blue

        public ColorRGB()
        {

        }  //deafult constructor with no parameter 

        public ColorRGB(bool color)


        {

            if (color)
            {
                Random rnd = new Random();
                red = rnd.Next(0, 256);
                green = rnd.Next(0, 256);
                blue = rnd.Next(0, 256);
            }

            else
            {
                red = 0;
                green = 0;
                blue = 0;

            }



        }  //  constructor to set random values for red blue and green data members random values must be between ( 0 and 255)

        public ColorRGB(double r, double g, double b)
        {
            red = r;
            green = g;
            blue = b;
        }    // this constructor sets the red, green, and blue color values

    }
}


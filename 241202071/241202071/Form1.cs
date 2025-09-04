using System.Drawing;
using System.Windows.Forms;

namespace _241202071
{
    public partial class Form1 : Form
    {
        private Polygon polygon;

        public Form1()
        {
            InitializeComponent();
            polygon = new Polygon();
        }


        private void setValueOfTheCenter()
        {
            double centerX, centerY;  // two variables for x and y

            bool isNumberX = double.TryParse(textBoxX.Text, out centerX); // check if x is a number

            if (!isNumberX)
            {
                MessageBox.Show("X must be a number. Default is 0.");  // show message box if value is not number
                centerX = 0;     // set x to 0
                textBoxX.Text = "0";   // update textbox with 0
            }
            else if (centerX < 0 || centerX > 3)  // show messagebox  if x not in range
            {
                MessageBox.Show("X must be between [0, 3]. Default is 0.");
                centerX = 0;    // set x to 0
                textBoxX.Text = "0";    // update textbox with 0
            }

            bool isNumberY = double.TryParse(textBoxY.Text, out centerY); // check if y is a number

            if (!isNumberY)
            {
                MessageBox.Show("Y must be a number. Default is 0.");  // show message box if value is not number
                centerY = 0;            // same operations 
                textBoxY.Text = "0";
            }
            else if (centerY < 0 || centerY > 3)
            {
                MessageBox.Show("Y must be between [0, 3]. Default is 0.");  // show messagebox  if y not in range
                centerY = 0;
                textBoxY.Text = "0";
            }

            Point2D center = new Point2D(centerX, centerY);   // create new point with x and y
            polygon.Center = center;  // set center of the polygon
        }

        private void setValueOfLength()
        {
            int length;
            bool isNumber = int.TryParse(textBoxLength.Text, out length);  // check if length is a number

            if (!isNumber)
            {
                MessageBox.Show("Length must be a number. Default is 4.");  // show message box if value is not number
                length = 4;
                textBoxLength.Text = "4";
            }
            else if (length < 3 || length > 9)
            {
                MessageBox.Show("Length must be between [3, 9]. Default is 4.");  // show messagebox  if length not in range
                length = 4;
                textBoxLength.Text = "4";
            }

            polygon.Length = length; // set length of the polygon
        }

        private void setValueOfColor()
        {

            int red = trackBarRed.Value;      // get value from red trackbar
            int green = trackBarGreen.Value;  // get value from green trackbar
            int blue = trackBarBlue.Value;     // get value from blue trackbar

            polygon.Color = Color.FromArgb(red, green, blue);    // set color with red green and blue


        }

        private void setValueOfNumberOfEdges()
        {
            int numberOfEdges;
            bool isNumber = int.TryParse(textBoxEdge.Text, out numberOfEdges);  // check if numberofedges  is a number

            if (!isNumber)
            {
                MessageBox.Show("Number of edges must be a number. Default is 5.");  // show message box if value is not number
                numberOfEdges = 5;
                textBoxEdge.Text = "5";
            }
            else if (numberOfEdges < 3 || numberOfEdges > 10)
            {
                MessageBox.Show("Number of edges must be between [3, 10]. Default is 5.");  // show messagebox  if numberofedges  not in range
                numberOfEdges = 5;
                textBoxEdge.Text = "5";
            }

            polygon.NumberofEdges = numberOfEdges;  // set numberofedges  of the polygon
        }

        private void setValueOfAngleRotation()
        {
            int angle;
            bool isNumber = int.TryParse(textBoxAngle.Text, out angle);     // check if angle   is a number
            if (!isNumber)
            {
                MessageBox.Show("Angle must be a number. Default value is (30).");   // show message box if value is not number 
                angle = 30;
                textBoxAngle.Text = "30";
            }
            else if (angle < 0 || angle > 359)
            {
                MessageBox.Show("Angle must be between [0, 359]. Default value is (30).");   // show messagebox  if angle not in range
                angle = 30;
                textBoxAngle.Text = "30";
            }

            polygon.Angle = angle;     // set angle of the polygon
        }

        private void setEdgeCoordinatesToListBox()
        {
            listBox1.Items.Clear();    // clean old items in listbox

            if (polygon.vertex == null)   // if no vertexpoint , show this message
            {
                MessageBox.Show("Vertex points not calculated.");
                return;
            }

            // for every point get point info as text
            for (int i = 0; i < polygon.vertex.Length; i++)
            {
                string label = "V" + (i + 1) + " = " + polygon.vertex[i].printCoordinates();  // printCoordinates() gives (x, y)
              

                listBox1.Items.Add(label);  // add the text to listbox
            }
        }

        private void findRotationDirection()
        {

            if (checkBoxCCW.Checked)   // if user checks counter clockwise
            {
                polygon.Angle = -polygon.Angle;     // make angle negative to rotate left (counter clockwise)
            }
        }

        public void resetForRandomValues()
        {
            Random rnd = new Random();   // we use Random class to make random values
            polygon.Center = new Point2D(true);  //  we use Point2D class to make random center 
            polygon.Length = rnd.Next(3, 10);    //  make random length between 3 and 9 
            polygon.NumberofEdges = rnd.Next(3, 11);  // make random number of edges between 3 and 10
            polygon.Angle = 0;
            polygon.Angle = rnd.Next(0, 359);     // set random angle between 0 and 358
            ColorRGB randomColor = new ColorRGB(true);  //to  make new color from ColorRGB class, use 'true' to get random RGB values
            polygon.Color = Color.FromArgb((int)randomColor.RED, (int)randomColor.GREEN, (int)randomColor.BLUE);   // set polygon's color using red, green, blue from randomColor object


        }

        private void polygonColorForTrackBar()
        {
            // get red, green, and blue values from trackBars (trackBars give integer, cast to double)
            double r = (double)trackBarRed.Value;
            double g = (double)trackBarGreen.Value;
            double b = (double)trackBarBlue.Value;

            // make new colorRgb object using r, g, b
            ColorRGB colorRgb = new ColorRGB(r, g, b);

            // set polygon's color using r, g, b values from the colorRgb object
            polygon.Color = Color.FromArgb((int)colorRgb.RED, (int)colorRgb.GREEN, (int)colorRgb.BLUE);

            // after changing color, redraw the polygon on the picture box
            DrawPolygonOnPictureBox();

        }

        private void DrawPolygonOnPictureBox()
        {

            // If there is an existing image in the picture box, delete it to avoid memory issues
            if (pictureBox1.Image != null)
                pictureBox1.Image.Dispose();

            Bitmap image = new Bitmap(pictureBox1.Width, pictureBox1.Height);   // we use it to create a image (bitmap) with the same size as the PictureBox
            Graphics pen = Graphics.FromImage(image);   // Create a graphics tool (pen) to draw on the image

            // Check if there are at least 3 points to make a polygon
            if (polygon.vertex == null || polygon.vertex.Length < 3)
            {
                MessageBox.Show("Need at least 3 points to draw.");
                return;
            }


            // These are for positioning the polygon in the center of the PictureBox (normally its up left)
            float centerX = pictureBox1.Width / 2f;
            float centerY = pictureBox1.Height / 2f;
            float zoom = 22f;   // Zoom makes the polygon bigger on screen
            float spaceBetweenDots = 1.5f;  // Distance between each dot on the edges of the polygon

            // Create an array to hold the converted screen coordinates
            PointF[] screenPoints = new PointF[polygon.vertex.Length];

            // Convert each vertex point from polygon to screen coordinate
            for (int i = 0; i < polygon.vertex.Length; i++)
            {
                float x = (float)polygon.vertex[i].X;
                float y = (float)polygon.vertex[i].Y;

                // Convert from math coordinate to screen coordinate
                float screenX = centerX + x * zoom;
                float screenY = centerY - y * zoom;  // y is reversed on screen 

                screenPoints[i] = new PointF(screenX, screenY);     // save converted point
            }

            // Now we draw dotted lines between each pair of points
            for (int i = 0; i < screenPoints.Length; i++)
            {
                PointF start = screenPoints[i];    // current point
                PointF end = screenPoints[(i + 1) % screenPoints.Length];  // next point

                float dx = end.X - start.X; // difference in X between the two point
                float dy = end.Y - start.Y; // difference in Y

                float length = (float)Math.Sqrt(dx * dx + dy * dy); // Length of the edge between the two points
                int numberOfDots = (int)(length / spaceBetweenDots); // How many dots we want to draw based on the length and spacing

                for (int j = 0; j <= numberOfDots; j++)    // Draw each dot along the edge
                {
                    float t = j / (float)numberOfDots;  // t is a value between 0 and 1
                    float dotX = start.X + t * dx;
                    float dotY = start.Y + t * dy;

                    pen.FillEllipse(new SolidBrush(polygon.Color), dotX - 2, dotY - 2, 4, 4);   // Draw a small circle at this position
                }
            }

            pictureBox1.Image = image;   //show the image in the PictureBox
            pen.Dispose();  // Clean up the graphics object 
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            // Set minimum, maximum and default value for trackbars
            trackBarRed.Minimum = 0;
            trackBarRed.Maximum = 255;
            trackBarRed.Value = 0;

            trackBarGreen.Minimum = 0;
            trackBarGreen.Maximum = 255;
            trackBarGreen.Value = 0;

            trackBarBlue.Minimum = 0;
            trackBarBlue.Maximum = 255;
            trackBarBlue.Value = 0;

            // Set initial text values
            textBoxX.Text = "0";
            textBoxY.Text = "0";
            textBoxLength.Text = "4";
            textBoxEdge.Text = "5";
            textBoxAngle.Text = "30";

            listBox1.Items.Add("Item 1");
            listBox1.Items.Add("Item 2");

        }

        private void trackBarRed_Scroll(object sender, EventArgs e)
        {
            polygonColorForTrackBar();   // When the trackbar is moved update the polygon's color
        }

        private void trackBarGreen_Scroll(object sender, EventArgs e)
        {
            polygonColorForTrackBar();   // When the trackbar is moved update the polygon's color
        }

        private void trackBarBlue_Scroll(object sender, EventArgs e)
        {
            polygonColorForTrackBar();    // When the trackbar is moved update the polygon's color
        }




        private void buttonDraw_Click(object sender, EventArgs e)
        {
            // recalling methods to use them  when we press the draw button
            setValueOfTheCenter();
            setValueOfLength();
            setValueOfColor();
            setValueOfNumberOfEdges();
            setValueOfAngleRotation();
            findRotationDirection();

            polygon.calculateEdgeCoordinates();
            polygon.CalculateAllEdgeCoordinates();

            bool clockwise = checkBoxCCW.Checked ? false : true;
            polygon.rotatePolygon(clockwise);

            setEdgeCoordinatesToListBox();
            DrawPolygonOnPictureBox();

        }

        private void buttonRotate_Click(object sender, EventArgs e)
        {

            // recalling methods to use them  when we press the rotate button
            if (polygon.vertex == null)
            {
                buttonReset.PerformClick();
            }

            setValueOfAngleRotation();
            findRotationDirection();

            bool clockwise = !checkBoxCCW.Checked;

            polygon.rotatePolygon(clockwise);
            setEdgeCoordinatesToListBox();
            DrawPolygonOnPictureBox();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            polygon = new Polygon();   //  Create a new polygon instance 
            resetForRandomValues();    // recalling method to use them  when we press the reset button

            // Update the text boxes with the new polygon center, length, edges, and angle
            textBoxX.Text = polygon.Center.X.ToString();
            textBoxY.Text = polygon.Center.Y.ToString();
            textBoxLength.Text = polygon.Length.ToString();
            textBoxEdge.Text = polygon.NumberofEdges.ToString();
            textBoxAngle.Text = polygon.Angle.ToString();

            // Update the trackbars with the new color values of the polygon
            trackBarRed.Value = polygon.Color.R;
            trackBarGreen.Value = polygon.Color.G;
            trackBarBlue.Value = polygon.Color.B;

            // recalling methods to use them  when we press the reset button and update the display
            polygon.calculateEdgeCoordinates();
            polygon.CalculateAllEdgeCoordinates();
            setEdgeCoordinatesToListBox();
            DrawPolygonOnPictureBox();
        }

    }
}


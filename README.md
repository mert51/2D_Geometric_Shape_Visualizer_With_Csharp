Polygon Drawing Application

This project is a C# Windows Forms application for drawing and visualizing polygons.
The user can define the polygon’s center, edge length, number of edges, rotation angle, and color through the interface. The polygon can also be rotated clockwise or counterclockwise.

Features

Create polygons with user-defined values:

Center coordinates (X, Y) → within the range [0, 3].

Edge length → within the range [3, 9].

Number of edges → within the range [3, 10].

Rotation angle → within the range [0, 359].

Color selection:

RGB values can be adjusted using TrackBar controls.

A random color can also be generated.

Rotate polygons clockwise or counterclockwise.

Draw polygon edges using dots instead of solid lines.

Generate a random polygon (random center, length, number of edges, color, and angle).

Display vertex coordinates in a ListBox.

Project Structure

ColorRGB.cs

Stores RGB color values.

Supports random or user-defined color values.

Point2D.cs

Stores point coordinates in Cartesian (x, y) and Polar (r, a) forms.

Provides conversions (Cartesian ↔ Polar) and coordinate formatting methods.

Polygon.cs

Stores the polygon’s center, edge length, number of edges, color, and rotation angle.

Calculates the first vertex and then all remaining vertices.

Rotates the polygon clockwise or counterclockwise.

Form1.cs (UI)

Collects input values from the user (TextBox, TrackBar, CheckBox).

Draws and rotates the polygon, and lists vertex coordinates in the ListBox.

Provides "Draw", "Rotate", and "Reset" button functionalities.

User Interface

TextBox inputs:

X and Y center coordinates

Edge length

Number of edges

Rotation angle

TrackBars: R, G, B values

CheckBox: counterclockwise rotation option

ListBox: displays polygon vertex coordinates

PictureBox: displays the polygon with dotted edges

Buttons:

Draw → draw the polygon

Rotate → rotate the polygon

Reset → generate a new random polygon

How to Run

Open the project with Visual Studio or any .NET-compatible IDE.

Build and run the solution.

Enter the desired values in the interface and click Draw.

Use Rotate to rotate the polygon or Reset to generate a new random polygon.

Development Notes

Polygon edges are drawn with dots for visualization.

Random values are generated using the Random class.

Dispose() is used to manage memory and remove old drawings.

Input validation is applied to ensure values are within valid ranges

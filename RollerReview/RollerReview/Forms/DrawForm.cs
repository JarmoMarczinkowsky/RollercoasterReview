using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.IO;

namespace RollerReview.Forms
{
    public partial class DrawForm : Form
    {
        private List<List<Point>> lines = new List<List<Point>>();
        private List<Point> currentLine = new List<Point>();
        private Pen linePen = new Pen(Color.Black, 3);

        public DrawForm()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.Paint += new PaintEventHandler(Form1_Paint);
            this.MouseDown += new MouseEventHandler(Form1_MouseDown);
            this.MouseMove += new MouseEventHandler(Form1_MouseMove);
            this.MouseUp += new MouseEventHandler(Form1_MouseUp);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            // Draw all lines in the list
            foreach (var line in lines)
            {
                if (line.Count > 1)
                {
                    e.Graphics.DrawLines(linePen, line.ToArray());
                }
            }
            // Draw the current line using the points in the list
            if (currentLine.Count > 1)
            {
                e.Graphics.DrawLines(linePen, currentLine.ToArray());
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            // Start a new line by creating a new list and adding the current mouse position
            currentLine = new List<Point>();
            currentLine.Add(e.Location);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            // If the left mouse button is held down, add the current mouse position to the current line
            if (e.Button == MouseButtons.Left)
            {
                currentLine.Add(e.Location);
                // Invalidate the form to trigger a redraw
                this.Invalidate();
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            // End the current line by adding it to the list of lines
            lines.Add(currentLine);
            currentLine = new List<Point>();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Calculate the bounds of the drawing area by subtracting the button and form borders from the form bounds
            var drawingBounds = new Rectangle(
                this.Left + this.Padding.Left,
                this.Top + this.Padding.Top,
                this.ClientSize.Width,
                this.ClientSize.Height);

            // Show a save file dialog to allow the user to choose a file name and location
            using (var dialog = new SaveFileDialog())
            {
                dialog.Filter = "PNG Image|*.png";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    // Create a bitmap of the drawing area and save it to the chosen file location
                    var bitmap = new Bitmap(drawingBounds.Width, drawingBounds.Height);
                    this.DrawToBitmap(bitmap, drawingBounds);
                    bitmap.Save(dialog.FileName);
                }
            }
        }
    }
}

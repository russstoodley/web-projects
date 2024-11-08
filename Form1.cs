using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Graphs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Event handler for the Draw button click
        private void buttonDraw_Click(object sender, EventArgs e)
        {
            // Get the user input from the TextBox
            string input = textBoxData.Text;

            // Split the input string into an array of numbers
            string[] inputArray = input.Split(',');
            int[] data = Array.ConvertAll(inputArray, int.Parse);

            // Create a Bitmap to draw the pie chart
            Bitmap bmp = new Bitmap(pictureBoxChart.Width, pictureBoxChart.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                // Define the colors for the pie chart slices
                Color[] colors = { Color.Red, Color.Blue, Color.Green, Color.Yellow, Color.Purple };
                // Calculate the total sum of the data
                int total = data.Sum();
                // Start angle for the first slice
                float startAngle = 0;

                // Draw each slice of the pie chart
                for (int i = 0; i < data.Length; i++)
                {
                    // Calculate the sweep angle for the current slice
                    float sweepAngle = (data[i] / (float)total) * 360;
                    // Draw the slice
                    g.FillPie(new SolidBrush(colors[i % colors.Length]), 10, 10,
                        bmp.Width - 20, bmp.Height - 20, startAngle, sweepAngle);
                    // Update the start angle for the next slice
                    startAngle += sweepAngle;
                }
            }

            // Display the pie chart in the PictureBox
            pictureBoxChart.Image = bmp;
        }

        private void buttonDraw_Click_1(object sender, EventArgs e)
        {
            // Get the user input from the TextBox
            string input = textBoxData.Text;
            // Split the input string into an array of numbers
            string[] inputArray = input.Split(',');
            int[] data = Array.ConvertAll(inputArray, int.Parse);

            // Create a Bitmap to draw the pie chart
            Bitmap bmp = new Bitmap(pictureBoxChart.Width, pictureBoxChart.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                // Define the colors for the pie chart slices
                Color[] colors = { Color.Red, Color.Blue, Color.Green, Color.Yellow, Color.Purple };
                // Calculate the total sum of the data
                int total = data.Sum();
                // Start angle for the first slice
                float startAngle = 0;

                // Draw each slice of the pie chart
                for (int i = 0; i < data.Length; i++)
                {
                    // Calculate the sweep angle for the current slice
                    float sweepAngle = (data[i] / (float)total) * 360;
                    // Draw the slice
                    g.FillPie(new SolidBrush(colors[i % colors.Length]), 10, 10, bmp.Width - 20, bmp.Height - 20, startAngle, sweepAngle);
                    // Update the start angle for the next slice
                    startAngle += sweepAngle;
                }
            }

            // Display the pie chart in the PictureBox
            pictureBoxChart.Image = bmp;
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            {
                // Clear the TextBox
                textBoxData.Text = string.Empty;
                // Reset the PictureBox
                pictureBoxChart.Image = null;
            }
        }
    }
}


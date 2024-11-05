using System;
using System.Drawing;
using System.Windows.Forms;

namespace ColorPaletteGenerator
{
    public partial class Form1 : Form
    {
        Random random = new Random(); // Random instance used for generating colors.

        // Variables to store both RGB and HEX
        private string[] rgbValues = new string[5];
        private string[] hexValues = new string[5];

        public Form1()
        {
            InitializeComponent();
        }

        // Method to generate a random color by producing random RGB values.
        private Color GenerateRandomColor()
        {
            int r = random.Next(0, 256); // Red value (0-255)
            int g = random.Next(0, 256); // Green value (0-255)
            int b = random.Next(0, 256); // Blue value (0-255)
            return Color.FromArgb(r, g, b); // Create a color from RGB components.
        }

        // Method to convert a Color object to a HEX string representation.
        private string ColorToHex(Color color)
        {
            return $"{color.R:X2}{color.G:X2}{color.B:X2}"; // Format RGB values to HEX.
        }

        // Method to generate a new palette and store both RGB and HEX values.
        private void UpdatePalette()
        {
            // Generate random colors for each panel.
            Color color1 = GenerateRandomColor();
            Color color2 = GenerateRandomColor();
            Color color3 = GenerateRandomColor();
            Color color4 = GenerateRandomColor();
            Color color5 = GenerateRandomColor();

            // Update the color of each panel.
            panel1.BackColor = color1;
            panel2.BackColor = color2;
            panel3.BackColor = color3;
            panel4.BackColor = color4;
            panel5.BackColor = color5;

            // Store RGB and HEX values in arrays
            rgbValues[0] = $"RGB: {color1.R}, {color1.G}, {color1.B}";
            rgbValues[1] = $"RGB: {color2.R}, {color2.G}, {color2.B}";
            rgbValues[2] = $"RGB: {color3.R}, {color3.G}, {color3.B}";
            rgbValues[3] = $"RGB: {color4.R}, {color4.G}, {color4.B}";
            rgbValues[4] = $"RGB: {color5.R}, {color5.G}, {color5.B}";

            hexValues[0] = $"HEX: {ColorToHex(color1)}";
            hexValues[1] = $"HEX: {ColorToHex(color2)}";
            hexValues[2] = $"HEX: {ColorToHex(color3)}";
            hexValues[3] = $"HEX: {ColorToHex(color4)}";
            hexValues[4] = $"HEX: {ColorToHex(color5)}";

            // Show labels according to the checkbox state (RGB or HEX)
            UpdateLabels();
            button2.Enabled = true;  // Enable Export-button after a palette has been generated
        }

        // Method to update the labels based on the checkbox state
        private void UpdateLabels()
        {
            // If the checkbox is checked, display HEX values; otherwise, display RGB values
            if (checkBoxHex.Checked)
            {
                ShowHEX(); // Show HEX when checkbox is checked
            }
            else
            {
                ShowRGB(); // Show RGB when checkbox is unchecked
            }
        }

        // Method to show RGB values
        private void ShowRGB()
        {
            label1.Text = rgbValues[0];
            label2.Text = rgbValues[1];
            label3.Text = rgbValues[2];
            label4.Text = rgbValues[3];
            label5.Text = rgbValues[4];
        }

        // Method to show HEX values
        private void ShowHEX()
        {
            label1.Text = hexValues[0];
            label2.Text = hexValues[1];
            label3.Text = hexValues[2];
            label4.Text = hexValues[3];
            label5.Text = hexValues[4];
        }

        // Event handler for the button click to generate a new color palette.
        private void button1_Click(object sender, EventArgs e)
        {
            UpdatePalette(); // Generate a new palette
        }

        // Event handler for checkbox state change to toggle between RGB and HEX
        private void checkBoxHex_CheckedChanged(object sender, EventArgs e)
        {
            UpdateLabels(); // Update labels to reflect the current state of the checkbox
        }

        // Event handler for label1 click to copy the color code to the clipboard.
        private void label1_Click(object sender, EventArgs e)
        {
            string labelText = label1.Text;

            // Copy the color code to clipboard.
            if (labelText.StartsWith("RGB"))
            {
                Clipboard.SetText(labelText.Substring(5).Trim());
            }

            else if (labelText.StartsWith("HEX"))
            {
                Clipboard.SetText(labelText.Substring(5).Trim());
            }

            MessageBox.Show("Color code copied to clipboard!"); // Show confirmation message.
        }

        // Event handler for label2 click to copy the color code to the clipboard.
        private void label2_Click(object sender, EventArgs e)
        {
            string labelText = label2.Text;

            // Copy the color code to clipboard.
            if (labelText.StartsWith("RGB"))
            {
                Clipboard.SetText(labelText.Substring(5).Trim());
            }

            else if (labelText.StartsWith("HEX"))
            {
                Clipboard.SetText(labelText.Substring(5).Trim());
            }

            MessageBox.Show("Color code copied to clipboard!"); // Show confirmation message.
        }

        // Event handler for label3 click to copy the color code to the clipboard.
        private void label3_Click(object sender, EventArgs e)
        {
            string labelText = label3.Text;

            // Copy the color code to clipboard.
            if (labelText.StartsWith("RGB"))
            {
                Clipboard.SetText(labelText.Substring(5).Trim());
            }

            else if (labelText.StartsWith("HEX"))
            {
                Clipboard.SetText(labelText.Substring(5).Trim());
            }

            MessageBox.Show("Color code copied to clipboard!"); // Show confirmation message.
        }

        // Event handler for label4 click to copy the color code to the clipboard.
        private void label4_Click(object sender, EventArgs e)
        {
            string labelText = label4.Text;

            // Copy the color code to clipboard.
            if (labelText.StartsWith("RGB"))
            {
                Clipboard.SetText(labelText.Substring(5).Trim());
            }

            else if (labelText.StartsWith("HEX"))
            {
                Clipboard.SetText(labelText.Substring(5).Trim());
            }

            MessageBox.Show("Color code copied to clipboard!"); // Show confirmation message.
        }

        // Event handler for label5 click to copy the color code to the clipboard.
        private void label5_Click(object sender, EventArgs e)
        {
            string labelText = label5.Text;

            // Copy the color code to clipboard.
            if (labelText.StartsWith("RGB"))
            {
                Clipboard.SetText(labelText.Substring(5).Trim());
            }

            else if (labelText.StartsWith("HEX"))
            {
                Clipboard.SetText(labelText.Substring(5).Trim());
            }

            MessageBox.Show("Color code copied to clipboard!"); // Show confirmation message.
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Create bitmap 400px width, 100px height
            Bitmap bitmap = new Bitmap(400, 100);

            // Draw color boxes on the bitmap (use panels colors)
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                // Panels colors, each and one is width 80px (400 / 5 = 80)
                g.FillRectangle(new SolidBrush(panel1.BackColor), new Rectangle(0, 0, 80, 100));
                g.FillRectangle(new SolidBrush(panel2.BackColor), new Rectangle(80, 0, 80, 100));
                g.FillRectangle(new SolidBrush(panel3.BackColor), new Rectangle(160, 0, 80, 100));
                g.FillRectangle(new SolidBrush(panel4.BackColor), new Rectangle(240, 0, 80, 100));
                g.FillRectangle(new SolidBrush(panel5.BackColor), new Rectangle(320, 0, 80, 100));
            }

            // Use SaveFileDialog to let the user choose where to save the image
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                {
                    saveFileDialog.Filter = "PNG Image|*.png";
                    saveFileDialog.Title = "Save Palette as PNG";
                    saveFileDialog.FileName = "palette.png";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        // Save bitmap as PNG
                        bitmap.Save(saveFileDialog.FileName, System.Drawing.Imaging.ImageFormat.Png);
                        MessageBox.Show("Palette saved!", "Export Palette", MessageBoxButtons.OK, MessageBoxIcon.Information); // Show confirmation message.
                    }
                }
            }

        }
    }
}
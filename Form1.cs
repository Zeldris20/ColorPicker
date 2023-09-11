using System;
using System.Drawing;
using System.Windows.Forms;

namespace Bunifuframework
{
    public partial class Form1 : Form
    {

        private bool isHexMode = false;
        private Color initialColor;

        public Form1()
        {
            InitializeComponent();



        }

        private void Start_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                // Get the color selected by the user
                initialColor = colorDialog.Color;

                // Set the initial color to PanelSpectrum
                PanelSpectrum.BackColor = initialColor;

                // Update the text boxes with the RGB components
                txtRedval.Text = initialColor.R.ToString();
                textGreenval.Text = initialColor.G.ToString();
                txtBlueval.Text = initialColor.B.ToString();


                // Update textBox1 with the initial color's RGB values
                textBox1.Text = $"{initialColor.R}, {initialColor.G}, {initialColor.B}";
            }
        }

        private void txtRedval_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtRedval.Text, out int redValue))
            {

            }
            else
            {

            }

        }

        private void textGreenval_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(textGreenval.Text, out int greenValue))
            {



            }
            else
            {

            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtBlueval_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtBlueval.Text, out int blueValue))
            {


            }
            else
            {

            }
        }

        private void PanelSpectrum_Paint(object sender, PaintEventArgs e)
        {

        }




        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Toggle between HEX and RGB modes
            isHexMode = !isHexMode;

            // Update the text boxes based on the current mode and initialization
            UpdateTextBoxText(initialColor);




        }

        private void UpdateTextBoxText(Color selectedColor)
        {
            if (isHexMode)
            {
                // Display HEX value
                string hexValue = ColorToHex(selectedColor);
                textBox1.Text = hexValue;
            }
            else
            {
                // Display RGB value
                textBox1.Text = $" {selectedColor.R}, {selectedColor.G}, {selectedColor.B}";
            }

        }



        private string ColorToHex(Color color)
        {
            return $"#{color.R:X2}{color.G:X2}{color.B:X2}";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

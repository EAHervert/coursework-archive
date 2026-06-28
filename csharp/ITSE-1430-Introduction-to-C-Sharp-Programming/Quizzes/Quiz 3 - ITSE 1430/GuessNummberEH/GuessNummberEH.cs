// Esau Hervert
// ITSE 1430
// Quiz 3, Extra Credit.
// Options/Reference: https://www.youtube.com/watch?v=hvSvEXxVCFA - Mouse over to display information.

using System;
using System.Windows.Forms;

namespace ITSE_1430
{
    public partial class GuessNummberEH : Form
    {
        //This is so tha the program will run without changing a lot of settings.
        static void Main()
        {
            Application.Run(new GuessNummberEH());
        }

        public GuessNummberEH() // Constructor.
        {
            InitializeComponent();
        }
    
        private void B1_CheckedChanged(object sender, EventArgs e) // Button 1.
        {
            Result.Text = "You Lost!!!!";

            // Disables the buttons.
            B1.Enabled = false;
            radioButton1.Enabled = false;
            radioButton3.Enabled = false;
            radioButton4.Enabled = false;
            radioButton5.Enabled = false;

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e) // Button 2.
        {
            Result.Text = "You Lost!!!!";

            // Disables the buttons.
            B1.Enabled = false;
            radioButton1.Enabled = false;
            radioButton3.Enabled = false;
            radioButton4.Enabled = false;
            radioButton5.Enabled = false;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e) // Button 3.
        {
            Result.Text = "You Lost!!!!";

            // Disables the buttons.
            B1.Enabled = false;
            radioButton1.Enabled = false;
            radioButton3.Enabled = false;
            radioButton4.Enabled = false;
            radioButton5.Enabled = false;

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e) // Button 4.
        {
            Result.Text = "You Lost!!!!";

            // Disables the buttons.
            B1.Enabled = false;
            radioButton1.Enabled = false;
            radioButton3.Enabled = false;
            radioButton4.Enabled = false;
            radioButton5.Enabled = false;

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e) // Button 5.
        {
            Result.Text = "You Won!!!!";

            // Disables the buttons.
            B1.Enabled = false;
            radioButton1.Enabled = false;
            radioButton3.Enabled = false;
            radioButton4.Enabled = false;
            radioButton5.Enabled = false;

        }

        private void label1_MouseHover(object sender, EventArgs e)
        {
            label1.Text += "\n\nIt's Not 1."; // The hint.
        }
    }
}

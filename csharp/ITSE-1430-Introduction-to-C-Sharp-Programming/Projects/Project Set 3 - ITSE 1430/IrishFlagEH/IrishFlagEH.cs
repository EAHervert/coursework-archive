// Esau Hervert
// ITSE 1430
// Project 3 - Problem 1.
// References/Option: https://en.wikipedia.org/wiki/Flag_of_Ireland - Colors.
// https://www.youtube.com/watch?v=s94WCTDMtbw - Draw the rectangles.

using System;
using System.Drawing;
using System.Windows.Forms;

namespace ITSE_1430
{
    public partial class IrishFlagEH : Form
    {
        //This is so tha the program will run without changing a lot of settings.
        static void Main()
        {
            Application.Run(new IrishFlagEH());
        }

        //Initializing the form.
        public IrishFlagEH()
        {
            InitializeComponent();
        }

        //Painting the flag.
        private void Flag_Paint(object sender, PaintEventArgs e)
        {
            //Creating the image.
            Graphics IrishFlag = Flag.CreateGraphics();

            //The colors of the Flag.
            Brush Green = new SolidBrush(Color.FromArgb(255, 22, 155, 98));
            Brush White = new SolidBrush(Color.FromArgb(255, 255, 255, 255));
            Brush Orange = new SolidBrush(Color.FromArgb(255, 255, 136, 62));

            //Filling up the rectangles.
            IrishFlag.FillRectangle(Green, 42, 80, 400, 800);
            IrishFlag.FillRectangle(White, 442, 80, 400, 800);
            IrishFlag.FillRectangle(Orange, 842, 80, 400, 800);
        }
    }
}

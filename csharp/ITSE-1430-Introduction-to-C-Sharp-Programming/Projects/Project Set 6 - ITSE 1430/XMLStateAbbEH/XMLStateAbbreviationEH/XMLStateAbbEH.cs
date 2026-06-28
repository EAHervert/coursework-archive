// Esau Hervert
// ITSE 1430
// Project Set 6 - Problem 2
// Options: None
// References: http://stackoverflow.com/questions/11787591/search-data-in-xml-file-c-sharp - Reading XML info with Linq.

using System;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ITSE_1430
{
    public partial class XMLStateAbbEH : Form
    {
        string Abbreviation = "TX"; // This is the string that will store the raw abbreviation the user inputs.

        public XMLStateAbbEH()
        {
            InitializeComponent();
        }

        public static void Main(string[] args)
        {
            Application.Run(new XMLStateAbbEH()); // Run the form.
        }

        private void Button_Click(object sender, EventArgs e) // When the submit button is pressed.
        {
            Abbreviation = State.Text; // Get the text from the user.
            string AB = Abbreviation.ToUpper(); // Change it to all uppercase.
            State.Enabled = false;

            XDocument Doc = XDocument.Load("USStates.xml"); // Open Document through Linq.

            int i = 0; // value that will run through the abbreviations index by index.
            int j = 0; // Will store which index had the abbreviation we are looking for.
            int k = 0; // Will run through the names index by index.

            foreach (var child in Doc.Descendants("abbreviation"))
            {
                if (child.Value == AB)
                {
                    j = i; // When we find the correct index, we store it.
                }

                i++; // Go through the entire index.
            }

            foreach (var child in Doc.Descendants("name"))
            {
                if (k == j) // Whenever we reach the correct index k.
                {
                    StateAnswer.Text = child.Value; // Display the state name associated to the abbreviation.
                }

                k++; // Go through the entire index.
            }
        }
    }
}

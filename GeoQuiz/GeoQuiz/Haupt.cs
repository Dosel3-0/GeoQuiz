using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeoQuiz
{
    public partial class Haupt : Form
    {
        private List<Laendern> RL; // Assuming this is your list of countries

        private int currentIndex = 0; // Track the current index of the country

        public Haupt()
        {
            InitializeComponent();
        }

        private void btnMainH_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Datenbank db = new Datenbank();

            int numberOfRandomCountries = 4;

            List<Laendern> randomCountries = db.getRandom(numberOfRandomCountries);

            // Ensure there are countries to display
            if (randomCountries.Count >= 4)
            {
                // Display the first country's question
                label1.Text = $"Welche ist die Hauptstadt von {randomCountries[currentIndex].Landname}?";

                // Assign each country's capital to radio buttons
                radioButton1.Text = randomCountries[0].Landhauptstadt;
                radioButton2.Text = randomCountries[1].Landhauptstadt;
                radioButton3.Text = randomCountries[2].Landhauptstadt;
                radioButton4.Text = randomCountries[3].Landhauptstadt;

                // Store the correct country's name
            }
            else
            {
                MessageBox.Show("Not enough countries in the database to display.");
            }
        }



    }
}

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
        private List<int> recentlyAskedIndices = new List<int>(); // Track recently asked questions
        private const int maxRecentQuestions = 4; // Number of recent questions to track to avoid repetition
        private bool isCheckingAnswer = false; // Flag to check if we are in "check answer" mode
        private string correctCountry;
        private int currentQuestionCount = 0;
        private int score = 0; // Track score


        public Haupt()
        {
            InitializeComponent();
        }

        private void btnMainH_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void btnNext_Click(object sender, EventArgs e)
        {
            if (isCheckingAnswer)
            {
                CheckAnswer();
            }
            else
            {
                LoadNewQuestion();
            }
        }

        private void Shuffle<T>(List<T> list)
        {
            Random rand = new Random();
            for (int i = list.Count - 1; i > 0; i--)
            {
                int j = rand.Next(0, i + 1);
                T temp = list[i];
                list[i] = list[j];
                list[j] = temp;
            }
        }

        private void LoadNewQuestion()
        {
            Datenbank db = new Datenbank();

            int numberOfRandomCountries = 4;

            RL = db.getRandom(numberOfRandomCountries);

            // Ensure there are countries to display
            if (RL.Count >= 4)
            {
                // Generate a random index for the correct answer
                Random rand = new Random();
                int newIndex;
                do
                {
                    newIndex = rand.Next(0, numberOfRandomCountries);
                } while (recentlyAskedIndices.Contains(newIndex));

                currentIndex = newIndex;

                recentlyAskedIndices.Add(currentIndex);
                if (recentlyAskedIndices.Count > maxRecentQuestions)
                {
                    recentlyAskedIndices.RemoveAt(0);
                }

                // Display the question for the randomly selected correct answer
                label1.Text = $"Welche ist die Hauptstadt von {RL[currentIndex].Landname}?";

                // Shuffle the list of capitals to assign to radio buttons
                List<string> capitals = new List<string>();
                for (int i = 0; i < RL.Count; i++)
                {
                    capitals.Add(RL[i].Landhauptstadt);
                }

                // Shuffle the capitals list
                Shuffle(capitals);

                // Assign shuffled capitals to radio buttons
                radioButton1.Text = capitals[0];
                radioButton2.Text = capitals[1];
                radioButton3.Text = capitals[2];
                radioButton4.Text = capitals[3];

                // Clear any previous selections
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                radioButton3.Checked = false;
                radioButton4.Checked = false;

                // Update the correct country variable
                correctCountry = RL[currentIndex].Landhauptstadt;

                // Set flag to check the answer next
                isCheckingAnswer = true;
                btnNext.Text = "Check Answer";
            }
            else
            {
                MessageBox.Show("Not enough countries in the database to display.");
            }
        }

        private void CheckAnswer()
        {
            // Check if a radio button is checked
            if (radioButton1.Checked || radioButton2.Checked || radioButton3.Checked || radioButton4.Checked)
            {
                string selectedCapital = "";

                // Determine which radio button is checked
                if (radioButton1.Checked) selectedCapital = radioButton1.Text;
                else if (radioButton2.Checked) selectedCapital = radioButton2.Text;
                else if (radioButton3.Checked) selectedCapital = radioButton3.Text;
                else if (radioButton4.Checked) selectedCapital = radioButton4.Text;

                // Check if the selected capital matches the correct answer
                if (!string.IsNullOrEmpty(selectedCapital))
                {
                    string correctCapital = RL[currentIndex].Landhauptstadt;
                    if (selectedCapital == correctCapital)
                    {
                        MessageBox.Show("Richtig!");
                        score++;
                    }
                    else
                    {
                        MessageBox.Show($"Falsch! Das Antwort ist {correctCapital}.");
                    }

                    // Set flag to load a new question next
                    isCheckingAnswer = false;
                    btnNext.Text = "Next";

                    currentQuestionCount++;

                    if (currentQuestionCount >= maxRecentQuestions)
                    {
                        MessageBox.Show($"Round finished! Your score: {score}/{maxRecentQuestions}");
                        ResetRound();
                    }
                }
            }
            else
            {
                MessageBox.Show("Bitte Wähle eine Antwort");
            }
        }

        private void ResetRound()
        {
            currentQuestionCount = 0;
            score = 0;
            recentlyAskedIndices.Clear();
            btnNext.Text = "Start New Round";
        }

    }
}

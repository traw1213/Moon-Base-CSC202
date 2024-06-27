using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoonBase // Namespace for the project
{
    public partial class Dinning : Form // Dinning inherits from Form
    {
        // Array of random messages to display
        private readonly string[] randomMessages = new string[]
        {
            "Enjoy your meal!",
            "Today's special is delicious.",
            "Don't forget to hydrate.",
            "A balanced diet is key.",
            "Dine with your fellow astronauts."
        };

        private readonly string logFilePath = "user_position_log.txt"; // Path to the log file

        public Dinning() // Constructor for Dinning
        {
            InitializeComponent(); // Initialize form components
            LogUserPosition("Dinning"); // Log the initial position
        }

        // Event handler for Dinning form load event
        private void Dinning_Load(object sender, EventArgs e)
        {
            // Any initialization logic for the Dinning form
        }

        // Event handler for clicking the CRdin button
        private void CRdinbutton_Click(object sender, EventArgs e)
        {
            LogUserPosition("Main Control Room"); // Log the new position
            Mainform mainForm = new Mainform(); // Create a new instance of the Mainform
            mainForm.Show(); // Show the Mainform
            this.Hide(); // Hide the current form (Dinning)
        }

        // Event handler for clicking the Dormdin button
        private void Dormdinbutton_Click(object sender, EventArgs e)
        {
            LogUserPosition("Dorms"); // Log the new position
            Dorms dormsForm = new Dorms(); // Create a new instance of the Dorms form
            dormsForm.Show(); // Show the Dorms form
            this.Hide(); // Hide the current form (Dinning)
        }

        // Event handler for clicking the garagedin button
        private void garagedinbutton_Click(object sender, EventArgs e)
        {
            LogUserPosition("Garage"); // Log the new position
            Garage garageForm = new Garage(); // Create a new instance of the Garage form
            garageForm.Show(); // Show the Garage form
            this.Hide(); // Hide the current form (Dinning)
        }

        // Event handler for clicking the randomdin button
        private void randomdinbutton_Click(object sender, EventArgs e)
        {
            Random random = new Random(); // Create a new instance of Random
            int index = random.Next(randomMessages.Length); // Get a random index
            MessageBox.Show(randomMessages[index], "Random Message"); // Show a random message
        }

        // Method to log the user's position
        private void LogUserPosition(string position)
        {
            using (StreamWriter writer = new StreamWriter(logFilePath, true)) // Open the log file for appending
            {
                writer.WriteLine($"{DateTime.Now}: User moved to {position}"); // Write the current date/time and position
            }
        }
    }
}
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
    public partial class Dorms : Form // Dorms inherits from Form
    {
        // Array of random messages to display
        private readonly string[] randomMessages = new string[]
        {
            "Rest well in the dorms.",
            "The dorms are quiet today.",
            "Remember to clean your room.",
            "A good night's sleep is important.",
            "The dorms are your safe haven."
        };

        private readonly string logFilePath = "user_position_log.txt"; // Path to the log file

        public Dorms() // Constructor for Dorms
        {
            InitializeComponent(); // Initialize form components
            LogUserPosition("Dorms"); // Log the initial position
        }

        // Event handler for Dorms form load event
        private void Dorms_Load(object sender, EventArgs e)
        {
            // Any initialization logic for the Dorms form
        }

        // Event handler for clicking the DinningD button
        private void DinningDbutton_Click(object sender, EventArgs e)
        {
            LogUserPosition("Dinning"); // Log the new position
            Dinning dinningForm = new Dinning(); // Create a new instance of the Dinning form
            dinningForm.Show(); // Show the Dinning form
            this.Hide(); // Hide the current form (Dorms)
        }

        // Event handler for clicking the CRdorm button
        private void CRdormbutton_Click(object sender, EventArgs e)
        {
            LogUserPosition("Main Control Room"); // Log the new position
            Mainform mainForm = new Mainform(); // Create a new instance of the Mainform
            mainForm.Show(); // Show the Mainform
            this.Hide(); // Hide the current form (Dorms)
        }

        // Event handler for clicking the GarageD button
        private void GarageDbutton_Click(object sender, EventArgs e)
        {
            LogUserPosition("Garage"); // Log the new position
            Garage garageForm = new Garage(); // Create a new instance of the Garage form
            garageForm.Show(); // Show the Garage form
            this.Hide(); // Hide the current form (Dorms)
        }

        // Event handler for clicking the RandomD button
        private void RandomDbutton_Click(object sender, EventArgs e)
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
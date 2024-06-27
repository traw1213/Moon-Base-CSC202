using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoonBase // Namespace for the project
{
    public partial class Mainform : Form // Mainform inherits from Form
    {
        private readonly string logFilePath = "user_position_log.txt"; // Path to the log file

        public Mainform() // Constructor for Mainform
        {
            InitializeComponent(); // Initialize form components
            LogUserPosition("Main Control Room"); // Log the initial position
        }

        // Event handler for clicking the DormCR button
        private void DormCRbutton_Click(object sender, EventArgs e)
        {
            LogUserPosition("Dorms"); // Log the new position
            Dorms dormsForm = new Dorms(); // Create a new instance of the Dorms form
            dormsForm.Show(); // Show the Dorms form
            this.Hide(); // Hide the current form (Mainform)
        }

        // Event handler for clicking the DinningCR button
        private void DinningCRbutton_Click(object sender, EventArgs e)
        {
            LogUserPosition("Dinning"); // Log the new position
            Dinning dinningForm = new Dinning(); // Create a new instance of the Dinning form
            dinningForm.Show(); // Show the Dinning form
            this.Hide(); // Hide the current form (Mainform)
        }

        // Event handler for clicking the GarageCR button
        private void GarageCRbutton_Click(object sender, EventArgs e)
        {
            LogUserPosition("Garage"); // Log the new position
            Garage garageForm = new Garage(); // Create a new instance of the Garage form
            garageForm.Show(); // Show the Garage form
            this.Hide(); // Hide the current form (Mainform)
        }

        // Event handler for clicking the RandomCR button
        private void RandomCRbutton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Do Not Touch Anything!!", "Warning"); // Show a warning message
        }

        // Event handler for clicking the viewLogButton button
        private void viewLogButton_Click(object sender, EventArgs e)
        {
            OpenLogFile(); // Open the log file
        }

        // Method to log the user's position
        private void LogUserPosition(string position)
        {
            using (StreamWriter writer = new StreamWriter(logFilePath, true)) // Open the log file for appending
            {
                writer.WriteLine($"{DateTime.Now}: User moved to {position}"); // Write the current date/time and position
            }
        }

        // Method to open the log file
        private void OpenLogFile()
        {
            if (File.Exists(logFilePath)) // Check if the log file exists
            {
                Process.Start(new ProcessStartInfo(logFilePath) { UseShellExecute = true }); // Open the log file with the default text editor
            }
            else
            {
                MessageBox.Show("Log file does not exist.", "Error"); // Show an error message if the log file doesn't exist
            }
        }
    }
}
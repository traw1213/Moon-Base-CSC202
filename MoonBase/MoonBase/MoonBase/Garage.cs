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
    public partial class Garage : Form // Garage inherits from Form
    {
        private readonly string logFilePath = "user_position_log.txt"; // Path to the log file

        public Garage() // Constructor for Garage
        {
            InitializeComponent(); // Initialize form components
            LogUserPosition("Garage"); // Log the initial position
        }

        // Event handler for Garage form load event
        private void Garage_Load(object sender, EventArgs e)
        {
            // Any initialization logic for the Garage form
        }

        // Event handler for clicking the CRgarage button
        private void CRgaragebutton_Click(object sender, EventArgs e)
        {
            LogUserPosition("Main Control Room"); // Log the new position
            Mainform mainForm = new Mainform(); // Create a new instance of the Mainform
            mainForm.Show(); // Show the Mainform
            this.Hide(); // Hide the current form (Garage)
        }

        // Event handler for clicking the DinningG button
        private void DinningGbutton_Click(object sender, EventArgs e)
        {
            LogUserPosition("Dinning"); // Log the new position
            Dinning dinningForm = new Dinning(); // Create a new instance of the Dinning form
            dinningForm.Show();
            this.Hide(); // Hide the current form (Garage)
        }

        // Event handler for clicking the DormG button
        private void DormGbutton_Click(object sender, EventArgs e)
        {
            LogUserPosition("Dorms"); // Log the new position
            Dorms dormsForm = new Dorms(); // Create a new instance of the Dorms form
            dormsForm.Show(); // Show the Dorms form
            this.Hide(); // Hide the current form (Garage)
        }

        // Event handler for clicking the RandomG button
        private void RandomGbutton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your equipment is the key to surviving on the Moon.", "Warning"); // Show a random message
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

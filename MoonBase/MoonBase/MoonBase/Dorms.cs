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

namespace MoonBase
{
    public partial class Dorms : Form
    {
        private readonly string logFilePath = "user_position_log.txt";

        public Dorms()
        {
            InitializeComponent();
            LogUserPosition("Dorms");
        }

        // Add this method to handle the load event
        private void Dorms_Load(object sender, EventArgs e)
        {
            // Any initialization logic for the Dorms form can be placed here
        }

        private void DinningDbutton_Click(object sender, EventArgs e)
        {
            LogUserPosition("Dinning");
            NavigateToForm(new Dinning());
        }

        private void CRdormbutton_Click(object sender, EventArgs e)
        {
            LogUserPosition("Main Control Room");
            NavigateToForm(new Mainform());
        }

        private void GarageDbutton_Click(object sender, EventArgs e)
        {
            LogUserPosition("Garage");
            NavigateToForm(new MCR());
        }

        private void RandomDbutton_Click(object sender, EventArgs e)
        {
            string[] randomMessages = {
                "Rest well in the dorms.",
                "The dorms are quiet today.",
                "Remember to clean your room.",
                "A good night's sleep is important.",
                "The dorms are your safe haven."
            };
            Random random = new Random();
            int index = random.Next(randomMessages.Length);
            MessageBox.Show(randomMessages[index], "Random Message");
        }

        private void LogUserPosition(string position)
        {
            using (StreamWriter writer = new StreamWriter(logFilePath, true))
            {
                writer.WriteLine($"{DateTime.Now}: User moved to {position}");
            }
        }

        private void NavigateToForm(Form form)
        {
            form.FormClosed += (s, args) => this.Close();
            this.Hide();
            form.Show();
        }
    }
}

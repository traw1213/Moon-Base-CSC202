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
    public partial class Dinning : Form
    {
        private readonly string logFilePath = "user_position_log.txt";

        public Dinning()
        {
            InitializeComponent();
            LogUserPosition("Dinning");
        }

      
        private void Dinning_Load(object sender, EventArgs e)
        {
            
        }

        private void CRdinbutton_Click(object sender, EventArgs e)
        {
            LogUserPosition("Main Control Room");
            NavigateToForm(new Mainform());
        }

        private void Dormdinbutton_Click(object sender, EventArgs e)
        {
            LogUserPosition("Dorms");
            NavigateToForm(new Dorms());
        }

        private void garagedinbutton_Click(object sender, EventArgs e)
        {
            LogUserPosition("Garage");
            NavigateToForm(new MCR());
        }

        private void randomdinbutton_Click(object sender, EventArgs e)
        {
            string[] randomMessages = {
                "Enjoy your meal!",
                "Today's special is delicious.",
                "Don't forget to hydrate.",
                "A balanced diet is key.",
                "Dine with your fellow astronauts."
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
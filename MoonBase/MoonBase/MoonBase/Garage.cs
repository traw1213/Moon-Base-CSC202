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
    public partial class MCR : Form
    {
        private readonly string logFilePath = "user_position_log.txt";

        public MCR()
        {
            InitializeComponent();
            LogUserPosition("Garage");
        }

        // Add this method to handle the load event
        private void Garage_Load(object sender, EventArgs e)
        {
            // Any initialization logic for the Garage form can be placed here
        }

        private void CRgaragebutton_Click(object sender, EventArgs e)
        {
            LogUserPosition("Main Control Room");
            NavigateToForm(new Mainform());
        }

        private void DinningGbutton_Click(object sender, EventArgs e)
        {
            LogUserPosition("Dinning");
            NavigateToForm(new Dinning());
        }

        private void DormGbutton_Click(object sender, EventArgs e)
        {
            LogUserPosition("Dorms");
            NavigateToForm(new Dorms());
        }

        private void RandomGbutton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your equipment is the key to surviving on the Moon.", "Warning");
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
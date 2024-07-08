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

namespace MoonBase
{
    public partial class Mainform : Form
    {
        private readonly string logFilePath = "user_position_log.txt";

        public Mainform()
        {
            InitializeComponent();
            LogUserPosition("Main Control Room");
        }

        private void DormCRbutton_Click(object sender, EventArgs e)
        {
            LogUserPosition("Dorms");
            NavigateToForm(new Dorms());
        }

        private void DinningCRbutton_Click(object sender, EventArgs e)
        {
            LogUserPosition("Dinning");
            NavigateToForm(new Dinning());
        }

        private void GarageCRbutton_Click(object sender, EventArgs e)
        {
            LogUserPosition("Garage");
            NavigateToForm(new MCR());
        }

        private void RandomCRbutton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Do Not Touch Anything!!", "Warning");
        }

        private void viewLogButton_Click(object sender, EventArgs e)
        {
            OpenLogFile();
        }

        private void CRtoMCRbutton_Click(object sender, EventArgs e)
        {
            LogUserPosition("Mission");
            NavigateToForm(new MissonControl());
        }

        private void LogUserPosition(string position)
        {
            using (StreamWriter writer = new StreamWriter(logFilePath, true))
            {
                writer.WriteLine($"{DateTime.Now}: User moved to {position}");
            }
        }

        private void OpenLogFile()
        {
            if (File.Exists(logFilePath))
            {
                Process.Start(new ProcessStartInfo(logFilePath) { UseShellExecute = true });
            }
            else
            {
                MessageBox.Show("Log file does not exist.", "Error");
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
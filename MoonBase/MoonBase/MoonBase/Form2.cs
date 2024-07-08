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
    public partial class MissonControl : Form
    {
        private bool isRed = false;
        private Random random = new Random();
        private int correctAnswer;
        private int correctAnswersCount = 0;
        private int timeLeft = 60; // 60 seconds countdown
        private readonly string logFilePath = "user_position_log.txt";

        private Timer countdownTimer;

        public MissonControl()
        {
            InitializeComponent();
            SubmitButton.Click += new EventHandler(SubmitButton_Click);
            MissionButton.Click += new EventHandler(MissionButton_Click);
            countdownTimer = new Timer();
            countdownTimer.Interval = 1000;
            countdownTimer.Tick += CountdownTimer_Tick;
            MCRtoCRbutton.Click += new EventHandler(MCRtoCRbutton_Click);
            MCRtoDormbutton.Click += new EventHandler(MCRtoDormbutton_Click);
            MCRtoDINbutton.Click += new EventHandler(MCRtoDINbutton_Click);
            MCRtoGarbutton.Click += new EventHandler(MCRtoGarbutton_Click);
        }

        private void MissonControl_Load(object sender, EventArgs e)
        {
            ButtonTimer.Interval = 300;
            ButtonTimer.Tick += ButtonTimer_Tick;
            ButtonTimer.Start();
            MathLabel.Visible = false;
            Answertext.Visible = false;
            SubmitButton.Visible = false;
            TimerLabel.Visible = false;
            CorrectAnswersLabel.Visible = false;
        }

        private void ButtonTimer_Tick(object sender, EventArgs e)
        {
            if (!MissionButton.BackColor.Equals(Color.Green))
            {
                MissionButton.BackColor = isRed ? DefaultBackColor : Color.Red;
                isRed = !isRed;
            }
        }

        private void GenerateMathProblem()
        {
            int num1 = random.Next(1, 11);
            int num2 = random.Next(1, 11);
            correctAnswer = num1 + num2;
            MathLabel.Text = $"What is {num1} + {num2}?";
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            int userAnswer;
            if (int.TryParse(Answertext.Text, out userAnswer))
            {
                if (userAnswer == correctAnswer)
                {
                    correctAnswersCount++;
                    CorrectAnswersLabel.Text = $"Correct Answers: {correctAnswersCount}";
                    MessageBox.Show("Correct! Well done!");

                    if (correctAnswersCount >= 8)
                    {
                        countdownTimer.Stop();
                        MessageBox.Show("Congratulations, you completed your first mission!");
                        ResetMission();
                    }
                }
                else
                {
                    MessageBox.Show($"Incorrect. The correct answer is {correctAnswer}.");
                }
                GenerateMathProblem();
                Answertext.Clear();
            }
            else
            {
                MessageBox.Show("Please enter a valid number.");
            }
        }

        private void MissionButton_Click(object sender, EventArgs e)
        {
            MathLabel.Visible = true;
            Answertext.Visible = true;
            SubmitButton.Visible = true;
            TimerLabel.Visible = true;
            CorrectAnswersLabel.Visible = true;
            CorrectAnswersLabel.Text = "Correct Answers: 0";
            GenerateMathProblem();
            MissionButton.BackColor = Color.Green;
            timeLeft = 60;
            correctAnswersCount = 0;
            countdownTimer.Start();
        }

        private void CountdownTimer_Tick(object sender, EventArgs e)
        {
            if (timeLeft > 0)
            {
                timeLeft--;
                TimerLabel.Text = $"Time Left: {timeLeft} seconds";
            }
            else
            {
                countdownTimer.Stop();
                if (correctAnswersCount < 8)
                {
                    MessageBox.Show("You must return to Earth for failure to pass the exam.");
                }
                ResetMission();
            }
        }

        private void ResetMission()
        {
            MathLabel.Visible = false;
            Answertext.Visible = false;
            SubmitButton.Visible = false;
            TimerLabel.Visible = false;
            CorrectAnswersLabel.Visible = false;
            MissionButton.BackColor = DefaultBackColor;
            Answertext.Clear();
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

        private void MCRtoCRbutton_Click(object sender, EventArgs e)
        {
            LogUserPosition("Main Control Room");
            NavigateToForm(new Mainform());
        }

        private void MCRtoDormbutton_Click(object sender, EventArgs e)
        {
            LogUserPosition("Dorms");
            NavigateToForm(new Dorms());
        }

        private void MCRtoDINbutton_Click(object sender, EventArgs e)
        {
            LogUserPosition("Dinning");
            NavigateToForm(new Dinning());
        }

        private void MCRtoGarbutton_Click(object sender, EventArgs e)
        {
            LogUserPosition("Garage");
            NavigateToForm(new MCR());
        }
    }
}
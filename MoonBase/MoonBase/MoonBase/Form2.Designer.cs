namespace MoonBase
{
    partial class MissonControl
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MissonControl));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.MCRtoCRbutton = new System.Windows.Forms.Button();
            this.MCRtoDormbutton = new System.Windows.Forms.Button();
            this.MCRtoDINbutton = new System.Windows.Forms.Button();
            this.MCRtoGarbutton = new System.Windows.Forms.Button();
            this.MissionButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ButtonTimer = new System.Windows.Forms.Timer(this.components);
            this.SubmitButton = new System.Windows.Forms.Button();
            this.MathLabel = new System.Windows.Forms.Label();
            this.Answertext = new System.Windows.Forms.TextBox();
            this.TimerLabel = new System.Windows.Forms.Label();
            this.CorrectAnswersLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 237);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(651, 646);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Location Information";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "label4";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(40, 170);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(528, 457);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = resources.GetString("textBox2.Text");
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(40, 64);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(528, 35);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "Misson Control Room";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Room Description";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Room Name";
            // 
            // MCRtoCRbutton
            // 
            this.MCRtoCRbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MCRtoCRbutton.Location = new System.Drawing.Point(1923, 132);
            this.MCRtoCRbutton.Name = "MCRtoCRbutton";
            this.MCRtoCRbutton.Size = new System.Drawing.Size(96, 31);
            this.MCRtoCRbutton.TabIndex = 1;
            this.MCRtoCRbutton.Text = "Control Room";
            this.MCRtoCRbutton.UseVisualStyleBackColor = true;
            this.MCRtoCRbutton.Click += new System.EventHandler(this.MCRtoCRbutton_Click);
            // 
            // MCRtoDormbutton
            // 
            this.MCRtoDormbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MCRtoDormbutton.Location = new System.Drawing.Point(1923, 169);
            this.MCRtoDormbutton.Name = "MCRtoDormbutton";
            this.MCRtoDormbutton.Size = new System.Drawing.Size(96, 31);
            this.MCRtoDormbutton.TabIndex = 2;
            this.MCRtoDormbutton.Text = "Dorms";
            this.MCRtoDormbutton.UseVisualStyleBackColor = true;
            this.MCRtoDormbutton.Click += new System.EventHandler(this.MCRtoDormbutton_Click);
            // 
            // MCRtoDINbutton
            // 
            this.MCRtoDINbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MCRtoDINbutton.Location = new System.Drawing.Point(1925, 212);
            this.MCRtoDINbutton.Name = "MCRtoDINbutton";
            this.MCRtoDINbutton.Size = new System.Drawing.Size(96, 31);
            this.MCRtoDINbutton.TabIndex = 3;
            this.MCRtoDINbutton.Text = "Dinning";
            this.MCRtoDINbutton.UseVisualStyleBackColor = true;
            this.MCRtoDINbutton.Click += new System.EventHandler(this.MCRtoDINbutton_Click);
            // 
            // MCRtoGarbutton
            // 
            this.MCRtoGarbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MCRtoGarbutton.Location = new System.Drawing.Point(1925, 249);
            this.MCRtoGarbutton.Name = "MCRtoGarbutton";
            this.MCRtoGarbutton.Size = new System.Drawing.Size(96, 31);
            this.MCRtoGarbutton.TabIndex = 4;
            this.MCRtoGarbutton.Text = "Garage";
            this.MCRtoGarbutton.UseVisualStyleBackColor = true;
            this.MCRtoGarbutton.Click += new System.EventHandler(this.MCRtoGarbutton_Click);
            // 
            // MissionButton
            // 
            this.MissionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MissionButton.Location = new System.Drawing.Point(1843, 303);
            this.MissionButton.Name = "MissionButton";
            this.MissionButton.Size = new System.Drawing.Size(176, 34);
            this.MissionButton.TabIndex = 5;
            this.MissionButton.Text = "Start Mission";
            this.MissionButton.UseVisualStyleBackColor = true;
            this.MissionButton.Click += new System.EventHandler(this.MissionButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1913, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Navigation";
            // 
            // ButtonTimer
            // 
            this.ButtonTimer.Interval = 200;
            // 
            // SubmitButton
            // 
            this.SubmitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitButton.Location = new System.Drawing.Point(1112, 237);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(75, 23);
            this.SubmitButton.TabIndex = 7;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            // 
            // MathLabel
            // 
            this.MathLabel.AutoSize = true;
            this.MathLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MathLabel.Location = new System.Drawing.Point(1058, 89);
            this.MathLabel.Name = "MathLabel";
            this.MathLabel.Size = new System.Drawing.Size(155, 24);
            this.MathLabel.TabIndex = 8;
            this.MathLabel.Text = "Math Questions";
            // 
            // Answertext
            // 
            this.Answertext.Location = new System.Drawing.Point(1103, 169);
            this.Answertext.Name = "Answertext";
            this.Answertext.Size = new System.Drawing.Size(100, 20);
            this.Answertext.TabIndex = 9;
            // 
            // TimerLabel
            // 
            this.TimerLabel.AutoSize = true;
            this.TimerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimerLabel.Location = new System.Drawing.Point(1108, 123);
            this.TimerLabel.Name = "TimerLabel";
            this.TimerLabel.Size = new System.Drawing.Size(63, 25);
            this.TimerLabel.TabIndex = 10;
            this.TimerLabel.Text = "Time";
            // 
            // CorrectAnswersLabel
            // 
            this.CorrectAnswersLabel.AutoSize = true;
            this.CorrectAnswersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CorrectAnswersLabel.Location = new System.Drawing.Point(1109, 201);
            this.CorrectAnswersLabel.Name = "CorrectAnswersLabel";
            this.CorrectAnswersLabel.Size = new System.Drawing.Size(78, 24);
            this.CorrectAnswersLabel.TabIndex = 11;
            this.CorrectAnswersLabel.Text = "Correct";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(676, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(389, 24);
            this.label5.TabIndex = 12;
            this.label5.Text = "How many phases does the Moon have?";
            // 
            // MissonControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(2032, 985);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CorrectAnswersLabel);
            this.Controls.Add(this.TimerLabel);
            this.Controls.Add(this.Answertext);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MissionButton);
            this.Controls.Add(this.MCRtoGarbutton);
            this.Controls.Add(this.MCRtoDINbutton);
            this.Controls.Add(this.MCRtoDormbutton);
            this.Controls.Add(this.MCRtoCRbutton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.MathLabel);
            this.Name = "MissonControl";
            this.Text = "Misson Control Room";
            this.Load += new System.EventHandler(this.MissonControl_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button MCRtoCRbutton;
        private System.Windows.Forms.Button MCRtoDormbutton;
        private System.Windows.Forms.Button MCRtoDINbutton;
        private System.Windows.Forms.Button MCRtoGarbutton;
        private System.Windows.Forms.Button MissionButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer ButtonTimer;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Label MathLabel;
        private System.Windows.Forms.TextBox Answertext;
        private System.Windows.Forms.Label TimerLabel;
        private System.Windows.Forms.Label CorrectAnswersLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}
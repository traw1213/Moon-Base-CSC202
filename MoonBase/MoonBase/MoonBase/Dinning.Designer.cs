﻿namespace MoonBase
{
    partial class Dinning
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dinning));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CRdinbutton = new System.Windows.Forms.Button();
            this.Dormdinbutton = new System.Windows.Forms.Button();
            this.garagedinbutton = new System.Windows.Forms.Button();
            this.randomdinbutton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Silver;
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 316);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(463, 527);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Location Information";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.DimGray;
            this.textBox2.Location = new System.Drawing.Point(29, 182);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox2.Size = new System.Drawing.Size(380, 329);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = resources.GetString("textBox2.Text");
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.DimGray;
            this.textBox1.Location = new System.Drawing.Point(29, 59);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(380, 35);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "Dinning Hall";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(25, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Room Description";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(23, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Room Name ";
            // 
            // CRdinbutton
            // 
            this.CRdinbutton.BackColor = System.Drawing.Color.Silver;
            this.CRdinbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CRdinbutton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.CRdinbutton.Location = new System.Drawing.Point(1945, 154);
            this.CRdinbutton.Name = "CRdinbutton";
            this.CRdinbutton.Size = new System.Drawing.Size(75, 45);
            this.CRdinbutton.TabIndex = 1;
            this.CRdinbutton.Text = "Control Room";
            this.CRdinbutton.UseVisualStyleBackColor = false;
            this.CRdinbutton.Click += new System.EventHandler(this.CRdinbutton_Click);
            // 
            // Dormdinbutton
            // 
            this.Dormdinbutton.BackColor = System.Drawing.Color.Silver;
            this.Dormdinbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dormdinbutton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Dormdinbutton.Location = new System.Drawing.Point(1945, 205);
            this.Dormdinbutton.Name = "Dormdinbutton";
            this.Dormdinbutton.Size = new System.Drawing.Size(75, 45);
            this.Dormdinbutton.TabIndex = 2;
            this.Dormdinbutton.Text = "Dorms";
            this.Dormdinbutton.UseVisualStyleBackColor = false;
            this.Dormdinbutton.Click += new System.EventHandler(this.Dormdinbutton_Click);
            // 
            // garagedinbutton
            // 
            this.garagedinbutton.BackColor = System.Drawing.Color.Silver;
            this.garagedinbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.garagedinbutton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.garagedinbutton.Location = new System.Drawing.Point(1945, 256);
            this.garagedinbutton.Name = "garagedinbutton";
            this.garagedinbutton.Size = new System.Drawing.Size(75, 45);
            this.garagedinbutton.TabIndex = 3;
            this.garagedinbutton.Text = "Garage";
            this.garagedinbutton.UseVisualStyleBackColor = false;
            this.garagedinbutton.Click += new System.EventHandler(this.garagedinbutton_Click);
            // 
            // randomdinbutton
            // 
            this.randomdinbutton.BackColor = System.Drawing.Color.Silver;
            this.randomdinbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.randomdinbutton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.randomdinbutton.Location = new System.Drawing.Point(1945, 307);
            this.randomdinbutton.Name = "randomdinbutton";
            this.randomdinbutton.Size = new System.Drawing.Size(75, 45);
            this.randomdinbutton.TabIndex = 4;
            this.randomdinbutton.Text = "Random";
            this.randomdinbutton.UseVisualStyleBackColor = false;
            this.randomdinbutton.Click += new System.EventHandler(this.randomdinbutton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Silver;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(1912, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Navigation";
            // 
            // Dinning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(2032, 985);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.randomdinbutton);
            this.Controls.Add(this.garagedinbutton);
            this.Controls.Add(this.Dormdinbutton);
            this.Controls.Add(this.CRdinbutton);
            this.Controls.Add(this.groupBox1);
            this.Name = "Dinning";
            this.Text = "Dinning";
            this.Load += new System.EventHandler(this.Dinning_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button CRdinbutton;
        private System.Windows.Forms.Button Dormdinbutton;
        private System.Windows.Forms.Button garagedinbutton;
        private System.Windows.Forms.Button randomdinbutton;
        private System.Windows.Forms.Label label3;
    }
}
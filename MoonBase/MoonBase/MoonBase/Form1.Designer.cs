namespace MoonBase
{
    partial class Mainform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mainform));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DormCRbutton = new System.Windows.Forms.Button();
            this.DinningCRbutton = new System.Windows.Forms.Button();
            this.GarageCRbutton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.RandomCRbutton = new System.Windows.Forms.Button();
            this.viewLogButton = new System.Windows.Forms.Button();
            this.CRtoMCRbutton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(41, 195);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(512, 654);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Location Information";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(10, 173);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(470, 404);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = resources.GetString("textBox2.Text");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Room Description";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(10, 58);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(333, 35);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Central Control Room";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Room Name";
            // 
            // DormCRbutton
            // 
            this.DormCRbutton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.DormCRbutton.Cursor = System.Windows.Forms.Cursors.Default;
            this.DormCRbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DormCRbutton.Location = new System.Drawing.Point(1924, 118);
            this.DormCRbutton.Name = "DormCRbutton";
            this.DormCRbutton.Size = new System.Drawing.Size(96, 31);
            this.DormCRbutton.TabIndex = 1;
            this.DormCRbutton.Tag = "";
            this.DormCRbutton.Text = "Dorms";
            this.DormCRbutton.UseVisualStyleBackColor = false;
            this.DormCRbutton.Click += new System.EventHandler(this.DormCRbutton_Click);
            // 
            // DinningCRbutton
            // 
            this.DinningCRbutton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.DinningCRbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DinningCRbutton.Location = new System.Drawing.Point(1924, 170);
            this.DinningCRbutton.Name = "DinningCRbutton";
            this.DinningCRbutton.Size = new System.Drawing.Size(96, 31);
            this.DinningCRbutton.TabIndex = 2;
            this.DinningCRbutton.Text = "Dinning";
            this.DinningCRbutton.UseVisualStyleBackColor = false;
            this.DinningCRbutton.Click += new System.EventHandler(this.DinningCRbutton_Click);
            // 
            // GarageCRbutton
            // 
            this.GarageCRbutton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.GarageCRbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GarageCRbutton.Location = new System.Drawing.Point(1924, 221);
            this.GarageCRbutton.Name = "GarageCRbutton";
            this.GarageCRbutton.Size = new System.Drawing.Size(96, 30);
            this.GarageCRbutton.TabIndex = 3;
            this.GarageCRbutton.Text = "Garage";
            this.GarageCRbutton.UseVisualStyleBackColor = false;
            this.GarageCRbutton.Click += new System.EventHandler(this.GarageCRbutton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1910, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Navigation";
            // 
            // RandomCRbutton
            // 
            this.RandomCRbutton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.RandomCRbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RandomCRbutton.Location = new System.Drawing.Point(1924, 273);
            this.RandomCRbutton.Name = "RandomCRbutton";
            this.RandomCRbutton.Size = new System.Drawing.Size(96, 30);
            this.RandomCRbutton.TabIndex = 5;
            this.RandomCRbutton.Text = "Random";
            this.RandomCRbutton.UseVisualStyleBackColor = false;
            this.RandomCRbutton.Click += new System.EventHandler(this.RandomCRbutton_Click);
            // 
            // viewLogButton
            // 
            this.viewLogButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewLogButton.ForeColor = System.Drawing.Color.Red;
            this.viewLogButton.Location = new System.Drawing.Point(1924, 911);
            this.viewLogButton.Name = "viewLogButton";
            this.viewLogButton.Size = new System.Drawing.Size(96, 30);
            this.viewLogButton.TabIndex = 6;
            this.viewLogButton.Text = "View Log";
            this.viewLogButton.UseVisualStyleBackColor = true;
            this.viewLogButton.Click += new System.EventHandler(this.viewLogButton_Click);
            // 
            // CRtoMCRbutton
            // 
            this.CRtoMCRbutton.BackColor = System.Drawing.Color.Gold;
            this.CRtoMCRbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CRtoMCRbutton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CRtoMCRbutton.Location = new System.Drawing.Point(1924, 321);
            this.CRtoMCRbutton.Name = "CRtoMCRbutton";
            this.CRtoMCRbutton.Size = new System.Drawing.Size(94, 30);
            this.CRtoMCRbutton.TabIndex = 7;
            this.CRtoMCRbutton.Text = "Mission Control Room";
            this.CRtoMCRbutton.UseVisualStyleBackColor = false;
            this.CRtoMCRbutton.Click += new System.EventHandler(this.CRtoMCRbutton_Click);
            // 
            // Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(2032, 985);
            this.Controls.Add(this.CRtoMCRbutton);
            this.Controls.Add(this.viewLogButton);
            this.Controls.Add(this.RandomCRbutton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.GarageCRbutton);
            this.Controls.Add(this.DinningCRbutton);
            this.Controls.Add(this.DormCRbutton);
            this.Controls.Add(this.groupBox1);
            this.Name = "Mainform";
            this.Text = "MoonBase Trav";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button DormCRbutton;
        private System.Windows.Forms.Button DinningCRbutton;
        private System.Windows.Forms.Button GarageCRbutton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button RandomCRbutton;
        private System.Windows.Forms.Button viewLogButton;
        private System.Windows.Forms.Button CRtoMCRbutton;
    }
}


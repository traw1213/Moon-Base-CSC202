namespace MoonBase
{
    partial class Dorms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dorms));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.DinningDbutton = new System.Windows.Forms.Button();
            this.CRdormbutton = new System.Windows.Forms.Button();
            this.GarageDbutton = new System.Windows.Forms.Button();
            this.RandomDbutton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(23, 277);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(390, 492);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Location Information";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Room Description";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Room Name";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(26, 152);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox2.Size = new System.Drawing.Size(317, 318);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = resources.GetString("textBox2.Text");
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(26, 55);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(317, 35);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Dorms";
            // 
            // DinningDbutton
            // 
            this.DinningDbutton.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.DinningDbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DinningDbutton.Location = new System.Drawing.Point(1945, 131);
            this.DinningDbutton.Name = "DinningDbutton";
            this.DinningDbutton.Size = new System.Drawing.Size(75, 45);
            this.DinningDbutton.TabIndex = 1;
            this.DinningDbutton.Text = "Dinning";
            this.DinningDbutton.UseVisualStyleBackColor = false;
            this.DinningDbutton.Click += new System.EventHandler(this.DinningDbutton_Click);
            // 
            // CRdormbutton
            // 
            this.CRdormbutton.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.CRdormbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CRdormbutton.Location = new System.Drawing.Point(1945, 182);
            this.CRdormbutton.Name = "CRdormbutton";
            this.CRdormbutton.Size = new System.Drawing.Size(75, 45);
            this.CRdormbutton.TabIndex = 2;
            this.CRdormbutton.Text = "Control Room";
            this.CRdormbutton.UseVisualStyleBackColor = false;
            this.CRdormbutton.Click += new System.EventHandler(this.CRdormbutton_Click);
            // 
            // GarageDbutton
            // 
            this.GarageDbutton.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.GarageDbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GarageDbutton.Location = new System.Drawing.Point(1945, 233);
            this.GarageDbutton.Name = "GarageDbutton";
            this.GarageDbutton.Size = new System.Drawing.Size(75, 45);
            this.GarageDbutton.TabIndex = 3;
            this.GarageDbutton.Text = "Garage";
            this.GarageDbutton.UseVisualStyleBackColor = false;
            this.GarageDbutton.Click += new System.EventHandler(this.GarageDbutton_Click);
            // 
            // RandomDbutton
            // 
            this.RandomDbutton.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.RandomDbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RandomDbutton.Location = new System.Drawing.Point(1945, 284);
            this.RandomDbutton.Name = "RandomDbutton";
            this.RandomDbutton.Size = new System.Drawing.Size(75, 45);
            this.RandomDbutton.TabIndex = 4;
            this.RandomDbutton.Text = "Random";
            this.RandomDbutton.UseVisualStyleBackColor = false;
            this.RandomDbutton.Click += new System.EventHandler(this.RandomDbutton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1913, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Navigation";
            // 
            // Dorms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(2032, 985);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.RandomDbutton);
            this.Controls.Add(this.GarageDbutton);
            this.Controls.Add(this.CRdormbutton);
            this.Controls.Add(this.DinningDbutton);
            this.Controls.Add(this.groupBox1);
            this.Name = "Dorms";
            this.Text = "Dorms";
            this.Load += new System.EventHandler(this.Dorms_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button DinningDbutton;
        private System.Windows.Forms.Button CRdormbutton;
        private System.Windows.Forms.Button GarageDbutton;
        private System.Windows.Forms.Button RandomDbutton;
        private System.Windows.Forms.Label label3;
    }
}
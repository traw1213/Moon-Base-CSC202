namespace MoonBase
{
    partial class Garage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Garage));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.CRgaragebutton = new System.Windows.Forms.Button();
            this.DinningGbutton = new System.Windows.Forms.Button();
            this.DormGbutton = new System.Windows.Forms.Button();
            this.RandomGbutton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Desktop;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(13, 254);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(439, 536);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Room Information";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Room Description";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Room Name";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Desktop;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox2.Location = new System.Drawing.Point(27, 207);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(346, 311);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = resources.GetString("textBox2.Text");
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Desktop;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox1.Location = new System.Drawing.Point(27, 71);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(346, 35);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Garage";
            // 
            // CRgaragebutton
            // 
            this.CRgaragebutton.BackColor = System.Drawing.SystemColors.Desktop;
            this.CRgaragebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CRgaragebutton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CRgaragebutton.Location = new System.Drawing.Point(1945, 157);
            this.CRgaragebutton.Name = "CRgaragebutton";
            this.CRgaragebutton.Size = new System.Drawing.Size(75, 45);
            this.CRgaragebutton.TabIndex = 1;
            this.CRgaragebutton.Text = "Control Room";
            this.CRgaragebutton.UseVisualStyleBackColor = false;
            this.CRgaragebutton.Click += new System.EventHandler(this.CRgaragebutton_Click);
            // 
            // DinningGbutton
            // 
            this.DinningGbutton.BackColor = System.Drawing.SystemColors.Desktop;
            this.DinningGbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DinningGbutton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DinningGbutton.Location = new System.Drawing.Point(1945, 208);
            this.DinningGbutton.Name = "DinningGbutton";
            this.DinningGbutton.Size = new System.Drawing.Size(75, 45);
            this.DinningGbutton.TabIndex = 2;
            this.DinningGbutton.Text = "Dinning";
            this.DinningGbutton.UseVisualStyleBackColor = false;
            this.DinningGbutton.Click += new System.EventHandler(this.DinningGbutton_Click);
            // 
            // DormGbutton
            // 
            this.DormGbutton.BackColor = System.Drawing.SystemColors.Desktop;
            this.DormGbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DormGbutton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DormGbutton.Location = new System.Drawing.Point(1945, 259);
            this.DormGbutton.Name = "DormGbutton";
            this.DormGbutton.Size = new System.Drawing.Size(75, 45);
            this.DormGbutton.TabIndex = 3;
            this.DormGbutton.Text = "Dorms";
            this.DormGbutton.UseVisualStyleBackColor = false;
            this.DormGbutton.Click += new System.EventHandler(this.DormGbutton_Click);
            // 
            // RandomGbutton
            // 
            this.RandomGbutton.BackColor = System.Drawing.SystemColors.Desktop;
            this.RandomGbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RandomGbutton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RandomGbutton.Location = new System.Drawing.Point(1945, 310);
            this.RandomGbutton.Name = "RandomGbutton";
            this.RandomGbutton.Size = new System.Drawing.Size(75, 45);
            this.RandomGbutton.TabIndex = 4;
            this.RandomGbutton.Text = "Random";
            this.RandomGbutton.UseVisualStyleBackColor = false;
            this.RandomGbutton.Click += new System.EventHandler(this.RandomGbutton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DimGray;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1912, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Navigation";
            // 
            // Garage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(2032, 985);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.RandomGbutton);
            this.Controls.Add(this.DormGbutton);
            this.Controls.Add(this.DinningGbutton);
            this.Controls.Add(this.CRgaragebutton);
            this.Controls.Add(this.groupBox1);
            this.Name = "Garage";
            this.Text = "Garage";
            this.Load += new System.EventHandler(this.Garage_Load);
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
        private System.Windows.Forms.Button CRgaragebutton;
        private System.Windows.Forms.Button DinningGbutton;
        private System.Windows.Forms.Button DormGbutton;
        private System.Windows.Forms.Button RandomGbutton;
        private System.Windows.Forms.Label label3;
    }
}
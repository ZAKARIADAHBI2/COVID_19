
namespace corona_window
{
    partial class Result
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.testnbr = new System.Windows.Forms.TextBox();
            this.perid = new System.Windows.Forms.TextBox();
            this.UNINFECTED = new System.Windows.Forms.Button();
            this.INFECTED = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.rslt = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(138, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Test info";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Test Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Person id";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Result";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "NeveauRisqueColor";
            // 
            // testnbr
            // 
            this.testnbr.Location = new System.Drawing.Point(141, 70);
            this.testnbr.Name = "testnbr";
            this.testnbr.Size = new System.Drawing.Size(138, 20);
            this.testnbr.TabIndex = 6;
            // 
            // perid
            // 
            this.perid.Location = new System.Drawing.Point(141, 113);
            this.perid.Name = "perid";
            this.perid.Size = new System.Drawing.Size(138, 20);
            this.perid.TabIndex = 7;
            // 
            // UNINFECTED
            // 
            this.UNINFECTED.Location = new System.Drawing.Point(225, 315);
            this.UNINFECTED.Name = "UNINFECTED";
            this.UNINFECTED.Size = new System.Drawing.Size(75, 23);
            this.UNINFECTED.TabIndex = 12;
            this.UNINFECTED.Text = "UNINFECTED";
            this.UNINFECTED.UseVisualStyleBackColor = true;
            this.UNINFECTED.Click += new System.EventHandler(this.button4_Click);
            // 
            // INFECTED
            // 
            this.INFECTED.Location = new System.Drawing.Point(47, 315);
            this.INFECTED.Name = "INFECTED";
            this.INFECTED.Size = new System.Drawing.Size(75, 23);
            this.INFECTED.TabIndex = 11;
            this.INFECTED.Text = "INFECTED";
            this.INFECTED.UseVisualStyleBackColor = true;
            this.INFECTED.Click += new System.EventHandler(this.INFECTED_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::corona_window.Properties.Resources.homee;
            this.pictureBox1.Location = new System.Drawing.Point(304, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.radioButton3.Location = new System.Drawing.Point(257, 223);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(60, 17);
            this.radioButton3.TabIndex = 16;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Orange";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.ForeColor = System.Drawing.Color.Green;
            this.radioButton2.Location = new System.Drawing.Point(201, 223);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(49, 17);
            this.radioButton2.TabIndex = 15;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "verte";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.ForeColor = System.Drawing.Color.Red;
            this.radioButton1.Location = new System.Drawing.Point(138, 223);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(57, 17);
            this.radioButton1.TabIndex = 14;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Rouge";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // rslt
            // 
            this.rslt.FormattingEnabled = true;
            this.rslt.Location = new System.Drawing.Point(141, 164);
            this.rslt.Name = "rslt";
            this.rslt.Size = new System.Drawing.Size(138, 21);
            this.rslt.TabIndex = 17;
            this.rslt.SelectedIndexChanged += new System.EventHandler(this.rslt_SelectedIndexChanged);
            // 
            // Result
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Chocolate;
            this.ClientSize = new System.Drawing.Size(344, 381);
            this.Controls.Add(this.rslt);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.UNINFECTED);
            this.Controls.Add(this.INFECTED);
            this.Controls.Add(this.perid);
            this.Controls.Add(this.testnbr);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Result";
            this.Text = "Result";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox testnbr;
        private System.Windows.Forms.TextBox perid;
        private System.Windows.Forms.Button UNINFECTED;
        private System.Windows.Forms.Button INFECTED;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.ComboBox rslt;
    }
}
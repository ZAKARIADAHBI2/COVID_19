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
            this.rslt = new System.Windows.Forms.ComboBox();
            this.color = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.duree = new System.Windows.Forms.TextBox();
            this.upd = new System.Windows.Forms.Button();
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
            this.testnbr.Location = new System.Drawing.Point(185, 74);
            this.testnbr.Name = "testnbr";
            this.testnbr.Size = new System.Drawing.Size(138, 20);
            this.testnbr.TabIndex = 6;
            // 
            // perid
            // 
            this.perid.Location = new System.Drawing.Point(185, 117);
            this.perid.Name = "perid";
            this.perid.Size = new System.Drawing.Size(138, 20);
            this.perid.TabIndex = 7;
            // 
            // UNINFECTED
            // 
            this.UNINFECTED.Location = new System.Drawing.Point(248, 379);
            this.UNINFECTED.Name = "UNINFECTED";
            this.UNINFECTED.Size = new System.Drawing.Size(75, 23);
            this.UNINFECTED.TabIndex = 12;
            this.UNINFECTED.Text = "UNINFECTED";
            this.UNINFECTED.UseVisualStyleBackColor = true;
            this.UNINFECTED.Click += new System.EventHandler(this.button4_Click);
            // 
            // INFECTED
            // 
            this.INFECTED.Location = new System.Drawing.Point(23, 379);
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
            this.pictureBox1.Location = new System.Drawing.Point(312, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // rslt
            // 
            this.rslt.FormattingEnabled = true;
            this.rslt.Location = new System.Drawing.Point(185, 168);
            this.rslt.Name = "rslt";
            this.rslt.Size = new System.Drawing.Size(138, 21);
            this.rslt.TabIndex = 17;
            this.rslt.SelectedIndexChanged += new System.EventHandler(this.rslt_SelectedIndexChanged);
            // 
            // color
            // 
            this.color.FormattingEnabled = true;
            this.color.Location = new System.Drawing.Point(185, 223);
            this.color.Name = "color";
            this.color.Size = new System.Drawing.Size(138, 21);
            this.color.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 273);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Duree de la Confinement";
            // 
            // duree
            // 
            this.duree.Location = new System.Drawing.Point(185, 270);
            this.duree.Name = "duree";
            this.duree.Size = new System.Drawing.Size(138, 20);
            this.duree.TabIndex = 20;
            // 
            // upd
            // 
            this.upd.Location = new System.Drawing.Point(130, 379);
            this.upd.Name = "upd";
            this.upd.Size = new System.Drawing.Size(75, 23);
            this.upd.TabIndex = 21;
            this.upd.Text = "Update";
            this.upd.UseVisualStyleBackColor = true;
            this.upd.Click += new System.EventHandler(this.upd_Click);
            // 
            // Result
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Chocolate;
            this.ClientSize = new System.Drawing.Size(344, 450);
            this.Controls.Add(this.upd);
            this.Controls.Add(this.duree);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.color);
            this.Controls.Add(this.rslt);
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
        private System.Windows.Forms.ComboBox rslt;
        private System.Windows.Forms.ComboBox color;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox duree;
        private System.Windows.Forms.Button upd;
    }
}
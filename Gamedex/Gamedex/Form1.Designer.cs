namespace Gamedex
{
    partial class Form1
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
            this.PrevB = new System.Windows.Forms.Button();
            this.NextB = new System.Windows.Forms.Button();
            this.FirstB = new System.Windows.Forms.Button();
            this.LastB = new System.Windows.Forms.Button();
            this.NewB = new System.Windows.Forms.Button();
            this.displayPB = new System.Windows.Forms.PictureBox();
            this.nameTB = new System.Windows.Forms.TextBox();
            this.creatorTB = new System.Windows.Forms.TextBox();
            this.revenueTB = new System.Windows.Forms.TextBox();
            this.mcTB = new System.Windows.Forms.TextBox();
            this.ratingUD = new System.Windows.Forms.DomainUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.genreTB = new System.Windows.Forms.TextBox();
            this.typeTB = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.displayPB)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Creator:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = "Rating:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 30);
            this.label4.TabIndex = 3;
            this.label4.Text = "Revenue:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 286);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(176, 30);
            this.label5.TabIndex = 4;
            this.label5.Text = "Main Character:";
            // 
            // PrevB
            // 
            this.PrevB.Location = new System.Drawing.Point(687, 341);
            this.PrevB.Name = "PrevB";
            this.PrevB.Size = new System.Drawing.Size(125, 43);
            this.PrevB.TabIndex = 5;
            this.PrevB.Text = "Previous";
            this.PrevB.UseVisualStyleBackColor = true;
            this.PrevB.Click += new System.EventHandler(this.PrevB_Click);
            // 
            // NextB
            // 
            this.NextB.Location = new System.Drawing.Point(901, 341);
            this.NextB.Name = "NextB";
            this.NextB.Size = new System.Drawing.Size(125, 43);
            this.NextB.TabIndex = 6;
            this.NextB.Text = "Next";
            this.NextB.UseVisualStyleBackColor = true;
            this.NextB.Click += new System.EventHandler(this.NextB_Click);
            // 
            // FirstB
            // 
            this.FirstB.Location = new System.Drawing.Point(815, 414);
            this.FirstB.Name = "FirstB";
            this.FirstB.Size = new System.Drawing.Size(125, 43);
            this.FirstB.TabIndex = 7;
            this.FirstB.Text = "First";
            this.FirstB.UseVisualStyleBackColor = true;
            this.FirstB.Click += new System.EventHandler(this.FirstB_Click);
            // 
            // LastB
            // 
            this.LastB.Location = new System.Drawing.Point(970, 414);
            this.LastB.Name = "LastB";
            this.LastB.Size = new System.Drawing.Size(125, 43);
            this.LastB.TabIndex = 8;
            this.LastB.Text = "Last";
            this.LastB.UseVisualStyleBackColor = true;
            this.LastB.Click += new System.EventHandler(this.LastB_Click);
            // 
            // NewB
            // 
            this.NewB.Location = new System.Drawing.Point(575, 414);
            this.NewB.Name = "NewB";
            this.NewB.Size = new System.Drawing.Size(125, 43);
            this.NewB.TabIndex = 9;
            this.NewB.Text = "New";
            this.NewB.UseVisualStyleBackColor = true;
            this.NewB.Click += new System.EventHandler(this.NewB_Click);
            // 
            // displayPB
            // 
            this.displayPB.Location = new System.Drawing.Point(575, 13);
            this.displayPB.Name = "displayPB";
            this.displayPB.Size = new System.Drawing.Size(520, 322);
            this.displayPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.displayPB.TabIndex = 10;
            this.displayPB.TabStop = false;
            this.displayPB.Click += new System.EventHandler(this.displayPB_Click);
            // 
            // nameTB
            // 
            this.nameTB.Location = new System.Drawing.Point(113, 30);
            this.nameTB.Name = "nameTB";
            this.nameTB.Size = new System.Drawing.Size(425, 38);
            this.nameTB.TabIndex = 11;
            // 
            // creatorTB
            // 
            this.creatorTB.Location = new System.Drawing.Point(126, 94);
            this.creatorTB.Name = "creatorTB";
            this.creatorTB.Size = new System.Drawing.Size(412, 38);
            this.creatorTB.TabIndex = 12;
            // 
            // revenueTB
            // 
            this.revenueTB.Location = new System.Drawing.Point(141, 222);
            this.revenueTB.Name = "revenueTB";
            this.revenueTB.Size = new System.Drawing.Size(406, 38);
            this.revenueTB.TabIndex = 14;
            // 
            // mcTB
            // 
            this.mcTB.Location = new System.Drawing.Point(210, 286);
            this.mcTB.Name = "mcTB";
            this.mcTB.Size = new System.Drawing.Size(328, 38);
            this.mcTB.TabIndex = 15;
            // 
            // ratingUD
            // 
            this.ratingUD.Items.Add("Early_Childhood");
            this.ratingUD.Items.Add("Everyone");
            this.ratingUD.Items.Add("Everyone_Ten_Up");
            this.ratingUD.Items.Add("Teen");
            this.ratingUD.Items.Add("Mature");
            this.ratingUD.Items.Add("Adults_Only");
            this.ratingUD.Items.Add("Rating_Pending");
            this.ratingUD.Location = new System.Drawing.Point(126, 158);
            this.ratingUD.Name = "ratingUD";
            this.ratingUD.ReadOnly = true;
            this.ratingUD.Size = new System.Drawing.Size(421, 38);
            this.ratingUD.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 350);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 30);
            this.label6.TabIndex = 17;
            this.label6.Text = "Genre:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 414);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 30);
            this.label7.TabIndex = 18;
            this.label7.Text = "Type:";
            // 
            // genreTB
            // 
            this.genreTB.Location = new System.Drawing.Point(113, 350);
            this.genreTB.Name = "genreTB";
            this.genreTB.Size = new System.Drawing.Size(425, 38);
            this.genreTB.TabIndex = 19;
            // 
            // typeTB
            // 
            this.typeTB.Location = new System.Drawing.Point(103, 414);
            this.typeTB.Name = "typeTB";
            this.typeTB.Size = new System.Drawing.Size(435, 38);
            this.typeTB.TabIndex = 20;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 482);
            this.Controls.Add(this.typeTB);
            this.Controls.Add(this.genreTB);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ratingUD);
            this.Controls.Add(this.mcTB);
            this.Controls.Add(this.revenueTB);
            this.Controls.Add(this.creatorTB);
            this.Controls.Add(this.nameTB);
            this.Controls.Add(this.displayPB);
            this.Controls.Add(this.NewB);
            this.Controls.Add(this.LastB);
            this.Controls.Add(this.FirstB);
            this.Controls.Add(this.NextB);
            this.Controls.Add(this.PrevB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Yi Baiti", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Form1";
            this.Text = "Gamedex";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.displayPB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button PrevB;
        private System.Windows.Forms.Button NextB;
        private System.Windows.Forms.Button FirstB;
        private System.Windows.Forms.Button LastB;
        private System.Windows.Forms.Button NewB;
        private System.Windows.Forms.PictureBox displayPB;
        private System.Windows.Forms.TextBox nameTB;
        private System.Windows.Forms.TextBox creatorTB;
        private System.Windows.Forms.TextBox revenueTB;
        private System.Windows.Forms.TextBox mcTB;
        private System.Windows.Forms.DomainUpDown ratingUD;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox genreTB;
        private System.Windows.Forms.TextBox typeTB;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}


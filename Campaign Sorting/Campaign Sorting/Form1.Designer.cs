namespace Campaign_Sorting
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
            this.campaignTB = new System.Windows.Forms.TextBox();
            this.playerTB = new System.Windows.Forms.TextBox();
            this.next1B = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(362, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number of Campaigns:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(300, 47);
            this.label2.TabIndex = 1;
            this.label2.Text = "Number of Players:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poor Richard", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(45, 300);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(799, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "*Remember: don\'t enter pre-determined campaigns or DMs into player count.*";
            // 
            // campaignTB
            // 
            this.campaignTB.Location = new System.Drawing.Point(421, 75);
            this.campaignTB.Name = "campaignTB";
            this.campaignTB.Size = new System.Drawing.Size(154, 53);
            this.campaignTB.TabIndex = 3;
            // 
            // playerTB
            // 
            this.playerTB.Location = new System.Drawing.Point(359, 180);
            this.playerTB.Name = "playerTB";
            this.playerTB.Size = new System.Drawing.Size(216, 53);
            this.playerTB.TabIndex = 4;
            // 
            // next1B
            // 
            this.next1B.Location = new System.Drawing.Point(658, 124);
            this.next1B.Name = "next1B";
            this.next1B.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.next1B.Size = new System.Drawing.Size(149, 56);
            this.next1B.TabIndex = 5;
            this.next1B.Text = "Next";
            this.next1B.UseVisualStyleBackColor = true;
            this.next1B.Click += new System.EventHandler(this.next1B_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(21F, 47F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 397);
            this.Controls.Add(this.next1B);
            this.Controls.Add(this.playerTB);
            this.Controls.Add(this.campaignTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Poor Richard", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.Name = "Form1";
            this.Text = "Number Entry";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox campaignTB;
        private System.Windows.Forms.TextBox playerTB;
        private System.Windows.Forms.Button next1B;
    }
}


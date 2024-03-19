namespace Practice
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
            this.calPick = new System.Windows.Forms.MonthCalendar();
            this.saveB = new System.Windows.Forms.Button();
            this.eTimeTB = new System.Windows.Forms.TextBox();
            this.sTimeTB = new System.Windows.Forms.TextBox();
            this.typeUD = new System.Windows.Forms.DomainUpDown();
            this.busyCB = new System.Windows.Forms.CheckBox();
            this.nameTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.enterTB = new System.Windows.Forms.TextBox();
            this.printTB = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // calPick
            // 
            this.calPick.Location = new System.Drawing.Point(16, 17);
            this.calPick.Margin = new System.Windows.Forms.Padding(16, 17, 16, 17);
            this.calPick.MaxDate = new System.DateTime(2024, 12, 31, 0, 0, 0, 0);
            this.calPick.MinDate = new System.DateTime(2024, 1, 1, 0, 0, 0, 0);
            this.calPick.Name = "calPick";
            this.calPick.TabIndex = 0;
            this.calPick.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.calPick_DateChanged);
            // 
            // saveB
            // 
            this.saveB.Location = new System.Drawing.Point(16, 238);
            this.saveB.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.saveB.Name = "saveB";
            this.saveB.Size = new System.Drawing.Size(153, 50);
            this.saveB.TabIndex = 1;
            this.saveB.Text = "Save";
            this.saveB.UseVisualStyleBackColor = true;
            this.saveB.Click += new System.EventHandler(this.saveB_Click);
            // 
            // eTimeTB
            // 
            this.eTimeTB.Location = new System.Drawing.Point(611, 205);
            this.eTimeTB.Name = "eTimeTB";
            this.eTimeTB.Size = new System.Drawing.Size(143, 38);
            this.eTimeTB.TabIndex = 18;
            // 
            // sTimeTB
            // 
            this.sTimeTB.Location = new System.Drawing.Point(388, 205);
            this.sTimeTB.Name = "sTimeTB";
            this.sTimeTB.Size = new System.Drawing.Size(143, 38);
            this.sTimeTB.TabIndex = 17;
            // 
            // typeUD
            // 
            this.typeUD.AllowDrop = true;
            this.typeUD.Items.Add("Home");
            this.typeUD.Items.Add("School");
            this.typeUD.Items.Add("Work");
            this.typeUD.Items.Add("Family");
            this.typeUD.Items.Add("Friends");
            this.typeUD.Items.Add("Errand");
            this.typeUD.Items.Add("None");
            this.typeUD.Location = new System.Drawing.Point(388, 140);
            this.typeUD.Name = "typeUD";
            this.typeUD.ReadOnly = true;
            this.typeUD.Size = new System.Drawing.Size(366, 38);
            this.typeUD.TabIndex = 16;
            // 
            // busyCB
            // 
            this.busyCB.AutoSize = true;
            this.busyCB.Font = new System.Drawing.Font("MS UI Gothic", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.busyCB.Location = new System.Drawing.Point(397, 67);
            this.busyCB.Name = "busyCB";
            this.busyCB.Size = new System.Drawing.Size(56, 51);
            this.busyCB.TabIndex = 15;
            this.busyCB.Text = " ";
            this.busyCB.UseVisualStyleBackColor = true;
            // 
            // nameTB
            // 
            this.nameTB.Location = new System.Drawing.Point(397, 14);
            this.nameTB.Name = "nameTB";
            this.nameTB.Size = new System.Drawing.Size(357, 38);
            this.nameTB.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(306, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 31);
            this.label4.TabIndex = 13;
            this.label4.Text = "Time:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(306, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 31);
            this.label3.TabIndex = 12;
            this.label3.Text = "Type:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(306, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 31);
            this.label2.TabIndex = 11;
            this.label2.Text = "Busy:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(306, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 31);
            this.label1.TabIndex = 10;
            this.label1.Text = "Event:";
            // 
            // enterTB
            // 
            this.enterTB.Location = new System.Drawing.Point(474, 347);
            this.enterTB.Name = "enterTB";
            this.enterTB.Size = new System.Drawing.Size(577, 38);
            this.enterTB.TabIndex = 19;
            // 
            // printTB
            // 
            this.printTB.Enabled = false;
            this.printTB.Location = new System.Drawing.Point(474, 422);
            this.printTB.Name = "printTB";
            this.printTB.Size = new System.Drawing.Size(577, 38);
            this.printTB.TabIndex = 20;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(75, 347);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(203, 75);
            this.button1.TabIndex = 21;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 503);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.printTB);
            this.Controls.Add(this.enterTB);
            this.Controls.Add(this.eTimeTB);
            this.Controls.Add(this.sTimeTB);
            this.Controls.Add(this.typeUD);
            this.Controls.Add(this.busyCB);
            this.Controls.Add(this.nameTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.saveB);
            this.Controls.Add(this.calPick);
            this.Font = new System.Drawing.Font("Poor Richard", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar calPick;
        private System.Windows.Forms.Button saveB;
        private System.Windows.Forms.TextBox eTimeTB;
        private System.Windows.Forms.TextBox sTimeTB;
        private System.Windows.Forms.DomainUpDown typeUD;
        private System.Windows.Forms.CheckBox busyCB;
        private System.Windows.Forms.TextBox nameTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox enterTB;
        private System.Windows.Forms.TextBox printTB;
        private System.Windows.Forms.Button button1;
    }
}


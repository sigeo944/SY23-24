namespace Day_Planner
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
            this.nameTB = new System.Windows.Forms.TextBox();
            this.busyCB = new System.Windows.Forms.CheckBox();
            this.typeUD = new System.Windows.Forms.DomainUpDown();
            this.sTimeTB = new System.Windows.Forms.TextBox();
            this.eTimeTB = new System.Windows.Forms.TextBox();
            this.saveB = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.calPick = new System.Windows.Forms.DateTimePicker();
            this.goB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 277);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Event:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 336);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Busy:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 402);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 28);
            this.label3.TabIndex = 3;
            this.label3.Text = "Type:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 465);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 28);
            this.label4.TabIndex = 4;
            this.label4.Text = "Time:";
            // 
            // nameTB
            // 
            this.nameTB.Location = new System.Drawing.Point(138, 274);
            this.nameTB.Name = "nameTB";
            this.nameTB.Size = new System.Drawing.Size(357, 34);
            this.nameTB.TabIndex = 5;
            // 
            // busyCB
            // 
            this.busyCB.AutoSize = true;
            this.busyCB.Font = new System.Drawing.Font("MS UI Gothic", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.busyCB.Location = new System.Drawing.Point(138, 327);
            this.busyCB.Name = "busyCB";
            this.busyCB.Size = new System.Drawing.Size(56, 51);
            this.busyCB.TabIndex = 6;
            this.busyCB.Text = " ";
            this.busyCB.UseVisualStyleBackColor = true;
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
            this.typeUD.Location = new System.Drawing.Point(129, 400);
            this.typeUD.Name = "typeUD";
            this.typeUD.ReadOnly = true;
            this.typeUD.Size = new System.Drawing.Size(366, 34);
            this.typeUD.TabIndex = 7;
            // 
            // sTimeTB
            // 
            this.sTimeTB.Location = new System.Drawing.Point(129, 465);
            this.sTimeTB.Name = "sTimeTB";
            this.sTimeTB.Size = new System.Drawing.Size(143, 34);
            this.sTimeTB.TabIndex = 8;
            // 
            // eTimeTB
            // 
            this.eTimeTB.Location = new System.Drawing.Point(352, 465);
            this.eTimeTB.Name = "eTimeTB";
            this.eTimeTB.Size = new System.Drawing.Size(143, 34);
            this.eTimeTB.TabIndex = 9;
            // 
            // saveB
            // 
            this.saveB.Location = new System.Drawing.Point(476, 175);
            this.saveB.Name = "saveB";
            this.saveB.Size = new System.Drawing.Size(107, 50);
            this.saveB.TabIndex = 10;
            this.saveB.Text = "Save";
            this.saveB.UseVisualStyleBackColor = true;
            this.saveB.Click += new System.EventHandler(this.saveB_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(558, 292);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 14;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // calPick
            // 
            this.calPick.Location = new System.Drawing.Point(92, 71);
            this.calPick.Name = "calPick";
            this.calPick.Size = new System.Drawing.Size(451, 34);
            this.calPick.TabIndex = 15;
            // 
            // goB
            // 
            this.goB.Location = new System.Drawing.Point(585, 55);
            this.goB.Name = "goB";
            this.goB.Size = new System.Drawing.Size(107, 50);
            this.goB.TabIndex = 16;
            this.goB.Text = "Save";
            this.goB.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 534);
            this.Controls.Add(this.goB);
            this.Controls.Add(this.calPick);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.saveB);
            this.Controls.Add(this.eTimeTB);
            this.Controls.Add(this.sTimeTB);
            this.Controls.Add(this.typeUD);
            this.Controls.Add(this.busyCB);
            this.Controls.Add(this.nameTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Day Planner";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nameTB;
        private System.Windows.Forms.CheckBox busyCB;
        private System.Windows.Forms.DomainUpDown typeUD;
        private System.Windows.Forms.TextBox sTimeTB;
        private System.Windows.Forms.TextBox eTimeTB;
        private System.Windows.Forms.Button saveB;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.DateTimePicker calPick;
        private System.Windows.Forms.Button goB;
    }
}


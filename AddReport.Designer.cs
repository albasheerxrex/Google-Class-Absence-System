namespace Google_Class_Absence_System
{
    partial class AddReport
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
            this.AddFileButton1 = new System.Windows.Forms.Button();
            this.selectstudy = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Closebutton2 = new System.Windows.Forms.Button();
            this.AddReportButtem = new System.Windows.Forms.Button();
            this.SelectGradeButton4 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AddFileButton1
            // 
            this.AddFileButton1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.AddFileButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddFileButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddFileButton1.ForeColor = System.Drawing.SystemColors.Control;
            this.AddFileButton1.Location = new System.Drawing.Point(510, 13);
            this.AddFileButton1.Name = "AddFileButton1";
            this.AddFileButton1.Size = new System.Drawing.Size(109, 24);
            this.AddFileButton1.TabIndex = 0;
            this.AddFileButton1.Text = "Add a file";
            this.AddFileButton1.UseVisualStyleBackColor = false;
            this.AddFileButton1.Click += new System.EventHandler(this.button1_Click);
            // 
            // selectstudy
            // 
            this.selectstudy.BackColor = System.Drawing.SystemColors.Info;
            this.selectstudy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.selectstudy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectstudy.FormattingEnabled = true;
            this.selectstudy.Items.AddRange(new object[] {
            "1ST-M",
            "2SE-M",
            "3TH-M",
            "4TH-M",
            "1ST-E",
            "2SE-E",
            "3TH-E",
            "4TH-E"});
            this.selectstudy.Location = new System.Drawing.Point(138, 15);
            this.selectstudy.Name = "selectstudy";
            this.selectstudy.Size = new System.Drawing.Size(121, 21);
            this.selectstudy.TabIndex = 1;
            this.selectstudy.SelectedIndexChanged += new System.EventHandler(this.selectstudy_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select Grade and Study";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(401, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Select GC Excel File";
            // 
            // Closebutton2
            // 
            this.Closebutton2.BackColor = System.Drawing.Color.Red;
            this.Closebutton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Closebutton2.ForeColor = System.Drawing.SystemColors.Control;
            this.Closebutton2.Location = new System.Drawing.Point(831, 12);
            this.Closebutton2.Name = "Closebutton2";
            this.Closebutton2.Size = new System.Drawing.Size(100, 39);
            this.Closebutton2.TabIndex = 4;
            this.Closebutton2.Text = "Close this window";
            this.Closebutton2.UseVisualStyleBackColor = false;
            this.Closebutton2.Click += new System.EventHandler(this.Closebutton2_Click);
            // 
            // AddReportButtem
            // 
            this.AddReportButtem.BackColor = System.Drawing.Color.Indigo;
            this.AddReportButtem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddReportButtem.ForeColor = System.Drawing.SystemColors.Control;
            this.AddReportButtem.Location = new System.Drawing.Point(646, 13);
            this.AddReportButtem.Name = "AddReportButtem";
            this.AddReportButtem.Size = new System.Drawing.Size(113, 24);
            this.AddReportButtem.TabIndex = 5;
            this.AddReportButtem.Text = "Add Report";
            this.AddReportButtem.UseVisualStyleBackColor = false;
            this.AddReportButtem.Click += new System.EventHandler(this.AddReportButtem_Click);
            // 
            // SelectGradeButton4
            // 
            this.SelectGradeButton4.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.SelectGradeButton4.ForeColor = System.Drawing.SystemColors.Control;
            this.SelectGradeButton4.Location = new System.Drawing.Point(265, 13);
            this.SelectGradeButton4.Name = "SelectGradeButton4";
            this.SelectGradeButton4.Size = new System.Drawing.Size(109, 24);
            this.SelectGradeButton4.TabIndex = 6;
            this.SelectGradeButton4.Text = "Select Grade";
            this.SelectGradeButton4.UseVisualStyleBackColor = false;
            this.SelectGradeButton4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(418, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(380, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "|";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(625, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "|";
            // 
            // AddReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 109);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SelectGradeButton4);
            this.Controls.Add(this.AddReportButtem);
            this.Controls.Add(this.Closebutton2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.selectstudy);
            this.Controls.Add(this.AddFileButton1);
            this.Name = "AddReport";
            this.Text = "AddReport";
            this.Load += new System.EventHandler(this.AddReport_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddFileButton1;
        private System.Windows.Forms.ComboBox selectstudy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Closebutton2;
        private System.Windows.Forms.Button AddReportButtem;
        private System.Windows.Forms.Button SelectGradeButton4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}
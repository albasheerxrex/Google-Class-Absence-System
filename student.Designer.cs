namespace Google_Class_Absence_System
{
    partial class student
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
            this.submitloan = new System.Windows.Forms.Button();
            this.useremail = new System.Windows.Forms.TextBox();
            this.usernametext = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.RTH4 = new System.Windows.Forms.RadioButton();
            this.THRD3 = new System.Windows.Forms.RadioButton();
            this.ST1 = new System.Windows.Forms.RadioButton();
            this.SEC2 = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.searchbox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // submitloan
            // 
            this.submitloan.BackColor = System.Drawing.SystemColors.HotTrack;
            this.submitloan.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.submitloan.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.submitloan.Location = new System.Drawing.Point(68, 219);
            this.submitloan.Name = "submitloan";
            this.submitloan.Size = new System.Drawing.Size(198, 48);
            this.submitloan.TabIndex = 26;
            this.submitloan.Text = "Add Student";
            this.submitloan.UseVisualStyleBackColor = false;
            this.submitloan.Click += new System.EventHandler(this.submitloan_Click);
            // 
            // useremail
            // 
            this.useremail.Location = new System.Drawing.Point(628, 58);
            this.useremail.Name = "useremail";
            this.useremail.Size = new System.Drawing.Size(189, 20);
            this.useremail.TabIndex = 21;
            // 
            // usernametext
            // 
            this.usernametext.Location = new System.Drawing.Point(628, 21);
            this.usernametext.Name = "usernametext";
            this.usernametext.Size = new System.Drawing.Size(189, 20);
            this.usernametext.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(532, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Student E-mail";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(532, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Student Grade";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(532, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Student Name";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(743, 138);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(74, 17);
            this.radioButton1.TabIndex = 27;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Day Study";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(628, 138);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(64, 17);
            this.radioButton2.TabIndex = 28;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Evening";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(534, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Student Study";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.RTH4);
            this.panel1.Controls.Add(this.submitloan);
            this.panel1.Controls.Add(this.THRD3);
            this.panel1.Controls.Add(this.ST1);
            this.panel1.Controls.Add(this.SEC2);
            this.panel1.Location = new System.Drawing.Point(522, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(311, 296);
            this.panel1.TabIndex = 30;
            // 
            // RTH4
            // 
            this.RTH4.AutoSize = true;
            this.RTH4.Location = new System.Drawing.Point(259, 99);
            this.RTH4.Name = "RTH4";
            this.RTH4.Size = new System.Drawing.Size(46, 17);
            this.RTH4.TabIndex = 34;
            this.RTH4.TabStop = true;
            this.RTH4.Text = "4TH";
            this.RTH4.UseVisualStyleBackColor = true;
            // 
            // THRD3
            // 
            this.THRD3.AutoSize = true;
            this.THRD3.Location = new System.Drawing.Point(206, 99);
            this.THRD3.Name = "THRD3";
            this.THRD3.Size = new System.Drawing.Size(47, 17);
            this.THRD3.TabIndex = 33;
            this.THRD3.TabStop = true;
            this.THRD3.Text = "3RD";
            this.THRD3.UseVisualStyleBackColor = true;
            // 
            // ST1
            // 
            this.ST1.AutoSize = true;
            this.ST1.Location = new System.Drawing.Point(102, 99);
            this.ST1.Name = "ST1";
            this.ST1.Size = new System.Drawing.Size(45, 17);
            this.ST1.TabIndex = 31;
            this.ST1.TabStop = true;
            this.ST1.Text = "1ST";
            this.ST1.UseVisualStyleBackColor = true;
            // 
            // SEC2
            // 
            this.SEC2.AutoSize = true;
            this.SEC2.Location = new System.Drawing.Point(153, 99);
            this.SEC2.Name = "SEC2";
            this.SEC2.Size = new System.Drawing.Size(52, 17);
            this.SEC2.TabIndex = 32;
            this.SEC2.TabStop = true;
            this.SEC2.Text = "2SEC";
            this.SEC2.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Window;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.searchbox);
            this.panel2.Font = new System.Drawing.Font("beIN Black ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(526, 296);
            this.panel2.TabIndex = 31;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Green;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(260, 152);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 47);
            this.button1.TabIndex = 35;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Highlight;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button3.Location = new System.Drawing.Point(64, 58);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(93, 38);
            this.button3.TabIndex = 4;
            this.button3.Text = "Search";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // searchbox
            // 
            this.searchbox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.searchbox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.searchbox.Location = new System.Drawing.Point(201, 58);
            this.searchbox.Name = "searchbox";
            this.searchbox.Size = new System.Drawing.Size(301, 38);
            this.searchbox.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 294);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(833, 281);
            this.dataGridView1.TabIndex = 32;
            // 
            // student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 580);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.useremail);
            this.Controls.Add(this.usernametext);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "student";
            this.Text = "student";
            this.Load += new System.EventHandler(this.student_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button submitloan;
        private System.Windows.Forms.TextBox useremail;
        private System.Windows.Forms.TextBox usernametext;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton RTH4;
        private System.Windows.Forms.RadioButton THRD3;
        private System.Windows.Forms.RadioButton ST1;
        private System.Windows.Forms.RadioButton SEC2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox searchbox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
    }
}
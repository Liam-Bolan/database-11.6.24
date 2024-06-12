namespace database__11._6._24
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtStudentID = new TextBox();
            txtFirstName = new TextBox();
            txtSecondName = new TextBox();
            txtDoB = new TextBox();
            button1 = new Button();
            button2 = new Button();
            listBox0 = new ListBox();
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            listBox3 = new ListBox();
            label7 = new Label();
            label8 = new Label();
            txtAvg = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(108, 57);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 0;
            label1.Text = "Student ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(108, 94);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 1;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(108, 134);
            label3.Name = "label3";
            label3.Size = new Size(29, 15);
            label3.TabIndex = 2;
            label3.Text = "DoB";
            // 
            // txtStudentID
            // 
            txtStudentID.Location = new Point(173, 54);
            txtStudentID.Name = "txtStudentID";
            txtStudentID.Size = new Size(173, 23);
            txtStudentID.TabIndex = 3;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(173, 91);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(173, 23);
            txtFirstName.TabIndex = 4;
            // 
            // txtSecondName
            // 
            txtSecondName.Location = new Point(361, 91);
            txtSecondName.Name = "txtSecondName";
            txtSecondName.Size = new Size(173, 23);
            txtSecondName.TabIndex = 5;
            // 
            // txtDoB
            // 
            txtDoB.Location = new Point(173, 126);
            txtDoB.Name = "txtDoB";
            txtDoB.Size = new Size(173, 23);
            txtDoB.TabIndex = 6;
            // 
            // button1
            // 
            button1.Location = new Point(593, 89);
            button1.Name = "button1";
            button1.Size = new Size(60, 25);
            button1.TabIndex = 7;
            button1.Text = "<";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(680, 89);
            button2.Name = "button2";
            button2.Size = new Size(60, 25);
            button2.TabIndex = 8;
            button2.Text = ">";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // listBox0
            // 
            listBox0.FormattingEnabled = true;
            listBox0.ItemHeight = 15;
            listBox0.Location = new Point(108, 197);
            listBox0.Name = "listBox0";
            listBox0.Size = new Size(137, 214);
            listBox0.TabIndex = 9;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(263, 197);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(137, 214);
            listBox1.TabIndex = 10;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(416, 197);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(137, 214);
            listBox2.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(467, 170);
            label4.Name = "label4";
            label4.Size = new Size(31, 15);
            label4.TabIndex = 12;
            label4.Text = "Date";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(310, 170);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 13;
            label5.Text = "Score";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(152, 170);
            label6.Name = "label6";
            label6.Size = new Size(38, 15);
            label6.TabIndex = 14;
            label6.Text = "TestID";
            // 
            // listBox3
            // 
            listBox3.FormattingEnabled = true;
            listBox3.ItemHeight = 15;
            listBox3.Location = new Point(574, 197);
            listBox3.Name = "listBox3";
            listBox3.Size = new Size(137, 214);
            listBox3.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(622, 170);
            label7.Name = "label7";
            label7.Size = new Size(30, 15);
            label7.TabIndex = 16;
            label7.Text = "Max";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(248, 426);
            label8.Name = "label8";
            label8.Size = new Size(38, 15);
            label8.TabIndex = 17;
            label8.Text = "Avg%";
            // 
            // txtAvg
            // 
            txtAvg.Location = new Point(288, 423);
            txtAvg.Name = "txtAvg";
            txtAvg.Size = new Size(112, 23);
            txtAvg.TabIndex = 18;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtAvg);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(listBox3);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Controls.Add(listBox0);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtDoB);
            Controls.Add(txtSecondName);
            Controls.Add(txtFirstName);
            Controls.Add(txtStudentID);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtStudentID;
        private TextBox txtFirstName;
        private TextBox txtSecondName;
        private TextBox txtDoB;
        private Button button1;
        private Button button2;
        private ListBox listBox0;
        private ListBox listBox1;
        private ListBox listBox2;
        private Label label4;
        private Label label5;
        private Label label6;
        private ListBox listBox3;
        private Label label7;
        private Label label8;
        private TextBox txtAvg;
    }
}

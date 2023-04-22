namespace DoctorBooking_App_ointment
{
    partial class Form4
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            textBox9 = new TextBox();
            textBox10 = new TextBox();
            textBox11 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            label3 = new Label();
            linkLabel1 = new LinkLabel();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(113, 165);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "AMA";
            textBox1.Size = new Size(277, 39);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(113, 239);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.PlaceholderText = "Password";
            textBox2.Size = new Size(277, 39);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(580, 165);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "AMA";
            textBox3.Size = new Size(200, 39);
            textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(580, 239);
            textBox4.Name = "textBox4";
            textBox4.PasswordChar = '*';
            textBox4.PlaceholderText = "Password";
            textBox4.Size = new Size(200, 39);
            textBox4.TabIndex = 3;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(580, 315);
            textBox5.Name = "textBox5";
            textBox5.PlaceholderText = "Name";
            textBox5.Size = new Size(200, 39);
            textBox5.TabIndex = 4;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(580, 382);
            textBox6.Name = "textBox6";
            textBox6.PlaceholderText = "Specialty";
            textBox6.Size = new Size(200, 39);
            textBox6.TabIndex = 5;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(580, 450);
            textBox7.Name = "textBox7";
            textBox7.PlaceholderText = "Tel";
            textBox7.Size = new Size(200, 39);
            textBox7.TabIndex = 6;
            textBox7.TextChanged += textBox7_TextChanged;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(919, 165);
            textBox8.Name = "textBox8";
            textBox8.PlaceholderText = "Email";
            textBox8.Size = new Size(282, 39);
            textBox8.TabIndex = 7;
            // 
            // textBox9
            // 
            textBox9.Location = new Point(919, 239);
            textBox9.Name = "textBox9";
            textBox9.PlaceholderText = "Address";
            textBox9.Size = new Size(282, 39);
            textBox9.TabIndex = 8;
            // 
            // textBox10
            // 
            textBox10.Location = new Point(919, 315);
            textBox10.Name = "textBox10";
            textBox10.PlaceholderText = "Zip";
            textBox10.Size = new Size(200, 39);
            textBox10.TabIndex = 9;
            // 
            // textBox11
            // 
            textBox11.Location = new Point(919, 382);
            textBox11.Name = "textBox11";
            textBox11.PlaceholderText = "Region";
            textBox11.Size = new Size(200, 39);
            textBox11.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(197, 70);
            label1.Name = "label1";
            label1.Size = new Size(88, 32);
            label1.TabIndex = 11;
            label1.Text = "Sign In";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(817, 70);
            label2.Name = "label2";
            label2.Size = new Size(98, 32);
            label2.TabIndex = 12;
            label2.Text = "Sign Up";
            // 
            // button1
            // 
            button1.Location = new Point(164, 332);
            button1.Name = "button1";
            button1.Size = new Size(150, 46);
            button1.TabIndex = 13;
            button1.Text = "Sign In";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(794, 522);
            button2.Name = "button2";
            button2.Size = new Size(150, 46);
            button2.TabIndex = 14;
            button2.Text = "Sign Up";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.BorderStyle = BorderStyle.Fixed3D;
            label3.Location = new Point(482, -24);
            label3.Name = "label3";
            label3.Size = new Size(10, 657);
            label3.TabIndex = 15;
            label3.Click += label3_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(12, 588);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(100, 32);
            linkLabel1.TabIndex = 16;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Go Back";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1254, 629);
            Controls.Add(linkLabel1);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox11);
            Controls.Add(textBox10);
            Controls.Add(textBox9);
            Controls.Add(textBox8);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form4";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form4";
            Load += Form4_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private TextBox textBox8;
        private TextBox textBox9;
        private TextBox textBox10;
        private TextBox textBox11;
        private Label label1;
        private Label label2;
        private Button button1;
        private Button button2;
        private Label label3;
        private LinkLabel linkLabel1;
    }
}
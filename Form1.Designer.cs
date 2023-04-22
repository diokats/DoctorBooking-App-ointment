namespace DoctorBooking_App_ointment
{
    partial class ConnectUser
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConnectUser));
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            button1 = new Button();
            label2 = new Label();
            button3 = new Button();
            linkLabel1 = new LinkLabel();
            toolTip1 = new ToolTip(components);
            toolTip2 = new ToolTip(components);
            linkLabel2 = new LinkLabel();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(502, 530);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(806, 182);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "AMKA";
            textBox1.Size = new Size(289, 39);
            textBox1.TabIndex = 2;
            toolTip1.SetToolTip(textBox1, "Enter Your AMKA here");
            // 
            // textBox2
            // 
            textBox2.Location = new Point(806, 243);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.PlaceholderText = "Password";
            textBox2.Size = new Size(289, 39);
            textBox2.TabIndex = 3;
            toolTip1.SetToolTip(textBox2, "Enter Your Password Here");
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(844, 512);
            label1.Name = "label1";
            label1.Size = new Size(266, 32);
            label1.TabIndex = 6;
            label1.Text = "Don't have an account?";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(866, 312);
            button1.Name = "button1";
            button1.Size = new Size(150, 46);
            button1.TabIndex = 7;
            button1.Text = "Sign In";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(930, 566);
            label2.Name = "label2";
            label2.Size = new Size(36, 32);
            label2.TabIndex = 8;
            label2.Text = "or";
            // 
            // button3
            // 
            button3.Location = new Point(736, 559);
            button3.Name = "button3";
            button3.Size = new Size(150, 46);
            button3.TabIndex = 10;
            button3.Text = "Sign Up";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(1001, 566);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(209, 32);
            linkLabel1.TabIndex = 11;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Continue as Guest";
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Location = new Point(12, 573);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(206, 32);
            linkLabel2.TabIndex = 12;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Are you a Doctor?";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(903, 91);
            label3.Name = "label3";
            label3.Size = new Size(88, 32);
            label3.TabIndex = 13;
            label3.Text = "Sign In";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(328, -27);
            label4.Name = "label4";
            label4.Size = new Size(78, 32);
            label4.TabIndex = 14;
            label4.Text = "label4";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Black", 13.875F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(587, 12);
            label5.Name = "label5";
            label5.Size = new Size(629, 50);
            label5.TabIndex = 15;
            label5.Text = "Welcome To The Doctor AnyStyle";
            // 
            // ConnectUser
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1254, 629);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(linkLabel2);
            Controls.Add(linkLabel1);
            Controls.Add(button3);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ConnectUser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ConnectUser";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Button button1;
        private Label label2;
        private Button button3;
        private LinkLabel linkLabel1;
        private ToolTip toolTip1;
        private ToolTip toolTip2;
        private LinkLabel linkLabel2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}
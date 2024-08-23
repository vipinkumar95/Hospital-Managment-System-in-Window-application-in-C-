namespace PranjulMedicalCenter
{
    partial class Admin_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_Login));
            panel1 = new Panel();
            label1 = new Label();
            usernameTextBox = new TextBox();
            passwordTextBox = new TextBox();
            btnlogin = new Button();
            linkLabelCreateUser = new LinkLabel();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.ForeColor = Color.FromArgb(0, 115, 130);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(400, 90);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(23, 53, 107);
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Corbel", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(30, 25);
            label1.Name = "label1";
            label1.Size = new Size(327, 41);
            label1.TabIndex = 1;
            label1.Text = "Pranjul Medical Center";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // usernameTextBox
            // 
            usernameTextBox.Location = new Point(23, 229);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(334, 37);
            usernameTextBox.TabIndex = 1;
            usernameTextBox.Text = "USERNAME";
            usernameTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(23, 297);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(334, 37);
            passwordTextBox.TabIndex = 2;
            passwordTextBox.Text = "PASSWORD";
            passwordTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // btnlogin
            // 
            btnlogin.BackColor = Color.FromArgb(23, 53, 107);
            btnlogin.ForeColor = Color.White;
            btnlogin.Location = new Point(83, 370);
            btnlogin.Name = "btnlogin";
            btnlogin.Size = new Size(203, 48);
            btnlogin.TabIndex = 3;
            btnlogin.Text = "LOGIN";
            btnlogin.UseVisualStyleBackColor = false;
            btnlogin.Click += btnlogin_Click;
            // 
            // linkLabelCreateUser
            // 
            linkLabelCreateUser.AutoSize = true;
            linkLabelCreateUser.Location = new Point(83, 439);
            linkLabelCreateUser.Name = "linkLabelCreateUser";
            linkLabelCreateUser.Size = new Size(221, 29);
            linkLabelCreateUser.TabIndex = 4;
            linkLabelCreateUser.TabStop = true;
            linkLabelCreateUser.Text = "CREATE NEW USER";
            linkLabelCreateUser.LinkClicked += linkLabelCreateUser_LinkClicked;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(104, 96);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 117);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // Admin_Login
            // 
            AutoScaleDimensions = new SizeF(13F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MintCream;
            ClientSize = new Size(400, 500);
            Controls.Add(pictureBox1);
            Controls.Add(linkLabelCreateUser);
            Controls.Add(btnlogin);
            Controls.Add(passwordTextBox);
            Controls.Add(usernameTextBox);
            Controls.Add(panel1);
            Font = new Font("Corbel", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ForeColor = Color.AliceBlue;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Admin_Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin_Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox usernameTextBox;
        private TextBox passwordTextBox;
        private Button btnlogin;
        private LinkLabel linkLabelCreateUser;
        private PictureBox pictureBox1;
    }
}
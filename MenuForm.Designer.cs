namespace PranjulMedicalCenter
{
    partial class MenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
            panel1 = new Panel();
            closebtn = new PictureBox();
            label1 = new Label();
            textBox2 = new TextBox();
            pictureBoxDoctors = new PictureBox();
            pictureBoxPatient = new PictureBox();
            pictureBoxDiagnosis = new PictureBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            pictureBoxLogout = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)closebtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxDoctors).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPatient).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxDiagnosis).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogout).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(closebtn);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1016, 150);
            panel1.TabIndex = 0;
            // 
            // closebtn
            // 
            closebtn.BorderStyle = BorderStyle.Fixed3D;
            closebtn.Image = (Image)resources.GetObject("closebtn.Image");
            closebtn.Location = new Point(971, 3);
            closebtn.Name = "closebtn";
            closebtn.Size = new Size(39, 42);
            closebtn.SizeMode = PictureBoxSizeMode.StretchImage;
            closebtn.TabIndex = 9;
            closebtn.TabStop = false;
            closebtn.Click += closebtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(23, 53, 107);
            label1.Font = new Font("Corbel", 48F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(20, 18);
            label1.Name = "label1";
            label1.Size = new Size(979, 117);
            label1.TabIndex = 9;
            label1.Text = "Pranjul Medical Center";
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(23, 53, 107);
            textBox2.Font = new Font("Corbel", 20F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            textBox2.ForeColor = Color.White;
            textBox2.Location = new Point(283, 156);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(417, 62);
            textBox2.TabIndex = 1;
            textBox2.Text = "CHOOSE ANY OPTION";
            // 
            // pictureBoxDoctors
            // 
            pictureBoxDoctors.Image = (Image)resources.GetObject("pictureBoxDoctors.Image");
            pictureBoxDoctors.Location = new Point(58, 316);
            pictureBoxDoctors.Name = "pictureBoxDoctors";
            pictureBoxDoctors.Size = new Size(247, 190);
            pictureBoxDoctors.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxDoctors.TabIndex = 2;
            pictureBoxDoctors.TabStop = false;
            pictureBoxDoctors.Click += pictureBoxDoctors_Click;
            // 
            // pictureBoxPatient
            // 
            pictureBoxPatient.Image = (Image)resources.GetObject("pictureBoxPatient.Image");
            pictureBoxPatient.Location = new Point(405, 316);
            pictureBoxPatient.Name = "pictureBoxPatient";
            pictureBoxPatient.Size = new Size(247, 190);
            pictureBoxPatient.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxPatient.TabIndex = 3;
            pictureBoxPatient.TabStop = false;
            pictureBoxPatient.Click += pictureBoxPatient_Click;
            // 
            // pictureBoxDiagnosis
            // 
            pictureBoxDiagnosis.Image = (Image)resources.GetObject("pictureBoxDiagnosis.Image");
            pictureBoxDiagnosis.Location = new Point(723, 316);
            pictureBoxDiagnosis.Name = "pictureBoxDiagnosis";
            pictureBoxDiagnosis.Size = new Size(247, 190);
            pictureBoxDiagnosis.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxDiagnosis.TabIndex = 4;
            pictureBoxDiagnosis.TabStop = false;
            pictureBoxDiagnosis.Click += pictureBoxDiagnosis_Click;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.FromArgb(23, 53, 107);
            textBox3.Font = new Font("Corbel", 20F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            textBox3.ForeColor = Color.White;
            textBox3.Location = new Point(73, 254);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(221, 47);
            textBox3.TabIndex = 5;
            textBox3.Text = "  DOCTOR";
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.FromArgb(23, 53, 107);
            textBox4.Font = new Font("Corbel", 20F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            textBox4.ForeColor = Color.White;
            textBox4.Location = new Point(419, 254);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(221, 47);
            textBox4.TabIndex = 6;
            textBox4.Text = "   PATIENT";
            // 
            // textBox5
            // 
            textBox5.BackColor = Color.FromArgb(23, 53, 107);
            textBox5.Font = new Font("Corbel", 20F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            textBox5.ForeColor = Color.White;
            textBox5.Location = new Point(735, 254);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(235, 56);
            textBox5.TabIndex = 7;
            textBox5.Text = "DIAGNOSIS";
            // 
            // pictureBoxLogout
            // 
            pictureBoxLogout.Image = (Image)resources.GetObject("pictureBoxLogout.Image");
            pictureBoxLogout.Location = new Point(909, 576);
            pictureBoxLogout.Name = "pictureBoxLogout";
            pictureBoxLogout.Size = new Size(71, 63);
            pictureBoxLogout.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxLogout.TabIndex = 8;
            pictureBoxLogout.TabStop = false;
            pictureBoxLogout.Click += pictureBoxLogout_Click;
            // 
            // MenuForm
            // 
            AutoScaleDimensions = new SizeF(13F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1016, 651);
            Controls.Add(pictureBoxLogout);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(pictureBoxDiagnosis);
            Controls.Add(pictureBoxPatient);
            Controls.Add(pictureBoxDoctors);
            Controls.Add(textBox2);
            Controls.Add(panel1);
            Font = new Font("Corbel", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ForeColor = Color.MistyRose;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "MenuForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MenuForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)closebtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxDoctors).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPatient).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxDiagnosis).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogout).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private TextBox textBox2;
        private PictureBox pictureBoxDoctors;
        private PictureBox pictureBoxPatient;
        private PictureBox pictureBoxDiagnosis;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private PictureBox pictureBoxLogout;
        private Label label1;
        private PictureBox closebtn;
    }
}
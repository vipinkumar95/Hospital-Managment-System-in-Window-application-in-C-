namespace PranjulMedicalCenter
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            progressBar1 = new ProgressBar();
            label4 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            btnClose = new PictureBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)btnClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Corbel", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(51, 52);
            label1.Name = "label1";
            label1.Size = new Size(325, 39);
            label1.TabIndex = 0;
            label1.Text = "Pranjul Medical Center";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(60, 370);
            label2.Name = "label2";
            label2.Size = new Size(290, 29);
            label2.TabIndex = 1;
            label2.Text = "Develop by Er. Vipin Kumar";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 410);
            label3.Name = "label3";
            label3.Size = new Size(358, 29);
            label3.TabIndex = 2;
            label3.Text = "Loading Application...Please Wait";
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(30, 441);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(358, 23);
            progressBar1.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(165, 467);
            label4.Name = "label4";
            label4.Size = new Size(75, 29);
            label4.TabIndex = 6;
            label4.Text = "label4";
            label4.Click += label4_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // btnClose
            // 
            btnClose.Image = (Image)resources.GetObject("btnClose.Image");
            btnClose.Location = new Point(348, 9);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(40, 40);
            btnClose.SizeMode = PictureBoxSizeMode.Zoom;
            btnClose.TabIndex = 7;
            btnClose.TabStop = false;
            btnClose.Click += btnClose_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(71, 97);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(265, 270);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(400, 500);
            Controls.Add(pictureBox1);
            Controls.Add(btnClose);
            Controls.Add(label4);
            Controls.Add(progressBar1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Corbel", 12F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PranjulMedicalCenter";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)btnClose).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private ProgressBar progressBar1;
        private Label label4;
        private System.Windows.Forms.Timer timer1;
        private PictureBox btnClose;
        private PictureBox pictureBox1;
    }
}

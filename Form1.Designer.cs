namespace ProjectPBOSewaAlatCamping
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
            pictureBox1 = new PictureBox();
            textBox1Loguser = new TextBox();
            textBox2Passuser = new TextBox();
            textBox3Reg = new TextBox();
            textBox4Pass = new TextBox();
            button1 = new Button();
            button2 = new Button();
            textBox1Emailreg = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.login__3_;
            pictureBox1.Location = new Point(31, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1498, 784);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // textBox1Loguser
            // 
            textBox1Loguser.Location = new Point(283, 354);
            textBox1Loguser.Name = "textBox1Loguser";
            textBox1Loguser.Size = new Size(494, 27);
            textBox1Loguser.TabIndex = 1;
            // 
            // textBox2Passuser
            // 
            textBox2Passuser.Location = new Point(283, 425);
            textBox2Passuser.Name = "textBox2Passuser";
            textBox2Passuser.Size = new Size(494, 27);
            textBox2Passuser.TabIndex = 2;
            // 
            // textBox3Reg
            // 
            textBox3Reg.Location = new Point(869, 354);
            textBox3Reg.Name = "textBox3Reg";
            textBox3Reg.Size = new Size(493, 27);
            textBox3Reg.TabIndex = 3;
            // 
            // textBox4Pass
            // 
            textBox4Pass.Location = new Point(869, 425);
            textBox4Pass.Name = "textBox4Pass";
            textBox4Pass.Size = new Size(493, 27);
            textBox4Pass.TabIndex = 4;
            // 
            // button1
            // 
            button1.Image = Properties.Resources.Screenshot_2025_05_17_183120;
            button1.Location = new Point(283, 474);
            button1.Name = "button1";
            button1.Size = new Size(74, 29);
            button1.TabIndex = 5;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Image = Properties.Resources.Screenshot_2025_05_18_002701;
            button2.Location = new Point(869, 513);
            button2.Name = "button2";
            button2.Size = new Size(133, 29);
            button2.TabIndex = 6;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox1Emailreg
            // 
            textBox1Emailreg.Location = new Point(869, 354);
            textBox1Emailreg.Name = "textBox1Emailreg";
            textBox1Emailreg.Size = new Size(292, 27);
            textBox1Emailreg.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1541, 808);
            Controls.Add(textBox1Emailreg);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox4Pass);
            Controls.Add(textBox3Reg);
            Controls.Add(textBox2Passuser);
            Controls.Add(textBox1Loguser);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox textBox1Loguser;
        private TextBox textBox2Passuser;
        private TextBox textBox3Reg;
        private TextBox textBox4Pass;
        private Button button1;
        private Button button2;
        private TextBox textBox1Emailreg;
    }
}

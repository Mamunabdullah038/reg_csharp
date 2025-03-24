namespace MyFirstAssignment
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
            button1 = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            textBox2 = new TextBox();
            label4 = new Label();
            textBox3 = new TextBox();
            label5 = new Label();
            textBox4 = new TextBox();
            label6 = new Label();
            textBox5 = new TextBox();
            label7 = new Label();
            button2 = new Button();
            button3 = new Button();
            label8 = new Label();
            pictureBox1 = new PictureBox();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 359);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Reset";
            button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(101, 15);
            label1.TabIndex = 1;
            label1.Text = "Registration Form";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Location = new Point(101, 32);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(266, 23);
            textBox1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 35);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 3;
            label2.Text = "Name : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 69);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 4;
            label3.Text = "Roll :";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(101, 66);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 105);
            label4.Name = "label4";
            label4.Size = new Size(47, 15);
            label4.TabIndex = 6;
            label4.Text = "Reg ID :";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(101, 105);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 143);
            label5.Name = "label5";
            label5.Size = new Size(61, 15);
            label5.TabIndex = 8;
            label5.Text = "Semester :";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(101, 143);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 179);
            label6.Name = "label6";
            label6.Size = new Size(83, 15);
            label6.TabIndex = 10;
            label6.Text = " Blood Group :";
            label6.Click += label6_Click;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(101, 179);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 214);
            label7.Name = "label7";
            label7.Size = new Size(51, 15);
            label7.TabIndex = 12;
            label7.Text = "Gender :";
            // 
            // button2
            // 
            button2.Location = new Point(101, 210);
            button2.Name = "button2";
            button2.Size = new Size(44, 23);
            button2.TabIndex = 13;
            button2.Text = "Male";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(101, 239);
            button3.Name = "button3";
            button3.Size = new Size(57, 23);
            button3.TabIndex = 14;
            button3.Text = "Female";
            button3.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 300);
            label8.Name = "label8";
            label8.Size = new Size(86, 15);
            label8.TabIndex = 15;
            label8.Text = "Uplode Photo :";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(104, 277);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 68);
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // button4
            // 
            button4.Location = new Point(12, 390);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 17;
            button4.Text = "Submit";
            button4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(645, 425);
            Controls.Add(button4);
            Controls.Add(pictureBox1);
            Controls.Add(label8);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label7);
            Controls.Add(textBox5);
            Controls.Add(label6);
            Controls.Add(textBox4);
            Controls.Add(label5);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private Label label3;
        private TextBox textBox2;
        private Label label4;
        private TextBox textBox3;
        private Label label5;
        private TextBox textBox4;
        private Label label6;
        private TextBox textBox5;
        private Label label7;
        private Button button2;
        private Button button3;
        private Label label8;
        private PictureBox pictureBox1;
        private Button button4;
    }
}

namespace kursovaya
{
    partial class Form2
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
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(379, 243);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(300, 55);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(379, 393);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(300, 55);
            textBox2.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(379, 528);
            button1.Name = "button1";
            button1.Size = new Size(300, 69);
            button1.TabIndex = 2;
            button1.Text = "check";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(356, 111);
            label1.Name = "label1";
            label1.Size = new Size(353, 48);
            label1.TabIndex = 3;
            label1.Text = "checking registration";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(188, 250);
            label2.Name = "label2";
            label2.Size = new Size(100, 48);
            label2.TabIndex = 4;
            label2.Text = "login";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(188, 393);
            label3.Name = "label3";
            label3.Size = new Size(170, 48);
            label3.TabIndex = 5;
            label3.Text = "password";
            // 
            // button2
            // 
            button2.Location = new Point(801, 224);
            button2.Name = "button2";
            button2.Size = new Size(181, 259);
            button2.TabIndex = 6;
            button2.Text = "add self";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1504, 1075);
            Controls.Add(button2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button2;
    }
}
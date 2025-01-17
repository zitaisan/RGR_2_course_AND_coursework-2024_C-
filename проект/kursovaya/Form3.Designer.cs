namespace kursovaya
{
    partial class Form3
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
            label1 = new Label();
            button1 = new Button();
            richTextBox1 = new RichTextBox();
            label2 = new Label();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(74, 50);
            label1.Name = "label1";
            label1.Size = new Size(76, 48);
            label1.TabIndex = 0;
            label1.Text = "day";
            // 
            // button1
            // 
            button1.Location = new Point(74, 946);
            button1.Name = "button1";
            button1.Size = new Size(498, 69);
            button1.TabIndex = 2;
            button1.Text = "change";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(74, 136);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(818, 787);
            richTextBox1.TabIndex = 3;
            richTextBox1.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(224, 50);
            label2.Name = "label2";
            label2.Size = new Size(115, 48);
            label2.TabIndex = 4;
            label2.Text = "label2";
            // 
            // button2
            // 
            button2.Location = new Point(914, 136);
            button2.Name = "button2";
            button2.Size = new Size(139, 351);
            button2.TabIndex = 5;
            button2.Text = "back";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(898, 809);
            button3.Name = "button3";
            button3.Size = new Size(155, 114);
            button3.TabIndex = 6;
            button3.Text = "update";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(622, 40);
            button4.Name = "button4";
            button4.Size = new Size(431, 69);
            button4.TabIndex = 7;
            button4.Text = "authorization";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1228, 1027);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(richTextBox1);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private RichTextBox richTextBox1;
        private Label label2;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}
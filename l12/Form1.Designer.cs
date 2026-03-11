namespace l12
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            numericUpDown1 = new NumericUpDown();
            button1 = new Button();
            label4 = new Label();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 0;
            label1.Text = "Название";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 27);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(183, 23);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 85);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(183, 23);
            textBox2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 67);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 2;
            label2.Text = "Автор";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 135);
            label3.Name = "label3";
            label3.Size = new Size(73, 15);
            label3.TabIndex = 4;
            label3.Text = "Год издания";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(12, 153);
            numericUpDown1.Maximum = new decimal(new int[] { 2100, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(183, 23);
            numericUpDown1.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(12, 202);
            button1.Name = "button1";
            button1.Size = new Size(183, 23);
            button1.TabIndex = 6;
            button1.Text = "Добавить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 267);
            label4.Name = "label4";
            label4.Size = new Size(16, 15);
            label4.TabIndex = 7;
            label4.Text = "...";
            // 
            // button2
            // 
            button2.Location = new Point(12, 230);
            button2.Name = "button2";
            button2.Size = new Size(183, 23);
            button2.TabIndex = 8;
            button2.Text = "Без данных";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(281, 301);
            Controls.Add(button2);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(numericUpDown1);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private Label label3;
        private NumericUpDown numericUpDown1;
        private Button button1;
        private Label label4;
        private Button button2;
    }
}

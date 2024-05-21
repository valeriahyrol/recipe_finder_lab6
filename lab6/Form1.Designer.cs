namespace lab6
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
            button1 = new Button();
            label2 = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Engravers MT", 15F, FontStyle.Bold);
            label1.Location = new Point(12, 32);
            label1.Name = "label1";
            label1.Size = new Size(533, 24);
            label1.TabIndex = 0;
            label1.Text = "Вітаю! Для того щоб знайти рецепт натисніть кнопку \"Знайти\"";
            // 
            // button1
            // 
            button1.Font = new Font("Engravers MT", 15F);
            button1.Location = new Point(619, 59);
            button1.Name = "button1";
            button1.Size = new Size(87, 33);
            button1.TabIndex = 1;
            button1.Text = "Знайти";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Engravers MT", 15F, FontStyle.Bold);
            label2.Location = new Point(12, 195);
            label2.Name = "label2";
            label2.Size = new Size(658, 24);
            label2.TabIndex = 2;
            label2.Text = "Для того щоб вивести весь перелік рецептів натисніть кнопку \"Показати все\"";
            // 
            // button2
            // 
            button2.Font = new Font("Engravers MT", 15F);
            button2.Location = new Point(619, 253);
            button2.Name = "button2";
            button2.Size = new Size(132, 34);
            button2.TabIndex = 3;
            button2.Text = "Показати все";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.NavajoWhite;
            ClientSize = new Size(884, 461);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Початкова сторінка";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Label label2;
        private Button button2;
    }
}

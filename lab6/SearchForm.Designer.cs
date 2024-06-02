namespace lab6
{
    partial class SearchForm
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
            SearchTextBox = new TextBox();
            SearchButton = new Button();
            ResultsDataGridView = new DataGridView();
            SearchByNameRadioButton = new RadioButton();
            SearchByIngredientsRadioButton = new RadioButton();
            SearchByIdRadioButton = new RadioButton();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)ResultsDataGridView).BeginInit();
            SuspendLayout();
            // 
            // SearchTextBox
            // 
            SearchTextBox.Location = new Point(670, 63);
            SearchTextBox.Name = "SearchTextBox";
            SearchTextBox.Size = new Size(153, 23);
            SearchTextBox.TabIndex = 0;
            // 
            // SearchButton
            // 
            SearchButton.Font = new Font("Segoe UI", 15F);
            SearchButton.Location = new Point(691, 274);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(132, 39);
            SearchButton.TabIndex = 1;
            SearchButton.Text = "Шукати";
            SearchButton.UseVisualStyleBackColor = true;
            // 
            // ResultsDataGridView
            // 
            ResultsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ResultsDataGridView.Location = new Point(2, 12);
            ResultsDataGridView.Name = "ResultsDataGridView";
            ResultsDataGridView.Size = new Size(485, 301);
            ResultsDataGridView.TabIndex = 2;
            // 
            // SearchByNameRadioButton
            // 
            SearchByNameRadioButton.AutoSize = true;
            SearchByNameRadioButton.Font = new Font("Segoe UI", 12F);
            SearchByNameRadioButton.Location = new Point(503, 158);
            SearchByNameRadioButton.Name = "SearchByNameRadioButton";
            SearchByNameRadioButton.Size = new Size(206, 25);
            SearchByNameRadioButton.TabIndex = 3;
            SearchByNameRadioButton.TabStop = true;
            SearchByNameRadioButton.Text = "Пошук за назвою страви";
            SearchByNameRadioButton.UseVisualStyleBackColor = true;
            // 
            // SearchByIngredientsRadioButton
            // 
            SearchByIngredientsRadioButton.AutoSize = true;
            SearchByIngredientsRadioButton.Font = new Font("Segoe UI", 12F);
            SearchByIngredientsRadioButton.Location = new Point(503, 189);
            SearchByIngredientsRadioButton.Name = "SearchByIngredientsRadioButton";
            SearchByIngredientsRadioButton.Size = new Size(188, 25);
            SearchByIngredientsRadioButton.TabIndex = 4;
            SearchByIngredientsRadioButton.TabStop = true;
            SearchByIngredientsRadioButton.Text = "Пошук за інгрідієнтом";
            SearchByIngredientsRadioButton.UseVisualStyleBackColor = true;
            // 
            // SearchByIdRadioButton
            // 
            SearchByIdRadioButton.AutoSize = true;
            SearchByIdRadioButton.Font = new Font("Segoe UI", 12F);
            SearchByIdRadioButton.Location = new Point(503, 220);
            SearchByIdRadioButton.Name = "SearchByIdRadioButton";
            SearchByIdRadioButton.Size = new Size(229, 25);
            SearchByIdRadioButton.TabIndex = 5;
            SearchByIdRadioButton.TabStop = true;
            SearchByIdRadioButton.Text = "Пошук за номером рецепту";
            SearchByIdRadioButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(493, 25);
            label1.Name = "label1";
            label1.Size = new Size(350, 21);
            label1.TabIndex = 6;
            label1.Text = "Введіть в поле назву, номер або інгрідієнт ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(493, 65);
            label2.Name = "label2";
            label2.Size = new Size(157, 21);
            label2.TabIndex = 7;
            label2.Text = "яку хочете знайти:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.Location = new Point(493, 124);
            label3.Name = "label3";
            label3.Size = new Size(215, 21);
            label3.TabIndex = 8;
            label3.Text = "Оберіть критерій пошуку:";
            // 
            // SearchForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.NavajoWhite;
            ClientSize = new Size(860, 475);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(SearchByIdRadioButton);
            Controls.Add(SearchByIngredientsRadioButton);
            Controls.Add(SearchByNameRadioButton);
            Controls.Add(ResultsDataGridView);
            Controls.Add(SearchButton);
            Controls.Add(SearchTextBox);
            Name = "SearchForm";
            Text = "SearchForm";
            ((System.ComponentModel.ISupportInitialize)ResultsDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox SearchTextBox;
        private Button SearchButton;
        private DataGridView ResultsDataGridView;
        private RadioButton SearchByNameRadioButton;
        private RadioButton SearchByIngredientsRadioButton;
        private RadioButton SearchByIdRadioButton;
        private Label label1;
        private Label label2;
        private Label label3;
    }

}
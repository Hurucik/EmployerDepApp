namespace EmployerDepApp
{
    partial class МенюРедактированияРабочего
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
            checkId_label = new Label();
            checkId_textBox = new TextBox();
            checkId_button = new Button();
            lastName_label = new Label();
            firstName_label = new Label();
            Patronymic_label = new Label();
            Position_label = new Label();
            WorkExperience_label = new Label();
            Salary_label = new Label();
            BirthDate_label = new Label();
            lastName_textBox = new TextBox();
            firstName_textBox = new TextBox();
            Patronymic_textBox = new TextBox();
            Position_textBox = new TextBox();
            WorkExperience_textBox = new TextBox();
            Salary_textBox = new TextBox();
            BirthDate_textBox = new TextBox();
            Apply_button = new Button();
            SuspendLayout();
            // 
            // checkId_label
            // 
            checkId_label.AutoSize = true;
            checkId_label.Location = new Point(356, 428);
            checkId_label.Margin = new Padding(4, 0, 4, 0);
            checkId_label.Name = "checkId_label";
            checkId_label.Size = new Size(125, 15);
            checkId_label.TabIndex = 0;
            checkId_label.Text = "Введите ID работника";
            // 
            // checkId_textBox
            // 
            checkId_textBox.Location = new Point(208, 425);
            checkId_textBox.Margin = new Padding(4, 3, 4, 3);
            checkId_textBox.Name = "checkId_textBox";
            checkId_textBox.Size = new Size(140, 23);
            checkId_textBox.TabIndex = 1;
            // 
            // checkId_button
            // 
            checkId_button.Location = new Point(59, 422);
            checkId_button.Margin = new Padding(4, 3, 4, 3);
            checkId_button.Name = "checkId_button";
            checkId_button.Size = new Size(141, 27);
            checkId_button.TabIndex = 2;
            checkId_button.Text = "Найти";
            checkId_button.UseVisualStyleBackColor = true;
            checkId_button.Click += КнопкаНайтиПоID;
            // 
            // lastName_label
            // 
            lastName_label.AutoSize = true;
            lastName_label.Location = new Point(14, 10);
            lastName_label.Margin = new Padding(4, 0, 4, 0);
            lastName_label.Name = "lastName_label";
            lastName_label.Size = new Size(58, 15);
            lastName_label.TabIndex = 3;
            lastName_label.Text = "Фамилия";
            // 
            // firstName_label
            // 
            firstName_label.AutoSize = true;
            firstName_label.Location = new Point(14, 57);
            firstName_label.Margin = new Padding(4, 0, 4, 0);
            firstName_label.Name = "firstName_label";
            firstName_label.Size = new Size(31, 15);
            firstName_label.TabIndex = 4;
            firstName_label.Text = "Имя";
            // 
            // Patronymic_label
            // 
            Patronymic_label.AutoSize = true;
            Patronymic_label.Location = new Point(14, 105);
            Patronymic_label.Margin = new Padding(4, 0, 4, 0);
            Patronymic_label.Name = "Patronymic_label";
            Patronymic_label.Size = new Size(58, 15);
            Patronymic_label.TabIndex = 5;
            Patronymic_label.Text = "Отчество";
            // 
            // Position_label
            // 
            Position_label.AutoSize = true;
            Position_label.Location = new Point(154, 10);
            Position_label.Margin = new Padding(4, 0, 4, 0);
            Position_label.Name = "Position_label";
            Position_label.Size = new Size(69, 15);
            Position_label.TabIndex = 6;
            Position_label.Text = "Должность";
            // 
            // WorkExperience_label
            // 
            WorkExperience_label.AutoSize = true;
            WorkExperience_label.Location = new Point(154, 57);
            WorkExperience_label.Margin = new Padding(4, 0, 4, 0);
            WorkExperience_label.Name = "WorkExperience_label";
            WorkExperience_label.Size = new Size(81, 15);
            WorkExperience_label.TabIndex = 7;
            WorkExperience_label.Text = "Опыт работы";
            // 
            // Salary_label
            // 
            Salary_label.AutoSize = true;
            Salary_label.Location = new Point(154, 105);
            Salary_label.Margin = new Padding(4, 0, 4, 0);
            Salary_label.Name = "Salary_label";
            Salary_label.Size = new Size(26, 15);
            Salary_label.TabIndex = 8;
            Salary_label.Text = "З/п";
            // 
            // BirthDate_label
            // 
            BirthDate_label.AutoSize = true;
            BirthDate_label.Location = new Point(58, 171);
            BirthDate_label.Margin = new Padding(4, 0, 4, 0);
            BirthDate_label.Name = "BirthDate_label";
            BirthDate_label.Size = new Size(167, 15);
            BirthDate_label.TabIndex = 9;
            BirthDate_label.Text = "Дата рождения [dd.mm.yyyy]";
            // 
            // lastName_textBox
            // 
            lastName_textBox.Location = new Point(14, 29);
            lastName_textBox.Margin = new Padding(4, 3, 4, 3);
            lastName_textBox.Name = "lastName_textBox";
            lastName_textBox.Size = new Size(116, 23);
            lastName_textBox.TabIndex = 10;
            // 
            // firstName_textBox
            // 
            firstName_textBox.Location = new Point(14, 75);
            firstName_textBox.Margin = new Padding(4, 3, 4, 3);
            firstName_textBox.Name = "firstName_textBox";
            firstName_textBox.Size = new Size(116, 23);
            firstName_textBox.TabIndex = 11;
            // 
            // Patronymic_textBox
            // 
            Patronymic_textBox.Location = new Point(14, 123);
            Patronymic_textBox.Margin = new Padding(4, 3, 4, 3);
            Patronymic_textBox.Name = "Patronymic_textBox";
            Patronymic_textBox.Size = new Size(116, 23);
            Patronymic_textBox.TabIndex = 12;
            // 
            // Position_textBox
            // 
            Position_textBox.Location = new Point(154, 29);
            Position_textBox.Margin = new Padding(4, 3, 4, 3);
            Position_textBox.Name = "Position_textBox";
            Position_textBox.Size = new Size(116, 23);
            Position_textBox.TabIndex = 13;
            // 
            // WorkExperience_textBox
            // 
            WorkExperience_textBox.Location = new Point(154, 75);
            WorkExperience_textBox.Margin = new Padding(4, 3, 4, 3);
            WorkExperience_textBox.Name = "WorkExperience_textBox";
            WorkExperience_textBox.Size = new Size(116, 23);
            WorkExperience_textBox.TabIndex = 14;
            // 
            // Salary_textBox
            // 
            Salary_textBox.Location = new Point(154, 123);
            Salary_textBox.Margin = new Padding(4, 3, 4, 3);
            Salary_textBox.Name = "Salary_textBox";
            Salary_textBox.Size = new Size(116, 23);
            Salary_textBox.TabIndex = 15;
            // 
            // BirthDate_textBox
            // 
            BirthDate_textBox.Location = new Point(86, 189);
            BirthDate_textBox.Margin = new Padding(4, 3, 4, 3);
            BirthDate_textBox.Name = "BirthDate_textBox";
            BirthDate_textBox.Size = new Size(116, 23);
            BirthDate_textBox.TabIndex = 16;
            // 
            // Apply_button
            // 
            Apply_button.Location = new Point(14, 234);
            Apply_button.Margin = new Padding(4, 3, 4, 3);
            Apply_button.Name = "Apply_button";
            Apply_button.Size = new Size(257, 27);
            Apply_button.TabIndex = 17;
            Apply_button.Text = "Применить";
            Apply_button.UseVisualStyleBackColor = true;
            Apply_button.Click += КнопкаПрименить;
            // 
            // МенюРедактированияРабочего
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(277, 266);
            Controls.Add(Apply_button);
            Controls.Add(BirthDate_textBox);
            Controls.Add(Salary_textBox);
            Controls.Add(WorkExperience_textBox);
            Controls.Add(Position_textBox);
            Controls.Add(Patronymic_textBox);
            Controls.Add(firstName_textBox);
            Controls.Add(lastName_textBox);
            Controls.Add(BirthDate_label);
            Controls.Add(Salary_label);
            Controls.Add(WorkExperience_label);
            Controls.Add(Position_label);
            Controls.Add(Patronymic_label);
            Controls.Add(firstName_label);
            Controls.Add(lastName_label);
            Controls.Add(checkId_button);
            Controls.Add(checkId_textBox);
            Controls.Add(checkId_label);
            Margin = new Padding(4, 3, 4, 3);
            Name = "МенюРедактированияРабочего";
            Text = "МенюРедактированияРабочего";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label checkId_label;
        private TextBox checkId_textBox;
        private Button checkId_button;
        private Label lastName_label;
        private Label firstName_label;
        private Label Patronymic_label;
        private Label Position_label;
        private Label WorkExperience_label;
        private Label Salary_label;
        private Label BirthDate_label;
        private TextBox lastName_textBox;
        private TextBox firstName_textBox;
        private TextBox Patronymic_textBox;
        private TextBox Position_textBox;
        private TextBox WorkExperience_textBox;
        private TextBox Salary_textBox;
        private TextBox BirthDate_textBox;
        private Button Apply_button;
    }
}
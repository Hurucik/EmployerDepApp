namespace EmployerDepApp
{
    partial class МенюДобавленияРабочего
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
            lastName_label = new Label();
            firstName_label = new Label();
            Patronymic_label = new Label();
            Position_label = new Label();
            WorkExperience_label = new Label();
            Solary_label = new Label();
            BirthDate_label = new Label();
            OK_button = new Button();
            Cancel_button = new Button();
            lastName_textBox = new TextBox();
            firstName_textBox = new TextBox();
            Patronymic_textBox = new TextBox();
            Position_textBox = new TextBox();
            WorkExperience_textBox = new TextBox();
            Solary_textBox = new TextBox();
            BirthDate_textBox = new TextBox();
            SuspendLayout();
            // 
            // lastName_label
            // 
            lastName_label.AutoSize = true;
            lastName_label.Location = new Point(14, 21);
            lastName_label.Margin = new Padding(4, 0, 4, 0);
            lastName_label.Name = "lastName_label";
            lastName_label.Size = new Size(58, 15);
            lastName_label.TabIndex = 0;
            lastName_label.Text = "Фамилия";
            // 
            // firstName_label
            // 
            firstName_label.AutoSize = true;
            firstName_label.Location = new Point(14, 74);
            firstName_label.Margin = new Padding(4, 0, 4, 0);
            firstName_label.Name = "firstName_label";
            firstName_label.Size = new Size(31, 15);
            firstName_label.TabIndex = 1;
            firstName_label.Text = "Имя";
            // 
            // Patronymic_label
            // 
            Patronymic_label.AutoSize = true;
            Patronymic_label.Location = new Point(14, 130);
            Patronymic_label.Margin = new Padding(4, 0, 4, 0);
            Patronymic_label.Name = "Patronymic_label";
            Patronymic_label.Size = new Size(58, 15);
            Patronymic_label.TabIndex = 2;
            Patronymic_label.Text = "Отчество";
            // 
            // Position_label
            // 
            Position_label.AutoSize = true;
            Position_label.Location = new Point(172, 21);
            Position_label.Margin = new Padding(4, 0, 4, 0);
            Position_label.Name = "Position_label";
            Position_label.Size = new Size(69, 15);
            Position_label.TabIndex = 3;
            Position_label.Text = "Должность";
            // 
            // WorkExperience_label
            // 
            WorkExperience_label.AutoSize = true;
            WorkExperience_label.Location = new Point(172, 74);
            WorkExperience_label.Margin = new Padding(4, 0, 4, 0);
            WorkExperience_label.Name = "WorkExperience_label";
            WorkExperience_label.Size = new Size(81, 15);
            WorkExperience_label.TabIndex = 4;
            WorkExperience_label.Text = "Опыт работы";
            // 
            // Solary_label
            // 
            Solary_label.AutoSize = true;
            Solary_label.Location = new Point(172, 130);
            Solary_label.Margin = new Padding(4, 0, 4, 0);
            Solary_label.Name = "Solary_label";
            Solary_label.Size = new Size(26, 15);
            Solary_label.TabIndex = 5;
            Solary_label.Text = "З/п";
            // 
            // BirthDate_label
            // 
            BirthDate_label.AutoSize = true;
            BirthDate_label.Location = new Point(62, 196);
            BirthDate_label.Margin = new Padding(4, 0, 4, 0);
            BirthDate_label.Name = "BirthDate_label";
            BirthDate_label.Size = new Size(167, 15);
            BirthDate_label.TabIndex = 6;
            BirthDate_label.Text = "Дата рождения [dd.mm.yyyy]";
            // 
            // OK_button
            // 
            OK_button.Location = new Point(14, 276);
            OK_button.Margin = new Padding(4, 3, 4, 3);
            OK_button.Name = "OK_button";
            OK_button.Size = new Size(88, 27);
            OK_button.TabIndex = 8;
            OK_button.Text = "Добавить";
            OK_button.UseVisualStyleBackColor = true;
            OK_button.Click += КнопкаДобавить;
            // 
            // Cancel_button
            // 
            Cancel_button.Location = new Point(181, 276);
            Cancel_button.Margin = new Padding(4, 3, 4, 3);
            Cancel_button.Name = "Cancel_button";
            Cancel_button.Size = new Size(88, 27);
            Cancel_button.TabIndex = 9;
            Cancel_button.Text = "Отмена";
            Cancel_button.UseVisualStyleBackColor = true;
            Cancel_button.Click += КнопкаОтмена;
            // 
            // lastName_textBox
            // 
            lastName_textBox.Location = new Point(14, 39);
            lastName_textBox.Margin = new Padding(4, 3, 4, 3);
            lastName_textBox.Name = "lastName_textBox";
            lastName_textBox.Size = new Size(96, 23);
            lastName_textBox.TabIndex = 10;
            // 
            // firstName_textBox
            // 
            firstName_textBox.Location = new Point(14, 92);
            firstName_textBox.Margin = new Padding(4, 3, 4, 3);
            firstName_textBox.Name = "firstName_textBox";
            firstName_textBox.Size = new Size(96, 23);
            firstName_textBox.TabIndex = 11;
            // 
            // Patronymic_textBox
            // 
            Patronymic_textBox.Location = new Point(14, 149);
            Patronymic_textBox.Margin = new Padding(4, 3, 4, 3);
            Patronymic_textBox.Name = "Patronymic_textBox";
            Patronymic_textBox.Size = new Size(96, 23);
            Patronymic_textBox.TabIndex = 12;
            // 
            // Position_textBox
            // 
            Position_textBox.Location = new Point(172, 39);
            Position_textBox.Margin = new Padding(4, 3, 4, 3);
            Position_textBox.Name = "Position_textBox";
            Position_textBox.Size = new Size(96, 23);
            Position_textBox.TabIndex = 13;
            // 
            // WorkExperience_textBox
            // 
            WorkExperience_textBox.Location = new Point(172, 92);
            WorkExperience_textBox.Margin = new Padding(4, 3, 4, 3);
            WorkExperience_textBox.Name = "WorkExperience_textBox";
            WorkExperience_textBox.Size = new Size(96, 23);
            WorkExperience_textBox.TabIndex = 14;
            // 
            // Solary_textBox
            // 
            Solary_textBox.Location = new Point(172, 149);
            Solary_textBox.Margin = new Padding(4, 3, 4, 3);
            Solary_textBox.Name = "Solary_textBox";
            Solary_textBox.Size = new Size(96, 23);
            Solary_textBox.TabIndex = 15;
            // 
            // BirthDate_textBox
            // 
            BirthDate_textBox.Location = new Point(102, 215);
            BirthDate_textBox.Margin = new Padding(4, 3, 4, 3);
            BirthDate_textBox.Name = "BirthDate_textBox";
            BirthDate_textBox.Size = new Size(96, 23);
            BirthDate_textBox.TabIndex = 16;
            // 
            // МенюДобавленияРабочего
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(285, 317);
            Controls.Add(BirthDate_textBox);
            Controls.Add(Solary_textBox);
            Controls.Add(WorkExperience_textBox);
            Controls.Add(Position_textBox);
            Controls.Add(Patronymic_textBox);
            Controls.Add(firstName_textBox);
            Controls.Add(lastName_textBox);
            Controls.Add(Cancel_button);
            Controls.Add(OK_button);
            Controls.Add(BirthDate_label);
            Controls.Add(Solary_label);
            Controls.Add(WorkExperience_label);
            Controls.Add(Position_label);
            Controls.Add(Patronymic_label);
            Controls.Add(firstName_label);
            Controls.Add(lastName_label);
            Margin = new Padding(4, 3, 4, 3);
            Name = "МенюДобавленияРабочего";
            Text = "МенюДобавленияРабочего";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lastName_label;
        private Label firstName_label;
        private Label Patronymic_label;
        private Label Position_label;
        private Label WorkExperience_label;
        private Label Solary_label;
        private Label BirthDate_label;
        private Button OK_button;
        private Button Cancel_button;
        private TextBox lastName_textBox;
        private TextBox firstName_textBox;
        private TextBox Patronymic_textBox;
        private TextBox Position_textBox;
        private TextBox WorkExperience_textBox;
        private TextBox Solary_textBox;
        private TextBox BirthDate_textBox;
    }
}
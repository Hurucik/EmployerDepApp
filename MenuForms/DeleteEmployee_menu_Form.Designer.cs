namespace EmployerDepApp
{
    partial class МенюУдаленияРабочегоПоИдентификатору
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
            ID_label = new Label();
            ID_textBox = new TextBox();
            Delete_button = new Button();
            SuspendLayout();
            // 
            // ID_label
            // 
            ID_label.AutoSize = true;
            ID_label.Location = new Point(14, 10);
            ID_label.Margin = new Padding(4, 0, 4, 0);
            ID_label.Name = "ID_label";
            ID_label.Size = new Size(119, 15);
            ID_label.TabIndex = 0;
            ID_label.Text = "Введите ID рабочего";
            // 
            // ID_textBox
            // 
            ID_textBox.Location = new Point(14, 29);
            ID_textBox.Margin = new Padding(4, 3, 4, 3);
            ID_textBox.Name = "ID_textBox";
            ID_textBox.Size = new Size(156, 23);
            ID_textBox.TabIndex = 1;
            // 
            // Delete_button
            // 
            Delete_button.Location = new Point(14, 60);
            Delete_button.Margin = new Padding(4, 3, 4, 3);
            Delete_button.Name = "Delete_button";
            Delete_button.Size = new Size(156, 27);
            Delete_button.TabIndex = 2;
            Delete_button.Text = "Удалить";
            Delete_button.UseVisualStyleBackColor = true;
            Delete_button.Click += КнопкаУдалить;
            // 
            // МенюУдаленияРабочегоПоИдентификатору
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(183, 103);
            Controls.Add(Delete_button);
            Controls.Add(ID_textBox);
            Controls.Add(ID_label);
            Margin = new Padding(4, 3, 4, 3);
            Name = "МенюУдаленияРабочегоПоИдентификатору";
            Text = "МенюУдаленияРабочегоПоИдентификатору";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ID_label;
        private TextBox ID_textBox;
        private Button Delete_button;
    }
}
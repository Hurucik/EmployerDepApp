namespace EmployerDepApp
{
    partial class ОтделКадров
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
            listView1 = new ListView();
            Index_columnHeader = new ColumnHeader();
            LastName_columnHeader = new ColumnHeader();
            FirstName_columnHeader = new ColumnHeader();
            Patronymic_columnHeader = new ColumnHeader();
            JobTitle_columnHeader = new ColumnHeader();
            WorkExperience_columnHeader = new ColumnHeader();
            Solary_columnHeader = new ColumnHeader();
            BirthDate_columnHeader = new ColumnHeader();
            menuStrip1 = new MenuStrip();
            главноеToolStripMenuItem = new ToolStripMenuItem();
            добавитьРаботникаToolStripMenuItem = new ToolStripMenuItem();
            редактироватьРаботникаToolStripMenuItem = new ToolStripMenuItem();
            удалитьРаботникаToolStripMenuItem = new ToolStripMenuItem();
            открытьБазуРаботниковИзФайлаToolStripMenuItem = new ToolStripMenuItem();
            сохранитьБазуВФайлToolStripMenuItem = new ToolStripMenuItem();
            сортироватьПоToolStripMenuItem = new ToolStripMenuItem();
            фамилииToolStripMenuItem = new ToolStripMenuItem();
            имениToolStripMenuItem = new ToolStripMenuItem();
            отчествуToolStripMenuItem = new ToolStripMenuItem();
            должностиToolStripMenuItem = new ToolStripMenuItem();
            стажуToolStripMenuItem = new ToolStripMenuItem();
            зпToolStripMenuItem = new ToolStripMenuItem();
            датеРожденияToolStripMenuItem = new ToolStripMenuItem();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { Index_columnHeader, LastName_columnHeader, FirstName_columnHeader, Patronymic_columnHeader, JobTitle_columnHeader, WorkExperience_columnHeader, Solary_columnHeader, BirthDate_columnHeader });
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.Location = new Point(14, 29);
            listView1.Margin = new Padding(4, 3, 4, 3);
            listView1.Name = "listView1";
            listView1.Size = new Size(905, 476);
            listView1.TabIndex = 1;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // Index_columnHeader
            // 
            Index_columnHeader.Text = "ID";
            Index_columnHeader.Width = 30;
            // 
            // LastName_columnHeader
            // 
            LastName_columnHeader.Text = "Фамилия";
            LastName_columnHeader.Width = 100;
            // 
            // FirstName_columnHeader
            // 
            FirstName_columnHeader.Text = "Имя";
            FirstName_columnHeader.Width = 100;
            // 
            // Patronymic_columnHeader
            // 
            Patronymic_columnHeader.Text = "Отчество";
            Patronymic_columnHeader.Width = 100;
            // 
            // JobTitle_columnHeader
            // 
            JobTitle_columnHeader.Text = "Должность";
            JobTitle_columnHeader.Width = 100;
            // 
            // WorkExperience_columnHeader
            // 
            WorkExperience_columnHeader.Text = "Стаж";
            WorkExperience_columnHeader.Width = 50;
            // 
            // Solary_columnHeader
            // 
            Solary_columnHeader.Text = "З/п";
            Solary_columnHeader.Width = 100;
            // 
            // BirthDate_columnHeader
            // 
            BirthDate_columnHeader.Text = "Дата рождения";
            BirthDate_columnHeader.Width = 100;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { главноеToolStripMenuItem, сортироватьПоToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 2, 0, 2);
            menuStrip1.Size = new Size(933, 24);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // главноеToolStripMenuItem
            // 
            главноеToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { добавитьРаботникаToolStripMenuItem, редактироватьРаботникаToolStripMenuItem, удалитьРаботникаToolStripMenuItem, открытьБазуРаботниковИзФайлаToolStripMenuItem, сохранитьБазуВФайлToolStripMenuItem });
            главноеToolStripMenuItem.Name = "главноеToolStripMenuItem";
            главноеToolStripMenuItem.Size = new Size(64, 20);
            главноеToolStripMenuItem.Text = "Главное";
            // 
            // добавитьРаботникаToolStripMenuItem
            // 
            добавитьРаботникаToolStripMenuItem.Name = "добавитьРаботникаToolStripMenuItem";
            добавитьРаботникаToolStripMenuItem.Size = new Size(215, 22);
            добавитьРаботникаToolStripMenuItem.Text = "Добавить работника";
            добавитьРаботникаToolStripMenuItem.Click += КнопкаВызоваОкнаДобавленияРаботника;
            // 
            // редактироватьРаботникаToolStripMenuItem
            // 
            редактироватьРаботникаToolStripMenuItem.Name = "редактироватьРаботникаToolStripMenuItem";
            редактироватьРаботникаToolStripMenuItem.Size = new Size(215, 22);
            редактироватьРаботникаToolStripMenuItem.Text = "Редактировать работника";
            редактироватьРаботникаToolStripMenuItem.Click += КнопкаВызоваОкнаРедактораРаботника;
            // 
            // удалитьРаботникаToolStripMenuItem
            // 
            удалитьРаботникаToolStripMenuItem.Name = "удалитьРаботникаToolStripMenuItem";
            удалитьРаботникаToolStripMenuItem.Size = new Size(215, 22);
            удалитьРаботникаToolStripMenuItem.Text = "Удалить работника";
            удалитьРаботникаToolStripMenuItem.Click += КнопкаВызоваОкнаУдаленияРаботника;
            // 
            // открытьБазуРаботниковИзФайлаToolStripMenuItem
            // 
            открытьБазуРаботниковИзФайлаToolStripMenuItem.Name = "открытьБазуРаботниковИзФайлаToolStripMenuItem";
            открытьБазуРаботниковИзФайлаToolStripMenuItem.Size = new Size(215, 22);
            открытьБазуРаботниковИзФайлаToolStripMenuItem.Text = "Открыть базу из файла";
            открытьБазуРаботниковИзФайлаToolStripMenuItem.Click += КнопкаОткрытьБазуРаботниковИзФайла;
            // 
            // сохранитьБазуВФайлToolStripMenuItem
            // 
            сохранитьБазуВФайлToolStripMenuItem.Name = "сохранитьБазуВФайлToolStripMenuItem";
            сохранитьБазуВФайлToolStripMenuItem.Size = new Size(215, 22);
            сохранитьБазуВФайлToolStripMenuItem.Text = "Сохранить базу в файл";
            сохранитьБазуВФайлToolStripMenuItem.Click += КнопкаСохранитьБазуВФайл;
            // 
            // сортироватьПоToolStripMenuItem
            // 
            сортироватьПоToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { фамилииToolStripMenuItem, имениToolStripMenuItem, отчествуToolStripMenuItem, должностиToolStripMenuItem, стажуToolStripMenuItem, зпToolStripMenuItem, датеРожденияToolStripMenuItem });
            сортироватьПоToolStripMenuItem.Name = "сортироватьПоToolStripMenuItem";
            сортироватьПоToolStripMenuItem.Size = new Size(116, 20);
            сортироватьПоToolStripMenuItem.Text = "Сортировать по...";
            // 
            // фамилииToolStripMenuItem
            // 
            фамилииToolStripMenuItem.Name = "фамилииToolStripMenuItem";
            фамилииToolStripMenuItem.Size = new Size(157, 22);
            фамилииToolStripMenuItem.Text = "Фамилии";
            фамилииToolStripMenuItem.Click += КнопкаСортировкиПоФамилии;
            // 
            // имениToolStripMenuItem
            // 
            имениToolStripMenuItem.Name = "имениToolStripMenuItem";
            имениToolStripMenuItem.Size = new Size(157, 22);
            имениToolStripMenuItem.Text = "Имени";
            имениToolStripMenuItem.Click += КнопкаСортировкиПоИмени;
            // 
            // отчествуToolStripMenuItem
            // 
            отчествуToolStripMenuItem.Name = "отчествуToolStripMenuItem";
            отчествуToolStripMenuItem.Size = new Size(157, 22);
            отчествуToolStripMenuItem.Text = "Отчеству";
            отчествуToolStripMenuItem.Click += КнопкаСортировкиПоОтчеству;
            // 
            // должностиToolStripMenuItem
            // 
            должностиToolStripMenuItem.Name = "должностиToolStripMenuItem";
            должностиToolStripMenuItem.Size = new Size(157, 22);
            должностиToolStripMenuItem.Text = "Должности";
            должностиToolStripMenuItem.Click += КнопкаСортировкиПоДолжности;
            // 
            // стажуToolStripMenuItem
            // 
            стажуToolStripMenuItem.Name = "стажуToolStripMenuItem";
            стажуToolStripMenuItem.Size = new Size(157, 22);
            стажуToolStripMenuItem.Text = "Стажу";
            стажуToolStripMenuItem.Click += КнопкаСортировкиПоСтажу;
            // 
            // зпToolStripMenuItem
            // 
            зпToolStripMenuItem.Name = "зпToolStripMenuItem";
            зпToolStripMenuItem.Size = new Size(157, 22);
            зпToolStripMenuItem.Text = "З/п";
            зпToolStripMenuItem.Click += КнопкаСортировкиПоЗП;
            // 
            // датеРожденияToolStripMenuItem
            // 
            датеРожденияToolStripMenuItem.Name = "датеРожденияToolStripMenuItem";
            датеРожденияToolStripMenuItem.Size = new Size(157, 22);
            датеРожденияToolStripMenuItem.Text = "Дате рождения";
            датеРожденияToolStripMenuItem.Click += КнопкаСортировкиПоДатеРождения;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.Filter = "Excel files|*.xlsx";
            // 
            // ОтделКадров
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 519);
            Controls.Add(listView1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4, 3, 4, 3);
            Name = "ОтделКадров";
            Text = "Отдел Кадров";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ColumnHeader LastName_columnHeader;
        private ColumnHeader FirstName_columnHeader;
        private ColumnHeader Patronymic_columnHeader;
        private ColumnHeader JobTitle_columnHeader;
        private ColumnHeader WorkExperience_columnHeader;
        private ColumnHeader Solary_columnHeader;
        private ColumnHeader BirthDate_columnHeader;
        public ListView listView1;
        private ColumnHeader Index_columnHeader;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem главноеToolStripMenuItem;
        private ToolStripMenuItem сортироватьПоToolStripMenuItem;
        private ToolStripMenuItem фамилииToolStripMenuItem;
        private ToolStripMenuItem имениToolStripMenuItem;
        private ToolStripMenuItem отчествуToolStripMenuItem;
        private ToolStripMenuItem должностиToolStripMenuItem;
        private ToolStripMenuItem стажуToolStripMenuItem;
        private ToolStripMenuItem зпToolStripMenuItem;
        private ToolStripMenuItem датеРожденияToolStripMenuItem;
        private ToolStripMenuItem добавитьРаботникаToolStripMenuItem;
        private ToolStripMenuItem редактироватьРаботникаToolStripMenuItem;
        private ToolStripMenuItem удалитьРаботникаToolStripMenuItem;
        private ToolStripMenuItem открытьБазуРаботниковИзФайлаToolStripMenuItem;
        private ToolStripMenuItem сохранитьБазуВФайлToolStripMenuItem;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
    }
}
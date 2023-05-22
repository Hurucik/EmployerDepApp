namespace EmployerDepApp
{
    public partial class МенюРедактированияРабочего : Form
    {
        private int EmployeeId;

        public МенюРедактированияРабочего()
        {
            InitializeComponent();


            // изначально скрываем элементы
            СкрытьВсеКомпоненты();
            // уменьшаем окно
            Size = new Size(170, 160);
            // достаем из невидимой области элементы для ввода ID
            checkId_label.Location = new Point(12, 9);
            checkId_textBox.Location = new Point(12, 25);
            checkId_button.Location = new Point(12, 59);


        }

        private void КнопкаНайтиПоID(object sender, EventArgs e)
        {
            // првоеряем поля на пустоту
            if (string.IsNullOrWhiteSpace(checkId_textBox.Text) ||
                string.IsNullOrEmpty(checkId_textBox.Text))
            {
                MessageBox.Show("Ошибка : Поле не заполнено!");
                Close(); return;
            }

            // проверяем число ли ID
            bool isIdInt = int.TryParse(checkId_textBox.Text, out EmployeeId);
            if (isIdInt == false)
            {
                MessageBox.Show("Ошибка : ID должно быть числом!");
                Close(); return;
            }
            // ищем пользвоателя в бд по ID
            Рабочий employee = БазаДанныхРабочих.Employees.FirstOrDefault(e => e.Id == EmployeeId);
            if (employee == null)
            {
                MessageBox.Show("Ошибка: Пользователя с таким ID нет в системе!");
                Close(); return;
            }

            // как только пользовател найден, скрываем элементы в которые писали ID
            checkId_label.Visible = false;
            checkId_textBox.Visible = false;
            checkId_button.Visible = false;
            // увеличиваем размер формы
            this.Size = new Size(260, 310);
            // и делаем видимыми компоненты где будет редактировать пользователя
            ОтобразитьВсеКомпоненты();
            // заполняем текстбоксы данными пользователя, которые будем редактирвоать
            ЗаполнитьВсеПоля(employee);
        }

        // метод для раскрытия компонентов
        private void ОтобразитьВсеКомпоненты()
        {
            lastName_label.Visible = true;
            lastName_textBox.Visible = true;
            firstName_label.Visible = true;
            firstName_textBox.Visible = true;
            Patronymic_label.Visible = true;
            Patronymic_textBox.Visible = true;
            Position_label.Visible = true;
            Position_textBox.Visible = true;
            WorkExperience_label.Visible = true;
            WorkExperience_textBox.Visible = true;
            Salary_label.Visible = true;
            Salary_textBox.Visible = true;
            BirthDate_label.Visible = true;
            BirthDate_textBox.Visible = true;
        }

        // метод для скрытия компонентов
        private void СкрытьВсеКомпоненты()
        {
            lastName_label.Visible = false;
            lastName_textBox.Visible = false;
            firstName_label.Visible = false;
            firstName_textBox.Visible = false;
            Patronymic_label.Visible = false;
            Patronymic_textBox.Visible = false;
            Position_label.Visible = false;
            Position_textBox.Visible = false;
            WorkExperience_label.Visible = false;
            WorkExperience_textBox.Visible = false;
            Salary_label.Visible = false;
            Salary_textBox.Visible = false;
            BirthDate_label.Visible = false;
            BirthDate_textBox.Visible = false;
        }

        // заполняем текстбоксы данными найденного пользователя
        private void ЗаполнитьВсеПоля(Рабочий employee)
        {
            lastName_textBox.Text = employee.LastName;
            firstName_textBox.Text = employee.FirstName;
            Patronymic_textBox.Text = employee.Patronymic;
            Position_textBox.Text = employee.Position;
            WorkExperience_textBox.Text = employee.WorkExperience.ToString();
            Salary_textBox.Text = employee.Salary.ToString();
            BirthDate_textBox.Text = employee.BirthDate.ToShortDateString();
        }

        // при нажатии Принять, редактируем пользователя
        private void КнопкаПрименить(object sender, EventArgs e)
        {
            // опять находим пользователя по ID
            Рабочий employee = БазаДанныхРабочих.Employees.FirstOrDefault(e => e.Id == EmployeeId);
            // меняем ему данные на измененные
            employee.LastName = lastName_textBox.Text;
            employee.FirstName = firstName_textBox.Text;
            employee.Patronymic = Patronymic_textBox.Text;
            employee.Position = Position_textBox.Text;
            employee.WorkExperience = ushort.Parse(WorkExperience_textBox.Text);
            employee.Salary = decimal.Parse(Salary_textBox.Text);
            employee.BirthDate = DateTime.Parse(BirthDate_textBox.Text);

            // обновляем таблицу
            ОтделКадров.ОбновитьЛист();
        }
    }
}
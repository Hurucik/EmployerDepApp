namespace EmployerDepApp
{
    public partial class МенюДобавленияРабочего : Form
    {
        public МенюДобавленияРабочего()
        {
            InitializeComponent();
        }

        private void КнопкаДобавить(object sender, EventArgs e)
        {
            if (ПроверкаЗаполненияПолей() == false)
            {
                MessageBox.Show("Не все поля заполнены!");
            }
            try
            {
                Рабочий employee = new Рабочий()
                {
                    LastName = lastName_textBox.Text,
                    FirstName = firstName_textBox.Text,
                    Patronymic = Patronymic_textBox.Text,
                    Position = Position_textBox.Text,
                    WorkExperience = ushort.Parse(WorkExperience_textBox.Text),
                    Salary = decimal.Parse(Solary_textBox.Text),
                    BirthDate = DateTime.Parse(BirthDate_textBox.Text)
                };
                БазаДанныхРабочих.Employees.Add(employee);
                ОтделКадров.ДобавитьРабочегоНаЛист(employee.Id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private bool ПроверкаЗаполненияПолей()
        {
            // Проверка, заполнены ли поля
            if (string.IsNullOrEmpty(lastName_textBox.Text) ||
                string.IsNullOrEmpty(firstName_textBox.Text) ||
                string.IsNullOrEmpty(Patronymic_textBox.Text) ||
                string.IsNullOrEmpty(Position_textBox.Text) ||
                string.IsNullOrEmpty(WorkExperience_textBox.Text) ||
                string.IsNullOrEmpty(Solary_label.Text) ||
                string.IsNullOrEmpty(BirthDate_textBox.Text))
            {
                // если нет, то выход из метода
                return false;
            }
            else
            {
                return true;
            }
        }

        private void КнопкаОтмена(object sender, EventArgs e)
        {
            // выход из формы
            Close();
        }
    }
}
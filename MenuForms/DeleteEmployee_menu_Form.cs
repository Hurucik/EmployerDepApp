namespace EmployerDepApp
{
    public partial class МенюУдаленияРабочегоПоИдентификатору : Form
    {
        public МенюУдаленияРабочегоПоИдентификатору()
        {
            InitializeComponent();
        }

        private void КнопкаУдалить(object sender, EventArgs e)
        {
            int id;
            // проверка поля , есть ли в нем что-то
            if (string.IsNullOrWhiteSpace(ID_textBox.Text) ||
                string.IsNullOrEmpty(ID_textBox.Text))
            {
                MessageBox.Show("Ошибка : Поле не заполнено!");
                Close(); return;
            }
            // парсим ID из текстбокса и проверяем чтобы оно было числом
            bool isIdInt = int.TryParse(ID_textBox.Text, out id);
            if (isIdInt == false)
            {
                MessageBox.Show("Ошибка : ID должно быть числом!");
                Close(); return;
            }
            // ищем в бд работника с id которое ввели в форму
            Рабочий employee = БазаДанныхРабочих.Employees.FirstOrDefault(e => e.Id == id);
            if (employee == null)
            {
                MessageBox.Show("Ошибка: рабочего с таким ID нет в системе!");
                Close(); return;
            }

            // удаляем пользователя из бд
            БазаДанныхРабочих.Employees.Remove(employee);
            //обновляем таблицу
            ОтделКадров.ОбновитьЛист();
            MessageBox.Show("Работник успешно удален!");
            Close();
        }
    }
}
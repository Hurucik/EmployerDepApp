namespace EmployerDepApp
{
    internal class Рабочий
    {
        public int Id; // ID
        public string FirstName;  // Имя
        public string LastName;  // Фамилия
        public string Patronymic;  // Отчество
        public string Position;  // Должность
        public DateTime BirthDate;  // Дата рождения
        public ushort WorkExperience;  // Стаж работы
        public decimal Salary;  // Зарплата
        private static int globalEmployeeId = 0;

        public Рабочий()
        {
            // Чтобы при создании работника ID увеличивался на 1
            Id = globalEmployeeId;
            globalEmployeeId++;
        }
    }
}
namespace EmployerDepApp
{
    internal static class БазаДанныхРабочих
    {
        // Лист работников
        public static List<Рабочий> Employees = new List<Рабочий>();

        // Очистить лист
        public static void ОчиститьЛист()
        {

            Employees.Clear();
        }
    }
}
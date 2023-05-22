namespace EmployerDepApp
{
    internal static class ШейкернаяСортировка
    {
        // переменная связанная с БД
        //все что меняется в Employees, то меняется в БД
        public static List<Рабочий> Employees = БазаДанныхРабочих.Employees;

        // на вход метода даем строку со значения поля которое будем сортировать
        public static void МетодШейкернойСортировки(string field)
        {
            int left = 0;
            int right = Employees.Count - 1;

            while (left < right)
            {
                for (int i = left; i < right; i++)
                {
                    // переменная отвечающая за перестановку значений
                    bool needSwap = false;
                    
                    if (field == "фамилия")
                    {
                        // сравниваем строки методом Compare
                        // если оно вернуло число < 0 , то 1 строка меньше второй
                        // если число = 0, то строки равны
                        // если число > 0, то 1 строка больше второй
                        int needSwapInt = string.Compare(Employees[i].LastName, Employees[i + 1].LastName);
                        // проверяем число, если меньше 0 то вернет false, а иначе true
                        if (needSwapInt < 0)
                        {
                            needSwap = false;
                        }
                        else
                        {
                            needSwap = true;
                        }
                    }
                    else if (field == "имя")
                    {
                        int needSwapInt = string.Compare(Employees[i].FirstName, Employees[i + 1].FirstName);
                        if (needSwapInt < 0)
                        {
                            needSwap = false;
                        }
                        else
                        {
                            needSwap = true;
                        }
                    }
                    else if (field == "отчество")
                    {
                        int needSwapInt = string.Compare(Employees[i].Patronymic, Employees[i + 1].Patronymic);
                        if (needSwapInt < 0)
                        {
                            needSwap = false;
                        }
                        else
                        {
                            needSwap = true;
                        }
                    }
                    else if (field == "должность")
                    {
                        int needSwapInt = string.Compare(Employees[i].Position, Employees[i + 1].Position);
                        if (needSwapInt < 0)
                        {
                            needSwap = false;
                        }
                        else
                        {
                            needSwap = true;
                        }
                    }
                    else if (field == "стаж")
                    {
                        needSwap = Employees[i].WorkExperience > Employees[i + 1].WorkExperience;
                    }
                    else if (field == "зарплата")
                    {
                        needSwap = Employees[i].Salary > Employees[i + 1].Salary;
                    }
                    else if (field == "дата рождения")
                    {
                        needSwap = Employees[i].BirthDate > Employees[i + 1].BirthDate;
                    }
                    if (needSwap)
                    {
                        var temp = Employees[i];
                        Employees[i] = Employees[i + 1];
                        Employees[i + 1] = temp;
                    }
                }
                right--;

                for (int i = right; i > left; i--)
                {
                    bool needSwap = false;
                    if (field == "фамилия")
                    {
                        int needSwapInt = string.Compare(Employees[i - 1].LastName, Employees[i].LastName);
                        if (needSwapInt < 0)
                        {
                            needSwap = false;
                        }
                        else
                        {
                            needSwap = true;
                        }
                    }
                    else if (field == "имя")
                    {
                        int needSwapInt = string.Compare(Employees[i - 1].FirstName, Employees[i].FirstName);
                        if (needSwapInt < 0)
                        {
                            needSwap = false;
                        }
                        else
                        {
                            needSwap = true;
                        }
                    }
                    else if (field == "отчество")
                    {
                        int needSwapInt = string.Compare(Employees[i - 1].Patronymic, Employees[i].Patronymic);
                        if (needSwapInt < 0)
                        {
                            needSwap = false;
                        }
                        else
                        {
                            needSwap = true;
                        }
                    }
                    else if (field == "должность")
                    {
                        int needSwapInt = string.Compare(Employees[i - 1].Position, Employees[i].Position);
                        if (needSwapInt < 0)
                        {
                            needSwap = false;
                        }
                        else
                        {
                            needSwap = true;
                        }
                    }
                    else if (field == "стаж")
                    {
                        needSwap = Employees[i - 1].WorkExperience > Employees[i].WorkExperience;
                    }
                    else if (field == "зарплата")
                    {
                        needSwap = Employees[i - 1].Salary > Employees[i].Salary;
                    }
                    else if (field == "дата рождения")
                    {
                        needSwap = Employees[i - 1].BirthDate > Employees[i].BirthDate;
                    }

                    if (needSwap)
                    {
                        var temp = Employees[i - 1];
                        Employees[i - 1] = Employees[i];
                        Employees[i] = temp;
                    }
                }
                left++;
            }
        }
    }
}
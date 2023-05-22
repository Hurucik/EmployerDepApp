using OfficeOpenXml;

namespace EmployerDepApp
{
    public partial class ќтдел адров : Form
    {
        // наша таблица, статическа€ чтобы моно было пользоватьс€ ей из разных форм и классов
        public static ListView listView;

        public ќтдел адров()
        {
            InitializeComponent();
            // изначально инициализируетс€ при запуске
            listView = listView1;
        }
        // метод добавлени€ рабочего на таблицу из Ѕƒ вручную по ID
        public static void ƒобавить–абочегоЌаЋист(int id)
        {
            // ищем рабочего в бд по ID
            –абочий employee = Ѕазаƒанных–абочих.Employees.FirstOrDefault(e => (e.Id == id));
            


            // добавл€ем рабочего
            listView.Items.Add(new ListViewItem(new string[]
            {
                employee.Id.ToString(),
                employee.LastName,
                employee.FirstName,
                employee.Patronymic,
                employee.Position,
                employee.WorkExperience.ToString(),
                employee.Salary.ToString(),
                employee.BirthDate.ToShortDateString()
            }));
        }

        // метод который очищает таблицу и заново добавл€ет на нее данные из Ѕƒ
        public static void ќбновитьЋист()
        {
            // очищаем listView
            listView.Items.Clear();

            // проходим€ по Ѕƒ и добавл€ем каждого пользовател€
            foreach (–абочий employee in Ѕазаƒанных–абочих.Employees)
            {
                if (employee == null)
                {
                    throw new Exception("Employee is null");
                }

                // берем ID пользовател€ и добавл€ем его с помощью метода
                ƒобавить–абочегоЌаЋист(employee.Id);
            }
        }

        private void  нопка¬ызоваќкна–едактора–аботника(object sender, EventArgs e)
        {
            new ћеню–едактировани€–абочего().ShowDialog();
        }

        private void  нопка¬ызоваќкна”далени€–аботника(object sender, EventArgs e)
        {
            new ћеню”далени€–абочегоѕо»дентификатору().ShowDialog();
        }

        private void  нопка¬ызоваќкнаƒобавлени€–аботника(object sender, EventArgs e)
        {
            new ћенюƒобавлени€–абочего().ShowDialog();
        }

        private void  нопкаќткрытьЅазу–аботников»з‘айла(object sender, EventArgs e)
        {
            // если закроем окно, то выхрдит из метода
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }


            string filename = openFileDialog1.FileName;
            // создаем пакет по имени файла
            ExcelPackage package = new ExcelPackage(filename);
            
                // об€зательно устанавливаем лицензию, без нее работать не будет
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            // открываем первый лист в екселе
            ExcelWorksheet worksheet = package.Workbook.Worksheets[0];

            // если таблица не пуста€ то
            if (worksheet.Dimension != null)
            {
                // считаем сколько в таблице строк с данными
                // если меньше 1 , то будет ошибка
                int rowCount;
                if (—чЄт оличества—трок(worksheet) > 1)
                {
                    rowCount = —чЄт оличества—трок(worksheet);

                }
                else
                {
                    throw new Exception("Ѕаза пуста€");
                }

                // очищаем Ѕƒ
                Ѕазаƒанных–абочих.ќчиститьЋист();

                // циклом идем по таблице и считываем данные с €чеек
                for (int rowIndex = 2; rowIndex <= rowCount; rowIndex++)
                {
                    // создаем пустого пользовател€
                    –абочий employee = new –абочий();

                    for (int columnIndex = 1; columnIndex <= 7; columnIndex++)
                    {
                        // переменна€ где будет хранить значение €чейки на которой мы сейчас
                        string value = worksheet.Cells[rowIndex, columnIndex].Value.ToString();
                        // если колонка равна определенной цифре
                        // то в нашего созданного пользовател€ записавем данные
                        switch (columnIndex)
                        {
                            case 1: employee.LastName = value; 
                                break;
                            case 2: employee.FirstName = value; 
                                break;
                            case 3: employee.Patronymic = value; 
                                break;
                            case 4: employee.Position = value; 
                                break;
                            case 5: employee.WorkExperience = ushort.Parse(value); 
                                break;
                            case 6: employee.Salary = int.Parse(value); 
                                break;
                            case 7: employee.BirthDate = DateTime.Parse(value); 
                                break;
                        }
                    }
                    // когда строка переходит на следующую, то мы
                    // добавл€ем пользовател€ в Ѕƒ и идем далее
                    // пока цикл не завершитс€
                    Ѕазаƒанных–абочих.Employees.Add(employee);
                }
                }
            
            // когда мы загрузили из таблицы Excel все данные, то обновл€ем listView
            ќтдел адров.ќбновитьЋист();
        }

        // метод который считает сколько строк с данными в таблице Excel
        private int —чЄт оличества—трок(ExcelWorksheet sheet)
        {
            // изначально 0
            int rowCount = 0;
            // проходим циклом от начала строк до конца
            for (int i = sheet.Dimension.Start.Row; i <= sheet.Dimension.End.Row; i++)
            {
                // ѕолучаем диапазон €чеек в текущей строке
                var range = sheet.Cells[i, sheet.Dimension.Start.Column, i, sheet.Dimension.End.Column];
                // ѕровер€ем, есть ли в диапазоне €чейки с текстом
                if (range.Any(c => !string.IsNullOrEmpty(c.Text)))
                {
                    rowCount++; // ”величиваем счетчик строк
                }
            }

            return rowCount;
        }

        private void  нопка—охранитьЅазу¬‘айл(object sender, EventArgs e)
        {
            // если закроем окно, то выходит из метода
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }


            string filename = saveFileDialog1.FileName;
            if (string.IsNullOrEmpty(filename))
            {
                throw new Exception("»м€ файла пустое!");
            }


            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            // создаем пакет таким образом
            ExcelPackage package = new ExcelPackage(new FileInfo($"{filename}.xlsx"));
            
            // добавл€ем лист в наш файл
            ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("List1");

            // «аголовки таблицы
            worksheet.Cells[1, 1].Value = "‘амили€";
            worksheet.Cells[1, 2].Value = "»м€";
            worksheet.Cells[1, 3].Value = "ќтчество";
            worksheet.Cells[1, 4].Value = "ƒолжность";
            worksheet.Cells[1, 5].Value = "—таж";
            worksheet.Cells[1, 6].Value = "«/п";
            worksheet.Cells[1, 7].Value = "ƒата рождени€";

            // индекс пользовател€
            int empIndex = 0;
            // проходим циклом по таблице и добавл€ем в нее данные пользователей
            for (int rowIndex = 2; rowIndex < Ѕазаƒанных–абочих.Employees.Count + 2; rowIndex++)
            {
                // находим пельзовател€ по индексу
                –абочий employee = Ѕазаƒанных–абочих.Employees[empIndex];
                // затем увеличиваем индекс на 1
                empIndex++;
                //проходим по колонкам и записываем в них данные
                for (int columnIndex = 1; columnIndex <= 7; columnIndex++)
                {
                    // в зависимости от колонки, завис€т данные
                    switch (columnIndex)
                    {
                        case 1:
                            worksheet.Cells[rowIndex, columnIndex].Value = employee.LastName;
                            break;

                        case 2:
                            worksheet.Cells[rowIndex, columnIndex].Value = employee.FirstName;
                            break;

                        case 3:
                            worksheet.Cells[rowIndex, columnIndex].Value = employee.Patronymic;
                            break;

                        case 4:
                            worksheet.Cells[rowIndex, columnIndex].Value = employee.Position;
                            break;

                        case 5:
                            worksheet.Cells[rowIndex, columnIndex].Value = employee.WorkExperience.ToString();
                            break;

                        case 6:
                            worksheet.Cells[rowIndex, columnIndex].Value = employee.Salary.ToString();
                            break;

                        case 7:
                            worksheet.Cells[rowIndex, columnIndex].Value = employee.BirthDate.ToShortDateString();
                            break;
                    }
                }
            }
            package.Save();
            MessageBox.Show("“аблица успешно сохранена");
            
        }

        // сортировки
        private void  нопка—ортировкиѕо‘амилии(object sender, EventArgs e)
        {
            Ўейкерна€—ортировка.ћетодЎейкерной—ортировки("фамили€");
            ќтдел адров.ќбновитьЋист();
        }

        private void  нопка—ортировкиѕо»мени(object sender, EventArgs e)
        {
            Ўейкерна€—ортировка.ћетодЎейкерной—ортировки("им€");
            ќтдел адров.ќбновитьЋист();
        }

        private void  нопка—ортировкиѕоќтчеству(object sender, EventArgs e)
        {
            Ўейкерна€—ортировка.ћетодЎейкерной—ортировки("отчество");
            ќтдел адров.ќбновитьЋист();
        }

        private void  нопка—ортировкиѕоƒолжности(object sender, EventArgs e)
        {
            Ўейкерна€—ортировка.ћетодЎейкерной—ортировки("должность");
            ќтдел адров.ќбновитьЋист();
        }

        private void  нопка—ортировкиѕо—тажу(object sender, EventArgs e)
        {
            Ўейкерна€—ортировка.ћетодЎейкерной—ортировки("стаж");
            ќтдел адров.ќбновитьЋист();
        }

        private void  нопка—ортировкиѕо«ѕ(object sender, EventArgs e)
        {
            Ўейкерна€—ортировка.ћетодЎейкерной—ортировки("зарплата");
            ќтдел адров.ќбновитьЋист();
        }

        private void  нопка—ортировкиѕоƒате–ождени€(object sender, EventArgs e)
        {
            Ўейкерна€—ортировка.ћетодЎейкерной—ортировки("дата рождени€");
            ќтдел адров.ќбновитьЋист();
        }
    }
}
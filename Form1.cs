using OfficeOpenXml;

namespace EmployerDepApp
{
    public partial class ����������� : Form
    {
        // ���� �������, ����������� ����� ���� ���� ������������ �� �� ������ ���� � �������
        public static ListView listView;

        public �����������()
        {
            InitializeComponent();
            // ���������� ���������������� ��� �������
            listView = listView1;
        }
        // ����� ���������� �������� �� ������� �� �� ������� �� ID
        public static void ����������������������(int id)
        {
            // ���� �������� � �� �� ID
            ������� employee = �����������������.Employees.FirstOrDefault(e => (e.Id == id));
            


            // ��������� ��������
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

        // ����� ������� ������� ������� � ������ ��������� �� ��� ������ �� ��
        public static void ������������()
        {
            // ������� listView
            listView.Items.Clear();

            // ��������� �� �� � ��������� ������� ������������
            foreach (������� employee in �����������������.Employees)
            {
                if (employee == null)
                {
                    throw new Exception("Employee is null");
                }

                // ����� ID ������������ � ��������� ��� � ������� ������
                ����������������������(employee.Id);
            }
        }

        private void ����������������������������������(object sender, EventArgs e)
        {
            new ��������������������������().ShowDialog();
        }

        private void ���������������������������������(object sender, EventArgs e)
        {
            new ������������������������������������().ShowDialog();
        }

        private void �����������������������������������(object sender, EventArgs e)
        {
            new ����������������������().ShowDialog();
        }

        private void ����������������������������������(object sender, EventArgs e)
        {
            // ���� ������� ����, �� ������� �� ������
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }


            string filename = openFileDialog1.FileName;
            // ������� ����� �� ����� �����
            ExcelPackage package = new ExcelPackage(filename);
            
                // ����������� ������������� ��������, ��� ��� �������� �� �����
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            // ��������� ������ ���� � ������
            ExcelWorksheet worksheet = package.Workbook.Worksheets[0];

            // ���� ������� �� ������ ��
            if (worksheet.Dimension != null)
            {
                // ������� ������� � ������� ����� � �������
                // ���� ������ 1 , �� ����� ������
                int rowCount;
                if (�������������������(worksheet) > 1)
                {
                    rowCount = �������������������(worksheet);

                }
                else
                {
                    throw new Exception("���� ������");
                }

                // ������� ��
                �����������������.������������();

                // ������ ���� �� ������� � ��������� ������ � �����
                for (int rowIndex = 2; rowIndex <= rowCount; rowIndex++)
                {
                    // ������� ������� ������������
                    ������� employee = new �������();

                    for (int columnIndex = 1; columnIndex <= 7; columnIndex++)
                    {
                        // ���������� ��� ����� ������� �������� ������ �� ������� �� ������
                        string value = worksheet.Cells[rowIndex, columnIndex].Value.ToString();
                        // ���� ������� ����� ������������ �����
                        // �� � ������ ���������� ������������ ��������� ������
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
                    // ����� ������ ��������� �� ���������, �� ��
                    // ��������� ������������ � �� � ���� �����
                    // ���� ���� �� ����������
                    �����������������.Employees.Add(employee);
                }
                }
            
            // ����� �� ��������� �� ������� Excel ��� ������, �� ��������� listView
            �����������.������������();
        }

        // ����� ������� ������� ������� ����� � ������� � ������� Excel
        private int �������������������(ExcelWorksheet sheet)
        {
            // ���������� 0
            int rowCount = 0;
            // �������� ������ �� ������ ����� �� �����
            for (int i = sheet.Dimension.Start.Row; i <= sheet.Dimension.End.Row; i++)
            {
                // �������� �������� ����� � ������� ������
                var range = sheet.Cells[i, sheet.Dimension.Start.Column, i, sheet.Dimension.End.Column];
                // ���������, ���� �� � ��������� ������ � �������
                if (range.Any(c => !string.IsNullOrEmpty(c.Text)))
                {
                    rowCount++; // ����������� ������� �����
                }
            }

            return rowCount;
        }

        private void ������������������������(object sender, EventArgs e)
        {
            // ���� ������� ����, �� ������� �� ������
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }


            string filename = saveFileDialog1.FileName;
            if (string.IsNullOrEmpty(filename))
            {
                throw new Exception("��� ����� ������!");
            }


            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            // ������� ����� ����� �������
            ExcelPackage package = new ExcelPackage(new FileInfo($"{filename}.xlsx"));
            
            // ��������� ���� � ��� ����
            ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("List1");

            // ��������� �������
            worksheet.Cells[1, 1].Value = "�������";
            worksheet.Cells[1, 2].Value = "���";
            worksheet.Cells[1, 3].Value = "��������";
            worksheet.Cells[1, 4].Value = "���������";
            worksheet.Cells[1, 5].Value = "����";
            worksheet.Cells[1, 6].Value = "�/�";
            worksheet.Cells[1, 7].Value = "���� ��������";

            // ������ ������������
            int empIndex = 0;
            // �������� ������ �� ������� � ��������� � ��� ������ �������������
            for (int rowIndex = 2; rowIndex < �����������������.Employees.Count + 2; rowIndex++)
            {
                // ������� ������������ �� �������
                ������� employee = �����������������.Employees[empIndex];
                // ����� ����������� ������ �� 1
                empIndex++;
                //�������� �� �������� � ���������� � ��� ������
                for (int columnIndex = 1; columnIndex <= 7; columnIndex++)
                {
                    // � ����������� �� �������, ������� ������
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
            MessageBox.Show("������� ������� ���������");
            
        }

        // ����������
        private void �������������������������(object sender, EventArgs e)
        {
            �������������������.������������������������("�������");
            �����������.������������();
        }

        private void �����������������������(object sender, EventArgs e)
        {
            �������������������.������������������������("���");
            �����������.������������();
        }

        private void ��������������������������(object sender, EventArgs e)
        {
            �������������������.������������������������("��������");
            �����������.������������();
        }

        private void ���������������������������(object sender, EventArgs e)
        {
            �������������������.������������������������("���������");
            �����������.������������();
        }

        private void �����������������������(object sender, EventArgs e)
        {
            �������������������.������������������������("����");
            �����������.������������();
        }

        private void ��������������������(object sender, EventArgs e)
        {
            �������������������.������������������������("��������");
            �����������.������������();
        }

        private void ������������������������������(object sender, EventArgs e)
        {
            �������������������.������������������������("���� ��������");
            �����������.������������();
        }
    }
}
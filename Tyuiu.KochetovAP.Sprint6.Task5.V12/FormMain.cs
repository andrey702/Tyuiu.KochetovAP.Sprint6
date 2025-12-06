using System;
using System.Windows.Forms;
using System.IO;
using Tyuiu.KochetovAP.Sprint6.Task5.V12.Lib;
using System.Globalization;

namespace Tyuiu.KochetovAP.Sprint6.Task5.V12
{
    public partial class FormMain : Form
    {
        private DataService ds = new DataService();
        private double[] allNumbers;
        private double[] filteredNumbers;

        public FormMain()
        {
            InitializeComponent();
            InitializeChart();
            CheckInputFile();
        }

        private void CheckInputFile()
        {
            string filePath = @"C:\DataSprint6\InPutFileTask5V12.txt";
            if (File.Exists(filePath))
            {
                labelShowStatus_KAP.Text = "Файл найден";
                labelShowStatus_KAP.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                labelShowStatus_KAP.Text = "Файл не найден";
                labelShowStatus_KAP.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void InitializeChart()
        {
            chartDisplayNumbers_KAP.Series[0].ChartType = SeriesChartType.Column;
            chartDisplayNumbers_KAP.Series[0].Name = "Числа";
            chartDisplayNumbers_KAP.ChartAreas[0].AxisX.Title = "Индекс";
            chartDisplayNumbers_KAP.ChartAreas[0].AxisY.Title = "Значение";
            chartDisplayNumbers_KAP.Titles.Clear();
        }

        private void buttonLoadFile_KAP_Click(object sender, EventArgs e)
        {
            try
            {
                string filePath = @"C:\DataSprint6\InPutFileTask5V12.txt";

                if (!File.Exists(filePath))
                {
                    MessageBox.Show($"Файл не найден: {filePath}", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                allNumbers = ds.LoadFromDataFile(filePath);
                DisplayAllNumbers();
                FilterNumbers();
                DisplayFilteredNumbers();
                UpdateChart();

                labelShowStatus_KAP.Text = $"Загружено: {allNumbers.Length} чисел";
                labelShowStatus_KAP.ForeColor = System.Drawing.Color.Green;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DisplayAllNumbers()
        {
            dataGridViewShowAll_KAP.Rows.Clear();
            dataGridViewShowAll_KAP.Columns.Clear();

            dataGridViewShowAll_KAP.Columns.Add("Index", "№");
            dataGridViewShowAll_KAP.Columns.Add("Value", "Значение");
            dataGridViewShowAll_KAP.Columns.Add("Divisible", "Кратно 5?");

            for (int i = 0; i < allNumbers.Length; i++)
            {
                bool isDivisible = Math.Abs(allNumbers[i] % 5) < 0.001 && Math.Abs(allNumbers[i]) > 0.001;
                dataGridViewShowAll_KAP.Rows.Add(i + 1, allNumbers[i].ToString("F3"), isDivisible ? "Да" : "Нет");
            }
        }

        private void FilterNumbers()
        {
            filteredNumbers = new double[allNumbers.Length];
            int count = 0;

            foreach (double num in allNumbers)
            {
                if (Math.Abs(num % 5) > 0.001 || Math.Abs(num) < 0.001)
                {
                    filteredNumbers[count] = num;
                    count++;
                }
            }

            Array.Resize(ref filteredNumbers, count);
        }

        private void DisplayFilteredNumbers()
        {
            textBoxShowFiltered_KAP.Clear();
            textBoxShowFiltered_KAP.AppendText("Числа не кратные 5:\r\n");
            textBoxShowFiltered_KAP.AppendText(new string('-', 30) + "\r\n");

            for (int i = 0; i < filteredNumbers.Length; i++)
            {
                textBoxShowFiltered_KAP.AppendText($"[{i}] = {filteredNumbers[i]:F3}\r\n");
            }

            textBoxShowFiltered_KAP.AppendText(new string('-', 30) + "\r\n");
            textBoxShowFiltered_KAP.AppendText($"Всего: {filteredNumbers.Length}\r\n");
        }

        private void UpdateChart()
        {
            chartDisplayNumbers_KAP.Series[0].Points.Clear();
            chartDisplayNumbers_KAP.Titles.Clear();
            chartDisplayNumbers_KAP.Titles.Add($"Числа не кратные 5 (всего: {filteredNumbers.Length})");

            for (int i = 0; i < filteredNumbers.Length; i++)
            {
                chartDisplayNumbers_KAP.Series[0].Points.AddXY(i, filteredNumbers[i]);
            }
        }

        private void buttonSaveResult_KAP_Click(object sender, EventArgs e)
        {
            if (filteredNumbers == null || filteredNumbers.Length == 0)
            {
                MessageBox.Show("Нет данных для сохранения", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
                saveDialog.FileName = "OutPutFileTask5V12.txt";
                saveDialog.InitialDirectory = @"C:\DataSprint6\";

                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter writer = new StreamWriter(saveDialog.FileName))
                    {
                        writer.WriteLine("Числа не кратные 5:");
                        for (int i = 0; i < filteredNumbers.Length; i++)
                        {
                            writer.WriteLine($"[{i}] = {filteredNumbers[i]:F3}");
                        }
                        writer.WriteLine($"Всего: {filteredNumbers.Length}");
                    }

                    MessageBox.Show($"Данные сохранены в файл:\n{saveDialog.FileName}",
                        "Сохранено", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка сохранения: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonShowHelp_KAP_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Спринт 6 | Таск 5 | Вариант 12\n\n" +
                "Задание: Прочитать данные из файла InPutFileTask5V12.txt\n" +
                "Вывести в dataGridView, отфильтровать числа не кратные 5\n" +
                "Построить диаграмму по отфильтрованным значениям\n\n" +
                "Выполнил: Кочетов А.П.",
                "Справка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonCreateFile_KAP_Click(object sender, EventArgs e)
        {
            try
            {
                string filePath = @"C:\DataSprint6\InPutFileTask5V12.txt";

                if (!Directory.Exists(@"C:\DataSprint6\"))
                {
                    Directory.CreateDirectory(@"C:\DataSprint6\");
                }

                string exampleData = "12.5 3.7 25.0 8.9 15.0\n" +
                                    "7.3 20.0 4.2 30.0 1.5\n" +
                                    "9.8 35.0 6.4 40.0 2.1";

                File.WriteAllText(filePath, exampleData);
                CheckInputFile();

                MessageBox.Show($"Создан файл: {filePath}", "Файл создан",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
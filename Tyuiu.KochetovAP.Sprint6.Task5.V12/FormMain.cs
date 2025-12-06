using System;
using System.Windows.Forms;
using System.IO;
using Tyuiu.KochetovAP.Sprint6.Task5.V12.Lib;
using System.Collections.Generic;

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
        }

        private void buttonLoadFile_KAP_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"C:\DataSprint6\InPutFileTask5V12.txt";

                if (!File.Exists(path))
                {
                    MessageBox.Show("Файл не найден", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                filteredNumbers = ds.LoadFromDataFile(path);

                ReadAllNumbersFromFile(path);

                DisplayAllNumbers();
                DisplayFilteredNumbers();
                UpdateChart();

                MessageBox.Show($"Всего чисел в файле: {allNumbers.Length}\n" +
                              $"Чисел не кратных 5: {filteredNumbers.Length}",
                    "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ReadAllNumbersFromFile(string path)
        {
            List<double> numbers = new List<double>();

            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (string.IsNullOrWhiteSpace(line))
                        continue;

                    line = line.Replace(',', '.');
                    string[] values = line.Split(new[] { ' ', '\t', ';' },
                                                StringSplitOptions.RemoveEmptyEntries);

                    foreach (string value in values)
                    {
                        if (double.TryParse(value, System.Globalization.NumberStyles.Any,
                            System.Globalization.CultureInfo.InvariantCulture, out double number))
                        {
                            numbers.Add(number);
                        }
                    }
                }
            }

            allNumbers = numbers.ToArray();
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
                bool isDivisible = Math.Abs(allNumbers[i] % 5) < 0.0001;
                dataGridViewShowAll_KAP.Rows.Add(i + 1, allNumbers[i].ToString("F3"),
                    isDivisible ? "Да" : "Нет");
            }
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
            chartDisplayNumbers_KAP.Titles.Add($"Диаграмма чисел не кратных 5");

            for (int i = 0; i < filteredNumbers.Length; i++)
            {
                chartDisplayNumbers_KAP.Series[0].Points.AddXY(i + 1, filteredNumbers[i]);
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
                string path = @"C:\DataSprint6\OutPutFileTask5V12.txt";
                using (StreamWriter writer = new StreamWriter(path))
                {
                    writer.WriteLine("Числа не кратные 5:");
                    for (int i = 0; i < filteredNumbers.Length; i++)
                    {
                        writer.WriteLine($"[{i}] = {filteredNumbers[i]:F3}");
                    }
                }
                MessageBox.Show($"Сохранено в: {path}", "Сохранено",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonShowHelp_KAP_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Спринт 6 | Таск 5 | Вариант 12\n" +
                          "1. Загрузить файл InPutFileTask5V12.txt\n" +
                          "2. DataService.LoadFromDataFile возвращает числа не кратные 5\n" +
                          "3. В таблице показать все числа с отметкой о кратности 5\n" +
                          "4. В текстовом поле - только числа не кратные 5\n" +
                          "5. Построить диаграмму по числам не кратным 5\n" +
                          "Кочетов А.П.",
                "Справка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
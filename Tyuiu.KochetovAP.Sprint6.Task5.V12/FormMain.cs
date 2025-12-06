using System;
using System.Windows.Forms;
using System.IO;
using Tyuiu.KochetovAP.Sprint6.Task5.V12.Lib;

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

                allNumbers = ds.LoadFromDataFile(path);
                FilterNumbers();
                DisplayData();
                UpdateChart();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FilterNumbers()
        {
            if (allNumbers == null) return;

            var list = new System.Collections.Generic.List<double>();
            foreach (double num in allNumbers)
            {
                if (Math.Abs(num % 5) > 0.0001)
                    list.Add(num);
            }
            filteredNumbers = list.ToArray();
        }

        private void DisplayData()
        {
            dataGridViewShowAll_KAP.Rows.Clear();
            dataGridViewShowAll_KAP.Columns.Clear();

            dataGridViewShowAll_KAP.Columns.Add("Index", "№");
            dataGridViewShowAll_KAP.Columns.Add("Value", "Значение");

            for (int i = 0; i < allNumbers.Length; i++)
            {
                dataGridViewShowAll_KAP.Rows.Add(i + 1, allNumbers[i].ToString("F3"));
            }

            textBoxShowFiltered_KAP.Clear();
            for (int i = 0; i < filteredNumbers.Length; i++)
            {
                textBoxShowFiltered_KAP.AppendText($"[{i}] = {filteredNumbers[i]:F3}\r\n");
            }
        }

        private void UpdateChart()
        {
            chartDisplayNumbers_KAP.Series[0].Points.Clear();
            for (int i = 0; i < filteredNumbers.Length; i++)
            {
                chartDisplayNumbers_KAP.Series[0].Points.AddXY(i + 1, filteredNumbers[i]);
            }
        }

        private void buttonSaveResult_KAP_Click(object sender, EventArgs e)
        {
            if (filteredNumbers == null || filteredNumbers.Length == 0)
            {
                MessageBox.Show("Нет данных для сохранения", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string path = @"C:\DataSprint6\OutPutFileTask5V12.txt";
                using (StreamWriter writer = new StreamWriter(path))
                {
                    for (int i = 0; i < filteredNumbers.Length; i++)
                    {
                        writer.WriteLine($"[{i}] = {filteredNumbers[i]:F3}");
                    }
                }
                MessageBox.Show($"Сохранено в: {path}", "Сохранено", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonShowHelp_KAP_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Спринт 6 | Таск 5 | Вариант 12\nЗагрузка файла -> Фильтрация -> Диаграмма\nКочетов А.П.",
                "Справка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
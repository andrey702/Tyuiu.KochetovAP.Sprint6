using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Tyuiu.KochetovAP.Sprint6.Task7.V14.Lib;

namespace Tyuiu.KochetovAP.Sprint6.Task7.V14
{
    public partial class FormMain : Form
    {
        private DataService dataService;
        private int[,] matrix;
        private string openFilePath;

        public FormMain()
        {
            InitializeComponent();
            dataService = new DataService();
        }

        private void buttonOpenFile_КAP_Click(object sender, EventArgs e)
        {
            openFileDialogTask_КAP.Filter = "CSV файлы (*.csv)|*.csv|Все файлы (*.*)|*.*";
            openFileDialogTask_КAP.FileName = "InPutFileTask7V14.csv";
            openFileDialogTask_КAP.InitialDirectory = @"C:\DataSprint6";

            if (openFileDialogTask_КAP.ShowDialog() == DialogResult.OK)
            {
                openFilePath = openFileDialogTask_КAP.FileName;
                textBoxLoadFile_КAP.Text = openFilePath;

                try
                {
                    LoadDataToGrid(openFilePath, dataGridViewInput_КAP);
                    matrix = dataService.GetMatrix(openFilePath);
                    DisplayMatrix(matrix, dataGridViewOutput_КAP);
                    HighlightSecondRow(dataGridViewOutput_КAP);

                    buttonProcess_КAP.Enabled = true;
                    buttonSaveFile_КAP.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void LoadDataToGrid(string filePath, DataGridView dgv)
        {
            dgv.Rows.Clear();
            dgv.Columns.Clear();

            string[] lines = File.ReadAllLines(filePath);

            int columns = lines[0].Split(';').Length;

            for (int i = 0; i < columns; i++)
            {
                dgv.Columns.Add($"col{i}", $"Столбец {i + 1}");
                dgv.Columns[i].Width = 50;
            }

            foreach (string line in lines)
            {
                string[] values = line.Split(';');
                dgv.Rows.Add(values);
            }
        }

        private void DisplayMatrix(int[,] matrix, DataGridView dgv)
        {
            dgv.Rows.Clear();
            dgv.Columns.Clear();

            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);

            for (int i = 0; i < columns; i++)
            {
                dgv.Columns.Add($"col{i}", $"Столбец {i + 1}");
                dgv.Columns[i].Width = 50;
            }

            for (int i = 0; i < rows; i++)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dgv);

                for (int j = 0; j < columns; j++)
                {
                    row.Cells[j].Value = matrix[i, j];
                }

                dgv.Rows.Add(row);
            }
        }

        private void HighlightSecondRow(DataGridView dgv)
        {
            if (dgv.Rows.Count > 1)
            {
                dgv.Rows[1].DefaultCellStyle.BackColor = Color.LightGreen;
                dgv.Rows[1].DefaultCellStyle.Font = new Font(dgv.Font, FontStyle.Bold);
            }
        }

        private void buttonProcess_КAP_Click(object sender, EventArgs e)
        {
            if (matrix != null)
            {
                DisplayMatrix(matrix, dataGridViewOutput_КAP);
                HighlightSecondRow(dataGridViewOutput_КAP);
                MessageBox.Show("Матрица успешно обработана!", "Информация",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonSaveFile_КAP_Click(object sender, EventArgs e)
        {
            if (matrix == null)
            {
                MessageBox.Show("Нет данных для сохранения", "Предупреждение",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            saveFileDialogOutput_КAP.Filter = "CSV файлы (*.csv)|*.csv|Все файлы (*.*)|*.*";
            saveFileDialogOutput_КAP.FileName = "OutPutFileTask7.csv";
            saveFileDialogOutput_КAP.InitialDirectory = @"C:\DataSprint6";

            if (saveFileDialogOutput_КAP.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    SaveMatrixToFile(matrix, saveFileDialogOutput_КAP.FileName);
                    MessageBox.Show("Файл успешно сохранен!", "Информация",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при сохранении: {ex.Message}", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void SaveMatrixToFile(int[,] matrix, string filePath)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                int rows = matrix.GetLength(0);
                int columns = matrix.GetLength(1);

                for (int i = 0; i < rows; i++)
                {
                    string[] rowValues = new string[columns];
                    for (int j = 0; j < columns; j++)
                    {
                        rowValues[j] = matrix[i, j].ToString();
                    }
                    writer.WriteLine(string.Join(";", rowValues));
                }
            }
        }

        private void buttonHelp_КAP_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Задание выполнил студент группы ИБКСб-25-1 Кочетов Андрей Павлович\n\n" +
                "Задание: Загрузить матрицу из CSV файла, изменить во второй строке\n" +
                "четные элементы на 44, вывести результат и сохранить в файл.",
                "Справка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonExit_КAP_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

using System;
using System.Windows.Forms;
using Tyuiu.KochetovAP.Sprint6.Task6.V1.Lib;

namespace Tyuiu.KochetovAP.Sprint6.Task6.V1
{
    public partial class FormMain : Form
    {
        private DataService ds = new DataService();

        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonOpenFile_KAP_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.InitialDirectory = @"C:\DataSprint6\";
                openFileDialog.Title = "Выберите файл";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    textBoxShowPath_KAP.Text = filePath;

                    textBoxShowInput_KAP.Text = System.IO.File.ReadAllText(filePath);

                    string result = ds.CollectTextFromFile(filePath);
                    textBoxShowOutput_KAP.Text = result;

                    labelShowStatus_KAP.Text = "Файл обработан";
                    labelShowStatus_KAP.ForeColor = System.Drawing.Color.Green;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                labelShowStatus_KAP.Text = "Ошибка";
                labelShowStatus_KAP.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void buttonSaveResult_KAP_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxShowOutput_KAP.Text))
            {
                MessageBox.Show("Нет данных для сохранения", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                saveFileDialog.FileName = "OutPutFileTask6V1.txt";
                saveFileDialog.InitialDirectory = @"C:\DataSprint6\";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    System.IO.File.WriteAllText(saveFileDialog.FileName, textBoxShowOutput_KAP.Text);
                    MessageBox.Show($"Сохранено: {saveFileDialog.FileName}",
                        "Сохранено", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonShowHelp_KAP_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Спринт 6 | Таск 6 | Вариант 1\n" +
                          "Из каждой строки файла берется первое слово\n" +
                          "Все первые слова объединяются в одну строку\n" +
                          "Кочетов А.П.",
                "Справка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
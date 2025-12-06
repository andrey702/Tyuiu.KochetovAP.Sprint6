using System;
using System.Drawing;
using System.Windows.Forms;
using Tyuiu.KochetovAP.Sprint6.Task4.V13.Lib;

namespace Tyuiu.KochetovAP.Sprint6.Task4.V13
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonCalculate_KAP_Click(object sender, EventArgs e)
        {
            try
            {
                DataService ds = new DataService();

                int startValue = -5;
                int stopValue = 5;

                double[] values = ds.GetMassFunction(startValue, stopValue);

                textBoxOutput_KAP.Text = "Табуляция функции F(x) = 3x + 2 - (2x - x)/(cos(x) + 1)\r\n";
                textBoxOutput_KAP.AppendText($"Диапазон: [{startValue}; {stopValue}], шаг: 1\r\n");
                textBoxOutput_KAP.AppendText(new string('-', 50) + "\r\n");

                for (int i = 0; i < values.Length; i++)
                {
                    int x = startValue + i;
                    textBoxOutput_KAP.AppendText($"x = {x,3} | F(x) = {values[i],8:F2}\r\n");
                }

                textBoxOutput_KAP.AppendText(new string('-', 50) + "\r\n");
                textBoxOutput_KAP.AppendText($"Всего значений: {values.Length}\r\n");

                chartFunction_KAP.Series[0].Points.Clear();
                for (int i = 0; i < values.Length; i++)
                {
                    int x = startValue + i;
                    chartFunction_KAP.Series[0].Points.AddXY(x, values[i]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSaveData_KAP_Click(object sender, EventArgs e)
        {
            try
            {
                DataService ds = new DataService();
                ds.SaveToFile("OutPutFileTask4V13.txt", -5, 5);

                MessageBox.Show("Данные сохранены в файл C:\\DataSprint6\\OutPutFileTask4V13.txt",
                    "Сохранение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonShowHelp_KAP_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Табулирование функции F(x) = 3x + 2 - (2x - x)/(cos(x) + 1)\r\n" +
                           "Диапазон: [-5; 5], шаг: 1\r\n" +
                           "Выполнил: Кочетов А.П. | Группа: ИИПб-23-1",
                           "Справка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
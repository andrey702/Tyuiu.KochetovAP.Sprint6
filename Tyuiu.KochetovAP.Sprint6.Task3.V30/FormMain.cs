using System;
using System.Windows.Forms;
using Tyuiu.KochetovAP.Sprint6.Task3.V30.Lib;

namespace Tyuiu.KochetovAP.Sprint6.Task3.V30
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            dataGridViewMatrix_KAP.ColumnCount = 5;
            dataGridViewMatrix_KAP.RowCount = 5;
            dataGridViewMatrix_KAP.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void buttonExecute_KAP_Click(object sender, EventArgs e)
        {
            try
            {

                int[,] matrix = {
                    { -9,  -4,  17,  -1, -20 },
                    { -19,  18,  -4,   2,  14 },
                    { -12,  16,  -2,   7,  18 },
                    { -16,  15,   4, -12, -13 },
                    { -15,  -4, -16,   1, -14 }
                };


                DataService ds = new DataService();
                int[,] resultMatrix = ds.Calculate(matrix);


                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        dataGridViewMatrix_KAP.Rows[i].Cells[j].Value = resultMatrix[i, j];
                    }
                }

                for (int j = 0; j < 5; j++)
                {
                    if (resultMatrix[4, j] == 0)
                    {
                        dataGridViewMatrix_KAP.Rows[4].Cells[j].Style.BackColor = System.Drawing.Color.LightGreen;
                    }
                }

                labelInfo_KAP.Text = "Замена выполнена успешно! Четные значения в пятой строке заменены на 0.";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_KAP_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнил студент группы ИБКСб-25-1 Кочетов Андрей Павлович.\n" +
                "Дан массив 5 на 5 элементов. Заменить четные значения в пятой строке на 0.",
                "Справка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
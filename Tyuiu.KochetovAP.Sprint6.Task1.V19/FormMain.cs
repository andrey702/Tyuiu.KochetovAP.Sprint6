using System;
using System.Windows.Forms;
using Tyuiu.KochetovAP.Sprint6.Task1.V19.Lib;

namespace Tyuiu.KochetovAP.Sprint6.Task1.V19
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonStart_KAP_Click(object sender, EventArgs e)
        {
            try
            {
                DataService ds = new DataService();
                int startValue = -5;
                int stopValue = 5;

                double[] resultArray = ds.GetMassFunction(startValue, stopValue);

                textBoxResult_KAP.Text = "";

                for (int i = 0; i < resultArray.Length; i++)
                {
                    int x = startValue + i;
                    double y = resultArray[i];

                    textBoxResult_KAP.AppendText($"x = {x,3} | f(x) = {y,7:F2}");
                    textBoxResult_KAP.AppendText(Environment.NewLine);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_KAP_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнил студент группы ИБКСб-25-1 Кочетов Андрей Павлович",
                "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

            textBoxResult_KAP.Font = new System.Drawing.Font("Consolas", 10f);
            textBoxResult_KAP.ReadOnly = true;
        }
    }
}
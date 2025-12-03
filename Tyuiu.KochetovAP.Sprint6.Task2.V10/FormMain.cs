using System;
using System.Windows.Forms;
using Tyuiu.KochetovAP.Sprint6.Task2.V10.Lib;

namespace Tyuiu.KochetovAP.Sprint6.Task2.V10
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonStart_KAP_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;

            double[] result = ds.GetMassFunction(startValue, stopValue);

            dataGridViewResult_KAP.Rows.Clear();

            for (int i = 0; i < result.Length; i++)
            {
                int x = startValue + i;
                dataGridViewResult_KAP.Rows.Add(x, result[i]);
            }
        }

        private void buttonHelp_KAP_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 выполнил студент группы ИБКСб-25-1 Кочетов Андрей Павлович", "Справка");
        }
    }
}
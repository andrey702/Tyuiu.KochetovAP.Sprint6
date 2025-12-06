namespace Tyuiu.KochetovAP.Sprint6.Task5.V12
{
    partial class FormMain
    {
        private System.ComponentModel.IContainer components = null;

        private Button buttonLoadFile_KAP;
        private Button buttonSaveResult_KAP;
        private Button buttonShowHelp_KAP;
        private DataGridView dataGridViewShowAll_KAP;
        private TextBox textBoxShowFiltered_KAP;
        private Chart chartDisplayNumbers_KAP;
        private Label labelAllNumbers_KAP;
        private Label labelFilteredNumbers_KAP;
        private Label labelChartTitle_KAP;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();

            this.buttonLoadFile_KAP = new System.Windows.Forms.Button();
            this.buttonSaveResult_KAP = new System.Windows.Forms.Button();
            this.buttonShowHelp_KAP = new System.Windows.Forms.Button();
            this.dataGridViewShowAll_KAP = new System.Windows.Forms.DataGridView();
            this.textBoxShowFiltered_KAP = new System.Windows.Forms.TextBox();
            this.chartDisplayNumbers_KAP = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labelAllNumbers_KAP = new System.Windows.Forms.Label();
            this.labelFilteredNumbers_KAP = new System.Windows.Forms.Label();
            this.labelChartTitle_KAP = new System.Windows.Forms.Label();

            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShowAll_KAP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDisplayNumbers_KAP)).BeginInit();
            this.SuspendLayout();

            // buttonLoadFile_KAP
            this.buttonLoadFile_KAP.BackColor = System.Drawing.Color.Lime;
            this.buttonLoadFile_KAP.Location = new System.Drawing.Point(12, 12);
            this.buttonLoadFile_KAP.Name = "buttonLoadFile_KAP";
            this.buttonLoadFile_KAP.Size = new System.Drawing.Size(100, 30);
            this.buttonLoadFile_KAP.TabIndex = 0;
            this.buttonLoadFile_KAP.Text = "Загрузить";
            this.buttonLoadFile_KAP.UseVisualStyleBackColor = false;
            this.buttonLoadFile_KAP.Click += new System.EventHandler(this.buttonLoadFile_KAP_Click);

            // buttonSaveResult_KAP
            this.buttonSaveResult_KAP.BackColor = System.Drawing.Color.Blue;
            this.buttonSaveResult_KAP.ForeColor = System.Drawing.Color.White;
            this.buttonSaveResult_KAP.Location = new System.Drawing.Point(118, 12);
            this.buttonSaveResult_KAP.Name = "buttonSaveResult_KAP";
            this.buttonSaveResult_KAP.Size = new System.Drawing.Size(100, 30);
            this.buttonSaveResult_KAP.TabIndex = 1;
            this.buttonSaveResult_KAP.Text = "Сохранить";
            this.buttonSaveResult_KAP.UseVisualStyleBackColor = false;
            this.buttonSaveResult_KAP.Click += new System.EventHandler(this.buttonSaveResult_KAP_Click);

            // buttonShowHelp_KAP
            this.buttonShowHelp_KAP.BackColor = System.Drawing.Color.Gray;
            this.buttonShowHelp_KAP.ForeColor = System.Drawing.Color.White;
            this.buttonShowHelp_KAP.Location = new System.Drawing.Point(224, 12);
            this.buttonShowHelp_KAP.Name = "buttonShowHelp_KAP";
            this.buttonShowHelp_KAP.Size = new System.Drawing.Size(80, 30);
            this.buttonShowHelp_KAP.TabIndex = 2;
            this.buttonShowHelp_KAP.Text = "Справка";
            this.buttonShowHelp_KAP.UseVisualStyleBackColor = false;
            this.buttonShowHelp_KAP.Click += new System.EventHandler(this.buttonShowHelp_KAP_Click);

            // dataGridViewShowAll_KAP
            this.dataGridViewShowAll_KAP.AllowUserToAddRows = false;
            this.dataGridViewShowAll_KAP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewShowAll_KAP.Location = new System.Drawing.Point(12, 80);
            this.dataGridViewShowAll_KAP.Name = "dataGridViewShowAll_KAP";
            this.dataGridViewShowAll_KAP.ReadOnly = true;
            this.dataGridViewShowAll_KAP.Size = new System.Drawing.Size(300, 250);
            this.dataGridViewShowAll_KAP.TabIndex = 3;

            // textBoxShowFiltered_KAP
            this.textBoxShowFiltered_KAP.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxShowFiltered_KAP.Location = new System.Drawing.Point(12, 360);
            this.textBoxShowFiltered_KAP.Multiline = true;
            this.textBoxShowFiltered_KAP.Name = "textBoxShowFiltered_KAP";
            this.textBoxShowFiltered_KAP.ReadOnly = true;
            this.textBoxShowFiltered_KAP.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxShowFiltered_KAP.Size = new System.Drawing.Size(300, 200);
            this.textBoxShowFiltered_KAP.TabIndex = 4;

            // chartDisplayNumbers_KAP
            this.chartDisplayNumbers_KAP.BackColor = System.Drawing.Color.WhiteSmoke;
            chartArea1.Name = "ChartArea1";
            this.chartDisplayNumbers_KAP.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartDisplayNumbers_KAP.Legends.Add(legend1);
            this.chartDisplayNumbers_KAP.Location = new System.Drawing.Point(320, 80);
            this.chartDisplayNumbers_KAP.Name = "chartDisplayNumbers_KAP";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartDisplayNumbers_KAP.Series.Add(series1);
            this.chartDisplayNumbers_KAP.Size = new System.Drawing.Size(450, 480);
            this.chartDisplayNumbers_KAP.TabIndex = 5;

            // labelAllNumbers_KAP
            this.labelAllNumbers_KAP.AutoSize = true;
            this.labelAllNumbers_KAP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAllNumbers_KAP.Location = new System.Drawing.Point(12, 60);
            this.labelAllNumbers_KAP.Name = "labelAllNumbers_KAP";
            this.labelAllNumbers_KAP.Size = new System.Drawing.Size(97, 15);
            this.labelAllNumbers_KAP.TabIndex = 6;
            this.labelAllNumbers_KAP.Text = "Все числа:";

            // labelFilteredNumbers_KAP
            this.labelFilteredNumbers_KAP.AutoSize = true;
            this.labelFilteredNumbers_KAP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFilteredNumbers_KAP.Location = new System.Drawing.Point(12, 340);
            this.labelFilteredNumbers_KAP.Name = "labelFilteredNumbers_KAP";
            this.labelFilteredNumbers_KAP.Size = new System.Drawing.Size(114, 15);
            this.labelFilteredNumbers_KAP.TabIndex = 7;
            this.labelFilteredNumbers_KAP.Text = "Не кратные 5:";

            // labelChartTitle_KAP
            this.labelChartTitle_KAP.AutoSize = true;
            this.labelChartTitle_KAP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelChartTitle_KAP.Location = new System.Drawing.Point(320, 60);
            this.labelChartTitle_KAP.Name = "labelChartTitle_KAP";
            this.labelChartTitle_KAP.Size = new System.Drawing.Size(77, 15);
            this.labelChartTitle_KAP.TabIndex = 8;
            this.labelChartTitle_KAP.Text = "Диаграмма";

            // FormMain
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 572);
            this.Controls.Add(this.labelChartTitle_KAP);
            this.Controls.Add(this.labelFilteredNumbers_KAP);
            this.Controls.Add(this.labelAllNumbers_KAP);
            this.Controls.Add(this.chartDisplayNumbers_KAP);
            this.Controls.Add(this.textBoxShowFiltered_KAP);
            this.Controls.Add(this.dataGridViewShowAll_KAP);
            this.Controls.Add(this.buttonShowHelp_KAP);
            this.Controls.Add(this.buttonSaveResult_KAP);
            this.Controls.Add(this.buttonLoadFile_KAP);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 5 | Вариант 12 | Кочетов А.П.";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShowAll_KAP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDisplayNumbers_KAP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
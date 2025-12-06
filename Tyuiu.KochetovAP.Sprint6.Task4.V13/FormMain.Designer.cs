namespace Tyuiu.KochetovAP.Sprint6.Task4.V13
{
    partial class FormMain
    {
        private System.ComponentModel.IContainer components = null;

        private Button buttonCalculate_KAP;
        private Button buttonSaveData_KAP;
        private Button buttonShowHelp_KAP;
        private TextBox textBoxOutput_KAP;
        private Chart chartFunction_KAP;
        private Label labelTaskInfo_KAP;

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
            this.buttonCalculate_KAP = new System.Windows.Forms.Button();
            this.buttonSaveData_KAP = new System.Windows.Forms.Button();
            this.buttonShowHelp_KAP = new System.Windows.Forms.Button();
            this.textBoxOutput_KAP = new System.Windows.Forms.TextBox();
            this.chartFunction_KAP = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labelTaskInfo_KAP = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_KAP)).BeginInit();
            this.SuspendLayout();

            // buttonCalculate_KAP
            this.buttonCalculate_KAP.BackColor = System.Drawing.Color.Lime;
            this.buttonCalculate_KAP.Location = new System.Drawing.Point(12, 60);
            this.buttonCalculate_KAP.Name = "buttonCalculate_KAP";
            this.buttonCalculate_KAP.Size = new System.Drawing.Size(120, 40);
            this.buttonCalculate_KAP.TabIndex = 0;
            this.buttonCalculate_KAP.Text = "Выполнить";
            this.buttonCalculate_KAP.UseVisualStyleBackColor = false;
            this.buttonCalculate_KAP.Click += new System.EventHandler(this.buttonCalculate_KAP_Click);

            // buttonSaveData_KAP
            this.buttonSaveData_KAP.BackColor = System.Drawing.Color.Blue;
            this.buttonSaveData_KAP.ForeColor = System.Drawing.Color.White;
            this.buttonSaveData_KAP.Location = new System.Drawing.Point(150, 60);
            this.buttonSaveData_KAP.Name = "buttonSaveData_KAP";
            this.buttonSaveData_KAP.Size = new System.Drawing.Size(120, 40);
            this.buttonSaveData_KAP.TabIndex = 1;
            this.buttonSaveData_KAP.Text = "Сохранить";
            this.buttonSaveData_KAP.UseVisualStyleBackColor = false;
            this.buttonSaveData_KAP.Click += new System.EventHandler(this.buttonSaveData_KAP_Click);

            // buttonShowHelp_KAP
            this.buttonShowHelp_KAP.BackColor = System.Drawing.Color.Gray;
            this.buttonShowHelp_KAP.Location = new System.Drawing.Point(290, 60);
            this.buttonShowHelp_KAP.Name = "buttonShowHelp_KAP";
            this.buttonShowHelp_KAP.Size = new System.Drawing.Size(120, 40);
            this.buttonShowHelp_KAP.TabIndex = 2;
            this.buttonShowHelp_KAP.Text = "Справка";
            this.buttonShowHelp_KAP.UseVisualStyleBackColor = false;
            this.buttonShowHelp_KAP.Click += new System.EventHandler(this.buttonShowHelp_KAP_Click);

            // textBoxOutput_KAP
            this.textBoxOutput_KAP.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxOutput_KAP.Location = new System.Drawing.Point(12, 120);
            this.textBoxOutput_KAP.Multiline = true;
            this.textBoxOutput_KAP.Name = "textBoxOutput_KAP";
            this.textBoxOutput_KAP.ReadOnly = true;
            this.textBoxOutput_KAP.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxOutput_KAP.Size = new System.Drawing.Size(400, 300);
            this.textBoxOutput_KAP.TabIndex = 3;

            // chartFunction_KAP
            this.chartFunction_KAP.BorderlineColor = System.Drawing.Color.Black;
            this.chartFunction_KAP.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea1.Name = "ChartArea1";
            this.chartFunction_KAP.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartFunction_KAP.Legends.Add(legend1);
            this.chartFunction_KAP.Location = new System.Drawing.Point(430, 120);
            this.chartFunction_KAP.Name = "chartFunction_KAP";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "F(x)";
            this.chartFunction_KAP.Series.Add(series1);
            this.chartFunction_KAP.Size = new System.Drawing.Size(400, 300);
            this.chartFunction_KAP.TabIndex = 4;
            this.chartFunction_KAP.Text = "chartFunction_KAP";

            // labelTaskInfo_KAP
            this.labelTaskInfo_KAP.AutoSize = true;
            this.labelTaskInfo_KAP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTaskInfo_KAP.Location = new System.Drawing.Point(12, 20);
            this.labelTaskInfo_KAP.Name = "labelTaskInfo_KAP";
            this.labelTaskInfo_KAP.Size = new System.Drawing.Size(700, 20);
            this.labelTaskInfo_KAP.TabIndex = 5;
            this.labelTaskInfo_KAP.Text = "Табулирование функции F(x) = 3x + 2 - (2x - x)/(cos(x) + 1) на диапазоне [-5; 5] с шагом 1";

            // FormMain
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 450);
            this.Controls.Add(this.labelTaskInfo_KAP);
            this.Controls.Add(this.chartFunction_KAP);
            this.Controls.Add(this.textBoxOutput_KAP);
            this.Controls.Add(this.buttonShowHelp_KAP);
            this.Controls.Add(this.buttonSaveData_KAP);
            this.Controls.Add(this.buttonCalculate_KAP);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 4 | Вариант 13 | Кочетов А.П.";
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_KAP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
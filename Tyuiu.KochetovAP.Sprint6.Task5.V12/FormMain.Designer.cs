namespace Tyuiu.KochetovAP.Sprint6.Task5.V12
{
    partial class FormMain
    {
        private System.ComponentModel.IContainer components = null;

        private Button buttonLoadFile_KAP;
        private Button buttonSaveResult_KAP;
        private Button buttonShowHelp_KAP;
        private Button buttonCreateFile_KAP;
        private DataGridView dataGridViewShowAll_KAP;
        private TextBox textBoxShowFiltered_KAP;
        private Chart chartDisplayNumbers_KAP;
        private Label labelShowStatus_KAP;
        private Label labelTitleAll_KAP;
        private Label labelTitleFiltered_KAP;
        private Label labelTitleChart_KAP;
        private Panel panelControl_KAP;

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
            this.buttonCreateFile_KAP = new System.Windows.Forms.Button();
            this.dataGridViewShowAll_KAP = new System.Windows.Forms.DataGridView();
            this.textBoxShowFiltered_KAP = new System.Windows.Forms.TextBox();
            this.chartDisplayNumbers_KAP = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labelShowStatus_KAP = new System.Windows.Forms.Label();
            this.labelTitleAll_KAP = new System.Windows.Forms.Label();
            this.labelTitleFiltered_KAP = new System.Windows.Forms.Label();
            this.labelTitleChart_KAP = new System.Windows.Forms.Label();
            this.panelControl_KAP = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShowAll_KAP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDisplayNumbers_KAP)).BeginInit();
            this.panelControl_KAP.SuspendLayout();
            this.SuspendLayout();

            // panelControl_KAP
            this.panelControl_KAP.BackColor = System.Drawing.Color.LightGray;
            this.panelControl_KAP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelControl_KAP.Controls.Add(this.buttonCreateFile_KAP);
            this.panelControl_KAP.Controls.Add(this.labelShowStatus_KAP);
            this.panelControl_KAP.Controls.Add(this.buttonLoadFile_KAP);
            this.panelControl_KAP.Controls.Add(this.buttonSaveResult_KAP);
            this.panelControl_KAP.Controls.Add(this.buttonShowHelp_KAP);
            this.panelControl_KAP.Location = new System.Drawing.Point(12, 12);
            this.panelControl_KAP.Name = "panelControl_KAP";
            this.panelControl_KAP.Size = new System.Drawing.Size(860, 80);
            this.panelControl_KAP.TabIndex = 0;

            // buttonLoadFile_KAP
            this.buttonLoadFile_KAP.BackColor = System.Drawing.Color.Lime;
            this.buttonLoadFile_KAP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLoadFile_KAP.Location = new System.Drawing.Point(10, 40);
            this.buttonLoadFile_KAP.Name = "buttonLoadFile_KAP";
            this.buttonLoadFile_KAP.Size = new System.Drawing.Size(120, 30);
            this.buttonLoadFile_KAP.TabIndex = 0;
            this.buttonLoadFile_KAP.Text = "Загрузить файл";
            this.buttonLoadFile_KAP.UseVisualStyleBackColor = false;
            this.buttonLoadFile_KAP.Click += new System.EventHandler(this.buttonLoadFile_KAP_Click);

            // buttonSaveResult_KAP
            this.buttonSaveResult_KAP.BackColor = System.Drawing.Color.Blue;
            this.buttonSaveResult_KAP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSaveResult_KAP.ForeColor = System.Drawing.Color.White;
            this.buttonSaveResult_KAP.Location = new System.Drawing.Point(140, 40);
            this.buttonSaveResult_KAP.Name = "buttonSaveResult_KAP";
            this.buttonSaveResult_KAP.Size = new System.Drawing.Size(120, 30);
            this.buttonSaveResult_KAP.TabIndex = 1;
            this.buttonSaveResult_KAP.Text = "Сохранить результат";
            this.buttonSaveResult_KAP.UseVisualStyleBackColor = false;
            this.buttonSaveResult_KAP.Click += new System.EventHandler(this.buttonSaveResult_KAP_Click);

            // buttonShowHelp_KAP
            this.buttonShowHelp_KAP.BackColor = System.Drawing.Color.Gray;
            this.buttonShowHelp_KAP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonShowHelp_KAP.ForeColor = System.Drawing.Color.White;
            this.buttonShowHelp_KAP.Location = new System.Drawing.Point(270, 40);
            this.buttonShowHelp_KAP.Name = "buttonShowHelp_KAP";
            this.buttonShowHelp_KAP.Size = new System.Drawing.Size(80, 30);
            this.buttonShowHelp_KAP.TabIndex = 2;
            this.buttonShowHelp_KAP.Text = "Справка";
            this.buttonShowHelp_KAP.UseVisualStyleBackColor = false;
            this.buttonShowHelp_KAP.Click += new System.EventHandler(this.buttonShowHelp_KAP_Click);

            // buttonCreateFile_KAP
            this.buttonCreateFile_KAP.BackColor = System.Drawing.Color.Orange;
            this.buttonCreateFile_KAP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCreateFile_KAP.Location = new System.Drawing.Point(360, 40);
            this.buttonCreateFile_KAP.Name = "buttonCreateFile_KAP";
            this.buttonCreateFile_KAP.Size = new System.Drawing.Size(120, 30);
            this.buttonCreateFile_KAP.TabIndex = 3;
            this.buttonCreateFile_KAP.Text = "Создать файл";
            this.buttonCreateFile_KAP.UseVisualStyleBackColor = false;
            this.buttonCreateFile_KAP.Click += new System.EventHandler(this.buttonCreateFile_KAP_Click);

            // labelShowStatus_KAP
            this.labelShowStatus_KAP.AutoSize = true;
            this.labelShowStatus_KAP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelShowStatus_KAP.Location = new System.Drawing.Point(10, 13);
            this.labelShowStatus_KAP.Name = "labelShowStatus_KAP";
            this.labelShowStatus_KAP.Size = new System.Drawing.Size(121, 15);
            this.labelShowStatus_KAP.TabIndex = 4;
            this.labelShowStatus_KAP.Text = "Статус файла: ...";

            // dataGridViewShowAll_KAP
            this.dataGridViewShowAll_KAP.AllowUserToAddRows = false;
            this.dataGridViewShowAll_KAP.AllowUserToDeleteRows = false;
            this.dataGridViewShowAll_KAP.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewShowAll_KAP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewShowAll_KAP.Location = new System.Drawing.Point(12, 120);
            this.dataGridViewShowAll_KAP.Name = "dataGridViewShowAll_KAP";
            this.dataGridViewShowAll_KAP.ReadOnly = true;
            this.dataGridViewShowAll_KAP.RowHeadersVisible = false;
            this.dataGridViewShowAll_KAP.Size = new System.Drawing.Size(400, 250);
            this.dataGridViewShowAll_KAP.TabIndex = 1;

            // textBoxShowFiltered_KAP
            this.textBoxShowFiltered_KAP.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxShowFiltered_KAP.Location = new System.Drawing.Point(12, 410);
            this.textBoxShowFiltered_KAP.Multiline = true;
            this.textBoxShowFiltered_KAP.Name = "textBoxShowFiltered_KAP";
            this.textBoxShowFiltered_KAP.ReadOnly = true;
            this.textBoxShowFiltered_KAP.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxShowFiltered_KAP.Size = new System.Drawing.Size(400, 200);
            this.textBoxShowFiltered_KAP.TabIndex = 2;

            // chartDisplayNumbers_KAP
            this.chartDisplayNumbers_KAP.BackColor = System.Drawing.Color.WhiteSmoke;
            chartArea1.Name = "ChartArea1";
            this.chartDisplayNumbers_KAP.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartDisplayNumbers_KAP.Legends.Add(legend1);
            this.chartDisplayNumbers_KAP.Location = new System.Drawing.Point(430, 120);
            this.chartDisplayNumbers_KAP.Name = "chartDisplayNumbers_KAP";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartDisplayNumbers_KAP.Series.Add(series1);
            this.chartDisplayNumbers_KAP.Size = new System.Drawing.Size(442, 490);
            this.chartDisplayNumbers_KAP.TabIndex = 3;
            this.chartDisplayNumbers_KAP.Text = "chartDisplayNumbers_KAP";

            // labelTitleAll_KAP
            this.labelTitleAll_KAP.AutoSize = true;
            this.labelTitleAll_KAP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTitleAll_KAP.Location = new System.Drawing.Point(12, 100);
            this.labelTitleAll_KAP.Name = "labelTitleAll_KAP";
            this.labelTitleAll_KAP.Size = new System.Drawing.Size(132, 15);
            this.labelTitleAll_KAP.TabIndex = 4;
            this.labelTitleAll_KAP.Text = "Все числа из файла";

            // labelTitleFiltered_KAP
            this.labelTitleFiltered_KAP.AutoSize = true;
            this.labelTitleFiltered_KAP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTitleFiltered_KAP.Location = new System.Drawing.Point(12, 390);
            this.labelTitleFiltered_KAP.Name = "labelTitleFiltered_KAP";
            this.labelTitleFiltered_KAP.Size = new System.Drawing.Size(131, 15);
            this.labelTitleFiltered_KAP.TabIndex = 5;
            this.labelTitleFiltered_KAP.Text = "Числа не кратные 5";

            // labelTitleChart_KAP
            this.labelTitleChart_KAP.AutoSize = true;
            this.labelTitleChart_KAP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTitleChart_KAP.Location = new System.Drawing.Point(430, 100);
            this.labelTitleChart_KAP.Name = "labelTitleChart_KAP";
            this.labelTitleChart_KAP.Size = new System.Drawing.Size(70, 15);
            this.labelTitleChart_KAP.TabIndex = 6;
            this.labelTitleChart_KAP.Text = "Диаграмма";

            // FormMain
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 622);
            this.Controls.Add(this.labelTitleChart_KAP);
            this.Controls.Add(this.labelTitleFiltered_KAP);
            this.Controls.Add(this.labelTitleAll_KAP);
            this.Controls.Add(this.chartDisplayNumbers_KAP);
            this.Controls.Add(this.textBoxShowFiltered_KAP);
            this.Controls.Add(this.dataGridViewShowAll_KAP);
            this.Controls.Add(this.panelControl_KAP);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 5 | Вариант 12 | Кочетов А.П.";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShowAll_KAP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDisplayNumbers_KAP)).EndInit();
            this.panelControl_KAP.ResumeLayout(false);
            this.panelControl_KAP.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
namespace Tyuiu.KochetovAP.Sprint6.Task6.V1
{
    partial class FormMain
    {
        private System.ComponentModel.IContainer components = null;

        private Button buttonOpenFile_KAP;
        private Button buttonSaveResult_KAP;
        private Button buttonShowHelp_KAP;
        private TextBox textBoxShowInput_KAP;
        private TextBox textBoxShowOutput_KAP;
        private TextBox textBoxShowPath_KAP;
        private Label labelShowPath_KAP;
        private Label labelShowInput_KAP;
        private Label labelShowOutput_KAP;
        private Label labelShowStatus_KAP;
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
            this.buttonOpenFile_KAP = new System.Windows.Forms.Button();
            this.buttonSaveResult_KAP = new System.Windows.Forms.Button();
            this.buttonShowHelp_KAP = new System.Windows.Forms.Button();
            this.textBoxShowInput_KAP = new System.Windows.Forms.TextBox();
            this.textBoxShowOutput_KAP = new System.Windows.Forms.TextBox();
            this.textBoxShowPath_KAP = new System.Windows.Forms.TextBox();
            this.labelShowPath_KAP = new System.Windows.Forms.Label();
            this.labelShowInput_KAP = new System.Windows.Forms.Label();
            this.labelShowOutput_KAP = new System.Windows.Forms.Label();
            this.labelShowStatus_KAP = new System.Windows.Forms.Label();
            this.panelControl_KAP = new System.Windows.Forms.Panel();

            this.panelControl_KAP.SuspendLayout();
            this.SuspendLayout();

            // panelControl_KAP
            this.panelControl_KAP.BackColor = System.Drawing.Color.LightGray;
            this.panelControl_KAP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelControl_KAP.Controls.Add(this.labelShowStatus_KAP);
            this.panelControl_KAP.Controls.Add(this.labelShowPath_KAP);
            this.panelControl_KAP.Controls.Add(this.textBoxShowPath_KAP);
            this.panelControl_KAP.Controls.Add(this.buttonOpenFile_KAP);
            this.panelControl_KAP.Controls.Add(this.buttonSaveResult_KAP);
            this.panelControl_KAP.Controls.Add(this.buttonShowHelp_KAP);
            this.panelControl_KAP.Location = new System.Drawing.Point(12, 12);
            this.panelControl_KAP.Name = "panelControl_KAP";
            this.panelControl_KAP.Size = new System.Drawing.Size(760, 80);
            this.panelControl_KAP.TabIndex = 0;

            // buttonOpenFile_KAP
            this.buttonOpenFile_KAP.BackColor = System.Drawing.Color.Lime;
            this.buttonOpenFile_KAP.Location = new System.Drawing.Point(10, 40);
            this.buttonOpenFile_KAP.Name = "buttonOpenFile_KAP";
            this.buttonOpenFile_KAP.Size = new System.Drawing.Size(120, 30);
            this.buttonOpenFile_KAP.TabIndex = 0;
            this.buttonOpenFile_KAP.Text = "Открыть файл";
            this.buttonOpenFile_KAP.UseVisualStyleBackColor = false;
            this.buttonOpenFile_KAP.Click += new System.EventHandler(this.buttonOpenFile_KAP_Click);

            // buttonSaveResult_KAP
            this.buttonSaveResult_KAP.BackColor = System.Drawing.Color.Blue;
            this.buttonSaveResult_KAP.ForeColor = System.Drawing.Color.White;
            this.buttonSaveResult_KAP.Location = new System.Drawing.Point(140, 40);
            this.buttonSaveResult_KAP.Name = "buttonSaveResult_KAP";
            this.buttonSaveResult_KAP.Size = new System.Drawing.Size(120, 30);
            this.buttonSaveResult_KAP.TabIndex = 1;
            this.buttonSaveResult_KAP.Text = "Сохранить";
            this.buttonSaveResult_KAP.UseVisualStyleBackColor = false;
            this.buttonSaveResult_KAP.Click += new System.EventHandler(this.buttonSaveResult_KAP_Click);

            // buttonShowHelp_KAP
            this.buttonShowHelp_KAP.BackColor = System.Drawing.Color.Gray;
            this.buttonShowHelp_KAP.ForeColor = System.Drawing.Color.White;
            this.buttonShowHelp_KAP.Location = new System.Drawing.Point(270, 40);
            this.buttonShowHelp_KAP.Name = "buttonShowHelp_KAP";
            this.buttonShowHelp_KAP.Size = new System.Drawing.Size(80, 30);
            this.buttonShowHelp_KAP.TabIndex = 2;
            this.buttonShowHelp_KAP.Text = "Справка";
            this.buttonShowHelp_KAP.UseVisualStyleBackColor = false;
            this.buttonShowHelp_KAP.Click += new System.EventHandler(this.buttonShowHelp_KAP_Click);

            // textBoxShowPath_KAP
            this.textBoxShowPath_KAP.Location = new System.Drawing.Point(100, 10);
            this.textBoxShowPath_KAP.Name = "textBoxShowPath_KAP";
            this.textBoxShowPath_KAP.ReadOnly = true;
            this.textBoxShowPath_KAP.Size = new System.Drawing.Size(500, 20);
            this.textBoxShowPath_KAP.TabIndex = 3;

            // labelShowPath_KAP
            this.labelShowPath_KAP.AutoSize = true;
            this.labelShowPath_KAP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.labelShowPath_KAP.Location = new System.Drawing.Point(10, 13);
            this.labelShowPath_KAP.Name = "labelShowPath_KAP";
            this.labelShowPath_KAP.Size = new System.Drawing.Size(84, 15);
            this.labelShowPath_KAP.TabIndex = 4;
            this.labelShowPath_KAP.Text = "Путь к файлу:";

            // labelShowStatus_KAP
            this.labelShowStatus_KAP.AutoSize = true;
            this.labelShowStatus_KAP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.labelShowStatus_KAP.Location = new System.Drawing.Point(610, 13);
            this.labelShowStatus_KAP.Name = "labelShowStatus_KAP";
            this.labelShowStatus_KAP.Size = new System.Drawing.Size(124, 15);
            this.labelShowStatus_KAP.TabIndex = 5;
            this.labelShowStatus_KAP.Text = "Статус: не загружен";

            // textBoxShowInput_KAP
            this.textBoxShowInput_KAP.Font = new System.Drawing.Font("Consolas", 9F);
            this.textBoxShowInput_KAP.Location = new System.Drawing.Point(12, 120);
            this.textBoxShowInput_KAP.Multiline = true;
            this.textBoxShowInput_KAP.Name = "textBoxShowInput_KAP";
            this.textBoxShowInput_KAP.ReadOnly = true;
            this.textBoxShowInput_KAP.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxShowInput_KAP.Size = new System.Drawing.Size(370, 400);
            this.textBoxShowInput_KAP.TabIndex = 1;

            // textBoxShowOutput_KAP
            this.textBoxShowOutput_KAP.Font = new System.Drawing.Font("Consolas", 9F);
            this.textBoxShowOutput_KAP.Location = new System.Drawing.Point(402, 120);
            this.textBoxShowOutput_KAP.Multiline = true;
            this.textBoxShowOutput_KAP.Name = "textBoxShowOutput_KAP";
            this.textBoxShowOutput_KAP.ReadOnly = true;
            this.textBoxShowOutput_KAP.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxShowOutput_KAP.Size = new System.Drawing.Size(370, 400);
            this.textBoxShowOutput_KAP.TabIndex = 2;

            // labelShowInput_KAP
            this.labelShowInput_KAP.AutoSize = true;
            this.labelShowInput_KAP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.labelShowInput_KAP.Location = new System.Drawing.Point(12, 100);
            this.labelShowInput_KAP.Name = "labelShowInput_KAP";
            this.labelShowInput_KAP.Size = new System.Drawing.Size(139, 15);
            this.labelShowInput_KAP.TabIndex = 3;
            this.labelShowInput_KAP.Text = "Содержимое файла:";

            // labelShowOutput_KAP
            this.labelShowOutput_KAP.AutoSize = true;
            this.labelShowOutput_KAP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.labelShowOutput_KAP.Location = new System.Drawing.Point(402, 100);
            this.labelShowOutput_KAP.Name = "labelShowOutput_KAP";
            this.labelShowOutput_KAP.Size = new System.Drawing.Size(72, 15);
            this.labelShowOutput_KAP.TabIndex = 4;
            this.labelShowOutput_KAP.Text = "Результат:";

            // FormMain
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 532);
            this.Controls.Add(this.labelShowOutput_KAP);
            this.Controls.Add(this.labelShowInput_KAP);
            this.Controls.Add(this.textBoxShowOutput_KAP);
            this.Controls.Add(this.textBoxShowInput_KAP);
            this.Controls.Add(this.panelControl_KAP);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 6 | Вариант 1 | Кочетов А.П.";
            this.panelControl_KAP.ResumeLayout(false);
            this.panelControl_KAP.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
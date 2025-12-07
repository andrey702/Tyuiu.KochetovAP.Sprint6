namespace Tyuiu.KochetovAP.Sprint6.Task7.V14
{
    partial class FormMain
    {
        private System.ComponentModel.IContainer components = null;

        
        private System.Windows.Forms.DataGridView dataGridViewInput_КAP;
        private System.Windows.Forms.DataGridView dataGridViewOutput_КAP;

        
        private System.Windows.Forms.Button buttonOpenFile_КAP;
        private System.Windows.Forms.Button buttonProcess_КAP;
        private System.Windows.Forms.Button buttonSaveFile_КAP;
        private System.Windows.Forms.Button buttonHelp_КAP;
        private System.Windows.Forms.Button buttonExit_КAP;

        
        private System.Windows.Forms.TextBox textBoxLoadFile_КAP;

        
        private System.Windows.Forms.OpenFileDialog openFileDialogTask_КAP;
        private System.Windows.Forms.SaveFileDialog saveFileDialogOutput_КAP;

        
        private System.Windows.Forms.Label labelInput_КAP;
        private System.Windows.Forms.Label labelOutput_КAP;
        private System.Windows.Forms.Label labelFilePath_КAP;

        
        private System.Windows.Forms.Panel panelControls_КAP;

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
            this.dataGridViewInput_КAP = new System.Windows.Forms.DataGridView();
            this.dataGridViewOutput_КAP = new System.Windows.Forms.DataGridView();
            this.textBoxLoadFile_КAP = new System.Windows.Forms.TextBox();
            this.buttonOpenFile_КAP = new System.Windows.Forms.Button();
            this.buttonProcess_КAP = new System.Windows.Forms.Button();
            this.buttonSaveFile_КAP = new System.Windows.Forms.Button();
            this.buttonHelp_КAP = new System.Windows.Forms.Button();
            this.buttonExit_КAP = new System.Windows.Forms.Button();
            this.openFileDialogTask_КAP = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialogOutput_КAP = new System.Windows.Forms.SaveFileDialog();
            this.labelInput_КAP = new System.Windows.Forms.Label();
            this.labelOutput_КAP = new System.Windows.Forms.Label();
            this.labelFilePath_КAP = new System.Windows.Forms.Label();
            this.panelControls_КAP = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInput_КAP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutput_КAP)).BeginInit();
            this.panelControls_КAP.SuspendLayout();
            this.SuspendLayout();

            
            this.dataGridViewInput_КAP.AllowUserToAddRows = false;
            this.dataGridViewInput_КAP.AllowUserToDeleteRows = false;
            this.dataGridViewInput_КAP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInput_КAP.Location = new System.Drawing.Point(12, 80);
            this.dataGridViewInput_КAP.Name = "dataGridViewInput_КAP";
            this.dataGridViewInput_КAP.ReadOnly = true;
            this.dataGridViewInput_КAP.RowHeadersVisible = false;
            this.dataGridViewInput_КAP.Size = new System.Drawing.Size(380, 300);
            this.dataGridViewInput_КAP.TabIndex = 0;

            
            this.dataGridViewOutput_КAP.AllowUserToAddRows = false;
            this.dataGridViewOutput_КAP.AllowUserToDeleteRows = false;
            this.dataGridViewOutput_КAP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOutput_КAP.Location = new System.Drawing.Point(408, 80);
            this.dataGridViewOutput_КAP.Name = "dataGridViewOutput_КAP";
            this.dataGridViewOutput_КAP.ReadOnly = true;
            this.dataGridViewOutput_КAP.RowHeadersVisible = false;
            this.dataGridViewOutput_КAP.Size = new System.Drawing.Size(380, 300);
            this.dataGridViewOutput_КAP.TabIndex = 1;

            
            this.textBoxLoadFile_КAP.Location = new System.Drawing.Point(100, 45);
            this.textBoxLoadFile_КAP.Name = "textBoxLoadFile_КAP";
            this.textBoxLoadFile_КAP.ReadOnly = true;
            this.textBoxLoadFile_КAP.Size = new System.Drawing.Size(292, 20);
            this.textBoxLoadFile_КAP.TabIndex = 2;

            
            this.buttonOpenFile_КAP.Location = new System.Drawing.Point(3, 3);
            this.buttonOpenFile_КAP.Name = "buttonOpenFile_КAP";
            this.buttonOpenFile_КAP.Size = new System.Drawing.Size(120, 35);
            this.buttonOpenFile_КAP.TabIndex = 3;
            this.buttonOpenFile_КAP.Text = "Открыть файл";
            this.buttonOpenFile_КAP.UseVisualStyleBackColor = true;
            this.buttonOpenFile_КAP.Click += new System.EventHandler(this.buttonOpenFile_КAP_Click);

            
            this.buttonProcess_КAP.Enabled = false;
            this.buttonProcess_КAP.Location = new System.Drawing.Point(129, 3);
            this.buttonProcess_КAP.Name = "buttonProcess_КAP";
            this.buttonProcess_КAP.Size = new System.Drawing.Size(120, 35);
            this.buttonProcess_КAP.TabIndex = 4;
            this.buttonProcess_КAP.Text = "Выполнить";
            this.buttonProcess_КAP.UseVisualStyleBackColor = true;
            this.buttonProcess_КAP.Click += new System.EventHandler(this.buttonProcess_КAP_Click);

            
            this.buttonSaveFile_КAP.Enabled = false;
            this.buttonSaveFile_КAP.Location = new System.Drawing.Point(255, 3);
            this.buttonSaveFile_КAP.Name = "buttonSaveFile_КAP";
            this.buttonSaveFile_КAP.Size = new System.Drawing.Size(120, 35);
            this.buttonSaveFile_КAP.TabIndex = 5;
            this.buttonSaveFile_КAP.Text = "Сохранить файл";
            this.buttonSaveFile_КAP.UseVisualStyleBackColor = true;
            this.buttonSaveFile_КAP.Click += new System.EventHandler(this.buttonSaveFile_КAP_Click);

            
            this.buttonHelp_КAP.Location = new System.Drawing.Point(381, 3);
            this.buttonHelp_КAP.Name = "buttonHelp_КAP";
            this.buttonHelp_КAP.Size = new System.Drawing.Size(120, 35);
            this.buttonHelp_КAP.TabIndex = 6;
            this.buttonHelp_КAP.Text = "Справка";
            this.buttonHelp_КAP.UseVisualStyleBackColor = true;
            this.buttonHelp_КAP.Click += new System.EventHandler(this.buttonHelp_КAP_Click);

            
            this.buttonExit_КAP.Location = new System.Drawing.Point(507, 3);
            this.buttonExit_КAP.Name = "buttonExit_КAP";
            this.buttonExit_КAP.Size = new System.Drawing.Size(120, 35);
            this.buttonExit_КAP.TabIndex = 7;
            this.buttonExit_КAP.Text = "Выход";
            this.buttonExit_КAP.UseVisualStyleBackColor = true;
            this.buttonExit_КAP.Click += new System.EventHandler(this.buttonExit_КAP_Click);

            
            this.labelInput_КAP.AutoSize = true;
            this.labelInput_КAP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInput_КAP.Location = new System.Drawing.Point(12, 60);
            this.labelInput_КAP.Name = "labelInput_КAP";
            this.labelInput_КAP.Size = new System.Drawing.Size(127, 15);
            this.labelInput_КAP.TabIndex = 8;
            this.labelInput_КAP.Text = "Исходная матрица";

            
            this.labelOutput_КAP.AutoSize = true;
            this.labelOutput_КAP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelOutput_КAP.Location = new System.Drawing.Point(405, 60);
            this.labelOutput_КAP.Name = "labelOutput_КAP";
            this.labelOutput_КAP.Size = new System.Drawing.Size(169, 15);
            this.labelOutput_КAP.TabIndex = 9;
            this.labelOutput_КAP.Text = "Результат обработки";

            
            this.labelFilePath_КAP.AutoSize = true;
            this.labelFilePath_КAP.Location = new System.Drawing.Point(12, 48);
            this.labelFilePath_КAP.Name = "labelFilePath_КAP";
            this.labelFilePath_КAP.Size = new System.Drawing.Size(82, 13);
            this.labelFilePath_КAP.TabIndex = 10;
            this.labelFilePath_КAP.Text = "Путь к файлу:";

            
            this.panelControls_КAP.Controls.Add(this.buttonOpenFile_КAP);
            this.panelControls_КAP.Controls.Add(this.buttonProcess_КAP);
            this.panelControls_КAP.Controls.Add(this.buttonSaveFile_КAP);
            this.panelControls_КAP.Controls.Add(this.buttonHelp_КAP);
            this.panelControls_КAP.Controls.Add(this.buttonExit_КAP);
            this.panelControls_КAP.Location = new System.Drawing.Point(12, 390);
            this.panelControls_КAP.Name = "panelControls_КAP";
            this.panelControls_КAP.Size = new System.Drawing.Size(776, 45);
            this.panelControls_КAP.TabIndex = 11;

           
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelControls_КAP);
            this.Controls.Add(this.labelFilePath_КAP);
            this.Controls.Add(this.labelOutput_КAP);
            this.Controls.Add(this.labelInput_КAP);
            this.Controls.Add(this.textBoxLoadFile_КAP);
            this.Controls.Add(this.dataGridViewOutput_КAP);
            this.Controls.Add(this.dataGridViewInput_КAP);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 7 | Вариант 14 | Кочетов А.П.";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInput_КAP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutput_КAP)).EndInit();
            this.panelControls_КAP.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
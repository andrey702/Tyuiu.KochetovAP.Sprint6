namespace Tyuiu.KochetovAP.Sprint6.Task3.V30
{
    partial class FormMain
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            dataGridViewMatrix_KAP = new DataGridView();
            buttonExecute_KAP = new Button();
            buttonHelp_KAP = new Button();
            labelInfo_KAP = new Label();
            panelButtons_KAP = new Panel();
            panelData_KAP = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrix_KAP).BeginInit();
            panelButtons_KAP.SuspendLayout();
            panelData_KAP.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewMatrix_KAP
            // 
            dataGridViewMatrix_KAP.AllowUserToAddRows = false;
            dataGridViewMatrix_KAP.AllowUserToDeleteRows = false;
            dataGridViewMatrix_KAP.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMatrix_KAP.Dock = DockStyle.Fill;
            dataGridViewMatrix_KAP.Location = new Point(0, 50);
            dataGridViewMatrix_KAP.Margin = new Padding(4, 5, 4, 5);
            dataGridViewMatrix_KAP.Name = "dataGridViewMatrix_KAP";
            dataGridViewMatrix_KAP.ReadOnly = true;
            dataGridViewMatrix_KAP.RowHeadersWidth = 51;
            dataGridViewMatrix_KAP.Size = new Size(1045, 582);
            dataGridViewMatrix_KAP.TabIndex = 0;
            // 
            // buttonExecute_KAP
            // 
            buttonExecute_KAP.Location = new Point(27, 23);
            buttonExecute_KAP.Margin = new Padding(4, 5, 4, 5);
            buttonExecute_KAP.Name = "buttonExecute_KAP";
            buttonExecute_KAP.Size = new Size(200, 62);
            buttonExecute_KAP.TabIndex = 1;
            buttonExecute_KAP.Text = "Выполнить";
            buttonExecute_KAP.UseVisualStyleBackColor = true;
            buttonExecute_KAP.Click += buttonExecute_KAP_Click;
            // 
            // buttonHelp_KAP
            // 
            buttonHelp_KAP.Location = new Point(274, 23);
            buttonHelp_KAP.Margin = new Padding(4, 5, 4, 5);
            buttonHelp_KAP.Name = "buttonHelp_KAP";
            buttonHelp_KAP.Size = new Size(200, 62);
            buttonHelp_KAP.TabIndex = 2;
            buttonHelp_KAP.Text = "Справка";
            buttonHelp_KAP.UseVisualStyleBackColor = true;
            buttonHelp_KAP.Click += buttonHelp_KAP_Click;
            // 
            // labelInfo_KAP
            // 
            labelInfo_KAP.AutoSize = true;
            labelInfo_KAP.Dock = DockStyle.Top;
            labelInfo_KAP.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelInfo_KAP.Location = new Point(0, 0);
            labelInfo_KAP.Margin = new Padding(4, 0, 4, 0);
            labelInfo_KAP.Name = "labelInfo_KAP";
            labelInfo_KAP.Padding = new Padding(13, 15, 13, 15);
            labelInfo_KAP.Size = new Size(223, 50);
            labelInfo_KAP.TabIndex = 3;
            labelInfo_KAP.Text = "Нажмите \"Выполнить\"";
            // 
            // panelButtons_KAP
            // 
            panelButtons_KAP.Controls.Add(buttonExecute_KAP);
            panelButtons_KAP.Controls.Add(buttonHelp_KAP);
            panelButtons_KAP.Dock = DockStyle.Bottom;
            panelButtons_KAP.Location = new Point(0, 632);
            panelButtons_KAP.Margin = new Padding(4, 5, 4, 5);
            panelButtons_KAP.Name = "panelButtons_KAP";
            panelButtons_KAP.Size = new Size(1045, 108);
            panelButtons_KAP.TabIndex = 4;
            // 
            // panelData_KAP
            // 
            panelData_KAP.Controls.Add(dataGridViewMatrix_KAP);
            panelData_KAP.Controls.Add(labelInfo_KAP);
            panelData_KAP.Dock = DockStyle.Fill;
            panelData_KAP.Location = new Point(0, 0);
            panelData_KAP.Margin = new Padding(4, 5, 4, 5);
            panelData_KAP.Name = "panelData_KAP";
            panelData_KAP.Size = new Size(1045, 632);
            panelData_KAP.TabIndex = 5;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1045, 740);
            Controls.Add(panelData_KAP);
            Controls.Add(panelButtons_KAP);
            Margin = new Padding(4, 5, 4, 5);
            MinimumSize = new Size(1061, 775);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 3 | Вариант 30 | Кочетов А.П.";
            Load += FormMain_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrix_KAP).EndInit();
            panelButtons_KAP.ResumeLayout(false);
            panelData_KAP.ResumeLayout(false);
            panelData_KAP.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewMatrix_KAP;
        private System.Windows.Forms.Button buttonExecute_KAP;
        private System.Windows.Forms.Button buttonHelp_KAP;
        private System.Windows.Forms.Label labelInfo_KAP;
        private System.Windows.Forms.Panel panelButtons_KAP;
        private System.Windows.Forms.Panel panelData_KAP;
    }
}
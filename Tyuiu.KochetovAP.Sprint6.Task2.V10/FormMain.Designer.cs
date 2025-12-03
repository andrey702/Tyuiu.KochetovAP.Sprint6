namespace Tyuiu.KochetovAP.Sprint6.Task2.V10
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

        private void InitializeComponent()
        {
            dataGridViewResult_KAP = new DataGridView();
            buttonStart_KAP = new Button();
            buttonHelp_KAP = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_KAP).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewResult_KAP
            // 
            dataGridViewResult_KAP.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewResult_KAP.Location = new Point(19, 82);
            dataGridViewResult_KAP.Margin = new Padding(4, 5, 4, 5);
            dataGridViewResult_KAP.Name = "dataGridViewResult_KAP";
            dataGridViewResult_KAP.RowHeadersWidth = 51;
            dataGridViewResult_KAP.Size = new Size(400, 538);
            dataGridViewResult_KAP.TabIndex = 0;
            // 
            // buttonStart_KAP
            // 
            buttonStart_KAP.Location = new Point(16, 18);
            buttonStart_KAP.Margin = new Padding(4, 5, 4, 5);
            buttonStart_KAP.Name = "buttonStart_KAP";
            buttonStart_KAP.Size = new Size(133, 46);
            buttonStart_KAP.TabIndex = 1;
            buttonStart_KAP.Text = "Выполнить";
            buttonStart_KAP.UseVisualStyleBackColor = true;
            buttonStart_KAP.Click += buttonStart_KAP_Click;
            // 
            // buttonHelp_KAP
            // 
            buttonHelp_KAP.Location = new Point(283, 18);
            buttonHelp_KAP.Margin = new Padding(4, 5, 4, 5);
            buttonHelp_KAP.Name = "buttonHelp_KAP";
            buttonHelp_KAP.Size = new Size(133, 46);
            buttonHelp_KAP.TabIndex = 2;
            buttonHelp_KAP.Text = "Справка";
            buttonHelp_KAP.UseVisualStyleBackColor = true;
            buttonHelp_KAP.Click += buttonHelp_KAP_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(432, 634);
            Controls.Add(buttonHelp_KAP);
            Controls.Add(buttonStart_KAP);
            Controls.Add(dataGridViewResult_KAP);
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Табулирование функции";
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_KAP).EndInit();
            ResumeLayout(false);
        }

        private System.Windows.Forms.DataGridView dataGridViewResult_KAP;
        private System.Windows.Forms.Button buttonStart_KAP;
        private System.Windows.Forms.Button buttonHelp_KAP;
    }
}
namespace Tyuiu.KochetovAP.Sprint6.Task1.V19
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
            this.textBoxResult_KAP = new System.Windows.Forms.TextBox();
            this.buttonStart_KAP = new System.Windows.Forms.Button();
            this.buttonHelp_KAP = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // textBoxResult_KAP
            this.textBoxResult_KAP.Location = new System.Drawing.Point(12, 50);
            this.textBoxResult_KAP.Multiline = true;
            this.textBoxResult_KAP.Name = "textBoxResult_KAP";
            this.textBoxResult_KAP.ReadOnly = true;
            this.textBoxResult_KAP.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult_KAP.Size = new System.Drawing.Size(360, 380);
            this.textBoxResult_KAP.TabIndex = 0;

            // buttonStart_KAP
            this.buttonStart_KAP.Location = new System.Drawing.Point(12, 12);
            this.buttonStart_KAP.Name = "buttonStart_KAP";
            this.buttonStart_KAP.Size = new System.Drawing.Size(120, 30);
            this.buttonStart_KAP.TabIndex = 1;
            this.buttonStart_KAP.Text = "Выполнить";
            this.buttonStart_KAP.UseVisualStyleBackColor = true;
            this.buttonStart_KAP.Click += new System.EventHandler(this.buttonStart_KAP_Click);

            // buttonHelp_KAP
            this.buttonHelp_KAP.Location = new System.Drawing.Point(252, 12);
            this.buttonHelp_KAP.Name = "buttonHelp_KAP";
            this.buttonHelp_KAP.Size = new System.Drawing.Size(120, 30);
            this.buttonHelp_KAP.TabIndex = 2;
            this.buttonHelp_KAP.Text = "Справка";
            this.buttonHelp_KAP.UseVisualStyleBackColor = true;
            this.buttonHelp_KAP.Click += new System.EventHandler(this.buttonHelp_KAP_Click);

            // FormMain
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 442);
            this.Controls.Add(this.buttonHelp_KAP);
            this.Controls.Add(this.buttonStart_KAP);
            this.Controls.Add(this.textBoxResult_KAP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Табулирование функции";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox textBoxResult_KAP;
        private System.Windows.Forms.Button buttonStart_KAP;
        private System.Windows.Forms.Button buttonHelp_KAP;
    }
}
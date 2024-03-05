namespace LiveLineLogoRemover
{
    partial class MainScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TextBoxMediaImportPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BrowseImport = new System.Windows.Forms.Button();
            this.BrowseExport = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBoxMediaExportPath = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ButtonInteractWithScript = new System.Windows.Forms.Button();
            this.ComboBoxSpeed = new System.Windows.Forms.ComboBox();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.ProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.ProgressLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.statusStrip.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TextBoxMediaImportPath
            // 
            this.TextBoxMediaImportPath.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxMediaImportPath.Location = new System.Drawing.Point(22, 40);
            this.TextBoxMediaImportPath.Name = "TextBoxMediaImportPath";
            this.TextBoxMediaImportPath.Size = new System.Drawing.Size(600, 29);
            this.TextBoxMediaImportPath.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label1.Location = new System.Drawing.Point(22, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Video a Ser Editado:";
            // 
            // BrowseImport
            // 
            this.BrowseImport.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.BrowseImport.Location = new System.Drawing.Point(628, 40);
            this.BrowseImport.Name = "BrowseImport";
            this.BrowseImport.Size = new System.Drawing.Size(90, 29);
            this.BrowseImport.TabIndex = 2;
            this.BrowseImport.Text = "Browse";
            this.BrowseImport.UseVisualStyleBackColor = true;
            // 
            // BrowseExport
            // 
            this.BrowseExport.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.BrowseExport.Location = new System.Drawing.Point(628, 116);
            this.BrowseExport.Name = "BrowseExport";
            this.BrowseExport.Size = new System.Drawing.Size(90, 29);
            this.BrowseExport.TabIndex = 5;
            this.BrowseExport.Text = "Browse";
            this.BrowseExport.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label2.Location = new System.Drawing.Point(22, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Local Para Salvar o Video:";
            // 
            // TextBoxMediaExportPath
            // 
            this.TextBoxMediaExportPath.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxMediaExportPath.Location = new System.Drawing.Point(22, 116);
            this.TextBoxMediaExportPath.Name = "TextBoxMediaExportPath";
            this.TextBoxMediaExportPath.Size = new System.Drawing.Size(600, 29);
            this.TextBoxMediaExportPath.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label3.Location = new System.Drawing.Point(23, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Velocidade do Vídeo:";
            // 
            // ButtonInteractWithScript
            // 
            this.ButtonInteractWithScript.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ButtonInteractWithScript.Location = new System.Drawing.Point(631, 267);
            this.ButtonInteractWithScript.Name = "ButtonInteractWithScript";
            this.ButtonInteractWithScript.Size = new System.Drawing.Size(107, 46);
            this.ButtonInteractWithScript.TabIndex = 11;
            this.ButtonInteractWithScript.Text = "Start";
            this.ButtonInteractWithScript.UseVisualStyleBackColor = true;
            // 
            // ComboBoxSpeed
            // 
            this.ComboBoxSpeed.DisplayMember = "UserSettings";
            this.ComboBoxSpeed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxSpeed.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ComboBoxSpeed.FormattingEnabled = true;
            this.ComboBoxSpeed.Items.AddRange(new object[] {
            "0,3",
            "0,5",
            "0,7",
            "1,0",
            "1,3",
            "1,5",
            "1,7",
            "2,0"});
            this.ComboBoxSpeed.Location = new System.Drawing.Point(183, 178);
            this.ComboBoxSpeed.Name = "ComboBoxSpeed";
            this.ComboBoxSpeed.Size = new System.Drawing.Size(107, 29);
            this.ComboBoxSpeed.TabIndex = 7;
            this.ComboBoxSpeed.ValueMember = "UserSettings";
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ProgressBar,
            this.ProgressLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 285);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStrip.Size = new System.Drawing.Size(741, 31);
            this.statusStrip.SizingGrip = false;
            this.statusStrip.TabIndex = 12;
            this.statusStrip.Visible = false;
            // 
            // ProgressBar
            // 
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(200, 25);
            // 
            // ProgressLabel
            // 
            this.ProgressLabel.Name = "ProgressLabel";
            this.ProgressLabel.Size = new System.Drawing.Size(70, 26);
            this.ProgressLabel.Text = "Rendering...";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TextBoxMediaImportPath);
            this.panel1.Controls.Add(this.ButtonInteractWithScript);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.ComboBoxSpeed);
            this.panel1.Controls.Add(this.BrowseImport);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.TextBoxMediaExportPath);
            this.panel1.Controls.Add(this.BrowseExport);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(741, 316);
            this.panel1.TabIndex = 13;
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 316);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip);
            this.MaximizeBox = false;
            this.Name = "MainScreen";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Video Settings";
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBoxMediaImportPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BrowseImport;
        private System.Windows.Forms.Button BrowseExport;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextBoxMediaExportPath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ComboBoxSpeed;
        internal System.Windows.Forms.ToolStripProgressBar ProgressBar;
        internal System.Windows.Forms.StatusStrip statusStrip;
        internal System.Windows.Forms.ToolStripStatusLabel ProgressLabel;
        internal System.Windows.Forms.Button ButtonInteractWithScript;
        private System.Windows.Forms.Panel panel1;
    }
}
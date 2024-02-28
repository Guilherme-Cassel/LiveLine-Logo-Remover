namespace TestScript
{
    partial class Input
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
            this.components = new System.ComponentModel.Container();
            this.TextBoxMediaImportPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BrowseImport = new System.Windows.Forms.Button();
            this.BrowseExport = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBoxMediaExportPath = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.StartScript = new System.Windows.Forms.Button();
            this.ComboBoxSpeed = new System.Windows.Forms.ComboBox();
            this.BindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // TextBoxMediaImportPath
            // 
            this.TextBoxMediaImportPath.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BindingSource, "ImportPath", true));
            this.TextBoxMediaImportPath.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxMediaImportPath.Location = new System.Drawing.Point(26, 51);
            this.TextBoxMediaImportPath.Name = "TextBoxMediaImportPath";
            this.TextBoxMediaImportPath.Size = new System.Drawing.Size(600, 29);
            this.TextBoxMediaImportPath.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label1.Location = new System.Drawing.Point(26, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Video a Ser Editado:";
            // 
            // BrowseImport
            // 
            this.BrowseImport.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.BrowseImport.Location = new System.Drawing.Point(632, 51);
            this.BrowseImport.Name = "BrowseImport";
            this.BrowseImport.Size = new System.Drawing.Size(90, 29);
            this.BrowseImport.TabIndex = 2;
            this.BrowseImport.Text = "Browse";
            this.BrowseImport.UseVisualStyleBackColor = true;
            // 
            // BrowseExport
            // 
            this.BrowseExport.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.BrowseExport.Location = new System.Drawing.Point(632, 127);
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
            this.label2.Location = new System.Drawing.Point(26, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Local Para Salvar o Video:";
            // 
            // TextBoxMediaExportPath
            // 
            this.TextBoxMediaExportPath.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxMediaExportPath.Location = new System.Drawing.Point(26, 127);
            this.TextBoxMediaExportPath.Name = "TextBoxMediaExportPath";
            this.TextBoxMediaExportPath.Size = new System.Drawing.Size(600, 29);
            this.TextBoxMediaExportPath.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label3.Location = new System.Drawing.Point(27, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Velocidade do Vídeo:";
            // 
            // StartScript
            // 
            this.StartScript.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.StartScript.Location = new System.Drawing.Point(632, 267);
            this.StartScript.Name = "StartScript";
            this.StartScript.Size = new System.Drawing.Size(107, 46);
            this.StartScript.TabIndex = 11;
            this.StartScript.Text = "Start";
            this.StartScript.UseVisualStyleBackColor = true;
            this.StartScript.Click += new System.EventHandler(this.StartScript_Click);
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
            this.ComboBoxSpeed.Location = new System.Drawing.Point(187, 189);
            this.ComboBoxSpeed.Name = "ComboBoxSpeed";
            this.ComboBoxSpeed.Size = new System.Drawing.Size(107, 29);
            this.ComboBoxSpeed.TabIndex = 7;
            this.ComboBoxSpeed.ValueMember = "UserSettings";
            // 
            // BindingSource
            // 
            this.BindingSource.DataSource = typeof(TestScript.UserSettings);
            // 
            // Input
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 316);
            this.Controls.Add(this.StartScript);
            this.Controls.Add(this.ComboBoxSpeed);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BrowseExport);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TextBoxMediaExportPath);
            this.Controls.Add(this.BrowseImport);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextBoxMediaImportPath);
            this.Name = "Input";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Video Settings";
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource)).EndInit();
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
        private System.Windows.Forms.Button StartScript;
        private System.Windows.Forms.ComboBox ComboBoxSpeed;
        private System.Windows.Forms.BindingSource BindingSource;
    }
}
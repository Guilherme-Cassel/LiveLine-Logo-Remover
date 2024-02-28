#nullable enable

using System;
using System.IO;
using System.Windows.Forms;

namespace LiveLineLogoRemover;

public partial class Input : Form
{
    public UserSettings UserSettings { get; set; } = null!;
    public Input()
    {
        InitializeComponent();
        BrowseImport.Click += BrowseImport_Click;
        BrowseExport.Click += BrowseExport_Click;

        ComboBoxSpeed.SelectedIndex = 3;
    }

    private void BrowseExport_Click(object sender, EventArgs e)
    {
        using var openFileDialog = new FolderBrowserDialog();

        DialogResult result = openFileDialog.ShowDialog();

        if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(openFileDialog.SelectedPath))
        {
            TextBoxMediaExportPath.Text = Path.Combine(openFileDialog.SelectedPath, "No LiveLine-Logo Video.mp4");
        }
    }

    private void BrowseImport_Click(object sender, EventArgs e)
    {
        using var openFileDialog = new OpenFileDialog();
        openFileDialog.Multiselect = false;
        openFileDialog.Filter = "MP4 files (*.mp4)|*.mp4";

        DialogResult result = openFileDialog.ShowDialog();

        if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(openFileDialog.FileName))
        {
            TextBoxMediaImportPath.Text = openFileDialog.FileName;
        }
    }

    private void StartScript_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(TextBoxMediaImportPath.Text) || string.IsNullOrEmpty(TextBoxMediaExportPath.Text) || string.IsNullOrEmpty(ComboBoxSpeed.SelectedItem.ToString()))
        {
            MessageBox.Show("Preencha Todos os Campos!!");
            return;
        }

        UserSettings = MountUserSetting();

        Close();
    }

    public UserSettings MountUserSetting()
    {
        return new
            (
            TextBoxMediaImportPath.Text,
            TextBoxMediaExportPath.Text,
            Double.Parse(ComboBoxSpeed.SelectedItem.ToString())
            );
    }
}

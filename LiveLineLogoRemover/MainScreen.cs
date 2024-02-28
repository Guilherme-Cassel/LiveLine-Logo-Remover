#nullable enable

using System;
using System.IO;
using System.Windows.Forms;

namespace LiveLineLogoRemover;

public partial class MainScreen : Form
{
    public MainScreen()
    {
        InitializeComponent();

        BrowseImport.Click += BrowseImport_Click;
        BrowseExport.Click += BrowseExport_Click;
        FormClosing += MainScreen_FormClosing;

        ComboBoxSpeed.SelectedIndex = 3;
    }

    private void MainScreen_FormClosing(object sender, FormClosingEventArgs e)
    {
        if (EntryPoint.UserSettings is null)
            MessageBox.Show("Operação Cancelada!");
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

        EntryPoint.UserSettings = MountUserSetting();

        EntryPoint.RunScript();

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

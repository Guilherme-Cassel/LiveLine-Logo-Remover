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
        ButtonInteractWithScript.Click += InteractWithScript_Click;

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

    private void InteractWithScript_Click(object sender, EventArgs e)
    {
        if (sender is Button button)
            if (button.Text == "Cancel")
                return;

        if (string.IsNullOrEmpty(TextBoxMediaImportPath.Text) || string.IsNullOrEmpty(TextBoxMediaExportPath.Text) || string.IsNullOrEmpty(ComboBoxSpeed.SelectedItem.ToString()))
        {
            MessageBox.Show("Preencha Todos os Campos!!");
            return;
        }

        EntryPoint.UserSettings = MountUserSetting();

        EntryPoint.RunScript();
    }

    public UserSettings MountUserSetting()
    {
        UserSettings settings = new
        (
        TextBoxMediaImportPath.Text,
        TextBoxMediaExportPath.Text,
        Double.Parse(ComboBoxSpeed.SelectedItem.ToString())
        );

        int index = 1;
        string newExportPath = settings.ExportPath;
        while (File.Exists(newExportPath))
        {
            string directory = Path.GetDirectoryName(settings.ExportPath);

            string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(settings.ExportPath);

            string modifiedFileName = fileNameWithoutExtension + $" - {index}";

            string extension = Path.GetExtension(settings.ExportPath);

            newExportPath = Path.Combine(directory, modifiedFileName + extension);

            index++;
        }
        settings.ExportPath = newExportPath;
        TextBoxMediaExportPath.Text = newExportPath;

        return settings;
    }

    public void Exit()
    {
        Close();
    }
}

namespace LiveLineLogoRemover;

public sealed class UserSettings(string importPath, string exportPath, double relativeSpeed)
{
    public string ImportPath { get; set; } = importPath;
    public string ExportPath { get; set; } = exportPath;
    public double RelativeSpeed { get; set; } = relativeSpeed;
}

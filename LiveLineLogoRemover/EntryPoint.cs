using ScriptPortal.Vegas;
using System;
using System.IO;
using System.Windows;

namespace LiveLineLogoRemover;

public class EntryPoint
{
    public static MainScreen MainScreen { get; set; } = new MainScreen();
    public static Vegas Vegas { get; private set; }
    public static UserSettings UserSettings { get; set; }
    public void FromVegas(Vegas vegas)
    {
        try
        {
            Vegas = vegas;
            MainScreen.ShowDialog();
        }
        catch (Exception ex)
        {
            throw new Exception("Erro no Script Capturado com Sucesso!", ex);
        }
        finally
        {
            vegas.Exit();
        }
    }
    public static void RunScript()
    {
        VegasVideo BaseVideo = new(UserSettings.ImportPath, true);
        BaseVideo.ApplyUserSetting();

        VegasVideo EffectsVideo = new(UserSettings.ImportPath, false);
        EffectsVideo.ApplyUserSetting();

        LiveLineVideoMaker.RemoveLogo(EffectsVideo);

        VideoRenderer.RenderVideo();

        ClearVegasEditingTrash();
    }

    private static void ClearVegasEditingTrash()
    {
        string importedVideoProjectSettingsFile = UserSettings.ImportPath + ".sfk";

        if (File.Exists(importedVideoProjectSettingsFile))
        {
            File.Delete(importedVideoProjectSettingsFile);
        }
    }
}

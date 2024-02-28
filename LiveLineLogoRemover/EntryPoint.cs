using ScriptPortal.Vegas;
using System;
using TestScript;

namespace LiveLineLogoRemover;

public class EntryPoint
{
    public static Vegas Vegas { get; private set; }
    public static UserSettings UserSettings { get; set; } = new("", "", 1.0);
    public void FromVegas(Vegas vegas)
    {
        try
        {
            Input formInput = new();
            formInput.ShowDialog();

            if (formInput.UserSettings is null)
            {
                System.Windows.Forms.MessageBox.Show("Operação Cancelada!");
                return;
            }

            Vegas = vegas;
            UserSettings = formInput.UserSettings;

            VegasVideo BaseVideo = new(UserSettings.ImportPath, true);
            BaseVideo.ApplyUserSetting();

            VegasVideo EffectsVideo = new(UserSettings.ImportPath, false);
            EffectsVideo.ApplyUserSetting();

            LiveLineVideoMaker.RemoveLogo(EffectsVideo);

            RenderVideo();
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
    private void RenderVideo()
    {
        string renderName = "MAGIX AVC/AAC MP4";
        string renderTemplateName = "Internet HD 1080p 59.94 fps (NVidia NVENC)";

        RenderTemplate renderTemplate = Vegas.Renderers.FindByName(renderName).Templates.FindByName(renderTemplateName);
        RenderArgs args = new (Vegas.Project);
        args.RenderTemplate = renderTemplate;
        args.OutputFile = UserSettings.ExportPath;

        Vegas.Render(args);

        System.Windows.Forms.MessageBox.Show("Rendering Complete!");
    }
}

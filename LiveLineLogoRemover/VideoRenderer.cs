using ScriptPortal.Vegas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LiveLineLogoRemover
{
    public class VideoRenderer
    {
        public static void RenderVideo()
        {
            EntryPoint.Vegas.RenderStarted += Vegas_RenderStarted;
            EntryPoint.Vegas.RenderFinished += Vegas_RenderFinished;
            EntryPoint.Vegas.RenderProgress += Vegas_RenderProgress;

            string renderName = "MAGIX AVC/AAC MP4";
            string renderTemplateName = "Internet HD 1080p 59.94 fps (NVidia NVENC)";

            RenderTemplate renderTemplate = EntryPoint.Vegas.Renderers.FindByName(renderName).Templates.FindByName(renderTemplateName);

            RenderArgs args = new(EntryPoint.Vegas.Project)
            {
                RenderTemplate = renderTemplate,
                OutputFile = EntryPoint.UserSettings.ExportPath,
                CancelRender = false
            };

            EntryPoint.Vegas.Render(args);
        }

        public static void Vegas_RenderProgress(object sender, RenderStatusEventArgs args)
        {
            void method()
            {
                EntryPoint.MainScreen.ProgressBar.Value = args.PercentComplete;
            }

            if (EntryPoint.MainScreen.InvokeRequired) EntryPoint.MainScreen.Invoke(method);
            else method();
        }

        private static void Vegas_RenderStarted(object sender, EventArgs e)
        {
            MessageBox.Show("Rendering Started!");
            EntryPoint.MainScreen.statusStrip.Visible = true;
        }

        private static void Vegas_RenderFinished(object sender, RenderStatusEventArgs args)
        {
            EntryPoint.MainScreen.ProgressLabel.Text = "Complete!";
            MessageBox.Show("Rendering Finished!");
        }
    }
}

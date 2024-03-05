using ScriptPortal.Vegas;
using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LiveLineLogoRemover
{
    public class VideoRenderer
    {
        internal static RenderArgs args = new();
        public static void RenderVideo()
        {
            EntryPoint.Vegas.RenderStarted += Vegas_RenderStarted;
            EntryPoint.Vegas.RenderFinished += Vegas_RenderFinished;
            EntryPoint.Vegas.RenderProgress += Vegas_RenderProgress;

            const double MinimumRelativeSpeedFor60fps = 0.7;
            RenderTemplate renderTemplate = (EntryPoint.UserSettings.RelativeSpeed >= MinimumRelativeSpeedFor60fps) ? CustomRenderTemplates.FullHD_60fps_10mbps : CustomRenderTemplates.FullHD_30fps_10mbps;

            args = new(EntryPoint.Vegas.Project)
            {
                RenderTemplate = renderTemplate,
                OutputFile = EntryPoint.UserSettings.ExportPath,
            };

            EntryPoint.Vegas.Render(args);
        }

        private static void Vegas_RenderStarted(object sender, EventArgs e)
        {
            MessageBox.Show("Rendering Will Start!");

            EntryPoint.MainScreen.ButtonInteractWithScript.Text = "Cancel";
            EntryPoint.MainScreen.ButtonInteractWithScript.Click += Vegas_RenderCancel;
            EntryPoint.MainScreen.ButtonInteractWithScript.Location = new(EntryPoint.MainScreen.ButtonInteractWithScript.Location.X, EntryPoint.MainScreen.ButtonInteractWithScript.Location.Y - EntryPoint.MainScreen.statusStrip.Height);
            EntryPoint.MainScreen.statusStrip.Visible = true;
        }

        private static void Vegas_RenderCancel(object sender, EventArgs e)
        {
            var vegasHandle = EntryPoint.Vegas.MainWindow.Handle;

            [DllImport("user32.dll", CharSet = CharSet.Auto)]
            static extern IntPtr SendMessage(IntPtr hWnd, UInt32 Msg, IntPtr wParam, IntPtr lParam);
            const UInt32 WM_CLOSE = 0x0010;

            SendMessage(vegasHandle, WM_CLOSE, IntPtr.Zero, IntPtr.Zero);
        }

        private static void Vegas_RenderProgress(object sender, RenderStatusEventArgs args)
        {
            void method()
            {
                EntryPoint.MainScreen.ProgressBar.Value = args.PercentComplete;
            }

            if (EntryPoint.MainScreen.InvokeRequired) EntryPoint.MainScreen.Invoke(method);
            else method();
        }

        private static void Vegas_RenderFinished(object sender, RenderStatusEventArgs args)
        {
            string labelText = (args.Status == RenderStatus.Complete) ? "Complete!" : "Cancelled!";

            EntryPoint.MainScreen.ProgressLabel.Text = labelText;

            if (args.Status == RenderStatus.Complete && args.Result == 1)
                MessageBox.Show("Rendering Finished!");
        }
    }
}

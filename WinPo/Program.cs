using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinPo
{
    static class Program
    {
        public static Dictionary<string, PosWindow.Rect> savedApps = new Dictionary<string, PosWindow.Rect>();
        //public static Dictionary<string, IContainerControl> savedContainers = new Dictionary<string, IContainerControl>();

        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Configuration());
        }
    }

    /*public class WinPoApplicationContext : ApplicationContext
    {
        private NotifyIcon trayIcon;

        public WinPoApplicationContext()
        {
            // Initialize Tray Icon
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Configuration));
            trayIcon = new NotifyIcon()
            {
                Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon"))),
                ContextMenu = new ContextMenu(new MenuItem[] {
                    new MenuItem("Set Windows"),
                    new MenuItem("Configuration", Application.Run(new Configuration()),
                    new MenuItem("Exit", Exit)
                }),
                Visible = true
            };
        }

        void Run(object sender, EventArgs e)
        {

        }

        void Exit(object sender, EventArgs e)
        {
            // Hide tray icon, otherwise it will remain shown until user mouses over it
            trayIcon.Visible = false;

            Application.Exit();
        }
    }*/
}
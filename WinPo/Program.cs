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
            Application.Run(new WinPoApplicationContext());
        }
    }

    public class WinPoApplicationContext : ApplicationContext
    {
        private NotifyIcon trayIcon;

        public WinPoApplicationContext()
        {
            // Initialize Tray Icon
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Configuration));
            trayIcon = new NotifyIcon()
            {
                Icon = Properties.Resources.TrayIcon,
                ContextMenu = new ContextMenu(new MenuItem[] {
                    new MenuItem("Set Window Position", SetWindows),
                    new MenuItem("-"),
                    new MenuItem("Configuration", Show),
                    new MenuItem("-"),
                    new MenuItem("Exit", Exit)
                }),
                Visible = true
            };
        }

        void SetWindows(object sender, EventArgs e)
        {
            if (Properties.Settings.Default == null)
            {
                MessageBox.Show("No saved configuration");
                return;
            }
            Program.savedApps = new Dictionary<string, PosWindow.Rect>();

            Configuration.importFromSettings();
            Configuration.setPositions();
        }

        void Show(object sender, EventArgs e)
        {
            Configuration configuration = new Configuration
            { 
                ShowInTaskbar = true
            };
            configuration.Show();
        }

        void Exit(object sender, EventArgs e)
        {
            // Hide tray icon, otherwise it will remain shown until user mouses over it
            trayIcon.Visible = false;

            Application.Exit();
        }
    }
}
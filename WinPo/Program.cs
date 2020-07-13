using IWshRuntimeLibrary;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
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
                    new MenuItem("Autostart", new MenuItem [] {
                        new MenuItem("Enable", EnableAutostart),
                        new MenuItem("Disable", DisableAutostart)
                    }),
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

        void EnableAutostart(object sender, EventArgs e)
        {
            if (!System.IO.File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\WinPo.lnk")){
                WshShellClass wshShell = new WshShellClass();
                IWshRuntimeLibrary.IWshShortcut shortcut;
                string startUpFolderPath = Environment.GetFolderPath(Environment.SpecialFolder.Startup);

                // Create the shortcut
                shortcut = (IWshRuntimeLibrary.IWshShortcut)wshShell.CreateShortcut(startUpFolderPath + "\\" + Application.ProductName + ".lnk");
                shortcut.TargetPath = Application.ExecutablePath;
                shortcut.WorkingDirectory = Application.StartupPath;
                shortcut.Description = "Launch WinPo";
                // shortcut.IconLocation = Application.StartupPath + @"\App.ico";
                shortcut.Save();
            }
        }

        void DisableAutostart(object sender, EventArgs e)
        {
            string startUpFolderPath = Environment.GetFolderPath(Environment.SpecialFolder.Startup);

            DirectoryInfo di = new DirectoryInfo(startUpFolderPath);
            FileInfo[] files = di.GetFiles("*.lnk");

            foreach (FileInfo fi in files)
            {
                string shortcutTargetFile = GetShortcutTargetFile(fi.FullName);

                if (shortcutTargetFile.EndsWith("WinPo.exe", StringComparison.InvariantCultureIgnoreCase))
                {
                    System.IO.File.Delete(fi.FullName);
                }
            }
        }

        public string GetShortcutTargetFile(string shortcutFilename)
        {
            string pathOnly = Path.GetDirectoryName(shortcutFilename);
            string filenameOnly = Path.GetFileName(shortcutFilename);

            Shell32.Shell shell = new Shell32.ShellClass();
            Shell32.Folder folder = shell.NameSpace(pathOnly);
            Shell32.FolderItem folderItem = folder.ParseName(filenameOnly);
            if (folderItem != null)
            {
                Shell32.ShellLinkObject link = (Shell32.ShellLinkObject)folderItem.GetLink;
                return link.Path;
            }

            return String.Empty; // Not found
        }
    }
}
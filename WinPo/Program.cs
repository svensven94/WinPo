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
        public static Dictionary<string, IContainerControl> savedContainers = new Dictionary<string, IContainerControl>();

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
}

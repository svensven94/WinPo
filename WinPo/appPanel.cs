using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace WinPo
{
    public partial class AppPanel : UserControl
    {
        private Dictionary<string, int[]> savedApps = new Dictionary<string, int[]>();

        public AppPanel()
        {
            InitializeComponent();
            getApps();
        }

        private void AppPanel_Load(object sender, EventArgs e)
        {
            getApps();
        }

        private void getApps()
        {
            Process[] processes = Process.GetProcesses();
            foreach (Process p in processes)
            {
                if (!String.IsNullOrEmpty(p.MainWindowTitle))
                {
                    comboApp.Items.Add(p.MainWindowTitle);
                }
            }
        }

        private void getScreens()
        {
            foreach (var screen in Screen.AllScreens)
            {
                string name = screen.DeviceName;
                //comboScreen.Items.Add(name.Substring(name.LastIndexOf('\\')+1));
            }
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            //IntPtr hWnd = PosWindow.FindWindow(comboApp.SelectedItem.ToString(),null);
            if (comboApp.SelectedIndex > -1)
            {
                IntPtr hWnd = PosWindow.FindWindow(null, comboApp.SelectedItem.ToString());
                if (hWnd != IntPtr.Zero)
                {
                    //PosWindow.SetWindowPos(hWnd, IntPtr.Zero, 0, 0, 0, 0, PosWindow.SWP_NOSIZE | PosWindow.SWP_NOZORDER);
                    PosWindow.Rect position = new PosWindow.Rect();
                    PosWindow.GetWindowRect(hWnd, ref position);
                    textPosLeft.Text = position.Left.ToString();
                    textPosTop.Text = position.Top.ToString();
                    textPosRight.Text = position.Right.ToString();
                    textPosBottom.Text = position.Bottom.ToString();
                }
            }
            else
            {
                MessageBox.Show("Please select an application");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void buttonSet_Click(object sender, EventArgs e)
        {
            if (comboApp.SelectedIndex > -1)
            {
                try
                {
                    var position = new int[] { Int32.Parse(textPosLeft.Text), Int32.Parse(textPosTop.Text) }; //Int32.Parse(textPosRight.Text), Int32.Parse(textPosBottom.Text) };
                    String app = comboApp.SelectedItem.ToString();
                    if (savedApps.ContainsKey(app))
                    {
                        savedApps[app] = position;
                    }
                    else
                    {
                        savedApps.Add(app, position);
                    }

                    IntPtr hWnd = PosWindow.FindWindow(null, comboApp.SelectedItem.ToString());
                    if (hWnd != IntPtr.Zero)
                    {
                        PosWindow.SetWindowPos(hWnd, IntPtr.Zero, position[0], position[1], 500, 500, PosWindow.SWP_NOSIZE | PosWindow.SWP_NOZORDER);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Please enter valid values");
                    return;
                }
            }
        }
    }
}
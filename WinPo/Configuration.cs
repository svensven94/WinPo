using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinPo
{
    public partial class Configuration : Form
    {
        private int appCount = 0;
        private List<int> tmpValues = new List<int>();
        private string tmpName;
        private PosWindow.Rect tmpPosition = new PosWindow.Rect();

        public Configuration()
        {
            InitializeComponent();
            try
            {
                buildPanel();
            }
            catch
            {
            appCount += 1;
            AppPanel newPanel = new AppPanel();
            newPanel.Name = appCount.ToString();
            newPanel.Dock = DockStyle.Fill;
            tableUpper.Controls.Add(newPanel);
            }
        }

        private void Configuration_Load(object sender, EventArgs e)
        {
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            appCount += 1;
            AppPanel newPanel = new AppPanel();
            newPanel.Name = appCount.ToString();
            newPanel.Dock = DockStyle.Fill;
            tableUpper.Controls.Add(newPanel);
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            foreach (Control item in tableUpper.Controls.OfType<Control>())
            {
                if (item.Name == appCount.ToString())
                {
                    tableUpper.Controls.Remove(item);
                    appCount -= 1;
                    break;
                }
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Reset();
            Properties.Settings.Default.apps = new List<string>();

            Program.savedApps = new Dictionary<string, PosWindow.Rect>();
            //Program.savedContainers = new Dictionary<string, IContainerControl>();

            //List<string> appList = new List<string>();
            foreach (Control control in tableUpper.Controls.OfType<AppPanel>())
            {
                GetControl(control, getValues);
                if (!String.IsNullOrEmpty(tmpName))
                {
                    PosWindow.Rect position = new PosWindow.Rect()
                    {
                        Left = tmpValues[1],
                        Top = tmpValues[0]
                    };
                    Program.savedApps[tmpName] = position;
                    Properties.Settings.Default.apps.Add(tmpName + ";" + position.Left + ";" + position.Top);
                }

                tmpName = null;
                tmpValues = new List<int>();
            }

            Properties.Settings.Default.Save(); 
        }


        private void buttonLoad_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default == null)
            {
                MessageBox.Show("No saved configuration");
                return;
            }

            try
            {
                buildPanel();
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("No saved settings!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void buildPanel()
        {
            Program.savedApps = new Dictionary<string, PosWindow.Rect>();
            tableUpper.Controls.Clear();
            appCount = 0;

            importFromSettings();

            foreach (KeyValuePair<String, PosWindow.Rect> app in Program.savedApps)
            {
                AppPanel newPanel = new AppPanel(app.Key, app.Value);
                newPanel.Dock = DockStyle.Top;
                //newPanel.Anchor = AnchorStyles.Top;
                appCount += 1;
                newPanel.Name = appCount.ToString();
                tableUpper.Controls.Add(newPanel);
            }
        }

        private void buttonSetAll_Click(object sender, EventArgs e)
        {
            setPositions();
        }

        public static void importFromSettings()
        {
            foreach (String savedData in Properties.Settings.Default.apps)
            {
                string appName = savedData.Split(';')[0];
                PosWindow.Rect position = new PosWindow.Rect()
                {
                    Left = Int32.Parse(savedData.Split(';')[1]),
                    Top = Int32.Parse(savedData.Split(';')[2])
                };
                Program.savedApps.Add(appName, position);
            }
        }

        public static void setPositions()
        {
            foreach (KeyValuePair<String, PosWindow.Rect> app in Program.savedApps)
            {

                IntPtr hWnd = PosWindow.FindWindow(null, app.Key);
                if (hWnd != IntPtr.Zero)
                {
                    PosWindow.SetWindowPos(hWnd, IntPtr.Zero, app.Value.Left, app.Value.Top, 0, 0, PosWindow.SWP_NOSIZE | PosWindow.SWP_NOZORDER);
                }
            }
        }

       private void Configuration_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Close();
            }
        }

        private void buttonImportAll_Click(object sender, EventArgs e)
        {
            foreach (Control panel in tableUpper.Controls.OfType<AppPanel>())
            {

                GetControl(panel, putValues);
                tmpName = null;
                tmpPosition = new PosWindow.Rect();
            }
        }

        private void putValues(Control control)
        {
            if (control.GetType() == typeof(ComboBox))
            {
                ComboBox box = (ComboBox)control;
                if (box.SelectedIndex > -1)
                {
                    tmpName = box.SelectedItem.ToString();
                    IntPtr hWnd = PosWindow.FindWindow(null, tmpName);
                    if (hWnd != IntPtr.Zero)
                    {
                        //PosWindow.SetWindowPos(hWnd, IntPtr.Zero, 0, 0, 0, 0, PosWindow.SWP_NOSIZE | PosWindow.SWP_NOZORDER);
                        PosWindow.GetWindowRect(hWnd, ref tmpPosition);
                    }
                }
            }
            else if (control.GetType() == typeof(TextBox))
            {
                TextBox box = (TextBox)control;
                switch (box.Name)
                {
                    case "textPosTop":
                        box.Text = tmpPosition.Top.ToString();
                        break;
                    case "textPosLeft":
                        box.Text = tmpPosition.Left.ToString();
                        break;
                }
            }
        }

        private void getValues(Control control)
        {
            if (control.GetType() == typeof(ComboBox))
            {
                ComboBox box = (ComboBox)control;
                if (box.SelectedIndex > -1)
                {
                    String app = box.SelectedItem.ToString();
                    if (!Program.savedApps.ContainsKey(app))
                    {
                        Program.savedApps.Add(app, new PosWindow.Rect());
                        tmpName = app;
                    }
                }
            }
            else if (control.GetType() == typeof(TextBox))
            {
                TextBox box = (TextBox)control;
                if (!String.IsNullOrEmpty(box.Text))
                {
                    tmpValues.Add(Int32.Parse(box.Text.Trim()));
                }
            }
        }

        private void GetControl(Control parent, Action<Control> method)
        {
            foreach (Control control in parent.Controls)
            {
                if (control.GetType() == typeof(ComboBox) || control.GetType() == typeof(TextBox))
                {
                    method(control);
                }
                else
                {
                    GetControl(control, method);
                }
            }
        }
    }
}

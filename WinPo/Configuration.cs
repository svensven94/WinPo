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

        public Configuration()
        {
            InitializeComponent();
            appCount += 1;
            AppPanel newPanel = new AppPanel();
            newPanel.Name = appCount.ToString();
            newPanel.Dock = DockStyle.Fill;
            tableUpper.Controls.Add(newPanel);
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
            Program.savedContainers = new Dictionary<string, IContainerControl>();

            List<string> appList = new List<string>();
            foreach (Control control in tableUpper.Controls.OfType<AppPanel>())
            {
                iterControls(control);
                if (!String.IsNullOrEmpty(tmpName))
                {
                    PosWindow.Rect position = new PosWindow.Rect()
                    {
                        Left = tmpValues[0],
                        Top = tmpValues[1]
                    };
                    Program.savedApps[tmpName] = position;
                    Properties.Settings.Default.apps.Add(tmpName + ";" + position.Left + ";" + position.Top);
                }

                tmpName = null;
                tmpValues = new List<int>();
            }

            //string jsonString = JsonConvert.SerializeObject(Program.savedApps);
            //appList.Add(jsonString);

            //Properties.Settings.Default.apps.Add(jsonString);
            //Properties.Settings.Default.apps = appList;
            Properties.Settings.Default.Save(); // Saves settings in application configuration file
        }

        private void iterControls(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                //if(control.GetType() == typeof(SplitContainer))
                if (control.GetType() == typeof(ComboBox))
                {
                    ComboBox box = (ComboBox) control;
                    if (box.SelectedIndex > -1)
                    {
                        String app = box.SelectedItem.ToString();
                        Program.savedContainers.Add(app, control.GetContainerControl());
                        if (!Program.savedApps.ContainsKey(app))
                        {
                            Program.savedApps.Add(app, new PosWindow.Rect());
                            tmpName = app;
                        }
                    }
                }
                else if (control.GetType() == typeof(TextBox))
                {
                    TextBox box = (TextBox) control;
                    if (!String.IsNullOrEmpty(box.Text))
                    {
                        tmpValues.Add(Int32.Parse(box.Text.Trim()));
                    }
                }
                else if (control.GetType() == typeof(Button))
                {
                    return;
                }
                else
                {
                    iterControls(control);
                }
            }
        }
    }
}

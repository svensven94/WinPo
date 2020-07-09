using System;
using System.Collections.Generic;
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
        private Dictionary<string, int[]> savedApps = new Dictionary<string, int[]>();
        private int appCount = 1;

        public Configuration()
        {
            InitializeComponent();
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
    }
}

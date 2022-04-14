using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegKeys
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string namereg;
        private void Add_Reg_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
            namereg = f2.NameOfReg;
            for (int i = 0; i < RegistryList.Items.Count; i++)
            {
                if (namereg == RegistryList.Items[i].ToString()) { RegistryList.Items.RemoveAt(i); break; }
            }
            RegistryList.Items.Add(namereg);
        }

        private void GetRegVal_Click(object sender, EventArgs e)
        {
            RegTree.Items.Clear();
            RegistryKey key = Registry.CurrentUser.OpenSubKey(Path.Combine("Software", RegistryList.SelectedItem.ToString()));
            Dictionary<string, object> keyValuePairs;
            RegTree.Items.Add(key.View.ToString());
            using (var settingsRegKey = Registry.CurrentUser.OpenSubKey(Path.Combine("Software", namereg)))
            {
                var valueNames = settingsRegKey.GetValueNames();
                keyValuePairs = valueNames.ToDictionary(name => name, settingsRegKey.GetValue);
                foreach (var regkey in keyValuePairs)
                {
                    RegTree.Items.Add(regkey.ToString() + settingsRegKey.GetValue(regkey.ToString()));
                }
            }
        }

        private void DeleteReg_Click(object sender, EventArgs e)
        {
            Registry.CurrentUser.DeleteSubKeyTree(Path.Combine("Software", RegistryList.SelectedItem.ToString()));
            RegistryList.Items.RemoveAt(RegistryList.SelectedIndex);
            RegTree.Items.Clear();
        }

        private void Clear_RegTree_Click(object sender, EventArgs e)
        {
            RegTree.Items.Clear();
        }
    }
}

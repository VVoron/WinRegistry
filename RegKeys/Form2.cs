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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public string NameOfReg { get; set; }
        private void Add_Registry_Click(object sender, EventArgs e)
        {
            NameOfReg = NameReg.Text.ToString();
            string ValueOfOpt = ValueOptions.Text.ToString();
            RegistryKey key = Registry.CurrentUser.CreateSubKey(Path.Combine("Software", NameOfReg));
            key.SetValue(NameOptions.Text.ToString(), ValueOfOpt);
            NameReg.Enabled = false;
            Add_Registry.Enabled = false;
            ValueOptions.Clear();
            NameOptions.Clear();
        }

        private void Add_Option_Click(object sender, EventArgs e)
        {
            RegistryKey key = Registry.CurrentUser.CreateSubKey(Path.Combine("Software", NameOfReg));
            key.SetValue(NameOptions.Text.ToString(), ValueOptions.Text.ToString());
            ValueOptions.Clear();
            NameOptions.Clear();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatasetsProcessing
{
    public partial class SettingsWindow : Form
    {
        public SettingsWindow(Settings settings)
        {
            InitializeComponent();
            CheckBoxPath.Checked = settings.OriginalPath();
            RadioNum.Checked = !settings.OriginalName();
            RadioOrig.Checked = settings.OriginalName();
        }

        public bool IsRadioOrigChecked()
        {
            return RadioOrig.Checked;
        }

        public bool IsCheckBoxPathChecked()
        {
            return CheckBoxPath.Checked;
        }

        private void Save_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        
    }
}

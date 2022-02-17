using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BepInExConfigEditor
{
    public partial class Credits : Form
    {
        public Credits()
        {
            InitializeComponent();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            Form _creditsForm = this;
            _creditsForm.Close();
        }

        private void CreditsTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

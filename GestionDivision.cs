using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_Main_Project
{
    public partial class GestionDivision : Form
    {
        public GestionDivision()
        {
            InitializeComponent();
        }

        private void BTN_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BTN_Ok_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
       
    }
}

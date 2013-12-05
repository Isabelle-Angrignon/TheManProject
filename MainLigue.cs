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
    public partial class Form_League : Form
    {
        public Form_League()
        {
            InitializeComponent();
        }

        private void FLB_Division_Click(object sender, EventArgs e)
        {
            GestionDivision Form = new GestionDivision();
            if (Form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ///envoyer commit?
            }
        }
    }
}

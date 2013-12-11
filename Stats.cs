using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

namespace The_Main_Project
{
    public partial class Stats : Form
    {
        public Stats()
        {
            InitializeComponent();
        }
        public OracleConnection conn = new OracleConnection();
        private DataSet formDataSet = new DataSet();
        private const string dsTable = "Table";
        OracleDataAdapter Oraliste;
        string sqlTop5 = "select * from vuefiche";

        private void FB_Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Stats_Load(object sender, EventArgs e)
        {
            try
            {
                OracleDataAdapter Oraliste = new OracleDataAdapter(sqlTop5, conn);

                if (formDataSet.Tables.Contains(sqlTop5))
                {
                    formDataSet.Tables[sqlTop5].Clear();
                }
                Oraliste.Fill(formDataSet, sqlTop5);
                Oraliste.Dispose();

                BindingSource maSource = new BindingSource(formDataSet, sqlTop5);

                DGV_Top5.DataSource = maSource;
            }
            catch (Exception se) { MessageBox.Show(se.Message.ToString()); }
        }
    }
}

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
    public partial class Top5 : Form
    {
        public Top5()
        {
            InitializeComponent();
        }
        public OracleConnection conn = new OracleConnection();
        private DataSet formDataSet = new DataSet();
        private const string dsTable = "Table";
        OracleDataAdapter Oraliste;
        string sqlTop5 = "select * from vuefiche where rownum <= 5";

                private void FB_Close_Click(object sender, EventArgs e)
        {
             Close();
        }

        private void Top5_Load(object sender, EventArgs e)
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

        private void gestionJoueurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LaLigne = DGV_Top5.CurrentCellAddress.Y;
            int LaColonne = 0;
            int NoJoueur = int.Parse(DGV_Top5.Rows[LaLigne].Cells[LaColonne].Value.ToString());
            GestionJoueur Form = new GestionJoueur();
            Form.NoJoueur = NoJoueur;
            Form.conn = conn;
            Form.ShowDialog();
        }

        private void afficherStatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LaLigne = DGV_Top5.CurrentCellAddress.Y;
            int LaColonne = 0;
            int NoJoueur = int.Parse(DGV_Top5.Rows[LaLigne].Cells[LaColonne].Value.ToString());
            AfficherStat Form = new AfficherStat();
            Form.NoJoueur = NoJoueur;
            Form.conn = conn;
            Form.ShowDialog();
        }

        private void DGV_Top5_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                CMS.Show(Cursor.Position);

            }
        }

        
    }
}

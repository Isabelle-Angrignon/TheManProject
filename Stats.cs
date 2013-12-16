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
                ChangeColorMenu();
            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            catch (Exception se) { MessageBox.Show(se.Message.ToString()); }
        }
        private void ChangeColorMenu()
        {
            ChangeColorDGV();
            this.BackColor = Properties.Settings.Default.Back_Color;
            foreach (Control c in this.Controls)
            {
                if (c.GetType() == typeof(MenuStrip))
                {
                    c.BackColor = Properties.Settings.Default.Menu_Back;
                    c.ForeColor = Properties.Settings.Default.Label_Color;
                }
                if (c.GetType() == typeof(Label))
                    c.ForeColor = Properties.Settings.Default.Label_Color;

                if (c.GetType() == typeof(ContextMenu))
                {
                    c.BackColor = Properties.Settings.Default.Menu_Back;
                    c.ForeColor = Properties.Settings.Default.Label_Color;
                }
                if (c.GetType() == typeof(ContextMenuStrip))
                {
                    c.BackColor = Properties.Settings.Default.Menu_Back;
                    c.ForeColor = Properties.Settings.Default.Label_Color;
                }
                if (c.GetType() == typeof(Menu))
                {
                    c.BackColor = Properties.Settings.Default.Menu_Back;
                    c.ForeColor = Properties.Settings.Default.Label_Color;
                }
                if (c.GetType() == typeof(GroupBox))
                    c.ForeColor = Properties.Settings.Default.Label_Color;
                if (c.GetType() == typeof(RadioButton))
                    c.ForeColor = Properties.Settings.Default.Label_Color;

            }
        }
        private void ChangeColorDGV()
        {
            for (int i = 0; i < DGV_Top5.RowCount; i++)
            {
                if (i % 2 == 0)
                {
                    DGV_Top5.Rows[i].DefaultCellStyle.BackColor = Properties.Settings.Default.DGV_Pair;
                }
                else
                {
                    DGV_Top5.Rows[i].DefaultCellStyle.BackColor = Properties.Settings.Default.DGV_Impair;
                }
            }
        }


        private void DGV_Top5_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                CMS.Show(Cursor.Position);
            }
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

        private void DGV_Top5_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ChangeColorDGV();
        }


    }
}

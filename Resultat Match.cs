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
    public partial class Resultat_Match : Form
    {
        public Resultat_Match()
        {
            InitializeComponent();
        }
        public OracleConnection conn = new OracleConnection();
        private DataSet formDataSet = new DataSet();
        private const string dsTable = "Table";
        public int NoMatch;

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BTN_Ok_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LoadMatch()
        {
            try
            {
                OracleCommand oraCmdProg = new OracleCommand("select * From Matchs where NoMatch = " + NoMatch, conn);
                oraCmdProg.CommandType = CommandType.Text;
                OracleDataReader objRead = oraCmdProg.ExecuteReader();
                while (objRead.Read())
                {
                    LB_NoMatch.Text = objRead.GetInt32(0).ToString();
                    LB_Lieu_Result.Text = objRead.GetString(4);
                    char[] splitters = new char[] { ' ' };
                    string[] CeQueJeVeux = objRead.GetDateTime(3).Date.ToString().Split(splitters);
                    LB_DateMatch.Text = CeQueJeVeux[0];
                    LB_NomEquipe_R.Text = objRead.GetString(1);
                    LB_NomEquipe_V.Text = objRead.GetString(2);
                }
                objRead.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            } 
        }

        private void Resultat_Match_Load(object sender, EventArgs e)
        {
            LoadMatch();
            FillComboBox();
        }
        private void FillComboBox()
        {
            try
            {
                OracleCommand oraCmdProg = new OracleCommand("select * From Joueurs", conn);
                oraCmdProg.CommandType = CommandType.Text;
                OracleDataReader objRead = oraCmdProg.ExecuteReader();
                while (objRead.Read())
                {
                    if (objRead.GetString(6) == LB_NomEquipe_R.Text)
                    {
                        CBX_Choix_J_R.Items.Add(objRead.GetString(2) + objRead.GetString(1));
                    }
                    if (objRead.GetString(6) == LB_NomEquipe_V.Text)
                    {
                        CBX_Choix_J_V.Items.Add(objRead.GetString(2) + objRead.GetString(1));
                    }
                }
                CBX_Choix_J_R.SelectedIndex = 0;
                CBX_Choix_J_V.SelectedIndex = 0;
                objRead.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            } 
        }
    }
}

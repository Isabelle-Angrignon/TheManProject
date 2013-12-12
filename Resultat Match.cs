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
        OracleDataAdapter Oraliste;
        private int BindingNoJoueurR;
        private int BindingNoJoueurV;

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
            LoadDataset();
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
                        CBX_Choix_J_R.Items.Add(objRead.GetString(2) + " " + objRead.GetString(1));
                    }
                    if (objRead.GetString(6) == LB_NomEquipe_V.Text)
                    {
                        CBX_Choix_J_V.Items.Add(objRead.GetString(2)+ " " + objRead.GetString(1));
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

        private void CBX_Choix_J_V_SelectedIndexChanged(object sender, EventArgs e)
        {
            OracleCommand oraCmdProg = new OracleCommand("select prénom , Nom , NoMatch ,P.Nojoueur , NBREBUTS , NBREPASSES , TEMPSPUNITION" +
                " From Joueurs INNER JOIN PRÉSENCESMATCHS P ON P.NOJOUEUR = joueurs.nojoueur", conn);
            oraCmdProg.CommandType = CommandType.Text;
            OracleDataReader objRead = oraCmdProg.ExecuteReader();
            while (objRead.Read())
            {
                char[] splitters = new char[] { ' ' };
                string[] CeQueJeVeux = CBX_Choix_J_V.Text.Split(splitters);
                if (CeQueJeVeux[0] == objRead.GetString(0) && CeQueJeVeux[1] == objRead.GetString(1))
                {
                    LB_ID_V.Text = objRead.GetInt32(3).ToString();
                    TB_But_Visiteur.Text = objRead.GetInt32(4).ToString();
                    TB_Passes_Visiteur.Text = objRead.GetInt32(5).ToString();
                    TB_Pen_Visiteur.Text = objRead.GetInt32(6).ToString();
                }
            }
            objRead.Close();
            LoadDataset();
        }

        private void CBX_Choix_J_R_SelectedIndexChanged(object sender, EventArgs e)
        {
            OracleCommand oraCmdProg = new OracleCommand("select prénom , Nom , NoMatch ,P.Nojoueur , NBREBUTS , NBREPASSES , TEMPSPUNITION"+
                " From Joueurs INNER JOIN PRÉSENCESMATCHS P ON P.NOJOUEUR = joueurs.nojoueur", conn);
            oraCmdProg.CommandType = CommandType.Text;
            OracleDataReader objRead = oraCmdProg.ExecuteReader();
            while (objRead.Read())
            {
                char[] splitters = new char[] { ' ' };
                string[] CeQueJeVeux = CBX_Choix_J_R.Text.Split(splitters);
                if (CeQueJeVeux[0] == objRead.GetString(0) && CeQueJeVeux[1] == objRead.GetString(1))
                {
                    LB_ID_R.Text = objRead.GetInt32(3).ToString();
                    TB_But_R.Text = objRead.GetInt32(4).ToString();
                    TB_Passes_R.Text = objRead.GetInt32(5).ToString();
                    TB_Pen_R.Text = objRead.GetInt32(6).ToString();
                }
            }
            objRead.Close();
            LoadDataset();
        }

        private void LoadDataset()
        {
            try
            {
                string sqlShow = "Select * from PRÉSENCESMATCHS";////ou par nom, prénom
                Oraliste = new OracleDataAdapter(sqlShow, conn);
                if (formDataSet.Tables.Contains(dsTable))
                {
                    formDataSet.Tables[dsTable].Clear();
                }
                Oraliste.Fill(formDataSet, dsTable);
                Oraliste.Dispose();

                BindingSource maSource = new BindingSource(formDataSet, dsTable);
                Vider();
                Lister();
            }
            catch (Exception se) { MessageBox.Show(se.Message.ToString()); }
        }
        private void Lister()
        {
            
            
        }
        private void Vider()
        {
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}

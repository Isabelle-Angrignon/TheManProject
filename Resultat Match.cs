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
                string sqlMatch= "select * From Matchs where NoMatch = " + "'" + NoMatch + "'";
                OracleCommand oraCmdProg = new OracleCommand(sqlMatch, conn);
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
                    //6 ie colonne == équipe
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

        private void LoadDataset()//pour les DGV
        {
            try
            {
                string sqlShow = "Select * from PRÉSENCESMATCHS";
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
        ///////////////////////////////
        // boutons  + - mod
        //////////////////////////////
        private void BTN_Add_R_Click(object sender, EventArgs e)
        {
            try
            {
                //////  :NOMATCH, :NOJOUEUR, :NBREBUTS,:NBREPASSES,:TEMPSPUNITION   all numbers
                string sqlAdd = "INSERT INTO PRÉSENCESMATCHS VALUES (:NOMATCH, :NOJOUEUR, :BUTS,:PASSES,:PUNITION)";

                OracleParameter oParam = new OracleParameter(":NOMATCH", OracleDbType.Int32, 2);
                OracleParameter oParam = new OracleParameter(":NOJOUEUR", OracleDbType.Int32, 2);
                OracleParameter oParam = new OracleParameter(":BUTS", OracleDbType.Int32, 2);
                OracleParameter oParam = new OracleParameter(":PASSES", OracleDbType.Int32, 2);
                OracleParameter oParam = new OracleParameter(":PUNITION", OracleDbType.Int32, 2);

                oParamRecev.Value = TB_Receveur.Text;
                oParamVisit.Value = TB_Visiteur.Text;
                oParamDate.Value = DTP_Date.Value;
                oParamLieu.Value = TB_Lieu.Text;
                oParamButsR.Value = int.Parse(TB_R_Pts.Text);
                oParamButsV.Value = int.Parse(TB_V_Pts.Text);

                OracleCommand orComm = new OracleCommand(sqlAdd, conn);
                orComm.Parameters.Add(oParamRecev);
                orComm.Parameters.Add(oParamVisit);
                orComm.Parameters.Add(oParamDate);
                orComm.Parameters.Add(oParamLieu);
                orComm.Parameters.Add(oParamButsR);
                orComm.Parameters.Add(oParamButsV);
                orComm.ExecuteNonQuery();
                MessageBox.Show(" Le match à été ajouté");

                LoadDataset();
            }
            catch (OracleException ex)
            {
                ErrorMessage(ex);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void BTN_Del_R_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlDelete = "DELETE FROM matchs WHERE Nomatch = :NO";

                OracleParameter oParamNo = new OracleParameter(":NO", OracleDbType.Int32, 3);
                oParamNo.Value = int.Parse(LB_No_Match.Text);

                OracleCommand orComm = new OracleCommand(sqlDelete, conn);
                orComm.Parameters.Add(oParamNo);
                orComm.ExecuteNonQuery();

                LoadDataset();
                MessageBox.Show(" Le match à été suprimé");
            }
            catch (OracleException ex)
            {
                ErrorMessage(ex);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void BTN_Mod_R_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlUpdate = "UPDATE matchs SET Reveceur = :RECEV, Visiteur = :VISIT, datematch = :DATEMATCH," +
                " Lieu = :LIEU, butsreceveur = :BUTSR, butsvisiteur = :BUTSV WHERE Nomatch = :NO"; //requete met a jour

                OracleParameter oParamRecev = new OracleParameter(":RECEV", OracleDbType.Varchar2, 30);
                OracleParameter oParamVisit = new OracleParameter(":VISIT", OracleDbType.Varchar2, 30);
                OracleParameter oParamDate = new OracleParameter(":DATEMATCH", OracleDbType.Date);
                OracleParameter oParamLieu = new OracleParameter(":LIEU", OracleDbType.Varchar2, 30);
                OracleParameter oParamButsR = new OracleParameter(":BUTSR", OracleDbType.Int32, 2);
                OracleParameter oParamButsV = new OracleParameter(":BUTSV", OracleDbType.Int32, 2);
                OracleParameter oParamNo = new OracleParameter(":NO", OracleDbType.Int32, 3);

                oParamRecev.Value = TB_Receveur.Text;
                oParamVisit.Value = TB_Visiteur.Text;
                oParamDate.Value = DTP_Date.Value;
                oParamLieu.Value = TB_Lieu.Text;
                oParamButsR.Value = int.Parse(TB_R_Pts.Text);
                oParamButsV.Value = int.Parse(TB_V_Pts.Text);
                oParamNo.Value = int.Parse(LB_No_Match.Text);

                OracleCommand orComm = new OracleCommand(sqlUpdate, conn);
                orComm.Parameters.Add(oParamRecev);
                orComm.Parameters.Add(oParamVisit);
                orComm.Parameters.Add(oParamDate);
                orComm.Parameters.Add(oParamLieu);
                orComm.Parameters.Add(oParamButsR);
                orComm.Parameters.Add(oParamButsV);
                orComm.Parameters.Add(oParamNo);
                orComm.ExecuteNonQuery();

                MessageBox.Show(" Le match à été modifié");

                LoadDataset();
            }
            catch (OracleException ex)
            {
                ErrorMessage(ex);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void ErrorMessage(OracleException Ex)
        {
            switch (Ex.Number)
            {
                case 02290:
                    // au lieu d'afficher violation de clé étrangère , on affiche ceci:
                    MessageBox.Show("Entrée invalide");
                    break;
                case 01400:
                    MessageBox.Show("Il y à des champs vides");
                    break;
                default: MessageBox.Show(Ex.Message.ToString());
                    break;
            }
        }


       
        ///visiteur////////////////////////////////
        private void BTN_Add_V_Click(object sender, EventArgs e)
        {

        }

        private void BTN_Del_V_Click(object sender, EventArgs e)
        {

        }

        private void BTN_Mod_V_Click(object sender, EventArgs e)
        {

        }
    }
}

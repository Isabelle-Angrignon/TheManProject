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
    public partial class Form_League : Form
    {
        private OracleConnection conn = new OracleConnection();
        private DataSet mainDataSet = new DataSet();
        string sqlHoraire = "SELECT DATEMATCH AS Match, NOMATCH AS No , RECEVEUR AS Receveur , BUTSRECEVEUR AS B,  VISITEUR AS Visiteur ," +
            " BUTSVISITEUR AS B,  LIEU AS Cité  FROM Matchs ";
        string sqlClassement = "select sum(Nbpoints)as total ,equipe from classement  group by equipe order by total desc";///////////////
        private byte[] logo = null;
        private const string dsHoraire = "Liste_matchs";
        private string dsClassement = "Classement_équipes";
        OracleDataReader orLigue;

        public Form_League()
        {
            InitializeComponent();
        }

        private void FLB_Division_Click(object sender, EventArgs e)
        {
            OuvertureDivision();
        }
        private void OuvertureDivision()
        {
            GestionDivision Form = new GestionDivision();
            Form.conn = conn;
            if (Form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                UpdateComboBox();
            }
        }

        private void Form_League_Load(object sender, EventArgs e)
        {
            Connect();
            UpdateComboBox();
            FillDGVMatch();
            FillDGVEquipe(sqlClassement);
        }
        
        private void UpdateComboBox()
        {
            CBX_Division.Items.Clear();
            try
            {
                OracleCommand oraCmdProg = new OracleCommand("select NomDivision From Divisions", conn);
                oraCmdProg.CommandType = CommandType.Text;

                OracleDataReader objRead = oraCmdProg.ExecuteReader();
                
                CBX_Division.Items.Add("(Toutes)");
                while (objRead.Read())
                {
                    CBX_Division.Items.Add(objRead.GetString(0));
                }                

                CBX_Division.SelectedIndex = 0;
                objRead.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            } 

        }
        private void Connect()
        {
            try
            {
                string Dsource = "(DESCRIPTION="
                + "(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)"
                + "(HOST=205.237.244.251)(PORT=1521)))"
                + "(CONNECT_DATA=(SERVICE_NAME=ORCL)))";

                String ChaineConnexion = "Data Source=" + Dsource
                + ";User Id = simon007; Password =  oracle1";
                conn.ConnectionString = ChaineConnexion;
                conn.Open();
                MessageBox.Show(conn.State.ToString());
            }
            catch (Exception ex) { MessageBox.Show(ex.Message.ToString());}
        }
        
        private void FillDGVMatch()
        {
            try
            {
                OracleDataAdapter Oraliste = new OracleDataAdapter(sqlHoraire, conn);

                if (mainDataSet.Tables.Contains(dsHoraire))
                {
                    mainDataSet.Tables[dsHoraire].Clear();
                }
                Oraliste.Fill(mainDataSet, dsHoraire);
                Oraliste.Dispose();

                BindingSource maSource = new BindingSource(mainDataSet, dsHoraire);

                DGV_Match.DataSource = maSource;
            }
            catch (Exception se) { MessageBox.Show(se.Message.ToString()); }
        }
                
        private void FillDGVEquipe(string sql)
        {
            try
            {
                OracleDataAdapter Oraliste = new OracleDataAdapter(sql, conn);

                if (mainDataSet.Tables.Contains(dsClassement))
                {
                    mainDataSet.Tables[dsClassement].Clear();
                }
                Oraliste.Fill(mainDataSet, dsClassement);
                Oraliste.Dispose();

                BindingSource maSource = new BindingSource(mainDataSet, dsClassement);

                DGV_Team.DataSource = maSource;
                //on selected item
                Vider();
                Lister();
                UpdateLogo();
               // PBX_Logo.DataBindings.Add("Image", mainDataSet, "Classement_équipes.logo", true);
            }
            catch (Exception se) { MessageBox.Show(se.Message.ToString()); }
        }
        private void UpdateLogo()
        {
            string sqlLogo = "SELECT logo FROM équipes where noméquipe = '" +
                DGV_Team.SelectedCells.ToString() + "'";
            OracleCommand CMD = new OracleCommand(sqlLogo, conn);
            CMD.CommandType = CommandType.Text;
            orLigue = CMD.ExecuteReader();
            while (orLigue.Read())
            {
         //      PBX_Logo.Image.Clone(     //(orLigue.GetString(0));
            }
            //récupérer le nom d'équipe du selected row du dgv
            //trouver ligne équivalente dans le data reader
            //associer le logo de cette ligne au CBX
        }
        private void Vider()
        {
            PBX_Logo.DataBindings.Clear();
            PBX_Logo.Image = null;
        }
        private void Lister()
        {
            PBX_Logo.DataBindings.Add("Image", mainDataSet, "Classement_équipes.logo", true);
        }
        

        private void OuvertureTop5()
        {
            Top5 Form = new Top5();
            Form.conn = conn;
            Form.ShowDialog();
        }

        private void FLB_Team_Click(object sender, EventArgs e)
        {
            OuvrireEquipe();

        }
        private void OuvrireEquipe()
        {
            GestionEquipe Form = new GestionEquipe();
            Form.conn = conn;
            if (Form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ///envoyer commit?
            }
        }

        private void flashButton1_Click(object sender, EventArgs e)
        {
            OuvrireJoueur();
        }
        private void OuvrireJoueur()
        {
            GestionJoueur Form = new GestionJoueur();
            Form.conn = conn;
            if (Form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ///envoyer commit?
            }
        }

        private void flashButton3_Click(object sender, EventArgs e)
        {
            OuvrireMatch();
        }

        private void OuvrireMatch()
        {
            GestionMatch Form = new GestionMatch();
            Form.conn = conn;
            if (Form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ///envoyer commit?
            }
        }

        private void FB_Top5_Click(object sender, EventArgs e)
        {
            OuvertureTop5();
        }

        private void flashButton4_Click(object sender, EventArgs e)
        {
            OuvrireResultat();
        }
        private void OuvrireResultat()
        {
            Resultat_Match Form = new Resultat_Match();
            Form.conn = conn;
            if (Form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ///envoyer commit?
            }
        }

        private void Form_League_SizeChanged(object sender, EventArgs e)
        {
            //constater nouvelle size, redimensionne éléments tels dgv en fonction de la nouvelle dimension
        }

        private void TSMI_Division_Click(object sender, EventArgs e)
        {
            OuvertureDivision();
        }

        private void TSMI_Equipe_Click(object sender, EventArgs e)
        {
            OuvrireEquipe();
        }

        private void TSMI_Joueur_Click(object sender, EventArgs e)
        {
            OuvrireJoueur();
        }

        private void TSMI_Match_Click(object sender, EventArgs e)
        {
            OuvrireMatch();
        }

        private void TSMI_Resultats_Click(object sender, EventArgs e)
        {
            OuvrireResultat();
        }

        private void OuvrireParam()
        {
            Parametre Form = new Parametre();
            if (Form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ///envoyer commit?
            }
        }

        private void TSMI_Themes_Click(object sender, EventArgs e)
        {
            OuvrireParam();
        }
        private void OuvrireStat()
        {
            Stats Form = new Stats();
            Form.conn = conn;
            Form.ShowDialog();
            
        }

        private void TSMI_Stats_Joueur_Click(object sender, EventArgs e)
        {
            OuvrireStat();
        }


        private void CBX_Division_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBX_Division.SelectedIndex == 0)
            {
                FillDGVEquipe(sqlClassement);
            }
            else
            {
                string sqlEquipeParDiv = "select sum(Nbpoints) as total, equipe from classement" +
                    " group by equipe having equipe in (select noméquipe from Équipes where" +
                    " nomdivision = '" + CBX_Division.SelectedItem.ToString() + "') order by total desc" ;
                FillDGVEquipe(sqlEquipeParDiv);
            }
        }


        private void FB_Close_Click(object sender, EventArgs e)
        {
            conn.Close();
            Application.Exit();
	}

        private void CMS_Match_Afficher_Click(object sender, EventArgs e)
        {
            OuvrireMatch();
        }

        private void CMS_Match_Modifier_Click(object sender, EventArgs e)
        {
            OuvrireMatch();
        }

        private void CMS_Match_Supprimer_Click(object sender, EventArgs e)
        {
            //doit supprimer l'élément sélectionné dans le DGV
        }

        


    }

   
}
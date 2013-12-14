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
        
        string sqlClassement = "select nomÉquipe as Équipe, sum(Nbpoints)as total from classement  group by nomÉquipe order by total desc";
        /private const string dsHoraire = "Liste_matchs";
        private string dsClassement = "Classement_équipes";        

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
                //Remplissage DGV Match avec dataadapter et dataset. 
                string sqlHoraire = "SELECT DATEMATCH AS Match, NOMATCH AS No , RECEVEUR AS Receveur , BUTSRECEVEUR AS B_R,  VISITEUR AS Visiteur ," +
                    " BUTSVISITEUR AS B_V,  LIEU AS Cité  FROM Matchs ";
                OracleDataAdapter Oraliste = new OracleDataAdapter(sqlHoraire, conn);

                if (mainDataSet.Tables.Contains("Liste_matchs"))
                {
                    mainDataSet.Tables["Liste_matchs"].Clear();
                }
                Oraliste.Fill(mainDataSet, "Liste_matchs");
                Oraliste.Dispose();

                BindingSource maSource = new BindingSource(mainDataSet, "Liste_matchs");

                DGV_Match.DataSource = maSource;
            }
            catch (Exception se) { MessageBox.Show(se.Message.ToString()); }
        }
                
        private void FillDGVEquipe(string sqlParticulier)
        {
            try
            {
                OracleDataAdapter Oraliste = new OracleDataAdapter(sqlParticulier, conn);

                if (mainDataSet.Tables.Contains("Classement_équipes"))
                {
                    mainDataSet.Tables["Classement_équipes"].Clear();
                }
                Oraliste.Fill(mainDataSet, "Classement_équipes");
                Oraliste.Dispose();

                BindingSource maSource = new BindingSource(mainDataSet, "Classement_équipes");

                DGV_Team.DataSource = maSource;
                //on selected item
                //Vider();
                //Lister();
                //UpdateLogo();
               // PBX_Logo.DataBindings.Add("Image", mainDataSet, "Classement_équipes.logo", true);
            }
            catch (Exception se) { MessageBox.Show(se.Message.ToString()); }
        }

        //afficher logo de l'équipe sélectionnée du DGV dans la picture box
        private void LoadLogo()
        {
        //    int LaLigne = DGV_Team.CurrentCellAddress.Y;
        //    int LaColonne = 1;
        //    string NomEquipe = DGV_Team.Rows[LaLigne].Cells[LaColonne].Value.ToString();
        //    string sqlLogo = "Select Logo from Équipes where noméquipe = '" + NomEquipe + "'";
        //    OracleCommand oraCmdProg = new OracleCommand(sqlLogo, conn);
        //    oraCmdProg.CommandType = CommandType.Text;

        //    OracleDataReader objRead = oraCmdProg.ExecuteReader();

        //    while (objRead.Read())
        //    {
        //        byte[] logo = objRead.GetByte(0);
        //    }  
        //    objRead.Close();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message.ToString());
        //    } 
        //    ////////
        //    if (logo_ != null)
        //        {
        //            using (MemoryStream ms = new MemoryStream(logo_)) 
        //            {
        //                PBX_Logo.Image = Image.FromStream(ms);
        //            }
        //        }    
        }

        private void UpdateLogo()
        {
            //string sqlLogo = "SELECT logo FROM équipes where noméquipe = '" +
            
            //    DGV_Team.SelectedCells.ToString() + "'";
            ////dataset
            //OracleDataAdapter Oraliste = new OracleDataAdapter(dsLogo, conn);

            //if (mainDataSet.Tables.Contains(dsLogo))
            //{
            //    mainDataSet.Tables[dsLogo].Clear();
            //}
            //Oraliste.Fill(mainDataSet, dsLogo);
            //Oraliste.Dispose();

            //BindingSource maSource = new BindingSource(mainDataSet, dsLogo);

            //DGV_Team.DataSource = maSource;
            ////on selected item
            //Vider();
            //Lister();
                

         //   OracleCommand CMD = new OracleCommand(sqlLogo, conn);
         //   CMD.CommandType = CommandType.Text;
         //   orLigue = CMD.ExecuteReader();
         //   while (orLigue.Read())
         //   {
         ////      PBX_Logo.Image.Clone(     //(orLigue.GetString(0));
         //   }
            //récupérer le nom d'équipe du selected row du dgv
            //trouver ligne équivalente dans le data reader
            //associer le logo de cette ligne au CBX
        }
        //private void Vider()
        //{
        //    PBX_Logo.DataBindings.Clear();
        //    PBX_Logo.Image = null;
        //}
        //private void Lister()
        //{
        //    PBX_Logo.DataBindings.Add("Image", mainDataSet, "Classement_équipes.logo", true);
        //}
        

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
            Form.ShowDialog();
        }

        private void flashButton1_Click(object sender, EventArgs e)
        {
            OuvrireJoueur();
        }
        private void OuvrireJoueur()
        {
            GestionJoueur Form = new GestionJoueur();
            Form.conn = conn;
            Form.ShowDialog();
        }

        private void flashButton3_Click(object sender, EventArgs e)
        {
            OuvrireMatch();
        }

        private void OuvrireMatch()
        {
            GestionMatch Form = new GestionMatch();
            Form.conn = conn;
            Form.ShowDialog();
        }

        private void FB_Top5_Click(object sender, EventArgs e)
        {
            OuvertureTop5();
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

        private void OuvrireParam()
        {
            Parametre Form = new Parametre();
            if (Form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //faire qquechose avec les settings
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
        //Quand on change de division, on n'affiche que les équipes de cette division
        private void CBX_Division_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Index 0 = "toutes les divisions donc on utilise la sql de classement std.
            if (CBX_Division.SelectedIndex == 0)
            {
                FillDGVEquipe(sqlClassement);
            }
            //Sinon, on affiche que les équipes de la division selectionnée.
            else
            {
                string sqlEquipeParDiv = "select nomÉquipe as équipe, sum(Nbpoints) as total  from classement" +
                    " group by nomÉquipe having nomÉquipe in (select noméquipe from Équipes where" +
                    " nomdivision = '" + CBX_Division.SelectedItem.ToString() + "') order by total desc" ;
                FillDGVEquipe(sqlEquipeParDiv);
            }
        }

        private void FB_Close_Click(object sender, EventArgs e)
        {
            conn.Close();
            Application.Exit();
	    }
        //Menu contextuel: appelle le form match pour le match sélectioné
        private void CMS_Match_Afficher_Click(object sender, EventArgs e)
        {
            int LaLigne = DGV_Match.CurrentCellAddress.Y;
            int LaColonne = 1;
            int NoMatch = int.Parse(DGV_Match.Rows[LaLigne].Cells[LaColonne].Value.ToString());
            GestionMatch Form = new GestionMatch();
            Form.NoMatch = NoMatch;
            Form.conn = conn;
            Form.ShowDialog();
        }
        //Menu contextuel: appelle le form résultat de match pour le match sélectioné
        private void CMS_Match_Modifier_Click(object sender, EventArgs e)
        {
            int LaLigne = DGV_Match.CurrentCellAddress.Y;
            int LaColonne = 1;
            int NoMatch = int.Parse(DGV_Match.Rows[LaLigne].Cells[LaColonne].Value.ToString());
            Resultat_Match Form = new Resultat_Match();
            Form.NoMatch = NoMatch;
            Form.conn = conn;
            Form.ShowDialog();
        }

        //Vérifie qu'on a cliqué avec bouton droit sur le DGV match et affiche le menu contextuel
        private void DGV_Match_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                CMS_Match.Show(Cursor.Position);                
            }
        }
        //Vérifie qu'on a cliqué avec bouton droit sur le DGV équipe et affiche le menu contextuel
        private void DGV_Team_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                CMS_Team.Show(Cursor.Position);
            }
        }

        //Menu contextuel: appelle le form équipe pour l'équipe sélectionnée
        private void CMS_Team_Afficher_Click(object sender, EventArgs e)
        {
            int LaLigne = DGV_Team.CurrentCellAddress.Y;
            int LaColonne = 1;
            string NomEquipe = DGV_Team.Rows[LaLigne].Cells[LaColonne].Value.ToString();
            GestionEquipe Form = new GestionEquipe();
            Form.NomEquipe = NomEquipe;
            Form.conn = conn;
            Form.ShowDialog();
        }

        private void TSMI_A_Propos_Click(object sender, EventArgs e)
        {
            A_Propos Form = new A_Propos();
            Form.ShowDialog();
        }
    }   
}
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

        /////////////////////////////////////////////////
        //Pour valider l'entrée des buts, passes et pénalités
        const char BACKSPACE = '\b';
        bool EstChiffre(char c)
        {
            String chiffres = "0123456789";
            return (chiffres.IndexOf(c.ToString()) != -1);
        }
        private void TB_Chiffres_Seulement_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != BACKSPACE)
                e.Handled = !EstChiffre(e.KeyChar);
        }
        /////////////////////////////////////////////////

        private void BTN_Ok_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void LoadMatch()
        {
            try
            {
                //Pour remplir l'entête du formulaire: sur quel match on av travailler...
                //no match assigné par la fenêtre appelante.
                string sqlMatch= "select * From Matchs where NoMatch = " + "'" + NoMatch + "'";
                OracleCommand oraCmdProg = new OracleCommand(sqlMatch, conn);
                oraCmdProg.CommandType = CommandType.Text;
                OracleDataReader objRead = oraCmdProg.ExecuteReader();
                while (objRead.Read())
                {                    
                    LB_NoMatch.Text = objRead.GetInt32(0).ToString();
                    LB_Lieu_Result.Text = objRead.GetString(4);

                    //Truc compliqué qui récupère la portion date du format date/heure
                    char[] splitters = new char[] { ' ' };
                    string[] CeQueJeVeux = objRead.GetDateTime(3).Date.ToString().Split(splitters);
                    LB_DateMatch.Text = CeQueJeVeux[0];

                    LB_NomEquipe_R.Text = objRead.GetString(1);
                    LB_NomEquipe_V.Text = objRead.GetString(2);
                }
                objRead.Close();
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

        private void Resultat_Match_Load(object sender, EventArgs e)
        {
            LoadMatch();
            FillComboBox();
            ChangeColorMenu();
            ChangeColorDGV();
        }

        //Remplir les deux menus déroulants avec la liste des joueurs de chaque équipe impliquées dans le match
        //Appelle aussi le remplissage des DGV en changeant l'index des combo box.
        private void FillComboBox()
        {
            try
            {
                OracleCommand oraCmdProg = new OracleCommand("select * From Joueurs", conn);
                oraCmdProg.CommandType = CommandType.Text;
                OracleDataReader objRead = oraCmdProg.ExecuteReader();
                while (objRead.Read())
                {
                    //Vérifie chacun des joueurs de la table joueur et l'ajoute à une liste si 
                    //son équipe participe au match en tant que receveur ou visiteur
                    if (objRead.GetString(6) == LB_NomEquipe_R.Text)
                    {
                        CBX_Choix_J_R.Items.Add(objRead.GetString(2) + " " + objRead.GetString(1));
                    }
                    if (objRead.GetString(6) == LB_NomEquipe_V.Text)
                    {
                        CBX_Choix_J_V.Items.Add(objRead.GetString(2)+ " " + objRead.GetString(1));
                    }
                }
                 try
                {
                    //Faire afficher le premier joueur de la liste
                    CBX_Choix_J_R.SelectedIndex = 0;
                    CBX_Choix_J_V.SelectedIndex = 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Il n'y a pas de joueur entré dans l'équipe");
                }
                objRead.Close();
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

        //Si on change de joueur dans un menu déroulant, on rempli les champs buts-passes-pénalité
        //avec ses valeurs personnelles pour ce match
        private void CBX_Choix_J_V_SelectedIndexChanged(object sender, EventArgs e)

        {
            string sqlMatchEquipe = "SELECT Prénom , Nom , NoMatch , J.Nojoueur , NbreButs , NbrePasses , "+
                "TempsPunition FROM (SELECT Prénom , Nom , J.Nojoueur, J.NomÉquipe FROM Joueurs J "+
                "  INNER JOIN Équipes E on E.NomÉquipe = J.NomÉquipe where E.NomÉquipe = '" +
                 LB_NomEquipe_V.Text + "')J LEFT OUTER JOIN PrésencesMatchs P ON P.NoJoueur = J.NoJoueur";
                       

            OracleCommand oraCmdProg = new OracleCommand(sqlMatchEquipe, conn);
            oraCmdProg.CommandType = CommandType.Text;
            OracleDataReader objRead = oraCmdProg.ExecuteReader();
            while (objRead.Read())
            {
                char[] splitters = new char[] { ' ' };
                string[] CeQueJeVeux = CBX_Choix_J_V.Text.Split(splitters);
                if (CeQueJeVeux[0] == objRead.GetString(0) && CeQueJeVeux[1] == objRead.GetString(1))
                {                   
                    LB_ID_V.Text = objRead.GetInt32(3).ToString();
                    if (objRead.IsDBNull(4))                    
                    {
                        TB_But_Visiteur.Clear();
                    }
                    else
                    {
                        TB_But_Visiteur.Text = objRead.GetInt32(4).ToString();
                    }
                    if (objRead.IsDBNull(5))
                    {
                        TB_Passes_Visiteur.Clear();
                    }
                    else
                    {
                        TB_Passes_Visiteur.Text = objRead.GetInt32(5).ToString();
                    }
                    if (objRead.IsDBNull(6))
                    {
                        TB_Pen_Visiteur.Clear();
                    }
                    else
                    {
                        TB_Pen_Visiteur.Text = objRead.GetInt32(6).ToString();
                    }               
                    
                }
            }
            objRead.Close();
            LoadDatasetV();
        }        
       
        private void CBX_Choix_J_R_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sqlMatchEquipe = "SELECT Prénom , Nom , NoMatch , J.Nojoueur , NbreButs , NbrePasses , TempsPunition FROM (SELECT Prénom , Nom , J.Nojoueur, J.NomÉquipe FROM Joueurs J   INNER JOIN Équipes E on E.NomÉquipe = J.NomÉquipe where E.NomÉquipe = '" + LB_NomEquipe_R.Text + "')J LEFT OUTER JOIN PrésencesMatchs P ON P.NoJoueur = J.NoJoueur";

            OracleCommand oraCmdProg = new OracleCommand(sqlMatchEquipe, conn);
            oraCmdProg.CommandType = CommandType.Text;
            OracleDataReader objRead = oraCmdProg.ExecuteReader();
            while (objRead.Read())
            {
                char[] splitters = new char[] { ' ' };
                string[] CeQueJeVeux = CBX_Choix_J_R.Text.Split(splitters);
                if (CeQueJeVeux[0] == objRead.GetString(0) && CeQueJeVeux[1] == objRead.GetString(1))
                {
                    LB_ID_R.Text = objRead.GetInt32(3).ToString();
                    
                    if (objRead.IsDBNull(4))
                    {
                        TB_But_R.Clear();
                    }
                    else
                    {
                        TB_But_R.Text = objRead.GetInt32(4).ToString();
                    }
                    if (objRead.IsDBNull(5))
                    {
                        TB_Passes_R.Clear();
                    }
                    else
                    {
                        TB_Passes_R.Text = objRead.GetInt32(5).ToString();
                    }
                    if (objRead.IsDBNull(6))
                    {
                        TB_Pen_R.Clear();
                    }
                    else
                    {
                        TB_Pen_R.Text = objRead.GetInt32(6).ToString();
                    }   
                }
            }
            objRead.Close();
            LoadDatasetR();           
        }

        private void LoadDatasetR()//pour le DGV de l'équipe qui reçoit.
        {
            try
            {                
                //Afficher tous les joueurs et leurs b/p/p participant à un match dans l'équipe qui reçoit.
                string sqlShow = "Select J.nojoueur as no, nom, prénom, nbrebuts as b, nbrepasses as p, "+
                    "tempspunition as pen from PRÉSENCESMATCHS P inner join joueurs J "+
                    "on P.nojoueur = J.nojoueur where nomatch = " + LB_NoMatch.Text + 
                    " AND P.nojoueur in (select nojoueur FROM Joueurs where noméquipe in "+
                    "(select receveur from matchs where receveur = '" + LB_NomEquipe_R.Text + "'))";
                               
                Oraliste = new OracleDataAdapter(sqlShow, conn);

                if (formDataSet.Tables.Contains("Receveur"))
                {
                    formDataSet.Tables["Receveur"].Clear();
                }
                Oraliste.Fill(formDataSet, "Receveur");
                Oraliste.Dispose();

                BindingSource maSource = new BindingSource(formDataSet, "Receveur");
                DGV_ListeJoueur_R.DataSource = maSource;                
            }
            catch (OracleException ex)
            {
                ErrorMessage(ex);
            }
            catch (Exception se) { MessageBox.Show(se.Message.ToString()); }
        }
       
        private void LoadDatasetV()//pour le DGV de l'équipe qui visite.
        {
            try
            {
                //Afficher tous les joueurs et leurs b/p/p participant à un match dans l'équipe qui visite.
                string sqlShow = "Select J.nojoueur as no, nom, prénom, nbrebuts as b, nbrepasses as p, " +
                    "tempspunition as pen from PRÉSENCESMATCHS P inner join joueurs J " +
                    "on P.nojoueur = J.nojoueur where nomatch = " + LB_NoMatch.Text +
                    " AND P.nojoueur in (select nojoueur FROM Joueurs where noméquipe in " +
                    "(select visiteur from matchs where Visiteur = '" + LB_NomEquipe_V.Text + "'))";

                Oraliste = new OracleDataAdapter(sqlShow, conn);

                if (formDataSet.Tables.Contains("Visiteur"))
                {
                    formDataSet.Tables["Visiteur"].Clear();
                }
                Oraliste.Fill(formDataSet, "Visiteur");
                Oraliste.Dispose();

                BindingSource maSource = new BindingSource(formDataSet, "Visiteur");
                DGV_ListeJoueur_V.DataSource = maSource;
            }
            catch (OracleException ex)
            {
                ErrorMessage(ex);
            }
            catch (Exception se) { MessageBox.Show(se.Message.ToString()); }
        } 
        ///////////////////////////////
        // boutons  + - mod
        //////////////////////////////

        ///receveur///////////////////////////////
        private void BTN_Add_R_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlAdd = "INSERT INTO PRÉSENCESMATCHS VALUES (:NOMATCH, :NOJOUEUR, :BUTS,:PASSES,:PUNITION)";

                OracleParameter oParamMatch = new OracleParameter(":NOMATCH", OracleDbType.Int32, 3);
                OracleParameter oParamJoueur = new OracleParameter(":NOJOUEUR", OracleDbType.Int32, 4);
                OracleParameter oParamButs = new OracleParameter(":BUTS", OracleDbType.Int32, 2);
                OracleParameter oParamPasses = new OracleParameter(":PASSES", OracleDbType.Int32, 2);
                OracleParameter oParamPunit = new OracleParameter(":PUNITION", OracleDbType.Int32, 3);

                oParamMatch.Value = int.Parse(LB_NoMatch.Text);
                oParamJoueur.Value = int.Parse(LB_ID_R.Text);
                oParamButs.Value = int.Parse(TB_But_R.Text);
                oParamPasses.Value = int.Parse(TB_Passes_R.Text);
                oParamPunit.Value = int.Parse(TB_Pen_R.Text);

                OracleCommand orComm = new OracleCommand(sqlAdd, conn);
                orComm.Parameters.Add(oParamMatch);
                orComm.Parameters.Add(oParamJoueur);
                orComm.Parameters.Add(oParamButs);
                orComm.Parameters.Add(oParamPasses);
                orComm.Parameters.Add(oParamPunit);                
                orComm.ExecuteNonQuery();
                MessageBox.Show("Le joueur a été ajouté au match");

                LoadDatasetR();
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
                string sqlDelete = "DELETE FROM PRÉSENCESMATCHS WHERE Nomatch = :NOMATCH AND NoJoueur = :NOJOUEUR";

                OracleParameter oParamNo = new OracleParameter(":NOMATCH", OracleDbType.Int32, 3);
                OracleParameter oParamNumber = new OracleParameter(":NOJOUEUR", OracleDbType.Int32, 4);
                oParamNo.Value = int.Parse(LB_NoMatch.Text);
                oParamNumber.Value = int.Parse(LB_ID_R.Text);

                OracleCommand orComm = new OracleCommand(sqlDelete, conn);
                orComm.Parameters.Add(oParamNo);
                orComm.Parameters.Add(oParamNumber);
                int res = orComm.ExecuteNonQuery();

                LoadDatasetR();                  
                MessageBox.Show(res + " participation supprimée avec succès");
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
                string sqlUpdate = "UPDATE PrésencesMatchs SET nbrebuts = :BUTS, nbrepasses = :PASSES, "+
                    "tempspunition = :PEN WHERE Nomatch = :NOMATCH AND NoJoueur = :NOJOUEUR"; //requete met a jour
                                
                OracleParameter oParamButs = new OracleParameter(":BUTS", OracleDbType.Int32, 2);
                OracleParameter oParamPasses = new OracleParameter(":PASSES", OracleDbType.Int32, 2);
                OracleParameter oParamPunit = new OracleParameter(":PUNITION", OracleDbType.Int32, 3);
                OracleParameter oParamMatch = new OracleParameter(":NOMATCH", OracleDbType.Int32, 3);
                OracleParameter oParamJoueur = new OracleParameter(":NOJOUEUR", OracleDbType.Int32, 4);

                oParamButs.Value = int.Parse(TB_But_R.Text);
                oParamPasses.Value = int.Parse(TB_Passes_R.Text);
                oParamPunit.Value = int.Parse(TB_Pen_R.Text);
                oParamMatch.Value = int.Parse(LB_NoMatch.Text);
                oParamJoueur.Value = int.Parse(LB_ID_R.Text);

                OracleCommand orComm = new OracleCommand(sqlUpdate, conn);
                
                orComm.Parameters.Add(oParamButs);
                orComm.Parameters.Add(oParamPasses);
                orComm.Parameters.Add(oParamPunit);
                orComm.Parameters.Add(oParamMatch);
                orComm.Parameters.Add(oParamJoueur);                
                orComm.ExecuteNonQuery();

                MessageBox.Show("La participation au match a été modifiée");
                LoadDatasetR();
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
                    MessageBox.Show("Il y a des champs vides");
                    break;
                default: MessageBox.Show(Ex.Message.ToString());
                    break;
            }
        }
               
        ///visiteur////////////////////////////////
        private void BTN_Add_V_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlAdd = "INSERT INTO PRÉSENCESMATCHS VALUES (:NOMATCH, :NOJOUEUR, :BUTS,:PASSES,:PUNITION)";

                OracleParameter oParamMatch = new OracleParameter(":NOMATCH", OracleDbType.Int32, 3);
                OracleParameter oParamJoueur = new OracleParameter(":NOJOUEUR", OracleDbType.Int32, 4);
                OracleParameter oParamButs = new OracleParameter(":BUTS", OracleDbType.Int32, 2);
                OracleParameter oParamPasses = new OracleParameter(":PASSES", OracleDbType.Int32, 2);
                OracleParameter oParamPunit = new OracleParameter(":PUNITION", OracleDbType.Int32, 3);

                oParamMatch.Value = int.Parse(LB_NoMatch.Text);
                oParamJoueur.Value = int.Parse(LB_ID_V.Text);
                oParamButs.Value = int.Parse(TB_But_Visiteur.Text);
                oParamPasses.Value = int.Parse(TB_Passes_Visiteur.Text);
                oParamPunit.Value = int.Parse(TB_Pen_Visiteur.Text);

                OracleCommand orComm = new OracleCommand(sqlAdd, conn);
                orComm.Parameters.Add(oParamMatch);
                orComm.Parameters.Add(oParamJoueur);
                orComm.Parameters.Add(oParamButs);
                orComm.Parameters.Add(oParamPasses);
                orComm.Parameters.Add(oParamPunit);
                orComm.ExecuteNonQuery();
                MessageBox.Show(" Le joueur a été ajouté au match");

                LoadDatasetV();
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

        private void BTN_Del_V_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlDelete = "DELETE FROM PRÉSENCESMATCHS WHERE Nomatch = :NOMATCH AND NoJoueur = :NOJOUEUR";

                OracleParameter oParamNo = new OracleParameter(":NOMATCH", OracleDbType.Int32, 3);
                OracleParameter oParamNumber = new OracleParameter(":NOJOUEUR", OracleDbType.Int32, 4);
                oParamNo.Value = int.Parse(LB_NoMatch.Text);
                oParamNumber.Value = int.Parse(LB_ID_V.Text);

                OracleCommand orComm = new OracleCommand(sqlDelete, conn);
                orComm.Parameters.Add(oParamNo);
                orComm.Parameters.Add(oParamNumber);
                int res = orComm.ExecuteNonQuery();

                LoadDatasetV();
                MessageBox.Show(res + " participation supprimée avec succès");
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

        private void BTN_Mod_V_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlUpdate = "UPDATE PrésencesMatchs SET nbrebuts = :BUTS, nbrepasses = :PASSES, " +
                    "tempspunition = :PEN WHERE Nomatch = :NOMATCH AND NoJoueur = :NOJOUEUR"; //requete met a jour

                OracleParameter oParamButs = new OracleParameter(":BUTS", OracleDbType.Int32, 2);
                OracleParameter oParamPasses = new OracleParameter(":PASSES", OracleDbType.Int32, 2);
                OracleParameter oParamPunit = new OracleParameter(":PUNITION", OracleDbType.Int32, 3);
                OracleParameter oParamMatch = new OracleParameter(":NOMATCH", OracleDbType.Int32, 3);
                OracleParameter oParamJoueur = new OracleParameter(":NOJOUEUR", OracleDbType.Int32, 4);

                oParamButs.Value = int.Parse(TB_But_Visiteur.Text);
                oParamPasses.Value = int.Parse(TB_Passes_Visiteur.Text);
                oParamPunit.Value = int.Parse(TB_Pen_Visiteur.Text);
                oParamMatch.Value = int.Parse(LB_NoMatch.Text);
                oParamJoueur.Value = int.Parse(LB_ID_V.Text);

                OracleCommand orComm = new OracleCommand(sqlUpdate, conn);

                orComm.Parameters.Add(oParamButs);
                orComm.Parameters.Add(oParamPasses);
                orComm.Parameters.Add(oParamPunit);
                orComm.Parameters.Add(oParamMatch);
                orComm.Parameters.Add(oParamJoueur);
                orComm.ExecuteNonQuery();

                MessageBox.Show(" La participation au match a été modifiée");
                LoadDatasetV();
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
        private void ChangeColorMenu()
        {
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
            for (int i = 0; i < DGV_ListeJoueur_R.RowCount; i++)
            {
                if (i % 2 == 0)
                {
                    DGV_ListeJoueur_R.Rows[i].DefaultCellStyle.BackColor = Properties.Settings.Default.DGV_Pair;
                }
                else
                {
                    DGV_ListeJoueur_R.Rows[i].DefaultCellStyle.BackColor = Properties.Settings.Default.DGV_Impair;
                }
            }
            for (int i = 0; i < DGV_ListeJoueur_V.RowCount; i++)
            {
                if (i % 2 == 0)
                {
                    DGV_ListeJoueur_V.Rows[i].DefaultCellStyle.BackColor = Properties.Settings.Default.DGV_Pair;
                }
                else
                {
                    DGV_ListeJoueur_V.Rows[i].DefaultCellStyle.BackColor = Properties.Settings.Default.DGV_Impair;
                }
            }
        }
    }
}

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
    public partial class GestionMatch : Form
    {
        public GestionMatch()
        {
            InitializeComponent();
        }

        public OracleConnection conn = new OracleConnection();
        private DataSet formDataSet = new DataSet();
        private const string dsTable = "Table";
        OracleDataAdapter Oraliste;        

        private void BTN_Ok_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void GestionMatch_Load(object sender, EventArgs e)
        {
            LoadDataset();
          //  AutoCompletePosition();
          //  AutoCompleteEquipe();
        }

        private void AutoCompleteEquipe()
        {
            try
            {
                OracleCommand oraCmdProg = new OracleCommand("select NomÉquipe From JOUEURS", conn);
                oraCmdProg.CommandType = CommandType.Text;

                OracleDataReader objRead = oraCmdProg.ExecuteReader();
                while (objRead.Read())
                {
                    TB_Équipe.AutoCompleteCustomSource.Add(objRead.GetString(0));
                }
                TB_Équipe.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                TB_Équipe.AutoCompleteSource = AutoCompleteSource.CustomSource;
                objRead.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
        private void AutoCompletePosition()
        {
            char[] séparateur = { '\r', '\n' };
            String[] Positions = The_Main_Project.Properties.Resources.Position.Split(séparateur, StringSplitOptions.RemoveEmptyEntries);

            foreach (String position in Positions)
            {
                TB_Position.AutoCompleteCustomSource.Add(position);
            }

            TB_Position.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            TB_Position.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }
        
        private void LoadDataset()
        {
            try
            {
                string sqlShow = "Select * from matchs order by nomatch";////ou par nom, prénom
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
            DTP_Date.DataBindings.Add("Text", formDataSet, "Table.datematch");
            TB_Lieu.DataBindings.Add("Text", formDataSet, "Table.lieu");
            TB_Receveur.DataBindings.Add("Text", formDataSet, "Table.receveur");
            TB_Visiteur.DataBindings.Add("Text", formDataSet, "Table.visiteur");
            TB_R_Pts.DataBindings.Add("Text", formDataSet, "Table.butesreceveur");
            TB_V_Pts.DataBindings.Add("Text", formDataSet, "Table.butsvisiteur");
        }
        private void Vider()
        {
            DTP_Date.DataBindings.Clear();
            TB_Lieu.DataBindings.Clear();
            TB_Receveur.DataBindings.Clear();
            TB_Visiteur.DataBindings.Clear();
            TB_R_Pts.DataBindings.Clear();
            TB_V_Pts.DataBindings.Clear();

            DTP_Date.Value = DateTime.Now;
            TB_Lieu.Clear();
            TB_Receveur.Clear();
            TB_Visiteur.Clear();
            TB_R_Pts.Clear();
            TB_V_Pts.Clear();
            
        }

        private void uC_Navigator_OnFirst(object sender, EventArgs e)
        {
            this.BindingContext[formDataSet, dsTable].Position = 0;            
        }

        private void uC_Navigator_OnLast(object sender, EventArgs e)
        {
            this.BindingContext[formDataSet, dsTable].Position =
                this.BindingContext[formDataSet, dsTable].Count - 1;            
        }
        private void uC_Navigator_OnNext(object sender, EventArgs e)
        {
            this.BindingContext[formDataSet, dsTable].Position += 1;
        }

        private void uC_Navigator_OnPrev(object sender, EventArgs e)
        {
            this.BindingContext[formDataSet, dsTable].Position -= 1;
        }
        private void BTN_Add_Click(object sender, EventArgs e)
        {
            try
            {
               // string Nom = TB_Prenom_J.Text + " " + TB_Nom_J.Text;
                string sqlAdd = "INSERT INTO Matchs VALUES (SeqMatchs.nextval,:RECEV,:VISIT," +
                    " :DATEMATCH, :LIEU, BUTSR, :BUTSV)";

                OracleParameter oParamRecev = new OracleParameter(":RECEV", OracleDbType.Varchar2, 20);
                OracleParameter oParamVisit = new OracleParameter(":VISIT", OracleDbType.Varchar2, 20);
                OracleParameter oParamDate = new OracleParameter(":DATEMATCH", OracleDbType.Date);
                OracleParameter oParamLieu = new OracleParameter(":LIEU", OracleDbType.Varchar2, 1);
                OracleParameter oParamButsR = new OracleParameter(":BUTSR", OracleDbType.Varchar2, 2);
                OracleParameter oParamButsV = new OracleParameter(":BUTSV", OracleDbType.Varchar2, 30);

                oParamRecev.Value = TB_Receveur.Text;
                oParamVisit.Value = TB_Visiteur.Text;
                oParamDate.Value = DTP_Date.Value;
                oParamLieu.Value = TB_Lieu.Text[0];
                oParamButsR.Value = TB_R_Pts.Text;
                oParamButsV.Value = TB_V_Pts.Text;

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

        private void BTN_Del_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlDelete = "DELETE FROM Joueurs WHERE NoJoueur = :NO";
                string Nom = TB_Prenom_J.Text + " " + TB_Nom_J.Text;
                OracleParameter oParamNo = new OracleParameter(":NO", OracleDbType.Int32, 4);
                oParamNo.Value = int.Parse(LB_No_J.Text);

                OracleCommand orComm = new OracleCommand(sqlDelete, conn);
                orComm.Parameters.Add(oParamNo);
                orComm.ExecuteNonQuery();

                LoadDataset();
                MessageBox.Show(" Le joueur " + Nom + " a été suprimer");
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

        private void BTN_Edit_Click(object sender, EventArgs e)
        {
            try
            {
                /////enregistrer la clé primaire d'abord pour pouvoir la modifier...  
                string Nom = TB_Prenom_J.Text + " " + TB_Nom_J.Text;
                string sqlUpdate = "UPDATE Joueurs SET Nom = :NOM, Prénom = :PRENOM, Naissance = :Naissance," +
                " Position = :POSITION, nomaillot = :MAILLOT, NomÉquipe = :EQUIPE WHERE NoJoueur = :NO"; //requete met a jour

                OracleParameter oParamNom = new OracleParameter(":NOM", OracleDbType.Varchar2, 20);
                OracleParameter oParamPrenom = new OracleParameter(":PRENOM", OracleDbType.Varchar2, 20);
                OracleParameter oParamDate = new OracleParameter(":NAISSANCE", OracleDbType.Date);
                OracleParameter oParamPos = new OracleParameter(":POSITION", OracleDbType.Varchar2, 1);
                OracleParameter oParamMail = new OracleParameter(":MAILLOT", OracleDbType.Int32, 2);
                OracleParameter oParamEqu = new OracleParameter(":EQUIPE", OracleDbType.Varchar2, 30);
                OracleParameter oParamNo = new OracleParameter(":NO", OracleDbType.Int32, 4);
                oParamNom.Value = TB_Nom_J.Text;
                oParamPrenom.Value = TB_Prenom_J.Text;
                oParamDate.Value = DTP_Naissance.Value;
                oParamPos.Value = TB_Position.Text[0];
                oParamMail.Value = int.Parse(TB_Maillot.Text);
                oParamEqu.Value = TB_Équipe.Text;
                oParamNo.Value = int.Parse(LB_No_J.Text);

                OracleCommand orComm = new OracleCommand(sqlUpdate, conn);
                orComm.Parameters.Add(oParamNom);
                orComm.Parameters.Add(oParamPrenom);
                orComm.Parameters.Add(oParamDate);
                orComm.Parameters.Add(oParamPos);
                orComm.Parameters.Add(oParamMail);
                orComm.Parameters.Add(oParamEqu);
                orComm.Parameters.Add(oParamNo);
                orComm.ExecuteNonQuery();
                MessageBox.Show(" Le joueur " + Nom + " a été modifier");

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

        private void BTN_Stats_Click(object sender, EventArgs e)
        {
            AfficherStat Form = new AfficherStat();
            Form.NoJoueur = int.Parse(LB_No_J.Text);
            Form.conn = conn;
            Form.ShowDialog();
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
                    MessageBox.Show("Il y a des champs vide");
                    break;
                default: MessageBox.Show(Ex.Message.ToString());
                    break;

            }
        }

        private void FB_Fiche_Resultat_Click(object sender, EventArgs e)
        {
            OuvrireResultat();
        }        
        private void OuvrireResultat()
        {
            Resultat_Match Form = new Resultat_Match();
            //ajouter params du match sélectionner
            Form.conn = conn;
            if (Form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ///envoyer commit?
            }
    }
}

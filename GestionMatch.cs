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
            AutoCompleteVisiteur();
            AutoCompleteReceveur();
        }

        private void AutoCompleteReceveur()
        {
            try
            {
                OracleCommand oraCmdProg = new OracleCommand("select NomÉquipe From Équipes", conn);
                oraCmdProg.CommandType = CommandType.Text;

                OracleDataReader objRead = oraCmdProg.ExecuteReader();
                while (objRead.Read())
                {
                    TB_Receveur.AutoCompleteCustomSource.Add(objRead.GetString(0));
                }
                TB_Receveur.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                TB_Receveur.AutoCompleteSource = AutoCompleteSource.CustomSource;
                objRead.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
        private void AutoCompleteVisiteur()
        {
            try
            {
                OracleCommand oraCmdProg = new OracleCommand("select NomÉquipe From Équipes", conn);
                oraCmdProg.CommandType = CommandType.Text;

                OracleDataReader objRead = oraCmdProg.ExecuteReader();
                while (objRead.Read())
                {
                    TB_Visiteur.AutoCompleteCustomSource.Add(objRead.GetString(0));
                }
                TB_Visiteur.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                TB_Visiteur.AutoCompleteSource = AutoCompleteSource.CustomSource;
                objRead.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
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
            LB_No_Match.DataBindings.Add("Text", formDataSet, "Table.nomatch");
            DTP_Date.DataBindings.Add("Text", formDataSet, "Table.datematch");
            TB_Lieu.DataBindings.Add("Text", formDataSet, "Table.lieu");
            TB_Receveur.DataBindings.Add("Text", formDataSet, "Table.receveur");
            TB_Visiteur.DataBindings.Add("Text", formDataSet, "Table.visiteur");
            TB_R_Pts.DataBindings.Add("Text", formDataSet, "Table.butsreceveur");
            TB_V_Pts.DataBindings.Add("Text", formDataSet, "Table.butsvisiteur");
        }
        private void Vider()
        {
            LB_No_Match.DataBindings.Clear();
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
                string sqlAdd = "INSERT INTO Matchs VALUES (SeqMatchs.nextval,:RECEV,:VISIT," +
                    " :DATEMATCH, :LIEU, :BUTSR, :BUTSV)";

                OracleParameter oParamRecev = new OracleParameter(":RECEV", OracleDbType.Varchar2, 30);
                OracleParameter oParamVisit = new OracleParameter(":VISIT", OracleDbType.Varchar2, 30);
                OracleParameter oParamDate = new OracleParameter(":DATEMATCH", OracleDbType.Date);
                OracleParameter oParamLieu = new OracleParameter(":LIEU", OracleDbType.Varchar2, 30);
                OracleParameter oParamButsR = new OracleParameter(":BUTSR", OracleDbType.Int32, 2);
                OracleParameter oParamButsV = new OracleParameter(":BUTSV", OracleDbType.Int32, 2);

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

        private void BTN_Del_Click(object sender, EventArgs e)
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

        private void BTN_Edit_Click(object sender, EventArgs e)
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

        private void FB_Fiche_Resultat_Click(object sender, EventArgs e)
        {
            OuvrireResultat();
        }
        private void OuvrireResultat()
        {
            Resultat_Match Form = new Resultat_Match();
            Form.conn = conn;
            Form.NoMatch = int.Parse(LB_No_Match.Text);
            if (Form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ///envoyer commit?
            }
        }
    }
}

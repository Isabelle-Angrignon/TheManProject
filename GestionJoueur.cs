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
    public partial class GestionJoueur : Form
    {
        public GestionJoueur()
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
            Close();
        }

        private void BTN_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BTN_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GestionJoueur_Load(object sender, EventArgs e)
        {
            LoadDataset();
        }
        private void LoadDataset()
        {
            try
            {
                string sqlShow = "Select * from Joueurs order by nomaillot";////ou par nom, prénom
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
            TB_Nom_J.DataBindings.Add("Text", formDataSet, "Table.Nom");
            TB_Prenom_J.DataBindings.Add("Text", formDataSet, "Table.Prénom");
            DTP_Naissance.DataBindings.Add("Text", formDataSet, "Table.Naissance");
            TB_Position.DataBindings.Add("Text", formDataSet, "Table.Position");
            TB_Maillot.DataBindings.Add("Text", formDataSet, "Table.nomaillot"); 
            TB_Équipe.DataBindings.Add("Text", formDataSet, "Table.noméquipe");        
        }
        private void Vider()
        {
            TB_Nom_J.DataBindings.Clear();
            TB_Prenom_J.DataBindings.Clear();
            DTP_Naissance.DataBindings.Clear();
            TB_Position.DataBindings.Clear();
            TB_Maillot.DataBindings.Clear();
            TB_Équipe.DataBindings.Clear();

            TB_Nom_J.Clear();
            TB_Prenom_J.Clear();
            DTP_Naissance.Value = DateTime.Now;
            TB_Position.Clear();
            TB_Maillot.Clear();
            TB_Équipe.Clear(); 
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
        /////////////////////////////////////////en construction//////////////////////////////////////////////////
        private void BTN_Add_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlAdd = "INSERT INTO Équipes(noméquipe,dateintro,ville,nomdivision)" +
                    "VALUES (:NOM,:DATEI,:VILLE,:NOMDIV)";
                OracleParameter oParamNom = new OracleParameter(":NOM", OracleDbType.Varchar2, 30);
                OracleParameter oParamDate = new OracleParameter(":DATEI", OracleDbType.Date);
                OracleParameter oParamVille = new OracleParameter(":VILLE", OracleDbType.Varchar2, 20);
                OracleParameter oParamDiv = new OracleParameter(":NOMDIV", OracleDbType.Varchar2, 30);
                oParamNom.Value = TB_Nom_Team.Text;
                oParamDate.Value = DTP_Date_Team.Value;
                oParamVille.Value = TB_Ville.Text;
                oParamDiv.Value = TB_DivisionEquipe.Text;

                OracleCommand orComm = new OracleCommand(sqlAdd, conn);
                orComm.Parameters.Add(oParamNom);
                orComm.Parameters.Add(oParamDate);
                orComm.Parameters.Add(oParamVille);
                orComm.Parameters.Add(oParamDiv);
                orComm.ExecuteNonQuery();

                LoadDataset();
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
                string sqlDelete = "DELETE FROM Équipes WHERE Noméquipe = :NOM";//requete supprime

                OracleParameter oParamNom = new OracleParameter(":NOM", OracleDbType.Varchar2, 30);
                oParamNom.Value = TB_Nom_Team.Text;

                OracleCommand orComm = new OracleCommand(sqlDelete, conn);
                orComm.Parameters.Add(oParamNom);
                orComm.ExecuteNonQuery();

                LoadDataset();
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
                string sqlUpdate = "UPDATE Équipes SET NomÉquipe = :NOM, DateIntro = :DATEI," +
                " ville = :VILLE, NomDivision = :NOMDIV WHERE NomÉquipe = :NOM2"; //requete met a jour

                OracleParameter oParamNom = new OracleParameter(":NOM", OracleDbType.Varchar2, 30);
                OracleParameter oParamDate = new OracleParameter(":DATEI", OracleDbType.Date);
                OracleParameter oParamVille = new OracleParameter(":VILLE", OracleDbType.Varchar2, 20);
                OracleParameter oParamDiv = new OracleParameter(":NOMDIV", OracleDbType.Varchar2, 30);
                OracleParameter oParamNom2 = new OracleParameter(":NOM2", OracleDbType.Varchar2, 30);
                oParamNom.Value = TB_Nom_Team.Text;
                oParamDate.Value = DTP_Date_Team.Value;
                oParamVille.Value = TB_Ville.Text;
                oParamDiv.Value = TB_DivisionEquipe.Text;
                oParamNom2.Value = clePrimaire;
                OracleCommand orComm = new OracleCommand(sqlUpdate, conn);
                orComm.Parameters.Add(oParamNom);
                orComm.Parameters.Add(oParamDate);
                orComm.Parameters.Add(oParamVille);
                orComm.Parameters.Add(oParamDiv);
                orComm.Parameters.Add(oParamNom2);
                orComm.ExecuteNonQuery();

                LoadDataset();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void BTN_Stats_Click(object sender, EventArgs e)
        {

        }        


    }
}

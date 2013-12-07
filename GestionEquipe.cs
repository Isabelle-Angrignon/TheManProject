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
    public partial class GestionEquipe : Form
    {
        public GestionEquipe()
        {
            InitializeComponent();
        }
        public OracleConnection conn = new OracleConnection();
        private DataSet equDataSet = new DataSet();
        private const string dsEquipe = "Équipe";
        OracleDataAdapter Oraliste;
        string clePrimaire;

        private void BTN_Ok_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void BTN_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GestionEquipe_Load(object sender, EventArgs e)
        {
            LoadDataset();
        }
        private void LoadDataset()
        {
            try
            {
                string sqlShow = "Select * from Équipes order by noméquipe";
                Oraliste = new OracleDataAdapter(sqlShow, conn);
                if (equDataSet.Tables.Contains(dsEquipe))
                {
                    equDataSet.Tables[dsEquipe].Clear();
                }
                Oraliste.Fill(equDataSet, dsEquipe);
                Oraliste.Dispose();

                BindingSource maSource = new BindingSource(equDataSet, dsEquipe);
                Vider();
                Lister();
            }
            catch (Exception se) { MessageBox.Show(se.Message.ToString()); }
        }
        private void Lister()
        {
            TB_Nom_Team.DataBindings.Add("Text", equDataSet, "Équipe.Noméquipe");
            DTP_Date_Team.DataBindings.Add("Text", equDataSet, "Équipe.DateIntro");
            clePrimaire = TB_Nom_Team.Text;
            TB_Ville.DataBindings.Add("Text", equDataSet, "Équipe.ville");
            TB_DivisionEquipe.DataBindings.Add("Text", equDataSet, "Équipe.nomdivision");
            ////logo//////
        }
        private void Vider()
        {
            TB_Nom_Team.DataBindings.Clear();
            DTP_Date_Team.DataBindings.Clear();
            TB_Ville.DataBindings.Clear();
            TB_DivisionEquipe.DataBindings.Clear();
            TB_Nom_Team.Clear();
            DTP_Date_Team.Value = DateTime.Now;
            TB_Ville.Clear();
            TB_DivisionEquipe.Clear();
            ////logo///////
        }

        private void uC_Navigator_OnFirst(object sender, EventArgs e)
        {
            this.BindingContext[equDataSet, dsEquipe].Position = 0;
            clePrimaire = TB_Nom_Team.Text;
        }

        private void uC_Navigator_OnLast(object sender, EventArgs e)
        {  
            this.BindingContext[equDataSet, dsEquipe].Position = 
                this.BindingContext[equDataSet, dsEquipe].Count - 1;
            clePrimaire = TB_Nom_Team.Text;
        }
        private void uC_Navigator_OnNext(object sender, EventArgs e)
        {
            this.BindingContext[equDataSet, dsEquipe].Position += 1;
            clePrimaire = TB_Nom_Team.Text;
        }

        private void uC_Navigator_OnPrev(object sender, EventArgs e)
        {
            this.BindingContext[equDataSet, dsEquipe].Position -= 1;
            clePrimaire = TB_Nom_Team.Text;
        }

        /*
         * 
        /////////////////////////////////
        ///// template std ///////////////
        //////////////////////////////////
       

        private void BTN_Add_Click(object sender, EventArgs e)
        {
            try 
            {
                string sqlAdd = "INSERT INTO Divisions VALUES (:NOMDIV,:CREATION)";
                OracleParameter oParamNomDiv = new OracleParameter(":NOMDIV", OracleDbType.Varchar2, 30);
                OracleParameter oParamCreation = new OracleParameter(":CREATION", OracleDbType.Date);
                oParamNomDiv.Value = TB_Nom_D.Text;
                oParamCreation.Value = DTP_Creation.Value;
                
                OracleCommand orComm = new OracleCommand(sqlAdd,conn);
                orComm.Parameters.Add(oParamNomDiv);
                orComm.Parameters.Add(oParamCreation);
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
                string sqlDelete = "DELETE FROM Divisions WHERE NomDivision = :NOMDIV";//requete supprime

                OracleParameter oParamNomDiv = new OracleParameter(":NOMDIV", OracleDbType.Varchar2, 30);
                oParamNomDiv.Value = TB_Nom_D.Text;
                
                OracleCommand orComm = new OracleCommand(sqlDelete, conn);
                orComm.Parameters.Add(oParamNomDiv);                
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
                string sqlUpdate = "UPDATE Divisions SET NomDivision = :NOMDIV, DateCréation = :CREATION"+
                " WHERE NomDivision = :NOMDIV2"; //requete met a jour

                OracleParameter oParamNomDiv = new OracleParameter(":NOMDIV", OracleDbType.Varchar2, 30);               
                OracleParameter oParamCreation = new OracleParameter(":CREATION", OracleDbType.Date);
                OracleParameter oParamNomDiv2 = new OracleParameter(":NOMDIV2", OracleDbType.Varchar2, 30);
                oParamNomDiv.Value = TB_Nom_D.Text;                
                oParamCreation.Value = DTP_Creation.Value;
                oParamNomDiv2.Value = clePrimaire;

                OracleCommand orComm = new OracleCommand(sqlUpdate, conn);
                orComm.Parameters.Add(oParamNomDiv);                
                orComm.Parameters.Add(oParamCreation);
                orComm.Parameters.Add(oParamNomDiv2);
                orComm.ExecuteNonQuery();

                LoadDataset();
            } 
            catch (Exception ex) 
            { 
                MessageBox.Show(ex.Message.ToString()); 
            } 
        }
         * */
    }
}

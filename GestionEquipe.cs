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
using System.IO;

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
        private const string dsEquipe = "Équipes";
        OracleDataAdapter Oraliste;
        string clePrimaire;
        private byte[] logo_;
        public byte[] logo 
        {
            get { return logo_; }
            set 
            {
                logo_ = value;
                if (logo_ != null)
                {
                    using (MemoryStream ms = new MemoryStream(logo_)) 
                    {
                        PBX_Logo.Image = Image.FromStream(ms);
                    }
                }            
            }
        }

        private void FB_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        } 

        private void GestionEquipe_Load(object sender, EventArgs e)
        {
            LoadDataset();
            Fill_CBX_Division();
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
            TB_Nom_Team.DataBindings.Add("Text", equDataSet, "Équipes.Noméquipe");
            DTP_Date_Team.DataBindings.Add("Text", equDataSet, "Équipes.DateIntro");
            clePrimaire = TB_Nom_Team.Text;
            TB_Ville.DataBindings.Add("Text", equDataSet, "Équipes.ville");
            TB_DivisionEquipe.DataBindings.Add("Text", equDataSet, "Équipes.nomdivision");///invisible
            CB_Division.SelectedItem = TB_DivisionEquipe.Text;

            ////logo//////
        }
        private void Fill_CBX_Division()
        {
            try
            {
                string sqlDivision = "select nomdivision from divisions";
                OracleCommand oraDivision = new OracleCommand(sqlDivision, conn);
                oraDivision.CommandType = CommandType.Text;
                OracleDataReader OraReadDiv = oraDivision.ExecuteReader();
                while (OraReadDiv.Read())
                {
                    CB_Division.Items.Add(OraReadDiv.GetString(0));
                }                
            }
            catch (Exception se) { MessageBox.Show(se.Message.ToString()); }

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
        /////////////////////////////////////////en construction//////////////////////////////////////////////////
        
        //ajouter logo
        private void BTN_Add_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlAdd = "INSERT INTO Équipes(noméquipe,dateintro,ville,nomdivision)"+
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
                MessageBox.Show("Enregistrement ajouté avec succès");
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
                if (MessageBox.Show("message", "Attention", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    string sqlDelete = "DELETE FROM Équipes WHERE Noméquipe = :NOM";//requete supprime

                    OracleParameter oParamNom = new OracleParameter(":NOM", OracleDbType.Varchar2, 30);
                    oParamNom.Value = TB_Nom_Team.Text;

                    OracleCommand orComm = new OracleCommand(sqlDelete, conn);
                    orComm.Parameters.Add(oParamNom);
                    orComm.ExecuteNonQuery();

                    LoadDataset();
                    MessageBox.Show("Enregistrement supprimé avec succès");
                }
            } 
            catch (Exception ex) 
            { 
                MessageBox.Show(ex.Message.ToString()); 
            } 
        }
        
        //ajouter logo
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
                MessageBox.Show("Enregistrement modifié avec succès");
            } 
            catch (Exception ex) 
            { 
                MessageBox.Show(ex.Message.ToString()); 
            } 
        }

        private void BTN_Load_Click(object sender, EventArgs e)
        {
            logo=null;
            OpenFileDialog file = new OpenFileDialog();
            file.Title = "Sélectionner le logo d'équipe";
            file.CheckFileExists = true;
            file.InitialDirectory = @":C\";
            file.Filter = "Fichiers images (*.BMP; *.JPG; *.GIF; *.PNG)|*.BMP; *.JPG; *.GIF; *.PNG|Tous les fichiers(*.*)|*.*";
            file.FilterIndex = 1;
            file.RestoreDirectory = true;
            if (file.ShowDialog() == DialogResult.OK)
            {
                logo = File.ReadAllBytes(file.FileName);
                PBX_Logo.Image = Image.FromFile(file.FileName);
            }
        }

        private void CB_Division_SelectedIndexChanged(object sender, EventArgs e)
        {

        }                       
    }
}

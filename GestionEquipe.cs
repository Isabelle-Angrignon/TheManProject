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
        public string NomEquipe = "";
        OracleDataAdapter Oraliste;
        string clePrimaire;

        private void FB_Close_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
            
        } 

        private void GestionEquipe_Load(object sender, EventArgs e)
        {
            LoadDataset();
            AutoCompleteDivision();
            ChangeColorMenu();
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
        
        private void LoadDataset()
        {
            try
            {
                string sqlShow = "Select * from Équipes order by noméquipe";
                if (NomEquipe != "")
                {
                    sqlShow = "Select * from Équipes where noméquipe ='" + NomEquipe+"'";
                }
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
            TB_DivisionEquipe.DataBindings.Add("Text", equDataSet, "Équipes.nomdivision");
            PBX_Logo.DataBindings.Add("Image", equDataSet, "Équipes.logo", true);      
            
}
        
        private void Vider()
        {
            TB_Nom_Team.DataBindings.Clear();
            DTP_Date_Team.DataBindings.Clear();
            TB_Ville.DataBindings.Clear();
            TB_DivisionEquipe.DataBindings.Clear();
            PBX_Logo.DataBindings.Clear();
            TB_Nom_Team.Clear();
            DTP_Date_Team.Value = DateTime.Now;
            TB_Ville.Clear();
            TB_DivisionEquipe.Clear();
            PBX_Logo.Image = null;            
        }
        #region "Navigation"

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
        #endregion
                
        private void BTN_Add_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlAdd = "INSERT INTO Équipes(noméquipe,dateintro,logo,ville,nomdivision)"+
                    "VALUES (:NOM,:DATEI,:LOGO,:VILLE,:NOMDIV)";
                OracleParameter oParamNom = new OracleParameter(":NOM", OracleDbType.Varchar2, 30);
                OracleParameter oParamDate = new OracleParameter(":DATEI", OracleDbType.Date);
                OracleParameter oParamLogo = new OracleParameter(":LOGO", OracleDbType.Blob);
                OracleParameter oParamVille = new OracleParameter(":VILLE", OracleDbType.Varchar2, 20);
                OracleParameter oParamDiv = new OracleParameter(":NOMDIV", OracleDbType.Varchar2, 30);
                oParamNom.Value = TB_Nom_Team.Text;
                oParamDate.Value = DTP_Date_Team.Value;
                //traduire l'image en BYTE
                byte[] buffer1 = imageToByteArray(PBX_Logo.Image);
                //Mettre le byte dans les param..
                oParamLogo.Value = buffer1;
                oParamVille.Value = TB_Ville.Text;
                oParamDiv.Value = TB_DivisionEquipe.Text;
                
                OracleCommand orComm = new OracleCommand(sqlAdd, conn);
                orComm.Parameters.Add(oParamNom);
                orComm.Parameters.Add(oParamDate);
                orComm.Parameters.Add(oParamLogo);
                orComm.Parameters.Add(oParamVille);
                orComm.Parameters.Add(oParamDiv);
                orComm.ExecuteNonQuery();

                LoadDataset();
                MessageBox.Show("Enregistrement ajouté avec succès");
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

        //Conversion de l'image du picture box en byte pour blob.
        public byte[] imageToByteArray(System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            return ms.ToArray();
        }
         
        private void BTN_Del_Click(object sender, EventArgs e)
        {
            try 
            {
                if (MessageBox.Show("Voulez-vous vraiment supprimer cette équipe?", "Attention", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    string sqlDelete = "DELETE FROM Équipes WHERE Noméquipe = :NOM";

                    OracleParameter oParamNom = new OracleParameter(":NOM", OracleDbType.Varchar2, 30);
                    oParamNom.Value = TB_Nom_Team.Text;

                    OracleCommand orComm = new OracleCommand(sqlDelete, conn);
                    orComm.Parameters.Add(oParamNom);
                    int res = orComm.ExecuteNonQuery();

                    LoadDataset();

                    MessageBox.Show(res + " enregistrement supprimé avec succès");
                }
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
                string sqlUpdate = "UPDATE Équipes SET NomÉquipe = :NOM, DateIntro = :DATEI, logo = :logo," +
                " ville = :VILLE, NomDivision = :NOMDIV WHERE NomÉquipe = :NOM2";

                OracleParameter oParamNom = new OracleParameter(":NOM", OracleDbType.Varchar2, 30);
                OracleParameter oParamDate = new OracleParameter(":DATEI", OracleDbType.Date);
                OracleParameter oParamLogo = new OracleParameter(":LOGO", OracleDbType.Blob);
                OracleParameter oParamVille = new OracleParameter(":VILLE", OracleDbType.Varchar2, 20);
                OracleParameter oParamDiv = new OracleParameter(":NOMDIV", OracleDbType.Varchar2, 30);
                OracleParameter oParamNom2 = new OracleParameter(":NOM2", OracleDbType.Varchar2, 30);
                oParamNom.Value = TB_Nom_Team.Text;
                oParamDate.Value = DTP_Date_Team.Value;

                //traduire l'image en BYTE
                byte[] buffer1 = imageToByteArray(PBX_Logo.Image);
                //Mettre le byte dans les param..
                oParamLogo.Value = buffer1;
                                
                oParamVille.Value = TB_Ville.Text;
                oParamDiv.Value = TB_DivisionEquipe.Text;
                oParamNom2.Value = clePrimaire;
                OracleCommand orComm = new OracleCommand(sqlUpdate, conn);
                orComm.Parameters.Add(oParamNom);
                orComm.Parameters.Add(oParamDate);
                orComm.Parameters.Add(oParamLogo);
                orComm.Parameters.Add(oParamVille);
                orComm.Parameters.Add(oParamDiv);
                orComm.Parameters.Add(oParamNom2);
                orComm.ExecuteNonQuery();
                
                LoadDataset();
                MessageBox.Show("Enregistrement modifié avec succès");
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

        private void BTN_Load_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Title = "Sélectionner le logo d'équipe";
            file.CheckFileExists = true;
            file.InitialDirectory = @":C\";            
            file.Filter = "Fichiers images (*.BMP; *.JPG; *.GIF; *.PNG)|*.BMP; *.JPG; *.GIF; *.PNG|Tous les fichiers(*.*)|*.*";
            file.FilterIndex = 1;
            file.RestoreDirectory = true;

            if (file.ShowDialog() == DialogResult.OK)
            {
                PBX_Logo.Image = Image.FromFile(file.FileName);
                PBX_Logo.ImageLocation = file.FileName;
            }  
        }

        private void AutoCompleteDivision()
        {
            try
            {
                OracleCommand oraCmdProg = new OracleCommand("select NomDivision From Divisions", conn);
                oraCmdProg.CommandType = CommandType.Text;

                OracleDataReader objRead = oraCmdProg.ExecuteReader();
                while (objRead.Read())
                {
                    TB_DivisionEquipe.AutoCompleteCustomSource.Add(objRead.GetString(0));
                }
                TB_DivisionEquipe.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                TB_DivisionEquipe.AutoCompleteSource = AutoCompleteSource.CustomSource;
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
        private void ErrorMessage(OracleException Ex)
        {
            switch (Ex.Number)
            {
                case 1:
                    MessageBox.Show("Une équipe porte déjà ce nom");
                    break;
                case 02292:
                    MessageBox.Show("L'équipe choisie n'est pas vide: " +
                        "on ne peut ni la suprimer, ni modifier son nom");
                    break;
                case 01400:
                    MessageBox.Show("L'équipe doit avoir un nom");
                    break;
                default: MessageBox.Show(Ex.Message.ToString());
                    break;
            }
        }
        
                    
    }
}

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
    public partial class GestionDivision : Form
    {
        public GestionDivision()
        { 
            InitializeComponent();
        }
        public OracleConnection conn = new OracleConnection();
        private DataSet divDataSet = new DataSet();
        private const string dsDivision = "Divisions";
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

        private void GestionDivision_Load(object sender, EventArgs e)
        {
            LoadDataset();
        }
        private void LoadDataset()
        {
            try
            {
                string sqlShow = "Select * from Divisions order by nomdivision";
                Oraliste = new OracleDataAdapter(sqlShow, conn);
                if (divDataSet.Tables.Contains(dsDivision))
                {
                    divDataSet.Tables[dsDivision].Clear();
                }
                Oraliste.Fill(divDataSet, dsDivision);
                Oraliste.Dispose();

                BindingSource maSource = new BindingSource(divDataSet, dsDivision);
                Vider();
                Lister();
            }
            catch (Exception se) { MessageBox.Show(se.Message.ToString()); }
        }
        private void Lister()
        {
            TB_Nom_D.DataBindings.Add("Text", divDataSet, "Divisions.NomDivision");
            DTP_Creation.DataBindings.Add("Text", divDataSet, "Divisions.DateCréation");
            clePrimaire = TB_Nom_D.Text;
        }
        private void Vider()
        {
            TB_Nom_D.DataBindings.Clear();
            DTP_Creation.DataBindings.Clear();
            TB_Nom_D.Clear();
            DTP_Creation.Value = DateTime.Now;
        }

        private void uC_Navigator_OnFirst(object sender, EventArgs e)
        {
            this.BindingContext[divDataSet, dsDivision].Position = 0;
            clePrimaire = TB_Nom_D.Text;
        }

        private void uC_Navigator_OnLast(object sender, EventArgs e)
        {
            this.BindingContext[divDataSet, dsDivision].Position =
                this.BindingContext[divDataSet, dsDivision].Count - 1;
            clePrimaire = TB_Nom_D.Text;
        }

        private void uC_Navigator_OnNext(object sender, EventArgs e)
        {
            this.BindingContext[divDataSet, dsDivision].Position += 1;
            clePrimaire = TB_Nom_D.Text;
        }

        private void uC_Navigator_OnPrev(object sender, EventArgs e)
        {
            this.BindingContext[divDataSet, dsDivision].Position -= 1;
            clePrimaire = TB_Nom_D.Text;
        }

        private void BTN_Add_Click(object sender, EventArgs e)
        {
            try 
            {
                string Nom = TB_Nom_D.Text;
                string sqlAdd = "INSERT INTO Divisions VALUES (:NOMDIV,:CREATION)";
                OracleParameter oParamNomDiv = new OracleParameter(":NOMDIV", OracleDbType.Varchar2, 30);
                OracleParameter oParamCreation = new OracleParameter(":CREATION", OracleDbType.Date);
                oParamNomDiv.Value = TB_Nom_D.Text;
                oParamCreation.Value = DTP_Creation.Value;
                
                OracleCommand orComm = new OracleCommand(sqlAdd,conn);
                orComm.Parameters.Add(oParamNomDiv);
                orComm.Parameters.Add(oParamCreation);
                orComm.ExecuteNonQuery();
                MessageBox.Show("La Divsion " + Nom + " a été ajouté");

                LoadDataset();
            } 
            catch (OracleException ex) 
            {
                ErrorMessage(ex);
            } 
        }

        private void BTN_Del_Click(object sender, EventArgs e)
        {
            try 
            {
                if (MessageBox.Show("Voulez-vous vraiment supprimer cet enregistrement?", "Attention", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    string Nom = TB_Nom_D.Text;
                    string sqlDelete = "DELETE FROM Divisions WHERE NomDivision = :NOMDIV";//requete supprime

                    OracleParameter oParamNomDiv = new OracleParameter(":NOMDIV", OracleDbType.Varchar2, 30);
                    oParamNomDiv.Value = TB_Nom_D.Text;

                    OracleCommand orComm = new OracleCommand(sqlDelete, conn);
                    orComm.Parameters.Add(oParamNomDiv);
                    int res = orComm.ExecuteNonQuery();

                    LoadDataset();
                    if (res > 0)
                    {
                        MessageBox.Show("La Divsion " + Nom + " a été supprimé");
                    }
                    else
                    {
                        MessageBox.Show("Aucune entrée");
                    }
                }
            } 
            catch (OracleException ex) 
            {
                ErrorMessage(ex);
            } 
        }

        private void BTN_Edit_Click(object sender, EventArgs e)
        {
            try 
            {
                /////enregistrer la clé primaire d'abord pour pouvoir la modifier...
                string Nom = TB_Nom_D.Text;
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
                MessageBox.Show("La Divsion " + Nom + " a été modifié");
            } 
            catch (OracleException ex) 
            {
                ErrorMessage(ex); 
            } 
        }

        private void ErrorMessage(OracleException Ex)
        {
            switch (Ex.Number)
            {
                case 1:
                    MessageBox.Show("Une division porte déjà ce nom");
                    break;
                case 02292:
                    MessageBox.Show("La Division choisie n'est pas vide et ne peut donc pas être suprimer ou son nom ne peut être modifier");
                    break;
                case 01400:
                    MessageBox.Show("La division doit avoir un nom");
                    break;
                default: MessageBox.Show(Ex.Message.ToString());
                    break;

            }
        }
    }
}

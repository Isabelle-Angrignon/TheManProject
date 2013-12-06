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
        //////////////////////////////////
        ///// template std ///////////////
        //////////////////////////////////
        public OracleConnection conn = new OracleConnection();
        private DataSet divDataSet = new DataSet();
        private const string dsDivision = "Divisions";
        OracleDataAdapter Oraliste;
        
        //oParam

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
            try
            {
                string sqlShow = "Select * from Divisions";
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
        }
        private void Vider()
        {
            TB_Nom_D.DataBindings.Clear();
            DTP_Creation.DataBindings.Clear();
            TB_Nom_D.Clear();
            DTP_Creation.Value = new DateTime();
        }

        private void uC_Navigator_OnFirst(object sender, EventArgs e)
        {
            this.BindingContext[divDataSet, dsDivision].Position = 0;
        }

        private void uC_Navigator_OnLast(object sender, EventArgs e)
        {
            this.BindingContext[divDataSet, dsDivision].Position =
                this.BindingContext[divDataSet, dsDivision].Count - 1;
        }

        private void uC_Navigator_OnNext(object sender, EventArgs e)
        {
            this.BindingContext[divDataSet, dsDivision].Position += 1;
        }

        private void uC_Navigator_OnPrev(object sender, EventArgs e)
        {
            this.BindingContext[divDataSet, dsDivision].Position -= 1;
        }

        private void BTN_Add_Click(object sender, EventArgs e)
        {
            try 
            {
                string sqlAdd = "INSERT INTO Division VALUES (:NOMDIV, :CREATION)";////requete ajout
                OracleParameter oParamNomDiv = new OracleParameter(":NOMDIV", OracleDbType.Varchar2, 30);
                OracleParameter oParamNomDiv2 = new OracleParameter(":NOMDIV", OracleDbType.Varchar2, 30);
                OracleParameter oParamCreation = new OracleParameter(":CREATION", OracleDbType.Date);
                oParamNomDiv.Value = TB_Nom_D.Text;
                oParamNomDiv2.Value = TB_Nom_D.Text;
                oParamCreation.Value = DTP_Creation.Value;
                
                OracleCommand orComm = new OracleCommand(sqlAdd,conn);
                orComm.Parameters.Add(oParamNomDiv);
                orComm.Parameters.Add(oParamNomDiv2);
                orComm.Parameters.Add(oParamCreation);
                orComm.ExecuteNonQuery();
                
               /*
                Oraliste.InsertCommand = new OracleCommand(sqlAdd, conn); 
                Oraliste.InsertCommand.Parameters.Add(":NOMDIV", OracleDbType.Varchar2, 20, "nomdivision"); 
                Oraliste.InsertCommand.Parameters.Add(":CREATION", OracleDbType.Varchar2, 20, "datecréation"); 
                Oraliste.Update(divDataSet.Tables[dsDivision]); 
                divDataSet.AcceptChanges();
                Oraliste.Dispose();*/

                Vider();
                Lister();
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
                string sqlDelete = "DELETE FROM Division WHERE NomDivision = :NOMDIV";//requete supprime
                Oraliste.DeleteCommand = new OracleCommand(sqlDelete, conn);
                Oraliste.DeleteCommand.Parameters.Add(":NOMDIV", OracleDbType.Varchar2, 30, "nomdivision");
                Oraliste.Update(divDataSet.Tables[dsDivision]);
                divDataSet.AcceptChanges();
                Oraliste.Dispose(); 
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
                //string clePrimaire = divDataSet.Tables[dsDivision].se
                string sqlUpdateNom = "UPDATE Division SET NomDivision = :NOMDIV AND DateCréation = :CREATION"+
                " WHERE NomDivision = clePrimaire"; //requete met a jour
                //string sqlUpdateDate = "UPDATE Division SET DateCréation = :CREATION";//requete met a jour

                Oraliste.UpdateCommand = new OracleCommand(sqlUpdateNom, conn);
                Oraliste.UpdateCommand.Parameters.Add(":nomdiv", OracleDbType.Varchar2, 20, "nomdivision");
                Oraliste.UpdateCommand.Parameters.Add(":creation", OracleDbType.Int32, 4, "datecréation");
                Oraliste.Update(divDataSet.Tables[dsDivision]);
                divDataSet.AcceptChanges(); 
                Oraliste.Dispose(); 
            } 
            catch (Exception ex) 
            { 
                MessageBox.Show(ex.Message.ToString()); 
            } 
        }
    }
}

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
        private OracleConnection conn = new OracleConnection();
        private DataSet divDataSet = new DataSet();
        string sqlShow = "Select * from Divisions";
        string sqlAdd = "INSERT INTO Division VALUES (:NOMDIV, :CREATION)";////requete ajout
        string sqlUpdateNom = "UPDATE Division SET NomDivision = :NOMDIV"; //requete met a jour
        string sqlUpdateDate = "UPDATE Division SET DateCréation = :CREATION";//requete met a jour
        string sqlDelete = "DELETE FROM Division WHERE NomDivision = :NOMDIV";//requete supprime

        private const string dsDivision = "Divisions";
        OracleDataReader oreadDiv;

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
                OracleDataAdapter Oraliste = new OracleDataAdapter(sqlShow, conn);

                if (divDataSet.Tables.Contains(dsDivision))
                {
                    divDataSet.Tables[dsDivision].Clear();
                }
                Oraliste.Fill(divDataSet, dsDivision);
                Oraliste.Dispose();

                BindingSource maSource = new BindingSource(divDataSet, dsDivision);

                TB_Nom_D.DataBindings.Add("Text", divDataSet, "Divisions.NomDivision");
                
            }
            catch (Exception se) { MessageBox.Show(se.Message.ToString()); }
        }


        /////////////////////////////////////////
        //exemple typique de code avec paramètres
        ///////////////////////////////////////
 /*       private void save_Click(object sender, EventArgs e) 
        { 
            try 
            { 
                // Modification 
                string sqlupdate = "update etudiants set nom =:nom where numad =:numad"; 
                Oraliste.UpdateCommand = new OracleCommand(sqlupdate, conn); 
                Oraliste.UpdateCommand.Parameters.Add(":nom", OracleDbType.Varchar2, 20, "nom"); 
                Oraliste.UpdateCommand.Parameters.Add(":numad", OracleDbType.Int32, 4, "numad"); 
 
                // insertion (voir le SELECT et le FILL) 
                string sqlinsert = "insert into etudiants (numad, NOM, PRENOM) values (SEQETU.NEXTVAL,:NOM, :PRENOM)" 
                Oraliste.InsertCommand = new OracleCommand(sqlinsert, conn); 
                Oraliste.InsertCommand.Parameters.Add(":nom", OracleDbType.Varchar2, 20, "nom"); 
                Oraliste.InsertCommand.Parameters.Add(":prenom", OracleDbType.Varchar2, 20, "prenom"); 
                
                // SUPPRESSION 
                string sqlsuppression = "delete from etudiants where numad =:numad"; 
                Oraliste.DeleteCommand = new OracleCommand(sqlsuppression, conn); 
                Oraliste.DeleteCommand.Parameters.Add(":numad", OracleDbType.Int32, 4, "numad"); 
 
                //executer la commande Insert ou delete ou update 
                Oraliste.Update(monDataSet.Tables["ResultatEtudiants"]); 
                monDataSet.AcceptChanges(); 
            } 
            catch (Exception ex) 
            { 
                MessageBox.Show(ex.Message.ToString()); 
            } 
            finally 
            { 
                Oraliste.Dispose(); 
            } 
        }
 */      
    }
}

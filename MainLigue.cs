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
    public partial class Form_League : Form
    {
        private OracleConnection conn = new OracleConnection();
        private DataSet mainDataSet = new DataSet();
        string sqlHoraire = "SELECT * FROM blabla";////////////////////////////////
        string sqlClassement = "requete qui affiche le classement";///////////////
        private const string dsHoraire = "Liste_matchs";
        private string dsCLassement = "Classement_équipes";
        OracleDataReader orLigue;

        public Form_League()
        {
            InitializeComponent();
        }

        private void FLB_Division_Click(object sender, EventArgs e)
        {
            GestionDivision Form = new GestionDivision();
            if (Form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ///envoyer commit?
            }
        }

        private void Form_League_Load(object sender, EventArgs e)
        {

        }
        private void Connect()
        {
            try
            {
                string Dsource = "(DESCRIPTION="
                + "(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)"
                + "(HOST=205.237.244.251)(PORT=1521)))"
                + "(CONNECT_DATA=(SERVICE_NAME=ORCL)))";

                String ChaineConnexion = "Data Source=" + Dsource
                + ";User Id = simon007 Password =  oracle1";
                conn.ConnectionString = ChaineConnexion;
                conn.Open();
                MessageBox.Show(conn.State.ToString());
            }
            catch (Exception ex) { MessageBox.Show(ex.Message.ToString());}
        }
    }
}
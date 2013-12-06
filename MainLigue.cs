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
            Form.conn = conn;
            if (Form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ///envoyer commit?
            }
        }

        private void Form_League_Load(object sender, EventArgs e)
        {
            Connect();
            UpdateComboBox();
        }

        private void UpdateComboBox()
        {
            try
            {
                OracleCommand oraCmdProg = new OracleCommand("select NomDivision From Divisions", conn);
                oraCmdProg.CommandType = CommandType.Text;

                OracleDataReader objRead = oraCmdProg.ExecuteReader();

                while (objRead.Read())
                {
                    //ListeProgrammes.Items.Add(objRead.GetInt32(0)); 
                    CBX_Division.Items.Add(objRead.GetString(0));
                }
                CBX_Division.Items.Add("Toutes");

                CBX_Division.SelectedIndex = 0;
                objRead.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            } 
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
                + ";User Id = simon007; Password =  oracle1";
                conn.ConnectionString = ChaineConnexion;
                conn.Open();
                MessageBox.Show(conn.State.ToString());
            }
            catch (Exception ex) { MessageBox.Show(ex.Message.ToString());}
        }
        
        private void FillDGVMatch()
        {
            try
            {
                OracleDataAdapter Oraliste = new OracleDataAdapter(sqlHoraire, conn);

                if (mainDataSet.Tables.Contains(dsHoraire))
                {
                    mainDataSet.Tables[dsHoraire].Clear();
                }
                Oraliste.Fill(mainDataSet, dsHoraire);
                Oraliste.Dispose();

                BindingSource maSource = new BindingSource(mainDataSet, dsHoraire);

                DGV_Match.DataSource = maSource;
            }
            catch (Exception se) { MessageBox.Show(se.Message.ToString()); }
        }

        private void flashButton2_Click(object sender, EventArgs e)
        {
            Top5 Form = new Top5();
            Form.ShowDialog();
        }

        private void FLB_Team_Click(object sender, EventArgs e)
        {
            GestionEquipe Form = new GestionEquipe();
            if (Form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ///envoyer commit?
            }

        }
        private void OuvrireEquipe()
        {

        }

        private void flashButton1_Click(object sender, EventArgs e)
        {
            GestionJoueur Form = new GestionJoueur();
            if (Form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ///envoyer commit?
            }
        }

        private void flashButton3_Click(object sender, EventArgs e)
        {
            GestionMatch Form = new GestionMatch();
            if (Form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ///envoyer commit?
            }
        }

        private void flashButton4_Click(object sender, EventArgs e)
        {
            Resultat_Match Form = new Resultat_Match();
            if (Form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ///envoyer commit?
            }
        }

        private void Form_League_SizeChanged(object sender, EventArgs e)
        {
            //constater nouvelle size, redimensionne éléments tels dgv en fonction de la nouvelle dimension
        }

    }

   
}
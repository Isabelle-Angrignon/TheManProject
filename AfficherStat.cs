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
    public partial class AfficherStat : Form
    {
        public AfficherStat()
        {
            InitializeComponent();
        }
        public OracleConnection conn = new OracleConnection();
        public int NoJoueur;
        private DataSet formDataSet = new DataSet();
        private const string dsTable = "Table";
        OracleDataAdapter Oraliste;       

        private void BTN_Ok_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

       
        private void LoadDataset()
        {
            try
            {
                string sqlShow = "Select * from VueFiche where Nom = (Select Nom From Joueurs where NoJoueur = " + NoJoueur + ")";
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
          //  string Sql = "CREATE VIEW VueFiche AS SELECT Nom, Prénom, NomÉquipe AS Équipe," +
          // "SUM(NbrePasses) AS Passes, SUM(NbreButs) AS Buts, SUM(NbrePasses)+ 2*SUM(NbreButs) AS Points " +
          //" FROM Joueurs J INNER JOIN  PrésencesMatchs P ON P.NoJoueur = J.NoJoueur " +
          // "group by nom,prénom, noméquipe order by totalpoint desc having J.NoJoueur = " + NoJoueur + ";";
            LB_Nom.DataBindings.Add("Text", formDataSet, "Table.nom");
            LB_Prenom.DataBindings.Add("Text", formDataSet, "Table.prénom");
            LB_Team.DataBindings.Add("Text", formDataSet, "Table.Équipe");
            LB_Passes.DataBindings.Add("Text", formDataSet, "Table.Passes");
            LB_But.DataBindings.Add("Text", formDataSet, "Table.Buts");
            LB_Points.DataBindings.Add("Text", formDataSet, "Table.Points");
                     
        }
        private void Vider()
        {
            LB_Nom.DataBindings.Clear();
            LB_Prenom.DataBindings.Clear();
            LB_Team.DataBindings.Clear();
            LB_Passes.DataBindings.Clear();
            LB_But.DataBindings.Clear();
            LB_Points.DataBindings.Clear();
            
        }

        private void AfficherStat_Load_1(object sender, EventArgs e)
        {
            LoadDataset();
            LoadTableJoueur();
            LoadMinutesJoueur();
            ArrangeZero();
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
        private void LoadTableJoueur()
        {
            try
            {
                OracleCommand oraCmdProg = new OracleCommand("select * From Joueurs where NoJoueur = "+NoJoueur, conn);
                oraCmdProg.CommandType = CommandType.Text;
                OracleDataReader objRead = oraCmdProg.ExecuteReader();
                while (objRead.Read())
                {
                    LB_Numero.Text = objRead.GetInt32(5).ToString();
                    char[] splitters = new char[] { ' ' };
                    string[] CeQueJeVeux = objRead.GetDateTime(3).Date.ToString().Split(splitters);
                    LB_DateNaissance.Text = CeQueJeVeux[0];
                    LB_Nom.Text = objRead.GetString(1);
                    LB_Prenom.Text = objRead.GetString(2);
                    LB_Team.Text = objRead.GetString(6);
                    if (objRead.GetString(4) == "G")
                    {
                        LB_Position.Text = "Guardien";
                    }
                    if (objRead.GetString(4) == "A")
                    {
                        LB_Position.Text = "Attaquant";
                    }
                    if (objRead.GetString(4) == "D")
                    {
                        LB_Position.Text = "Défenseur";
                    }
                }
                objRead.Close();
            }
            
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            } 
        }

        private void ArrangeZero()
        {
            if (LB_But.Text == "")
            {
                LB_But.Text = "0";
            }
            if (LB_Passes.Text == "")
            {
                LB_Passes.Text = "0";
            }
            if (LB_Points.Text == "")
            {
                LB_Points.Text = "0";
            }
            if (LB_Minute.Text == "")
            {
                LB_Minute.Text = "0";
            }

        }
        private void LoadMinutesJoueur()
        {
            try
            {
                OracleCommand oraCmdProg = new OracleCommand("select TEMPSPUNITION From PRÉSENCESMATCHS where NoJoueur = " + NoJoueur, conn);
                oraCmdProg.CommandType = CommandType.Text;
                OracleDataReader objRead = oraCmdProg.ExecuteReader();
                while (objRead.Read())
                {
                    LB_Minute.Text = objRead.GetInt32(0).ToString();
                }
                objRead.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            } 
        }
        private void Caractérstique_Enter(object sender, EventArgs e)
        {

        }

              







    }
}

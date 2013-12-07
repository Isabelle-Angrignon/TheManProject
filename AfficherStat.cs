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

        private void AfficherStat_Load(object sender, EventArgs e)
        {
            LoadDataset();
        }
        private void LoadDataset()
        {
            try
            {
                string sqlShow = "Select * from VueFiche order by nomaillot";////ou par nom, prénom
                Oraliste = new OracleDataAdapter(sqlShow, conn);
                if (formDataSet.Tables.Contains(dsTable))
                {
                    formDataSet.Tables[dsTable].Clear();
                }
                Oraliste.Fill(formDataSet, dsTable);
                Oraliste.Dispose();

                BindingSource maSource = new BindingSource(formDataSet, dsTable);
     //           Vider();
   //             Lister();
            }
            catch (Exception se) { MessageBox.Show(se.Message.ToString()); }
        }
        private void Lister()
        {
            /* CREATE VIEW VueFiche AS SELECT Nom, Prénom, NomÉquipe AS Équipe,
         SUM(NbrePasses) AS Passes, SUM(NbreButs) AS Buts, SUM(NbrePasses)+ 2*SUM(NbreButs) AS Points 
         FROM Joueurs J INNER JOIN  PrésencesMatchs P ON P.NoJoueur = J.NoJoueur group by nom,prénom, noméquipe order by totalpoint desc;*/
            LB_Nom.DataBindings.Add("Text", formDataSet, "Table.");
            LB_Prenom.DataBindings.Add("Text", formDataSet, "Table.");
            LB_Team.DataBindings.Add("Text", formDataSet, "Table.");
            LB_Passes.DataBindings.Add("Text", formDataSet, "Table.");
            LB_But.DataBindings.Add("Text", formDataSet, "Table.");
            LB_Points.DataBindings.Add("Text", formDataSet, "Table.");

            //LB_Penalite
            //LB_DateNaissance
             //LB_Numero
            //LB_Position           

           
        }
        //private void Vider()
        //{
        //    LB_No_J.DataBindings.Clear();
        //    TB_Nom_J.DataBindings.Clear();
        //    TB_Prenom_J.DataBindings.Clear();
        //    DTP_Naissance.DataBindings.Clear();
        //    TB_Position.DataBindings.Clear();
        //    TB_Maillot.DataBindings.Clear();
        //    TB_Équipe.DataBindings.Clear();
        //    //LB_No_J.  pas de clear...invisible anyway
        //    TB_Nom_J.Clear();
        //    TB_Prenom_J.Clear();
        //    DTP_Naissance.Value = DateTime.Now;
        //    TB_Position.Clear();
        //    TB_Maillot.Clear();
        //    TB_Équipe.Clear();
        //}

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







    }
}

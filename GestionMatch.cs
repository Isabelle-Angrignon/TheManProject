﻿using System;
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
    public partial class GestionMatch : Form
    {
        public GestionMatch()
        {
            InitializeComponent();
        }

        public OracleConnection conn = new OracleConnection();
        private DataSet formDataSet = new DataSet();       
        OracleDataAdapter Oraliste;
        public int NoMatch = -1;

        /////////////////////////////////////////////////
        //Pour valider l'entrée des pts de matchs en numérique seulement
        const char BACKSPACE = '\b';
        bool EstChiffre(char c)
        {
            String chiffres = "0123456789";
            return (chiffres.IndexOf(c.ToString()) != -1);
        }
        private void TB_Chiffres_Seulement_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != BACKSPACE)
                e.Handled = !EstChiffre(e.KeyChar);
        }
        /////////////////////////////////////////////////

        private void BTN_Ok_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void GestionMatch_Load(object sender, EventArgs e)
        {
            LoadDataset();
            AutoCompleteEquipe();
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
        //Fait en sorte que les noms d'équipe receveur et visiteur se complète dès qu'on commence à taper un nom.        
        private void AutoCompleteEquipe()
        {
            try
            {
                OracleCommand oraCmdProg = new OracleCommand("select NomÉquipe From Équipes", conn);
                oraCmdProg.CommandType = CommandType.Text;

                OracleDataReader objRead = oraCmdProg.ExecuteReader();
                while (objRead.Read())
                {
                    TB_Visiteur.AutoCompleteCustomSource.Add(objRead.GetString(0));
                    TB_Receveur.AutoCompleteCustomSource.Add(objRead.GetString(0));
                }
                TB_Visiteur.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                TB_Visiteur.AutoCompleteSource = AutoCompleteSource.CustomSource;
                TB_Receveur.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                TB_Receveur.AutoCompleteSource = AutoCompleteSource.CustomSource;
                objRead.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
        private void LoadDataset()
        {
            try
            {
                string sqlShow = "Select * from matchs order by nomatch";
                if (NoMatch != -1)
                {
                    sqlShow = "Select * from matchs where nomatch =" + NoMatch;
                }
                
                Oraliste = new OracleDataAdapter(sqlShow, conn);
                if (formDataSet.Tables.Contains("Match"))
                {
                    formDataSet.Tables["Match"].Clear();
                }
                Oraliste.Fill(formDataSet, "Match");
                Oraliste.Dispose();

                BindingSource maSource = new BindingSource(formDataSet, "Match");
                Vider();
                Lister();               
            }
            catch (Exception se) { MessageBox.Show(se.Message.ToString()); }
        }
        private void Lister()
        {
            LB_No_Match.DataBindings.Add("Text", formDataSet, "Match.nomatch");
            DTP_Date.DataBindings.Add("Text", formDataSet, "Match.datematch");
            TB_Lieu.DataBindings.Add("Text", formDataSet, "Match.lieu");
            TB_Receveur.DataBindings.Add("Text", formDataSet, "Match.receveur");
            TB_Visiteur.DataBindings.Add("Text", formDataSet, "Match.visiteur");
            TB_R_Pts.DataBindings.Add("Text", formDataSet, "Match.butsreceveur");
            TB_V_Pts.DataBindings.Add("Text", formDataSet, "Match.butsvisiteur");
        }
        private void Vider()
        {
            LB_No_Match.DataBindings.Clear();
            DTP_Date.DataBindings.Clear();
            TB_Lieu.DataBindings.Clear();
            TB_Receveur.DataBindings.Clear();
            TB_Visiteur.DataBindings.Clear();
            TB_R_Pts.DataBindings.Clear();
            TB_V_Pts.DataBindings.Clear();
                      
            DTP_Date.Value = DateTime.Now;
            TB_Lieu.Clear();
            TB_Receveur.Clear();
            TB_Visiteur.Clear();
            TB_R_Pts.Clear();
            TB_V_Pts.Clear();
            
        }

        private void uC_Navigator_OnFirst(object sender, EventArgs e)
        {
            this.BindingContext[formDataSet, "Match"].Position = 0;            
        }

        private void uC_Navigator_OnLast(object sender, EventArgs e)
        {
            this.BindingContext[formDataSet, "Match"].Position =
                this.BindingContext[formDataSet, "Match"].Count - 1;            
        }
        private void uC_Navigator_OnNext(object sender, EventArgs e)
        {
            this.BindingContext[formDataSet, "Match"].Position += 1;
        }

        private void uC_Navigator_OnPrev(object sender, EventArgs e)
        {
            this.BindingContext[formDataSet, "Match"].Position -= 1;
        }
        private void BTN_Add_Click(object sender, EventArgs e)
        {
            if (TB_Receveur.Text != TB_Visiteur.Text)
            {
                try
                {
                    string sqlAdd = "INSERT INTO Matchs VALUES (SeqMatchs.nextval,:RECEV,:VISIT," +
                        " :DATEMATCH, :LIEU, :BUTSR, :BUTSV)";

                    OracleParameter oParamRecev = new OracleParameter(":RECEV", OracleDbType.Varchar2, 30);
                    OracleParameter oParamVisit = new OracleParameter(":VISIT", OracleDbType.Varchar2, 30);
                    OracleParameter oParamDate = new OracleParameter(":DATEMATCH", OracleDbType.Date);
                    OracleParameter oParamLieu = new OracleParameter(":LIEU", OracleDbType.Varchar2, 30);
                    OracleParameter oParamButsR = new OracleParameter(":BUTSR", OracleDbType.Int32, 2);
                    OracleParameter oParamButsV = new OracleParameter(":BUTSV", OracleDbType.Int32, 2);

                    oParamRecev.Value = TB_Receveur.Text;
                    oParamVisit.Value = TB_Visiteur.Text;
                    oParamDate.Value = DTP_Date.Value;
                    oParamLieu.Value = TB_Lieu.Text;
                    oParamButsR.Value = int.Parse(TB_R_Pts.Text);
                    oParamButsV.Value = int.Parse(TB_V_Pts.Text);

                    OracleCommand orComm = new OracleCommand(sqlAdd, conn);
                    orComm.Parameters.Add(oParamRecev);
                    orComm.Parameters.Add(oParamVisit);
                    orComm.Parameters.Add(oParamDate);
                    orComm.Parameters.Add(oParamLieu);
                    orComm.Parameters.Add(oParamButsR);
                    orComm.Parameters.Add(oParamButsV);
                    orComm.ExecuteNonQuery();
                    MessageBox.Show(" Le match a été ajouté");

                    LoadDataset();
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
            else
            {
                MessageBox.Show("Une équipe ne peut jouer contre elle-même.");
            }
        }

        private void BTN_Del_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Voulez-vous vraiment supprimer cet enregistrement?", "Attention", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    string sqlDelete = "DELETE FROM matchs WHERE Nomatch = :NO";

                    OracleParameter oParamNo = new OracleParameter(":NO", OracleDbType.Int32, 3);
                    oParamNo.Value = int.Parse(LB_No_Match.Text);

                    OracleCommand orComm = new OracleCommand(sqlDelete, conn);
                    orComm.Parameters.Add(oParamNo);
                    int res = orComm.ExecuteNonQuery();

                    LoadDataset();
                    if (res > 0)
                    {
                        MessageBox.Show(" Le match a été suprimé");
                    }
                    else
                    {
                        MessageBox.Show("Aucune entrée n'est présente");
                    }
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
            if (TB_Receveur.Text != TB_Visiteur.Text)
            {
                try
                {
                    string sqlUpdate = "UPDATE matchs SET Receveur = :RECEV, Visiteur = :VISIT, datematch = :DATEMATCH," +
                    " Lieu = :LIEU, butsreceveur = :BUTSR, butsvisiteur = :BUTSV WHERE Nomatch = :NO"; //requete met a jour

                    OracleParameter oParamRecev = new OracleParameter(":RECEV", OracleDbType.Varchar2, 30);
                    OracleParameter oParamVisit = new OracleParameter(":VISIT", OracleDbType.Varchar2, 30);
                    OracleParameter oParamDate = new OracleParameter(":DATEMATCH", OracleDbType.Date);
                    OracleParameter oParamLieu = new OracleParameter(":LIEU", OracleDbType.Varchar2, 30);
                    OracleParameter oParamButsR = new OracleParameter(":BUTSR", OracleDbType.Int32, 2);
                    OracleParameter oParamButsV = new OracleParameter(":BUTSV", OracleDbType.Int32, 2);
                    OracleParameter oParamNo = new OracleParameter(":NO", OracleDbType.Int32, 3);

                    oParamRecev.Value = TB_Receveur.Text;
                    oParamVisit.Value = TB_Visiteur.Text;
                    oParamDate.Value = DTP_Date.Value;
                    oParamLieu.Value = TB_Lieu.Text;
                    oParamButsR.Value = int.Parse(TB_R_Pts.Text);
                    oParamButsV.Value = int.Parse(TB_V_Pts.Text);
                    oParamNo.Value = int.Parse(LB_No_Match.Text);

                    OracleCommand orComm = new OracleCommand(sqlUpdate, conn);
                    orComm.Parameters.Add(oParamRecev);
                    orComm.Parameters.Add(oParamVisit);
                    orComm.Parameters.Add(oParamDate);
                    orComm.Parameters.Add(oParamLieu);
                    orComm.Parameters.Add(oParamButsR);
                    orComm.Parameters.Add(oParamButsV);
                    orComm.Parameters.Add(oParamNo);
                    orComm.ExecuteNonQuery();

                    MessageBox.Show(" Le match a été modifié");

                    LoadDataset();
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
            else
            {
                MessageBox.Show("Une équipe ne peut jouer contre elle-même.");
            }
        }           

        private void ErrorMessage(OracleException Ex)
        {
            switch (Ex.Number)
            {
                case 02290:
                    // au lieu d'afficher violation de clé étrangère , on affiche ceci:
                    MessageBox.Show("Entrée invalide");
                    break;                
                case 01400:
                    MessageBox.Show("Il y a des champs vides");
                    break;
                default: MessageBox.Show(Ex.Message.ToString());
                    break;  
            }
        }

        private void FB_Fiche_Resultat_Click(object sender, EventArgs e)
        {
            try
            {
                OuvrireResultat();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Il n'y a pas de joueur dans une des équipes");
            }
        }
        private void OuvrireResultat()
        {
            Resultat_Match Form = new Resultat_Match();
            Form.conn = conn;
            Form.NoMatch = int.Parse(LB_No_Match.Text);
            Form.ShowDialog();
        }     
    }
}

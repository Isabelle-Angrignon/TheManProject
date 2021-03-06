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
    public partial class GestionJoueur : Form
    {
        public GestionJoueur()
        {
            InitializeComponent();
        }
        public OracleConnection conn = new OracleConnection();
        private DataSet formDataSet = new DataSet();
        private const string dsTable = "Table";
        OracleDataAdapter Oraliste;
        public int NoJoueur = -1;
        public string NomEquipe = "";
        /////////////////////////////////////////////////
        //Pour valider l'entrée du no de maillot
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
            Close();
        }

        private void BTN_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        } 
        private void GestionJoueur_Load(object sender, EventArgs e)
        {
            LoadDataset();
            AutoCompletePosition();
            ContournerBinding(TB_Position.Text);
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

        private void AutoCompleteEquipe()
        {
            try
            {
                OracleCommand oraCmdProg = new OracleCommand("select NomÉquipe From Équipes", conn);
                oraCmdProg.CommandType = CommandType.Text;

                OracleDataReader objRead = oraCmdProg.ExecuteReader();
                while (objRead.Read())
                {
                    TB_Équipe.AutoCompleteCustomSource.Add(objRead.GetString(0));
                }
                TB_Équipe.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                TB_Équipe.AutoCompleteSource = AutoCompleteSource.CustomSource;
                objRead.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
        private void AutoCompletePosition()
        {
            char[] séparateur = { '\r', '\n' };
            String[] Positions = The_Main_Project.Properties.Resources.Position.Split(séparateur, StringSplitOptions.RemoveEmptyEntries);

            foreach (String position in Positions)
            {
                TB_Position.AutoCompleteCustomSource.Add(position);
            }

            TB_Position.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            TB_Position.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }
        private void ContournerBinding(string ARemplacer)
        {
            if (ARemplacer == "G")
            {
                TB_Position.Text = "Guardien";
            }
            if (ARemplacer == "A")
            {
                TB_Position.Text = "Attaquant";
            }
            if (ARemplacer == "D")
            {
                TB_Position.Text = "Défenseur";
            }
        }
        private void LoadDataset()
        {
            try
            {
                string sqlShow = "Select * from Joueurs order by nomaillot";
                if (NoJoueur != -1)
                {
                    sqlShow = "Select * from Joueurs where nojoueur =" + NoJoueur;
                }
                if (NomEquipe != "")
                {
                    sqlShow = "Select * from joueurs where noméquipe ='" + NomEquipe + "'";
                }
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
                ContournerBinding(TB_Position.Text);
            }
            catch (Exception se) { MessageBox.Show(se.Message.ToString()); }
        }
        private void Lister()
        {
            LB_No_J.DataBindings.Add("Text", formDataSet, "Table.NoJoueur");
            TB_Nom_J.DataBindings.Add("Text", formDataSet, "Table.Nom");
            TB_Prenom_J.DataBindings.Add("Text", formDataSet, "Table.Prénom");
            DTP_Naissance.DataBindings.Add("Text", formDataSet, "Table.Naissance");
            TB_Position.DataBindings.Add("Text", formDataSet, "Table.Position");
            TB_Maillot.DataBindings.Add("Text", formDataSet, "Table.nomaillot"); 
            TB_Équipe.DataBindings.Add("Text", formDataSet, "Table.noméquipe");        
        }
        private void Vider()
        {
            LB_No_J.DataBindings.Clear();
            TB_Nom_J.DataBindings.Clear();
            TB_Prenom_J.DataBindings.Clear();
            DTP_Naissance.DataBindings.Clear();
            TB_Position.DataBindings.Clear();
            TB_Maillot.DataBindings.Clear();
            TB_Équipe.DataBindings.Clear();            
            TB_Nom_J.Clear();
            TB_Prenom_J.Clear();
            DTP_Naissance.Value = DateTime.Now;
            TB_Position.Clear();
            TB_Maillot.Clear();
            TB_Équipe.Clear(); 
        }

        private void uC_Navigator_OnFirst(object sender, EventArgs e)
        {
            this.BindingContext[formDataSet, dsTable].Position = 0;
            ContournerBinding(TB_Position.Text);
        }

        private void uC_Navigator_OnLast(object sender, EventArgs e)
        {
            this.BindingContext[formDataSet, dsTable].Position =
                this.BindingContext[formDataSet, dsTable].Count - 1;
            ContournerBinding(TB_Position.Text);
        }
        private void uC_Navigator_OnNext(object sender, EventArgs e)
        {
            this.BindingContext[formDataSet, dsTable].Position += 1;
            ContournerBinding(TB_Position.Text);
        }

        private void uC_Navigator_OnPrev(object sender, EventArgs e)
        {
            this.BindingContext[formDataSet, dsTable].Position -= 1;
            ContournerBinding(TB_Position.Text);
        }        
        private void BTN_Add_Click(object sender, EventArgs e)
        {
            try
            {
                string Nom = TB_Prenom_J.Text + " " + TB_Nom_J.Text;
                string sqlAdd = "INSERT INTO Joueurs VALUES (seqJoueurs.nextval,:NOM,:PRENOM, "+
                    " :NAISSANCE,:POSITION,:MAILLOT,:EQUIPE)";
                OracleParameter oParamNom = new OracleParameter(":NOM", OracleDbType.Varchar2, 20);
                OracleParameter oParamPrenom = new OracleParameter(":PRENOM", OracleDbType.Varchar2, 20);
                OracleParameter oParamDate = new OracleParameter(":NAISSANCE", OracleDbType.Date);
                OracleParameter oParamPos = new OracleParameter(":POSITION", OracleDbType.Varchar2, 1);
                OracleParameter oParamMail = new OracleParameter(":MAILLOT", OracleDbType.Varchar2, 2);
                OracleParameter oParamEqu = new OracleParameter(":EQUIPE", OracleDbType.Varchar2, 30);
                oParamNom.Value = TB_Nom_J.Text;
                oParamPrenom.Value = TB_Prenom_J.Text;
                oParamDate.Value = DTP_Naissance.Value;
                oParamPos.Value = TB_Position.Text[0];
                oParamMail.Value = TB_Maillot.Text;
                oParamEqu.Value = TB_Équipe.Text;

                OracleCommand orComm = new OracleCommand(sqlAdd, conn);
                orComm.Parameters.Add(oParamNom);
                orComm.Parameters.Add(oParamPrenom);
                orComm.Parameters.Add(oParamDate);
                orComm.Parameters.Add(oParamPos);
                orComm.Parameters.Add(oParamMail);
                orComm.Parameters.Add(oParamEqu);
                orComm.ExecuteNonQuery();
                MessageBox.Show(" Le joueur " + Nom + " a été ajouté");

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

        private void BTN_Del_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Voulez-vous vraiment supprimer ce joueur?", "Attention", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    string sqlDelete = "DELETE FROM Joueurs WHERE NoJoueur = :NO";
                    string Nom = TB_Prenom_J.Text + " " + TB_Nom_J.Text;
                    OracleParameter oParamNo = new OracleParameter(":NO", OracleDbType.Int32, 4);
                    oParamNo.Value = int.Parse(LB_No_J.Text);

                    OracleCommand orComm = new OracleCommand(sqlDelete, conn);
                    orComm.Parameters.Add(oParamNo);
                    int res = orComm.ExecuteNonQuery();

                    LoadDataset();
                    if (res > 0)
                    {
                        MessageBox.Show(" Le joueur " + Nom + " a été suprimé");
                    }
                    else
                    {
                        MessageBox.Show(" Aucune entrée");
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
            try
            {
                /////enregistrer la clé primaire d'abord pour pouvoir la modifier...  
                string Nom = TB_Prenom_J.Text + " " + TB_Nom_J.Text;
                string sqlUpdate = "UPDATE Joueurs SET Nom = :NOM, Prénom = :PRENOM, Naissance = :Naissance," +
                " Position = :POSITION, nomaillot = :MAILLOT, NomÉquipe = :EQUIPE WHERE NoJoueur = :NO"; //requete met a jour

                OracleParameter oParamNom = new OracleParameter(":NOM", OracleDbType.Varchar2, 20);
                OracleParameter oParamPrenom = new OracleParameter(":PRENOM", OracleDbType.Varchar2, 20);
                OracleParameter oParamDate = new OracleParameter(":NAISSANCE", OracleDbType.Date);
                OracleParameter oParamPos = new OracleParameter(":POSITION", OracleDbType.Varchar2, 1);
                OracleParameter oParamMail = new OracleParameter(":MAILLOT", OracleDbType.Int32, 2);
                OracleParameter oParamEqu = new OracleParameter(":EQUIPE", OracleDbType.Varchar2, 30);
                OracleParameter oParamNo = new OracleParameter(":NO", OracleDbType.Int32, 4);
                oParamNom.Value = TB_Nom_J.Text;
                oParamPrenom.Value = TB_Prenom_J.Text;
                oParamDate.Value = DTP_Naissance.Value;
                oParamPos.Value = TB_Position.Text[0];
                oParamMail.Value = int.Parse(TB_Maillot.Text);
                oParamEqu.Value = TB_Équipe.Text;
                oParamNo.Value = int.Parse(LB_No_J.Text);

                OracleCommand orComm = new OracleCommand(sqlUpdate, conn);
                orComm.Parameters.Add(oParamNom);
                orComm.Parameters.Add(oParamPrenom);
                orComm.Parameters.Add(oParamDate);
                orComm.Parameters.Add(oParamPos);
                orComm.Parameters.Add(oParamMail);
                orComm.Parameters.Add(oParamEqu);
                orComm.Parameters.Add(oParamNo);
                orComm.ExecuteNonQuery();
                MessageBox.Show(" Le joueur " + Nom + " a été modifié");

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

        private void BTN_Stats_Click(object sender, EventArgs e)
        {
            AfficherStat Form = new AfficherStat();
            Form.NoJoueur = int.Parse(LB_No_J.Text);
            Form.conn = conn;
            Form.ShowDialog();
        }

        private void ErrorMessage(OracleException Ex)
        {
            switch (Ex.Number)
            {
                case 02290:
                    // au lieu d'afficher violation de clé étrangère , on affiche ceci:
                    MessageBox.Show("Entrée invalide");
                    break;
                case 02292:
                    MessageBox.Show("Le joueur choisi est inscrit dans au moins un match: " +
                        "on ne peut le suprimer.");
                    break;
                case 01400:
                    MessageBox.Show("Il y a des champs vides");
                    break;
                default: MessageBox.Show(Ex.Message.ToString());
                    break;
            }
        }
    }
}

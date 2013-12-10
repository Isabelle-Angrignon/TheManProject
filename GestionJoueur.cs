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
        }
        private void LoadDataset()
        {
            try
            {
                string sqlShow = "Select * from Joueurs order by nomaillot";////ou par nom, prénom
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
            //LB_No_J.  pas de clear...invisible anyway
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
        private void BTN_Add_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlAdd = "INSERT INTO Joueurs VALUES (seqJoueurs.nextval,:NOM,:PRENOM,:"+
                    " NAISSANCE,:POSITION,:MAILLOT,:EQUIPE)";
                OracleParameter oParamNom = new OracleParameter(":NOM", OracleDbType.Varchar2, 20);
                OracleParameter oParamPrenom = new OracleParameter(":PRENOM", OracleDbType.Varchar2, 20);
                OracleParameter oParamDate = new OracleParameter(":NAISSANCE", OracleDbType.Date);
                OracleParameter oParamPos = new OracleParameter(":POSITION", OracleDbType.Varchar2, 1);
                OracleParameter oParamMail = new OracleParameter(":MAILLOT", OracleDbType.Varchar2, 2);
                OracleParameter oParamEqu = new OracleParameter(":EQUIPE", OracleDbType.Varchar2, 30);
                oParamNom.Value = TB_Nom_J.Text;
                oParamPrenom.Value = TB_Prenom_J.Text;
                oParamDate.Value = DTP_Naissance.Value;
                oParamPos.Value = TB_Position.Text;
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

                LoadDataset();
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
                string sqlDelete = "DELETE FROM Joueurs WHERE NoJoueur = :NO";

                OracleParameter oParamNo = new OracleParameter(":NO", OracleDbType.Int32, 4);
                oParamNo.Value = LB_No_J.Text;

                OracleCommand orComm = new OracleCommand(sqlDelete, conn);
                orComm.Parameters.Add(oParamNo);
                orComm.ExecuteNonQuery();

                LoadDataset();
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
                string sqlUpdate = "UPDATE Joueurs SET Nom = :NOM, Prénom = :PRENOM, Naissance = :Naissance," +
                " Position = :POSITION, NomÉquipe = :EQUIPE WHERE NoJoueur = :NO"; //requete met a jour

                OracleParameter oParamNom = new OracleParameter(":NOM", OracleDbType.Varchar2, 20);
                OracleParameter oParamPrenom = new OracleParameter(":PRENOM", OracleDbType.Varchar2, 20);
                OracleParameter oParamDate = new OracleParameter(":NAISSANCE", OracleDbType.Date);
                OracleParameter oParamPos = new OracleParameter(":POSITION", OracleDbType.Varchar2, 1);
                OracleParameter oParamMail = new OracleParameter(":MAILLOT", OracleDbType.Varchar2, 2);
                OracleParameter oParamEqu = new OracleParameter(":EQUIPE", OracleDbType.Varchar2, 30);
                OracleParameter oParamNo = new OracleParameter(":NO", OracleDbType.Int32, 4);
                oParamNom.Value = TB_Nom_J.Text;
                oParamPrenom.Value = TB_Prenom_J.Text;
                oParamDate.Value = DTP_Naissance.Value;
                oParamPos.Value = TB_Position.Text;
                oParamMail.Value = TB_Maillot.Text;
                oParamEqu.Value = TB_Équipe.Text;
                oParamNo.Value = LB_No_J.Text;

                OracleCommand orComm = new OracleCommand(sqlUpdate, conn);
                orComm.Parameters.Add(oParamNom);
                orComm.Parameters.Add(oParamPrenom);
                orComm.Parameters.Add(oParamDate);
                orComm.Parameters.Add(oParamPos);
                orComm.Parameters.Add(oParamMail);
                orComm.Parameters.Add(oParamEqu);
                orComm.Parameters.Add(oParamNo);
                orComm.ExecuteNonQuery();

                LoadDataset();
            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void BTN_Stats_Click(object sender, EventArgs e)
        {

        }        


    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_Main_Project
{
    public partial class Parametre : Form
    {
        public Parametre()
        {
            InitializeComponent();
        }
        public Form_League Form;
        int Choix = 0;

        private  Color D_BackColor = SystemColors.ButtonFace;
        private  Color D_PairRow = Color.White;
        private  Color D_Label = Color.Black;
        private  Color D_ImpairRow = Color.Gainsboro;
        private  Color D_Menu_Back = SystemColors.Menu;

        private Color S_BackColor = Color.FromArgb(33,33,33);
        private Color S_PairRow = Color.LightGray;
        private Color S_Label = Color.White;
        private Color S_ImpairRow = Color.Gray;
        private Color S_Menu_Back = Color.FromArgb(33,33,33);

        private void BTN_Ok_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void RB_Defaut_CheckedChanged(object sender, EventArgs e)
        {
            Choix = 0;
        }

        private void RB_Canadien_CheckedChanged(object sender, EventArgs e)
        {
            Choix = 1;
        }

        private void RB_Sombre_CheckedChanged(object sender, EventArgs e)
        {
            Choix = 2;
        }

        private void BTN_Appliquer_Click(object sender, EventArgs e)
        {
            if (Choix == 0)
            {
                Properties.Settings.Default.Label_Color = D_Label;
                Properties.Settings.Default.Back_Color = D_BackColor;
                Properties.Settings.Default.DGV_Impair = D_ImpairRow;
                Properties.Settings.Default.DGV_Pair = D_PairRow;
                Properties.Settings.Default.Menu_Back = D_Menu_Back;
            }
            if (Choix == 1)
            {

            }
            if (Choix == 2)
            {
                Properties.Settings.Default.Label_Color = S_Label;
                Properties.Settings.Default.Back_Color = S_BackColor;
                Properties.Settings.Default.DGV_Impair = S_ImpairRow;
                Properties.Settings.Default.DGV_Pair = S_PairRow;
                Properties.Settings.Default.Menu_Back = S_Menu_Back;
            }
            
            Form.ChangeColor();
            ChangeColorMenu();
            Properties.Settings.Default.Save();
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
    }
}

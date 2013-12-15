namespace The_Main_Project
{
    partial class GestionJoueur
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionJoueur));
            this.Caractérstique = new System.Windows.Forms.GroupBox();
            this.uC_Navigator = new UC_Navigator.UC_Navigator();
            this.BTN_Stats = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TB_Maillot = new System.Windows.Forms.TextBox();
            this.TB_Équipe = new System.Windows.Forms.TextBox();
            this.DTP_Naissance = new System.Windows.Forms.DateTimePicker();
            this.TB_Nom_J = new System.Windows.Forms.TextBox();
            this.BTN_Edit = new System.Windows.Forms.Button();
            this.BTN_Del = new System.Windows.Forms.Button();
            this.BTN_Add = new System.Windows.Forms.Button();
            this.TB_Position = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TB_Prenom_J = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LB_No_J = new System.Windows.Forms.Label();
            this.FB_Close = new FlashButton.FlashButton();
            this.Caractérstique.SuspendLayout();
            this.SuspendLayout();
            // 
            // Caractérstique
            // 
            this.Caractérstique.Controls.Add(this.uC_Navigator);
            this.Caractérstique.Controls.Add(this.BTN_Stats);
            this.Caractérstique.Controls.Add(this.label2);
            this.Caractérstique.Controls.Add(this.TB_Maillot);
            this.Caractérstique.Controls.Add(this.TB_Équipe);
            this.Caractérstique.Controls.Add(this.DTP_Naissance);
            this.Caractérstique.Controls.Add(this.TB_Nom_J);
            this.Caractérstique.Controls.Add(this.BTN_Edit);
            this.Caractérstique.Controls.Add(this.BTN_Del);
            this.Caractérstique.Controls.Add(this.BTN_Add);
            this.Caractérstique.Controls.Add(this.TB_Position);
            this.Caractérstique.Controls.Add(this.label6);
            this.Caractérstique.Controls.Add(this.label5);
            this.Caractérstique.Controls.Add(this.TB_Prenom_J);
            this.Caractérstique.Controls.Add(this.label4);
            this.Caractérstique.Controls.Add(this.label3);
            this.Caractérstique.Controls.Add(this.label1);
            this.Caractérstique.Location = new System.Drawing.Point(12, 12);
            this.Caractérstique.Name = "Caractérstique";
            this.Caractérstique.Size = new System.Drawing.Size(329, 230);
            this.Caractérstique.TabIndex = 3;
            this.Caractérstique.TabStop = false;
            // 
            // uC_Navigator
            // 
            this.uC_Navigator.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uC_Navigator.Location = new System.Drawing.Point(29, 195);
            this.uC_Navigator.Name = "uC_Navigator";
            this.uC_Navigator.Size = new System.Drawing.Size(206, 19);
            this.uC_Navigator.TabIndex = 37;
            this.uC_Navigator.OnFirst += new UC_Navigator.UC_Navigator.ClickFirstChangedHandler(this.uC_Navigator_OnFirst);
            this.uC_Navigator.OnPrev += new UC_Navigator.UC_Navigator.ClickPreviousChangedHandler(this.uC_Navigator_OnPrev);
            this.uC_Navigator.OnNext += new UC_Navigator.UC_Navigator.ClickNextChangedHandler(this.uC_Navigator_OnNext);
            this.uC_Navigator.OnLast += new UC_Navigator.UC_Navigator.ClickLastChangedHandler(this.uC_Navigator_OnLast);
            // 
            // BTN_Stats
            // 
            this.BTN_Stats.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Stats.Location = new System.Drawing.Point(265, 182);
            this.BTN_Stats.Name = "BTN_Stats";
            this.BTN_Stats.Size = new System.Drawing.Size(58, 39);
            this.BTN_Stats.TabIndex = 22;
            this.BTN_Stats.Text = "Fiche";
            this.BTN_Stats.UseVisualStyleBackColor = true;
            this.BTN_Stats.Click += new System.EventHandler(this.BTN_Stats_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Équipe";
            // 
            // TB_Maillot
            // 
            this.TB_Maillot.Location = new System.Drawing.Point(96, 18);
            this.TB_Maillot.Name = "TB_Maillot";
            this.TB_Maillot.Size = new System.Drawing.Size(100, 20);
            this.TB_Maillot.TabIndex = 20;
            this.TB_Maillot.Text = "Check pas déja équipe";
            this.TB_Maillot.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_Chiffres_Seulement_KeyPress);
            // 
            // TB_Équipe
            // 
            this.TB_Équipe.Location = new System.Drawing.Point(98, 153);
            this.TB_Équipe.Name = "TB_Équipe";
            this.TB_Équipe.Size = new System.Drawing.Size(141, 20);
            this.TB_Équipe.TabIndex = 19;
            this.TB_Équipe.Text = "Autofill";
            // 
            // DTP_Naissance
            // 
            this.DTP_Naissance.Location = new System.Drawing.Point(108, 102);
            this.DTP_Naissance.Name = "DTP_Naissance";
            this.DTP_Naissance.Size = new System.Drawing.Size(131, 20);
            this.DTP_Naissance.TabIndex = 17;
            // 
            // TB_Nom_J
            // 
            this.TB_Nom_J.Location = new System.Drawing.Point(96, 45);
            this.TB_Nom_J.Name = "TB_Nom_J";
            this.TB_Nom_J.Size = new System.Drawing.Size(143, 20);
            this.TB_Nom_J.TabIndex = 16;
            // 
            // BTN_Edit
            // 
            this.BTN_Edit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Edit.Image = global::The_Main_Project.Properties.Resources.Crayon_petit;
            this.BTN_Edit.Location = new System.Drawing.Point(277, 116);
            this.BTN_Edit.Name = "BTN_Edit";
            this.BTN_Edit.Size = new System.Drawing.Size(40, 40);
            this.BTN_Edit.TabIndex = 3;
            this.BTN_Edit.UseVisualStyleBackColor = true;
            this.BTN_Edit.Click += new System.EventHandler(this.BTN_Edit_Click);
            // 
            // BTN_Del
            // 
            this.BTN_Del.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Del.Image = ((System.Drawing.Image)(resources.GetObject("BTN_Del.Image")));
            this.BTN_Del.Location = new System.Drawing.Point(277, 70);
            this.BTN_Del.Name = "BTN_Del";
            this.BTN_Del.Size = new System.Drawing.Size(40, 40);
            this.BTN_Del.TabIndex = 4;
            this.BTN_Del.UseVisualStyleBackColor = true;
            this.BTN_Del.Click += new System.EventHandler(this.BTN_Del_Click);
            // 
            // BTN_Add
            // 
            this.BTN_Add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Add.Image = global::The_Main_Project.Properties.Resources.BTN_Plus1;
            this.BTN_Add.Location = new System.Drawing.Point(277, 25);
            this.BTN_Add.Name = "BTN_Add";
            this.BTN_Add.Size = new System.Drawing.Size(40, 40);
            this.BTN_Add.TabIndex = 5;
            this.BTN_Add.UseVisualStyleBackColor = true;
            this.BTN_Add.Click += new System.EventHandler(this.BTN_Add_Click);
            // 
            // TB_Position
            // 
            this.TB_Position.Location = new System.Drawing.Point(96, 128);
            this.TB_Position.Name = "TB_Position";
            this.TB_Position.Size = new System.Drawing.Size(143, 20);
            this.TB_Position.TabIndex = 10;
            this.TB_Position.Text = "Autofill";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Position";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Date naissance";
            // 
            // TB_Prenom_J
            // 
            this.TB_Prenom_J.Location = new System.Drawing.Point(96, 73);
            this.TB_Prenom_J.Name = "TB_Prenom_J";
            this.TB_Prenom_J.Size = new System.Drawing.Size(143, 20);
            this.TB_Prenom_J.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Prénom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nom";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "# Chandail";
            // 
            // LB_No_J
            // 
            this.LB_No_J.AutoSize = true;
            this.LB_No_J.Location = new System.Drawing.Point(9, 284);
            this.LB_No_J.Name = "LB_No_J";
            this.LB_No_J.Size = new System.Drawing.Size(0, 13);
            this.LB_No_J.TabIndex = 38;
            // 
            // FB_Close
            // 
            this.FB_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.FB_Close.BackgroundImage = global::The_Main_Project.Properties.Resources.Porte;
            this.FB_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FB_Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FB_Close.ImageClick = global::The_Main_Project.Properties.Resources.PorteCLic;
            this.FB_Close.ImageDisable = null;
            this.FB_Close.ImageNeutral = global::The_Main_Project.Properties.Resources.Porte;
            this.FB_Close.ImageOver = global::The_Main_Project.Properties.Resources.PorteOver;
            this.FB_Close.Location = new System.Drawing.Point(296, 248);
            this.FB_Close.Name = "FB_Close";
            this.FB_Close.Size = new System.Drawing.Size(40, 46);
            this.FB_Close.TabIndex = 39;
            this.FB_Close.Click += new System.EventHandler(this.BTN_Ok_Click);
            // 
            // GestionJoueur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 306);
            this.Controls.Add(this.LB_No_J);
            this.Controls.Add(this.FB_Close);
            this.Controls.Add(this.Caractérstique);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "GestionJoueur";
            this.Text = "Gestion joueur";
            this.Load += new System.EventHandler(this.GestionJoueur_Load);
            this.Caractérstique.ResumeLayout(false);
            this.Caractérstique.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox Caractérstique;
        private System.Windows.Forms.Button BTN_Edit;
        private System.Windows.Forms.Button BTN_Del;
        private System.Windows.Forms.Button BTN_Add;
        private System.Windows.Forms.TextBox TB_Position;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TB_Prenom_J;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TB_Nom_J;
        private System.Windows.Forms.Button BTN_Stats;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TB_Maillot;
        private System.Windows.Forms.TextBox TB_Équipe;
        private System.Windows.Forms.DateTimePicker DTP_Naissance;
        private UC_Navigator.UC_Navigator uC_Navigator;
        private System.Windows.Forms.Label LB_No_J;
        private FlashButton.FlashButton FB_Close;
    }
}
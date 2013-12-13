namespace The_Main_Project
{
    partial class GestionMatch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionMatch));
            this.BTN_MOD = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TB_R_Pts = new System.Windows.Forms.TextBox();
            this.TB_V_Pts = new System.Windows.Forms.TextBox();
            this.UC_Navigator = new UC_Navigator.UC_Navigator();
            this.button2 = new System.Windows.Forms.Button();
            this.BTN_Delete = new System.Windows.Forms.Button();
            this.BTN_Add = new System.Windows.Forms.Button();
            this.TB_Receveur = new System.Windows.Forms.TextBox();
            this.TB_Visiteur = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TB_Lieu = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DTP_Date = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.FB_Close = new FlashButton.FlashButton();
            this.FB_Fiche_Resultat = new FlashButton.FlashButton();
            this.label2 = new System.Windows.Forms.Label();
            this.LB_No_Match = new System.Windows.Forms.Label();
            this.BTN_MOD.SuspendLayout();
            this.SuspendLayout();
            // 
            // BTN_MOD
            // 
            this.BTN_MOD.Controls.Add(this.label1);
            this.BTN_MOD.Controls.Add(this.TB_R_Pts);
            this.BTN_MOD.Controls.Add(this.TB_V_Pts);
            this.BTN_MOD.Controls.Add(this.UC_Navigator);
            this.BTN_MOD.Controls.Add(this.button2);
            this.BTN_MOD.Controls.Add(this.BTN_Delete);
            this.BTN_MOD.Controls.Add(this.BTN_Add);
            this.BTN_MOD.Controls.Add(this.TB_Receveur);
            this.BTN_MOD.Controls.Add(this.TB_Visiteur);
            this.BTN_MOD.Controls.Add(this.label6);
            this.BTN_MOD.Controls.Add(this.label5);
            this.BTN_MOD.Controls.Add(this.TB_Lieu);
            this.BTN_MOD.Controls.Add(this.label4);
            this.BTN_MOD.Controls.Add(this.DTP_Date);
            this.BTN_MOD.Controls.Add(this.label3);
            this.BTN_MOD.Location = new System.Drawing.Point(12, 12);
            this.BTN_MOD.Name = "BTN_MOD";
            this.BTN_MOD.Size = new System.Drawing.Size(295, 167);
            this.BTN_MOD.TabIndex = 0;
            this.BTN_MOD.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(183, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 41;
            this.label1.Text = "Pts";
            // 
            // TB_R_Pts
            // 
            this.TB_R_Pts.Location = new System.Drawing.Point(171, 71);
            this.TB_R_Pts.Name = "TB_R_Pts";
            this.TB_R_Pts.Size = new System.Drawing.Size(39, 20);
            this.TB_R_Pts.TabIndex = 40;
            this.TB_R_Pts.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_Chiffres_Seulement_KeyPress);
            // 
            // TB_V_Pts
            // 
            this.TB_V_Pts.Location = new System.Drawing.Point(171, 97);
            this.TB_V_Pts.Name = "TB_V_Pts";
            this.TB_V_Pts.Size = new System.Drawing.Size(39, 20);
            this.TB_V_Pts.TabIndex = 39;
            this.TB_V_Pts.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_Chiffres_Seulement_KeyPress);
            // 
            // UC_Navigator
            // 
            this.UC_Navigator.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UC_Navigator.Location = new System.Drawing.Point(12, 132);
            this.UC_Navigator.Name = "UC_Navigator";
            this.UC_Navigator.Size = new System.Drawing.Size(206, 19);
            this.UC_Navigator.TabIndex = 38;
            this.UC_Navigator.OnFirst += new UC_Navigator.UC_Navigator.ClickFirstChangedHandler(this.uC_Navigator_OnFirst);
            this.UC_Navigator.OnPrev += new UC_Navigator.UC_Navigator.ClickPreviousChangedHandler(this.uC_Navigator_OnPrev);
            this.UC_Navigator.OnNext += new UC_Navigator.UC_Navigator.ClickNextChangedHandler(this.uC_Navigator_OnNext);
            this.UC_Navigator.OnLast += new UC_Navigator.UC_Navigator.ClickLastChangedHandler(this.uC_Navigator_OnLast);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Image = global::The_Main_Project.Properties.Resources.Crayon_petit;
            this.button2.Location = new System.Drawing.Point(240, 85);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(44, 43);
            this.button2.TabIndex = 3;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.BTN_Edit_Click);
            // 
            // BTN_Delete
            // 
            this.BTN_Delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Delete.Image = ((System.Drawing.Image)(resources.GetObject("BTN_Delete.Image")));
            this.BTN_Delete.Location = new System.Drawing.Point(240, 49);
            this.BTN_Delete.Name = "BTN_Delete";
            this.BTN_Delete.Size = new System.Drawing.Size(44, 40);
            this.BTN_Delete.TabIndex = 4;
            this.BTN_Delete.UseVisualStyleBackColor = true;
            this.BTN_Delete.Click += new System.EventHandler(this.BTN_Del_Click);
            // 
            // BTN_Add
            // 
            this.BTN_Add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Add.Image = global::The_Main_Project.Properties.Resources.BTN_Plus1;
            this.BTN_Add.Location = new System.Drawing.Point(240, 12);
            this.BTN_Add.Name = "BTN_Add";
            this.BTN_Add.Size = new System.Drawing.Size(44, 35);
            this.BTN_Add.TabIndex = 5;
            this.BTN_Add.UseVisualStyleBackColor = true;
            this.BTN_Add.Click += new System.EventHandler(this.BTN_Add_Click);
            // 
            // TB_Receveur
            // 
            this.TB_Receveur.Location = new System.Drawing.Point(65, 71);
            this.TB_Receveur.Name = "TB_Receveur";
            this.TB_Receveur.Size = new System.Drawing.Size(100, 20);
            this.TB_Receveur.TabIndex = 11;
            // 
            // TB_Visiteur
            // 
            this.TB_Visiteur.Location = new System.Drawing.Point(65, 97);
            this.TB_Visiteur.Name = "TB_Visiteur";
            this.TB_Visiteur.Size = new System.Drawing.Size(100, 20);
            this.TB_Visiteur.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Visiteur";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Receveur";
            // 
            // TB_Lieu
            // 
            this.TB_Lieu.Location = new System.Drawing.Point(65, 45);
            this.TB_Lieu.Name = "TB_Lieu";
            this.TB_Lieu.Size = new System.Drawing.Size(100, 20);
            this.TB_Lieu.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Lieu";
            // 
            // DTP_Date
            // 
            this.DTP_Date.Location = new System.Drawing.Point(54, 19);
            this.DTP_Date.Name = "DTP_Date";
            this.DTP_Date.Size = new System.Drawing.Size(111, 20);
            this.DTP_Date.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Date";
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
            this.FB_Close.Location = new System.Drawing.Point(260, 186);
            this.FB_Close.Name = "FB_Close";
            this.FB_Close.Size = new System.Drawing.Size(49, 46);
            this.FB_Close.TabIndex = 39;
            this.FB_Close.Click += new System.EventHandler(this.BTN_Ok_Click);
            // 
            // FB_Fiche_Resultat
            // 
            this.FB_Fiche_Resultat.BackgroundImage = global::The_Main_Project.Properties.Resources.FB_Resultat;
            this.FB_Fiche_Resultat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FB_Fiche_Resultat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FB_Fiche_Resultat.ImageClick = global::The_Main_Project.Properties.Resources.FB_Resultat_Click;
            this.FB_Fiche_Resultat.ImageDisable = global::The_Main_Project.Properties.Resources.FB_Resultat_Disable;
            this.FB_Fiche_Resultat.ImageNeutral = global::The_Main_Project.Properties.Resources.FB_Resultat;
            this.FB_Fiche_Resultat.ImageOver = global::The_Main_Project.Properties.Resources.FB_Resultat_Hover;
            this.FB_Fiche_Resultat.Location = new System.Drawing.Point(12, 187);
            this.FB_Fiche_Resultat.Name = "FB_Fiche_Resultat";
            this.FB_Fiche_Resultat.Size = new System.Drawing.Size(60, 45);
            this.FB_Fiche_Resultat.TabIndex = 24;
            this.FB_Fiche_Resultat.Click += new System.EventHandler(this.FB_Fiche_Resultat_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 40;
            this.label2.Text = "#";
            // 
            // LB_No_Match
            // 
            this.LB_No_Match.AutoSize = true;
            this.LB_No_Match.Location = new System.Drawing.Point(34, 7);
            this.LB_No_Match.Name = "LB_No_Match";
            this.LB_No_Match.Size = new System.Drawing.Size(0, 13);
            this.LB_No_Match.TabIndex = 41;
            // 
            // GestionMatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 242);
            this.Controls.Add(this.LB_No_Match);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FB_Close);
            this.Controls.Add(this.BTN_MOD);
            this.Controls.Add(this.FB_Fiche_Resultat);
            this.Name = "GestionMatch";
            this.Text = "Gestion Match";
            this.Load += new System.EventHandler(this.GestionMatch_Load);
            this.BTN_MOD.ResumeLayout(false);
            this.BTN_MOD.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox BTN_MOD;
        private System.Windows.Forms.TextBox TB_Receveur;
        private System.Windows.Forms.TextBox TB_Visiteur;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TB_Lieu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker DTP_Date;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button BTN_Delete;
        private System.Windows.Forms.Button BTN_Add;
        private UC_Navigator.UC_Navigator UC_Navigator;
        private FlashButton.FlashButton FB_Close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TB_R_Pts;
        private System.Windows.Forms.TextBox TB_V_Pts;
        private FlashButton.FlashButton FB_Fiche_Resultat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LB_No_Match;
    }
}
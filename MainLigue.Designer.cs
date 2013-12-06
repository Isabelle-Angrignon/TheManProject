namespace The_Main_Project
{
    partial class Form_League
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.DGV_Team = new System.Windows.Forms.DataGridView();
            this.MS_Main = new System.Windows.Forms.MenuStrip();
            this.TSMI_Gestion = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Division = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Equipe = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Joueur = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Match = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Resultats = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Stats = new System.Windows.Forms.ToolStripMenuItem();
            this.divisonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.équipeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Stats_Joueur = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Affichage = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Themes = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Aide = new System.Windows.Forms.ToolStripMenuItem();
            this.aideToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_A_Propos = new System.Windows.Forms.ToolStripMenuItem();
            this.DGV_Match = new System.Windows.Forms.DataGridView();
            this.CBX_Division = new System.Windows.Forms.ComboBox();
            this.CMS_Match = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CMS_Match_Afficher = new System.Windows.Forms.ToolStripMenuItem();
            this.CMS_Match_Modifier = new System.Windows.Forms.ToolStripMenuItem();
            this.CMS_Match_Supprimer = new System.Windows.Forms.ToolStripMenuItem();
            this.CMS_Team = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CMS_Team_Afficher = new System.Windows.Forms.ToolStripMenuItem();
            this.CMS_Team_Modifier = new System.Windows.Forms.ToolStripMenuItem();
            this.CMS_Team_Supprimer = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.FB_Result = new FlashButton.FlashButton();
            this.FB_Match = new FlashButton.FlashButton();
            this.flashButton2 = new FlashButton.FlashButton();
            this.FB_Joueur = new FlashButton.FlashButton();
            this.FLB_Team = new FlashButton.FlashButton();
            this.FLB_Division = new FlashButton.FlashButton();
            this.PBX_Logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Team)).BeginInit();
            this.MS_Main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Match)).BeginInit();
            this.CMS_Match.SuspendLayout();
            this.CMS_Team.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBX_Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_Team
            // 
            this.DGV_Team.AllowUserToAddRows = false;
            this.DGV_Team.AllowUserToDeleteRows = false;
            this.DGV_Team.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Team.Location = new System.Drawing.Point(582, 146);
            this.DGV_Team.Name = "DGV_Team";
            this.DGV_Team.RowHeadersVisible = false;
            this.DGV_Team.Size = new System.Drawing.Size(421, 270);
            this.DGV_Team.TabIndex = 1;
            // 
            // MS_Main
            // 
            this.MS_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_Gestion,
            this.TSMI_Stats,
            this.TSMI_Affichage,
            this.TSMI_Aide});
            this.MS_Main.Location = new System.Drawing.Point(0, 0);
            this.MS_Main.Name = "MS_Main";
            this.MS_Main.Size = new System.Drawing.Size(1015, 24);
            this.MS_Main.TabIndex = 4;
            this.MS_Main.Text = "menuStrip1";
            // 
            // TSMI_Gestion
            // 
            this.TSMI_Gestion.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_Division,
            this.TSMI_Equipe,
            this.TSMI_Joueur,
            this.TSMI_Match,
            this.TSMI_Resultats});
            this.TSMI_Gestion.Name = "TSMI_Gestion";
            this.TSMI_Gestion.Size = new System.Drawing.Size(59, 20);
            this.TSMI_Gestion.Text = "Gestion";
            // 
            // TSMI_Division
            // 
            this.TSMI_Division.Name = "TSMI_Division";
            this.TSMI_Division.Size = new System.Drawing.Size(152, 22);
            this.TSMI_Division.Text = "Division...";
            this.TSMI_Division.Click += new System.EventHandler(this.TSMI_Division_Click);
            // 
            // TSMI_Equipe
            // 
            this.TSMI_Equipe.Name = "TSMI_Equipe";
            this.TSMI_Equipe.Size = new System.Drawing.Size(152, 22);
            this.TSMI_Equipe.Text = "Équipe...";
            this.TSMI_Equipe.Click += new System.EventHandler(this.TSMI_Equipe_Click);
            // 
            // TSMI_Joueur
            // 
            this.TSMI_Joueur.Name = "TSMI_Joueur";
            this.TSMI_Joueur.Size = new System.Drawing.Size(152, 22);
            this.TSMI_Joueur.Text = "Joueur...";
            this.TSMI_Joueur.Click += new System.EventHandler(this.TSMI_Joueur_Click);
            // 
            // TSMI_Match
            // 
            this.TSMI_Match.Name = "TSMI_Match";
            this.TSMI_Match.Size = new System.Drawing.Size(152, 22);
            this.TSMI_Match.Text = "Match ...";
            this.TSMI_Match.Click += new System.EventHandler(this.TSMI_Match_Click);
            // 
            // TSMI_Resultats
            // 
            this.TSMI_Resultats.Name = "TSMI_Resultats";
            this.TSMI_Resultats.Size = new System.Drawing.Size(152, 22);
            this.TSMI_Resultats.Text = "Résultat...";
            this.TSMI_Resultats.Click += new System.EventHandler(this.TSMI_Resultats_Click);
            // 
            // TSMI_Stats
            // 
            this.TSMI_Stats.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.divisonToolStripMenuItem,
            this.équipeToolStripMenuItem1,
            this.TSMI_Stats_Joueur});
            this.TSMI_Stats.Name = "TSMI_Stats";
            this.TSMI_Stats.Size = new System.Drawing.Size(44, 20);
            this.TSMI_Stats.Text = "Stats";
            // 
            // divisonToolStripMenuItem
            // 
            this.divisonToolStripMenuItem.Enabled = false;
            this.divisonToolStripMenuItem.Name = "divisonToolStripMenuItem";
            this.divisonToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.divisonToolStripMenuItem.Text = "Divison...";
            // 
            // équipeToolStripMenuItem1
            // 
            this.équipeToolStripMenuItem1.Enabled = false;
            this.équipeToolStripMenuItem1.Name = "équipeToolStripMenuItem1";
            this.équipeToolStripMenuItem1.Size = new System.Drawing.Size(122, 22);
            this.équipeToolStripMenuItem1.Text = "Équipe...";
            // 
            // TSMI_Stats_Joueur
            // 
            this.TSMI_Stats_Joueur.Name = "TSMI_Stats_Joueur";
            this.TSMI_Stats_Joueur.Size = new System.Drawing.Size(152, 22);
            this.TSMI_Stats_Joueur.Text = "Joueur...";
            this.TSMI_Stats_Joueur.Click += new System.EventHandler(this.TSMI_Stats_Joueur_Click);
            // 
            // TSMI_Affichage
            // 
            this.TSMI_Affichage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_Themes});
            this.TSMI_Affichage.Name = "TSMI_Affichage";
            this.TSMI_Affichage.Size = new System.Drawing.Size(70, 20);
            this.TSMI_Affichage.Text = "Affichage";
            // 
            // TSMI_Themes
            // 
            this.TSMI_Themes.Name = "TSMI_Themes";
            this.TSMI_Themes.Size = new System.Drawing.Size(152, 22);
            this.TSMI_Themes.Text = "Thèmes...";
            this.TSMI_Themes.Click += new System.EventHandler(this.TSMI_Themes_Click);
            // 
            // TSMI_Aide
            // 
            this.TSMI_Aide.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aideToolStripMenuItem1,
            this.TSMI_A_Propos});
            this.TSMI_Aide.Name = "TSMI_Aide";
            this.TSMI_Aide.Size = new System.Drawing.Size(24, 20);
            this.TSMI_Aide.Text = "?";
            // 
            // aideToolStripMenuItem1
            // 
            this.aideToolStripMenuItem1.Enabled = false;
            this.aideToolStripMenuItem1.Name = "aideToolStripMenuItem1";
            this.aideToolStripMenuItem1.Size = new System.Drawing.Size(131, 22);
            this.aideToolStripMenuItem1.Text = "Aide...";
            // 
            // TSMI_A_Propos
            // 
            this.TSMI_A_Propos.Name = "TSMI_A_Propos";
            this.TSMI_A_Propos.Size = new System.Drawing.Size(131, 22);
            this.TSMI_A_Propos.Text = "A Propos...";
            // 
            // DGV_Match
            // 
            this.DGV_Match.AllowUserToAddRows = false;
            this.DGV_Match.AllowUserToDeleteRows = false;
            this.DGV_Match.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Match.Location = new System.Drawing.Point(29, 146);
            this.DGV_Match.Name = "DGV_Match";
            this.DGV_Match.RowHeadersVisible = false;
            this.DGV_Match.Size = new System.Drawing.Size(421, 270);
            this.DGV_Match.TabIndex = 7;
            // 
            // CBX_Division
            // 
            this.CBX_Division.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CBX_Division.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBX_Division.FormattingEnabled = true;
            this.CBX_Division.Location = new System.Drawing.Point(684, 119);
            this.CBX_Division.Name = "CBX_Division";
            this.CBX_Division.Size = new System.Drawing.Size(225, 21);
            this.CBX_Division.TabIndex = 8;
            // 
            // CMS_Match
            // 
            this.CMS_Match.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CMS_Match_Afficher,
            this.CMS_Match_Modifier,
            this.CMS_Match_Supprimer});
            this.CMS_Match.Name = "CMS_Match";
            this.CMS_Match.Size = new System.Drawing.Size(130, 70);
            // 
            // CMS_Match_Afficher
            // 
            this.CMS_Match_Afficher.Name = "CMS_Match_Afficher";
            this.CMS_Match_Afficher.Size = new System.Drawing.Size(129, 22);
            this.CMS_Match_Afficher.Text = "Afficher...";
            // 
            // CMS_Match_Modifier
            // 
            this.CMS_Match_Modifier.Name = "CMS_Match_Modifier";
            this.CMS_Match_Modifier.Size = new System.Drawing.Size(129, 22);
            this.CMS_Match_Modifier.Text = "Modifier...";
            // 
            // CMS_Match_Supprimer
            // 
            this.CMS_Match_Supprimer.Name = "CMS_Match_Supprimer";
            this.CMS_Match_Supprimer.Size = new System.Drawing.Size(129, 22);
            this.CMS_Match_Supprimer.Text = "Supprimer";
            // 
            // CMS_Team
            // 
            this.CMS_Team.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CMS_Team_Afficher,
            this.CMS_Team_Modifier,
            this.CMS_Team_Supprimer});
            this.CMS_Team.Name = "CMS_Match";
            this.CMS_Team.Size = new System.Drawing.Size(130, 70);
            // 
            // CMS_Team_Afficher
            // 
            this.CMS_Team_Afficher.Name = "CMS_Team_Afficher";
            this.CMS_Team_Afficher.Size = new System.Drawing.Size(129, 22);
            this.CMS_Team_Afficher.Text = "Afficher...";
            // 
            // CMS_Team_Modifier
            // 
            this.CMS_Team_Modifier.Name = "CMS_Team_Modifier";
            this.CMS_Team_Modifier.Size = new System.Drawing.Size(129, 22);
            this.CMS_Team_Modifier.Text = "Modifier...";
            // 
            // CMS_Team_Supprimer
            // 
            this.CMS_Team_Supprimer.Name = "CMS_Team_Supprimer";
            this.CMS_Team_Supprimer.Size = new System.Drawing.Size(129, 22);
            this.CMS_Team_Supprimer.Text = "Supprimer";
            // 
            // FB_Result
            // 
            this.FB_Result.BackgroundImage = global::The_Main_Project.Properties.Resources.FB_Resultat;
            this.FB_Result.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FB_Result.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FB_Result.ImageClick = global::The_Main_Project.Properties.Resources.FB_Resultat_Click;
            this.FB_Result.ImageDisable = global::The_Main_Project.Properties.Resources.FB_Resultat_Disable;
            this.FB_Result.ImageNeutral = global::The_Main_Project.Properties.Resources.FB_Resultat;
            this.FB_Result.ImageOver = global::The_Main_Project.Properties.Resources.FB_Resultat_Hover;
            this.FB_Result.Location = new System.Drawing.Point(471, 44);
            this.FB_Result.Name = "FB_Result";
            this.FB_Result.Size = new System.Drawing.Size(60, 45);
            this.FB_Result.TabIndex = 24;
            this.FB_Result.Click += new System.EventHandler(this.flashButton4_Click);
            // 
            // FB_Match
            // 
            this.FB_Match.BackgroundImage = global::The_Main_Project.Properties.Resources.FB_Match;
            this.FB_Match.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FB_Match.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FB_Match.ImageClick = global::The_Main_Project.Properties.Resources.FB_Match_Click;
            this.FB_Match.ImageDisable = global::The_Main_Project.Properties.Resources.FB_Match_Disable;
            this.FB_Match.ImageNeutral = global::The_Main_Project.Properties.Resources.FB_Match;
            this.FB_Match.ImageOver = global::The_Main_Project.Properties.Resources.FB_Match_Hover;
            this.FB_Match.Location = new System.Drawing.Point(405, 43);
            this.FB_Match.Name = "FB_Match";
            this.FB_Match.Size = new System.Drawing.Size(60, 45);
            this.FB_Match.TabIndex = 23;
            this.FB_Match.Click += new System.EventHandler(this.flashButton3_Click);
            // 
            // flashButton2
            // 
            this.flashButton2.BackgroundImage = global::The_Main_Project.Properties.Resources.FB_Top_5;
            this.flashButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.flashButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flashButton2.ImageClick = global::The_Main_Project.Properties.Resources.FB_Top_5_Click;
            this.flashButton2.ImageDisable = global::The_Main_Project.Properties.Resources.FB_Top_5_Disable;
            this.flashButton2.ImageNeutral = global::The_Main_Project.Properties.Resources.FB_Top_5;
            this.flashButton2.ImageOver = global::The_Main_Project.Properties.Resources.FB_Top_5_hover;
            this.flashButton2.Location = new System.Drawing.Point(277, 44);
            this.flashButton2.Name = "flashButton2";
            this.flashButton2.Size = new System.Drawing.Size(45, 45);
            this.flashButton2.TabIndex = 22;
            this.flashButton2.Click += new System.EventHandler(this.flashButton2_Click);
            // 
            // FB_Joueur
            // 
            this.FB_Joueur.BackgroundImage = global::The_Main_Project.Properties.Resources.FB_Player;
            this.FB_Joueur.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FB_Joueur.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FB_Joueur.ImageClick = global::The_Main_Project.Properties.Resources.FB_Player_Click;
            this.FB_Joueur.ImageDisable = global::The_Main_Project.Properties.Resources.FB_Player_Disable;
            this.FB_Joueur.ImageNeutral = global::The_Main_Project.Properties.Resources.FB_Player;
            this.FB_Joueur.ImageOver = global::The_Main_Project.Properties.Resources.FB_Player_Hover;
            this.FB_Joueur.Location = new System.Drawing.Point(220, 44);
            this.FB_Joueur.Name = "FB_Joueur";
            this.FB_Joueur.Size = new System.Drawing.Size(45, 45);
            this.FB_Joueur.TabIndex = 21;
            this.FB_Joueur.Click += new System.EventHandler(this.flashButton1_Click);
            // 
            // FLB_Team
            // 
            this.FLB_Team.BackgroundImage = global::The_Main_Project.Properties.Resources.FB_Team;
            this.FLB_Team.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FLB_Team.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FLB_Team.ImageClick = global::The_Main_Project.Properties.Resources.FB_Team_Click;
            this.FLB_Team.ImageDisable = global::The_Main_Project.Properties.Resources.FB_Team_Disable;
            this.FLB_Team.ImageNeutral = global::The_Main_Project.Properties.Resources.FB_Team;
            this.FLB_Team.ImageOver = global::The_Main_Project.Properties.Resources.FB_Team_Hover;
            this.FLB_Team.Location = new System.Drawing.Point(88, 43);
            this.FLB_Team.Name = "FLB_Team";
            this.FLB_Team.Size = new System.Drawing.Size(60, 45);
            this.FLB_Team.TabIndex = 20;
            this.FLB_Team.Click += new System.EventHandler(this.FLB_Team_Click);
            // 
            // FLB_Division
            // 
            this.FLB_Division.BackgroundImage = global::The_Main_Project.Properties.Resources.Division_FB;
            this.FLB_Division.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FLB_Division.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FLB_Division.ImageClick = global::The_Main_Project.Properties.Resources.Division_FB_Click;
            this.FLB_Division.ImageDisable = global::The_Main_Project.Properties.Resources.Division_FB_Disable;
            this.FLB_Division.ImageNeutral = global::The_Main_Project.Properties.Resources.Division_FB;
            this.FLB_Division.ImageOver = global::The_Main_Project.Properties.Resources.Division_FB_Hover;
            this.FLB_Division.Location = new System.Drawing.Point(22, 44);
            this.FLB_Division.Name = "FLB_Division";
            this.FLB_Division.Size = new System.Drawing.Size(60, 45);
            this.FLB_Division.TabIndex = 19;
            this.FLB_Division.Click += new System.EventHandler(this.FLB_Division_Click);
            // 
            // PBX_Logo
            // 
            this.PBX_Logo.Location = new System.Drawing.Point(503, 146);
            this.PBX_Logo.Name = "PBX_Logo";
            this.PBX_Logo.Size = new System.Drawing.Size(73, 56);
            this.PBX_Logo.TabIndex = 6;
            this.PBX_Logo.TabStop = false;
            // 
            // Form_League
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 428);
            this.Controls.Add(this.FB_Result);
            this.Controls.Add(this.FB_Match);
            this.Controls.Add(this.flashButton2);
            this.Controls.Add(this.FB_Joueur);
            this.Controls.Add(this.FLB_Team);
            this.Controls.Add(this.FLB_Division);
            this.Controls.Add(this.CBX_Division);
            this.Controls.Add(this.DGV_Match);
            this.Controls.Add(this.PBX_Logo);
            this.Controls.Add(this.DGV_Team);
            this.Controls.Add(this.MS_Main);
            this.MainMenuStrip = this.MS_Main;
            this.Name = "Form_League";
            this.Text = "Bienvenue dans la ligue ";
            this.Load += new System.EventHandler(this.Form_League_Load);
            this.SizeChanged += new System.EventHandler(this.Form_League_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Team)).EndInit();
            this.MS_Main.ResumeLayout(false);
            this.MS_Main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Match)).EndInit();
            this.CMS_Match.ResumeLayout(false);
            this.CMS_Team.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PBX_Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_Team;
        private System.Windows.Forms.MenuStrip MS_Main;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Gestion;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Division;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Equipe;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Joueur;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Match;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Resultats;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Stats;
        private System.Windows.Forms.ToolStripMenuItem divisonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem équipeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Stats_Joueur;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Affichage;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Themes;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Aide;
        private System.Windows.Forms.ToolStripMenuItem TSMI_A_Propos;
        private System.Windows.Forms.PictureBox PBX_Logo;
        private System.Windows.Forms.DataGridView DGV_Match;
        private System.Windows.Forms.ComboBox CBX_Division;
        private System.Windows.Forms.ToolStripMenuItem aideToolStripMenuItem1;
        private System.Windows.Forms.ContextMenuStrip CMS_Match;
        private System.Windows.Forms.ToolStripMenuItem CMS_Match_Afficher;
        private System.Windows.Forms.ToolStripMenuItem CMS_Match_Modifier;
        private System.Windows.Forms.ToolStripMenuItem CMS_Match_Supprimer;
        private System.Windows.Forms.ContextMenuStrip CMS_Team;
        private System.Windows.Forms.ToolStripMenuItem CMS_Team_Afficher;
        private System.Windows.Forms.ToolStripMenuItem CMS_Team_Modifier;
        private System.Windows.Forms.ToolStripMenuItem CMS_Team_Supprimer;
        private FlashButton.FlashButton FLB_Division;
        private FlashButton.FlashButton FLB_Team;
        private FlashButton.FlashButton FB_Joueur;
        private FlashButton.FlashButton flashButton2;
        private FlashButton.FlashButton FB_Match;
        private FlashButton.FlashButton FB_Result;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;

    }
}


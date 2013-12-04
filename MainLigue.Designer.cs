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
            this.PBX_Logo = new System.Windows.Forms.PictureBox();
            this.DGV_Match = new System.Windows.Forms.DataGridView();
            this.CBX_Division = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.CMS_Match = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CMS_Match_Afficher = new System.Windows.Forms.ToolStripMenuItem();
            this.CMS_Match_Modifier = new System.Windows.Forms.ToolStripMenuItem();
            this.CMS_Match_Supprimer = new System.Windows.Forms.ToolStripMenuItem();
            this.CMS_Team = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CMS_Team_Afficher = new System.Windows.Forms.ToolStripMenuItem();
            this.CMS_Team_Modifier = new System.Windows.Forms.ToolStripMenuItem();
            this.CMS_Team_Supprimer = new System.Windows.Forms.ToolStripMenuItem();
            this.FLB_Division = new FlashButton.FlashButton();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Team)).BeginInit();
            this.MS_Main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBX_Logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Match)).BeginInit();
            this.CMS_Match.SuspendLayout();
            this.CMS_Team.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGV_Team
            // 
            this.DGV_Team.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Team.Location = new System.Drawing.Point(582, 146);
            this.DGV_Team.Name = "DGV_Team";
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
            // 
            // TSMI_Equipe
            // 
            this.TSMI_Equipe.Name = "TSMI_Equipe";
            this.TSMI_Equipe.Size = new System.Drawing.Size(152, 22);
            this.TSMI_Equipe.Text = "Équipe...";
            // 
            // TSMI_Joueur
            // 
            this.TSMI_Joueur.Name = "TSMI_Joueur";
            this.TSMI_Joueur.Size = new System.Drawing.Size(152, 22);
            this.TSMI_Joueur.Text = "Joueur...";
            // 
            // TSMI_Match
            // 
            this.TSMI_Match.Name = "TSMI_Match";
            this.TSMI_Match.Size = new System.Drawing.Size(152, 22);
            this.TSMI_Match.Text = "Match ...";
            // 
            // TSMI_Resultats
            // 
            this.TSMI_Resultats.Name = "TSMI_Resultats";
            this.TSMI_Resultats.Size = new System.Drawing.Size(152, 22);
            this.TSMI_Resultats.Text = "Résultat...";
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
            this.divisonToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.divisonToolStripMenuItem.Text = "Divison...";
            // 
            // équipeToolStripMenuItem1
            // 
            this.équipeToolStripMenuItem1.Enabled = false;
            this.équipeToolStripMenuItem1.Name = "équipeToolStripMenuItem1";
            this.équipeToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.équipeToolStripMenuItem1.Text = "Équipe...";
            // 
            // TSMI_Stats_Joueur
            // 
            this.TSMI_Stats_Joueur.Name = "TSMI_Stats_Joueur";
            this.TSMI_Stats_Joueur.Size = new System.Drawing.Size(152, 22);
            this.TSMI_Stats_Joueur.Text = "Joueur...";
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
            this.TSMI_Themes.Size = new System.Drawing.Size(125, 22);
            this.TSMI_Themes.Text = "Thèmes...";
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
            // PBX_Logo
            // 
            this.PBX_Logo.Location = new System.Drawing.Point(503, 146);
            this.PBX_Logo.Name = "PBX_Logo";
            this.PBX_Logo.Size = new System.Drawing.Size(73, 56);
            this.PBX_Logo.TabIndex = 6;
            this.PBX_Logo.TabStop = false;
            // 
            // DGV_Match
            // 
            this.DGV_Match.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Match.Location = new System.Drawing.Point(29, 146);
            this.DGV_Match.Name = "DGV_Match";
            this.DGV_Match.Size = new System.Drawing.Size(421, 270);
            this.DGV_Match.TabIndex = 7;
            // 
            // CBX_Division
            // 
            this.CBX_Division.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CBX_Division.FormattingEnabled = true;
            this.CBX_Division.Location = new System.Drawing.Point(684, 119);
            this.CBX_Division.Name = "CBX_Division";
            this.CBX_Division.Size = new System.Drawing.Size(225, 21);
            this.CBX_Division.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(286, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 45);
            this.button1.TabIndex = 10;
            this.button1.Text = "Top 5";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(88, 44);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(60, 45);
            this.button2.TabIndex = 11;
            this.button2.Text = "Equipe";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(405, 43);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(60, 45);
            this.button3.TabIndex = 12;
            this.button3.Text = "Match";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(220, 44);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(60, 45);
            this.button5.TabIndex = 13;
            this.button5.Text = "Joueur";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(22, 43);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(60, 45);
            this.button6.TabIndex = 14;
            this.button6.Text = "Division";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(471, 44);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(60, 45);
            this.button7.TabIndex = 15;
            this.button7.Text = "Résultat";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
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
            // FLB_Division
            // 
            this.FLB_Division.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FLB_Division.ImageClick = null;
            this.FLB_Division.ImageDisable = null;
            this.FLB_Division.ImageNeutral = null;
            this.FLB_Division.ImageOver = null;
            this.FLB_Division.Location = new System.Drawing.Point(12, 58);
            this.FLB_Division.Name = "FLB_Division";
            this.FLB_Division.Size = new System.Drawing.Size(60, 45);
            this.FLB_Division.TabIndex = 18;
            // 
            // Form_League
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 428);
            this.Controls.Add(this.FLB_Division);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CBX_Division);
            this.Controls.Add(this.DGV_Match);
            this.Controls.Add(this.PBX_Logo);
            this.Controls.Add(this.DGV_Team);
            this.Controls.Add(this.MS_Main);
            this.MainMenuStrip = this.MS_Main;
            this.Name = "Form_League";
            this.Text = "Bienvenue dans la ligue ";
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Team)).EndInit();
            this.MS_Main.ResumeLayout(false);
            this.MS_Main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBX_Logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Match)).EndInit();
            this.CMS_Match.ResumeLayout(false);
            this.CMS_Team.ResumeLayout(false);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
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

    }
}


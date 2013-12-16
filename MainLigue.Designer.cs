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
            this.CMS_Team = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CMS_Team_Afficher = new System.Windows.Forms.ToolStripMenuItem();
            this.afficherJoueursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.FB_Match = new FlashButton.FlashButton();
            this.FB_Top5 = new FlashButton.FlashButton();
            this.FB_Joueur = new FlashButton.FlashButton();
            this.FLB_Team = new FlashButton.FlashButton();
            this.FLB_Division = new FlashButton.FlashButton();
            this.PBX_Logo = new System.Windows.Forms.PictureBox();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.FB_Close = new FlashButton.FlashButton();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Team)).BeginInit();
            this.MS_Main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Match)).BeginInit();
            this.CMS_Match.SuspendLayout();
            this.CMS_Team.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBX_Logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_Team
            // 
            this.DGV_Team.AllowUserToAddRows = false;
            this.DGV_Team.AllowUserToDeleteRows = false;
            this.DGV_Team.AllowUserToResizeColumns = false;
            this.DGV_Team.AllowUserToResizeRows = false;
            this.DGV_Team.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGV_Team.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DGV_Team.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGV_Team.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Team.Location = new System.Drawing.Point(639, 146);
            this.DGV_Team.MultiSelect = false;
            this.DGV_Team.Name = "DGV_Team";
            this.DGV_Team.ReadOnly = true;
            this.DGV_Team.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DGV_Team.RowHeadersVisible = false;
            this.DGV_Team.Size = new System.Drawing.Size(191, 213);
            this.DGV_Team.TabIndex = 1;
            this.DGV_Team.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Team_CellContentClick);
            this.DGV_Team.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DGV_Team_CellMouseUp);
            this.DGV_Team.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DGV_Team_ColumnHeaderMouseClick);
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
            this.MS_Main.Size = new System.Drawing.Size(842, 24);
            this.MS_Main.TabIndex = 4;
            this.MS_Main.Text = "menuStrip1";
            // 
            // TSMI_Gestion
            // 
            this.TSMI_Gestion.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_Division,
            this.TSMI_Equipe,
            this.TSMI_Joueur,
            this.TSMI_Match});
            this.TSMI_Gestion.Name = "TSMI_Gestion";
            this.TSMI_Gestion.Size = new System.Drawing.Size(59, 20);
            this.TSMI_Gestion.Text = "Gestion";
            // 
            // TSMI_Division
            // 
            this.TSMI_Division.Name = "TSMI_Division";
            this.TSMI_Division.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.TSMI_Division.Size = new System.Drawing.Size(172, 22);
            this.TSMI_Division.Text = "Divisions...";
            this.TSMI_Division.Click += new System.EventHandler(this.TSMI_Division_Click);
            // 
            // TSMI_Equipe
            // 
            this.TSMI_Equipe.Name = "TSMI_Equipe";
            this.TSMI_Equipe.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.TSMI_Equipe.Size = new System.Drawing.Size(172, 22);
            this.TSMI_Equipe.Text = "Équipes...";
            this.TSMI_Equipe.Click += new System.EventHandler(this.TSMI_Equipe_Click);
            // 
            // TSMI_Joueur
            // 
            this.TSMI_Joueur.Name = "TSMI_Joueur";
            this.TSMI_Joueur.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.J)));
            this.TSMI_Joueur.Size = new System.Drawing.Size(172, 22);
            this.TSMI_Joueur.Text = "Joueurs...";
            this.TSMI_Joueur.Click += new System.EventHandler(this.TSMI_Joueur_Click);
            // 
            // TSMI_Match
            // 
            this.TSMI_Match.Name = "TSMI_Match";
            this.TSMI_Match.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.TSMI_Match.Size = new System.Drawing.Size(172, 22);
            this.TSMI_Match.Text = "Matchs...";
            this.TSMI_Match.Click += new System.EventHandler(this.TSMI_Match_Click);
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
            this.divisonToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.divisonToolStripMenuItem.Text = "Divison...";
            // 
            // équipeToolStripMenuItem1
            // 
            this.équipeToolStripMenuItem1.Enabled = false;
            this.équipeToolStripMenuItem1.Name = "équipeToolStripMenuItem1";
            this.équipeToolStripMenuItem1.Size = new System.Drawing.Size(123, 22);
            this.équipeToolStripMenuItem1.Text = "Équipe...";
            // 
            // TSMI_Stats_Joueur
            // 
            this.TSMI_Stats_Joueur.Name = "TSMI_Stats_Joueur";
            this.TSMI_Stats_Joueur.Size = new System.Drawing.Size(123, 22);
            this.TSMI_Stats_Joueur.Text = "Joueurs...";
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
            this.TSMI_Themes.Size = new System.Drawing.Size(125, 22);
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
            this.TSMI_A_Propos.Text = "À propos...";
            this.TSMI_A_Propos.Click += new System.EventHandler(this.TSMI_A_Propos_Click);
            // 
            // DGV_Match
            // 
            this.DGV_Match.AllowUserToAddRows = false;
            this.DGV_Match.AllowUserToDeleteRows = false;
            this.DGV_Match.AllowUserToResizeColumns = false;
            this.DGV_Match.AllowUserToResizeRows = false;
            this.DGV_Match.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.DGV_Match.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DGV_Match.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGV_Match.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Match.Location = new System.Drawing.Point(12, 146);
            this.DGV_Match.Name = "DGV_Match";
            this.DGV_Match.ReadOnly = true;
            this.DGV_Match.RowHeadersVisible = false;
            this.DGV_Match.Size = new System.Drawing.Size(482, 213);
            this.DGV_Match.TabIndex = 7;
            this.DGV_Match.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DGV_Match_CellMouseUp);
            this.DGV_Match.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DGV_Match_ColumnHeaderMouseClick);
            // 
            // CBX_Division
            // 
            this.CBX_Division.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CBX_Division.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CBX_Division.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBX_Division.FormattingEnabled = true;
            this.CBX_Division.Location = new System.Drawing.Point(639, 119);
            this.CBX_Division.Name = "CBX_Division";
            this.CBX_Division.Size = new System.Drawing.Size(191, 21);
            this.CBX_Division.TabIndex = 8;
            this.CBX_Division.SelectedIndexChanged += new System.EventHandler(this.CBX_Division_SelectedIndexChanged);
            // 
            // CMS_Match
            // 
            this.CMS_Match.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CMS_Match_Afficher,
            this.CMS_Match_Modifier});
            this.CMS_Match.Name = "CMS_Match";
            this.CMS_Match.Size = new System.Drawing.Size(215, 48);
            // 
            // CMS_Match_Afficher
            // 
            this.CMS_Match_Afficher.Name = "CMS_Match_Afficher";
            this.CMS_Match_Afficher.Size = new System.Drawing.Size(214, 22);
            this.CMS_Match_Afficher.Text = "Gérer ce match...";
            this.CMS_Match_Afficher.Click += new System.EventHandler(this.CMS_Match_Afficher_Click);
            // 
            // CMS_Match_Modifier
            // 
            this.CMS_Match_Modifier.Name = "CMS_Match_Modifier";
            this.CMS_Match_Modifier.Size = new System.Drawing.Size(214, 22);
            this.CMS_Match_Modifier.Text = "Gérer ses résultats match...";
            this.CMS_Match_Modifier.Click += new System.EventHandler(this.CMS_Match_Modifier_Click);
            // 
            // CMS_Team
            // 
            this.CMS_Team.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CMS_Team_Afficher,
            this.afficherJoueursToolStripMenuItem});
            this.CMS_Team.Name = "CMS_Match";
            this.CMS_Team.Size = new System.Drawing.Size(180, 48);
            // 
            // CMS_Team_Afficher
            // 
            this.CMS_Team_Afficher.Name = "CMS_Team_Afficher";
            this.CMS_Team_Afficher.Size = new System.Drawing.Size(179, 22);
            this.CMS_Team_Afficher.Text = "Gérer cette équipe...";
            this.CMS_Team_Afficher.Click += new System.EventHandler(this.CMS_Team_Afficher_Click);
            // 
            // afficherJoueursToolStripMenuItem
            // 
            this.afficherJoueursToolStripMenuItem.Name = "afficherJoueursToolStripMenuItem";
            this.afficherJoueursToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.afficherJoueursToolStripMenuItem.Text = "Gérer ses joueurs ...";
            this.afficherJoueursToolStripMenuItem.Click += new System.EventHandler(this.afficherJoueursToolStripMenuItem_Click);
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
            // FB_Top5
            // 
            this.FB_Top5.BackgroundImage = global::The_Main_Project.Properties.Resources.FB_Top_5;
            this.FB_Top5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FB_Top5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FB_Top5.ImageClick = global::The_Main_Project.Properties.Resources.FB_Top_5_Click;
            this.FB_Top5.ImageDisable = global::The_Main_Project.Properties.Resources.FB_Top_5_Disable;
            this.FB_Top5.ImageNeutral = global::The_Main_Project.Properties.Resources.FB_Top_5;
            this.FB_Top5.ImageOver = global::The_Main_Project.Properties.Resources.FB_Top_5_hover;
            this.FB_Top5.Location = new System.Drawing.Point(277, 44);
            this.FB_Top5.Name = "FB_Top5";
            this.FB_Top5.Size = new System.Drawing.Size(45, 45);
            this.FB_Top5.TabIndex = 22;
            this.FB_Top5.Click += new System.EventHandler(this.FB_Top5_Click);
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
            this.PBX_Logo.Location = new System.Drawing.Point(558, 146);
            this.PBX_Logo.Name = "PBX_Logo";
            this.PBX_Logo.Size = new System.Drawing.Size(75, 75);
            this.PBX_Logo.TabIndex = 6;
            this.PBX_Logo.TabStop = false;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // FB_Close
            // 
            this.FB_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FB_Close.BackgroundImage = global::The_Main_Project.Properties.Resources.Porte;
            this.FB_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FB_Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FB_Close.ImageClick = global::The_Main_Project.Properties.Resources.PorteCLic;
            this.FB_Close.ImageDisable = null;
            this.FB_Close.ImageNeutral = global::The_Main_Project.Properties.Resources.Porte;
            this.FB_Close.ImageOver = global::The_Main_Project.Properties.Resources.PorteOver;
            this.FB_Close.Location = new System.Drawing.Point(790, 44);
            this.FB_Close.Name = "FB_Close";
            this.FB_Close.Size = new System.Drawing.Size(40, 46);
            this.FB_Close.TabIndex = 40;
            this.FB_Close.Click += new System.EventHandler(this.FB_Close_Click);
            // 
            // Form_League
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 371);
            this.Controls.Add(this.FB_Close);
            this.Controls.Add(this.FB_Match);
            this.Controls.Add(this.FB_Top5);
            this.Controls.Add(this.FB_Joueur);
            this.Controls.Add(this.FLB_Team);
            this.Controls.Add(this.FLB_Division);
            this.Controls.Add(this.CBX_Division);
            this.Controls.Add(this.DGV_Match);
            this.Controls.Add(this.PBX_Logo);
            this.Controls.Add(this.DGV_Team);
            this.Controls.Add(this.MS_Main);
            this.MainMenuStrip = this.MS_Main;
            this.MinimumSize = new System.Drawing.Size(800, 300);
            this.Name = "Form_League";
            this.Text = "Bienvenue dans la ligue ";
            this.Load += new System.EventHandler(this.Form_League_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Team)).EndInit();
            this.MS_Main.ResumeLayout(false);
            this.MS_Main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Match)).EndInit();
            this.CMS_Match.ResumeLayout(false);
            this.CMS_Team.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PBX_Logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
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
        private System.Windows.Forms.ContextMenuStrip CMS_Team;
        private System.Windows.Forms.ToolStripMenuItem CMS_Team_Afficher;
        private FlashButton.FlashButton FLB_Division;
        private FlashButton.FlashButton FLB_Team;
        private FlashButton.FlashButton FB_Joueur;
        private FlashButton.FlashButton FB_Top5;
        private FlashButton.FlashButton FB_Match;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private FlashButton.FlashButton FB_Close;
        private System.Windows.Forms.ToolStripMenuItem afficherJoueursToolStripMenuItem;

    }
}


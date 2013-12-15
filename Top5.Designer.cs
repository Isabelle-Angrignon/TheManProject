namespace The_Main_Project
{
    partial class Top5
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
            this.components = new System.ComponentModel.Container();
            this.LB_Top5 = new System.Windows.Forms.Label();
            this.DGV_Top5 = new System.Windows.Forms.DataGridView();
            this.FB_Close = new FlashButton.FlashButton();
            this.CMS = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.gestionJoueurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afficherStatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Top5)).BeginInit();
            this.CMS.SuspendLayout();
            this.SuspendLayout();
            // 
            // LB_Top5
            // 
            this.LB_Top5.AutoSize = true;
            this.LB_Top5.Location = new System.Drawing.Point(12, 9);
            this.LB_Top5.Name = "LB_Top5";
            this.LB_Top5.Size = new System.Drawing.Size(148, 13);
            this.LB_Top5.TabIndex = 4;
            this.LB_Top5.Text = "Les 5 meilleurs joueurs sont ...";
            // 
            // DGV_Top5
            // 
            this.DGV_Top5.AllowUserToAddRows = false;
            this.DGV_Top5.AllowUserToDeleteRows = false;
            this.DGV_Top5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGV_Top5.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DGV_Top5.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGV_Top5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Top5.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.DGV_Top5.Location = new System.Drawing.Point(15, 25);
            this.DGV_Top5.MultiSelect = false;
            this.DGV_Top5.Name = "DGV_Top5";
            this.DGV_Top5.ReadOnly = true;
            this.DGV_Top5.RowHeadersVisible = false;
            this.DGV_Top5.Size = new System.Drawing.Size(531, 164);
            this.DGV_Top5.TabIndex = 5;
            this.DGV_Top5.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DGV_Top5_CellMouseUp);
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
            this.FB_Close.Location = new System.Drawing.Point(491, 195);
            this.FB_Close.Name = "FB_Close";
            this.FB_Close.Size = new System.Drawing.Size(55, 62);
            this.FB_Close.TabIndex = 26;
            this.FB_Close.Click += new System.EventHandler(this.FB_Close_Click);
            // 
            // CMS
            // 
            this.CMS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionJoueurToolStripMenuItem,
            this.afficherStatToolStripMenuItem});
            this.CMS.Name = "CMS";
            this.CMS.Size = new System.Drawing.Size(180, 48);
            // 
            // gestionJoueurToolStripMenuItem
            // 
            this.gestionJoueurToolStripMenuItem.Name = "gestionJoueurToolStripMenuItem";
            this.gestionJoueurToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.gestionJoueurToolStripMenuItem.Text = "Gérer ce joueur...";
            this.gestionJoueurToolStripMenuItem.Click += new System.EventHandler(this.gestionJoueurToolStripMenuItem_Click);
            // 
            // afficherStatToolStripMenuItem
            // 
            this.afficherStatToolStripMenuItem.Name = "afficherStatToolStripMenuItem";
            this.afficherStatToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.afficherStatToolStripMenuItem.Text = "Fiche de ce joueur...";
            this.afficherStatToolStripMenuItem.Click += new System.EventHandler(this.afficherStatToolStripMenuItem_Click);
            // 
            // Top5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 257);
            this.Controls.Add(this.FB_Close);
            this.Controls.Add(this.DGV_Top5);
            this.Controls.Add(this.LB_Top5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximumSize = new System.Drawing.Size(574, 500);
            this.MinimumSize = new System.Drawing.Size(574, 39);
            this.Name = "Top5";
            this.Text = "Top 5 des joueurs de la ligue";
            this.Load += new System.EventHandler(this.Top5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Top5)).EndInit();
            this.CMS.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LB_Top5;
        private System.Windows.Forms.DataGridView DGV_Top5;
        private FlashButton.FlashButton FB_Close;
        private System.Windows.Forms.ContextMenuStrip CMS;
        private System.Windows.Forms.ToolStripMenuItem gestionJoueurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem afficherStatToolStripMenuItem;
    }
}
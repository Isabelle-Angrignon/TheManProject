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
            this.LB_Top5 = new System.Windows.Forms.Label();
            this.DGV_Top5 = new System.Windows.Forms.DataGridView();
            this.FB_Close = new FlashButton.FlashButton();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Top5)).BeginInit();
            this.SuspendLayout();
            // 
            // LB_Top5
            // 
            this.LB_Top5.AutoSize = true;
            this.LB_Top5.Location = new System.Drawing.Point(12, 9);
            this.LB_Top5.Name = "LB_Top5";
            this.LB_Top5.Size = new System.Drawing.Size(139, 13);
            this.LB_Top5.TabIndex = 4;
            this.LB_Top5.Text = "Les meilleurs joueurs sont ...";
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
            this.DGV_Top5.Cursor = System.Windows.Forms.Cursors.No;
            this.DGV_Top5.Location = new System.Drawing.Point(15, 25);
            this.DGV_Top5.MultiSelect = false;
            this.DGV_Top5.Name = "DGV_Top5";
            this.DGV_Top5.ReadOnly = true;
            this.DGV_Top5.RowHeadersVisible = false;
            this.DGV_Top5.Size = new System.Drawing.Size(531, 241);
            this.DGV_Top5.TabIndex = 5;
            // 
            // FB_Close
            // 
            this.FB_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.FB_Close.BackgroundImage = global::The_Main_Project.Properties.Resources.Porte;
            this.FB_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FB_Close.ImageClick = global::The_Main_Project.Properties.Resources.PorteCLic;
            this.FB_Close.ImageDisable = null;
            this.FB_Close.ImageNeutral = global::The_Main_Project.Properties.Resources.Porte;
            this.FB_Close.ImageOver = global::The_Main_Project.Properties.Resources.PorteOver;
            this.FB_Close.Location = new System.Drawing.Point(491, 272);
            this.FB_Close.Name = "FB_Close";
            this.FB_Close.Size = new System.Drawing.Size(55, 62);
            this.FB_Close.TabIndex = 26;
            this.FB_Close.Click += new System.EventHandler(this.FB_Close_Click);
            // 
            // Top5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 334);
            this.Controls.Add(this.FB_Close);
            this.Controls.Add(this.DGV_Top5);
            this.Controls.Add(this.LB_Top5);
            this.Name = "Top5";
            this.Text = "Top 5 des joueurs de la ligue";
            this.Load += new System.EventHandler(this.Top5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Top5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LB_Top5;
        private System.Windows.Forms.DataGridView DGV_Top5;
        private FlashButton.FlashButton FB_Close;
    }
}
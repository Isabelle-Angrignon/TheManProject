namespace The_Main_Project
{
    partial class Parametre
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
            this.BG_Parametre = new System.Windows.Forms.GroupBox();
            this.RB_Sombre = new System.Windows.Forms.RadioButton();
            this.RB_Canadien = new System.Windows.Forms.RadioButton();
            this.RB_Defaut = new System.Windows.Forms.RadioButton();
            this.BTN_Appliquer = new System.Windows.Forms.Button();
            this.FB_Close = new FlashButton.FlashButton();
            this.BG_Parametre.SuspendLayout();
            this.SuspendLayout();
            // 
            // BG_Parametre
            // 
            this.BG_Parametre.Controls.Add(this.RB_Sombre);
            this.BG_Parametre.Controls.Add(this.RB_Canadien);
            this.BG_Parametre.Controls.Add(this.RB_Defaut);
            this.BG_Parametre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BG_Parametre.Location = new System.Drawing.Point(12, 12);
            this.BG_Parametre.Name = "BG_Parametre";
            this.BG_Parametre.Size = new System.Drawing.Size(113, 124);
            this.BG_Parametre.TabIndex = 0;
            this.BG_Parametre.TabStop = false;
            this.BG_Parametre.Text = "Options";
            // 
            // RB_Sombre
            // 
            this.RB_Sombre.AutoSize = true;
            this.RB_Sombre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RB_Sombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RB_Sombre.Location = new System.Drawing.Point(6, 89);
            this.RB_Sombre.Name = "RB_Sombre";
            this.RB_Sombre.Size = new System.Drawing.Size(83, 24);
            this.RB_Sombre.TabIndex = 2;
            this.RB_Sombre.TabStop = true;
            this.RB_Sombre.Text = "Sombre";
            this.RB_Sombre.UseVisualStyleBackColor = true;
            // 
            // RB_Canadien
            // 
            this.RB_Canadien.AutoSize = true;
            this.RB_Canadien.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RB_Canadien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RB_Canadien.Location = new System.Drawing.Point(6, 59);
            this.RB_Canadien.Name = "RB_Canadien";
            this.RB_Canadien.Size = new System.Drawing.Size(95, 24);
            this.RB_Canadien.TabIndex = 1;
            this.RB_Canadien.TabStop = true;
            this.RB_Canadien.Text = "Canadien";
            this.RB_Canadien.UseVisualStyleBackColor = true;
            // 
            // RB_Defaut
            // 
            this.RB_Defaut.AutoSize = true;
            this.RB_Defaut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RB_Defaut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RB_Defaut.Location = new System.Drawing.Point(6, 29);
            this.RB_Defaut.Name = "RB_Defaut";
            this.RB_Defaut.Size = new System.Drawing.Size(76, 24);
            this.RB_Defaut.TabIndex = 0;
            this.RB_Defaut.TabStop = true;
            this.RB_Defaut.Text = "Défaut";
            this.RB_Defaut.UseVisualStyleBackColor = true;
            this.RB_Defaut.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // BTN_Appliquer
            // 
            this.BTN_Appliquer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Appliquer.Location = new System.Drawing.Point(12, 142);
            this.BTN_Appliquer.Name = "BTN_Appliquer";
            this.BTN_Appliquer.Size = new System.Drawing.Size(68, 50);
            this.BTN_Appliquer.TabIndex = 11;
            this.BTN_Appliquer.Text = "Appliquer";
            this.BTN_Appliquer.UseVisualStyleBackColor = true;
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
            this.FB_Close.Location = new System.Drawing.Point(151, 142);
            this.FB_Close.Name = "FB_Close";
            this.FB_Close.Size = new System.Drawing.Size(42, 50);
            this.FB_Close.TabIndex = 26;
            this.FB_Close.Click += new System.EventHandler(this.BTN_Ok_Click);
            // 
            // Parametre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(205, 203);
            this.Controls.Add(this.FB_Close);
            this.Controls.Add(this.BTN_Appliquer);
            this.Controls.Add(this.BG_Parametre);
            this.Name = "Parametre";
            this.Text = "Thèmes";
            this.BG_Parametre.ResumeLayout(false);
            this.BG_Parametre.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox BG_Parametre;
        private System.Windows.Forms.RadioButton RB_Sombre;
        private System.Windows.Forms.RadioButton RB_Canadien;
        private System.Windows.Forms.RadioButton RB_Defaut;
        private System.Windows.Forms.Button BTN_Appliquer;
        private FlashButton.FlashButton FB_Close;
    }
}
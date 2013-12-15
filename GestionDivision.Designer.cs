namespace The_Main_Project
{
    partial class GestionDivision
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
            this.Caractérstique = new System.Windows.Forms.GroupBox();
            this.uC_Navigator = new UC_Navigator.UC_Navigator();
            this.DTP_Creation = new System.Windows.Forms.DateTimePicker();
            this.TB_Nom_D = new System.Windows.Forms.TextBox();
            this.BTN_Edit = new System.Windows.Forms.Button();
            this.BTN_Del = new System.Windows.Forms.Button();
            this.BTN_Add = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.FB_Close = new FlashButton.FlashButton();
            this.Caractérstique.SuspendLayout();
            this.SuspendLayout();
            // 
            // Caractérstique
            // 
            this.Caractérstique.Controls.Add(this.uC_Navigator);
            this.Caractérstique.Controls.Add(this.DTP_Creation);
            this.Caractérstique.Controls.Add(this.TB_Nom_D);
            this.Caractérstique.Controls.Add(this.BTN_Edit);
            this.Caractérstique.Controls.Add(this.BTN_Del);
            this.Caractérstique.Controls.Add(this.BTN_Add);
            this.Caractérstique.Controls.Add(this.label5);
            this.Caractérstique.Controls.Add(this.label3);
            this.Caractérstique.Location = new System.Drawing.Point(12, 12);
            this.Caractérstique.Name = "Caractérstique";
            this.Caractérstique.Size = new System.Drawing.Size(222, 157);
            this.Caractérstique.TabIndex = 9;
            this.Caractérstique.TabStop = false;
            // 
            // uC_Navigator
            // 
            this.uC_Navigator.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uC_Navigator.Location = new System.Drawing.Point(9, 106);
            this.uC_Navigator.Name = "uC_Navigator";
            this.uC_Navigator.Size = new System.Drawing.Size(132, 19);
            this.uC_Navigator.TabIndex = 18;
            this.uC_Navigator.OnFirst += new UC_Navigator.UC_Navigator.ClickFirstChangedHandler(this.uC_Navigator_OnFirst);
            this.uC_Navigator.OnPrev += new UC_Navigator.UC_Navigator.ClickPreviousChangedHandler(this.uC_Navigator_OnPrev);
            this.uC_Navigator.OnNext += new UC_Navigator.UC_Navigator.ClickNextChangedHandler(this.uC_Navigator_OnNext);
            this.uC_Navigator.OnLast += new UC_Navigator.UC_Navigator.ClickLastChangedHandler(this.uC_Navigator_OnLast);
            // 
            // DTP_Creation
            // 
            this.DTP_Creation.Location = new System.Drawing.Point(9, 62);
            this.DTP_Creation.Name = "DTP_Creation";
            this.DTP_Creation.Size = new System.Drawing.Size(131, 20);
            this.DTP_Creation.TabIndex = 17;
            // 
            // TB_Nom_D
            // 
            this.TB_Nom_D.Location = new System.Drawing.Point(41, 13);
            this.TB_Nom_D.Name = "TB_Nom_D";
            this.TB_Nom_D.Size = new System.Drawing.Size(100, 20);
            this.TB_Nom_D.TabIndex = 16;
            // 
            // BTN_Edit
            // 
            this.BTN_Edit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Edit.Image = global::The_Main_Project.Properties.Resources.Crayon_petit;
            this.BTN_Edit.Location = new System.Drawing.Point(163, 103);
            this.BTN_Edit.Name = "BTN_Edit";
            this.BTN_Edit.Size = new System.Drawing.Size(40, 35);
            this.BTN_Edit.TabIndex = 3;
            this.BTN_Edit.UseVisualStyleBackColor = true;
            this.BTN_Edit.Click += new System.EventHandler(this.BTN_Edit_Click);
            // 
            // BTN_Del
            // 
            this.BTN_Del.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Del.Image = global::The_Main_Project.Properties.Resources.BTN_Moins;
            this.BTN_Del.Location = new System.Drawing.Point(163, 57);
            this.BTN_Del.Name = "BTN_Del";
            this.BTN_Del.Size = new System.Drawing.Size(40, 35);
            this.BTN_Del.TabIndex = 4;
            this.BTN_Del.UseVisualStyleBackColor = true;
            this.BTN_Del.Click += new System.EventHandler(this.BTN_Del_Click);
            // 
            // BTN_Add
            // 
            this.BTN_Add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Add.Image = global::The_Main_Project.Properties.Resources.BTN_Plus1;
            this.BTN_Add.Location = new System.Drawing.Point(163, 12);
            this.BTN_Add.Name = "BTN_Add";
            this.BTN_Add.Size = new System.Drawing.Size(40, 35);
            this.BTN_Add.TabIndex = 5;
            this.BTN_Add.UseVisualStyleBackColor = true;
            this.BTN_Add.Click += new System.EventHandler(this.BTN_Add_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Date création";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nom";
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
            this.FB_Close.Location = new System.Drawing.Point(187, 175);
            this.FB_Close.Name = "FB_Close";
            this.FB_Close.Size = new System.Drawing.Size(47, 52);
            this.FB_Close.TabIndex = 26;
            this.FB_Close.Click += new System.EventHandler(this.BTN_Ok_Click);
            // 
            // GestionDivision
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(246, 239);
            this.Controls.Add(this.FB_Close);
            this.Controls.Add(this.Caractérstique);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "GestionDivision";
            this.Text = "Gestion division";
            this.Load += new System.EventHandler(this.GestionDivision_Load);
            this.Caractérstique.ResumeLayout(false);
            this.Caractérstique.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Caractérstique;
        private System.Windows.Forms.DateTimePicker DTP_Creation;
        private System.Windows.Forms.TextBox TB_Nom_D;
        private System.Windows.Forms.Button BTN_Edit;
        private System.Windows.Forms.Button BTN_Del;
        private System.Windows.Forms.Button BTN_Add;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private UC_Navigator.UC_Navigator uC_Navigator;
        private FlashButton.FlashButton FB_Close;
    }
}
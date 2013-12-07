namespace The_Main_Project
{
    partial class GestionEquipe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionEquipe));
            this.BTN_Ok = new System.Windows.Forms.Button();
            this.BTN_Cancel = new System.Windows.Forms.Button();
            this.Caractérstique = new System.Windows.Forms.GroupBox();
            this.uC_Navigator = new UC_Navigator.UC_Navigator();
            this.BTN_Load = new System.Windows.Forms.Button();
            this.PBX_Logo = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TB_DivisionEquipe = new System.Windows.Forms.TextBox();
            this.DTP_Date_Team = new System.Windows.Forms.DateTimePicker();
            this.TB_Nom_Team = new System.Windows.Forms.TextBox();
            this.BTN_Edit = new System.Windows.Forms.Button();
            this.BTN_Del = new System.Windows.Forms.Button();
            this.BTN_Add = new System.Windows.Forms.Button();
            this.TB_Ville = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Caractérstique.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBX_Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // BTN_Ok
            // 
            this.BTN_Ok.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Ok.Location = new System.Drawing.Point(194, 249);
            this.BTN_Ok.Name = "BTN_Ok";
            this.BTN_Ok.Size = new System.Drawing.Size(50, 50);
            this.BTN_Ok.TabIndex = 8;
            this.BTN_Ok.Text = "OK";
            this.BTN_Ok.UseVisualStyleBackColor = true;
            this.BTN_Ok.Click += new System.EventHandler(this.BTN_Ok_Click);
            // 
            // BTN_Cancel
            // 
            this.BTN_Cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Cancel.Location = new System.Drawing.Point(253, 249);
            this.BTN_Cancel.Name = "BTN_Cancel";
            this.BTN_Cancel.Size = new System.Drawing.Size(50, 50);
            this.BTN_Cancel.TabIndex = 7;
            this.BTN_Cancel.Text = "Cancel";
            this.BTN_Cancel.UseVisualStyleBackColor = true;
            this.BTN_Cancel.Click += new System.EventHandler(this.BTN_Cancel_Click);
            // 
            // Caractérstique
            // 
            this.Caractérstique.Controls.Add(this.uC_Navigator);
            this.Caractérstique.Controls.Add(this.BTN_Load);
            this.Caractérstique.Controls.Add(this.PBX_Logo);
            this.Caractérstique.Controls.Add(this.label2);
            this.Caractérstique.Controls.Add(this.TB_DivisionEquipe);
            this.Caractérstique.Controls.Add(this.DTP_Date_Team);
            this.Caractérstique.Controls.Add(this.TB_Nom_Team);
            this.Caractérstique.Controls.Add(this.BTN_Edit);
            this.Caractérstique.Controls.Add(this.BTN_Del);
            this.Caractérstique.Controls.Add(this.BTN_Add);
            this.Caractérstique.Controls.Add(this.TB_Ville);
            this.Caractérstique.Controls.Add(this.label6);
            this.Caractérstique.Controls.Add(this.label5);
            this.Caractérstique.Controls.Add(this.label3);
            this.Caractérstique.Location = new System.Drawing.Point(12, 12);
            this.Caractérstique.Name = "Caractérstique";
            this.Caractérstique.Size = new System.Drawing.Size(288, 231);
            this.Caractérstique.TabIndex = 6;
            this.Caractérstique.TabStop = false;
            // 
            // uC_Navigator
            // 
            this.uC_Navigator.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uC_Navigator.Location = new System.Drawing.Point(17, 198);
            this.uC_Navigator.Name = "uC_Navigator";
            this.uC_Navigator.Size = new System.Drawing.Size(195, 19);
            this.uC_Navigator.TabIndex = 23;
            this.uC_Navigator.OnFirst += new UC_Navigator.UC_Navigator.ClickFirstChangedHandler(this.uC_Navigator_OnFirst);
            this.uC_Navigator.OnPrev += new UC_Navigator.UC_Navigator.ClickPreviousChangedHandler(this.uC_Navigator_OnPrev);
            this.uC_Navigator.OnNext += new UC_Navigator.UC_Navigator.ClickNextChangedHandler(this.uC_Navigator_OnNext);
            this.uC_Navigator.OnLast += new UC_Navigator.UC_Navigator.ClickLastChangedHandler(this.uC_Navigator_OnLast);
            // 
            // BTN_Load
            // 
            this.BTN_Load.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Load.Location = new System.Drawing.Point(96, 19);
            this.BTN_Load.Name = "BTN_Load";
            this.BTN_Load.Size = new System.Drawing.Size(75, 23);
            this.BTN_Load.TabIndex = 9;
            this.BTN_Load.Text = "Charger";
            this.BTN_Load.UseVisualStyleBackColor = true;
            // 
            // PBX_Logo
            // 
            this.PBX_Logo.Location = new System.Drawing.Point(17, 19);
            this.PBX_Logo.Name = "PBX_Logo";
            this.PBX_Logo.Size = new System.Drawing.Size(73, 50);
            this.PBX_Logo.TabIndex = 22;
            this.PBX_Logo.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Division";
            // 
            // TB_DivisionEquipe
            // 
            this.TB_DivisionEquipe.Location = new System.Drawing.Point(67, 157);
            this.TB_DivisionEquipe.Name = "TB_DivisionEquipe";
            this.TB_DivisionEquipe.Size = new System.Drawing.Size(131, 20);
            this.TB_DivisionEquipe.TabIndex = 19;
            this.TB_DivisionEquipe.Text = "Autofill";
            // 
            // DTP_Date_Team
            // 
            this.DTP_Date_Team.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTP_Date_Team.Location = new System.Drawing.Point(83, 106);
            this.DTP_Date_Team.Name = "DTP_Date_Team";
            this.DTP_Date_Team.Size = new System.Drawing.Size(115, 20);
            this.DTP_Date_Team.TabIndex = 17;
            // 
            // TB_Nom_Team
            // 
            this.TB_Nom_Team.Location = new System.Drawing.Point(67, 79);
            this.TB_Nom_Team.Name = "TB_Nom_Team";
            this.TB_Nom_Team.Size = new System.Drawing.Size(131, 20);
            this.TB_Nom_Team.TabIndex = 16;
            // 
            // BTN_Edit
            // 
            this.BTN_Edit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Edit.Image = global::The_Main_Project.Properties.Resources.Crayon_petit;
            this.BTN_Edit.Location = new System.Drawing.Point(221, 137);
            this.BTN_Edit.Name = "BTN_Edit";
            this.BTN_Edit.Size = new System.Drawing.Size(40, 40);
            this.BTN_Edit.TabIndex = 3;
            this.BTN_Edit.UseVisualStyleBackColor = true;
            // 
            // BTN_Del
            // 
            this.BTN_Del.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Del.Image = ((System.Drawing.Image)(resources.GetObject("BTN_Del.Image")));
            this.BTN_Del.Location = new System.Drawing.Point(221, 91);
            this.BTN_Del.Name = "BTN_Del";
            this.BTN_Del.Size = new System.Drawing.Size(40, 40);
            this.BTN_Del.TabIndex = 4;
            this.BTN_Del.UseVisualStyleBackColor = true;
            // 
            // BTN_Add
            // 
            this.BTN_Add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Add.Image = global::The_Main_Project.Properties.Resources.BTN_Plus1;
            this.BTN_Add.Location = new System.Drawing.Point(221, 46);
            this.BTN_Add.Name = "BTN_Add";
            this.BTN_Add.Size = new System.Drawing.Size(40, 40);
            this.BTN_Add.TabIndex = 5;
            this.BTN_Add.UseVisualStyleBackColor = true;
            // 
            // TB_Ville
            // 
            this.TB_Ville.Location = new System.Drawing.Point(67, 131);
            this.TB_Ville.Name = "TB_Ville";
            this.TB_Ville.Size = new System.Drawing.Size(131, 20);
            this.TB_Ville.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Ville";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Date intro";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nom";
            // 
            // GestionEquipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 314);
            this.Controls.Add(this.BTN_Ok);
            this.Controls.Add(this.BTN_Cancel);
            this.Controls.Add(this.Caractérstique);
            this.Name = "GestionEquipe";
            this.Text = "GestionEquipe";
            this.Load += new System.EventHandler(this.GestionEquipe_Load);
            this.Caractérstique.ResumeLayout(false);
            this.Caractérstique.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBX_Logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BTN_Ok;
        private System.Windows.Forms.Button BTN_Cancel;
        private System.Windows.Forms.GroupBox Caractérstique;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TB_DivisionEquipe;
        private System.Windows.Forms.DateTimePicker DTP_Date_Team;
        private System.Windows.Forms.TextBox TB_Nom_Team;
        private System.Windows.Forms.Button BTN_Edit;
        private System.Windows.Forms.Button BTN_Del;
        private System.Windows.Forms.Button BTN_Add;
        private System.Windows.Forms.TextBox TB_Ville;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BTN_Load;
        private System.Windows.Forms.PictureBox PBX_Logo;
        private UC_Navigator.UC_Navigator uC_Navigator;
    }
}
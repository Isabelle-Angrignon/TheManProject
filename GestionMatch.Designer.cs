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
            this.UC_Navigator = new UC_Navigator.UC_Navigator();
            this.TB_Receveur = new System.Windows.Forms.TextBox();
            this.TB_Visiteur = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TB_Lieu = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DTP_Date = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.BTN_Ok = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.BTN_Delete = new System.Windows.Forms.Button();
            this.BTN_Add = new System.Windows.Forms.Button();
            this.BTN_MOD.SuspendLayout();
            this.SuspendLayout();
            // 
            // BTN_MOD
            // 
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
            this.BTN_MOD.Size = new System.Drawing.Size(264, 167);
            this.BTN_MOD.TabIndex = 0;
            this.BTN_MOD.TabStop = false;
            // 
            // UC_Navigator
            // 
            this.UC_Navigator.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UC_Navigator.Location = new System.Drawing.Point(12, 132);
            this.UC_Navigator.Name = "UC_Navigator";
            this.UC_Navigator.Size = new System.Drawing.Size(206, 19);
            this.UC_Navigator.TabIndex = 38;
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
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Viviteur";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Reveveur";
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
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(226, 185);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 50);
            this.button1.TabIndex = 1;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BTN_Ok
            // 
            this.BTN_Ok.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Ok.Location = new System.Drawing.Point(170, 185);
            this.BTN_Ok.Name = "BTN_Ok";
            this.BTN_Ok.Size = new System.Drawing.Size(50, 50);
            this.BTN_Ok.TabIndex = 2;
            this.BTN_Ok.Text = "OK";
            this.BTN_Ok.UseVisualStyleBackColor = true;
            this.BTN_Ok.Click += new System.EventHandler(this.BTN_Ok_Click);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Image = global::The_Main_Project.Properties.Resources.Crayon_petit;
            this.button2.Location = new System.Drawing.Point(214, 83);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(44, 43);
            this.button2.TabIndex = 3;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // BTN_Delete
            // 
            this.BTN_Delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Delete.Image = ((System.Drawing.Image)(resources.GetObject("BTN_Delete.Image")));
            this.BTN_Delete.Location = new System.Drawing.Point(214, 47);
            this.BTN_Delete.Name = "BTN_Delete";
            this.BTN_Delete.Size = new System.Drawing.Size(44, 40);
            this.BTN_Delete.TabIndex = 4;
            this.BTN_Delete.UseVisualStyleBackColor = true;
            // 
            // BTN_Add
            // 
            this.BTN_Add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Add.Image = global::The_Main_Project.Properties.Resources.BTN_Plus1;
            this.BTN_Add.Location = new System.Drawing.Point(214, 10);
            this.BTN_Add.Name = "BTN_Add";
            this.BTN_Add.Size = new System.Drawing.Size(44, 35);
            this.BTN_Add.TabIndex = 5;
            this.BTN_Add.UseVisualStyleBackColor = true;
            // 
            // GestionMatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 241);
            this.Controls.Add(this.BTN_Ok);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BTN_MOD);
            this.Name = "GestionMatch";
            this.Text = "GestionMatch";
            this.BTN_MOD.ResumeLayout(false);
            this.BTN_MOD.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BTN_Ok;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button BTN_Delete;
        private System.Windows.Forms.Button BTN_Add;
        private UC_Navigator.UC_Navigator UC_Navigator;
    }
}
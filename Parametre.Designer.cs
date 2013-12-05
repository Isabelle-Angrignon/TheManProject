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
            this.BTN_Ok = new System.Windows.Forms.Button();
            this.BTN_Cancel = new System.Windows.Forms.Button();
            this.BTN_Appliquer = new System.Windows.Forms.Button();
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
            // BTN_Ok
            // 
            this.BTN_Ok.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Ok.Location = new System.Drawing.Point(86, 142);
            this.BTN_Ok.Name = "BTN_Ok";
            this.BTN_Ok.Size = new System.Drawing.Size(50, 50);
            this.BTN_Ok.TabIndex = 10;
            this.BTN_Ok.Text = "OK";
            this.BTN_Ok.UseVisualStyleBackColor = true;
            this.BTN_Ok.Click += new System.EventHandler(this.BTN_Ok_Click);
            // 
            // BTN_Cancel
            // 
            this.BTN_Cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Cancel.Location = new System.Drawing.Point(142, 142);
            this.BTN_Cancel.Name = "BTN_Cancel";
            this.BTN_Cancel.Size = new System.Drawing.Size(50, 50);
            this.BTN_Cancel.TabIndex = 9;
            this.BTN_Cancel.Text = "Cancel";
            this.BTN_Cancel.UseVisualStyleBackColor = true;
            this.BTN_Cancel.Click += new System.EventHandler(this.button1_Click);
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
            // Parametre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(205, 203);
            this.Controls.Add(this.BTN_Appliquer);
            this.Controls.Add(this.BTN_Ok);
            this.Controls.Add(this.BTN_Cancel);
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
        private System.Windows.Forms.Button BTN_Ok;
        private System.Windows.Forms.Button BTN_Cancel;
        private System.Windows.Forms.Button BTN_Appliquer;
    }
}
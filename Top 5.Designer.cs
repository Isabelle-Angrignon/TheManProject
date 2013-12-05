namespace The_Main_Project
{
    partial class Top_5
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
            this.BTN_Ok = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Top5)).BeginInit();
            this.SuspendLayout();
            // 
            // LB_Top5
            // 
            this.LB_Top5.AutoSize = true;
            this.LB_Top5.Location = new System.Drawing.Point(24, 11);
            this.LB_Top5.Name = "LB_Top5";
            this.LB_Top5.Size = new System.Drawing.Size(132, 13);
            this.LB_Top5.TabIndex = 0;
            this.LB_Top5.Text = "Le top 5 des joueurs est ...";
            // 
            // DGV_Top5
            // 
            this.DGV_Top5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Top5.Location = new System.Drawing.Point(25, 43);
            this.DGV_Top5.Name = "DGV_Top5";
            this.DGV_Top5.Size = new System.Drawing.Size(299, 189);
            this.DGV_Top5.TabIndex = 1;
            // 
            // BTN_Ok
            // 
            this.BTN_Ok.Location = new System.Drawing.Point(284, 257);
            this.BTN_Ok.Name = "BTN_Ok";
            this.BTN_Ok.Size = new System.Drawing.Size(50, 50);
            this.BTN_Ok.TabIndex = 12;
            this.BTN_Ok.Text = "OK";
            this.BTN_Ok.UseVisualStyleBackColor = true;
            this.BTN_Ok.Click += new System.EventHandler(this.BTN_Ok_Click);
            // 
            // Top_5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 319);
            this.Controls.Add(this.BTN_Ok);
            this.Controls.Add(this.DGV_Top5);
            this.Controls.Add(this.LB_Top5);
            this.Name = "Top_5";
            this.Text = "Top_5";
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Top5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LB_Top5;
        private System.Windows.Forms.DataGridView DGV_Top5;
        private System.Windows.Forms.Button BTN_Ok;
    }
}
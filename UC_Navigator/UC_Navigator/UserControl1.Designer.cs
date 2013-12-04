namespace UC_Navigator
{
    partial class UC_Navigator
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

        #region Code généré par le Concepteur de composants

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.BTNF_Last = new BoutonFlèche.BoutonFlèche();
            this.BTNF_Next = new BoutonFlèche.BoutonFlèche();
            this.BTNF_Previous = new BoutonFlèche.BoutonFlèche();
            this.BTNF_First = new BoutonFlèche.BoutonFlèche();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // BTNF_Last
            // 
            this.BTNF_Last.Apparence = BoutonFlèche.BoutonFlèche.ApparenceType.GotoFin;
            this.BTNF_Last.ClickColor = System.Drawing.Color.White;
            this.BTNF_Last.Direction = BoutonFlèche.BoutonFlèche.DirectionType.Droit;
            this.BTNF_Last.EnterColor = System.Drawing.Color.LightGray;
            this.BTNF_Last.LeaveColor = System.Drawing.Color.Black;
            this.BTNF_Last.Location = new System.Drawing.Point(117, 3);
            this.BTNF_Last.Name = "BTNF_Last";
            this.BTNF_Last.Size = new System.Drawing.Size(24, 24);
            this.BTNF_Last.TabIndex = 0;
            // 
            // BTNF_Next
            // 
            this.BTNF_Next.Apparence = BoutonFlèche.BoutonFlèche.ApparenceType.Triangle;
            this.BTNF_Next.ClickColor = System.Drawing.Color.White;
            this.BTNF_Next.Direction = BoutonFlèche.BoutonFlèche.DirectionType.Droit;
            this.BTNF_Next.EnterColor = System.Drawing.Color.LightGray;
            this.BTNF_Next.LeaveColor = System.Drawing.Color.Black;
            this.BTNF_Next.Location = new System.Drawing.Point(79, 3);
            this.BTNF_Next.Name = "BTNF_Next";
            this.BTNF_Next.Size = new System.Drawing.Size(24, 24);
            this.BTNF_Next.TabIndex = 0;
            // 
            // BTNF_Previous
            // 
            this.BTNF_Previous.Apparence = BoutonFlèche.BoutonFlèche.ApparenceType.Triangle;
            this.BTNF_Previous.ClickColor = System.Drawing.Color.White;
            this.BTNF_Previous.Direction = BoutonFlèche.BoutonFlèche.DirectionType.Gauche;
            this.BTNF_Previous.EnterColor = System.Drawing.Color.LightGray;
            this.BTNF_Previous.LeaveColor = System.Drawing.Color.Black;
            this.BTNF_Previous.Location = new System.Drawing.Point(41, 3);
            this.BTNF_Previous.Name = "BTNF_Previous";
            this.BTNF_Previous.Size = new System.Drawing.Size(24, 24);
            this.BTNF_Previous.TabIndex = 0;
            // 
            // BTNF_First
            // 
            this.BTNF_First.Apparence = BoutonFlèche.BoutonFlèche.ApparenceType.GotoFin;
            this.BTNF_First.ClickColor = System.Drawing.Color.White;
            this.BTNF_First.Direction = BoutonFlèche.BoutonFlèche.DirectionType.Gauche;
            this.BTNF_First.EnterColor = System.Drawing.Color.LightGray;
            this.BTNF_First.LeaveColor = System.Drawing.Color.Black;
            this.BTNF_First.Location = new System.Drawing.Point(3, 3);
            this.BTNF_First.Name = "BTNF_First";
            this.BTNF_First.Size = new System.Drawing.Size(24, 24);
            this.BTNF_First.TabIndex = 0;
            // 
            // UC_Navigator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BTNF_Last);
            this.Controls.Add(this.BTNF_Next);
            this.Controls.Add(this.BTNF_Previous);
            this.Controls.Add(this.BTNF_First);
            this.Name = "UC_Navigator";
            this.Size = new System.Drawing.Size(150, 32);
            this.SizeChanged += new System.EventHandler(this.UC_Navigator_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource1;
        private BoutonFlèche.BoutonFlèche BTNF_First;
        private BoutonFlèche.BoutonFlèche BTNF_Previous;
        private BoutonFlèche.BoutonFlèche BTNF_Next;
        private BoutonFlèche.BoutonFlèche BTNF_Last;


    }
}

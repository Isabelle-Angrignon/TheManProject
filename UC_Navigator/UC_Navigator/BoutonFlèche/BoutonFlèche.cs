using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BoutonFlèche
{
    [DefaultEvent("MouseClick")]
    public partial class BoutonFlèche : UserControl
    {

        // énumération des quatres directions
        public enum DirectionType { Haut, Bas, Gauche, Droit };
        private DirectionType m_Direction = DirectionType.Bas;

        // énumération des états possible du contrôle Flèche
        // OUT  : le pointeur de la souris est en dehors du contrôle
        // IN   : le pointeur de la souris est en dedans du contrôle
        // CLIC : le pointeur de la souris est en dedans du contrôle
        //        et le bouton de la souris est enfoncé
        private enum Etat { OUT, IN, CLIC };

      // état du contrôle qui déterminera comment la flèche sera dessinée
        private Etat m_etat = Etat.OUT;

        // énumération de l'apparence
        public enum ApparenceType { Normal, Triangle, Aigu, GotoFin };
        private ApparenceType m_Apparence = ApparenceType.Normal;

  
        private Color m_Enter_Color = Color.LightGray;
        private Color m_Leave_Color = Color.Black;
        private Color m_Click_Color = Color.White;

        [Description("Direction de la flèche.")]
        public DirectionType Direction
        {
            get { return m_Direction; }
            set { m_Direction = value; this.Refresh(); }
        }

        [Description("Apparence de la flèche.")]
        public ApparenceType Apparence
        {
            get { return m_Apparence; }
            set { m_Apparence = value; this.Refresh(); }
        }

        [Description("Couleur de la flèche lorsque que le pointeur de souris survol sa zone.")]
        public Color EnterColor
        {
            get { return m_Enter_Color; }
            set { m_Enter_Color = value; this.Refresh(); }
        }

        [Description("Couleur de la flèche lorsque que le pointeur de souris quite sa zone.")]
        public Color LeaveColor
        {
            get { return m_Leave_Color; }
            set { m_Leave_Color = value; this.Refresh(); }
        }

        [Description("Couleur de la flèche lorsque que le pointeur de souris survol sa zone et que le boutons est enfoncé.")]
        public Color ClickColor
        {
            get { return m_Click_Color; }
            set { m_Click_Color = value; this.Refresh(); }
        }

        public BoutonFlèche()
        {
            InitializeComponent();
        }

        private Point Tourne90(Point p, Point centre)
        {
            Point pc = new Point(p.X - centre.X, p.Y - centre.Y);
            Point pt = new Point(centre.X - pc.Y, centre.Y + pc.X);
            return pt;
        }

        private void Tourne90(Point[] pts, Point centre)
        {
            for(int i= 0; i < pts.Count(); i++)
            {
                pts[i] = Tourne90(pts[i], centre);
            }
        }

        ///////////////////////////////////////////////////////////////////////////////////////////
        // C o n t r u i r e _ F l è c h e
        ///////////////////////////////////////////////////////////////////////////////////////////
        // Cette fonction retourne un tableau de points décrivant la topologie de la flèche par
        // les extrêmitées des segment qui la compose. Cette topologie tiendra compte des
        // proportions du rectangle bordure et du membre m_Direction
        ///////////////////////////////////////////////////////////////////////////////////////////
        private Point[] Contruire_Flèche(Rectangle bordure)
        {
            // tableau de points pour mémoriser la géométrie de la flèche
            Point[] points = null;

            // calcul de la demi de la plus petite dimension du rectangle bordure
            Point demi = new Point(1,1);

            switch (m_Direction)
            {
                case DirectionType.Droit:
                case DirectionType.Gauche :
                    demi = new Point(bordure.Width / 2, bordure.Height / 2);
                    break;
                case DirectionType.Haut:
                case DirectionType.Bas:
                    demi = new Point(bordure.Height / 2, bordure.Width / 2);
                    break;
            }


            // calcul du centre du rectangle bordure
            Point centre = new Point(bordure.Left + bordure.Width / 2,
                                     bordure.Top + bordure.Height / 2);

            // calculer les extrêmitées des segment qui compose 
            // le contour de la flèche DE DIRECTION DROITE celon
            // le type d'apparence
            switch (m_Apparence)
            {
                case ApparenceType.Normal:  
                    points = new Point[8];
                    points[0] = new Point(centre.X + demi.X, centre.Y);
                    points[1] = new Point(centre.X, centre.Y + demi.Y);
                    points[2] = new Point(centre.X, centre.Y + demi.Y / 2);
                    points[3] = new Point(centre.X - demi.X, centre.Y + demi.Y / 2);
                    points[4] = new Point(centre.X - demi.X, centre.Y - demi.Y / 2);
                    points[5] = new Point(centre.X, centre.Y - demi.Y / 2);
                    points[6] = new Point(centre.X, centre.Y - demi.Y);
                    points[7] = new Point(points[0].X, points[0].Y);
                    break;

                case ApparenceType.Triangle:
                    points = new Point[4];
                    points[0] = new Point(centre.X + demi.X / 2, centre.Y);
                    points[1] = new Point(centre.X - demi.X / 2, centre.Y + demi.Y);
                    points[2] = new Point(centre.X - demi.X / 2, centre.Y - demi.Y);
                    points[3] = new Point(points[0].X, points[0].Y);
                    break;

                case ApparenceType.Aigu :
                    points = new Point[5];
                    points[0] = new Point(centre.X + demi.X / 2, centre.Y);
                    points[1] = new Point(centre.X - demi.X / 2, centre.Y + demi.Y);
                    points[2] = new Point(centre.X , centre.Y);
                    points[3] = new Point(centre.X - demi.X / 2, centre.Y - demi.Y);
                    points[4] = new Point(points[0].X, points[0].Y);
                    break;


                case ApparenceType.GotoFin:
                    points = new Point[9];
                    points[0] = new Point(centre.X + demi.X / 2, centre.Y);
                    points[1] = new Point(centre.X + demi.X / 2, centre.Y - demi.Y);
                    points[2] = new Point(centre.X + demi.X / 2 + demi.X / 4, centre.Y - demi.Y);
                    points[3] = new Point(centre.X + demi.X / 2 + demi.X / 4, centre.Y + demi.Y);
                    points[4] = new Point(centre.X + demi.X / 2 , centre.Y + demi.Y);
                    points[5] = new Point(centre.X + demi.X / 2, centre.Y);

                    points[6] = new Point(centre.X - demi.X / 2, centre.Y + demi.Y);
                    points[7] = new Point(centre.X - demi.X / 2, centre.Y - demi.Y);
                    points[8] = new Point(points[0].X, points[0].Y);
                    break;

            }

            // Effectuer la rotation nécessaire
            switch (m_Direction)
            {
                case DirectionType.Haut:    Tourne90(points, centre);
                                            Tourne90(points, centre);
                                            Tourne90(points, centre);
                                            break;

                case DirectionType.Gauche:  Tourne90(points, centre);
                                            Tourne90(points, centre);
                                            break;

                case DirectionType.Bas:     Tourne90(points, centre);
                                            break;
            }
 
            return points;
        }

        private void Draw(Graphics DC)
        {
            // construire un rectangle englobant le contrôle
            Rectangle r = new Rectangle(new Point(0, 0), this.Size);

            // tracer le contour du contrôle
            DC.FillRectangle(new SolidBrush(this.BackColor), r);

            // réduire de 2 pixels le contour du contrôle pour jouer le rôle de
            // marges pour le traçage de la flèche
            r.Inflate(-2, -2);

            Brush brush = null;

            // choisir la couleur de remplissage en fonction de l'état m_etat du contrôle
            switch (m_etat)
            {
                case Etat.OUT: brush = new SolidBrush(m_Leave_Color); break;
                case Etat.IN: brush = new SolidBrush(m_Enter_Color); break;
                case Etat.CLIC: brush = new SolidBrush(m_Click_Color); break;
            }

            // optimisation d'affichage pour lisser les arètes de la flêche
            DC.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // remplir l'intérieur de la flèche construite
            DC.FillPolygon(brush, Contruire_Flèche(r));

            // tracer les contour de la flèche construite
            DC.DrawLines(new Pen(Color.Black, 1), Contruire_Flèche(r));
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
        }

        private void BoutonFlèche_Paint(object sender, PaintEventArgs e)
        {
            Draw(e.Graphics);
        }

        private void BoutonFlèche_MouseEnter(object sender, EventArgs e)
        {
            m_etat = Etat.IN;
            this.Refresh();
        }

        private void BoutonFlèche_MouseLeave(object sender, EventArgs e)
        {
            m_etat = Etat.OUT;
            this.Refresh();
        }

        private void BoutonFlèche_MouseDown(object sender, MouseEventArgs e)
        {
            m_etat = Etat.CLIC;
            this.Refresh();
        }

        private void BoutonFlèche_MouseUp(object sender, MouseEventArgs e)
        {
            m_etat = Etat.IN;
            this.Refresh();
        }
    }
}

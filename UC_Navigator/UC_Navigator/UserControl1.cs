using System;
using System.Drawing;
using System.Windows.Forms;

namespace UC_Navigator
{
    public partial class UC_Navigator: UserControl
    {
        public UC_Navigator()
        {
            InitializeComponent();
        }

        private void UC_Navigator_SizeChanged(object sender, EventArgs e)
        {
            BTNF_First.Height =
            BTNF_Previous.Height =
            BTNF_Next.Height =
            BTNF_Last.Height =
            BTNF_First.Width =
            BTNF_Previous.Width =
            BTNF_Next.Width =
            BTNF_Last.Width = this.Height;

            int step = this.Width / 4;
            int halfstep = this.Height/2;

            BTNF_First.Location = new Point(step/2 - halfstep, 0);
            BTNF_Previous.Location = new Point(step + step/2 - halfstep, 0);
            BTNF_Next.Location = new Point(2 * step + step / 2 - halfstep, 0);
            BTNF_Last.Location = new Point(3 * step + step / 2 - halfstep, 0);
        }
                
        // Prototype du delegate du traitement des événements First, Previous, Next et Last  
        public delegate void ClickFirstChangedHandler(Object sender, EventArgs e);
        public delegate void ClickPreviousChangedHandler(Object sender, EventArgs e);
        public delegate void ClickNextChangedHandler(Object sender, EventArgs e);
        public delegate void ClickLastChangedHandler(Object sender, EventArgs e);

        // Membre public des types click handlers   
        public event ClickFirstChangedHandler OnFirst = null;
        public event ClickPreviousChangedHandler OnPrev = null;
        public event ClickNextChangedHandler OnNext = null;
        public event ClickLastChangedHandler OnLast = null;

        // Méthode d'appel du gestionnaire des événements        
        private void OnClickFirst()
        {            
            if (OnFirst != null)
                OnFirst(this, new EventArgs());
        }
        private void OnClickPrevious()
        {
            if (OnPrev != null)
                OnPrev(this, new EventArgs());
        }
        private void OnClickNext()
        {
            if (OnNext != null)
                OnNext(this, new EventArgs());
        }
        private void OnClickLast()
        {
            if (OnLast != null)
                OnLast(this, new EventArgs());
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace DrawShapeLib
{
    public class CCircle : CShape
    {
        #region Variables membres

        private int _Rayon;
        
        #endregion

        #region Constructeurs

        public CCircle() : base()
        {
            Rayon = 0;
        }

        public CCircle(int r, Point p, Color c) : base(p, c)
        {
            Rayon = r;
        }

        public CCircle(int r, Point p, Color c, bool rempli) : base(p, c, rempli)
        {
            Rayon = r;
        }

        #endregion

        #region Propriétés

        public int Rayon
        {
            get { return _Rayon; }
            set { _Rayon = value; }
        }

        #endregion

        #region Méthodes

        public override string ToString()
        {
            return "Cercle \n" + base.ToString() + string.Format("\n\tRayon du cercle: {0}", _Rayon);
        }

        public override void Draw()
        {
            Console.WriteLine(this.ToString());
        }

        public override void Draw(Graphics g)
        {
            if (Rempli == true)
                g.FillEllipse(new SolidBrush(Couleur), PointAncrage.X, PointAncrage.Y, Rayon, Rayon);
            else
                g.DrawEllipse(new Pen(Couleur), PointAncrage.X, PointAncrage.Y, Rayon, Rayon);
        }

        public override object Clone()
        {
            return new CCircle(this.Rayon, new Point (this.PointAncrage.X, this.PointAncrage.Y), this.Couleur, this.Rempli);
        }

        #endregion
    }
}

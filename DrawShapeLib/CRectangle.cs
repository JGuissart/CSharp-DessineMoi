using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace DrawShapeLib
{
    public class CRectangle : CShape
    {
        #region Variables membres

        private int _Longueur;
        private int _Largeur;
        
        #endregion

        #region Constructeurs

        public CRectangle() : base()
        {
            Longueur = 0;
            Largeur = 0;
        }

        public CRectangle(int l, int L, Point p, Color c) : base(p, c, false)
        {
            Longueur = l;
            Largeur = L;
        }

        public CRectangle(int l, int L, Point p, Color c, bool r) : base(p, c, r)
        {
            Longueur = l;
            Largeur = L;
        }

        #endregion

        #region Propriétés

        public int Longueur
        {
            get { return _Longueur; }
            set { _Longueur = value; }
        }

        public int Largeur
        {
            get { return _Largeur; }
            set { _Largeur = value; }
        }

        #endregion

        #region Méthodes

        public override string ToString()
        {
            if (Longueur == Largeur)
                return "Carré \n" + base.ToString() + string.Format("\n\tCôté: {0}", Longueur);
            else
                return "Rectangle \n" + base.ToString() + string.Format("\n\tLongueur: {0} \n\tLargeur: {1}", Longueur, Largeur);
        }

        public override object Clone()
        {
            return new CRectangle(this.Longueur, this.Largeur, new Point(this.PointAncrage.X, this.PointAncrage.Y), this.Couleur, this.Rempli);
        }

        public override void Draw()
        {
            Console.WriteLine(this.ToString());
        }

        public override void Draw(Graphics g)
        {
            if (Rempli == true)
                g.FillRectangle(new SolidBrush(Couleur), PointAncrage.X, PointAncrage.Y, Longueur, Largeur);
            else
                g.DrawRectangle(new Pen(Couleur), PointAncrage.X, PointAncrage.Y, Longueur, Largeur);
        }

        #endregion
    }
}

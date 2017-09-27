using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace DrawShapeLib
{
    public abstract class CShape : IDrawable
    {
        #region Variables membres

        private Point _PointAncrage;
        private bool _Rempli;
        private Color _Couleur;

        #endregion

        #region Constructeurs

        public CShape()
        {
            PointAncrage = new Point(0, 0);
            Rempli = false;
            Couleur = Color.Black;
        }

        public CShape(Point p, Color c, bool r)
        {
            PointAncrage = p;
            Couleur = c;
            Rempli = r;
        }

        public CShape(Point p, Color c) : this(p, c, false)
        {

        }

        #endregion

        #region Propriétés

        public Point PointAncrage
        {
            get { return _PointAncrage; }
            set { _PointAncrage = value; }
        }

        public bool Rempli
        {
            get { return _Rempli; }
            set { _Rempli = value; }
        }

        public Color Couleur
        {
            get { return _Couleur; }
            set { _Couleur = value; }
        }

        public Point TopLeft
        {
            get { return PointAncrage; }
            set { PointAncrage = value; }
        }

        #endregion

        #region Méthodes

        public override string ToString()
        {
            return string.Format("\tPoint d'ancrage: {0} \n\tCouleur: {1} \n\tRempli: {2}", _PointAncrage, _Couleur, _Rempli);
        }
        
        public abstract void Draw();
        public abstract void Draw(Graphics g);
        public abstract object Clone();

        #endregion
    }
}

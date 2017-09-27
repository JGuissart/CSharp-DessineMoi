using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace DrawShapeLib
{
    public class CComplex : IDrawable
    {
        #region Variables membres

        private List<IDrawable> _ListeForme; // Contiendra toutes les formes simple composant CETTE forme complexe
        private string _Nom;
        private Point _PointAncrage;

        #endregion

        #region Constructeurs

        public CComplex()
        {
            ListeForme = new List<IDrawable>();
            Nom = "default";
        }

        public CComplex(string n)
        {
            ListeForme = new List<IDrawable>();
            Nom = n;
        }

        public CComplex(string n, List<IDrawable> l, Point p)
        {
            ListeForme = l;
            Nom = n;
            PointAncrage = p;
        }

        #endregion

        #region Propriétés

        public Point PointAncrage
        {
            get { return _PointAncrage; }
            set { _PointAncrage = value; }
        }

        public string Nom
        {
            get { return _Nom; }
            set { _Nom = value; }
        }

        public List<IDrawable> ListeForme
        {
            get { return _ListeForme; }
            set { _ListeForme = value; }
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
            return Nom;
        }

        public void Draw()
        {
            Console.WriteLine(this.ToString());
        }

        public void Draw(Graphics g)
        {
            foreach (IDrawable elem in ListeForme)
            {
                IDrawable temp = (IDrawable)elem.Clone();
                Point p = temp.TopLeft;
                p.X += PointAncrage.X;
                p.Y += PointAncrage.Y;
                temp.TopLeft = p;
                temp.Draw(g);
            }
        }

        public object Clone()
        {
            CComplex ComplexShapeTemp = new CComplex();

            ComplexShapeTemp.Nom = this.Nom;
            ComplexShapeTemp.PointAncrage = new Point(this.PointAncrage.X, this.PointAncrage.Y);

            foreach (IDrawable elem in ListeForme)
            {
                if (elem.GetType().Equals(typeof(CCircle)))
                {
                    CCircle c = (CCircle)elem.Clone();
                    ComplexShapeTemp.ListeForme.Add(c);
                }
                if (elem.GetType().Equals(typeof(CSquare)))
                {
                    CSquare c = (CSquare)elem.Clone();
                    ComplexShapeTemp.ListeForme.Add(c);
                }
                if (elem.GetType().Equals(typeof(CRectangle)))
                {
                    CRectangle r = (CRectangle)elem.Clone();
                    ComplexShapeTemp.ListeForme.Add(r);
                }
            }

            return ComplexShapeTemp;
        }

        #endregion
    }
}

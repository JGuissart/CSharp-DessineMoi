using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace DrawShapeLib
{
    public class CPicture : IDrawable
    {
        #region Variables Membres

        private int _Longueur;
        private int _Largeur;
        private Bitmap _Image;
        private Point _PointAncrage;
        private string _Nom;
        private float _Echelle;

        #endregion

        #region Constructeurs

        public CPicture()
        {
            Longueur = 0;
            Largeur = 0;
            Image = null;
            PointAncrage = new Point(0, 0);
            Nom = "default";
        }

        public CPicture(Bitmap img)
        {
            Image = img;
            Longueur = img.Size.Width;
            Largeur = img.Size.Height;
            PointAncrage = new Point(0, 0);
        }

        public CPicture( Bitmap img, int lon, int lar)
        {
            Longueur = lon;
            Largeur = lar;
            Image = img;
            PointAncrage = new Point(0, 0);
        }

        public CPicture(Bitmap img, Point pa, int lon, int lar, string n)
        {
            Longueur = lon;
            Largeur = lar;
            Image = img;
            PointAncrage = pa;
            Nom = n;
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

        public Bitmap Image
        {
            get { return _Image; }
            set { _Image = value; }
        }

        public Point PointAncrage
        {
            get { return _PointAncrage; }
            set { _PointAncrage = value; }
        }

        public Point TopLeft
        {
            get { return PointAncrage; }
            set { PointAncrage = value; }
        }

        public string Nom
        {
            get { return _Nom; }
            set { _Nom = value; }
        }

        public float Echelle
        {
            get { return _Echelle; }
            set { _Echelle = value; }
        }

        #endregion

        #region Méthodes

        public override string ToString()
        {
            return string.Format("Image: {0}\tLongueur: {1}\tLargeur: {2}\tPoint d'ancrage: {3}\tEchelle: {4}", Nom, Longueur, Image.Size.Height * Echelle, PointAncrage, Echelle);
        }

        public void Draw()
        {
            Console.WriteLine(this.ToString());
        }

        public void Draw(Graphics g)
        {
            Echelle = (float)Longueur / (float)Image.Size.Width;

            g.DrawImage(Image, PointAncrage.X, PointAncrage.Y, Longueur, Image.Size.Height * Echelle);
        }

        public object Clone()
        {
            CPicture imgTemp = new CPicture();
            imgTemp.Nom = this.Nom;
            Bitmap bitmapTemp = new Bitmap(this.Image);
            imgTemp.Image = bitmapTemp;
            imgTemp.Longueur = bitmapTemp.Size.Width;
            imgTemp.Largeur = bitmapTemp.Size.Height;            
            Point pAncrageTemp = new Point(this.PointAncrage.X, this.PointAncrage.Y);
            imgTemp.PointAncrage = pAncrageTemp;

            return imgTemp;
        }

        #endregion
    }
}

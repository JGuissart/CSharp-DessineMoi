using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DrawShapeLib;
using System.Drawing.Imaging;

namespace WinFormEtape02Test
{
    public partial class ComplexForm : Form
    {
        #region Variables Membres

        private Point _PositionMouseDown;
        private Point _PositionMouseUp;
        private Color _CouleurForme;
        private CComplex _ComplexeShapeTemp;
        private bool _Valide;
        private List<IDrawable> _ListeFormeSimple;
        private int _Forme;

        #endregion

        #region Propriétés

        public List<IDrawable> ListeFormeSimple
        {
            get { return _ListeFormeSimple; }
            set { _ListeFormeSimple = value; }
        }

        public bool Valide
        {
            get { return _Valide; }
            set { _Valide = value; }
        }

        public CComplex ComplexeShapeTemp
        {
            get { return _ComplexeShapeTemp; }
            set { _ComplexeShapeTemp = value; }
        }

        public Color CouleurForme
        {
            get { return _CouleurForme; }
            set { _CouleurForme = value; }
        }

        public Point PositionMouseUp
        {
            get { return _PositionMouseUp; }
            set { _PositionMouseUp = value; }
        }

        public int Forme
        {
            get { return _Forme; }
            set { _Forme = value; }
        }

        public Point PositionMouseDown
        {
            get { return _PositionMouseDown; }
            set { _PositionMouseDown = value; }
        }

        #endregion

        #region Constructeurs

        public ComplexForm()
        {
            InitializeComponent();
            pictureBox2.Image = new Bitmap(pictureBox2.Size.Width, pictureBox2.Size.Height, PixelFormat.Format24bppRgb);
            Graphics g = Graphics.FromImage(pictureBox2.Image);
            g.Clear(Color.White);
            g.Dispose();
            pictureBox2.Refresh();
            Forme = 0;
            CouleurForme = Color.Black;
            ListeFormeSimple = new List<IDrawable>();
        }

        #endregion

        #region Evenements Boutons

        private void btSquare_Click(object sender, EventArgs e)
        {
            Forme = 1;
            remplirPanelModele();
        }

        private void btRectangle_Click(object sender, EventArgs e)
        {
            Forme = 2;
            remplirPanelModele();
        }

        private void btCircle_Click(object sender, EventArgs e)
        {
            Forme = 3;
            remplirPanelModele();
        }

        private void btValider_Click(object sender, EventArgs e)
        {
            if (ListeFormeSimple.Count > 1)
            {
                Point PATempElem0 = ListeFormeSimple[0].TopLeft;

                int x = PATempElem0.X, y = PATempElem0.Y;

                for (int i = 1; i < ListeFormeSimple.Count; i++)
                {
                    if (x > ListeFormeSimple[i].TopLeft.X)
                        x = ListeFormeSimple[i].TopLeft.X;
                    if (y > ListeFormeSimple[i].TopLeft.Y)
                        y = ListeFormeSimple[i].TopLeft.Y;
                }

                foreach (IDrawable elem in ListeFormeSimple)
                {
                    Point p = elem.TopLeft;
                    p.X -= x;
                    p.Y -= y;
                    elem.TopLeft = p;
                }

                ComplexeShapeTemp = new CComplex(fldNomForme.Text, ListeFormeSimple, new Point(0, 0));

                Valide = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Vous ne pouvez pas valider une forme complexe ne comprenant qu'une forme simple ...");
                Valide = false;
            }
        }

        #endregion

        #region Evenements PictureBox

        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            PositionMouseDown = e.Location;
        }

        private void pictureBox2_MouseUp(object sender, MouseEventArgs e)
        {
            PositionMouseUp = e.Location;
            float TailleX = PositionMouseUp.X - PositionMouseDown.X;
            float TailleY = PositionMouseUp.Y - PositionMouseDown.Y;

            Point pAncrageTemp = new Point();

            if (PositionMouseDown.X < PositionMouseUp.X)
                pAncrageTemp.X = PositionMouseDown.X;
            else
                pAncrageTemp.X = PositionMouseUp.X;

            if (PositionMouseDown.Y < PositionMouseUp.Y)
                pAncrageTemp.Y = PositionMouseDown.Y;
            else
                pAncrageTemp.Y = PositionMouseUp.Y;

            TailleX = Math.Abs(TailleX);
            TailleY = Math.Abs(TailleY);

            Graphics g = Graphics.FromImage(pictureBox2.Image);

            if (Forme == 1) // Carré
            {
                if (checkBoxPlein.Checked)
                {
                    CSquare c = new CSquare((int)TailleX, pAncrageTemp, CouleurForme, true);
                    c.Draw(g);
                    ListeFormeSimple.Add(c);
                }
                else
                {
                    CSquare c = new CSquare((int)TailleX, pAncrageTemp, CouleurForme);
                    c.Draw(g);
                    ListeFormeSimple.Add(c);
                }
            }

            if (Forme == 2) // Rectangle
            {
                if (checkBoxPlein.Checked)
                {
                    CRectangle r = new CRectangle((int)TailleX, (int)TailleY, pAncrageTemp, CouleurForme, true);
                    r.Draw(g);
                    ListeFormeSimple.Add(r);
                }
                else
                {
                    CRectangle r = new CRectangle((int)TailleX, (int)TailleY, pAncrageTemp, CouleurForme);
                    r.Draw(g);
                    ListeFormeSimple.Add(r);
                }
            }

            if (Forme == 3) // Cercle
            {
                if (checkBoxPlein.Checked)
                {
                    CCircle c = new CCircle((int)TailleX, pAncrageTemp, CouleurForme, true);
                    c.Draw(g);
                    ListeFormeSimple.Add(c);
                }
                else
                {
                    CCircle c = new CCircle((int)TailleX, pAncrageTemp, CouleurForme);
                    c.Draw(g);
                    ListeFormeSimple.Add(c);
                }
            }

            g.Dispose();
            pictureBox2.Refresh();
        }

        #endregion

        #region Evenements Panel

        private void panelColor_Click(object sender, EventArgs e)
        {
            DialogResult ColorResult = colorDialog1.ShowDialog();

            if (ColorResult == DialogResult.OK)
            {
                CouleurForme = colorDialog1.Color;
                remplirPanelModele();
            }
        }

        #endregion

        #region Evenements CheckBox

        private void checkBoxPlein_CheckedChanged(object sender, EventArgs e)
        {
            remplirPanelModele();
        }

        #endregion

        #region Méthodes

        private void remplirPanelModele()
        {
            Graphics g = panelModele.CreateGraphics();
            if (Forme == 0) // Si on a pas cliqué sur une forme
            {
                g.FillRectangle(new SolidBrush(CouleurForme), 0, 0, 64, 64);
            }
            else
            {
                g.FillRectangle(new SolidBrush(Color.White), 0, 0, 64, 64);
                if (Forme == 1) // Carré
                {
                    if (checkBoxPlein.Checked)
                        g.FillRectangle(new SolidBrush(CouleurForme), 20, 16, 25, 25);
                    else
                        g.DrawRectangle(new Pen(CouleurForme), 20, 16, 25, 25);
                }

                if (Forme == 2) // Rectangle
                {
                    if (checkBoxPlein.Checked)
                        g.FillRectangle(new SolidBrush(CouleurForme), 20, 16, 35, 20);
                    else
                        g.DrawRectangle(new Pen(CouleurForme), 20, 16, 35, 20);
                }

                if (Forme == 3) // Cercle
                {
                    if (checkBoxPlein.Checked)
                        g.FillEllipse(new SolidBrush(CouleurForme), 20, 16, 25, 25);
                    else
                        g.DrawEllipse(new Pen(CouleurForme), 20, 16, 25, 25);
                }
            }
        }

        #endregion
    }
}

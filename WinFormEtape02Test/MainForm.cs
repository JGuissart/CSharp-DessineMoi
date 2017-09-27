using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using Microsoft.Win32;
using System.IO;
using DrawShapeLib;

namespace WinFormEtape02Test
{
    public partial class MainForm : Form
    {
        #region Variables Membres

        private Point _PositionMouseDown;
        private Point _PositionMouseUp;
        private Color _CouleurForme;
        private List<IDrawable> _ListeFormeSimple;
        private CComplex _FormeComplex;
        private Bitmap _ImagePicture;
        private string _NomImage;
        private bool _Dessine;
        private int _Forme;
        private RegistryKey _Reg;
        private Stack<IDrawable> _LIFOPrecendentSuivant;
        
        #endregion

        #region Propriétés

        public Bitmap ImagePicture
        {
            get { return _ImagePicture; }
            set { _ImagePicture = value; }
        }

        public CComplex FormeComplex
        {
            get { return _FormeComplex; }
            set { _FormeComplex = value; }
        }

        public bool Dessine
        {
            get { return _Dessine; }
            set { _Dessine = value; }
        }

        public List<IDrawable> ListeFormeSimple
        {
            get { return _ListeFormeSimple; }
            set { _ListeFormeSimple = value; }
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

        public RegistryKey Reg
        {
            get { return _Reg; }
            set { _Reg = value; }
        }

        public string NomImage
        {
            get { return _NomImage; }
            set { _NomImage = value; }
        }

        public Stack<IDrawable> LIFOPrecendentSuivant
        {
            get { return _LIFOPrecendentSuivant; }
            set { _LIFOPrecendentSuivant = value; }
        }

        #endregion

        #region Constructeurs

        public MainForm()
        {
            InitializeComponent();
            pictureBox1.Image = new Bitmap(pictureBox1.Size.Width, pictureBox1.Size.Height, PixelFormat.Format24bppRgb);
            pictureBoxImg.Image = new Bitmap(pictureBoxImg.Size.Width, pictureBoxImg.Size.Height, PixelFormat.Format24bppRgb);
            Graphics g = Graphics.FromImage(pictureBox1.Image);
            g.Clear(Color.White);
            g.Dispose();
            pictureBox1.Refresh();
            
            Graphics g2 = Graphics.FromImage(pictureBoxImg.Image);
            g2.Clear(Color.White);
            g2.Dispose();
            pictureBoxImg.Refresh();
            Forme = 0;
            CouleurForme = Color.Black;
            ListeFormeSimple = new List<IDrawable>();
            FormeComplex = new CComplex();
            chargementListeBoxImage();
        }

        #endregion

        #region Evenements Boutons

        private void btCarre_Click(object sender, EventArgs e)
        {
            CSquare c = new CSquare();

            if (comboBox1.SelectedItem != null) // Déselectionner l'objet actuellement sélectionné de la comboBox
                comboBox1.SelectedItem = null;

            if (listBox1.SelectedItem != null) // Déselectionner l'objet actuellement sélectionné de la listBox
                listBox1.SelectedItem = null;

            if (listBoxImage.SelectedItem != null) // Déselectionner l'objet actuellement sélectionné de la listBoxImage + rafraichir la pictureBoxImage
            {
                listBoxImage.SelectedItem = null;
                Graphics g = Graphics.FromImage(pictureBoxImg.Image);
                g.Clear(Color.White);
                g.Dispose();
                pictureBoxImg.Refresh();
            }

            propertyGridForm1.SelectedObject = c;

            Forme = 1;
            remplirPanelModele();
        }

        private void btRectangle_Click(object sender, EventArgs e)
        {
            CRectangle r = new CRectangle();

            if (comboBox1.SelectedItem != null) // Déselectionner l'objet actuellement sélectionné de la comboBox
                comboBox1.SelectedItem = null;

            if (listBox1.SelectedItem != null) // Déselectionner l'objet actuellement sélectionné de la listBox
                listBox1.SelectedItem = null;

            if (listBoxImage.SelectedItem != null) // Déselectionner l'objet actuellement sélectionné de la listBoxImage + rafraichir la pictureBoxImage
            {
                listBoxImage.SelectedItem = null;
                Graphics g = Graphics.FromImage(pictureBoxImg.Image);
                g.Clear(Color.White);
                g.Dispose();
                pictureBoxImg.Refresh();
            }

            propertyGridForm1.SelectedObject = r;

            Forme = 2;
            remplirPanelModele();
        }

        private void btCercle_Click(object sender, EventArgs e)
        {
            CCircle c = new CCircle();

            if (comboBox1.SelectedItem != null) // Déselectionner l'objet actuellement sélectionné de la comboBox
                comboBox1.SelectedItem = null;

            if (listBox1.SelectedItem != null) // Déselectionner l'objet actuellement sélectionné de la listBox
                listBox1.SelectedItem = null;

            if (listBoxImage.SelectedItem != null) // Déselectionner l'objet actuellement sélectionné de la listBoxImage + rafraichir la pictureBoxImage
            {
                listBoxImage.SelectedItem = null;
                Graphics g = Graphics.FromImage(pictureBoxImg.Image);
                g.Clear(Color.White);
                g.Dispose();
                pictureBoxImg.Refresh();
            }

            propertyGridForm1.SelectedObject = c;

            Forme = 3;
            remplirPanelModele();
        }

        private void btImage_Click(object sender, EventArgs e) // Ouverture d'un formulaire pour choisir une image
        {
            OpenFileDialog f = new OpenFileDialog();

            f.Filter = "(*.bmp, *.jpg)|*.bmp;*.jpg";

            if (f.ShowDialog() == DialogResult.OK)
            {
                ImagePicture = new Bitmap(f.FileName);
                CPicture i = new CPicture(ImagePicture);
                Forme = 4;
                listBoxImage.SelectedItem = null;
                listBoxImage.Items.Add(i);
                NomImage = Path.GetFileName(f.FileName);
                Reg.SetValue(NomImage, f.FileName);
            }
        }

        private void btSave_Click(object sender, EventArgs e) // Ouverture d'un formulaire pour sauvegarder la pictureBox
        {
            if (listBox1.Items.Count > 0)
            {
                SaveFileDialog s = new SaveFileDialog();
                s.Filter = "(*.bmp, *.jpg)|*.bmp;*.jpg";
                if (s.ShowDialog() == DialogResult.OK)
                    pictureBox1.Image.Save(s.FileName);
            }
        }

        private void btComplex_Click(object sender, EventArgs e)
        {
            ComplexForm FormComplex = new ComplexForm();
            FormComplex.ShowDialog();

            if (FormComplex.Valide)
            {
                comboBox1.Items.Add(FormComplex.ComplexeShapeTemp);
                FormeComplex = FormComplex.ComplexeShapeTemp;
            }
        }

        private void btClear_Click(object sender, EventArgs e) // Vide la pictureBox et la listBox
        {
            if (listBox1.Items.Count > 0)
            {
                Graphics g = Graphics.FromImage(pictureBox1.Image);
                Graphics g2 = Graphics.FromImage(pictureBoxImg.Image);
                listBox1.Items.Clear();
                propertyGridForm1.SelectedObject = null;
                listBoxImage.SelectedItem = null;
                g.Clear(Color.White);
                g.Dispose();
                pictureBox1.Refresh();
                g2.Clear(Color.White);
                g2.Dispose();
                pictureBoxImg.Refresh();
            }
        }

        private void btCarre_MouseHover(object sender, EventArgs e)
        {
            ToolTip TT = new ToolTip();
            TT.SetToolTip(this.btCarre, "Permet de dessiner une forme carré");
        }

        private void btRectangle_MouseHover(object sender, EventArgs e)
        {
            ToolTip TT = new ToolTip();
            TT.SetToolTip(this.btRectangle, "Permet de dessiner une forme rectangle");
        }

        private void btCercle_MouseHover(object sender, EventArgs e)
        {
            ToolTip TT = new ToolTip();
            TT.SetToolTip(this.btCercle, "Permet de dessiner un cercle");
        }

        private void btComplex_MouseHover(object sender, EventArgs e)
        {
            ToolTip TT = new ToolTip();
            TT.SetToolTip(this.btComplex, "Permet de dessiner une forme complexe.\nUne forme complexe est une association de formes simples");
        }

        private void btImage_MouseHover(object sender, EventArgs e)
        {
            ToolTip TT = new ToolTip();
            TT.SetToolTip(this.btImage, "Permet de dessiner une image sélectionnée au préalable");
        }

        private void btClear_MouseHover(object sender, EventArgs e)
        {
            ToolTip TT = new ToolTip();
            TT.SetToolTip(this.btClear, "Permet de vider la pictureBox ainsi que la listBox");
        }

        private void btSave_MouseHover(object sender, EventArgs e)
        {
            ToolTip TT = new ToolTip();
            TT.SetToolTip(this.btSave, "Permet de sauver la pictureBox sur disque");
        }

        private void btCreateUpdateShapePG_Click(object sender, EventArgs e)
        {
            if (propertyGridForm1.SelectedObject != null)
                listBox1.Items.Add(propertyGridForm1.SelectedObject);

            Graphics g = Graphics.FromImage(pictureBox1.Image);
            g.Clear(Color.White);

            foreach (IDrawable elem in listBox1.Items)
            {
                elem.Draw(g);
            }

            g.Dispose();
            pictureBox1.Refresh();
        }

        #endregion

        #region Evenements PictureBox

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                Forme = 0;
                List<IDrawable> lTemp = new List<IDrawable>();
                FormeComplex = (CComplex)comboBox1.SelectedItem;

                foreach (IDrawable elem in FormeComplex.ListeForme)
                {
                    lTemp.Add((IDrawable)elem.Clone());
                }

                FormeComplex.PointAncrage = e.Location;

                Graphics g = Graphics.FromImage(pictureBox1.Image);
                FormeComplex.Draw(g);
                g.Dispose();
                pictureBox1.Refresh();

                CComplex ComplexShapeTemp = new CComplex(FormeComplex.Nom, lTemp, FormeComplex.PointAncrage);
                listBox1.Items.Add(ComplexShapeTemp);
                Dessine = false;
            }
            else
            {
                PositionMouseDown = e.Location;
                Dessine = true;
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            PositionMouseUp = e.Location;
            Dessine = false;
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

            Graphics g = Graphics.FromImage(pictureBox1.Image);

            if (Forme == 1) // Carré
            {
                if (checkBoxPlein.Checked)
                {
                    CSquare c = new CSquare((int)TailleX, pAncrageTemp, CouleurForme, true);
                    c.Draw(g);
                    propertyGridForm1.SelectedObject = c;
                    listBox1.Items.Add(c);
                }
                else
                {
                    CSquare c = new CSquare((int)TailleX, pAncrageTemp, CouleurForme);
                    c.Draw(g);
                    propertyGridForm1.SelectedObject = c;
                    listBox1.Items.Add(c);
                }
            }

            if (Forme == 2) // Rectangle
            {
                if (checkBoxPlein.Checked)
                {
                    CRectangle r = new CRectangle((int)TailleX, (int)TailleY, pAncrageTemp, CouleurForme, true);
                    r.Draw(g);
                    propertyGridForm1.SelectedObject = r;
                    listBox1.Items.Add(r);
                }
                else
                {
                    CRectangle r = new CRectangle((int)TailleX, (int)TailleY, pAncrageTemp, CouleurForme);
                    r.Draw(g);
                    propertyGridForm1.SelectedObject = r;
                    listBox1.Items.Add(r);
                }
            }

            if (Forme == 3) // Cercle
            {
                if (checkBoxPlein.Checked)
                {
                    CCircle c = new CCircle((int)TailleX, pAncrageTemp, CouleurForme, true);
                    c.Draw(g);
                    propertyGridForm1.SelectedObject = c;
                    listBox1.Items.Add(c);
                }
                else
                {
                    CCircle c = new CCircle((int)TailleX, pAncrageTemp, CouleurForme);
                    c.Draw(g);
                    propertyGridForm1.SelectedObject = c;
                    listBox1.Items.Add(c);
                }
            }

            if (Forme == 4)
            {
                CPicture i = new CPicture(ImagePicture, pAncrageTemp, (int)TailleX, (int)TailleY, NomImage);
                i.Draw(g);
                propertyGridForm1.SelectedObject = i;
                listBox1.Items.Add(i);
            }

            if (listBoxImage.SelectedItem != null)
            {
                CPicture i = (CPicture)listBoxImage.SelectedItem;
                CPicture imgTemp = (CPicture)i.Clone();
                imgTemp.PointAncrage = pAncrageTemp;
                imgTemp.Longueur = (int)TailleX;
                imgTemp.Largeur = (int)TailleY;
                imgTemp.Draw(g);
                propertyGridForm1.SelectedObject = imgTemp;
                listBox1.Items.Add(imgTemp);
            }

            g.Dispose();
            pictureBox1.Refresh();
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            lbCoordTR.Text = e.Location.X.ToString() + ", " + e.Location.Y.ToString() + " px";

            if (Dessine)
            {
                PositionMouseUp = e.Location;
                pictureBox1.Refresh();
            }
        }

        #endregion

        #region Evenements ListBox

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e) // Se déroulera à chaque fois que l'on choisira un objet dans la listBox1
        {
            propertyGridForm1.SelectedObject = listBox1.SelectedItem;
        }

        private void listBoxImage_SelectedIndexChanged(object sender, EventArgs e) // Se déroulera à chaque fois que l'on choisira un objet dans la listBoxImage
        {
            CPicture img = (CPicture)listBoxImage.SelectedItem;
            if (img != null)
            {
                CPicture imgTemp = (CPicture)img.Clone();

                Graphics g = Graphics.FromImage(pictureBoxImg.Image);
                g.Clear(Color.White);

                if (imgTemp != null)
                {
                    Forme = 0;
                    comboBox1.SelectedItem = null;

                    float fEchelleTemp, fCoordTemp;

                    if (imgTemp.Longueur > imgTemp.Largeur)
                    {
                        fEchelleTemp = (float)imgTemp.Longueur / (float)pictureBoxImg.Size.Width;
                        fCoordTemp = (pictureBoxImg.Size.Height - (imgTemp.Largeur / fEchelleTemp)) / 2;

                        g.DrawImage(imgTemp.Image, 0, (int)fCoordTemp, pictureBoxImg.Size.Width, imgTemp.Largeur / fEchelleTemp);
                    }
                    else if (imgTemp.Longueur < imgTemp.Largeur)
                    {
                        fEchelleTemp = (float)imgTemp.Largeur / (float)pictureBoxImg.Size.Height;
                        fCoordTemp = (pictureBoxImg.Size.Width - (imgTemp.Longueur / fEchelleTemp)) / 2;

                        g.DrawImage(imgTemp.Image, (int)fCoordTemp, 0, imgTemp.Longueur / fEchelleTemp, pictureBoxImg.Size.Height);
                    }
                    else
                    {
                        if (imgTemp.Longueur >= pictureBoxImg.Size.Width)
                            g.DrawImage(imgTemp.Image, 0, 0, pictureBoxImg.Size.Width, pictureBoxImg.Size.Height);
                        else
                        {
                            fCoordTemp = pictureBoxImg.Size.Width - imgTemp.Longueur;

                            g.DrawImage(imgTemp.Image, fCoordTemp / 2, fCoordTemp / 2, imgTemp.Longueur, imgTemp.Largeur);
                        }
                    }
                }

                g.Dispose();
                pictureBoxImg.Refresh();
            }
        }

        #endregion

        #region Evenements MenuStrip

        private void nouveauToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count > 0)
            {
                DialogResult dial = MessageBox.Show("Voulez-vous enregistrer la picture box ?", "Dessine-moi", MessageBoxButtons.YesNo);

                if (dial == DialogResult.Yes)
                {
                    SaveFileDialog s = new SaveFileDialog();
                    s.Filter = "(*.bmp, *.jpg)|*.bmp;*.jpg";
                    if (s.ShowDialog() == DialogResult.OK)
                        pictureBox1.Image.Save(s.FileName);
                }
            }
            Graphics g = Graphics.FromImage(pictureBox1.Image);
            listBox1.Items.Clear();
            propertyGridForm1.SelectedObject = null;
            g.Clear(Color.White);
            g.Dispose();
            pictureBox1.Refresh();
        }

        private void enregistrerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog s = new SaveFileDialog();
            s.Filter = "(*.bmp, *.jpg)|*.bmp;*.jpg";
            if (s.ShowDialog() == DialogResult.OK)
                pictureBox1.Image.Save(s.FileName);
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Voulez-vous vraimer quitter l'application \"Dessine-moi\" ?", "Dessine-moi", MessageBoxButtons.YesNo);

            if (dialog == DialogResult.Yes)
            {
                if (listBox1.Items.Count == 0)
                    Application.Exit();
                else
                {
                    DialogResult dial = MessageBox.Show("Voulez-vous enregistrer la picture box ?", "Dessine-moi", MessageBoxButtons.YesNoCancel);
                    if (dial == DialogResult.Yes)
                    {
                        SaveFileDialog s = new SaveFileDialog();
                        s.Filter = "(*.bmp, *.jpg)|*.bmp;*.jpg";
                        if (s.ShowDialog() == DialogResult.OK)
                            pictureBox1.Image.Save(s.FileName);

                        Application.Exit();
                    }
                    if (dial == DialogResult.No)
                        Application.Exit();
                }
            }
        }

        #endregion

        #region Evenements CheckBox

        private void checkBoxPlein_Click(object sender, EventArgs e)
        {
            remplirPanelModele();
        }

        #endregion

        #region Evenements Form

        private void Close_Form1(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Voulez-vous vraimer quitter l'application \"Dessine-moi\" ?", "Dessine-moi", MessageBoxButtons.YesNo);

            if (dialog == DialogResult.Yes)
                Application.Exit();
            else
                e.Cancel = true;
        }

        #endregion

        #region Evenements PropertyGrid

        private void propertyGridForm1_PropertyValueChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                if (listBox1.SelectedItem != null && listBox1.SelectedItem.GetType().Equals(typeof(CCircle)))
                {
                    CCircle C = new CCircle();
                    C = (CCircle)propertyGridForm1.SelectedObject;
                    listBox1.Items.Remove(listBox1.SelectedItem);
                    //listBox1.Items.Add(C);
                    propertyGridForm1.SelectedObject = C;
                }

                if (listBox1.SelectedItem != null && listBox1.SelectedItem.GetType().Equals(typeof(CSquare)))
                {
                    CSquare C = new CSquare();
                    C = (CSquare)propertyGridForm1.SelectedObject;
                    listBox1.Items.Remove(listBox1.SelectedItem);
                    //listBox1.Items.Add(C);
                    propertyGridForm1.SelectedObject = C;
                }

                if (listBox1.SelectedItem != null && listBox1.SelectedItem.GetType().Equals(typeof(CRectangle)))
                {
                    CRectangle R = new CRectangle();
                    R = (CRectangle)propertyGridForm1.SelectedObject;
                    listBox1.Items.Remove(listBox1.SelectedItem);
                    //listBox1.Items.Add(R);
                    propertyGridForm1.SelectedObject = R;
                }

                if (listBox1.SelectedItem != null && listBox1.SelectedItem.GetType().Equals(typeof(CComplex)))
                {
                    CComplex C = new CComplex();
                    C = (CComplex)propertyGridForm1.SelectedObject;
                    listBox1.Items.Remove(listBox1.SelectedItem);
                    //listBox1.Items.Add(C);
                    propertyGridForm1.SelectedObject = C;
                }

                if (listBox1.SelectedItem != null && listBox1.SelectedItem.GetType().Equals(typeof(CPicture)))
                {
                    CPicture P = new CPicture();
                    P = (CPicture)propertyGridForm1.SelectedObject;
                    listBox1.Items.Remove(listBox1.SelectedItem);
                    //listBox1.Items.Add(P);
                    propertyGridForm1.SelectedObject = P;
                }
            }
        } 

        #endregion

        #region Evenements Panel

        private void panelModele_Click(object sender, EventArgs e) // Ouverture d'une colorDialog
        {
            DialogResult ColorResult = colorDialog1.ShowDialog();

            if (ColorResult == DialogResult.OK)
            {
                CouleurForme = colorDialog1.Color;
                remplirPanelModele();
            }
        }

        private void panelModele_MouseHover(object sender, EventArgs e)
        {
            ToolTip TT = new ToolTip();
            TT.SetToolTip(this.panelModele, "Cliquez pour choisir la couleur de la forme");
        }

        #endregion

        #region Evenements ComboBox

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Forme != 0 || listBox1.SelectedItem != null || listBoxImage.SelectedItem != null)
            {
                Forme = 0;
                listBoxImage.SelectedItem = null;
                listBox1.SelectedItem = null;
            }
        }

        #endregion

        #region Méthodes

        private void remplirPanelModele()
        {
            Graphics g = panelModele.CreateGraphics();
            if (Forme == 0) // Si on a pas cliqué sur une forme
            {
                g.FillRectangle(new SolidBrush(CouleurForme), 0, 0, panelModele.Size.Width, panelModele.Size.Height);
            }
            else
            {
                g.FillRectangle(new SolidBrush(Color.White), 0, 0, panelModele.Size.Width, panelModele.Size.Height);
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

                if (Forme == 4) // Image
                {
                    CPicture p = new CPicture(ImagePicture, new Point(20, 16), 20, 20, "Test");
                    p.Draw(g);
                }
            }
        }

        private void chargementListeBoxImage()
        {
            Reg = Registry.CurrentUser.OpenSubKey("Software", true);
            if (Reg.OpenSubKey("HEPL", true) == null)
                Reg.CreateSubKey("HEPL");
            Reg = Reg.OpenSubKey("HEPL", true);
            if (Reg.OpenSubKey("Dessine-moi", true) == null)
                Reg.CreateSubKey("Dessine-moi");
            Reg = Reg.OpenSubKey("Dessine-moi", true);
            if (Reg.OpenSubKey("DM Image Working Path", true) == null)
                Reg.CreateSubKey("DM Image Working Path");
            Reg = Reg.OpenSubKey("DM Image Working Path", true);

            if (Reg.ValueCount > 0)
            {
                string[] listeNoms = Reg.GetValueNames();
                string sPath;
                CPicture imgPic;
                Image imgChargee = null;

                foreach (string nomImage in listeNoms)
                {
                    sPath = (string)Reg.GetValue(nomImage);
                    if (File.Exists(sPath))
                    {
                        imgChargee = Image.FromFile(sPath);
                        imgPic = new CPicture((Bitmap)imgChargee.Clone(), new Point(0, 0), imgChargee.Size.Width, imgChargee.Size.Height, nomImage);
                        listBoxImage.Items.Add(imgPic);

                        imgChargee.Dispose();
                    }
                    else
                    {
                        MessageBox.Show("Le fichier \"" + nomImage + "\" n'existe plus ...\n" +
                                        "Celui-ci a peut-être été renommé ou supprimé ...\n" +
                                        "(Ancien emplacement: " + sPath);
                        Reg.DeleteValue(nomImage);
                    }
                }
            }
        }

        #endregion
    }
}

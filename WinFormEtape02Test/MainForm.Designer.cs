namespace WinFormEtape02Test
{
    partial class MainForm
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

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.btCarre = new System.Windows.Forms.Button();
            this.btRectangle = new System.Windows.Forms.Button();
            this.btCercle = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelModele = new System.Windows.Forms.Panel();
            this.checkBoxPlein = new System.Windows.Forms.CheckBox();
            this.btClear = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.propertyGridForm1 = new System.Windows.Forms.PropertyGrid();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btComplex = new System.Windows.Forms.Button();
            this.btImage = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lbCoordTR = new System.Windows.Forms.Label();
            this.btSave = new System.Windows.Forms.Button();
            this.btCreateUpdateShapePG = new System.Windows.Forms.Button();
            this.listBoxImage = new System.Windows.Forms.ListBox();
            this.pictureBoxImg = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nouveauToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enregistrerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbTitreComboBox = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImg)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btCarre
            // 
            this.btCarre.Location = new System.Drawing.Point(12, 97);
            this.btCarre.Name = "btCarre";
            this.btCarre.Size = new System.Drawing.Size(75, 23);
            this.btCarre.TabIndex = 1;
            this.btCarre.Text = "Carré";
            this.btCarre.UseVisualStyleBackColor = true;
            this.btCarre.Click += new System.EventHandler(this.btCarre_Click);
            this.btCarre.MouseHover += new System.EventHandler(this.btCarre_MouseHover);
            // 
            // btRectangle
            // 
            this.btRectangle.Location = new System.Drawing.Point(12, 126);
            this.btRectangle.Name = "btRectangle";
            this.btRectangle.Size = new System.Drawing.Size(75, 23);
            this.btRectangle.TabIndex = 2;
            this.btRectangle.Text = "Rectangle";
            this.btRectangle.UseVisualStyleBackColor = true;
            this.btRectangle.Click += new System.EventHandler(this.btRectangle_Click);
            this.btRectangle.MouseHover += new System.EventHandler(this.btRectangle_MouseHover);
            // 
            // btCercle
            // 
            this.btCercle.Location = new System.Drawing.Point(12, 155);
            this.btCercle.Name = "btCercle";
            this.btCercle.Size = new System.Drawing.Size(75, 23);
            this.btCercle.TabIndex = 3;
            this.btCercle.Text = "Cercle";
            this.btCercle.UseVisualStyleBackColor = true;
            this.btCercle.Click += new System.EventHandler(this.btCercle_Click);
            this.btCercle.MouseHover += new System.EventHandler(this.btCercle_MouseHover);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Cross;
            this.pictureBox1.Location = new System.Drawing.Point(185, 72);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(825, 364);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // panelModele
            // 
            this.panelModele.BackColor = System.Drawing.Color.White;
            this.panelModele.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelModele.Location = new System.Drawing.Point(12, 27);
            this.panelModele.Name = "panelModele";
            this.panelModele.Size = new System.Drawing.Size(75, 64);
            this.panelModele.TabIndex = 5;
            this.panelModele.Click += new System.EventHandler(this.panelModele_Click);
            this.panelModele.MouseHover += new System.EventHandler(this.panelModele_MouseHover);
            // 
            // checkBoxPlein
            // 
            this.checkBoxPlein.AutoSize = true;
            this.checkBoxPlein.Location = new System.Drawing.Point(93, 27);
            this.checkBoxPlein.Name = "checkBoxPlein";
            this.checkBoxPlein.Size = new System.Drawing.Size(61, 17);
            this.checkBoxPlein.TabIndex = 14;
            this.checkBoxPlein.Text = "Remplir";
            this.checkBoxPlein.UseVisualStyleBackColor = true;
            this.checkBoxPlein.Click += new System.EventHandler(this.checkBoxPlein_Click);
            // 
            // btClear
            // 
            this.btClear.Location = new System.Drawing.Point(1016, 43);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(160, 23);
            this.btClear.TabIndex = 15;
            this.btClear.Text = "Vider la pictureBox principale";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            this.btClear.MouseHover += new System.EventHandler(this.btClear_MouseHover);
            // 
            // propertyGridForm1
            // 
            this.propertyGridForm1.Location = new System.Drawing.Point(11, 184);
            this.propertyGridForm1.Name = "propertyGridForm1";
            this.propertyGridForm1.Size = new System.Drawing.Size(168, 268);
            this.propertyGridForm1.TabIndex = 17;
            this.propertyGridForm1.PropertyValueChanged += new System.Windows.Forms.PropertyValueChangedEventHandler(this.propertyGridForm1_PropertyValueChanged);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(186, 442);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(990, 134);
            this.listBox1.TabIndex = 18;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btComplex
            // 
            this.btComplex.Location = new System.Drawing.Point(93, 97);
            this.btComplex.Name = "btComplex";
            this.btComplex.Size = new System.Drawing.Size(75, 23);
            this.btComplex.TabIndex = 19;
            this.btComplex.Text = "Complexe";
            this.btComplex.UseVisualStyleBackColor = true;
            this.btComplex.Click += new System.EventHandler(this.btComplex_Click);
            this.btComplex.MouseHover += new System.EventHandler(this.btComplex_MouseHover);
            // 
            // btImage
            // 
            this.btImage.Location = new System.Drawing.Point(93, 126);
            this.btImage.Name = "btImage";
            this.btImage.Size = new System.Drawing.Size(75, 23);
            this.btImage.TabIndex = 20;
            this.btImage.Text = "Image";
            this.btImage.UseVisualStyleBackColor = true;
            this.btImage.Click += new System.EventHandler(this.btImage_Click);
            this.btImage.MouseHover += new System.EventHandler(this.btImage_MouseHover);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(291, 27);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(253, 21);
            this.comboBox1.TabIndex = 22;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lbCoordTR
            // 
            this.lbCoordTR.AutoSize = true;
            this.lbCoordTR.Location = new System.Drawing.Point(12, 533);
            this.lbCoordTR.Name = "lbCoordTR";
            this.lbCoordTR.Size = new System.Drawing.Size(0, 13);
            this.lbCoordTR.TabIndex = 23;
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(935, 43);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(75, 23);
            this.btSave.TabIndex = 24;
            this.btSave.Text = "Sauver";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            this.btSave.MouseHover += new System.EventHandler(this.btSave_MouseHover);
            // 
            // btCreateUpdateShapePG
            // 
            this.btCreateUpdateShapePG.Location = new System.Drawing.Point(11, 458);
            this.btCreateUpdateShapePG.Name = "btCreateUpdateShapePG";
            this.btCreateUpdateShapePG.Size = new System.Drawing.Size(168, 23);
            this.btCreateUpdateShapePG.TabIndex = 25;
            this.btCreateUpdateShapePG.Text = "Créer / afficher les modifications";
            this.btCreateUpdateShapePG.UseVisualStyleBackColor = true;
            this.btCreateUpdateShapePG.Click += new System.EventHandler(this.btCreateUpdateShapePG_Click);
            // 
            // listBoxImage
            // 
            this.listBoxImage.FormattingEnabled = true;
            this.listBoxImage.Location = new System.Drawing.Point(1018, 72);
            this.listBoxImage.Name = "listBoxImage";
            this.listBoxImage.Size = new System.Drawing.Size(158, 199);
            this.listBoxImage.TabIndex = 26;
            this.listBoxImage.SelectedIndexChanged += new System.EventHandler(this.listBoxImage_SelectedIndexChanged);
            // 
            // pictureBoxImg
            // 
            this.pictureBoxImg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxImg.Location = new System.Drawing.Point(1018, 278);
            this.pictureBoxImg.Name = "pictureBoxImg";
            this.pictureBoxImg.Size = new System.Drawing.Size(158, 158);
            this.pictureBoxImg.TabIndex = 27;
            this.pictureBoxImg.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1188, 24);
            this.menuStrip1.TabIndex = 28;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nouveauToolStripMenuItem,
            this.enregistrerToolStripMenuItem,
            this.quitterToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // nouveauToolStripMenuItem
            // 
            this.nouveauToolStripMenuItem.Name = "nouveauToolStripMenuItem";
            this.nouveauToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.nouveauToolStripMenuItem.Text = "Nouveau";
            this.nouveauToolStripMenuItem.Click += new System.EventHandler(this.nouveauToolStripMenuItem_Click);
            // 
            // enregistrerToolStripMenuItem
            // 
            this.enregistrerToolStripMenuItem.Name = "enregistrerToolStripMenuItem";
            this.enregistrerToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.enregistrerToolStripMenuItem.Text = "Enregistrer";
            this.enregistrerToolStripMenuItem.Click += new System.EventHandler(this.enregistrerToolStripMenuItem_Click);
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // lbTitreComboBox
            // 
            this.lbTitreComboBox.AutoSize = true;
            this.lbTitreComboBox.Location = new System.Drawing.Point(185, 27);
            this.lbTitreComboBox.Name = "lbTitreComboBox";
            this.lbTitreComboBox.Size = new System.Drawing.Size(100, 13);
            this.lbTitreComboBox.TabIndex = 29;
            this.lbTitreComboBox.Text = "Formes complexes: ";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1188, 588);
            this.Controls.Add(this.lbTitreComboBox);
            this.Controls.Add(this.pictureBoxImg);
            this.Controls.Add(this.listBoxImage);
            this.Controls.Add(this.btCreateUpdateShapePG);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.lbCoordTR);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btImage);
            this.Controls.Add(this.btComplex);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.propertyGridForm1);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.checkBoxPlein);
            this.Controls.Add(this.panelModele);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btCercle);
            this.Controls.Add(this.btRectangle);
            this.Controls.Add(this.btCarre);
            this.Controls.Add(this.menuStrip1);
            this.HelpButton = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Dessine-moi";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Close_Form1);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImg)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btCarre;
        private System.Windows.Forms.Button btRectangle;
        private System.Windows.Forms.Button btCercle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelModele;
        private System.Windows.Forms.CheckBox checkBoxPlein;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.PropertyGrid propertyGridForm1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btComplex;
        private System.Windows.Forms.Button btImage;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lbCoordTR;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btCreateUpdateShapePG;
        private System.Windows.Forms.ListBox listBoxImage;
        private System.Windows.Forms.PictureBox pictureBoxImg;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nouveauToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enregistrerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.Label lbTitreComboBox;
    }
}


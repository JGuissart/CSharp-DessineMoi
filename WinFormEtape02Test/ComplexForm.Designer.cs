namespace WinFormEtape02Test
{
    partial class ComplexForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelModele = new System.Windows.Forms.Panel();
            this.btSquare = new System.Windows.Forms.Button();
            this.btRectangle = new System.Windows.Forms.Button();
            this.btCircle = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.checkBoxPlein = new System.Windows.Forms.CheckBox();
            this.btValider = new System.Windows.Forms.Button();
            this.fldNomForme = new System.Windows.Forms.TextBox();
            this.lbNomForme = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelModele
            // 
            this.panelModele.BackColor = System.Drawing.Color.White;
            this.panelModele.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelModele.Location = new System.Drawing.Point(12, 12);
            this.panelModele.Name = "panelModele";
            this.panelModele.Size = new System.Drawing.Size(64, 64);
            this.panelModele.TabIndex = 0;
            this.panelModele.Click += new System.EventHandler(this.panelColor_Click);
            // 
            // btSquare
            // 
            this.btSquare.Location = new System.Drawing.Point(89, 12);
            this.btSquare.Name = "btSquare";
            this.btSquare.Size = new System.Drawing.Size(64, 23);
            this.btSquare.TabIndex = 1;
            this.btSquare.Text = "Carré";
            this.btSquare.UseVisualStyleBackColor = true;
            this.btSquare.Click += new System.EventHandler(this.btSquare_Click);
            // 
            // btRectangle
            // 
            this.btRectangle.Location = new System.Drawing.Point(159, 12);
            this.btRectangle.Name = "btRectangle";
            this.btRectangle.Size = new System.Drawing.Size(64, 23);
            this.btRectangle.TabIndex = 2;
            this.btRectangle.Text = "Rectangle";
            this.btRectangle.UseVisualStyleBackColor = true;
            this.btRectangle.Click += new System.EventHandler(this.btRectangle_Click);
            // 
            // btCircle
            // 
            this.btCircle.Location = new System.Drawing.Point(229, 12);
            this.btCircle.Name = "btCircle";
            this.btCircle.Size = new System.Drawing.Size(64, 23);
            this.btCircle.TabIndex = 3;
            this.btCircle.Text = "Cercle";
            this.btCircle.UseVisualStyleBackColor = true;
            this.btCircle.Click += new System.EventHandler(this.btCircle_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(12, 82);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(388, 364);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseDown);
            this.pictureBox2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseUp);
            // 
            // checkBoxPlein
            // 
            this.checkBoxPlein.AutoSize = true;
            this.checkBoxPlein.Location = new System.Drawing.Point(299, 18);
            this.checkBoxPlein.Name = "checkBoxPlein";
            this.checkBoxPlein.Size = new System.Drawing.Size(101, 17);
            this.checkBoxPlein.TabIndex = 5;
            this.checkBoxPlein.Text = "Remplir la forme";
            this.checkBoxPlein.UseVisualStyleBackColor = true;
            this.checkBoxPlein.CheckedChanged += new System.EventHandler(this.checkBoxPlein_CheckedChanged);
            // 
            // btValider
            // 
            this.btValider.Location = new System.Drawing.Point(406, 12);
            this.btValider.Name = "btValider";
            this.btValider.Size = new System.Drawing.Size(105, 434);
            this.btValider.TabIndex = 21;
            this.btValider.Text = "Valider";
            this.btValider.UseVisualStyleBackColor = true;
            this.btValider.Click += new System.EventHandler(this.btValider_Click);
            // 
            // fldNomForme
            // 
            this.fldNomForme.Location = new System.Drawing.Point(194, 56);
            this.fldNomForme.Name = "fldNomForme";
            this.fldNomForme.Size = new System.Drawing.Size(206, 20);
            this.fldNomForme.TabIndex = 22;
            // 
            // lbNomForme
            // 
            this.lbNomForme.AutoSize = true;
            this.lbNomForme.Location = new System.Drawing.Point(104, 59);
            this.lbNomForme.Name = "lbNomForme";
            this.lbNomForme.Size = new System.Drawing.Size(84, 13);
            this.lbNomForme.TabIndex = 23;
            this.lbNomForme.Text = "Nom de la forme";
            // 
            // ComplexForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 465);
            this.Controls.Add(this.lbNomForme);
            this.Controls.Add(this.fldNomForme);
            this.Controls.Add(this.btValider);
            this.Controls.Add(this.checkBoxPlein);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btCircle);
            this.Controls.Add(this.btRectangle);
            this.Controls.Add(this.btSquare);
            this.Controls.Add(this.panelModele);
            this.Name = "ComplexForm";
            this.Text = "FormComplexShape";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelModele;
        private System.Windows.Forms.Button btSquare;
        private System.Windows.Forms.Button btRectangle;
        private System.Windows.Forms.Button btCircle;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.CheckBox checkBoxPlein;
        private System.Windows.Forms.Button btValider;
        private System.Windows.Forms.TextBox fldNomForme;
        private System.Windows.Forms.Label lbNomForme;
    }
}
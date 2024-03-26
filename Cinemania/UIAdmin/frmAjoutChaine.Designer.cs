namespace UIAdmin
{
    partial class frmAjoutChaine
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
            this.txtNomChaine = new System.Windows.Forms.TextBox();
            this.lblNomChaine = new System.Windows.Forms.Label();
            this.labelTitre = new System.Windows.Forms.Label();
            this.lblCinema = new System.Windows.Forms.Label();
            this.txtNomCinema = new System.Windows.Forms.TextBox();
            this.txtAdresse = new System.Windows.Forms.TextBox();
            this.lblAdresse = new System.Windows.Forms.Label();
            this.grpCine = new System.Windows.Forms.GroupBox();
            this.grpSalle = new System.Windows.Forms.GroupBox();
            this.lblPlacesParRangee = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelNumSalle = new System.Windows.Forms.Label();
            this.cmbQteRangees = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbNbrPlace = new System.Windows.Forms.ComboBox();
            this.btCancel = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.grpCine.SuspendLayout();
            this.grpSalle.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNomChaine
            // 
            this.txtNomChaine.Location = new System.Drawing.Point(272, 99);
            this.txtNomChaine.Name = "txtNomChaine";
            this.txtNomChaine.Size = new System.Drawing.Size(183, 27);
            this.txtNomChaine.TabIndex = 0;
            // 
            // lblNomChaine
            // 
            this.lblNomChaine.AutoSize = true;
            this.lblNomChaine.Location = new System.Drawing.Point(134, 102);
            this.lblNomChaine.Name = "lblNomChaine";
            this.lblNomChaine.Size = new System.Drawing.Size(105, 20);
            this.lblNomChaine.TabIndex = 1;
            this.lblNomChaine.Text = "Nom Chaine  *";
            // 
            // labelTitre
            // 
            this.labelTitre.AutoSize = true;
            this.labelTitre.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTitre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.labelTitre.Location = new System.Drawing.Point(106, 28);
            this.labelTitre.Name = "labelTitre";
            this.labelTitre.Size = new System.Drawing.Size(407, 38);
            this.labelTitre.TabIndex = 2;
            this.labelTitre.Text = "Ajout d\'une chaine de cinéma";
            // 
            // lblCinema
            // 
            this.lblCinema.AutoSize = true;
            this.lblCinema.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCinema.ForeColor = System.Drawing.Color.Black;
            this.lblCinema.Location = new System.Drawing.Point(43, 51);
            this.lblCinema.Name = "lblCinema";
            this.lblCinema.Size = new System.Drawing.Size(110, 20);
            this.lblCinema.TabIndex = 3;
            this.lblCinema.Text = "Nom Cinéma  *";
            // 
            // txtNomCinema
            // 
            this.txtNomCinema.Location = new System.Drawing.Point(183, 46);
            this.txtNomCinema.Name = "txtNomCinema";
            this.txtNomCinema.Size = new System.Drawing.Size(173, 30);
            this.txtNomCinema.TabIndex = 4;
            // 
            // txtAdresse
            // 
            this.txtAdresse.Location = new System.Drawing.Point(699, 51);
            this.txtAdresse.Name = "txtAdresse";
            this.txtAdresse.Size = new System.Drawing.Size(310, 30);
            this.txtAdresse.TabIndex = 6;
            // 
            // lblAdresse
            // 
            this.lblAdresse.AutoSize = true;
            this.lblAdresse.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAdresse.ForeColor = System.Drawing.Color.Black;
            this.lblAdresse.Location = new System.Drawing.Point(549, 56);
            this.lblAdresse.Name = "lblAdresse";
            this.lblAdresse.Size = new System.Drawing.Size(115, 20);
            this.lblAdresse.TabIndex = 5;
            this.lblAdresse.Text = "Adresse Cinéma";
            // 
            // grpCine
            // 
            this.grpCine.BackColor = System.Drawing.Color.Snow;
            this.grpCine.Controls.Add(this.grpSalle);
            this.grpCine.Controls.Add(this.txtAdresse);
            this.grpCine.Controls.Add(this.lblAdresse);
            this.grpCine.Controls.Add(this.txtNomCinema);
            this.grpCine.Controls.Add(this.lblCinema);
            this.grpCine.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grpCine.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.grpCine.Location = new System.Drawing.Point(106, 147);
            this.grpCine.Name = "grpCine";
            this.grpCine.Size = new System.Drawing.Size(1063, 355);
            this.grpCine.TabIndex = 7;
            this.grpCine.TabStop = false;
            this.grpCine.Text = "Enregistrement d\'un cinema";
            // 
            // grpSalle
            // 
            this.grpSalle.BackColor = System.Drawing.Color.SeaShell;
            this.grpSalle.Controls.Add(this.lblPlacesParRangee);
            this.grpSalle.Controls.Add(this.label3);
            this.grpSalle.Controls.Add(this.labelNumSalle);
            this.grpSalle.Controls.Add(this.cmbQteRangees);
            this.grpSalle.Controls.Add(this.label5);
            this.grpSalle.Controls.Add(this.label4);
            this.grpSalle.Controls.Add(this.cmbNbrPlace);
            this.grpSalle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.grpSalle.Location = new System.Drawing.Point(176, 116);
            this.grpSalle.Name = "grpSalle";
            this.grpSalle.Size = new System.Drawing.Size(645, 196);
            this.grpSalle.TabIndex = 23;
            this.grpSalle.TabStop = false;
            this.grpSalle.Text = "Enregistrement d\'une salle du cinema";
            // 
            // lblPlacesParRangee
            // 
            this.lblPlacesParRangee.AutoSize = true;
            this.lblPlacesParRangee.Location = new System.Drawing.Point(28, 149);
            this.lblPlacesParRangee.Name = "lblPlacesParRangee";
            this.lblPlacesParRangee.Size = new System.Drawing.Size(0, 23);
            this.lblPlacesParRangee.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(27, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "Numero de salle :";
            // 
            // labelNumSalle
            // 
            this.labelNumSalle.AutoSize = true;
            this.labelNumSalle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelNumSalle.ForeColor = System.Drawing.Color.Red;
            this.labelNumSalle.Location = new System.Drawing.Point(168, 55);
            this.labelNumSalle.Name = "labelNumSalle";
            this.labelNumSalle.Size = new System.Drawing.Size(20, 23);
            this.labelNumSalle.TabIndex = 22;
            this.labelNumSalle.Text = "1";
            // 
            // cmbQteRangees
            // 
            this.cmbQteRangees.FormattingEnabled = true;
            this.cmbQteRangees.Location = new System.Drawing.Point(168, 109);
            this.cmbQteRangees.Name = "cmbQteRangees";
            this.cmbQteRangees.Size = new System.Drawing.Size(54, 31);
            this.cmbQteRangees.TabIndex = 18;
            this.cmbQteRangees.SelectedIndexChanged += new System.EventHandler(this.cmbQteRangees_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(343, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 20);
            this.label5.TabIndex = 21;
            this.label5.Text = "Nombre de places  *";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(7, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "Nombre de rangées  *";
            // 
            // cmbNbrPlace
            // 
            this.cmbNbrPlace.FormattingEnabled = true;
            this.cmbNbrPlace.Location = new System.Drawing.Point(523, 107);
            this.cmbNbrPlace.Name = "cmbNbrPlace";
            this.cmbNbrPlace.Size = new System.Drawing.Size(57, 31);
            this.cmbNbrPlace.TabIndex = 20;
            this.cmbNbrPlace.SelectedIndexChanged += new System.EventHandler(this.cmbNbrPlace_SelectedIndexChanged);
            // 
            // btCancel
            // 
            this.btCancel.BackColor = System.Drawing.Color.Snow;
            this.btCancel.Location = new System.Drawing.Point(706, 521);
            this.btCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(206, 40);
            this.btCancel.TabIndex = 9;
            this.btCancel.Text = "Annuler";
            this.btCancel.UseVisualStyleBackColor = false;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btSave
            // 
            this.btSave.BackColor = System.Drawing.Color.Snow;
            this.btSave.Location = new System.Drawing.Point(267, 520);
            this.btSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(197, 41);
            this.btSave.TabIndex = 8;
            this.btSave.Text = "Ajouter Chaine de cinema";
            this.btSave.UseVisualStyleBackColor = false;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // frmAjoutChaine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(1205, 590);
            this.ControlBox = false;
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.grpCine);
            this.Controls.Add(this.labelTitre);
            this.Controls.Add(this.lblNomChaine);
            this.Controls.Add(this.txtNomChaine);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmAjoutChaine";
            this.Text = "Ajouter chaine de cinéma";
            this.grpCine.ResumeLayout(false);
            this.grpCine.PerformLayout();
            this.grpSalle.ResumeLayout(false);
            this.grpSalle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtNomChaine;
        private Label lblNomChaine;
        private Label labelTitre;
        private Label lblCinema;
        private TextBox txtNomCinema;
        private TextBox txtAdresse;
        private Label lblAdresse;
        private GroupBox grpCine;
        private GroupBox grpSalle;
        private Label label3;
        private Label labelNumSalle;
        private ComboBox cmbQteRangees;
        private Label label5;
        private Label label4;
        private ComboBox cmbNbrPlace;
        private Label lblPlacesParRangee;
        private Button btCancel;
        private Button btSave;
    }
}
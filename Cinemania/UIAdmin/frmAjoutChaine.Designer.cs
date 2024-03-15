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
            this.txtCinema = new System.Windows.Forms.Label();
            this.txtNomCinema = new System.Windows.Forms.TextBox();
            this.txtAdresse = new System.Windows.Forms.TextBox();
            this.labelAdresse = new System.Windows.Forms.Label();
            this.grpCine = new System.Windows.Forms.GroupBox();
            this.grpSalle = new System.Windows.Forms.GroupBox();
            this.labelPlacesRangees = new System.Windows.Forms.Label();
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
            this.txtNomChaine.Location = new System.Drawing.Point(251, 115);
            this.txtNomChaine.Name = "txtNomChaine";
            this.txtNomChaine.Size = new System.Drawing.Size(183, 27);
            this.txtNomChaine.TabIndex = 0;
            // 
            // lblNomChaine
            // 
            this.lblNomChaine.AutoSize = true;
            this.lblNomChaine.Location = new System.Drawing.Point(108, 118);
            this.lblNomChaine.Name = "lblNomChaine";
            this.lblNomChaine.Size = new System.Drawing.Size(91, 20);
            this.lblNomChaine.TabIndex = 1;
            this.lblNomChaine.Text = "Nom Chaine";
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
            // txtCinema
            // 
            this.txtCinema.AutoSize = true;
            this.txtCinema.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCinema.ForeColor = System.Drawing.Color.Black;
            this.txtCinema.Location = new System.Drawing.Point(41, 61);
            this.txtCinema.Name = "txtCinema";
            this.txtCinema.Size = new System.Drawing.Size(96, 20);
            this.txtCinema.TabIndex = 3;
            this.txtCinema.Text = "Nom Cinéma";
            // 
            // txtNomCinema
            // 
            this.txtNomCinema.Location = new System.Drawing.Point(176, 54);
            this.txtNomCinema.Name = "txtNomCinema";
            this.txtNomCinema.Size = new System.Drawing.Size(173, 30);
            this.txtNomCinema.TabIndex = 4;
            // 
            // txtAdresse
            // 
            this.txtAdresse.Location = new System.Drawing.Point(655, 58);
            this.txtAdresse.Name = "txtAdresse";
            this.txtAdresse.Size = new System.Drawing.Size(310, 30);
            this.txtAdresse.TabIndex = 6;
            // 
            // labelAdresse
            // 
            this.labelAdresse.AutoSize = true;
            this.labelAdresse.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelAdresse.ForeColor = System.Drawing.Color.Black;
            this.labelAdresse.Location = new System.Drawing.Point(506, 61);
            this.labelAdresse.Name = "labelAdresse";
            this.labelAdresse.Size = new System.Drawing.Size(115, 20);
            this.labelAdresse.TabIndex = 5;
            this.labelAdresse.Text = "Adresse Cinéma";
            // 
            // grpCine
            // 
            this.grpCine.BackColor = System.Drawing.Color.Snow;
            this.grpCine.Controls.Add(this.grpSalle);
            this.grpCine.Controls.Add(this.txtAdresse);
            this.grpCine.Controls.Add(this.labelAdresse);
            this.grpCine.Controls.Add(this.txtNomCinema);
            this.grpCine.Controls.Add(this.txtCinema);
            this.grpCine.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grpCine.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.grpCine.Location = new System.Drawing.Point(63, 190);
            this.grpCine.Name = "grpCine";
            this.grpCine.Size = new System.Drawing.Size(1107, 363);
            this.grpCine.TabIndex = 7;
            this.grpCine.TabStop = false;
            this.grpCine.Text = "Enregistrement d\'un cinema";
            // 
            // grpSalle
            // 
            this.grpSalle.BackColor = System.Drawing.Color.SeaShell;
            this.grpSalle.Controls.Add(this.labelPlacesRangees);
            this.grpSalle.Controls.Add(this.label3);
            this.grpSalle.Controls.Add(this.labelNumSalle);
            this.grpSalle.Controls.Add(this.cmbQteRangees);
            this.grpSalle.Controls.Add(this.label5);
            this.grpSalle.Controls.Add(this.label4);
            this.grpSalle.Controls.Add(this.cmbNbrPlace);
            this.grpSalle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.grpSalle.Location = new System.Drawing.Point(161, 116);
            this.grpSalle.Name = "grpSalle";
            this.grpSalle.Size = new System.Drawing.Size(707, 210);
            this.grpSalle.TabIndex = 23;
            this.grpSalle.TabStop = false;
            this.grpSalle.Text = "Enregistrement d\'une salle du cinema";
            // 
            // labelPlacesRangees
            // 
            this.labelPlacesRangees.AutoSize = true;
            this.labelPlacesRangees.Location = new System.Drawing.Point(45, 168);
            this.labelPlacesRangees.Name = "labelPlacesRangees";
            this.labelPlacesRangees.Size = new System.Drawing.Size(0, 23);
            this.labelPlacesRangees.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(28, 55);
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
            this.cmbQteRangees.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmbQteRangees.FormattingEnabled = true;
            this.cmbQteRangees.Location = new System.Drawing.Point(168, 109);
            this.cmbQteRangees.Name = "cmbQteRangees";
            this.cmbQteRangees.Size = new System.Drawing.Size(84, 31);
            this.cmbQteRangees.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(343, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 20);
            this.label5.TabIndex = 21;
            this.label5.Text = "Nombre de places";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(7, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "Nombre de rangées";
            // 
            // cmbNbrPlace
            // 
            this.cmbNbrPlace.FormattingEnabled = true;
            this.cmbNbrPlace.Location = new System.Drawing.Point(523, 107);
            this.cmbNbrPlace.Name = "cmbNbrPlace";
            this.cmbNbrPlace.Size = new System.Drawing.Size(117, 31);
            this.cmbNbrPlace.TabIndex = 20;
            // 
            // btCancel
            // 
            this.btCancel.BackColor = System.Drawing.Color.Snow;
            this.btCancel.Location = new System.Drawing.Point(640, 572);
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
            this.btSave.Location = new System.Drawing.Point(295, 572);
            this.btSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(197, 41);
            this.btSave.TabIndex = 8;
            this.btSave.Text = "Ajouter Chaine de cinema";
            this.btSave.UseVisualStyleBackColor = false;
            // 
            // frmAjoutChaine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(1241, 650);
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
        private Label txtCinema;
        private TextBox txtNomCinema;
        private TextBox txtAdresse;
        private Label labelAdresse;
        private GroupBox grpCine;
        private GroupBox grpSalle;
        private Label label3;
        private Label labelNumSalle;
        private ComboBox cmbQteRangees;
        private Label label5;
        private Label label4;
        private ComboBox cmbNbrPlace;
        private Label labelPlacesRangees;
        private Button btCancel;
        private Button btSave;
    }
}
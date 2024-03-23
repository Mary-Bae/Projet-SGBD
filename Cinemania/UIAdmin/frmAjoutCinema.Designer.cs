namespace UIAdmin
{
    partial class frmAjoutCinema
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomCinema = new System.Windows.Forms.TextBox();
            this.txtAdresseCinema = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btSave = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbQteRangees = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbNbrPlace = new System.Windows.Forms.ComboBox();
            this.labelNumSalle = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblPlacesParRangee = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom du cinema  *";
            // 
            // txtNomCinema
            // 
            this.txtNomCinema.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNomCinema.Location = new System.Drawing.Point(162, 80);
            this.txtNomCinema.Name = "txtNomCinema";
            this.txtNomCinema.Size = new System.Drawing.Size(169, 23);
            this.txtNomCinema.TabIndex = 1;
            // 
            // txtAdresseCinema
            // 
            this.txtAdresseCinema.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAdresseCinema.Location = new System.Drawing.Point(557, 77);
            this.txtAdresseCinema.Name = "txtAdresseCinema";
            this.txtAdresseCinema.Size = new System.Drawing.Size(331, 23);
            this.txtAdresseCinema.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(426, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Adresse du cinema";
            // 
            // btSave
            // 
            this.btSave.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btSave.BackColor = System.Drawing.Color.Snow;
            this.btSave.Location = new System.Drawing.Point(322, 379);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(121, 30);
            this.btSave.TabIndex = 4;
            this.btSave.Text = "Ajouter Cinema";
            this.btSave.UseVisualStyleBackColor = false;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btCancel
            // 
            this.btCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btCancel.BackColor = System.Drawing.Color.Snow;
            this.btCancel.Location = new System.Drawing.Point(503, 379);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(120, 30);
            this.btCancel.TabIndex = 5;
            this.btCancel.Text = "Annuler";
            this.btCancel.UseVisualStyleBackColor = false;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(20, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Numero de salle :";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(21, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "Nombre de rangées  *";
            // 
            // cmbQteRangees
            // 
            this.cmbQteRangees.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbQteRangees.FormattingEnabled = true;
            this.cmbQteRangees.Location = new System.Drawing.Point(150, 102);
            this.cmbQteRangees.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbQteRangees.Name = "cmbQteRangees";
            this.cmbQteRangees.Size = new System.Drawing.Size(64, 27);
            this.cmbQteRangees.TabIndex = 12;
            this.cmbQteRangees.SelectedIndexChanged += new System.EventHandler(this.cmbQteRangees_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(262, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 15);
            this.label5.TabIndex = 15;
            this.label5.Text = "Nombre de places  *";
            // 
            // cmbNbrPlace
            // 
            this.cmbNbrPlace.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbNbrPlace.FormattingEnabled = true;
            this.cmbNbrPlace.Location = new System.Drawing.Point(395, 102);
            this.cmbNbrPlace.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbNbrPlace.Name = "cmbNbrPlace";
            this.cmbNbrPlace.Size = new System.Drawing.Size(64, 27);
            this.cmbNbrPlace.TabIndex = 14;
            this.cmbNbrPlace.SelectedIndexChanged += new System.EventHandler(this.cmbNbrPlace_SelectedIndexChanged);
            // 
            // labelNumSalle
            // 
            this.labelNumSalle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelNumSalle.AutoSize = true;
            this.labelNumSalle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelNumSalle.ForeColor = System.Drawing.Color.Red;
            this.labelNumSalle.Location = new System.Drawing.Point(135, 43);
            this.labelNumSalle.Name = "labelNumSalle";
            this.labelNumSalle.Size = new System.Drawing.Size(17, 19);
            this.labelNumSalle.TabIndex = 16;
            this.labelNumSalle.Text = "1";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.Snow;
            this.groupBox1.Controls.Add(this.lblPlacesParRangee);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.labelNumSalle);
            this.groupBox1.Controls.Add(this.cmbNbrPlace);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cmbQteRangees);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.groupBox1.Location = new System.Drawing.Point(207, 150);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(534, 192);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ajout de la Salle 1";
            // 
            // lblPlacesParRangee
            // 
            this.lblPlacesParRangee.AutoSize = true;
            this.lblPlacesParRangee.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPlacesParRangee.ForeColor = System.Drawing.Color.Red;
            this.lblPlacesParRangee.Location = new System.Drawing.Point(33, 158);
            this.lblPlacesParRangee.Name = "lblPlacesParRangee";
            this.lblPlacesParRangee.Size = new System.Drawing.Size(0, 15);
            this.lblPlacesParRangee.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(48, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(185, 30);
            this.label6.TabIndex = 18;
            this.label6.Text = "Nouveau cinema";
            // 
            // frmAjoutCinema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(928, 450);
            this.ControlBox = false;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.txtAdresseCinema);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNomCinema);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmAjoutCinema";
            this.Text = "Enregistrement d\'un nouveau cinema";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtNomCinema;
        private TextBox txtAdresseCinema;
        private Label label2;
        private Button btSave;
        private Button btCancel;
        private Label label3;
        private Label label4;
        private ComboBox cmbQteRangees;
        private Label label5;
        private ComboBox cmbNbrPlace;
        private Label labelNumSalle;
        private GroupBox groupBox1;
        private Label lblPlacesParRangee;
        private Label label6;
    }
}
namespace UIAdmin
{
    partial class frmAjoutSeance
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
            this.lblAvertissement = new System.Windows.Forms.Label();
            this.btQuitter = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lstProgrTrad = new System.Windows.Forms.ListView();
            this.Cinema = new System.Windows.Forms.ColumnHeader();
            this.Film = new System.Windows.Forms.ColumnHeader();
            this.Langue = new System.Windows.Forms.ColumnHeader();
            this.sousTitre = new System.Windows.Forms.ColumnHeader();
            this.date = new System.Windows.Forms.ColumnHeader();
            this.cmbHoraire = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.calDateFin = new System.Windows.Forms.MonthCalendar();
            this.label3 = new System.Windows.Forms.Label();
            this.btSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAvertissement
            // 
            this.lblAvertissement.AutoSize = true;
            this.lblAvertissement.ForeColor = System.Drawing.Color.Red;
            this.lblAvertissement.Location = new System.Drawing.Point(202, 347);
            this.lblAvertissement.Name = "lblAvertissement";
            this.lblAvertissement.Size = new System.Drawing.Size(0, 15);
            this.lblAvertissement.TabIndex = 32;
            // 
            // btQuitter
            // 
            this.btQuitter.BackColor = System.Drawing.Color.Snow;
            this.btQuitter.ForeColor = System.Drawing.Color.Black;
            this.btQuitter.Location = new System.Drawing.Point(378, 443);
            this.btQuitter.Name = "btQuitter";
            this.btQuitter.Size = new System.Drawing.Size(118, 33);
            this.btQuitter.TabIndex = 31;
            this.btQuitter.Text = "Quitter";
            this.btQuitter.UseVisualStyleBackColor = false;
            this.btQuitter.Click += new System.EventHandler(this.btQuitter_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(43, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(330, 30);
            this.label6.TabIndex = 29;
            this.label6.Text = "Ajout - Modification de seance";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 15);
            this.label1.TabIndex = 33;
            this.label1.Text = "Film";
            // 
            // lstProgrTrad
            // 
            this.lstProgrTrad.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Cinema,
            this.Film,
            this.Langue,
            this.sousTitre,
            this.date});
            this.lstProgrTrad.FullRowSelect = true;
            this.lstProgrTrad.Location = new System.Drawing.Point(105, 102);
            this.lstProgrTrad.Name = "lstProgrTrad";
            this.lstProgrTrad.Size = new System.Drawing.Size(619, 102);
            this.lstProgrTrad.TabIndex = 34;
            this.lstProgrTrad.UseCompatibleStateImageBehavior = false;
            this.lstProgrTrad.View = System.Windows.Forms.View.Details;
            this.lstProgrTrad.Resize += new System.EventHandler(this.lstProgrTrad_Resize);
            // 
            // Cinema
            // 
            this.Cinema.Text = "Cinema";
            // 
            // Film
            // 
            this.Film.Text = "Film";
            // 
            // Langue
            // 
            this.Langue.Text = "Langue";
            // 
            // sousTitre
            // 
            this.sousTitre.Text = "Sous-Titre";
            // 
            // date
            // 
            this.date.Text = "Date Programmée";
            // 
            // cmbHoraire
            // 
            this.cmbHoraire.FormattingEnabled = true;
            this.cmbHoraire.Items.AddRange(new object[] {
            "16:00",
            "18:00",
            "20:00",
            "22:00"});
            this.cmbHoraire.Location = new System.Drawing.Point(105, 266);
            this.cmbHoraire.Name = "cmbHoraire";
            this.cmbHoraire.Size = new System.Drawing.Size(121, 23);
            this.cmbHoraire.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 266);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 15);
            this.label2.TabIndex = 36;
            this.label2.Text = "Horaire";
            // 
            // calDateFin
            // 
            this.calDateFin.Location = new System.Drawing.Point(497, 266);
            this.calDateFin.Name = "calDateFin";
            this.calDateFin.TabIndex = 37;
            this.calDateFin.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.calDateFin_DateSelected);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(343, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 15);
            this.label3.TabIndex = 38;
            this.label3.Text = "Date de fin de la séance";
            // 
            // btSave
            // 
            this.btSave.BackColor = System.Drawing.Color.Snow;
            this.btSave.ForeColor = System.Drawing.Color.Black;
            this.btSave.Location = new System.Drawing.Point(188, 443);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(118, 33);
            this.btSave.TabIndex = 39;
            this.btSave.Text = "Créer séance";
            this.btSave.UseVisualStyleBackColor = false;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // frmAjoutSeance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 515);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.calDateFin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbHoraire);
            this.Controls.Add(this.lstProgrTrad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblAvertissement);
            this.Controls.Add(this.btQuitter);
            this.Controls.Add(this.label6);
            this.Name = "frmAjoutSeance";
            this.Text = "frmAjoutSeance";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblAvertissement;
        private Button btQuitter;
        private Label label6;
        private Label label1;
        private ListView lstProgrTrad;
        private ColumnHeader Cinema;
        private ColumnHeader Film;
        private ColumnHeader Langue;
        private ColumnHeader sousTitre;
        private ColumnHeader date;
        private ComboBox cmbHoraire;
        private Label label2;
        private MonthCalendar calDateFin;
        private Label label3;
        private Button btSave;
    }
}
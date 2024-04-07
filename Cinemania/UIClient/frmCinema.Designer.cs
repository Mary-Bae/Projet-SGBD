namespace UIClient
{
    partial class frmCinema
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
            this.lblCinemaNom = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lstFilms = new System.Windows.Forms.ListBox();
            this.lstLangue = new System.Windows.Forms.ListView();
            this.Langue = new System.Windows.Forms.ColumnHeader();
            this.SousTitre = new System.Windows.Forms.ColumnHeader();
            this.Horaire = new System.Windows.Forms.ColumnHeader();
            this.btCancel = new System.Windows.Forms.Button();
            this.btReserver = new System.Windows.Forms.Button();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblGenre = new System.Windows.Forms.Label();
            this.dateReservation = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCinemaNom
            // 
            this.lblCinemaNom.AutoSize = true;
            this.lblCinemaNom.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCinemaNom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblCinemaNom.Location = new System.Drawing.Point(43, 56);
            this.lblCinemaNom.Name = "lblCinemaNom";
            this.lblCinemaNom.Size = new System.Drawing.Size(0, 38);
            this.lblCinemaNom.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 20);
            this.label1.TabIndex = 32;
            this.label1.Text = "Films disponibles";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(262, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 20);
            this.label2.TabIndex = 33;
            this.label2.Text = "Langues et horaires disponibles";
            // 
            // lstFilms
            // 
            this.lstFilms.FormattingEnabled = true;
            this.lstFilms.ItemHeight = 20;
            this.lstFilms.Location = new System.Drawing.Point(29, 161);
            this.lstFilms.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lstFilms.Name = "lstFilms";
            this.lstFilms.Size = new System.Drawing.Size(143, 184);
            this.lstFilms.TabIndex = 34;
            this.lstFilms.SelectedIndexChanged += new System.EventHandler(this.lstFilms_SelectedIndexChanged);
            // 
            // lstLangue
            // 
            this.lstLangue.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Langue,
            this.SousTitre,
            this.Horaire});
            this.lstLangue.FullRowSelect = true;
            this.lstLangue.Location = new System.Drawing.Point(262, 161);
            this.lstLangue.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lstLangue.Name = "lstLangue";
            this.lstLangue.Size = new System.Drawing.Size(217, 184);
            this.lstLangue.TabIndex = 35;
            this.lstLangue.UseCompatibleStateImageBehavior = false;
            this.lstLangue.View = System.Windows.Forms.View.Details;
            this.lstLangue.SelectedIndexChanged += new System.EventHandler(this.lstLangue_SelectedIndexChanged);
            // 
            // Langue
            // 
            this.Langue.Text = "Langue";
            this.Langue.Width = 70;
            // 
            // SousTitre
            // 
            this.SousTitre.Text = "Sous-Titre";
            this.SousTitre.Width = 70;
            // 
            // Horaire
            // 
            this.Horaire.Text = "Horaire";
            // 
            // btCancel
            // 
            this.btCancel.BackColor = System.Drawing.Color.Snow;
            this.btCancel.Location = new System.Drawing.Point(298, 552);
            this.btCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(170, 44);
            this.btCancel.TabIndex = 37;
            this.btCancel.Text = "Quitter sans réserver";
            this.btCancel.UseVisualStyleBackColor = false;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btReserver
            // 
            this.btReserver.BackColor = System.Drawing.Color.Snow;
            this.btReserver.Location = new System.Drawing.Point(565, 301);
            this.btReserver.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btReserver.Name = "btReserver";
            this.btReserver.Size = new System.Drawing.Size(143, 44);
            this.btReserver.TabIndex = 36;
            this.btReserver.Text = "Reserver";
            this.btReserver.UseVisualStyleBackColor = false;
            this.btReserver.Click += new System.EventHandler(this.btReserver_Click);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(29, 404);
            this.lblDescription.MaximumSize = new System.Drawing.Size(571, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(0, 20);
            this.lblDescription.TabIndex = 38;
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Location = new System.Drawing.Point(29, 371);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(0, 20);
            this.lblGenre.TabIndex = 39;
            // 
            // dateReservation
            // 
            this.dateReservation.Location = new System.Drawing.Point(543, 161);
            this.dateReservation.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateReservation.Name = "dateReservation";
            this.dateReservation.Size = new System.Drawing.Size(198, 27);
            this.dateReservation.TabIndex = 40;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(543, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 20);
            this.label3.TabIndex = 41;
            this.label3.Text = "Date de reservation";
            // 
            // frmCinema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(799, 629);
            this.ControlBox = false;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateReservation);
            this.Controls.Add(this.lblGenre);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btReserver);
            this.Controls.Add(this.lstLangue);
            this.Controls.Add(this.lstFilms);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCinemaNom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmCinema";
            this.Text = "Cinema";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblCinemaNom;
        private Label label1;
        private Label label2;
        private ListBox lstFilms;
        private ListView lstLangue;
        private Button btCancel;
        private Button btReserver;
        private Label lblDescription;
        private Label lblGenre;
        private ColumnHeader Langue;
        private ColumnHeader SousTitre;
        private ColumnHeader Horaire;
        private DateTimePicker dateReservation;
        private Label label3;
    }
}
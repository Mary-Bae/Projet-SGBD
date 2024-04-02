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
            this.btCancel = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblGenre = new System.Windows.Forms.Label();
            this.Horaire = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // lblCinemaNom
            // 
            this.lblCinemaNom.AutoSize = true;
            this.lblCinemaNom.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCinemaNom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblCinemaNom.Location = new System.Drawing.Point(38, 42);
            this.lblCinemaNom.Name = "lblCinemaNom";
            this.lblCinemaNom.Size = new System.Drawing.Size(0, 30);
            this.lblCinemaNom.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 15);
            this.label1.TabIndex = 32;
            this.label1.Text = "Choisissez le film qui vous interesse";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(386, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 15);
            this.label2.TabIndex = 33;
            this.label2.Text = "Choisissez la langue";
            // 
            // lstFilms
            // 
            this.lstFilms.FormattingEnabled = true;
            this.lstFilms.ItemHeight = 15;
            this.lstFilms.Location = new System.Drawing.Point(47, 121);
            this.lstFilms.Name = "lstFilms";
            this.lstFilms.Size = new System.Drawing.Size(126, 139);
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
            this.lstLangue.Location = new System.Drawing.Point(346, 121);
            this.lstLangue.Name = "lstLangue";
            this.lstLangue.Size = new System.Drawing.Size(204, 139);
            this.lstLangue.TabIndex = 35;
            this.lstLangue.UseCompatibleStateImageBehavior = false;
            this.lstLangue.View = System.Windows.Forms.View.Details;
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
            // btCancel
            // 
            this.btCancel.BackColor = System.Drawing.Color.Snow;
            this.btCancel.Location = new System.Drawing.Point(291, 402);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(125, 33);
            this.btCancel.TabIndex = 37;
            this.btCancel.Text = "Retour";
            this.btCancel.UseVisualStyleBackColor = false;
            // 
            // btSave
            // 
            this.btSave.BackColor = System.Drawing.Color.Snow;
            this.btSave.Location = new System.Drawing.Point(131, 402);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(125, 33);
            this.btSave.TabIndex = 36;
            this.btSave.Text = "Reserver";
            this.btSave.UseVisualStyleBackColor = false;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(47, 303);
            this.lblDescription.MaximumSize = new System.Drawing.Size(500, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(0, 15);
            this.lblDescription.TabIndex = 38;
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Location = new System.Drawing.Point(47, 278);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(0, 15);
            this.lblGenre.TabIndex = 39;
            // 
            // Horaire
            // 
            this.Horaire.Text = "Horaire";
            // 
            // frmCinema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(573, 447);
            this.Controls.Add(this.lblGenre);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.lstLangue);
            this.Controls.Add(this.lstFilms);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCinemaNom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
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
        private Button btSave;
        private Label lblDescription;
        private Label lblGenre;
        private ColumnHeader Langue;
        private ColumnHeader SousTitre;
        private ColumnHeader Horaire;
    }
}
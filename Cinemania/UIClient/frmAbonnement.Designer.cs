namespace UIClient
{
    partial class frmAbonnement
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
            this.labelTitre = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lstChaine = new System.Windows.Forms.ListBox();
            this.btCancel = new System.Windows.Forms.Button();
            this.btAcheter = new System.Windows.Forms.Button();
            this.lblPrix = new System.Windows.Forms.Label();
            this.lblUid = new System.Windows.Forms.Label();
            this.lblDateAchat = new System.Windows.Forms.Label();
            this.lblDateValidite = new System.Windows.Forms.Label();
            this.lblMerci = new System.Windows.Forms.Label();
            this.lblReservationRestante = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelTitre
            // 
            this.labelTitre.AutoSize = true;
            this.labelTitre.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTitre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.labelTitre.Location = new System.Drawing.Point(36, 37);
            this.labelTitre.Name = "labelTitre";
            this.labelTitre.Size = new System.Drawing.Size(230, 30);
            this.labelTitre.TabIndex = 3;
            this.labelTitre.Text = "Achat d\'abonnement";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(36, 95);
            this.label1.MaximumSize = new System.Drawing.Size(700, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(672, 34);
            this.label1.TabIndex = 4;
            this.label1.Text = "Vous pouvez ici vous prendre un abonnement de 5 places pour la chaine de cinéma d" +
    "e votre choix, vous pourrez acceder à tous les cinémas de la chaine avec cet abo" +
    "nnement !";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(121, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(507, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Profitez de notre offre spéciale ! 6 places pour le prix de 5 !";
            // 
            // lstChaine
            // 
            this.lstChaine.FormattingEnabled = true;
            this.lstChaine.ItemHeight = 15;
            this.lstChaine.Location = new System.Drawing.Point(122, 207);
            this.lstChaine.Name = "lstChaine";
            this.lstChaine.Size = new System.Drawing.Size(144, 169);
            this.lstChaine.TabIndex = 6;
            this.lstChaine.SelectedIndexChanged += new System.EventHandler(this.lstChaine_SelectedIndexChanged);
            // 
            // btCancel
            // 
            this.btCancel.BackColor = System.Drawing.Color.Snow;
            this.btCancel.Location = new System.Drawing.Point(305, 455);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(144, 40);
            this.btCancel.TabIndex = 11;
            this.btCancel.Text = "Sortir";
            this.btCancel.UseVisualStyleBackColor = false;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btAcheter
            // 
            this.btAcheter.BackColor = System.Drawing.Color.Snow;
            this.btAcheter.Location = new System.Drawing.Point(122, 382);
            this.btAcheter.Name = "btAcheter";
            this.btAcheter.Size = new System.Drawing.Size(144, 41);
            this.btAcheter.TabIndex = 10;
            this.btAcheter.Text = "Acheter un abonnement";
            this.btAcheter.UseVisualStyleBackColor = false;
            this.btAcheter.Click += new System.EventHandler(this.btAcheter_Click);
            // 
            // lblPrix
            // 
            this.lblPrix.AutoSize = true;
            this.lblPrix.Location = new System.Drawing.Point(24, 231);
            this.lblPrix.Name = "lblPrix";
            this.lblPrix.Size = new System.Drawing.Size(0, 15);
            this.lblPrix.TabIndex = 12;
            // 
            // lblUid
            // 
            this.lblUid.AutoSize = true;
            this.lblUid.Location = new System.Drawing.Point(348, 255);
            this.lblUid.Name = "lblUid";
            this.lblUid.Size = new System.Drawing.Size(0, 15);
            this.lblUid.TabIndex = 14;
            // 
            // lblDateAchat
            // 
            this.lblDateAchat.AutoSize = true;
            this.lblDateAchat.Location = new System.Drawing.Point(348, 291);
            this.lblDateAchat.Name = "lblDateAchat";
            this.lblDateAchat.Size = new System.Drawing.Size(0, 15);
            this.lblDateAchat.TabIndex = 15;
            // 
            // lblDateValidite
            // 
            this.lblDateValidite.AutoSize = true;
            this.lblDateValidite.Location = new System.Drawing.Point(348, 328);
            this.lblDateValidite.Name = "lblDateValidite";
            this.lblDateValidite.Size = new System.Drawing.Size(0, 15);
            this.lblDateValidite.TabIndex = 16;
            // 
            // lblMerci
            // 
            this.lblMerci.AutoSize = true;
            this.lblMerci.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblMerci.Location = new System.Drawing.Point(348, 220);
            this.lblMerci.Name = "lblMerci";
            this.lblMerci.Size = new System.Drawing.Size(0, 15);
            this.lblMerci.TabIndex = 17;
            // 
            // lblReservationRestante
            // 
            this.lblReservationRestante.AutoSize = true;
            this.lblReservationRestante.Location = new System.Drawing.Point(348, 370);
            this.lblReservationRestante.Name = "lblReservationRestante";
            this.lblReservationRestante.Size = new System.Drawing.Size(0, 15);
            this.lblReservationRestante.TabIndex = 18;
            // 
            // frmAbonnement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(815, 519);
            this.ControlBox = false;
            this.Controls.Add(this.lblReservationRestante);
            this.Controls.Add(this.lblMerci);
            this.Controls.Add(this.lblDateValidite);
            this.Controls.Add(this.lblDateAchat);
            this.Controls.Add(this.lblUid);
            this.Controls.Add(this.lblPrix);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btAcheter);
            this.Controls.Add(this.lstChaine);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelTitre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmAbonnement";
            this.Text = "Achat Abonnement";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelTitre;
        private Label label1;
        private Label label2;
        private ListBox lstChaine;
        private Button btCancel;
        private Button btAcheter;
        private Label lblPrix;
        private Label lblUid;
        private Label lblDateAchat;
        private Label lblDateValidite;
        private Label lblMerci;
        private Label lblReservationRestante;
    }
}
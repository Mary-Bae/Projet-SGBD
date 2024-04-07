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
            this.btChoix = new System.Windows.Forms.Button();
            this.lblPayement = new System.Windows.Forms.Label();
            this.lblCine = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTitre
            // 
            this.labelTitre.AutoSize = true;
            this.labelTitre.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTitre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.labelTitre.Location = new System.Drawing.Point(41, 49);
            this.labelTitre.Name = "labelTitre";
            this.labelTitre.Size = new System.Drawing.Size(293, 38);
            this.labelTitre.TabIndex = 3;
            this.labelTitre.Text = "Achat d\'abonnement";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(41, 127);
            this.label1.MaximumSize = new System.Drawing.Size(800, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(771, 46);
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
            this.label2.Location = new System.Drawing.Point(132, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(647, 32);
            this.label2.TabIndex = 5;
            this.label2.Text = "Profitez de notre offre spéciale ! 6 places pour le prix de 5 !";
            // 
            // lstChaine
            // 
            this.lstChaine.FormattingEnabled = true;
            this.lstChaine.ItemHeight = 20;
            this.lstChaine.Location = new System.Drawing.Point(133, 256);
            this.lstChaine.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lstChaine.Name = "lstChaine";
            this.lstChaine.Size = new System.Drawing.Size(164, 204);
            this.lstChaine.TabIndex = 6;
            this.lstChaine.SelectedIndexChanged += new System.EventHandler(this.lstChaine_SelectedIndexChanged);
            // 
            // btCancel
            // 
            this.btCancel.BackColor = System.Drawing.Color.Snow;
            this.btCancel.Location = new System.Drawing.Point(390, 612);
            this.btCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(141, 44);
            this.btCancel.TabIndex = 11;
            this.btCancel.Text = "Quitter";
            this.btCancel.UseVisualStyleBackColor = false;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btAcheter
            // 
            this.btAcheter.BackColor = System.Drawing.Color.Snow;
            this.btAcheter.Location = new System.Drawing.Point(131, 614);
            this.btAcheter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btAcheter.Name = "btAcheter";
            this.btAcheter.Size = new System.Drawing.Size(161, 44);
            this.btAcheter.TabIndex = 10;
            this.btAcheter.Text = "Payer l\'abonnement";
            this.btAcheter.UseVisualStyleBackColor = false;
            this.btAcheter.Click += new System.EventHandler(this.btAcheter_Click);
            // 
            // lblPrix
            // 
            this.lblPrix.AutoSize = true;
            this.lblPrix.ForeColor = System.Drawing.Color.Red;
            this.lblPrix.Location = new System.Drawing.Point(354, 233);
            this.lblPrix.Name = "lblPrix";
            this.lblPrix.Size = new System.Drawing.Size(289, 20);
            this.lblPrix.TabIndex = 12;
            this.lblPrix.Text = "Prix de l\'abonnement : 50€ au lieu de 60€ !";
            // 
            // lblUid
            // 
            this.lblUid.AutoSize = true;
            this.lblUid.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblUid.Location = new System.Drawing.Point(3, 51);
            this.lblUid.Name = "lblUid";
            this.lblUid.Size = new System.Drawing.Size(0, 20);
            this.lblUid.TabIndex = 14;
            // 
            // lblDateAchat
            // 
            this.lblDateAchat.AutoSize = true;
            this.lblDateAchat.Location = new System.Drawing.Point(3, 102);
            this.lblDateAchat.Name = "lblDateAchat";
            this.lblDateAchat.Size = new System.Drawing.Size(0, 20);
            this.lblDateAchat.TabIndex = 15;
            // 
            // lblDateValidite
            // 
            this.lblDateValidite.AutoSize = true;
            this.lblDateValidite.Location = new System.Drawing.Point(3, 153);
            this.lblDateValidite.Name = "lblDateValidite";
            this.lblDateValidite.Size = new System.Drawing.Size(0, 20);
            this.lblDateValidite.TabIndex = 16;
            // 
            // lblMerci
            // 
            this.lblMerci.AutoSize = true;
            this.lblMerci.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblMerci.Location = new System.Drawing.Point(3, 0);
            this.lblMerci.Name = "lblMerci";
            this.lblMerci.Size = new System.Drawing.Size(0, 20);
            this.lblMerci.TabIndex = 17;
            // 
            // lblReservationRestante
            // 
            this.lblReservationRestante.AutoSize = true;
            this.lblReservationRestante.Location = new System.Drawing.Point(3, 204);
            this.lblReservationRestante.Name = "lblReservationRestante";
            this.lblReservationRestante.Size = new System.Drawing.Size(0, 20);
            this.lblReservationRestante.TabIndex = 18;
            // 
            // btChoix
            // 
            this.btChoix.BackColor = System.Drawing.Color.Snow;
            this.btChoix.Location = new System.Drawing.Point(133, 468);
            this.btChoix.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btChoix.Name = "btChoix";
            this.btChoix.Size = new System.Drawing.Size(165, 51);
            this.btChoix.TabIndex = 19;
            this.btChoix.Text = "S\'abonner à cette chaine de cinéma";
            this.btChoix.UseVisualStyleBackColor = false;
            this.btChoix.Click += new System.EventHandler(this.btChoix_Click);
            // 
            // lblPayement
            // 
            this.lblPayement.AutoSize = true;
            this.lblPayement.Location = new System.Drawing.Point(132, 536);
            this.lblPayement.Name = "lblPayement";
            this.lblPayement.Size = new System.Drawing.Size(0, 20);
            this.lblPayement.TabIndex = 51;
            // 
            // lblCine
            // 
            this.lblCine.AutoSize = true;
            this.lblCine.Location = new System.Drawing.Point(3, 0);
            this.lblCine.Name = "lblCine";
            this.lblCine.Size = new System.Drawing.Size(0, 20);
            this.lblCine.TabIndex = 52;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblCine, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(354, 256);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(466, 263);
            this.tableLayoutPanel1.TabIndex = 53;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.lblMerci, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblUid, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblDateAchat, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.lblReservationRestante, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.lblDateValidite, 0, 3);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(236, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(227, 257);
            this.tableLayoutPanel2.TabIndex = 53;
            // 
            // frmAbonnement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(873, 669);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.lblPayement);
            this.Controls.Add(this.btChoix);
            this.Controls.Add(this.lblPrix);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btAcheter);
            this.Controls.Add(this.lstChaine);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelTitre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmAbonnement";
            this.Text = "Achat Abonnement";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
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
        private Button btChoix;
        private Label lblPayement;
        private Label lblCine;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
    }
}
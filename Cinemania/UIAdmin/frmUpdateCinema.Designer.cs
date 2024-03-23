namespace UIAdmin
{
    partial class frmUpdateCinema
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
            this.label6 = new System.Windows.Forms.Label();
            this.btCancel = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.txtAdresseCinema = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNomCinema = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblErreur = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(137, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(182, 30);
            this.label6.TabIndex = 26;
            this.label6.Text = "Modifier cinema";
            // 
            // btCancel
            // 
            this.btCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btCancel.BackColor = System.Drawing.Color.Snow;
            this.btCancel.Location = new System.Drawing.Point(389, 293);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(138, 34);
            this.btCancel.TabIndex = 24;
            this.btCancel.Text = "Annuler";
            this.btCancel.UseVisualStyleBackColor = false;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btSave
            // 
            this.btSave.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btSave.BackColor = System.Drawing.Color.Snow;
            this.btSave.Location = new System.Drawing.Point(132, 293);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(139, 34);
            this.btSave.TabIndex = 23;
            this.btSave.Text = "Modifier Cinema";
            this.btSave.UseVisualStyleBackColor = false;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // txtAdresseCinema
            // 
            this.txtAdresseCinema.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAdresseCinema.Location = new System.Drawing.Point(279, 202);
            this.txtAdresseCinema.Name = "txtAdresseCinema";
            this.txtAdresseCinema.Size = new System.Drawing.Size(286, 23);
            this.txtAdresseCinema.TabIndex = 22;
            this.txtAdresseCinema.TextChanged += new System.EventHandler(this.txtAdresseCinema_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(137, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 15);
            this.label2.TabIndex = 21;
            this.label2.Text = "Adresse du cinema";
            // 
            // txtNomCinema
            // 
            this.txtNomCinema.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNomCinema.Location = new System.Drawing.Point(279, 132);
            this.txtNomCinema.Name = "txtNomCinema";
            this.txtNomCinema.Size = new System.Drawing.Size(167, 23);
            this.txtNomCinema.TabIndex = 20;
            this.txtNomCinema.TextChanged += new System.EventHandler(this.txtNomCinema_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(137, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 15);
            this.label1.TabIndex = 19;
            this.label1.Text = "Nom du cinema  *";
            // 
            // lblErreur
            // 
            this.lblErreur.AutoSize = true;
            this.lblErreur.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblErreur.ForeColor = System.Drawing.Color.Red;
            this.lblErreur.Location = new System.Drawing.Point(137, 260);
            this.lblErreur.Name = "lblErreur";
            this.lblErreur.Size = new System.Drawing.Size(0, 15);
            this.lblErreur.TabIndex = 27;
            // 
            // frmUpdateCinema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(701, 438);
            this.ControlBox = false;
            this.Controls.Add(this.lblErreur);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.txtAdresseCinema);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNomCinema);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmUpdateCinema";
            this.Text = "Modifier le cinema";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label6;
        private Button btCancel;
        private Button btSave;
        private TextBox txtAdresseCinema;
        private Label label2;
        private TextBox txtNomCinema;
        private Label label1;
        private Label lblErreur;
    }
}
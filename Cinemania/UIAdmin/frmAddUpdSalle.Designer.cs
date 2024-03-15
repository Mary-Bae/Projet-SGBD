namespace UIAdmin
{
    partial class frmAddUpdSalle
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
            this.cmbNumSalle = new System.Windows.Forms.ComboBox();
            this.cmbNbrPlace = new System.Windows.Forms.ComboBox();
            this.cmbQteRangees = new System.Windows.Forms.ComboBox();
            this.labelNumSalle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btSave = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.lblPlacesParRangee = new System.Windows.Forms.Label();
            this.lblAvertissement = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbNumSalle
            // 
            this.cmbNumSalle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbNumSalle.FormattingEnabled = true;
            this.cmbNumSalle.Location = new System.Drawing.Point(257, 149);
            this.cmbNumSalle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbNumSalle.Name = "cmbNumSalle";
            this.cmbNumSalle.Size = new System.Drawing.Size(70, 28);
            this.cmbNumSalle.TabIndex = 0;
            this.cmbNumSalle.SelectedIndexChanged += new System.EventHandler(this.cmbNumSalle_SelectedIndexChanged);
            // 
            // cmbNbrPlace
            // 
            this.cmbNbrPlace.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbNbrPlace.FormattingEnabled = true;
            this.cmbNbrPlace.Location = new System.Drawing.Point(257, 224);
            this.cmbNbrPlace.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbNbrPlace.Name = "cmbNbrPlace";
            this.cmbNbrPlace.Size = new System.Drawing.Size(70, 28);
            this.cmbNbrPlace.TabIndex = 1;
            this.cmbNbrPlace.SelectedIndexChanged += new System.EventHandler(this.cmbNbrPlace_SelectedIndexChanged);
            // 
            // cmbQteRangees
            // 
            this.cmbQteRangees.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbQteRangees.FormattingEnabled = true;
            this.cmbQteRangees.Location = new System.Drawing.Point(538, 224);
            this.cmbQteRangees.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbQteRangees.Name = "cmbQteRangees";
            this.cmbQteRangees.Size = new System.Drawing.Size(70, 28);
            this.cmbQteRangees.TabIndex = 2;
            this.cmbQteRangees.SelectedIndexChanged += new System.EventHandler(this.cmbQteRangees_SelectedIndexChanged);
            // 
            // labelNumSalle
            // 
            this.labelNumSalle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelNumSalle.AutoSize = true;
            this.labelNumSalle.Location = new System.Drawing.Point(89, 152);
            this.labelNumSalle.Name = "labelNumSalle";
            this.labelNumSalle.Size = new System.Drawing.Size(118, 20);
            this.labelNumSalle.TabIndex = 3;
            this.labelNumSalle.Text = "Numero de salle";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nombre de places";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(374, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nombre de rangées";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(111, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(216, 37);
            this.label3.TabIndex = 6;
            this.label3.Text = "Salle de cinema";
            // 
            // btSave
            // 
            this.btSave.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btSave.BackColor = System.Drawing.Color.Snow;
            this.btSave.Location = new System.Drawing.Point(127, 364);
            this.btSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(143, 31);
            this.btSave.TabIndex = 7;
            this.btSave.Text = "Sauver";
            this.btSave.UseVisualStyleBackColor = false;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btCancel
            // 
            this.btCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btCancel.BackColor = System.Drawing.Color.Snow;
            this.btCancel.Location = new System.Drawing.Point(350, 364);
            this.btCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(143, 31);
            this.btCancel.TabIndex = 8;
            this.btCancel.Text = "Annuler";
            this.btCancel.UseVisualStyleBackColor = false;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // lblPlacesParRangee
            // 
            this.lblPlacesParRangee.AutoSize = true;
            this.lblPlacesParRangee.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPlacesParRangee.ForeColor = System.Drawing.Color.Red;
            this.lblPlacesParRangee.Location = new System.Drawing.Point(160, 312);
            this.lblPlacesParRangee.Name = "lblPlacesParRangee";
            this.lblPlacesParRangee.Size = new System.Drawing.Size(0, 23);
            this.lblPlacesParRangee.TabIndex = 9;
            // 
            // lblAvertissement
            // 
            this.lblAvertissement.AutoSize = true;
            this.lblAvertissement.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAvertissement.ForeColor = System.Drawing.Color.Red;
            this.lblAvertissement.Location = new System.Drawing.Point(160, 276);
            this.lblAvertissement.Name = "lblAvertissement";
            this.lblAvertissement.Size = new System.Drawing.Size(0, 23);
            this.lblAvertissement.TabIndex = 10;
            // 
            // frmAddUpdSalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(674, 483);
            this.ControlBox = false;
            this.Controls.Add(this.lblAvertissement);
            this.Controls.Add(this.lblPlacesParRangee);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelNumSalle);
            this.Controls.Add(this.cmbQteRangees);
            this.Controls.Add(this.cmbNbrPlace);
            this.Controls.Add(this.cmbNumSalle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmAddUpdSalle";
            this.Text = "Ajout d\'une salle de cinema";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cmbNumSalle;
        private ComboBox cmbNbrPlace;
        private ComboBox cmbQteRangees;
        private Label labelNumSalle;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btSave;
        private Button btCancel;
        private Label lblPlacesParRangee;
        private Label lblAvertissement;
    }
}
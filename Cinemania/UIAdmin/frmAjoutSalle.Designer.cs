namespace UIAdmin
{
    partial class frmAjoutSalle
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
            this.cmbNumSalle.FormattingEnabled = true;
            this.cmbNumSalle.Location = new System.Drawing.Point(155, 89);
            this.cmbNumSalle.Name = "cmbNumSalle";
            this.cmbNumSalle.Size = new System.Drawing.Size(62, 23);
            this.cmbNumSalle.TabIndex = 0;
            this.cmbNumSalle.SelectedIndexChanged += new System.EventHandler(this.cmbNumSalle_SelectedIndexChanged);
            // 
            // cmbNbrPlace
            // 
            this.cmbNbrPlace.FormattingEnabled = true;
            this.cmbNbrPlace.Location = new System.Drawing.Point(155, 153);
            this.cmbNbrPlace.Name = "cmbNbrPlace";
            this.cmbNbrPlace.Size = new System.Drawing.Size(62, 23);
            this.cmbNbrPlace.TabIndex = 1;
            this.cmbNbrPlace.SelectedIndexChanged += new System.EventHandler(this.cmbNbrPlace_SelectedIndexChanged);
            // 
            // cmbQteRangees
            // 
            this.cmbQteRangees.FormattingEnabled = true;
            this.cmbQteRangees.Location = new System.Drawing.Point(377, 153);
            this.cmbQteRangees.Name = "cmbQteRangees";
            this.cmbQteRangees.Size = new System.Drawing.Size(62, 23);
            this.cmbQteRangees.TabIndex = 2;
            this.cmbQteRangees.SelectedIndexChanged += new System.EventHandler(this.cmbQteRangees_SelectedIndexChanged);
            // 
            // labelNumSalle
            // 
            this.labelNumSalle.AutoSize = true;
            this.labelNumSalle.Location = new System.Drawing.Point(39, 97);
            this.labelNumSalle.Name = "labelNumSalle";
            this.labelNumSalle.Size = new System.Drawing.Size(93, 15);
            this.labelNumSalle.TabIndex = 3;
            this.labelNumSalle.Text = "Numero de salle";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nombre de places";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(260, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nombre de rangées";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(39, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(256, 30);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nouvelle salle de cinema";
            // 
            // btSave
            // 
            this.btSave.BackColor = System.Drawing.Color.Snow;
            this.btSave.Location = new System.Drawing.Point(92, 256);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(125, 23);
            this.btSave.TabIndex = 7;
            this.btSave.Text = "Ajouter Salle";
            this.btSave.UseVisualStyleBackColor = false;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btCancel
            // 
            this.btCancel.BackColor = System.Drawing.Color.Snow;
            this.btCancel.Location = new System.Drawing.Point(260, 256);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(125, 23);
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
            this.lblPlacesParRangee.Location = new System.Drawing.Point(82, 217);
            this.lblPlacesParRangee.Name = "lblPlacesParRangee";
            this.lblPlacesParRangee.Size = new System.Drawing.Size(0, 17);
            this.lblPlacesParRangee.TabIndex = 9;
            // 
            // lblAvertissement
            // 
            this.lblAvertissement.AutoSize = true;
            this.lblAvertissement.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAvertissement.ForeColor = System.Drawing.Color.Red;
            this.lblAvertissement.Location = new System.Drawing.Point(82, 190);
            this.lblAvertissement.Name = "lblAvertissement";
            this.lblAvertissement.Size = new System.Drawing.Size(0, 17);
            this.lblAvertissement.TabIndex = 10;
            // 
            // frmAjoutSalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(502, 334);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAjoutSalle";
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
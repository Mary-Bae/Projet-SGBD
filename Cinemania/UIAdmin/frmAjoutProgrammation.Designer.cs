namespace UIAdmin
{
    partial class frmAjoutProgrammation
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
            this.lblErreur = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btCancel = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbCine = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CalProgrammation = new System.Windows.Forms.MonthCalendar();
            this.SuspendLayout();
            // 
            // lblErreur
            // 
            this.lblErreur.AutoSize = true;
            this.lblErreur.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblErreur.ForeColor = System.Drawing.Color.Red;
            this.lblErreur.Location = new System.Drawing.Point(110, 362);
            this.lblErreur.Name = "lblErreur";
            this.lblErreur.Size = new System.Drawing.Size(0, 15);
            this.lblErreur.TabIndex = 35;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(65, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(423, 30);
            this.label6.TabIndex = 34;
            this.label6.Text = "Programmation du film pour un cinéma";
            // 
            // btCancel
            // 
            this.btCancel.BackColor = System.Drawing.Color.Snow;
            this.btCancel.Location = new System.Drawing.Point(362, 395);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(138, 34);
            this.btCancel.TabIndex = 33;
            this.btCancel.Text = "Annuler";
            this.btCancel.UseVisualStyleBackColor = false;
            // 
            // btSave
            // 
            this.btSave.BackColor = System.Drawing.Color.Snow;
            this.btSave.Location = new System.Drawing.Point(105, 395);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(139, 34);
            this.btSave.TabIndex = 32;
            this.btSave.Text = "Programmer";
            this.btSave.UseVisualStyleBackColor = false;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 15);
            this.label2.TabIndex = 30;
            this.label2.Text = "Choix du cinema";
            // 
            // cmbCine
            // 
            this.cmbCine.BackColor = System.Drawing.SystemColors.Info;
            this.cmbCine.FormattingEnabled = true;
            this.cmbCine.Location = new System.Drawing.Point(210, 110);
            this.cmbCine.Name = "cmbCine";
            this.cmbCine.Size = new System.Drawing.Size(133, 23);
            this.cmbCine.TabIndex = 37;
            this.cmbCine.Text = "Selection cinemas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 15);
            this.label3.TabIndex = 38;
            this.label3.Text = "Date de début";
            // 
            // CalProgrammation
            // 
            this.CalProgrammation.BackColor = System.Drawing.Color.Gray;
            this.CalProgrammation.ForeColor = System.Drawing.SystemColors.Info;
            this.CalProgrammation.Location = new System.Drawing.Point(212, 176);
            this.CalProgrammation.Margin = new System.Windows.Forms.Padding(3);
            this.CalProgrammation.MinDate = new System.DateTime(2023, 1, 1, 0, 0, 0, 0);
            this.CalProgrammation.Name = "CalProgrammation";
            this.CalProgrammation.TabIndex = 39;
            this.CalProgrammation.TitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.CalProgrammation.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.CalProgrammation_DateSelected);
            // 
            // frmAjoutProgrammation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 500);
            this.Controls.Add(this.CalProgrammation);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbCine);
            this.Controls.Add(this.lblErreur);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.label2);
            this.Name = "frmAjoutProgrammation";
            this.Text = "Ajout Programmation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblErreur;
        private Label label6;
        private Button btCancel;
        private Button btSave;
        private Label label2;
        private ComboBox cmbCine;
        private Label label3;
        private MonthCalendar CalProgrammation;
    }
}
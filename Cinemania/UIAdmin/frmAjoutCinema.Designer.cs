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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom du cinema";
            // 
            // txtNomCinema
            // 
            this.txtNomCinema.Location = new System.Drawing.Point(190, 130);
            this.txtNomCinema.Name = "txtNomCinema";
            this.txtNomCinema.Size = new System.Drawing.Size(169, 23);
            this.txtNomCinema.TabIndex = 1;
            // 
            // txtAdresseCinema
            // 
            this.txtAdresseCinema.Location = new System.Drawing.Point(190, 187);
            this.txtAdresseCinema.Name = "txtAdresseCinema";
            this.txtAdresseCinema.Size = new System.Drawing.Size(169, 23);
            this.txtAdresseCinema.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Adresse du cinema";
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(58, 318);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(121, 30);
            this.btSave.TabIndex = 4;
            this.btSave.Text = "Ajouter Cinema";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(239, 318);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(120, 30);
            this.btCancel.TabIndex = 5;
            this.btCancel.Text = "Annuler";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // frmAjoutCinema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.txtAdresseCinema);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNomCinema);
            this.Controls.Add(this.label1);
            this.Name = "frmAjoutCinema";
            this.Text = "FormAjoutCinema";
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
    }
}
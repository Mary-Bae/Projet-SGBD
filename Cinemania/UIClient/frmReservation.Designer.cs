namespace UIClient
{
    partial class frmReservation
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
            this.lblSalle = new System.Windows.Forms.Label();
            this.tblPanelSeats = new System.Windows.Forms.TableLayoutPanel();
            this.btCancel = new System.Windows.Forms.Button();
            this.btReserver = new System.Windows.Forms.Button();
            this.nbrTickets = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rbtVirement = new System.Windows.Forms.RadioButton();
            this.rbtAbonnement = new System.Windows.Forms.RadioButton();
            this.btChoix = new System.Windows.Forms.Button();
            this.txtUid = new System.Windows.Forms.TextBox();
            this.lblUid = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nbrTickets)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCinemaNom
            // 
            this.lblCinemaNom.AutoSize = true;
            this.lblCinemaNom.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCinemaNom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblCinemaNom.Location = new System.Drawing.Point(47, 37);
            this.lblCinemaNom.Name = "lblCinemaNom";
            this.lblCinemaNom.Size = new System.Drawing.Size(0, 38);
            this.lblCinemaNom.TabIndex = 31;
            // 
            // lblSalle
            // 
            this.lblSalle.AutoSize = true;
            this.lblSalle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSalle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblSalle.Location = new System.Drawing.Point(47, 100);
            this.lblSalle.Name = "lblSalle";
            this.lblSalle.Size = new System.Drawing.Size(0, 32);
            this.lblSalle.TabIndex = 32;
            // 
            // tblPanelSeats
            // 
            this.tblPanelSeats.ColumnCount = 1;
            this.tblPanelSeats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblPanelSeats.Location = new System.Drawing.Point(241, 164);
            this.tblPanelSeats.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tblPanelSeats.Name = "tblPanelSeats";
            this.tblPanelSeats.RowCount = 1;
            this.tblPanelSeats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblPanelSeats.Size = new System.Drawing.Size(517, 269);
            this.tblPanelSeats.TabIndex = 33;
            // 
            // btCancel
            // 
            this.btCancel.BackColor = System.Drawing.Color.Snow;
            this.btCancel.Location = new System.Drawing.Point(615, 581);
            this.btCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(143, 44);
            this.btCancel.TabIndex = 39;
            this.btCancel.Text = "Retour";
            this.btCancel.UseVisualStyleBackColor = false;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btReserver
            // 
            this.btReserver.BackColor = System.Drawing.Color.Snow;
            this.btReserver.Location = new System.Drawing.Point(241, 581);
            this.btReserver.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btReserver.Name = "btReserver";
            this.btReserver.Size = new System.Drawing.Size(143, 44);
            this.btReserver.TabIndex = 38;
            this.btReserver.Text = "Payer Reservation";
            this.btReserver.UseVisualStyleBackColor = false;
            this.btReserver.Click += new System.EventHandler(this.btReserver_Click);
            // 
            // nbrTickets
            // 
            this.nbrTickets.Location = new System.Drawing.Point(33, 201);
            this.nbrTickets.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nbrTickets.Name = "nbrTickets";
            this.nbrTickets.Size = new System.Drawing.Size(137, 27);
            this.nbrTickets.TabIndex = 40;
            this.nbrTickets.ValueChanged += new System.EventHandler(this.nbrTickets_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 20);
            this.label1.TabIndex = 41;
            this.label1.Text = "Nombre de réservations";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.ForeColor = System.Drawing.Color.Red;
            this.lblTotal.Location = new System.Drawing.Point(33, 312);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(0, 20);
            this.lblTotal.TabIndex = 43;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 267);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 20);
            this.label2.TabIndex = 44;
            this.label2.Text = "Prix du ticket : 10€";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 368);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 20);
            this.label3.TabIndex = 45;
            this.label3.Text = "Preference de payement";
            // 
            // rbtVirement
            // 
            this.rbtVirement.AutoSize = true;
            this.rbtVirement.Location = new System.Drawing.Point(33, 408);
            this.rbtVirement.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbtVirement.Name = "rbtVirement";
            this.rbtVirement.Size = new System.Drawing.Size(90, 24);
            this.rbtVirement.TabIndex = 46;
            this.rbtVirement.TabStop = true;
            this.rbtVirement.Text = "Virement";
            this.rbtVirement.UseVisualStyleBackColor = true;
            // 
            // rbtAbonnement
            // 
            this.rbtAbonnement.AutoSize = true;
            this.rbtAbonnement.Location = new System.Drawing.Point(33, 441);
            this.rbtAbonnement.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbtAbonnement.Name = "rbtAbonnement";
            this.rbtAbonnement.Size = new System.Drawing.Size(116, 24);
            this.rbtAbonnement.TabIndex = 47;
            this.rbtAbonnement.TabStop = true;
            this.rbtAbonnement.Text = "Abonnement";
            this.rbtAbonnement.UseVisualStyleBackColor = true;
            this.rbtAbonnement.CheckedChanged += new System.EventHandler(this.rbtAbonnement_CheckedChanged);
            // 
            // btChoix
            // 
            this.btChoix.BackColor = System.Drawing.Color.Snow;
            this.btChoix.Location = new System.Drawing.Point(27, 495);
            this.btChoix.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btChoix.Name = "btChoix";
            this.btChoix.Size = new System.Drawing.Size(143, 44);
            this.btChoix.TabIndex = 48;
            this.btChoix.Text = "Choix de payement";
            this.btChoix.UseVisualStyleBackColor = false;
            this.btChoix.Click += new System.EventHandler(this.btChoix_Click);
            // 
            // txtUid
            // 
            this.txtUid.Location = new System.Drawing.Point(241, 503);
            this.txtUid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUid.Name = "txtUid";
            this.txtUid.Size = new System.Drawing.Size(516, 27);
            this.txtUid.TabIndex = 49;
            // 
            // lblUid
            // 
            this.lblUid.AutoSize = true;
            this.lblUid.Location = new System.Drawing.Point(241, 467);
            this.lblUid.Name = "lblUid";
            this.lblUid.Size = new System.Drawing.Size(412, 20);
            this.lblUid.TabIndex = 50;
            this.lblUid.Text = "Rentrez ici votre UID et confirmez la reservation pour valider.";
            // 
            // frmReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(878, 681);
            this.ControlBox = false;
            this.Controls.Add(this.lblUid);
            this.Controls.Add(this.txtUid);
            this.Controls.Add(this.btChoix);
            this.Controls.Add(this.rbtAbonnement);
            this.Controls.Add(this.rbtVirement);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nbrTickets);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btReserver);
            this.Controls.Add(this.tblPanelSeats);
            this.Controls.Add(this.lblSalle);
            this.Controls.Add(this.lblCinemaNom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmReservation";
            this.Text = "Reservation";
            ((System.ComponentModel.ISupportInitialize)(this.nbrTickets)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblCinemaNom;
        private Label lblSalle;
        private TableLayoutPanel tblPanelSeats;
        private Button btCancel;
        private Button btReserver;
        private NumericUpDown nbrTickets;
        private Label label1;
        private Label lblTotal;
        private Label label2;
        private Label label3;
        private RadioButton rbtVirement;
        private RadioButton rbtAbonnement;
        private Button btChoix;
        private TextBox txtUid;
        private Label lblUid;
    }
}
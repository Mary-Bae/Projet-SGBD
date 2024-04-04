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
            ((System.ComponentModel.ISupportInitialize)(this.nbrTickets)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCinemaNom
            // 
            this.lblCinemaNom.AutoSize = true;
            this.lblCinemaNom.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCinemaNom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblCinemaNom.Location = new System.Drawing.Point(41, 28);
            this.lblCinemaNom.Name = "lblCinemaNom";
            this.lblCinemaNom.Size = new System.Drawing.Size(0, 30);
            this.lblCinemaNom.TabIndex = 31;
            // 
            // lblSalle
            // 
            this.lblSalle.AutoSize = true;
            this.lblSalle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSalle.Location = new System.Drawing.Point(41, 85);
            this.lblSalle.Name = "lblSalle";
            this.lblSalle.Size = new System.Drawing.Size(0, 21);
            this.lblSalle.TabIndex = 32;
            // 
            // tblPanelSeats
            // 
            this.tblPanelSeats.ColumnCount = 1;
            this.tblPanelSeats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblPanelSeats.Location = new System.Drawing.Point(183, 123);
            this.tblPanelSeats.Name = "tblPanelSeats";
            this.tblPanelSeats.RowCount = 1;
            this.tblPanelSeats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblPanelSeats.Size = new System.Drawing.Size(478, 265);
            this.tblPanelSeats.TabIndex = 33;
            // 
            // btCancel
            // 
            this.btCancel.BackColor = System.Drawing.Color.Snow;
            this.btCancel.Location = new System.Drawing.Point(463, 415);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(125, 33);
            this.btCancel.TabIndex = 39;
            this.btCancel.Text = "Retour";
            this.btCancel.UseVisualStyleBackColor = false;
            // 
            // btReserver
            // 
            this.btReserver.BackColor = System.Drawing.Color.Snow;
            this.btReserver.Location = new System.Drawing.Point(211, 415);
            this.btReserver.Name = "btReserver";
            this.btReserver.Size = new System.Drawing.Size(125, 33);
            this.btReserver.TabIndex = 38;
            this.btReserver.Text = "Reserver";
            this.btReserver.UseVisualStyleBackColor = false;
            this.btReserver.Click += new System.EventHandler(this.btReserver_Click);
            // 
            // nbrTickets
            // 
            this.nbrTickets.Location = new System.Drawing.Point(29, 174);
            this.nbrTickets.Name = "nbrTickets";
            this.nbrTickets.Size = new System.Drawing.Size(120, 23);
            this.nbrTickets.TabIndex = 40;
            this.nbrTickets.ValueChanged += new System.EventHandler(this.nbrTickets_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 15);
            this.label1.TabIndex = 41;
            this.label1.Text = "Nombre de réservations";
            // 
            // frmReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 502);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nbrTickets);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btReserver);
            this.Controls.Add(this.tblPanelSeats);
            this.Controls.Add(this.lblSalle);
            this.Controls.Add(this.lblCinemaNom);
            this.Name = "frmReservation";
            this.Text = "frmReservation";
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
    }
}
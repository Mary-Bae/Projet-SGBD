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
            // frmReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblSalle);
            this.Controls.Add(this.lblCinemaNom);
            this.Name = "frmReservation";
            this.Text = "frmReservation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblCinemaNom;
        private Label lblSalle;
    }
}
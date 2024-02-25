namespace UIAdmin
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btGetCinemas = new System.Windows.Forms.Button();
            this.dgvCine = new System.Windows.Forms.DataGridView();
            this.btDelCinemas = new System.Windows.Forms.Button();
            this.btUpdate = new System.Windows.Forms.Button();
            this.labelTitre = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCine)).BeginInit();
            this.SuspendLayout();
            // 
            // btGetCinemas
            // 
            this.btGetCinemas.BackColor = System.Drawing.SystemColors.Info;
            this.btGetCinemas.Location = new System.Drawing.Point(27, 100);
            this.btGetCinemas.Name = "btGetCinemas";
            this.btGetCinemas.Size = new System.Drawing.Size(92, 40);
            this.btGetCinemas.TabIndex = 0;
            this.btGetCinemas.Text = "Get Cinemas";
            this.btGetCinemas.UseVisualStyleBackColor = false;
            this.btGetCinemas.Click += new System.EventHandler(this.btGetCinemas_Click);
            // 
            // dgvCine
            // 
            this.dgvCine.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCine.BackgroundColor = System.Drawing.Color.Salmon;
            this.dgvCine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCine.Location = new System.Drawing.Point(27, 180);
            this.dgvCine.Name = "dgvCine";
            this.dgvCine.RowTemplate.Height = 25;
            this.dgvCine.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvCine.Size = new System.Drawing.Size(742, 231);
            this.dgvCine.TabIndex = 1;
            // 
            // btDelCinemas
            // 
            this.btDelCinemas.BackColor = System.Drawing.SystemColors.Info;
            this.btDelCinemas.Location = new System.Drawing.Point(164, 100);
            this.btDelCinemas.Name = "btDelCinemas";
            this.btDelCinemas.Size = new System.Drawing.Size(99, 40);
            this.btDelCinemas.TabIndex = 2;
            this.btDelCinemas.Text = "Del Cinemas";
            this.btDelCinemas.UseVisualStyleBackColor = false;
            this.btDelCinemas.Click += new System.EventHandler(this.btDelCinemas_Click);
            // 
            // btUpdate
            // 
            this.btUpdate.BackColor = System.Drawing.SystemColors.Info;
            this.btUpdate.Location = new System.Drawing.Point(306, 100);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(99, 40);
            this.btUpdate.TabIndex = 3;
            this.btUpdate.Text = "Upd Cinemas";
            this.btUpdate.UseVisualStyleBackColor = false;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // labelTitre
            // 
            this.labelTitre.AutoSize = true;
            this.labelTitre.Font = new System.Drawing.Font("Trebuchet MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTitre.ForeColor = System.Drawing.Color.Maroon;
            this.labelTitre.Location = new System.Drawing.Point(38, 21);
            this.labelTitre.Name = "labelTitre";
            this.labelTitre.Size = new System.Drawing.Size(365, 35);
            this.labelTitre.TabIndex = 4;
            this.labelTitre.Text = "Administration des cinemas";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelTitre);
            this.Controls.Add(this.btUpdate);
            this.Controls.Add(this.btDelCinemas);
            this.Controls.Add(this.dgvCine);
            this.Controls.Add(this.btGetCinemas);
            this.Name = "Form1";
            this.Text = "Administration";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCine)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btGetCinemas;
        private DataGridView dgvCine;
        private Button btDelCinemas;
        private Button btUpdate;
        private Label labelTitre;
    }
}
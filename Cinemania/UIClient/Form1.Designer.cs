namespace UIClient
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
            this.btCine = new System.Windows.Forms.Button();
            this.dgvCine = new System.Windows.Forms.DataGridView();
            this.bt1 = new System.Windows.Forms.Button();
            this.labelTitre = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCine)).BeginInit();
            this.SuspendLayout();
            // 
            // btCine
            // 
            this.btCine.BackColor = System.Drawing.SystemColors.Info;
            this.btCine.Location = new System.Drawing.Point(61, 83);
            this.btCine.Name = "btCine";
            this.btCine.Size = new System.Drawing.Size(116, 34);
            this.btCine.TabIndex = 0;
            this.btCine.Text = "Choix du cinema";
            this.btCine.UseVisualStyleBackColor = false;
            this.btCine.Click += new System.EventHandler(this.btCine_Click);
            // 
            // dgvCine
            // 
            this.dgvCine.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCine.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dgvCine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCine.Location = new System.Drawing.Point(61, 141);
            this.dgvCine.Name = "dgvCine";
            this.dgvCine.RowTemplate.Height = 25;
            this.dgvCine.Size = new System.Drawing.Size(696, 217);
            this.dgvCine.TabIndex = 1;
            // 
            // bt1
            // 
            this.bt1.Location = new System.Drawing.Point(61, 364);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(30, 23);
            this.bt1.TabIndex = 2;
            this.bt1.Text = "1";
            this.bt1.UseVisualStyleBackColor = true;
            this.bt1.Click += new System.EventHandler(this.bt1_Click);
            // 
            // labelTitre
            // 
            this.labelTitre.AutoSize = true;
            this.labelTitre.Font = new System.Drawing.Font("Stencil", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTitre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelTitre.Location = new System.Drawing.Point(61, 24);
            this.labelTitre.Name = "labelTitre";
            this.labelTitre.Size = new System.Drawing.Size(386, 32);
            this.labelTitre.TabIndex = 3;
            this.labelTitre.Text = "Bienvenue chez Cinemania";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelTitre);
            this.Controls.Add(this.bt1);
            this.Controls.Add(this.dgvCine);
            this.Controls.Add(this.btCine);
            this.Name = "Form1";
            this.Text = "Cinemania";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCine)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btCine;
        private DataGridView dgvCine;
        private Button bt1;
        private Label labelTitre;
    }
}
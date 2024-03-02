﻿namespace UIAdmin
{
    partial class frmAdmin
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
            this.components = new System.ComponentModel.Container();
            this.btGetCinemas = new System.Windows.Forms.Button();
            this.dgvCine = new System.Windows.Forms.DataGridView();
            this.MenuCinema = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ajouterCinemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierCinemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerCinémaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btUpdate = new System.Windows.Forms.Button();
            this.labelTitre = new System.Windows.Forms.Label();
            this.dgvChaine = new System.Windows.Forms.DataGridView();
            this.MenuChaine = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.supprimerChaineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCine)).BeginInit();
            this.MenuCinema.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChaine)).BeginInit();
            this.MenuChaine.SuspendLayout();
            this.SuspendLayout();
            // 
            // btGetCinemas
            // 
            this.btGetCinemas.BackColor = System.Drawing.SystemColors.Info;
            this.btGetCinemas.Location = new System.Drawing.Point(665, 90);
            this.btGetCinemas.Name = "btGetCinemas";
            this.btGetCinemas.Size = new System.Drawing.Size(114, 40);
            this.btGetCinemas.TabIndex = 0;
            this.btGetCinemas.Text = "Tous les Cinemas";
            this.btGetCinemas.UseVisualStyleBackColor = false;
            this.btGetCinemas.Click += new System.EventHandler(this.btGetCinemas_Click);
            // 
            // dgvCine
            // 
            this.dgvCine.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCine.BackgroundColor = System.Drawing.Color.Salmon;
            this.dgvCine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCine.ContextMenuStrip = this.MenuCinema;
            this.dgvCine.Location = new System.Drawing.Point(290, 198);
            this.dgvCine.Name = "dgvCine";
            this.dgvCine.RowHeadersWidth = 51;
            this.dgvCine.RowTemplate.Height = 25;
            this.dgvCine.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCine.Size = new System.Drawing.Size(498, 231);
            this.dgvCine.TabIndex = 1;
            // 
            // MenuCinema
            // 
            this.MenuCinema.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuCinema.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterCinemaToolStripMenuItem,
            this.modifierCinemaToolStripMenuItem,
            this.supprimerCinémaToolStripMenuItem});
            this.MenuCinema.Name = "MenuCinema";
            this.MenuCinema.Size = new System.Drawing.Size(174, 70);
            // 
            // ajouterCinemaToolStripMenuItem
            // 
            this.ajouterCinemaToolStripMenuItem.Name = "ajouterCinemaToolStripMenuItem";
            this.ajouterCinemaToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.ajouterCinemaToolStripMenuItem.Text = "Ajouter Cinéma";
            // 
            // modifierCinemaToolStripMenuItem
            // 
            this.modifierCinemaToolStripMenuItem.Name = "modifierCinemaToolStripMenuItem";
            this.modifierCinemaToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.modifierCinemaToolStripMenuItem.Text = "Modifier Cinéma";
            // 
            // supprimerCinémaToolStripMenuItem
            // 
            this.supprimerCinémaToolStripMenuItem.Name = "supprimerCinémaToolStripMenuItem";
            this.supprimerCinémaToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.supprimerCinémaToolStripMenuItem.Text = "Supprimer Cinéma";
            this.supprimerCinémaToolStripMenuItem.Click += new System.EventHandler(this.supprimerCinémaToolStripMenuItem_Click);
            // 
            // btUpdate
            // 
            this.btUpdate.BackColor = System.Drawing.SystemColors.Info;
            this.btUpdate.Location = new System.Drawing.Point(542, 90);
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
            // dgvChaine
            // 
            this.dgvChaine.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChaine.BackgroundColor = System.Drawing.Color.Salmon;
            this.dgvChaine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChaine.ContextMenuStrip = this.MenuChaine;
            this.dgvChaine.Location = new System.Drawing.Point(22, 198);
            this.dgvChaine.Name = "dgvChaine";
            this.dgvChaine.RowHeadersWidth = 51;
            this.dgvChaine.RowTemplate.Height = 25;
            this.dgvChaine.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChaine.Size = new System.Drawing.Size(241, 231);
            this.dgvChaine.TabIndex = 5;
            this.dgvChaine.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChaine_CellEndEdit);
            this.dgvChaine.SelectionChanged += new System.EventHandler(this.dgvChaines_SelectionChanged);
            // 
            // MenuChaine
            // 
            this.MenuChaine.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuChaine.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.supprimerChaineToolStripMenuItem});
            this.MenuChaine.Name = "MenuChaine";
            this.MenuChaine.Size = new System.Drawing.Size(170, 26);
            // 
            // supprimerChaineToolStripMenuItem
            // 
            this.supprimerChaineToolStripMenuItem.Name = "supprimerChaineToolStripMenuItem";
            this.supprimerChaineToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.supprimerChaineToolStripMenuItem.Text = "Supprimer Chaine";
            this.supprimerChaineToolStripMenuItem.Click += new System.EventHandler(this.supprimerChaineToolStripMenuItem_Click);
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvChaine);
            this.Controls.Add(this.labelTitre);
            this.Controls.Add(this.btUpdate);
            this.Controls.Add(this.dgvCine);
            this.Controls.Add(this.btGetCinemas);
            this.Name = "frmAdmin";
            this.Text = "Administration";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCine)).EndInit();
            this.MenuCinema.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChaine)).EndInit();
            this.MenuChaine.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btGetCinemas;
        private DataGridView dgvCine;
        private Button btUpdate;
        private Label labelTitre;
        private DataGridView dgvChaine;
        private ContextMenuStrip MenuCinema;
        private ToolStripMenuItem ajouterCinemaToolStripMenuItem;
        private ToolStripMenuItem modifierCinemaToolStripMenuItem;
        private ToolStripMenuItem supprimerCinémaToolStripMenuItem;
        private ContextMenuStrip MenuChaine;
        private ToolStripMenuItem supprimerChaineToolStripMenuItem;
    }
}
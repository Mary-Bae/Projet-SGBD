namespace UIAdmin
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btGetCinemas = new System.Windows.Forms.Button();
            this.dgvCine = new System.Windows.Forms.DataGridView();
            this.MenuCinema = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.supprimerCinémaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierCinémaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelTitre = new System.Windows.Forms.Label();
            this.dgvChaine = new System.Windows.Forms.DataGridView();
            this.MenuChaine = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.supprimerChaineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierChaineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btAjoutercinema = new System.Windows.Forms.Button();
            this.dgvSalles = new System.Windows.Forms.DataGridView();
            this.MenuSalle = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.supprimerSalleDeCinemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierSalleDeCinemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btAddSalle = new System.Windows.Forms.Button();
            this.btAddChaine = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCine)).BeginInit();
            this.MenuCinema.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChaine)).BeginInit();
            this.MenuChaine.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalles)).BeginInit();
            this.MenuSalle.SuspendLayout();
            this.SuspendLayout();
            // 
            // btGetCinemas
            // 
            this.btGetCinemas.BackColor = System.Drawing.SystemColors.Info;
            this.btGetCinemas.Location = new System.Drawing.Point(369, 156);
            this.btGetCinemas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btGetCinemas.Name = "btGetCinemas";
            this.btGetCinemas.Size = new System.Drawing.Size(736, 53);
            this.btGetCinemas.TabIndex = 0;
            this.btGetCinemas.Text = "Visualisation de tous les Cinemas";
            this.btGetCinemas.UseVisualStyleBackColor = false;
            this.btGetCinemas.Click += new System.EventHandler(this.btGetCinemas_Click);
            // 
            // dgvCine
            // 
            this.dgvCine.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCine.BackgroundColor = System.Drawing.Color.Salmon;
            this.dgvCine.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCine.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCine.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvCine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCine.ContextMenuStrip = this.MenuCinema;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Salmon;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCine.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvCine.EnableHeadersVisualStyles = false;
            this.dgvCine.Location = new System.Drawing.Point(368, 217);
            this.dgvCine.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvCine.Name = "dgvCine";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.Salmon;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCine.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvCine.RowHeadersWidth = 51;
            this.dgvCine.RowTemplate.Height = 25;
            this.dgvCine.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCine.Size = new System.Drawing.Size(737, 308);
            this.dgvCine.TabIndex = 1;
            this.dgvCine.SelectionChanged += new System.EventHandler(this.dgvCine_SelectionChanged);
            // 
            // MenuCinema
            // 
            this.MenuCinema.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuCinema.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.supprimerCinémaToolStripMenuItem,
            this.modifierCinémaToolStripMenuItem});
            this.MenuCinema.Name = "MenuCinema";
            this.MenuCinema.Size = new System.Drawing.Size(202, 52);
            // 
            // supprimerCinémaToolStripMenuItem
            // 
            this.supprimerCinémaToolStripMenuItem.Name = "supprimerCinémaToolStripMenuItem";
            this.supprimerCinémaToolStripMenuItem.Size = new System.Drawing.Size(201, 24);
            this.supprimerCinémaToolStripMenuItem.Text = "Supprimer Cinéma";
            this.supprimerCinémaToolStripMenuItem.Click += new System.EventHandler(this.supprimerCinémaToolStripMenuItem_Click);
            // 
            // modifierCinémaToolStripMenuItem
            // 
            this.modifierCinémaToolStripMenuItem.Name = "modifierCinémaToolStripMenuItem";
            this.modifierCinémaToolStripMenuItem.Size = new System.Drawing.Size(201, 24);
            this.modifierCinémaToolStripMenuItem.Text = "Modifier Cinéma";
            this.modifierCinémaToolStripMenuItem.Click += new System.EventHandler(this.modifierCinémaToolStripMenuItem_Click);
            // 
            // labelTitre
            // 
            this.labelTitre.AutoSize = true;
            this.labelTitre.Font = new System.Drawing.Font("Trebuchet MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTitre.ForeColor = System.Drawing.Color.Maroon;
            this.labelTitre.Location = new System.Drawing.Point(43, 28);
            this.labelTitre.Name = "labelTitre";
            this.labelTitre.Size = new System.Drawing.Size(456, 43);
            this.labelTitre.TabIndex = 4;
            this.labelTitre.Text = "Administration des cinemas";
            // 
            // dgvChaine
            // 
            this.dgvChaine.AllowUserToAddRows = false;
            this.dgvChaine.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChaine.BackgroundColor = System.Drawing.Color.Salmon;
            this.dgvChaine.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvChaine.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvChaine.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvChaine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChaine.ContextMenuStrip = this.MenuChaine;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.Salmon;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvChaine.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvChaine.EnableHeadersVisualStyles = false;
            this.dgvChaine.Location = new System.Drawing.Point(25, 217);
            this.dgvChaine.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvChaine.Name = "dgvChaine";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.Salmon;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvChaine.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvChaine.RowHeadersWidth = 51;
            this.dgvChaine.RowTemplate.Height = 25;
            this.dgvChaine.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChaine.Size = new System.Drawing.Size(322, 695);
            this.dgvChaine.TabIndex = 5;
            this.dgvChaine.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChaine_CellEndEdit);
            this.dgvChaine.SelectionChanged += new System.EventHandler(this.dgvChaines_SelectionChanged);
            // 
            // MenuChaine
            // 
            this.MenuChaine.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuChaine.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.supprimerChaineToolStripMenuItem,
            this.modifierChaineToolStripMenuItem});
            this.MenuChaine.Name = "MenuChaine";
            this.MenuChaine.Size = new System.Drawing.Size(197, 52);
            // 
            // supprimerChaineToolStripMenuItem
            // 
            this.supprimerChaineToolStripMenuItem.Name = "supprimerChaineToolStripMenuItem";
            this.supprimerChaineToolStripMenuItem.Size = new System.Drawing.Size(196, 24);
            this.supprimerChaineToolStripMenuItem.Text = "Supprimer Chaine";
            this.supprimerChaineToolStripMenuItem.Click += new System.EventHandler(this.supprimerChaineToolStripMenuItem_Click);
            // 
            // modifierChaineToolStripMenuItem
            // 
            this.modifierChaineToolStripMenuItem.Name = "modifierChaineToolStripMenuItem";
            this.modifierChaineToolStripMenuItem.Size = new System.Drawing.Size(196, 24);
            this.modifierChaineToolStripMenuItem.Text = "Modifier Chaine";
            this.modifierChaineToolStripMenuItem.Click += new System.EventHandler(this.modifierChaineToolStripMenuItem_Click);
            // 
            // btAjoutercinema
            // 
            this.btAjoutercinema.BackColor = System.Drawing.SystemColors.Info;
            this.btAjoutercinema.Location = new System.Drawing.Point(25, 156);
            this.btAjoutercinema.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btAjoutercinema.Name = "btAjoutercinema";
            this.btAjoutercinema.Size = new System.Drawing.Size(322, 53);
            this.btAjoutercinema.TabIndex = 6;
            this.btAjoutercinema.Text = "Ajout nouveau cinema -->";
            this.btAjoutercinema.UseVisualStyleBackColor = false;
            this.btAjoutercinema.Click += new System.EventHandler(this.btAjoutercinema_Click);
            // 
            // dgvSalles
            // 
            this.dgvSalles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSalles.BackgroundColor = System.Drawing.Color.Salmon;
            this.dgvSalles.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvSalles.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSalles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSalles.ContextMenuStrip = this.MenuSalle;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Salmon;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSalles.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSalles.EnableHeadersVisualStyles = false;
            this.dgvSalles.Location = new System.Drawing.Point(367, 594);
            this.dgvSalles.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvSalles.Name = "dgvSalles";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Salmon;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSalles.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSalles.RowHeadersWidth = 51;
            this.dgvSalles.RowTemplate.Height = 25;
            this.dgvSalles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSalles.Size = new System.Drawing.Size(738, 309);
            this.dgvSalles.TabIndex = 7;
            // 
            // MenuSalle
            // 
            this.MenuSalle.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuSalle.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.supprimerSalleDeCinemaToolStripMenuItem,
            this.modifierSalleDeCinemaToolStripMenuItem});
            this.MenuSalle.Name = "MenuSalle";
            this.MenuSalle.Size = new System.Drawing.Size(255, 52);
            // 
            // supprimerSalleDeCinemaToolStripMenuItem
            // 
            this.supprimerSalleDeCinemaToolStripMenuItem.Name = "supprimerSalleDeCinemaToolStripMenuItem";
            this.supprimerSalleDeCinemaToolStripMenuItem.Size = new System.Drawing.Size(254, 24);
            this.supprimerSalleDeCinemaToolStripMenuItem.Text = "Supprimer salle de cinema";
            this.supprimerSalleDeCinemaToolStripMenuItem.Click += new System.EventHandler(this.supprimerSalleDeCinemaToolStripMenuItem_Click);
            // 
            // modifierSalleDeCinemaToolStripMenuItem
            // 
            this.modifierSalleDeCinemaToolStripMenuItem.Name = "modifierSalleDeCinemaToolStripMenuItem";
            this.modifierSalleDeCinemaToolStripMenuItem.Size = new System.Drawing.Size(254, 24);
            this.modifierSalleDeCinemaToolStripMenuItem.Text = "Modifier salle de cinema";
            this.modifierSalleDeCinemaToolStripMenuItem.Click += new System.EventHandler(this.modifierSalleDeCinemaToolStripMenuItem_Click);
            // 
            // btAddSalle
            // 
            this.btAddSalle.BackColor = System.Drawing.SystemColors.Info;
            this.btAddSalle.Location = new System.Drawing.Point(368, 533);
            this.btAddSalle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btAddSalle.Name = "btAddSalle";
            this.btAddSalle.Size = new System.Drawing.Size(737, 53);
            this.btAddSalle.TabIndex = 8;
            this.btAddSalle.Text = "Ajout nouvelle salle de cinema";
            this.btAddSalle.UseVisualStyleBackColor = false;
            this.btAddSalle.Click += new System.EventHandler(this.btAddSalle_Click);
            // 
            // btAddChaine
            // 
            this.btAddChaine.BackColor = System.Drawing.SystemColors.Info;
            this.btAddChaine.Location = new System.Drawing.Point(25, 95);
            this.btAddChaine.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btAddChaine.Name = "btAddChaine";
            this.btAddChaine.Size = new System.Drawing.Size(322, 53);
            this.btAddChaine.TabIndex = 9;
            this.btAddChaine.Text = "Ajout nouvelle chaine de cinéma";
            this.btAddChaine.UseVisualStyleBackColor = false;
            this.btAddChaine.Click += new System.EventHandler(this.btAddChaine_Click);
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1266, 928);
            this.Controls.Add(this.btAddChaine);
            this.Controls.Add(this.btAddSalle);
            this.Controls.Add(this.dgvSalles);
            this.Controls.Add(this.btAjoutercinema);
            this.Controls.Add(this.dgvChaine);
            this.Controls.Add(this.labelTitre);
            this.Controls.Add(this.dgvCine);
            this.Controls.Add(this.btGetCinemas);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmAdmin";
            this.Text = "Administration";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dgvCine)).EndInit();
            this.MenuCinema.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChaine)).EndInit();
            this.MenuChaine.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalles)).EndInit();
            this.MenuSalle.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btGetCinemas;
        private DataGridView dgvCine;
        private Label labelTitre;
        private DataGridView dgvChaine;
        private ContextMenuStrip MenuCinema;
        private ToolStripMenuItem supprimerCinémaToolStripMenuItem;
        private ContextMenuStrip MenuChaine;
        private ToolStripMenuItem supprimerChaineToolStripMenuItem;
        private Button btAjoutercinema;
        private DataGridView dgvSalles;
        private Button btAddSalle;
        private ContextMenuStrip MenuSalle;
        private ToolStripMenuItem supprimerSalleDeCinemaToolStripMenuItem;
        private ToolStripMenuItem modifierSalleDeCinemaToolStripMenuItem;
        private ToolStripMenuItem modifierCinémaToolStripMenuItem;
        private ToolStripMenuItem modifierChaineToolStripMenuItem;
        private Button btAddChaine;
    }
}
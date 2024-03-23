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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.MenuCinema = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.supprimerCinémaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierCinémaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuChaine = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.supprimerChaineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSalle = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.supprimerSalleDeCinemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierSalleDeCinemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabAdmin = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblStatusMessage = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvChaine = new System.Windows.Forms.DataGridView();
            this.dgvCine = new System.Windows.Forms.DataGridView();
            this.dgvSalles = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btAddChaine = new System.Windows.Forms.Button();
            this.btAjoutercinema = new System.Windows.Forms.Button();
            this.btAddSalle = new System.Windows.Forms.Button();
            this.btGetCinemas = new System.Windows.Forms.Button();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.labelTitre = new System.Windows.Forms.Label();
            this.tabProgrammation = new System.Windows.Forms.TabPage();
            this.MenuCinema.SuspendLayout();
            this.MenuChaine.SuspendLayout();
            this.MenuSalle.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabAdmin.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChaine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalles)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuCinema
            // 
            this.MenuCinema.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuCinema.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.supprimerCinémaToolStripMenuItem,
            this.modifierCinémaToolStripMenuItem});
            this.MenuCinema.Name = "MenuCinema";
            this.MenuCinema.Size = new System.Drawing.Size(174, 48);
            // 
            // supprimerCinémaToolStripMenuItem
            // 
            this.supprimerCinémaToolStripMenuItem.Name = "supprimerCinémaToolStripMenuItem";
            this.supprimerCinémaToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.supprimerCinémaToolStripMenuItem.Text = "Supprimer Cinéma";
            this.supprimerCinémaToolStripMenuItem.Click += new System.EventHandler(this.supprimerCinémaToolStripMenuItem_Click);
            // 
            // modifierCinémaToolStripMenuItem
            // 
            this.modifierCinémaToolStripMenuItem.Name = "modifierCinémaToolStripMenuItem";
            this.modifierCinémaToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.modifierCinémaToolStripMenuItem.Text = "Modifier Cinéma";
            this.modifierCinémaToolStripMenuItem.Click += new System.EventHandler(this.modifierCinémaToolStripMenuItem_Click);
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
            // MenuSalle
            // 
            this.MenuSalle.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuSalle.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.supprimerSalleDeCinemaToolStripMenuItem,
            this.modifierSalleDeCinemaToolStripMenuItem});
            this.MenuSalle.Name = "MenuSalle";
            this.MenuSalle.Size = new System.Drawing.Size(214, 48);
            // 
            // supprimerSalleDeCinemaToolStripMenuItem
            // 
            this.supprimerSalleDeCinemaToolStripMenuItem.Name = "supprimerSalleDeCinemaToolStripMenuItem";
            this.supprimerSalleDeCinemaToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.supprimerSalleDeCinemaToolStripMenuItem.Text = "Supprimer salle de cinema";
            this.supprimerSalleDeCinemaToolStripMenuItem.Click += new System.EventHandler(this.supprimerSalleDeCinemaToolStripMenuItem_Click);
            // 
            // modifierSalleDeCinemaToolStripMenuItem
            // 
            this.modifierSalleDeCinemaToolStripMenuItem.Name = "modifierSalleDeCinemaToolStripMenuItem";
            this.modifierSalleDeCinemaToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.modifierSalleDeCinemaToolStripMenuItem.Text = "Modifier salle de cinema";
            this.modifierSalleDeCinemaToolStripMenuItem.Click += new System.EventHandler(this.modifierSalleDeCinemaToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabAdmin);
            this.tabControl1.Controls.Add(this.tabProgrammation);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1037, 696);
            this.tabControl1.TabIndex = 3;
            // 
            // tabAdmin
            // 
            this.tabAdmin.BackColor = System.Drawing.Color.Black;
            this.tabAdmin.Controls.Add(this.tableLayoutPanel1);
            this.tabAdmin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabAdmin.Location = new System.Drawing.Point(4, 30);
            this.tabAdmin.Name = "tabAdmin";
            this.tabAdmin.Padding = new System.Windows.Forms.Padding(3);
            this.tabAdmin.Size = new System.Drawing.Size(1029, 662);
            this.tabAdmin.TabIndex = 0;
            this.tabAdmin.Text = "Administration Cinemas";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Black;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lblStatusMessage, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgvChaine, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.dgvCine, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.dgvSalles, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1023, 656);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblStatusMessage
            // 
            this.lblStatusMessage.AutoSize = true;
            this.lblStatusMessage.BackColor = System.Drawing.Color.Black;
            this.lblStatusMessage.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblStatusMessage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblStatusMessage.ForeColor = System.Drawing.Color.Red;
            this.lblStatusMessage.Location = new System.Drawing.Point(0, 590);
            this.lblStatusMessage.Margin = new System.Windows.Forms.Padding(0);
            this.lblStatusMessage.Name = "lblStatusMessage";
            this.lblStatusMessage.Size = new System.Drawing.Size(511, 21);
            this.lblStatusMessage.TabIndex = 20;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.Navy;
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.label1, 0, 2);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(511, 0);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 41.46341F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 58.53659F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(512, 156);
            this.tableLayoutPanel3.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(3, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(457, 58);
            this.label1.TabIndex = 13;
            this.label1.Text = "Administration cinemas";
            // 
            // dgvChaine
            // 
            this.dgvChaine.AllowUserToAddRows = false;
            this.dgvChaine.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChaine.BackgroundColor = System.Drawing.Color.Black;
            this.dgvChaine.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvChaine.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvChaine.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvChaine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChaine.ContextMenuStrip = this.MenuChaine;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvChaine.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvChaine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvChaine.EnableHeadersVisualStyles = false;
            this.dgvChaine.Location = new System.Drawing.Point(3, 167);
            this.dgvChaine.Name = "dgvChaine";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvChaine.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvChaine.RowHeadersWidth = 51;
            this.dgvChaine.RowTemplate.Height = 25;
            this.dgvChaine.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChaine.Size = new System.Drawing.Size(505, 158);
            this.dgvChaine.TabIndex = 13;
            this.dgvChaine.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChaine_CellEndEdit);
            this.dgvChaine.CurrentCellChanged += new System.EventHandler(this.dgvChaines_SelectionChanged);
            // 
            // dgvCine
            // 
            this.dgvCine.AllowUserToAddRows = false;
            this.dgvCine.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCine.BackgroundColor = System.Drawing.Color.Black;
            this.dgvCine.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCine.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCine.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvCine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCine.ContextMenuStrip = this.MenuCinema;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCine.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvCine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCine.EnableHeadersVisualStyles = false;
            this.dgvCine.Location = new System.Drawing.Point(3, 331);
            this.dgvCine.Name = "dgvCine";
            this.dgvCine.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCine.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvCine.RowHeadersWidth = 51;
            this.dgvCine.RowTemplate.Height = 25;
            this.dgvCine.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCine.Size = new System.Drawing.Size(505, 256);
            this.dgvCine.TabIndex = 11;
            this.dgvCine.CurrentCellChanged += new System.EventHandler(this.dgvCine_SelectionChanged);
            // 
            // dgvSalles
            // 
            this.dgvSalles.AllowUserToAddRows = false;
            this.dgvSalles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSalles.BackgroundColor = System.Drawing.Color.Black;
            this.dgvSalles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSalles.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSalles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvSalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSalles.ContextMenuStrip = this.MenuSalle;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSalles.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvSalles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSalles.EnableHeadersVisualStyles = false;
            this.dgvSalles.Location = new System.Drawing.Point(514, 331);
            this.dgvSalles.Name = "dgvSalles";
            this.dgvSalles.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSalles.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvSalles.RowHeadersWidth = 51;
            this.dgvSalles.RowTemplate.Height = 25;
            this.dgvSalles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSalles.Size = new System.Drawing.Size(506, 256);
            this.dgvSalles.TabIndex = 15;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.btAddChaine, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btAjoutercinema, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btAddSalle, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.btGetCinemas, 1, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(520, 172);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(494, 148);
            this.tableLayoutPanel2.TabIndex = 18;
            // 
            // btAddChaine
            // 
            this.btAddChaine.BackColor = System.Drawing.SystemColors.Info;
            this.btAddChaine.Dock = System.Windows.Forms.DockStyle.Top;
            this.btAddChaine.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btAddChaine.Location = new System.Drawing.Point(250, 3);
            this.btAddChaine.Name = "btAddChaine";
            this.btAddChaine.Size = new System.Drawing.Size(241, 68);
            this.btAddChaine.TabIndex = 17;
            this.btAddChaine.Text = "Ajout chaine de cinéma";
            this.btAddChaine.UseVisualStyleBackColor = false;
            this.btAddChaine.Click += new System.EventHandler(this.btAddChaine_Click);
            // 
            // btAjoutercinema
            // 
            this.btAjoutercinema.BackColor = System.Drawing.SystemColors.Info;
            this.btAjoutercinema.Dock = System.Windows.Forms.DockStyle.Top;
            this.btAjoutercinema.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btAjoutercinema.Location = new System.Drawing.Point(3, 3);
            this.btAjoutercinema.Name = "btAjoutercinema";
            this.btAjoutercinema.Size = new System.Drawing.Size(241, 68);
            this.btAjoutercinema.TabIndex = 14;
            this.btAjoutercinema.Text = "Ajout nouveau cinema ";
            this.btAjoutercinema.UseVisualStyleBackColor = false;
            this.btAjoutercinema.Click += new System.EventHandler(this.btAjoutercinema_Click);
            // 
            // btAddSalle
            // 
            this.btAddSalle.BackColor = System.Drawing.SystemColors.Info;
            this.btAddSalle.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btAddSalle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btAddSalle.Location = new System.Drawing.Point(3, 77);
            this.btAddSalle.Name = "btAddSalle";
            this.btAddSalle.Size = new System.Drawing.Size(241, 68);
            this.btAddSalle.TabIndex = 16;
            this.btAddSalle.Text = "Ajout salle de cinema";
            this.btAddSalle.UseVisualStyleBackColor = false;
            this.btAddSalle.Click += new System.EventHandler(this.btAddSalle_Click);
            // 
            // btGetCinemas
            // 
            this.btGetCinemas.BackColor = System.Drawing.SystemColors.Info;
            this.btGetCinemas.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btGetCinemas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btGetCinemas.Location = new System.Drawing.Point(250, 77);
            this.btGetCinemas.Name = "btGetCinemas";
            this.btGetCinemas.Size = new System.Drawing.Size(241, 68);
            this.btGetCinemas.TabIndex = 10;
            this.btGetCinemas.Text = "Visualiser tous les Cinemas";
            this.btGetCinemas.UseVisualStyleBackColor = false;
            this.btGetCinemas.Click += new System.EventHandler(this.btGetCinemas_Click);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.BackColor = System.Drawing.Color.Navy;
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.labelTitre, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.19665F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 72.80334F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(511, 156);
            this.tableLayoutPanel4.TabIndex = 19;
            // 
            // labelTitre
            // 
            this.labelTitre.AutoSize = true;
            this.labelTitre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTitre.Font = new System.Drawing.Font("Viner Hand ITC", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.labelTitre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.labelTitre.Location = new System.Drawing.Point(3, 38);
            this.labelTitre.Name = "labelTitre";
            this.labelTitre.Padding = new System.Windows.Forms.Padding(44, 0, 0, 0);
            this.labelTitre.Size = new System.Drawing.Size(505, 102);
            this.labelTitre.TabIndex = 13;
            this.labelTitre.Text = "CINEMANIA";
            // 
            // tabProgrammation
            // 
            this.tabProgrammation.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabProgrammation.Location = new System.Drawing.Point(4, 30);
            this.tabProgrammation.Name = "tabProgrammation";
            this.tabProgrammation.Padding = new System.Windows.Forms.Padding(3);
            this.tabProgrammation.Size = new System.Drawing.Size(1029, 662);
            this.tabProgrammation.TabIndex = 1;
            this.tabProgrammation.Text = "Programmation";
            this.tabProgrammation.UseVisualStyleBackColor = true;
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1037, 696);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmAdmin";
            this.Text = "Administration";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.MenuCinema.ResumeLayout(false);
            this.MenuChaine.ResumeLayout(false);
            this.MenuSalle.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabAdmin.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChaine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalles)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private ContextMenuStrip MenuCinema;
        private ToolStripMenuItem supprimerCinémaToolStripMenuItem;
        private ContextMenuStrip MenuChaine;
        private ToolStripMenuItem supprimerChaineToolStripMenuItem;
        private ContextMenuStrip MenuSalle;
        private ToolStripMenuItem supprimerSalleDeCinemaToolStripMenuItem;
        private ToolStripMenuItem modifierSalleDeCinemaToolStripMenuItem;
        private ToolStripMenuItem modifierCinémaToolStripMenuItem;
        private TabControl tabControl1;
        private TabPage tabAdmin;
        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView dgvSalles;
        private Button btAddSalle;
        private Button btAjoutercinema;
        private Button btAddChaine;
        private Button btGetCinemas;
        private DataGridView dgvChaine;
        private DataGridView dgvCine;
        private TabPage tabProgrammation;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel4;
        private Label labelTitre;
        private Label lblStatusMessage;
    }
}
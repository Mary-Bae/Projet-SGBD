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
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.btDelCinemas = new System.Windows.Forms.Button();
            this.btUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // btGetCinemas
            // 
            this.btGetCinemas.Location = new System.Drawing.Point(144, 105);
            this.btGetCinemas.Name = "btGetCinemas";
            this.btGetCinemas.Size = new System.Drawing.Size(92, 40);
            this.btGetCinemas.TabIndex = 0;
            this.btGetCinemas.Text = "Get Cinemas";
            this.btGetCinemas.UseVisualStyleBackColor = true;
            this.btGetCinemas.Click += new System.EventHandler(this.btGetCinemas_Click);
            // 
            // dataGrid
            // 
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Location = new System.Drawing.Point(144, 221);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.RowTemplate.Height = 25;
            this.dataGrid.Size = new System.Drawing.Size(378, 178);
            this.dataGrid.TabIndex = 1;
            // 
            // btDelCinemas
            // 
            this.btDelCinemas.Location = new System.Drawing.Point(281, 105);
            this.btDelCinemas.Name = "btDelCinemas";
            this.btDelCinemas.Size = new System.Drawing.Size(99, 40);
            this.btDelCinemas.TabIndex = 2;
            this.btDelCinemas.Text = "Del Cinemas";
            this.btDelCinemas.UseVisualStyleBackColor = true;
            this.btDelCinemas.Click += new System.EventHandler(this.btDelCinemas_Click);
            // 
            // btUpdate
            // 
            this.btUpdate.Location = new System.Drawing.Point(423, 105);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(99, 40);
            this.btUpdate.TabIndex = 3;
            this.btUpdate.Text = "Upd Cinemas";
            this.btUpdate.UseVisualStyleBackColor = true;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btUpdate);
            this.Controls.Add(this.btDelCinemas);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.btGetCinemas);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btGetCinemas;
        private DataGridView dataGrid;
        private Button btDelCinemas;
        private Button btUpdate;
    }
}
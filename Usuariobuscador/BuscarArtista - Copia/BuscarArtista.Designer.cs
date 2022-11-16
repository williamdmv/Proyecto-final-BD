namespace Usuariobuscador
{
    partial class BuscarArtista
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreartisticoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.generomusicalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artistaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtBuscador = new System.Windows.Forms.TextBox();
            this.Buscar = new System.Windows.Forms.Button();
            this.bunifuToggleSwitch21 = new Bunifu.UI.WinForms.BunifuToggleSwitch2();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artistaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreDataGridViewTextBoxColumn,
            this.apellidosDataGridViewTextBoxColumn,
            this.nombreartisticoDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn,
            this.generomusicalDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.artistaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(33, 155);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(729, 203);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.Width = 125;
            // 
            // apellidosDataGridViewTextBoxColumn
            // 
            this.apellidosDataGridViewTextBoxColumn.DataPropertyName = "Apellidos";
            this.apellidosDataGridViewTextBoxColumn.HeaderText = "Apellidos";
            this.apellidosDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.apellidosDataGridViewTextBoxColumn.Name = "apellidosDataGridViewTextBoxColumn";
            this.apellidosDataGridViewTextBoxColumn.Width = 125;
            // 
            // nombreartisticoDataGridViewTextBoxColumn
            // 
            this.nombreartisticoDataGridViewTextBoxColumn.DataPropertyName = "Nombreartistico";
            this.nombreartisticoDataGridViewTextBoxColumn.HeaderText = "Nombreartistico";
            this.nombreartisticoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nombreartisticoDataGridViewTextBoxColumn.Name = "nombreartisticoDataGridViewTextBoxColumn";
            this.nombreartisticoDataGridViewTextBoxColumn.Width = 125;
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            this.descripcionDataGridViewTextBoxColumn.Width = 125;
            // 
            // generomusicalDataGridViewTextBoxColumn
            // 
            this.generomusicalDataGridViewTextBoxColumn.DataPropertyName = "Generomusical";
            this.generomusicalDataGridViewTextBoxColumn.HeaderText = "Generomusical";
            this.generomusicalDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.generomusicalDataGridViewTextBoxColumn.Name = "generomusicalDataGridViewTextBoxColumn";
            this.generomusicalDataGridViewTextBoxColumn.Width = 125;
            // 
            // artistaBindingSource
            // 
            this.artistaBindingSource.DataSource = typeof(Usuariobuscador.Artista);
            // 
            // txtBuscador
            // 
            this.txtBuscador.Location = new System.Drawing.Point(159, 64);
            this.txtBuscador.Name = "txtBuscador";
            this.txtBuscador.Size = new System.Drawing.Size(100, 22);
            this.txtBuscador.TabIndex = 1;
            // 
            // Buscar
            // 
            this.Buscar.Location = new System.Drawing.Point(296, 62);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(75, 23);
            this.Buscar.TabIndex = 2;
            this.Buscar.Text = "Buscar";
            this.Buscar.UseVisualStyleBackColor = true;
            this.Buscar.Click += new System.EventHandler(this.Buscar_Click);
            // 
            // bunifuToggleSwitch21
            // 
            this.bunifuToggleSwitch21.BackColor = System.Drawing.Color.Transparent;
            this.bunifuToggleSwitch21.Checked = false;
            this.bunifuToggleSwitch21.CheckedBackColor = System.Drawing.Color.DodgerBlue;
            this.bunifuToggleSwitch21.CheckedSwitchColor = System.Drawing.Color.White;
            this.bunifuToggleSwitch21.CheckedSwitchStyle = Bunifu.UI.WinForms.BunifuToggleSwitch2.SwitchStyles.Fill;
            this.bunifuToggleSwitch21.Location = new System.Drawing.Point(582, 49);
            this.bunifuToggleSwitch21.Name = "bunifuToggleSwitch21";
            this.bunifuToggleSwitch21.OutlineThickness = 2;
            this.bunifuToggleSwitch21.Size = new System.Drawing.Size(42, 22);
            this.bunifuToggleSwitch21.TabIndex = 3;
            this.bunifuToggleSwitch21.UncheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.bunifuToggleSwitch21.UncheckedSwitchColor = System.Drawing.Color.White;
            this.bunifuToggleSwitch21.UncheckedSwitchStyle = Bunifu.UI.WinForms.BunifuToggleSwitch2.SwitchStyles.Fill;
            // 
            // BuscarArtista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 450);
            this.Controls.Add(this.bunifuToggleSwitch21);
            this.Controls.Add(this.Buscar);
            this.Controls.Add(this.txtBuscador);
            this.Controls.Add(this.dataGridView1);
            this.Name = "BuscarArtista";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artistaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idArtistaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreartisticoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn generomusicalDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource artistaBindingSource;
        private System.Windows.Forms.TextBox txtBuscador;
        private System.Windows.Forms.Button Buscar;
        private Bunifu.UI.WinForms.BunifuToggleSwitch2 bunifuToggleSwitch21;
    }
}


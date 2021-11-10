
namespace BancoPresentacion
{
	partial class FrmConsulta
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
			this.lblFechaDesde = new System.Windows.Forms.Label();
			this.cboFiltroFecha = new System.Windows.Forms.ComboBox();
			this.dtpFechaDesde = new System.Windows.Forms.DateTimePicker();
			this.lblFiltroFecha = new System.Windows.Forms.Label();
			this.lblFechaHasta = new System.Windows.Forms.Label();
			this.btnConsultar = new System.Windows.Forms.Button();
			this.dtpFechaHasta = new System.Windows.Forms.DateTimePicker();
			this.btnEditar = new System.Windows.Forms.Button();
			this.lblFiltro = new System.Windows.Forms.Label();
			this.btnNuevo = new System.Windows.Forms.Button();
			this.cboFiltro = new System.Windows.Forms.ComboBox();
			this.btnEliminar = new System.Windows.Forms.Button();
			this.txtFiltro = new System.Windows.Forms.TextBox();
			this.dgvConsulta = new System.Windows.Forms.DataGridView();
			this.cId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cCbu = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cTipoCuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cSaldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cUltimoMov = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.chkBaja = new System.Windows.Forms.CheckBox();
			((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).BeginInit();
			this.SuspendLayout();
			// 
			// lblFechaDesde
			// 
			this.lblFechaDesde.AutoSize = true;
			this.lblFechaDesde.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.lblFechaDesde.Location = new System.Drawing.Point(360, 39);
			this.lblFechaDesde.Name = "lblFechaDesde";
			this.lblFechaDesde.Size = new System.Drawing.Size(59, 18);
			this.lblFechaDesde.TabIndex = 2;
			this.lblFechaDesde.Text = "Desde:";
			// 
			// cboFiltroFecha
			// 
			this.cboFiltroFecha.BackColor = System.Drawing.SystemColors.ButtonShadow;
			this.cboFiltroFecha.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboFiltroFecha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cboFiltroFecha.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.cboFiltroFecha.ForeColor = System.Drawing.Color.Black;
			this.cboFiltroFecha.FormattingEnabled = true;
			this.cboFiltroFecha.Location = new System.Drawing.Point(83, 35);
			this.cboFiltroFecha.Name = "cboFiltroFecha";
			this.cboFiltroFecha.Size = new System.Drawing.Size(254, 25);
			this.cboFiltroFecha.TabIndex = 1;
			this.cboFiltroFecha.SelectedIndexChanged += new System.EventHandler(this.cboFiltroFecha_SelectedIndexChanged_1);
			// 
			// dtpFechaDesde
			// 
			this.dtpFechaDesde.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpFechaDesde.Location = new System.Drawing.Point(423, 37);
			this.dtpFechaDesde.Name = "dtpFechaDesde";
			this.dtpFechaDesde.Size = new System.Drawing.Size(143, 26);
			this.dtpFechaDesde.TabIndex = 3;
			// 
			// lblFiltroFecha
			// 
			this.lblFiltroFecha.AutoSize = true;
			this.lblFiltroFecha.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.lblFiltroFecha.Location = new System.Drawing.Point(33, 39);
			this.lblFiltroFecha.Name = "lblFiltroFecha";
			this.lblFiltroFecha.Size = new System.Drawing.Size(42, 18);
			this.lblFiltroFecha.TabIndex = 0;
			this.lblFiltroFecha.Text = "Filtro";
			// 
			// lblFechaHasta
			// 
			this.lblFechaHasta.AutoSize = true;
			this.lblFechaHasta.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.lblFechaHasta.Location = new System.Drawing.Point(588, 39);
			this.lblFechaHasta.Name = "lblFechaHasta";
			this.lblFechaHasta.Size = new System.Drawing.Size(52, 18);
			this.lblFechaHasta.TabIndex = 4;
			this.lblFechaHasta.Text = "Hasta:";
			// 
			// btnConsultar
			// 
			this.btnConsultar.BackColor = System.Drawing.Color.DimGray;
			this.btnConsultar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnConsultar.FlatAppearance.BorderSize = 0;
			this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnConsultar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.btnConsultar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.btnConsultar.Location = new System.Drawing.Point(697, 99);
			this.btnConsultar.Name = "btnConsultar";
			this.btnConsultar.Size = new System.Drawing.Size(80, 35);
			this.btnConsultar.TabIndex = 9;
			this.btnConsultar.Text = "Consultar";
			this.btnConsultar.UseVisualStyleBackColor = false;
			this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
			// 
			// dtpFechaHasta
			// 
			this.dtpFechaHasta.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpFechaHasta.Location = new System.Drawing.Point(647, 37);
			this.dtpFechaHasta.Name = "dtpFechaHasta";
			this.dtpFechaHasta.Size = new System.Drawing.Size(143, 26);
			this.dtpFechaHasta.TabIndex = 5;
			// 
			// btnEditar
			// 
			this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnEditar.BackColor = System.Drawing.Color.DimGray;
			this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnEditar.FlatAppearance.BorderSize = 0;
			this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnEditar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.btnEditar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.btnEditar.Location = new System.Drawing.Point(616, 455);
			this.btnEditar.Name = "btnEditar";
			this.btnEditar.Size = new System.Drawing.Size(80, 35);
			this.btnEditar.TabIndex = 13;
			this.btnEditar.Text = "Editar";
			this.btnEditar.UseVisualStyleBackColor = false;
			this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
			// 
			// lblFiltro
			// 
			this.lblFiltro.AutoSize = true;
			this.lblFiltro.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.lblFiltro.Location = new System.Drawing.Point(33, 107);
			this.lblFiltro.Name = "lblFiltro";
			this.lblFiltro.Size = new System.Drawing.Size(42, 18);
			this.lblFiltro.TabIndex = 6;
			this.lblFiltro.Text = "Filtro";
			// 
			// btnNuevo
			// 
			this.btnNuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnNuevo.BackColor = System.Drawing.Color.DimGray;
			this.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnNuevo.FlatAppearance.BorderSize = 0;
			this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnNuevo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.btnNuevo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.btnNuevo.Location = new System.Drawing.Point(483, 455);
			this.btnNuevo.Name = "btnNuevo";
			this.btnNuevo.Size = new System.Drawing.Size(80, 35);
			this.btnNuevo.TabIndex = 12;
			this.btnNuevo.Text = "Nuevo";
			this.btnNuevo.UseVisualStyleBackColor = false;
			this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
			// 
			// cboFiltro
			// 
			this.cboFiltro.BackColor = System.Drawing.SystemColors.ButtonShadow;
			this.cboFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cboFiltro.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.cboFiltro.ForeColor = System.Drawing.Color.Black;
			this.cboFiltro.FormattingEnabled = true;
			this.cboFiltro.Location = new System.Drawing.Point(83, 103);
			this.cboFiltro.Name = "cboFiltro";
			this.cboFiltro.Size = new System.Drawing.Size(254, 25);
			this.cboFiltro.TabIndex = 7;
			// 
			// btnEliminar
			// 
			this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnEliminar.BackColor = System.Drawing.Color.DimGray;
			this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnEliminar.FlatAppearance.BorderSize = 0;
			this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnEliminar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.btnEliminar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.btnEliminar.Location = new System.Drawing.Point(744, 455);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(80, 35);
			this.btnEliminar.TabIndex = 14;
			this.btnEliminar.Text = "Eliminar";
			this.btnEliminar.UseVisualStyleBackColor = false;
			this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
			// 
			// txtFiltro
			// 
			this.txtFiltro.BackColor = System.Drawing.Color.White;
			this.txtFiltro.Cursor = System.Windows.Forms.Cursors.Default;
			this.txtFiltro.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.txtFiltro.ForeColor = System.Drawing.Color.Black;
			this.txtFiltro.Location = new System.Drawing.Point(365, 103);
			this.txtFiltro.MaxLength = 30;
			this.txtFiltro.Name = "txtFiltro";
			this.txtFiltro.Size = new System.Drawing.Size(298, 23);
			this.txtFiltro.TabIndex = 8;
			this.txtFiltro.TextChanged += new System.EventHandler(this.txtFiltro_TextChanged);
			this.txtFiltro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFiltro_KeyPress);
			// 
			// dgvConsulta
			// 
			this.dgvConsulta.AllowUserToAddRows = false;
			this.dgvConsulta.AllowUserToDeleteRows = false;
			this.dgvConsulta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvConsulta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvConsulta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
        this.cId,
        this.cCliente,
        this.cCbu,
        this.cTipoCuenta,
        this.cSaldo,
        this.cUltimoMov});
			      this.dgvConsulta.SelectionChanged += new System.EventHandler(this.dgvConsulta_SelectionChanged);	
            this.dgvConsulta.Location = new System.Drawing.Point(14, 186);
            this.dgvConsulta.Name = "dgvConsulta";
            this.dgvConsulta.ReadOnly = true;
            this.dgvConsulta.RowTemplate.Height = 25;
            this.dgvConsulta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvConsulta.Size = new System.Drawing.Size(827, 255);
            this.dgvConsulta.TabIndex = 11;
            this.dgvConsulta.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvConsulta_CellDoubleClick);
            // 
            // cId
            // 
            this.cId.HeaderText = "Id";
            this.cId.Name = "cId";
            this.cId.ReadOnly = true;
            // 
            // cCliente
            // 
            this.cCliente.HeaderText = "Cliente";
            this.cCliente.Name = "cCliente";
            this.cCliente.ReadOnly = true;
            // 
            // cCbu
            // 
            this.cCbu.HeaderText = "CBU";
            this.cCbu.Name = "cCbu";
            this.cCbu.ReadOnly = true;
            // 
            // cTipoCuenta
            // 
            this.cTipoCuenta.HeaderText = "Tipo de Cuenta";
            this.cTipoCuenta.Name = "cTipoCuenta";
            this.cTipoCuenta.ReadOnly = true;
            // 
            // cSaldo
            // 
            this.cSaldo.HeaderText = "Saldo";
            this.cSaldo.Name = "cSaldo";
            this.cSaldo.ReadOnly = true;
            // 
            // cUltimoMov
            // 
            this.cUltimoMov.HeaderText = "Ultimo Mov";
            this.cUltimoMov.Name = "cUltimoMov";
            this.cUltimoMov.ReadOnly = true;
            // 
            // chkBaja
            // 
            this.chkBaja.AutoSize = true;
            this.chkBaja.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkBaja.Location = new System.Drawing.Point(741, 157);
            this.chkBaja.Name = "chkBaja";
            this.chkBaja.Size = new System.Drawing.Size(91, 21);
            this.chkBaja.TabIndex = 10;
            this.chkBaja.Text = "Incluir Baja";
            this.chkBaja.UseVisualStyleBackColor = true;
            // 
            // FrmConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 500);
            this.Controls.Add(this.chkBaja);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.dgvConsulta);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.lblFechaDesde);
            this.Controls.Add(this.cboFiltro);
            this.Controls.Add(this.cboFiltroFecha);
            this.Controls.Add(this.dtpFechaDesde);
            this.Controls.Add(this.lblFiltro);
            this.Controls.Add(this.lblFiltroFecha);
            this.Controls.Add(this.lblFechaHasta);
            this.Controls.Add(this.dtpFechaHasta);
            this.Controls.Add(this.btnConsultar);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "FrmConsulta";
            this.Text = "Consultas";
            this.Load += new System.EventHandler(this.FrmConsulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();


		}

		#endregion

		private System.Windows.Forms.Label lblFechaDesde;
		private System.Windows.Forms.ComboBox cboFiltroFecha;
		private System.Windows.Forms.DateTimePicker dtpFechaDesde;
		private System.Windows.Forms.Label lblFiltroFecha;
		private System.Windows.Forms.Label lblFechaHasta;
		private System.Windows.Forms.Button btnConsultar;
		private System.Windows.Forms.DateTimePicker dtpFechaHasta;
		private System.Windows.Forms.Button btnEditar;
		private System.Windows.Forms.Label lblFiltro;
		private System.Windows.Forms.Button btnNuevo;
		private System.Windows.Forms.ComboBox cboFiltro;
		private System.Windows.Forms.Button btnEliminar;
		private System.Windows.Forms.TextBox txtFiltro;
		private System.Windows.Forms.DataGridView dgvConsulta;
		private System.Windows.Forms.CheckBox chkBaja;
		private System.Windows.Forms.DataGridViewTextBoxColumn cId;
		private System.Windows.Forms.DataGridViewTextBoxColumn cCliente;
		private System.Windows.Forms.DataGridViewTextBoxColumn cCbu;
		private System.Windows.Forms.DataGridViewTextBoxColumn cTipoCuenta;
		private System.Windows.Forms.DataGridViewTextBoxColumn cSaldo;
		private System.Windows.Forms.DataGridViewTextBoxColumn cUltimoMov;
	}
}
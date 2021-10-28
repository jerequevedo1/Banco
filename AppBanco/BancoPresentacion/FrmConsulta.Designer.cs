
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
			this.dgvConsulta = new System.Windows.Forms.DataGridView();
			this.btnConsultar = new System.Windows.Forms.Button();
			this.btnNuevo = new System.Windows.Forms.Button();
			this.btnEditar = new System.Windows.Forms.Button();
			this.btnEliminar = new System.Windows.Forms.Button();
			this.txtFiltro = new System.Windows.Forms.TextBox();
			this.cboFiltro = new System.Windows.Forms.ComboBox();
			this.lblFiltro = new System.Windows.Forms.Label();
			this.dtpFechaHasta = new System.Windows.Forms.DateTimePicker();
			this.lblFechaHasta = new System.Windows.Forms.Label();
			this.dtpFechaDesde = new System.Windows.Forms.DateTimePicker();
			this.lblFechaDesde = new System.Windows.Forms.Label();
			this.cboFiltroFecha = new System.Windows.Forms.ComboBox();
			this.lblFiltroFecha = new System.Windows.Forms.Label();
			this.cId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cCbu = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cTipoCuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cSaldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cUltimoMov = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvConsulta
			// 
			this.dgvConsulta.AllowUserToAddRows = false;
			this.dgvConsulta.AllowUserToDeleteRows = false;
			this.dgvConsulta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvConsulta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cId,
            this.cCliente,
            this.cCbu,
            this.cTipoCuenta,
            this.cSaldo,
            this.cUltimoMov});
			this.dgvConsulta.Location = new System.Drawing.Point(27, 143);
			this.dgvConsulta.Name = "dgvConsulta";
			this.dgvConsulta.ReadOnly = true;
			this.dgvConsulta.RowTemplate.Height = 25;
			this.dgvConsulta.Size = new System.Drawing.Size(659, 309);
			this.dgvConsulta.TabIndex = 0;
			// 
			// btnConsultar
			// 
			this.btnConsultar.Location = new System.Drawing.Point(611, 83);
			this.btnConsultar.Name = "btnConsultar";
			this.btnConsultar.Size = new System.Drawing.Size(75, 23);
			this.btnConsultar.TabIndex = 1;
			this.btnConsultar.Text = "Consultar";
			this.btnConsultar.UseVisualStyleBackColor = true;
			this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
			// 
			// btnNuevo
			// 
			this.btnNuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnNuevo.FlatAppearance.BorderSize = 0;
			this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnNuevo.Location = new System.Drawing.Point(369, 493);
			this.btnNuevo.Name = "btnNuevo";
			this.btnNuevo.Size = new System.Drawing.Size(75, 23);
			this.btnNuevo.TabIndex = 3;
			this.btnNuevo.Text = "Nuevo";
			this.btnNuevo.UseVisualStyleBackColor = true;
			this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
			// 
			// btnEditar
			// 
			this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnEditar.FlatAppearance.BorderSize = 0;
			this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnEditar.Location = new System.Drawing.Point(486, 493);
			this.btnEditar.Name = "btnEditar";
			this.btnEditar.Size = new System.Drawing.Size(75, 23);
			this.btnEditar.TabIndex = 4;
			this.btnEditar.Text = "Editar";
			this.btnEditar.UseVisualStyleBackColor = true;
			// 
			// btnEliminar
			// 
			this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnEliminar.FlatAppearance.BorderSize = 0;
			this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnEliminar.Location = new System.Drawing.Point(611, 493);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(75, 23);
			this.btnEliminar.TabIndex = 5;
			this.btnEliminar.Text = "Eliminar";
			this.btnEliminar.UseVisualStyleBackColor = true;
			// 
			// txtFiltro
			// 
			this.txtFiltro.Location = new System.Drawing.Point(336, 83);
			this.txtFiltro.Name = "txtFiltro";
			this.txtFiltro.Size = new System.Drawing.Size(261, 23);
			this.txtFiltro.TabIndex = 18;
			// 
			// cboFiltro
			// 
			this.cboFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboFiltro.FormattingEnabled = true;
			this.cboFiltro.Location = new System.Drawing.Point(90, 83);
			this.cboFiltro.Name = "cboFiltro";
			this.cboFiltro.Size = new System.Drawing.Size(223, 23);
			this.cboFiltro.TabIndex = 17;
			// 
			// lblFiltro
			// 
			this.lblFiltro.AutoSize = true;
			this.lblFiltro.Location = new System.Drawing.Point(46, 87);
			this.lblFiltro.Name = "lblFiltro";
			this.lblFiltro.Size = new System.Drawing.Size(34, 15);
			this.lblFiltro.TabIndex = 16;
			this.lblFiltro.Text = "Filtro";
			// 
			// dtpFechaHasta
			// 
			this.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpFechaHasta.Location = new System.Drawing.Point(560, 23);
			this.dtpFechaHasta.Name = "dtpFechaHasta";
			this.dtpFechaHasta.Size = new System.Drawing.Size(126, 23);
			this.dtpFechaHasta.TabIndex = 15;
			// 
			// lblFechaHasta
			// 
			this.lblFechaHasta.AutoSize = true;
			this.lblFechaHasta.Location = new System.Drawing.Point(516, 27);
			this.lblFechaHasta.Name = "lblFechaHasta";
			this.lblFechaHasta.Size = new System.Drawing.Size(40, 15);
			this.lblFechaHasta.TabIndex = 14;
			this.lblFechaHasta.Text = "Hasta:";
			// 
			// dtpFechaDesde
			// 
			this.dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpFechaDesde.Location = new System.Drawing.Point(380, 23);
			this.dtpFechaDesde.Name = "dtpFechaDesde";
			this.dtpFechaDesde.Size = new System.Drawing.Size(126, 23);
			this.dtpFechaDesde.TabIndex = 13;
			// 
			// lblFechaDesde
			// 
			this.lblFechaDesde.AutoSize = true;
			this.lblFechaDesde.Location = new System.Drawing.Point(336, 27);
			this.lblFechaDesde.Name = "lblFechaDesde";
			this.lblFechaDesde.Size = new System.Drawing.Size(42, 15);
			this.lblFechaDesde.TabIndex = 12;
			this.lblFechaDesde.Text = "Desde:";
			// 
			// cboFiltroFecha
			// 
			this.cboFiltroFecha.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboFiltroFecha.FormattingEnabled = true;
			this.cboFiltroFecha.Location = new System.Drawing.Point(90, 23);
			this.cboFiltroFecha.Name = "cboFiltroFecha";
			this.cboFiltroFecha.Size = new System.Drawing.Size(223, 23);
			this.cboFiltroFecha.TabIndex = 11;
			// 
			// lblFiltroFecha
			// 
			this.lblFiltroFecha.AutoSize = true;
			this.lblFiltroFecha.Location = new System.Drawing.Point(46, 27);
			this.lblFiltroFecha.Name = "lblFiltroFecha";
			this.lblFiltroFecha.Size = new System.Drawing.Size(34, 15);
			this.lblFiltroFecha.TabIndex = 10;
			this.lblFiltroFecha.Text = "Filtro";
			// 
			// cId
			// 
			this.cId.HeaderText = "Id";
			this.cId.Name = "cId";
			this.cId.ReadOnly = true;
			this.cId.Visible = false;
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
			// FrmConsulta
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(721, 549);
			this.Controls.Add(this.txtFiltro);
			this.Controls.Add(this.cboFiltro);
			this.Controls.Add(this.lblFiltro);
			this.Controls.Add(this.dtpFechaHasta);
			this.Controls.Add(this.lblFechaHasta);
			this.Controls.Add(this.dtpFechaDesde);
			this.Controls.Add(this.lblFechaDesde);
			this.Controls.Add(this.cboFiltroFecha);
			this.Controls.Add(this.lblFiltroFecha);
			this.Controls.Add(this.btnEliminar);
			this.Controls.Add(this.btnEditar);
			this.Controls.Add(this.btnNuevo);
			this.Controls.Add(this.btnConsultar);
			this.Controls.Add(this.dgvConsulta);
			this.Name = "FrmConsulta";
			this.Text = "FrmConsulta";
			((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvConsulta;
		private System.Windows.Forms.Button btnConsultar;
		private System.Windows.Forms.Button btnNuevo;
		private System.Windows.Forms.Button btnEditar;
		private System.Windows.Forms.Button btnEliminar;
		private System.Windows.Forms.TextBox txtFiltro;
		private System.Windows.Forms.ComboBox cboFiltro;
		private System.Windows.Forms.Label lblFiltro;
		private System.Windows.Forms.DateTimePicker dtpFechaHasta;
		private System.Windows.Forms.Label lblFechaHasta;
		private System.Windows.Forms.DateTimePicker dtpFechaDesde;
		private System.Windows.Forms.Label lblFechaDesde;
		private System.Windows.Forms.ComboBox cboFiltroFecha;
		private System.Windows.Forms.Label lblFiltroFecha;
		private System.Windows.Forms.DataGridViewTextBoxColumn cId;
		private System.Windows.Forms.DataGridViewTextBoxColumn cCliente;
		private System.Windows.Forms.DataGridViewTextBoxColumn cCbu;
		private System.Windows.Forms.DataGridViewTextBoxColumn cTipoCuenta;
		private System.Windows.Forms.DataGridViewTextBoxColumn cSaldo;
		private System.Windows.Forms.DataGridViewTextBoxColumn cUltimoMov;
	}
}
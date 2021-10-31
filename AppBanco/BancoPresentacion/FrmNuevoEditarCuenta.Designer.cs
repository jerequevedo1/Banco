
namespace BancoPresentacion
{
	partial class FrmNuevoEditarCuenta
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
			this.lblNroCuenta = new System.Windows.Forms.Label();
			this.lblCbu = new System.Windows.Forms.Label();
			this.txtCbu = new System.Windows.Forms.TextBox();
			this.txtAlias = new System.Windows.Forms.TextBox();
			this.lblAlias = new System.Windows.Forms.Label();
			this.txtDepositoInicial = new System.Windows.Forms.TextBox();
			this.lblDepositoInicial = new System.Windows.Forms.Label();
			this.txtCliente = new System.Windows.Forms.TextBox();
			this.lblCliente = new System.Windows.Forms.Label();
			this.txtLimiteDesc = new System.Windows.Forms.TextBox();
			this.lblLimiteDesc = new System.Windows.Forms.Label();
			this.btnBuscar = new System.Windows.Forms.Button();
			this.btnNuevo = new System.Windows.Forms.Button();
			this.lblTipoCuenta = new System.Windows.Forms.Label();
			this.lblTipoMoneda = new System.Windows.Forms.Label();
			this.cboTipoCuenta = new System.Windows.Forms.ComboBox();
			this.cboTipoMoneda = new System.Windows.Forms.ComboBox();
			this.btnAceptar = new System.Windows.Forms.Button();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.dgvClientes = new System.Windows.Forms.DataGridView();
			this.cId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cDni = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
			this.SuspendLayout();
			// 
			// lblNroCuenta
			// 
			this.lblNroCuenta.AutoSize = true;
			this.lblNroCuenta.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lblNroCuenta.Location = new System.Drawing.Point(12, 22);
			this.lblNroCuenta.Name = "lblNroCuenta";
			this.lblNroCuenta.Size = new System.Drawing.Size(97, 21);
			this.lblNroCuenta.TabIndex = 0;
			this.lblNroCuenta.Text = "Nro Cuenta: ";
			// 
			// lblCbu
			// 
			this.lblCbu.AutoSize = true;
			this.lblCbu.Location = new System.Drawing.Point(45, 82);
			this.lblCbu.Name = "lblCbu";
			this.lblCbu.Size = new System.Drawing.Size(29, 15);
			this.lblCbu.TabIndex = 1;
			this.lblCbu.Text = "Cbu";
			// 
			// txtCbu
			// 
			this.txtCbu.Location = new System.Drawing.Point(98, 74);
			this.txtCbu.Name = "txtCbu";
			this.txtCbu.Size = new System.Drawing.Size(100, 23);
			this.txtCbu.TabIndex = 2;
			// 
			// txtAlias
			// 
			this.txtAlias.Location = new System.Drawing.Point(278, 74);
			this.txtAlias.Name = "txtAlias";
			this.txtAlias.Size = new System.Drawing.Size(100, 23);
			this.txtAlias.TabIndex = 4;
			// 
			// lblAlias
			// 
			this.lblAlias.AutoSize = true;
			this.lblAlias.Location = new System.Drawing.Point(225, 82);
			this.lblAlias.Name = "lblAlias";
			this.lblAlias.Size = new System.Drawing.Size(32, 15);
			this.lblAlias.TabIndex = 3;
			this.lblAlias.Text = "Alias";
			// 
			// txtDepositoInicial
			// 
			this.txtDepositoInicial.Location = new System.Drawing.Point(601, 119);
			this.txtDepositoInicial.Name = "txtDepositoInicial";
			this.txtDepositoInicial.Size = new System.Drawing.Size(100, 23);
			this.txtDepositoInicial.TabIndex = 6;
			// 
			// lblDepositoInicial
			// 
			this.lblDepositoInicial.AutoSize = true;
			this.lblDepositoInicial.Location = new System.Drawing.Point(502, 127);
			this.lblDepositoInicial.Name = "lblDepositoInicial";
			this.lblDepositoInicial.Size = new System.Drawing.Size(88, 15);
			this.lblDepositoInicial.TabIndex = 5;
			this.lblDepositoInicial.Text = "Deposito Inicial";
			// 
			// txtCliente
			// 
			this.txtCliente.Location = new System.Drawing.Point(156, 172);
			this.txtCliente.Name = "txtCliente";
			this.txtCliente.Size = new System.Drawing.Size(307, 23);
			this.txtCliente.TabIndex = 10;
			// 
			// lblCliente
			// 
			this.lblCliente.AutoSize = true;
			this.lblCliente.Location = new System.Drawing.Point(89, 180);
			this.lblCliente.Name = "lblCliente";
			this.lblCliente.Size = new System.Drawing.Size(44, 15);
			this.lblCliente.TabIndex = 9;
			this.lblCliente.Text = "Cliente";
			// 
			// txtLimiteDesc
			// 
			this.txtLimiteDesc.Location = new System.Drawing.Point(524, 74);
			this.txtLimiteDesc.Name = "txtLimiteDesc";
			this.txtLimiteDesc.Size = new System.Drawing.Size(100, 23);
			this.txtLimiteDesc.TabIndex = 12;
			// 
			// lblLimiteDesc
			// 
			this.lblLimiteDesc.AutoSize = true;
			this.lblLimiteDesc.Location = new System.Drawing.Point(412, 82);
			this.lblLimiteDesc.Name = "lblLimiteDesc";
			this.lblLimiteDesc.Size = new System.Drawing.Size(106, 15);
			this.lblLimiteDesc.TabIndex = 11;
			this.lblLimiteDesc.Text = "Limite Descubierto";
			// 
			// btnBuscar
			// 
			this.btnBuscar.Location = new System.Drawing.Point(496, 172);
			this.btnBuscar.Name = "btnBuscar";
			this.btnBuscar.Size = new System.Drawing.Size(75, 23);
			this.btnBuscar.TabIndex = 13;
			this.btnBuscar.Text = "Buscar";
			this.btnBuscar.UseVisualStyleBackColor = true;
			this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
			// 
			// btnNuevo
			// 
			this.btnNuevo.Location = new System.Drawing.Point(583, 172);
			this.btnNuevo.Name = "btnNuevo";
			this.btnNuevo.Size = new System.Drawing.Size(75, 23);
			this.btnNuevo.TabIndex = 14;
			this.btnNuevo.Text = "Nuevo";
			this.btnNuevo.UseVisualStyleBackColor = true;
			this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
			// 
			// lblTipoCuenta
			// 
			this.lblTipoCuenta.AutoSize = true;
			this.lblTipoCuenta.Location = new System.Drawing.Point(39, 123);
			this.lblTipoCuenta.Name = "lblTipoCuenta";
			this.lblTipoCuenta.Size = new System.Drawing.Size(71, 15);
			this.lblTipoCuenta.TabIndex = 15;
			this.lblTipoCuenta.Text = "Tipo Cuenta";
			// 
			// lblTipoMoneda
			// 
			this.lblTipoMoneda.AutoSize = true;
			this.lblTipoMoneda.Location = new System.Drawing.Point(272, 123);
			this.lblTipoMoneda.Name = "lblTipoMoneda";
			this.lblTipoMoneda.Size = new System.Drawing.Size(77, 15);
			this.lblTipoMoneda.TabIndex = 16;
			this.lblTipoMoneda.Text = "Tipo Moneda";
			// 
			// cboTipoCuenta
			// 
			this.cboTipoCuenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboTipoCuenta.FormattingEnabled = true;
			this.cboTipoCuenta.Location = new System.Drawing.Point(129, 119);
			this.cboTipoCuenta.Name = "cboTipoCuenta";
			this.cboTipoCuenta.Size = new System.Drawing.Size(121, 23);
			this.cboTipoCuenta.TabIndex = 17;
			// 
			// cboTipoMoneda
			// 
			this.cboTipoMoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboTipoMoneda.FormattingEnabled = true;
			this.cboTipoMoneda.Location = new System.Drawing.Point(356, 120);
			this.cboTipoMoneda.Name = "cboTipoMoneda";
			this.cboTipoMoneda.Size = new System.Drawing.Size(121, 23);
			this.cboTipoMoneda.TabIndex = 18;
			// 
			// btnAceptar
			// 
			this.btnAceptar.Location = new System.Drawing.Point(281, 386);
			this.btnAceptar.Name = "btnAceptar";
			this.btnAceptar.Size = new System.Drawing.Size(75, 23);
			this.btnAceptar.TabIndex = 19;
			this.btnAceptar.Text = "Aceptar";
			this.btnAceptar.UseVisualStyleBackColor = true;
			// 
			// btnCancelar
			// 
			this.btnCancelar.Location = new System.Drawing.Point(402, 386);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(75, 23);
			this.btnCancelar.TabIndex = 20;
			this.btnCancelar.Text = "Cancelar";
			this.btnCancelar.UseVisualStyleBackColor = true;
			// 
			// dgvClientes
			// 
			this.dgvClientes.AllowUserToAddRows = false;
			this.dgvClientes.AllowUserToDeleteRows = false;
			this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cId,
            this.cCliente,
            this.cDni,
            this.cEmail});
			this.dgvClientes.Location = new System.Drawing.Point(146, 213);
			this.dgvClientes.Name = "dgvClientes";
			this.dgvClientes.ReadOnly = true;
			this.dgvClientes.RowTemplate.Height = 25;
			this.dgvClientes.Size = new System.Drawing.Size(444, 150);
			this.dgvClientes.TabIndex = 21;
			this.dgvClientes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientes_CellDoubleClick);
			// 
			// cId
			// 
			this.cId.HeaderText = "Nro Cliente";
			this.cId.Name = "cId";
			this.cId.ReadOnly = true;
			// 
			// cCliente
			// 
			this.cCliente.HeaderText = "Cliente";
			this.cCliente.Name = "cCliente";
			this.cCliente.ReadOnly = true;
			// 
			// cDni
			// 
			this.cDni.HeaderText = "Dni";
			this.cDni.Name = "cDni";
			this.cDni.ReadOnly = true;
			// 
			// cEmail
			// 
			this.cEmail.HeaderText = "Email";
			this.cEmail.Name = "cEmail";
			this.cEmail.ReadOnly = true;
			// 
			// FrmNuevoEditarCuenta
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(714, 421);
			this.Controls.Add(this.dgvClientes);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.btnAceptar);
			this.Controls.Add(this.cboTipoMoneda);
			this.Controls.Add(this.cboTipoCuenta);
			this.Controls.Add(this.lblTipoMoneda);
			this.Controls.Add(this.lblTipoCuenta);
			this.Controls.Add(this.btnNuevo);
			this.Controls.Add(this.btnBuscar);
			this.Controls.Add(this.txtLimiteDesc);
			this.Controls.Add(this.lblLimiteDesc);
			this.Controls.Add(this.txtCliente);
			this.Controls.Add(this.lblCliente);
			this.Controls.Add(this.txtDepositoInicial);
			this.Controls.Add(this.lblDepositoInicial);
			this.Controls.Add(this.txtAlias);
			this.Controls.Add(this.lblAlias);
			this.Controls.Add(this.txtCbu);
			this.Controls.Add(this.lblCbu);
			this.Controls.Add(this.lblNroCuenta);
			this.Name = "FrmNuevoEditarCuenta";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "FrmNuevoEditarCuenta";
			this.Load += new System.EventHandler(this.FrmNuevoEditarCuenta_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblNroCuenta;
		private System.Windows.Forms.Label lblCbu;
		private System.Windows.Forms.TextBox txtCbu;
		private System.Windows.Forms.TextBox txtAlias;
		private System.Windows.Forms.Label lblAlias;
		private System.Windows.Forms.TextBox txtDepositoInicial;
		private System.Windows.Forms.Label lblDepositoInicial;
		private System.Windows.Forms.TextBox txtCliente;
		private System.Windows.Forms.Label lblCliente;
		private System.Windows.Forms.TextBox txtLimiteDesc;
		private System.Windows.Forms.Label lblLimiteDesc;
		private System.Windows.Forms.Button btnBuscar;
		private System.Windows.Forms.Button btnNuevo;
		private System.Windows.Forms.Label lblTipoCuenta;
		private System.Windows.Forms.Label lblTipoMoneda;
		private System.Windows.Forms.ComboBox cboTipoCuenta;
		private System.Windows.Forms.ComboBox cboTipoMoneda;
		private System.Windows.Forms.Button btnAceptar;
		private System.Windows.Forms.Button btnCancelar;
		private System.Windows.Forms.DataGridView dgvClientes;
		private System.Windows.Forms.DataGridViewTextBoxColumn cId;
		private System.Windows.Forms.DataGridViewTextBoxColumn cCliente;
		private System.Windows.Forms.DataGridViewTextBoxColumn cDni;
		private System.Windows.Forms.DataGridViewTextBoxColumn cEmail;
	}
}
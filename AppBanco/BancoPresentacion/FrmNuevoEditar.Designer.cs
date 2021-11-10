
namespace BancoPresentacion
{
	partial class FrmNuevoEditar
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
            this.lblBuscarCliente = new System.Windows.Forms.Label();
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
            this.lblCliProvincia = new System.Windows.Forms.Label();
            this.cboCliProvincia = new System.Windows.Forms.ComboBox();
            this.lblLocalidad = new System.Windows.Forms.Label();
            this.cboCliLocalidad = new System.Windows.Forms.ComboBox();
            this.txtCliEmail = new System.Windows.Forms.TextBox();
            this.lblCliEmail = new System.Windows.Forms.Label();
            this.txtCliTel = new System.Windows.Forms.TextBox();
            this.lblClienteTel = new System.Windows.Forms.Label();
            this.lblCliBarrio = new System.Windows.Forms.Label();
            this.cboClienteBarrio = new System.Windows.Forms.ComboBox();
            this.txtCliDire = new System.Windows.Forms.TextBox();
            this.lblCliDire = new System.Windows.Forms.Label();
            this.txtCliApellido = new System.Windows.Forms.TextBox();
            this.lblCliApellido = new System.Windows.Forms.Label();
            this.txtCliCuil = new System.Windows.Forms.TextBox();
            this.lblClienteCuil = new System.Windows.Forms.Label();
            this.txtCliDNI = new System.Windows.Forms.TextBox();
            this.lblCliDNI = new System.Windows.Forms.Label();
            this.txtCliNombre = new System.Windows.Forms.TextBox();
            this.lblCliNombre = new System.Windows.Forms.Label();
            this.lblNroCliente = new System.Windows.Forms.Label();
            this.panelCliente = new System.Windows.Forms.Panel();
            this.panelCuenta = new System.Windows.Forms.Panel();
            this.panelCliente.SuspendLayout();
            this.panelCuenta.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNroCuenta
            // 
            this.lblNroCuenta.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblNroCuenta.AutoSize = true;
            this.lblNroCuenta.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNroCuenta.Location = new System.Drawing.Point(19, 290);
            this.lblNroCuenta.Name = "lblNroCuenta";
            this.lblNroCuenta.Size = new System.Drawing.Size(112, 19);
            this.lblNroCuenta.TabIndex = 0;
            this.lblNroCuenta.Text = "Nro Cuenta: ";
            // 
            // lblCbu
            // 
            this.lblCbu.AutoSize = true;
            this.lblCbu.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCbu.Location = new System.Drawing.Point(9, 8);
            this.lblCbu.Name = "lblCbu";
            this.lblCbu.Size = new System.Drawing.Size(36, 17);
            this.lblCbu.TabIndex = 25;
            this.lblCbu.Text = "Cbu";
            // 
            // txtCbu
            // 
            this.txtCbu.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCbu.Location = new System.Drawing.Point(9, 26);
            this.txtCbu.MaxLength = 22;
            this.txtCbu.Name = "txtCbu";
            this.txtCbu.Size = new System.Drawing.Size(144, 23);
            this.txtCbu.TabIndex = 26;
            this.txtCbu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCbu_KeyPress);
            // 
            // txtAlias
            // 
            this.txtAlias.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAlias.Location = new System.Drawing.Point(9, 81);
            this.txtAlias.MaxLength = 15;
            this.txtAlias.Name = "txtAlias";
            this.txtAlias.Size = new System.Drawing.Size(144, 23);
            this.txtAlias.TabIndex = 32;
            // 
            // lblAlias
            // 
            this.lblAlias.AutoSize = true;
            this.lblAlias.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAlias.Location = new System.Drawing.Point(9, 63);
            this.lblAlias.Name = "lblAlias";
            this.lblAlias.Size = new System.Drawing.Size(37, 17);
            this.lblAlias.TabIndex = 31;
            this.lblAlias.Text = "Alias";
            // 
            // txtDepositoInicial
            // 
            this.txtDepositoInicial.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDepositoInicial.Location = new System.Drawing.Point(185, 81);
            this.txtDepositoInicial.Name = "txtDepositoInicial";
            this.txtDepositoInicial.Size = new System.Drawing.Size(144, 23);
            this.txtDepositoInicial.TabIndex = 34;
            this.txtDepositoInicial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDepositoInicial_KeyPress);
            // 
            // lblDepositoInicial
            // 
            this.lblDepositoInicial.AutoSize = true;
            this.lblDepositoInicial.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDepositoInicial.Location = new System.Drawing.Point(185, 63);
            this.lblDepositoInicial.Name = "lblDepositoInicial";
            this.lblDepositoInicial.Size = new System.Drawing.Size(107, 17);
            this.lblDepositoInicial.TabIndex = 33;
            this.lblDepositoInicial.Text = "Depósito Inicial";
            // 
            // txtCliente
            // 
            this.txtCliente.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCliente.Location = new System.Drawing.Point(111, 25);
            this.txtCliente.MaxLength = 30;
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(384, 23);
            this.txtCliente.TabIndex = 1;
            // 
            // lblBuscarCliente
            // 
            this.lblBuscarCliente.AutoSize = true;
            this.lblBuscarCliente.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBuscarCliente.Location = new System.Drawing.Point(51, 28);
            this.lblBuscarCliente.Name = "lblBuscarCliente";
            this.lblBuscarCliente.Size = new System.Drawing.Size(61, 18);
            this.lblBuscarCliente.TabIndex = 0;
            this.lblBuscarCliente.Text = "Cliente";
            // 
            // txtLimiteDesc
            // 
            this.txtLimiteDesc.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtLimiteDesc.Location = new System.Drawing.Point(185, 26);
            this.txtLimiteDesc.Name = "txtLimiteDesc";
            this.txtLimiteDesc.Size = new System.Drawing.Size(144, 23);
            this.txtLimiteDesc.TabIndex = 28;
            this.txtLimiteDesc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLimiteDesc_KeyPress);
            // 
            // lblLimiteDesc
            // 
            this.lblLimiteDesc.AutoSize = true;
            this.lblLimiteDesc.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLimiteDesc.Location = new System.Drawing.Point(185, 8);
            this.lblLimiteDesc.Name = "lblLimiteDesc";
            this.lblLimiteDesc.Size = new System.Drawing.Size(127, 17);
            this.lblLimiteDesc.TabIndex = 27;
            this.lblLimiteDesc.Text = "Límite Descubierto";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.DimGray;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(506, 24);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(80, 35);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.DimGray;
            this.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNuevo.ForeColor = System.Drawing.Color.White;
            this.btnNuevo.Location = new System.Drawing.Point(593, 24);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(80, 35);
            this.btnNuevo.TabIndex = 3;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // lblTipoCuenta
            // 
            this.lblTipoCuenta.AutoSize = true;
            this.lblTipoCuenta.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTipoCuenta.Location = new System.Drawing.Point(366, 63);
            this.lblTipoCuenta.Name = "lblTipoCuenta";
            this.lblTipoCuenta.Size = new System.Drawing.Size(87, 17);
            this.lblTipoCuenta.TabIndex = 35;
            this.lblTipoCuenta.Text = "Tipo Cuenta";
            // 
            // lblTipoMoneda
            // 
            this.lblTipoMoneda.AutoSize = true;
            this.lblTipoMoneda.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTipoMoneda.Location = new System.Drawing.Point(366, 8);
            this.lblTipoMoneda.Name = "lblTipoMoneda";
            this.lblTipoMoneda.Size = new System.Drawing.Size(92, 17);
            this.lblTipoMoneda.TabIndex = 29;
            this.lblTipoMoneda.Text = "Tipo Moneda";
            // 
            // cboTipoCuenta
            // 
            this.cboTipoCuenta.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.cboTipoCuenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoCuenta.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboTipoCuenta.FormattingEnabled = true;
            this.cboTipoCuenta.Location = new System.Drawing.Point(366, 81);
            this.cboTipoCuenta.Name = "cboTipoCuenta";
            this.cboTipoCuenta.Size = new System.Drawing.Size(144, 25);
            this.cboTipoCuenta.TabIndex = 36;
            // 
            // cboTipoMoneda
            // 
            this.cboTipoMoneda.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.cboTipoMoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoMoneda.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboTipoMoneda.FormattingEnabled = true;
            this.cboTipoMoneda.Location = new System.Drawing.Point(366, 26);
            this.cboTipoMoneda.Name = "cboTipoMoneda";
            this.cboTipoMoneda.Size = new System.Drawing.Size(144, 25);
            this.cboTipoMoneda.TabIndex = 30;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAceptar.BackColor = System.Drawing.Color.DimGray;
            this.btnAceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAceptar.FlatAppearance.BorderSize = 0;
            this.btnAceptar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAceptar.ForeColor = System.Drawing.Color.White;
            this.btnAceptar.Location = new System.Drawing.Point(210, 440);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(80, 35);
            this.btnAceptar.TabIndex = 37;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCancelar.BackColor = System.Drawing.Color.DimGray;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(468, 440);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(80, 35);
            this.btnCancelar.TabIndex = 38;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblCliProvincia
            // 
            this.lblCliProvincia.AutoSize = true;
            this.lblCliProvincia.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCliProvincia.Location = new System.Drawing.Point(9, 64);
            this.lblCliProvincia.Name = "lblCliProvincia";
            this.lblCliProvincia.Size = new System.Drawing.Size(68, 17);
            this.lblCliProvincia.TabIndex = 13;
            this.lblCliProvincia.Text = "Provincia";
            // 
            // cboCliProvincia
            // 
            this.cboCliProvincia.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.cboCliProvincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCliProvincia.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboCliProvincia.FormattingEnabled = true;
            this.cboCliProvincia.Location = new System.Drawing.Point(8, 82);
            this.cboCliProvincia.Name = "cboCliProvincia";
            this.cboCliProvincia.Size = new System.Drawing.Size(144, 25);
            this.cboCliProvincia.TabIndex = 14;
            this.cboCliProvincia.SelectedIndexChanged += new System.EventHandler(this.cboCliProvincia_SelectedIndexChanged);
            // 
            // lblLocalidad
            // 
            this.lblLocalidad.AutoSize = true;
            this.lblLocalidad.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLocalidad.Location = new System.Drawing.Point(185, 64);
            this.lblLocalidad.Name = "lblLocalidad";
            this.lblLocalidad.Size = new System.Drawing.Size(73, 17);
            this.lblLocalidad.TabIndex = 15;
            this.lblLocalidad.Text = "Localidad";
            // 
            // cboCliLocalidad
            // 
            this.cboCliLocalidad.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.cboCliLocalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCliLocalidad.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboCliLocalidad.FormattingEnabled = true;
            this.cboCliLocalidad.Location = new System.Drawing.Point(185, 82);
            this.cboCliLocalidad.Name = "cboCliLocalidad";
            this.cboCliLocalidad.Size = new System.Drawing.Size(144, 25);
            this.cboCliLocalidad.TabIndex = 16;
            this.cboCliLocalidad.SelectedIndexChanged += new System.EventHandler(this.cboCliLocalidad_SelectedIndexChanged);
            // 
            // txtCliEmail
            // 
            this.txtCliEmail.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCliEmail.Location = new System.Drawing.Point(366, 140);
            this.txtCliEmail.MaxLength = 35;
            this.txtCliEmail.Name = "txtCliEmail";
            this.txtCliEmail.Size = new System.Drawing.Size(144, 23);
            this.txtCliEmail.TabIndex = 24;
            // 
            // lblCliEmail
            // 
            this.lblCliEmail.AutoSize = true;
            this.lblCliEmail.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCliEmail.Location = new System.Drawing.Point(366, 122);
            this.lblCliEmail.Name = "lblCliEmail";
            this.lblCliEmail.Size = new System.Drawing.Size(47, 17);
            this.lblCliEmail.TabIndex = 23;
            this.lblCliEmail.Text = "E-mail";
            // 
            // txtCliTel
            // 
            this.txtCliTel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCliTel.Location = new System.Drawing.Point(186, 140);
            this.txtCliTel.MaxLength = 15;
            this.txtCliTel.Name = "txtCliTel";
            this.txtCliTel.Size = new System.Drawing.Size(144, 23);
            this.txtCliTel.TabIndex = 22;
            // 
            // lblClienteTel
            // 
            this.lblClienteTel.AutoSize = true;
            this.lblClienteTel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblClienteTel.Location = new System.Drawing.Point(185, 122);
            this.lblClienteTel.Name = "lblClienteTel";
            this.lblClienteTel.Size = new System.Drawing.Size(62, 17);
            this.lblClienteTel.TabIndex = 21;
            this.lblClienteTel.Text = "Teléfono";
            // 
            // lblCliBarrio
            // 
            this.lblCliBarrio.AutoSize = true;
            this.lblCliBarrio.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCliBarrio.Location = new System.Drawing.Point(366, 64);
            this.lblCliBarrio.Name = "lblCliBarrio";
            this.lblCliBarrio.Size = new System.Drawing.Size(44, 17);
            this.lblCliBarrio.TabIndex = 17;
            this.lblCliBarrio.Text = "Barrio";
            // 
            // cboClienteBarrio
            // 
            this.cboClienteBarrio.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.cboClienteBarrio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboClienteBarrio.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboClienteBarrio.FormattingEnabled = true;
            this.cboClienteBarrio.Location = new System.Drawing.Point(366, 82);
            this.cboClienteBarrio.Name = "cboClienteBarrio";
            this.cboClienteBarrio.Size = new System.Drawing.Size(144, 25);
            this.cboClienteBarrio.TabIndex = 18;
            // 
            // txtCliDire
            // 
            this.txtCliDire.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCliDire.Location = new System.Drawing.Point(9, 140);
            this.txtCliDire.MaxLength = 30;
            this.txtCliDire.Name = "txtCliDire";
            this.txtCliDire.Size = new System.Drawing.Size(144, 23);
            this.txtCliDire.TabIndex = 20;
            // 
            // lblCliDire
            // 
            this.lblCliDire.AutoSize = true;
            this.lblCliDire.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCliDire.Location = new System.Drawing.Point(9, 122);
            this.lblCliDire.Name = "lblCliDire";
            this.lblCliDire.Size = new System.Drawing.Size(69, 17);
            this.lblCliDire.TabIndex = 19;
            this.lblCliDire.Text = "Dirección";
            // 
            // txtCliApellido
            // 
            this.txtCliApellido.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCliApellido.Location = new System.Drawing.Point(186, 31);
            this.txtCliApellido.MaxLength = 20;
            this.txtCliApellido.Name = "txtCliApellido";
            this.txtCliApellido.Size = new System.Drawing.Size(144, 23);
            this.txtCliApellido.TabIndex = 8;
            // 
            // lblCliApellido
            // 
            this.lblCliApellido.AutoSize = true;
            this.lblCliApellido.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCliApellido.Location = new System.Drawing.Point(185, 13);
            this.lblCliApellido.Name = "lblCliApellido";
            this.lblCliApellido.Size = new System.Drawing.Size(61, 17);
            this.lblCliApellido.TabIndex = 7;
            this.lblCliApellido.Text = "Apellido";
            // 
            // txtCliCuil
            // 
            this.txtCliCuil.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCliCuil.Location = new System.Drawing.Point(526, 31);
            this.txtCliCuil.MaxLength = 11;
            this.txtCliCuil.Name = "txtCliCuil";
            this.txtCliCuil.Size = new System.Drawing.Size(144, 23);
            this.txtCliCuil.TabIndex = 12;
            // 
            // lblClienteCuil
            // 
            this.lblClienteCuil.AutoSize = true;
            this.lblClienteCuil.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblClienteCuil.Location = new System.Drawing.Point(526, 13);
            this.lblClienteCuil.Name = "lblClienteCuil";
            this.lblClienteCuil.Size = new System.Drawing.Size(33, 17);
            this.lblClienteCuil.TabIndex = 11;
            this.lblClienteCuil.Text = "Cuil";
            // 
            // txtCliDNI
            // 
            this.txtCliDNI.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCliDNI.Location = new System.Drawing.Point(366, 31);
            this.txtCliDNI.MaxLength = 8;
            this.txtCliDNI.Name = "txtCliDNI";
            this.txtCliDNI.Size = new System.Drawing.Size(144, 23);
            this.txtCliDNI.TabIndex = 10;
            // 
            // lblCliDNI
            // 
            this.lblCliDNI.AutoSize = true;
            this.lblCliDNI.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCliDNI.Location = new System.Drawing.Point(366, 13);
            this.lblCliDNI.Name = "lblCliDNI";
            this.lblCliDNI.Size = new System.Drawing.Size(35, 17);
            this.lblCliDNI.TabIndex = 9;
            this.lblCliDNI.Text = "DNI ";
            // 
            // txtCliNombre
            // 
            this.txtCliNombre.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCliNombre.Location = new System.Drawing.Point(9, 31);
            this.txtCliNombre.MaxLength = 20;
            this.txtCliNombre.Name = "txtCliNombre";
            this.txtCliNombre.Size = new System.Drawing.Size(144, 23);
            this.txtCliNombre.TabIndex = 6;
            // 
            // lblCliNombre
            // 
            this.lblCliNombre.AutoSize = true;
            this.lblCliNombre.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCliNombre.Location = new System.Drawing.Point(9, 13);
            this.lblCliNombre.Name = "lblCliNombre";
            this.lblCliNombre.Size = new System.Drawing.Size(61, 17);
            this.lblCliNombre.TabIndex = 5;
            this.lblCliNombre.Text = "Nombre";
            // 
            // lblNroCliente
            // 
            this.lblNroCliente.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblNroCliente.AutoSize = true;
            this.lblNroCliente.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNroCliente.Location = new System.Drawing.Point(19, 72);
            this.lblNroCliente.Name = "lblNroCliente";
            this.lblNroCliente.Size = new System.Drawing.Size(105, 19);
            this.lblNroCliente.TabIndex = 4;
            this.lblNroCliente.Text = "Nro Cliente:";
            // 
            // panelCliente
            // 
            this.panelCliente.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panelCliente.Controls.Add(this.cboClienteBarrio);
            this.panelCliente.Controls.Add(this.lblCliProvincia);
            this.panelCliente.Controls.Add(this.lblCliNombre);
            this.panelCliente.Controls.Add(this.cboCliProvincia);
            this.panelCliente.Controls.Add(this.txtCliNombre);
            this.panelCliente.Controls.Add(this.lblLocalidad);
            this.panelCliente.Controls.Add(this.lblCliDNI);
            this.panelCliente.Controls.Add(this.cboCliLocalidad);
            this.panelCliente.Controls.Add(this.txtCliDNI);
            this.panelCliente.Controls.Add(this.txtCliEmail);
            this.panelCliente.Controls.Add(this.lblClienteCuil);
            this.panelCliente.Controls.Add(this.lblCliEmail);
            this.panelCliente.Controls.Add(this.txtCliCuil);
            this.panelCliente.Controls.Add(this.txtCliTel);
            this.panelCliente.Controls.Add(this.lblCliApellido);
            this.panelCliente.Controls.Add(this.lblClienteTel);
            this.panelCliente.Controls.Add(this.txtCliApellido);
            this.panelCliente.Controls.Add(this.lblCliBarrio);
            this.panelCliente.Controls.Add(this.lblCliDire);
            this.panelCliente.Controls.Add(this.txtCliDire);
            this.panelCliente.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panelCliente.Location = new System.Drawing.Point(42, 100);
            this.panelCliente.Name = "panelCliente";
            this.panelCliente.Size = new System.Drawing.Size(691, 176);
            this.panelCliente.TabIndex = 3;
            // 
            // panelCuenta
            // 
            this.panelCuenta.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panelCuenta.Controls.Add(this.txtCbu);
            this.panelCuenta.Controls.Add(this.lblCbu);
            this.panelCuenta.Controls.Add(this.lblAlias);
            this.panelCuenta.Controls.Add(this.txtAlias);
            this.panelCuenta.Controls.Add(this.cboTipoMoneda);
            this.panelCuenta.Controls.Add(this.cboTipoCuenta);
            this.panelCuenta.Controls.Add(this.txtLimiteDesc);
            this.panelCuenta.Controls.Add(this.lblTipoMoneda);
            this.panelCuenta.Controls.Add(this.lblDepositoInicial);
            this.panelCuenta.Controls.Add(this.lblTipoCuenta);
            this.panelCuenta.Controls.Add(this.txtDepositoInicial);
            this.panelCuenta.Controls.Add(this.lblLimiteDesc);
            this.panelCuenta.Location = new System.Drawing.Point(42, 314);
            this.panelCuenta.Name = "panelCuenta";
            this.panelCuenta.Size = new System.Drawing.Size(539, 119);
            this.panelCuenta.TabIndex = 24;
            // 
            // FrmNuevoEditar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 483);
            this.Controls.Add(this.panelCuenta);
            this.Controls.Add(this.lblNroCliente);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.lblBuscarCliente);
            this.Controls.Add(this.lblNroCuenta);
            this.Controls.Add(this.panelCliente);
            this.Name = "FrmNuevoEditar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Crear/Editar Clientes y Cuentas";
            this.Load += new System.EventHandler(this.FrmNuevoEditar_Load);
            this.panelCliente.ResumeLayout(false);
            this.panelCliente.PerformLayout();
            this.panelCuenta.ResumeLayout(false);
            this.panelCuenta.PerformLayout();
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
		private System.Windows.Forms.Label lblBuscarCliente;
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
		private System.Windows.Forms.Label lblCliProvincia;
		private System.Windows.Forms.ComboBox cboCliProvincia;
		private System.Windows.Forms.Label lblLocalidad;
		private System.Windows.Forms.ComboBox cboCliLocalidad;
		private System.Windows.Forms.TextBox txtCliEmail;
		private System.Windows.Forms.Label lblCliEmail;
		private System.Windows.Forms.TextBox txtCliTel;
		private System.Windows.Forms.Label lblClienteTel;
		private System.Windows.Forms.Label lblCliBarrio;
		private System.Windows.Forms.ComboBox cboClienteBarrio;
		private System.Windows.Forms.TextBox txtCliDire;
		private System.Windows.Forms.Label lblCliDire;
		private System.Windows.Forms.TextBox txtCliApellido;
		private System.Windows.Forms.Label lblCliApellido;
		private System.Windows.Forms.TextBox txtCliCuil;
		private System.Windows.Forms.Label lblClienteCuil;
		private System.Windows.Forms.TextBox txtCliDNI;
		private System.Windows.Forms.Label lblCliDNI;
		private System.Windows.Forms.TextBox txtCliNombre;
		private System.Windows.Forms.Label lblCliNombre;
		private System.Windows.Forms.Label lblNroCliente;
		private System.Windows.Forms.Panel panelCliente;
		private System.Windows.Forms.Panel panelCuenta;
	}
}
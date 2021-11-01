
namespace BancoPresentacion
{
	partial class FrmConsultaCliente
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
			this.dgvClientes = new System.Windows.Forms.DataGridView();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.btnAceptar = new System.Windows.Forms.Button();
			this.cId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cDni = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cAccion = new System.Windows.Forms.DataGridViewButtonColumn();
			((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvClientes
			// 
			this.dgvClientes.AllowUserToAddRows = false;
			this.dgvClientes.AllowUserToDeleteRows = false;
			this.dgvClientes.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.dgvClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cId,
            this.cCliente,
            this.cDni,
            this.cEmail,
            this.cAccion});
			this.dgvClientes.Location = new System.Drawing.Point(11, 16);
			this.dgvClientes.Name = "dgvClientes";
			this.dgvClientes.ReadOnly = true;
			this.dgvClientes.RowTemplate.Height = 25;
			this.dgvClientes.Size = new System.Drawing.Size(455, 330);
			this.dgvClientes.TabIndex = 27;
			this.dgvClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientes_CellContentClick);
			this.dgvClientes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientes_CellDoubleClick);
			// 
			// btnCancelar
			// 
			this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnCancelar.Location = new System.Drawing.Point(300, 364);
			this.btnCancelar.MaximumSize = new System.Drawing.Size(708, 464);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(75, 23);
			this.btnCancelar.TabIndex = 26;
			this.btnCancelar.Text = "Cancelar";
			this.btnCancelar.UseVisualStyleBackColor = true;
			// 
			// btnAceptar
			// 
			this.btnAceptar.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnAceptar.Location = new System.Drawing.Point(90, 364);
			this.btnAceptar.MaximumSize = new System.Drawing.Size(708, 464);
			this.btnAceptar.Name = "btnAceptar";
			this.btnAceptar.Size = new System.Drawing.Size(75, 23);
			this.btnAceptar.TabIndex = 25;
			this.btnAceptar.Text = "Aceptar";
			this.btnAceptar.UseVisualStyleBackColor = true;
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
			// cAccion
			// 
			this.cAccion.HeaderText = "Agregar";
			this.cAccion.Name = "cAccion";
			this.cAccion.ReadOnly = true;
			this.cAccion.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.cAccion.Text = "Agregar";
			this.cAccion.UseColumnTextForButtonValue = true;
			// 
			// FrmConsultaCliente
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(485, 405);
			this.Controls.Add(this.dgvClientes);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.btnAceptar);
			this.Name = "FrmConsultaCliente";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Consulta Clientes";
			this.Load += new System.EventHandler(this.FrmNuevoEditarCliente_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvClientes;
		private System.Windows.Forms.Button btnCancelar;
		private System.Windows.Forms.Button btnAceptar;
		private System.Windows.Forms.DataGridViewTextBoxColumn cId;
		private System.Windows.Forms.DataGridViewTextBoxColumn cCliente;
		private System.Windows.Forms.DataGridViewTextBoxColumn cDni;
		private System.Windows.Forms.DataGridViewTextBoxColumn cEmail;
		private System.Windows.Forms.DataGridViewButtonColumn cAccion;
	}
}
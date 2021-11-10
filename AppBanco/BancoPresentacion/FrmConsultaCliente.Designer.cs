
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.cId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cAccion = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvClientes
            // 
            this.dgvClientes.AllowUserToAddRows = false;
            this.dgvClientes.AllowUserToDeleteRows = false;
            this.dgvClientes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cId,
            this.cCliente,
            this.cDni,
            this.cEmail,
            this.cAccion});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvClientes.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvClientes.Location = new System.Drawing.Point(12, 12);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvClientes.RowTemplate.Height = 25;
            this.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClientes.Size = new System.Drawing.Size(493, 334);
            this.dgvClientes.TabIndex = 27;
            this.dgvClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientes_CellContentClick);
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
            // cAccion
            // 
            this.cAccion.HeaderText = "Agregar";
            this.cAccion.Name = "cAccion";
            this.cAccion.ReadOnly = true;
            this.cAccion.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cAccion.Text = "Agregar";
            this.cAccion.UseColumnTextForButtonValue = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancelar.BackColor = System.Drawing.Color.DimGray;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCancelar.Location = new System.Drawing.Point(333, 362);
            this.btnCancelar.MaximumSize = new System.Drawing.Size(708, 464);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(80, 30);
            this.btnCancelar.TabIndex = 26;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click_1);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAceptar.BackColor = System.Drawing.Color.DimGray;
            this.btnAceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAceptar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAceptar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAceptar.Location = new System.Drawing.Point(106, 362);
            this.btnAceptar.MaximumSize = new System.Drawing.Size(708, 464);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(80, 30);
            this.btnAceptar.TabIndex = 25;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click_1);
            // 
            // FrmConsultaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 405);
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
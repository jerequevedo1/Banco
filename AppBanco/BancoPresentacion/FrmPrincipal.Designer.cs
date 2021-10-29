
namespace BancoPresentacion
{
	partial class FrmPrincipal
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
			this.panelMenu = new System.Windows.Forms.Panel();
			this.btnSalir = new System.Windows.Forms.Button();
			this.btnConfiguracion = new System.Windows.Forms.Button();
			this.btnTransaccion = new System.Windows.Forms.Button();
			this.btnCliente = new System.Windows.Forms.Button();
			this.btnCuenta = new System.Windows.Forms.Button();
			this.panelIcono = new System.Windows.Forms.Panel();
			this.panelTitleBar = new System.Windows.Forms.Panel();
			this.lblTitle = new System.Windows.Forms.Label();
			this.lblBienvenida = new System.Windows.Forms.Label();
			this.panelChild = new System.Windows.Forms.Panel();
			this.panelMenu.SuspendLayout();
			this.panelTitleBar.SuspendLayout();
			this.SuspendLayout();
			// 
			// panelMenu
			// 
			this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.panelMenu.Controls.Add(this.btnSalir);
			this.panelMenu.Controls.Add(this.btnConfiguracion);
			this.panelMenu.Controls.Add(this.btnTransaccion);
			this.panelMenu.Controls.Add(this.btnCliente);
			this.panelMenu.Controls.Add(this.btnCuenta);
			this.panelMenu.Controls.Add(this.panelIcono);
			this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
			this.panelMenu.Location = new System.Drawing.Point(0, 0);
			this.panelMenu.Name = "panelMenu";
			this.panelMenu.Size = new System.Drawing.Size(220, 561);
			this.panelMenu.TabIndex = 0;
			// 
			// btnSalir
			// 
			this.btnSalir.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.btnSalir.FlatAppearance.BorderSize = 0;
			this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSalir.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.btnSalir.ForeColor = System.Drawing.Color.Silver;
			this.btnSalir.Image = global::BancoPresentacion.Properties.Resources.icon_cerrar_sesion;
			this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnSalir.Location = new System.Drawing.Point(0, 512);
			this.btnSalir.Name = "btnSalir";
			this.btnSalir.Size = new System.Drawing.Size(220, 49);
			this.btnSalir.TabIndex = 5;
			this.btnSalir.Text = "Cerrar Sesion";
			this.btnSalir.UseVisualStyleBackColor = true;
			this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
			// 
			// btnConfiguracion
			// 
			this.btnConfiguracion.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnConfiguracion.FlatAppearance.BorderSize = 0;
			this.btnConfiguracion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnConfiguracion.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.btnConfiguracion.ForeColor = System.Drawing.Color.Silver;
			this.btnConfiguracion.Image = global::BancoPresentacion.Properties.Resources.icon_config;
			this.btnConfiguracion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnConfiguracion.Location = new System.Drawing.Point(0, 259);
			this.btnConfiguracion.Name = "btnConfiguracion";
			this.btnConfiguracion.Size = new System.Drawing.Size(220, 59);
			this.btnConfiguracion.TabIndex = 4;
			this.btnConfiguracion.Text = "Configuracion";
			this.btnConfiguracion.UseVisualStyleBackColor = true;
			this.btnConfiguracion.Click += new System.EventHandler(this.btnConfiguracion_Click);
			// 
			// btnTransaccion
			// 
			this.btnTransaccion.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnTransaccion.FlatAppearance.BorderSize = 0;
			this.btnTransaccion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnTransaccion.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.btnTransaccion.ForeColor = System.Drawing.Color.Silver;
			this.btnTransaccion.Image = global::BancoPresentacion.Properties.Resources.Icono_transacciones;
			this.btnTransaccion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnTransaccion.Location = new System.Drawing.Point(0, 200);
			this.btnTransaccion.Name = "btnTransaccion";
			this.btnTransaccion.Size = new System.Drawing.Size(220, 59);
			this.btnTransaccion.TabIndex = 3;
			this.btnTransaccion.Text = "Transacciones";
			this.btnTransaccion.UseVisualStyleBackColor = true;
			this.btnTransaccion.Click += new System.EventHandler(this.btnTransaccion_Click);
			// 
			// btnCliente
			// 
			this.btnCliente.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnCliente.FlatAppearance.BorderSize = 0;
			this.btnCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCliente.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.btnCliente.ForeColor = System.Drawing.Color.Silver;
			this.btnCliente.Image = global::BancoPresentacion.Properties.Resources.Icono_usuarios;
			this.btnCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCliente.Location = new System.Drawing.Point(0, 141);
			this.btnCliente.Name = "btnCliente";
			this.btnCliente.Size = new System.Drawing.Size(220, 59);
			this.btnCliente.TabIndex = 2;
			this.btnCliente.Text = "Clientes";
			this.btnCliente.UseVisualStyleBackColor = true;
			this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
			// 
			// btnCuenta
			// 
			this.btnCuenta.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnCuenta.FlatAppearance.BorderSize = 0;
			this.btnCuenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCuenta.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.btnCuenta.ForeColor = System.Drawing.Color.Silver;
			this.btnCuenta.Image = global::BancoPresentacion.Properties.Resources.icon_cuentas;
			this.btnCuenta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCuenta.Location = new System.Drawing.Point(0, 80);
			this.btnCuenta.Name = "btnCuenta";
			this.btnCuenta.Size = new System.Drawing.Size(220, 61);
			this.btnCuenta.TabIndex = 1;
			this.btnCuenta.Text = "Cuentas";
			this.btnCuenta.UseVisualStyleBackColor = true;
			this.btnCuenta.Click += new System.EventHandler(this.btnCuenta_Click);
			// 
			// panelIcono
			// 
			this.panelIcono.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
			this.panelIcono.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelIcono.Location = new System.Drawing.Point(0, 0);
			this.panelIcono.Name = "panelIcono";
			this.panelIcono.Size = new System.Drawing.Size(220, 80);
			this.panelIcono.TabIndex = 0;
			// 
			// panelTitleBar
			// 
			this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
			this.panelTitleBar.Controls.Add(this.lblTitle);
			this.panelTitleBar.Controls.Add(this.lblBienvenida);
			this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelTitleBar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.panelTitleBar.Location = new System.Drawing.Point(220, 0);
			this.panelTitleBar.Name = "panelTitleBar";
			this.panelTitleBar.Size = new System.Drawing.Size(764, 80);
			this.panelTitleBar.TabIndex = 1;
			// 
			// lblTitle
			// 
			this.lblTitle.AutoSize = true;
			this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lblTitle.ForeColor = System.Drawing.Color.White;
			this.lblTitle.Location = new System.Drawing.Point(241, 32);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(47, 17);
			this.lblTitle.TabIndex = 1;
			this.lblTitle.Text = "Home";
			// 
			// lblBienvenida
			// 
			this.lblBienvenida.AutoSize = true;
			this.lblBienvenida.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lblBienvenida.ForeColor = System.Drawing.Color.White;
			this.lblBienvenida.Location = new System.Drawing.Point(6, 9);
			this.lblBienvenida.Name = "lblBienvenida";
			this.lblBienvenida.Size = new System.Drawing.Size(81, 17);
			this.lblBienvenida.TabIndex = 0;
			this.lblBienvenida.Text = "Bienvenid@";
			// 
			// panelChild
			// 
			this.panelChild.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelChild.Location = new System.Drawing.Point(220, 80);
			this.panelChild.Name = "panelChild";
			this.panelChild.Size = new System.Drawing.Size(764, 481);
			this.panelChild.TabIndex = 2;
			// 
			// FrmPrincipal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(984, 561);
			this.Controls.Add(this.panelChild);
			this.Controls.Add(this.panelTitleBar);
			this.Controls.Add(this.panelMenu);
			this.MinimumSize = new System.Drawing.Size(1000, 600);
			this.Name = "FrmPrincipal";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.FrmPrincipal_Load);
			this.panelMenu.ResumeLayout(false);
			this.panelTitleBar.ResumeLayout(false);
			this.panelTitleBar.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panelMenu;
		private System.Windows.Forms.Button btnSalir;
		private System.Windows.Forms.Button btnConfiguracion;
		private System.Windows.Forms.Button btnTransaccion;
		private System.Windows.Forms.Button btnCliente;
		private System.Windows.Forms.Button btnCuenta;
		private System.Windows.Forms.Panel panelIcono;
		private System.Windows.Forms.Panel panelTitleBar;
		private System.Windows.Forms.Label lblBienvenida;
		private System.Windows.Forms.Panel panelChild;
		private System.Windows.Forms.Label lblTitle;
	}
}


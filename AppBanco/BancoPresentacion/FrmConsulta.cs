﻿using BancoAccesoDatos;
using BancoDominio;
using BancoDominio.Entidades;
using BancoServicios;
using BancoServicios.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static BancoDominio.Enumeraciones;

namespace BancoPresentacion
{
	public partial class FrmConsulta : Form
	{
		private IClienteService gestorCliente;
		private Tipo tipo;
		private Accion modo;
		private ICuentaService gestorCuenta;
		//private Form activeForm;
		private List<Cliente> lst;

		public FrmConsulta(Tipo tipo)
		{
			InitializeComponent();
			gestorCliente = new ServiceFactory().CrearClienteService(new DaoFactory());
			gestorCuenta = new ServiceFactory().CrearCuentaService(new DaoFactory());
			this.tipo = tipo;
			lst = new List<Cliente>();
		}

		private void btnNuevo_Click(object sender, EventArgs e)
		{
			//opcion con ventana emergente
			modo = Accion.Create;

			if (tipo.Equals(Tipo.Cliente))
			{
				new FrmNuevoEditar(modo, Tipo.Cliente, 0).ShowDialog();
			}
			if (tipo.Equals(Tipo.Cuenta))
			{
				new FrmNuevoEditar(modo, Tipo.Cuenta, 0).ShowDialog();
			}

		}
		private void btnConsultar_Click(object sender, EventArgs e)
		{
			CargarGrilla(tipo);
		}

		private void FrmConsulta_Load(object sender, EventArgs e)
		{
			if (tipo.Equals(Tipo.Cliente))
			{
				CargarTiposFiltros(tipo);
				CargarFiltroFecha(tipo);
				CargarHeaderGrid(tipo);
				CargarGrilla(tipo);
			}
			if (tipo.Equals(Tipo.Cuenta))
			{
				CargarTiposFiltros(tipo);
				//CargarFiltroFecha(tipo);
				CargarHeaderGrid(tipo);
				CargarGrilla(tipo);
			}

		}

		private void CargarHeaderGrid(Tipo tipo)
		{
			if (tipo.Equals(Tipo.Cliente))
			{
				this.dgvConsulta.Columns[0].HeaderText = "NRO CLIENTE";
				this.dgvConsulta.Columns[1].HeaderText = "NOMBRE";
				this.dgvConsulta.Columns[2].HeaderText = "DNI";
				this.dgvConsulta.Columns[3].HeaderText = "DIRECCION";
				this.dgvConsulta.Columns[4].HeaderText = "TELEFONO";
				this.dgvConsulta.Columns[5].HeaderText = "EMAIL";
			}
			if (tipo.Equals(Tipo.Cuenta))
			{
				this.dgvConsulta.Columns[0].HeaderText = "NRO CUENTA";
				this.dgvConsulta.Columns[1].HeaderText = "CLIENTE";
				this.dgvConsulta.Columns[2].HeaderText = "DNI";
				this.dgvConsulta.Columns[3].HeaderText = "TIPO CUENTA";
				this.dgvConsulta.Columns[4].HeaderText = "CBU";
				this.dgvConsulta.Columns[5].HeaderText = "ALIAS";
				this.dgvConsulta.Columns.Add("cExtra", "SALDO");

			}
		}

		private void CargarGrilla(Tipo tipo)
		{
			List<Parametro> filtros = CargarParametros(tipo);

			if (tipo.Equals(Tipo.Cliente))
			{
				//List<Cliente> lst = new List<Cliente>();

				dgvConsulta.Rows.Clear();
				lst = gestorCliente.GetClienteByFilters(filtros);


				foreach (Cliente item in lst)
				{
					dgvConsulta.Rows.Add(new object[] { item.IdCliente, item.NombreCompleto(), item.Dni, item.Direccion.ToString(), item.Telefono, item.Email.ToString()/*item.GetFechaBajaFormato()*/ });
				}
			}
			if (tipo.Equals(Tipo.Cuenta))
			{
				//List<Cliente> lst = new List<Cliente>();

				dgvConsulta.Rows.Clear();
				lst = gestorCuenta.GetCuentaByFilters(filtros);

				foreach (Cliente item in lst)
				{
					int i = 0;
					if (item.Cuentas[i].TipoMoneda.Equals("P"))
					{

						dgvConsulta.Rows.Add(new object[] { item.Cuentas[i].IdCuenta, item.NombreCompleto(), item.Dni, item.Cuentas[i].TipoCuenta.DescTipoCuenta, item.Cuentas[i].Cbu, item.Cuentas[i].Alias, "$ " + item.Cuentas[i].Saldo });

					}
					if (item.Cuentas[i].TipoMoneda.Equals("D"))
					{

						dgvConsulta.Rows.Add(new object[] { item.Cuentas[i].IdCuenta, item.NombreCompleto(), item.Dni, item.Cuentas[i].TipoCuenta.DescTipoCuenta, item.Cuentas[i].Cbu, item.Cuentas[i].Alias, "U$S " + item.Cuentas[i].Saldo });

					}
					i++;
				}

			}

		}

		private List<Parametro> CargarParametros(Tipo tipo)
		{
			List<Parametro> filtros = new List<Parametro>();
			object filtroTexto = DBNull.Value;
			string conBaja = "N";

			// filtros.Add(new Parametro("@fechaDesde", dtpFechaDesde.Value)); //Esta comentado para definir si agregamos enum
			// filtros.Add(new Parametro("@fechaHasta", dtpFechaHasta.Value));

			if (!String.IsNullOrEmpty(txtFiltro.Text))
			{
				filtroTexto = txtFiltro.Text;
				if (tipo.Equals(Tipo.Cliente))
				{
					if (cboFiltro.SelectedIndex == 0)
					{
						filtros.Add(new Parametro("@nroCliente", filtroTexto));
					}
					else
					{
						filtros.Add(new Parametro("@ClienteNombre", filtroTexto));
					}
				}
				if (tipo.Equals(Tipo.Cuenta))
				{
					switch (cboFiltro.SelectedIndex)
					{
						case 0:
							filtros.Add(new Parametro("@nroCuenta", filtroTexto));
							break;
						case 1:
							filtros.Add(new Parametro("@ClienteNombre", filtroTexto));
							break;
						case 2:
							filtros.Add(new Parametro("@cbu", filtroTexto));
							break;
						case 3:
							filtros.Add(new Parametro("@alias", filtroTexto));
							break;
						case 4:
							filtros.Add(new Parametro("@clienteNombre", filtroTexto));
							break;
					}
				}
			}


			if (chkBaja.Checked) conBaja = "S";

			filtros.Add(new Parametro("@activo", conBaja));

			filtros.Add(new Parametro("@tipo", cboFiltro.SelectedIndex));

			return filtros;
		}

		private void CargarFiltroFecha(Tipo tipo)
		{
			if (tipo.Equals(Tipo.Cliente))
			{
				string[] filtrosFecha = new string[] { "Hoy", "Ayer", "Ultimos 7 dias", "Ultimos 14 dias", "Ultimos 28 dias" };
				cboFiltroFecha.Items.Clear();
				cboFiltroFecha.Items.AddRange(filtrosFecha);
			}

			cboFiltroFecha.SelectedIndex = 4;
		}
		private void CargarTiposFiltros(Tipo tipo)
		{
			if (tipo.Equals(Tipo.Cliente))
			{
				string[] tiposFiltros = new string[] { "Numero de Cliente", "Nombre Cliente", "Inactivos" };

				cboFiltro.Items.Clear();
				cboFiltro.Items.AddRange(tiposFiltros);
			}
			if (tipo.Equals(Tipo.Cuenta))
			{
				string[] tiposFiltros = new string[] { "Numero de Cuenta", "Nombre Cliente", "Cbu", "Alias", "Inactivos" };

				cboFiltro.Items.Clear();
				cboFiltro.Items.AddRange(tiposFiltros);
			}
			cboFiltro.SelectedIndex = 0;
		}

		private void cboFiltroFecha_SelectedIndexChanged(object sender, EventArgs e)
		{
			switch (cboFiltroFecha.SelectedIndex)
			{
				case 0:
					dtpFechaDesde.Value = DateTime.Today;
					break;
				case 1:
					dtpFechaDesde.Value = DateTime.Today.AddDays(-1);
					break;
				case 2:
					dtpFechaDesde.Value = DateTime.Today.AddDays(-7);
					break;
				case 3:
					dtpFechaDesde.Value = DateTime.Today.AddDays(-14);
					break;
				case 4:
					dtpFechaDesde.Value = DateTime.Today.AddDays(-28);
					break;
			}
		}

		private void btnEditar_Click(object sender, EventArgs e)
		{
			modo = Accion.Update;
			if (tipo.Equals(Tipo.Cliente))
			{
				if (dgvConsulta.RowCount > 0)
				{
					int nroCliente = Convert.ToInt32(dgvConsulta.CurrentRow.Cells[0].Value.ToString());
					new FrmNuevoEditar(modo, Tipo.Cliente, nroCliente).ShowDialog();
					CargarGrilla(tipo);
				}
				else
				{
					MessageBox.Show("No hay clientes en consulta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			if (tipo.Equals(Tipo.Cuenta))
			{
				if (dgvConsulta.RowCount > 0)
				{
					int nroCliente = 0;
					int nroCuenta = Convert.ToInt32(dgvConsulta.CurrentRow.Cells[0].Value.ToString());
					foreach (Cliente item in lst)
					{
						int i = 0;
						if (item.Cuentas[i].IdCuenta.Equals(nroCuenta))
						{
							nroCliente = item.IdCliente;
						}
						i++;
					}
					new FrmNuevoEditar(modo, Tipo.Cuenta, nroCliente).ShowDialog();
					CargarGrilla(tipo);
				}
				else
				{
					MessageBox.Show("No hay cuentas en consulta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}
		private void btnEliminar_Click(object sender, EventArgs e)
		{
			modo = Accion.Delete;
			if (tipo.Equals(Tipo.Cliente))
			{
				if (dgvConsulta.RowCount > 0)
				{
					int nro = Convert.ToInt32(dgvConsulta.CurrentRow.Cells[0].Value.ToString());
					
				}
				else
				{
					MessageBox.Show("No hay clientes en consulta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			if (tipo.Equals(Tipo.Cuenta))
			{
				if (dgvConsulta.RowCount > 0)
				{
					int nro = Convert.ToInt32(dgvConsulta.CurrentRow.Cells[0].Value.ToString());
					
				}
				else
				{
					MessageBox.Show("No hay cuentas en consulta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}

		}

	}
}

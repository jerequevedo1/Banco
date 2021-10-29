﻿using BancoDominio;
using BancoDominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoServicios.Interfaces
{
	public interface ICuentaService
	{
		public List<Cuenta> GetCuentaByFilters(List<Parametro> parametros);
	}
}
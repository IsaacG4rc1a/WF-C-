using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
	public class CD_Conexion
	{
		private SqlConnection Conection = new SqlConnection(@"Server=DESKTOP-0SD9P5K\CHACOJR; Database=Practica;;Integrated Security=true");

		public SqlConnection ObtenerConeccion()
		{
			if (Conection.State == ConnectionState.Closed)
				Conection.Open();
				return Conection;
		}

		public SqlConnection CerrarConeccion()
		{
			if (Conection.State == ConnectionState.Open)
				Conection.Close();
			return Conection;
		}
	}
}

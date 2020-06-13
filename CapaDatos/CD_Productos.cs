using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
	public class CD_Productos
	{
		private CD_Conexion Conexion = new CD_Conexion();
		SqlDataReader Leer;
		SqlCommand comando = new SqlCommand();
		DataTable Tabla = new DataTable();
		DataTable cate = new DataTable();


		public DataTable mostrar()
		{
			comando.Connection = Conexion.ObtenerConeccion();
			comando.CommandText = "MostrarProductos";
			comando.CommandType = CommandType.StoredProcedure;

			Leer = comando.ExecuteReader();
			Tabla.Load(Leer);

			Conexion.CerrarConeccion();

			return Tabla;
		}

		public DataTable mostarCate()
		{
			comando.Connection = Conexion.ObtenerConeccion();
			comando.CommandText = "ListarCate";
			comando.CommandType = CommandType.StoredProcedure;

			Leer = comando.ExecuteReader();
			cate.Load(Leer);

			Conexion.CerrarConeccion();

			return cate;
		}

		public void Insertar(string nombre, string descripcion, string marca, double precio, int stock, int cate, int estado)
		{
			comando.Connection = Conexion.ObtenerConeccion();
			comando.CommandText = "InsetarProductos";
			comando.CommandType = CommandType.StoredProcedure;

			comando.Parameters.AddWithValue("@nombre", nombre);
			comando.Parameters.AddWithValue("@descrip", descripcion);
			comando.Parameters.AddWithValue("@marca", marca);
			comando.Parameters.AddWithValue("@precio", precio);
			comando.Parameters.AddWithValue("@stock", stock);
			comando.Parameters.AddWithValue("@cate", cate);
			comando.Parameters.AddWithValue("@estado", 1);

			comando.ExecuteNonQuery();

			comando.Parameters.Clear();

			Conexion.CerrarConeccion();
		}

		public void Editar(string nombre, string descripcion, string marca, double precio, int stock, int cate,int Id)
		{
			comando.Connection = Conexion.ObtenerConeccion();
			comando.CommandText = "EditarProductos";
			comando.CommandType = CommandType.StoredProcedure;

			comando.Parameters.AddWithValue("@nombre", nombre);
			comando.Parameters.AddWithValue("@descrip", descripcion);
			comando.Parameters.AddWithValue("@marca", marca);
			comando.Parameters.AddWithValue("@precio", precio);
			comando.Parameters.AddWithValue("@stock", stock);
			comando.Parameters.AddWithValue("@cate", cate);
			comando.Parameters.AddWithValue("@id", Id);

			comando.ExecuteNonQuery();
			comando.Parameters.Clear();

			Conexion.CerrarConeccion();
		}

		public void Eliminar (int id)
		{
			comando.Connection = Conexion.ObtenerConeccion();
			comando.CommandText = "EliminarProducto";
			comando.CommandType = CommandType.StoredProcedure;

			comando.Parameters.AddWithValue("@idpro", id);

			comando.ExecuteNonQuery();

			comando.Parameters.Clear();
			Conexion.CerrarConeccion();
		}
	}
}

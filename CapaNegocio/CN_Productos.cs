using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;

namespace CapaNegocio
{
	public class CN_Productos
	{
		private CD_Productos _CRUD = new CD_Productos();

		//Mostrar datos en la tabla
		public DataTable MostrarProd()
		{
			DataTable Tabla = new DataTable();
			Tabla = _CRUD.mostrar();
			return Tabla;
		}

		public DataTable mostrarCate()
		{
			DataTable Cate = new DataTable();
			Cate = _CRUD.mostarCate();
			return Cate;
		}

		public void InsertarProd(string nombre, string descripcion, string marca, string precio, string stock, int cate, string estado)
		{
			_CRUD.Insertar(nombre,descripcion,marca,Convert.ToDouble(precio), Convert.ToInt16(stock), cate, Convert.ToInt16(estado));
		}

		public void	EditarProd(string nombre, string descripcion, string marca, string precio, string stock, int cate, string Id)
		{
			_CRUD.Editar(nombre, descripcion, marca, Convert.ToDouble(precio), Convert.ToInt16(stock), cate, Convert.ToInt16(Id));
		}

		public void Eliminar(string id)
		{
			_CRUD.Eliminar(Convert.ToInt16(id));
		}
	}
}

using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
	public partial class frmProductos : Form
	{
		CN_Productos _Crud = new CN_Productos();
		DataTable tabla = new DataTable();
		private string idProd = null;
		private bool Editar = false;
		string estado = "1";

		public frmProductos()
		{
			InitializeComponent();
			
		}

		private void frmProductos_Load(object sender, EventArgs e)
		{
			MostrarProdcs();
			MostrarCate();
			tabla.Columns.Add("Nombre", typeof(string));
		}

		private void MostrarCate()
		{
			cbCate.DataSource = _Crud.mostrarCate();
			cbCate.DisplayMember = "Categoria";
			cbCate.ValueMember = "Id";
		}

		//Lista los productos
		private void MostrarProdcs()
		{
			CN_Productos objeto = new CN_Productos();
			dgvProd.DataSource = objeto.MostrarProd();
		}

		private void btnGuardar_Click(object sender, EventArgs e)
		{
			if (Editar == false && Convert.ToInt32(cbCate.SelectedValue) != 0)
			{
				try
				{
					//INSERTA DATOS A TABLA, CONEXION SQL. (TABLA 1)
					_Crud.InsertarProd(txtNombre.Text, txtDescrip.Text, txtMarca.Text, txtPrecio.Text, txtStock.Text, Convert.ToInt32(cbCate.SelectedValue), estado);
					MostrarProdcs();
					

					//INSERTA DATO A TABLA TEMPORAL (TABLA 2)
					tabla.Rows.Add(txtNombre.Text);

					dgvTemporal.DataSource = tabla;

					MessageBox.Show("El registro se agregó correctamente.");
					limpiarForm();
				}
				catch (Exception ex)
				{

					MessageBox.Show("no se pudo insertar los datos por: " + ex);
				}
				
			}
			if (Editar == true)
			{
				try
				{
					_Crud.EditarProd(txtNombre.Text, txtDescrip.Text, txtMarca.Text, txtPrecio.Text, txtStock.Text, Convert.ToInt32(cbCate.SelectedValue), idProd);
					MessageBox.Show("se edito correctamente");
					MostrarProdcs();
					limpiarForm();
					Editar = false;
				}
				catch (Exception ex)
				{
					MessageBox.Show("no se pudo editar los datos por: " + ex);
				}
			}
		}

		private void limpiarForm()
		{
			txtDescrip.Clear();
			txtMarca.Text = "";
			txtPrecio.Clear();
			txtStock.Clear();
			txtNombre.Clear();
		}

		private void btnEditar_Click(object sender, EventArgs e)
		{
			if (dgvProd.SelectedRows.Count > 0)
			{
				Editar = true;

				txtNombre.Text = dgvProd.CurrentRow.Cells["Nombre"].Value.ToString();
				txtDescrip.Text = dgvProd.CurrentRow.Cells["Descripcion"].Value.ToString();
				txtMarca.Text = dgvProd.CurrentRow.Cells["Marca"].Value.ToString();
				txtPrecio.Text = dgvProd.CurrentRow.Cells["Precio"].Value.ToString();
				txtStock.Text = dgvProd.CurrentRow.Cells["Stock"].Value.ToString();
				cbCate.SelectedValue = dgvProd.CurrentRow.Cells["Categoria"].Value.ToString();
				idProd = dgvProd.CurrentRow.Cells["Id"].Value.ToString();
			}
			else
			{
				MessageBox.Show("seleccione una fila por favor.");
			}
		}

		private void btnEliminar_Click(object sender, EventArgs e)
		{
			if (dgvProd.SelectedRows.Count > 0)
			{
				idProd = dgvProd.CurrentRow.Cells["Id"].Value.ToString();
				_Crud.Eliminar(idProd);
				MessageBox.Show("Eliminado correctamente");
				MostrarProdcs();
			}
			else
				MessageBox.Show("seleccione una fila por favor");
		}
	}
}

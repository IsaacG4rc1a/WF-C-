namespace CapaPresentacion
{
	partial class frmProductos
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
			this.dgvProd = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.txtDescrip = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtMarca = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtPrecio = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtStock = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.btnGuardar = new System.Windows.Forms.Button();
			this.btnEditar = new System.Windows.Forms.Button();
			this.btnEliminar = new System.Windows.Forms.Button();
			this.cbCate = new System.Windows.Forms.ComboBox();
			this.label6 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dgvProd)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvProd
			// 
			this.dgvProd.AllowUserToAddRows = false;
			this.dgvProd.AllowUserToDeleteRows = false;
			this.dgvProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvProd.Location = new System.Drawing.Point(12, 42);
			this.dgvProd.Name = "dgvProd";
			this.dgvProd.ReadOnly = true;
			this.dgvProd.Size = new System.Drawing.Size(523, 313);
			this.dgvProd.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(566, 42);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(44, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Nombre";
			// 
			// txtNombre
			// 
			this.txtNombre.Location = new System.Drawing.Point(618, 42);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(132, 20);
			this.txtNombre.TabIndex = 2;
			// 
			// txtDescrip
			// 
			this.txtDescrip.Location = new System.Drawing.Point(618, 68);
			this.txtDescrip.Name = "txtDescrip";
			this.txtDescrip.Size = new System.Drawing.Size(132, 20);
			this.txtDescrip.TabIndex = 4;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(549, 68);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(63, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Descripcion";
			// 
			// txtMarca
			// 
			this.txtMarca.Location = new System.Drawing.Point(618, 94);
			this.txtMarca.Name = "txtMarca";
			this.txtMarca.Size = new System.Drawing.Size(132, 20);
			this.txtMarca.TabIndex = 6;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(566, 94);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(37, 13);
			this.label3.TabIndex = 5;
			this.label3.Text = "Marca";
			// 
			// txtPrecio
			// 
			this.txtPrecio.Location = new System.Drawing.Point(618, 120);
			this.txtPrecio.Name = "txtPrecio";
			this.txtPrecio.Size = new System.Drawing.Size(132, 20);
			this.txtPrecio.TabIndex = 8;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(566, 120);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(37, 13);
			this.label4.TabIndex = 7;
			this.label4.Text = "Precio";
			// 
			// txtStock
			// 
			this.txtStock.Location = new System.Drawing.Point(618, 146);
			this.txtStock.Name = "txtStock";
			this.txtStock.Size = new System.Drawing.Size(132, 20);
			this.txtStock.TabIndex = 10;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(566, 146);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(35, 13);
			this.label5.TabIndex = 9;
			this.label5.Text = "Stock";
			// 
			// btnGuardar
			// 
			this.btnGuardar.Location = new System.Drawing.Point(569, 207);
			this.btnGuardar.Name = "btnGuardar";
			this.btnGuardar.Size = new System.Drawing.Size(181, 29);
			this.btnGuardar.TabIndex = 11;
			this.btnGuardar.Text = "Guardar";
			this.btnGuardar.UseVisualStyleBackColor = true;
			this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
			// 
			// btnEditar
			// 
			this.btnEditar.Location = new System.Drawing.Point(12, 361);
			this.btnEditar.Name = "btnEditar";
			this.btnEditar.Size = new System.Drawing.Size(181, 29);
			this.btnEditar.TabIndex = 12;
			this.btnEditar.Text = "Editar";
			this.btnEditar.UseVisualStyleBackColor = true;
			this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
			// 
			// btnEliminar
			// 
			this.btnEliminar.Location = new System.Drawing.Point(199, 361);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(181, 29);
			this.btnEliminar.TabIndex = 13;
			this.btnEliminar.Text = "Elimnar";
			this.btnEliminar.UseVisualStyleBackColor = true;
			this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
			// 
			// cbCate
			// 
			this.cbCate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbCate.FormattingEnabled = true;
			this.cbCate.Location = new System.Drawing.Point(618, 173);
			this.cbCate.Name = "cbCate";
			this.cbCate.Size = new System.Drawing.Size(132, 21);
			this.cbCate.TabIndex = 14;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(566, 176);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(52, 13);
			this.label6.TabIndex = 15;
			this.label6.Text = "Categoria";
			// 
			// frmProductos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(818, 455);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.cbCate);
			this.Controls.Add(this.btnEliminar);
			this.Controls.Add(this.btnEditar);
			this.Controls.Add(this.btnGuardar);
			this.Controls.Add(this.txtStock);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.txtPrecio);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtMarca);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtDescrip);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtNombre);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dgvProd);
			this.Name = "frmProductos";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.frmProductos_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvProd)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvProd;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.TextBox txtDescrip;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtMarca;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtPrecio;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtStock;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button btnGuardar;
		private System.Windows.Forms.Button btnEditar;
		private System.Windows.Forms.Button btnEliminar;
		private System.Windows.Forms.ComboBox cbCate;
		private System.Windows.Forms.Label label6;
	}
}


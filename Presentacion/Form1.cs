using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FormProducto : Form
    {
        public FormProducto()
        {
            InitializeComponent();
        }

        public ProductoServicio productoServicio = new ProductoServicio();

        private void FormProducto_Load(object sender, EventArgs e)
        {
            dgvProducto.DataSource = productoServicio.listarProductos();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string descripcion = txtDescripcion.Text;
            double precio = double.Parse(txtPrecio.Text);
            int existencia = int.Parse(txtStock.Text);

            bool seGuardo = productoServicio.GuardarProducto(nombre, descripcion, precio, existencia);

            if (seGuardo)
            {
                MessageBox.Show("Producto guardado con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                actualizarDgv();
                limpiarCampos();
            }

        }

        private void actualizarDgv() 
        {
            dgvProducto.DataSource = null;
            dgvProducto.DataSource = productoServicio.listarProductos();
        }
        private void limpiarCampos() 
        {
            txtNombre.Clear();
            txtDescripcion.Clear();
            txtPrecio.Clear();
            txtStock.Clear();
            txtNombre.Focus();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PantallasBD
{
    public partial class FormActualizar : Form
    {
        public FormActualizar()
        {
            InitializeComponent();
        }

        private void btnActualizarPrecio_Click_1(object sender, EventArgs e)
        {
            String strNombreProd = txtNombre.Text;
            SqlConnection conexion = new SqlConnection("Data Source=ASUS; database=Facturacion; Integrated Security= SSPI");
            conexion.Open();
            String strComando = "UPDATE productos SET precio_unit = " + txtPrecio.Text + "WHERE nombre_prod LIKE '" + strNombreProd + "%' OR id_producto = "+strNombreProd;
            SqlCommand comando = new SqlCommand(strComando, conexion);
            int num = comando.ExecuteNonQuery();
            txtAfectacion.Text = num.ToString();
        }

        private void btnActualizarStock_Click_1(object sender, EventArgs e)
        {
            String strNombreProd = txtNombre.Text;
            SqlConnection conexion = new SqlConnection("Data Source=ASUS; database=Facturacion; Integrated Security= SSPI");
            conexion.Open();
            String strComando = "UPDATE productos SET unidad += " + txtCantidad.Text + "WHERE nombre_prod LIKE '" + strNombreProd + "%' OR id_producto = " + strNombreProd;
            SqlCommand comando = new SqlCommand(strComando, conexion);
            int num = comando.ExecuteNonQuery();
            txtActualizacion2.Text = num.ToString();
        }

        private void txtNombre_Leave(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                txtNombre.Text = "Nombre o ID";
                txtNombre.ForeColor = Color.Gray;
            }
        }

        private void txtNombre_Enter(object sender, EventArgs e)
        {
            if (txtNombre.Text == "Nombre o ID")
            {
                txtNombre.Text = "";
                txtNombre.ForeColor = Color.Black;
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

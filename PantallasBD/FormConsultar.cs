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
    public partial class FormConsultar : Form
    {
        public FormConsultar()
        {
            InitializeComponent();
        }

        string strConn;
        string strComm;
        SqlConnection conn; 
        SqlCommand comm;

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textCodigo.Text)) {
                return;
            }
            String codigo = textCodigo.Text;
            strConn = "Data Source=ASUS; database=Facturacion; Integrated Security=SSPI";
            using (conn = new SqlConnection(strConn))
            {
                conn.Open();
                strComm = "SELECT * FROM Productos WHERE id_producto = " + codigo;
                comm = new SqlCommand(strComm, conn);
                SqlDataReader reader = comm.ExecuteReader();
                while (reader.Read()) { 
                    string nombre = reader.GetString(1);
                    decimal precioUnit = reader.GetDecimal(2);
                    string unidad = reader.GetString(3);
                    int tipo = reader.GetInt32(4);
                    int proveedor = reader.GetInt32(5);
                    ListViewItem item = new ListViewItem(nombre);
                    item.SubItems.Add(precioUnit.ToString());
                    item.SubItems.Add(unidad);
                    item.SubItems.Add(tipo.ToString());
                    item.SubItems.Add(proveedor.ToString());
                    listaConsulta.Items.Add(item);
                }   
                textCodigo.Clear();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            listaConsulta.Items.Clear();
        }
    }
}

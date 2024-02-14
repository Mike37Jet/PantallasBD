﻿using System;
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
    public partial class FormEliminar : Form
    {
        public FormEliminar()
        {
            InitializeComponent();
        }

        string strConn = null;
        string strComm = null;
        SqlConnection conn = null;
        SqlCommand comm = null;

        private void FormEliminar_Load(object sender, EventArgs e)
        {
        
        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            String codigo = this.txtCodigo.Text;

            // Reemplaza la cadena de conexión con la correcta para tu entorno
            string strConn = "Data Source=ASUS; database=Facturacion; Integrated Security=SSPI";

            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();

                // Utiliza parámetros para evitar problemas de seguridad y manejar tipos de datos
                string strComm = "DELETE FROM Productos WHERE id_producto = " + codigo + "";

                using (comm = new SqlCommand(strComm, conn))
                {
                    int num = comm.ExecuteNonQuery();
                    txtN2.Text = num.ToString();
                }
            }
        }
    }
}

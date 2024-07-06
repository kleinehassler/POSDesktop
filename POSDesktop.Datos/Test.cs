using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POSDesktop.Datos;
using MySql.Data;
using MySql.Data.MySqlClient;


namespace POSDesktop.Datos
{
    public partial class Test : Form
    {
        public Test()
        {
            InitializeComponent();
        }

        private void Test_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            try
            {
                string cadenaconexion1 = "Server=hassler.ec;Database=hasslere_sc_facturacion;Uid=hasslere_siscon;Pwd=M4ch4l42@22;";

                MySqlConnection mycon = new MySqlConnection(cadenaconexion1);
                mycon.Open();
                label1.Text = "Conexion Exitosa";
            }
            catch (Exception ex)
            {
                label1.Text = "Error de Conexion " + ex.Message;
            }
        }
    }
}

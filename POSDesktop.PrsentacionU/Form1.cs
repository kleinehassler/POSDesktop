using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data;
using MySql.Data.MySqlClient;


namespace POSDesktop.PrsentacionU
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            try
            {
                string cadenaconexion1 = "Server=hassler.ec;Database=hasslere_sc_facturacion;Uid=hasslere_siscon;Pwd=Machala2022;";

                MySqlConnection mycon = new MySqlConnection(cadenaconexion1);
                mycon.Open();
                label1.Text = "Conexion Exitosa";
            }
            catch (Exception ex)
            {
                label1.Text = "Error de Conexion " + ex.Message;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}

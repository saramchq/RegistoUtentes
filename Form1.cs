using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace RegistoUtentes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnsalvar_Click(object sender, EventArgs e)
        {
            try
            {
                string string_cnn = "datasource=localhost;port=3306;username=root;password=11111;database=registoclientes";

                string sql = "INSERT INTO clientes(nome, telefone, morada, numero, complemento, codigopostal, pais, concelho, cidade) VALUES ('" + txtnome + "', '" + txttelefone + "', '" + txtmorada + "', '" + txtnumero + "', '" + txtcomplemento + "', '" + txtcodpostal + "','" + txtpais + "', '" + txtconcelho + "', '" + txtcidade + "')";


                MySqlConnection cnn = new MySqlConnection(string_cnn);


                MySqlCommand retorno_comando = new MySqlCommand(sql, cnn);

                cnn.Open();

                retorno_comando.ExecuteReader();

                MessageBox.Show("Salvo com sucesso!");

                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }
    }
}

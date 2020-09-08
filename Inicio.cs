using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Formulario
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void BotonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            //BtnEntrar.Enabled = false;
        }

        private void controlBotones()
        {
            if (txtNombre.Text.Trim() != string.Empty && txtNombre.Text.All(Char.IsLetter))
            {
                //BtnEntrar.Enabled = true;
                //errorProvider1.SetError(Nombre, "");
            }
            else
            {
                if (!(txtNombre.Text.All(Char.IsLetter)))
                {
                   // errorProvider1.SetError(Nombre, "El nombre sólo debe contener letras");
                }
                else
                {
                   // errorProvider1.SetError(Nombre, "Debe introducir su nombre");
                }
                //BtnEntrar.Enabled = false;
                txtNombre.Focus();
            }
        }

        private void Nombre_TextChanged(object sender, EventArgs e)
        {
            controlBotones();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BotonEntrar_Click(object sender, EventArgs e)
        {

            SqlConnection conexion = new SqlConnection("data source=DESKTOP-BD0UES6; initial catalog=estuadiante");
            try
            {
                conexion.Open();
                MessageBox.Show("Connection Open ! ");
                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! ");
            }

        }

		private void button1_Click(object sender, EventArgs e)
		{
            SqlConnection conexion = new SqlConnection("data source=DESKTOP-BD0UES6; initial catalog=estudiante; Integrated Security=True");
            try
            {
            conexion.Open();
            //MessageBox.Show("Connection Open ! ");             

            // Se guardan la info de los estudiantes
            string nombre = txtNombre.Text;
            string genero = cBoxGenero.Text;
            string telefono = txtNumero.Text;
            string carrera = txtCarrera.Text;
            string condiciones = Termino.Text;

            string cadena = "insert into escuela (Nombre,Genero,telefono,carrera,Condiciones) values ('" + nombre + "','" + genero + "','" + telefono + "', '" + carrera + "','" + condiciones + "' ) ";
            SqlCommand comando = new SqlCommand(cadena,conexion);
            comando.ExecuteNonQuery();
            MessageBox.Show("Registro guardado");
            conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! ");
            }

        }




        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            grillaListadeRegistros grillaListadeRegistros = new grillaListadeRegistros();
            grillaListadeRegistros.Show();

        }
    }
}

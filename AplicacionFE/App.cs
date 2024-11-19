using AplicacionBE.Persistence;
using AplicacionBE.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacionFE
{
    public partial class App : Form
    {
        DatosPersistence dp = new DatosPersistence();
        public App()
        {
            InitializeComponent();
            CargaDatos();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Obtener datos de los TextBox
            string nombre = tbNombre.Text;
            int edad;

            // Validar que la edad sea un número entero
            if (!int.TryParse(tbEdad.Text, out edad))
            {
                MessageBox.Show("Por favor, ingrese una edad válida.");
                return;
            }

            // Crear una nueva instancia de Datos
            Datos datos = new Datos
            {
                Nombre = nombre,
                Edad = edad
            };

            // Verificar la edad utilizando el método Verificar
            string resultadoVerificacion = datos.Verificar(edad);
            MessageBox.Show(resultadoVerificacion);

            // Si la verificación es exitosa, insertar los datos en la persistencia
            if (resultadoVerificacion == "Acceso concedido")
            {
                dp.InsertarDatos(datos);

                // Limpiar los TextBox después de agregar
                tbNombre.Clear();
                tbEdad.Clear();

                MessageBox.Show("Datos agregados exitosamente.");

                // Recargar los datos en el DataGridView
                CargaDatos();
            }
            else
            {
                MessageBox.Show("No se pueden agregar los datos debido a la edad.");
            }
        }

        private void CargaDatos()
        {
            dp.LeerArchivo();
            dgvLista.DataSource = dp.DatosTable;
        }

        private void App_Load(object sender, EventArgs e)
        {

        }
    }
}

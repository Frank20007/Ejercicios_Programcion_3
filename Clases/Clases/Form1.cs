using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clases
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEjecutar_Click(object sender, EventArgs e)
        {
            //Persona Pedro = new Persona();

            //Pedro.Nombre = NombreTextBox.Text;
            //Pedro.Apellido = ApellidoTextBox.Text;
            //Pedro.Edad = Convert.ToInt32(EdadTextBox.Text);
            //Pedro.Direccion = DireccionTextBox.Text;

            Personas Pedro = new Personas(txtNombre .Text, txtApellido .Text, Convert.ToInt32(txtEdad .Text), txtDireccion .Text);

            string NombreCompleto = Pedro.DevolverNombreCompleto();

            MessageBox.Show(NombreCompleto);



        }
    }
}

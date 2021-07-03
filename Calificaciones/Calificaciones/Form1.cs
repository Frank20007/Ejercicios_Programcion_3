using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calificaciones
{
    public partial class frmCalificaciones : Form
    {
        public frmCalificaciones()
        {
            InitializeComponent();
        }

        private void btnEjecutar_Click(object sender, EventArgs e)
        {
            Promedio Estudiante = new Promedio(txtNombre.Text,Convert .ToInt32 ( txtCuenta.Text),Convert .ToInt32 ( txtNota1.Text),Convert .ToInt32 ( txtNota2.Text),Convert .ToInt32( txtNota3.Text),Convert .ToInt32 ( txtNota4.Text));

            string promedio = Estudiante.DevolverPromnedio();

            MessageBox.Show(promedio);


            string aprobadoreprobado = Estudiante.AprobadoReprobado();

            MessageBox.Show(aprobadoreprobado);

        }
    }
}

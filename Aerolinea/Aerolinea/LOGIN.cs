using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Aerolinea
{
    public partial class FrmLogin : Syncfusion.Windows.Forms.Office2010Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            if (TxtUsuario.Text == "")
            {
                errorProvider1.SetError(TxtUsuario, "Ingrese el usuario");
                TxtUsuario .Focus();
                return;
            }
            errorProvider1.SetError(TxtUsuario , "");
            if (TxtContra .Text == "")
            {
                errorProvider1.SetError(TxtContra , "Ingrese la contraseña");
                TxtContra .Focus();
                return;
            }
            errorProvider1.SetError(TxtContra , "");

            BaseDatos conexion = new BaseDatos();

            if (conexion.ValidarUsuario(TxtUsuario.Text, TxtContra.Text))
            {
                FrmPrincipal formulario = new FrmPrincipal();
                this.Hide();
                formulario.Show();
            }
            else
            {
                MessageBox.Show("Usuario ó Contraseña Invalidos");
            }





        }
    }
}

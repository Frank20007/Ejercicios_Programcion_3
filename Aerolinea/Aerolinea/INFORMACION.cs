using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Aerolinea
{
    public partial class FrmInformacion : Syncfusion.Windows.Forms.Office2010Form
    {
        public FrmInformacion()
        {
            InitializeComponent();
        }
        BaseDatos bd = new BaseDatos();

        private void INFORMACION_Load(object sender, EventArgs e)
        {
            ListarPasajeros();
        }

        private void ListarPasajeros()
        {
            DgInformación.DataSource = bd.ListarPasajeros();  
        }
    }
}

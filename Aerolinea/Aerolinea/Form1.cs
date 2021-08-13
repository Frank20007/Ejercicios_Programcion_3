using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Linq;
namespace Aerolinea
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int factura, ID_maleta, x;
        ulong precio_boleto, precio_maleta, impuesto, subtotal, descuento, total, precio_boleto2, precio_maleta2, impuesto2, subtotal2, descuento2, total2, cambio_dolar;

        private void Form1_Load(object sender, EventArgs e)
        {
            x1 = 0;
            precio_boleto = 0;
        precio_boleto2 = 0;
        LvVuelos.Enabled = false ;
            TxtFactura.Enabled = false;
            TxtBoleto.Enabled = false ;
            TxtBoleto2.Enabled =  false ;
            TxtMaletas.Enabled = false ;
            TxtMaletas2.Enabled = false ;
            TxtImpuesto.Enabled = false ;
            TxtImpuesto2.Enabled = false ;
            TxtSubTotal.Enabled = false ;
            TxtSubTotal2.Enabled = false ;
            TxtDescuento.Enabled = false ;
            TxtDescuento2.Enabled = false ;
            TxtTotal.Enabled = false ;
            TxtTotal2.Enabled = false ;
            RbDirecto.Enabled = false ;
            RbEscala.Enabled = false ;
            TxtEscala.Enabled = false ;
            TxtAsiento.Enabled = false ;
            TxtFechaSalida.Enabled = false ;
            TxtFechaRegreso.Enabled = false ;
            CmbPeso.Enabled = false ;
            TxtEdad.Enabled = false ;
            McSalida.Enabled = false ;
            McRegreso.Enabled = false ;
            CmbAbordaje.Enabled = false ;
            CmbDestino.Enabled = false ;
            CmbColumna.Enabled = false ;
            CmbFila.Enabled = false ;
            NdMaletas.Enabled = false ;
            CmbPeso.Enabled = false ;
            RbCredito.Enabled = false ;
            RbEfectivo.Enabled = false ;
            TxtNombre.Enabled = false ;
            RbSi.Enabled = false ;
            BtnCalcular.Enabled = false ;
            BtnRegistrar.Enabled = false ;


            TxtBoleto.Text = "0" & " U$";
            TxtBoleto2.Text = "0" & " Lps";
            TxtMaletas.Text = "0" & " U$";
            TxtMaletas2.Text = "0" & " Lps";
            TxtImpuesto.Text = "0" & " U$";
            TxtImpuesto2.Text = "0" & " Lps";
            TxtSubTotal.Text = "0" & " U$";
            TxtSubTotal2.Text = "0" & " Lps";
            TxtDescuento.Text = "0" & " U$";
            TxtDescuento2.Text = "0" & " Lps";
            TxtTotal.Text = "0" & " U$";
            TxtTotal2.Text = "0" & " Lps";

        'factura'
        Randomize()
        factura = Rnd() * 1000;
            TxtFactura.Text = factura & "°";
        }
    }
}

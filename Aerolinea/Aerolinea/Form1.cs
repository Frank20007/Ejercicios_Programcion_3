﻿using System;
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
        decimal impuesto;
        decimal impuesto2;
        decimal subtotal;
        decimal  cambio_dolar;
        decimal subtotal2;
        decimal descuento;
        decimal descuento2;
        decimal total;
        decimal total2;
       
        int precio_boleto, precio_boleto2, precio_maleta2, precio_maleta;
        int factura, ID_maleta, x;

        private void RbSi_CheckedChanged(object sender, EventArgs e)
        {
            TxtEdad.Enabled = true;
            McSalida.Enabled = true;
        }

        private void McSalida_DateChanged(object sender, DateRangeEventArgs e)
        {
            TxtFechaSalida.Text = Convert.ToString( McSalida.SelectionStart.Date);

            //'Restricciones'
            if (McSalida.SelectionStart < McSalida.TodayDate)
            {
                MessageBox.Show("La fecha de salida que eligió no está disponible");
                TxtFechaSalida.Text = "";
                McRegreso.Enabled = true;

            }

        }

        private void McRegreso_DateChanged(object sender, DateRangeEventArgs e)
        {
            TxtFechaRegreso.Text = Convert.ToString(McRegreso.SelectionStart.Date);

            //'Restricciones'
            if (McRegreso.SelectionStart < McSalida.SelectionStart)

            {
                MessageBox.Show ("La fecha de regreso no puede ser antes de la fecha de salida");
                TxtFechaRegreso.Text = "";
            }
            RbDirecto.Enabled = true;

            RbEscala.Enabled = true;
            LvVuelos.Enabled = true;
        }

        private void RbCredito_CheckedChanged(object sender, EventArgs e)
        {
            BtnCalcular.Enabled = true;
            
        }

        private void RbEfectivo_CheckedChanged(object sender, EventArgs e)
        {
            BtnCalcular.Enabled = true;
        }

        private void NdMaletas_ValueChanged(object sender, EventArgs e)
        {
            CmbPeso.Enabled = true;
            cambio_dolar = (decimal)23.67;
        if (NdMaletas.Value > 0 )
                for (int i = 0; i < NdMaletas.Value; i++)
                {
                    precio_maleta = 50 * i;
                }
            else
            {
                precio_maleta = 0;      
            } 
                
        }

        private void CmbPeso_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CmbPeso.Text == "30 Libras")
            {
                precio_maleta += precio_maleta;
                cambio_dolar = (decimal)23.67;
            }

            if (CmbPeso.Text =="50 Libras")
            {
                precio_maleta += precio_maleta;
                    } 
   

        if( CmbPeso.Text =="80 Libras") 

           {
                precio_maleta += precio_maleta * 2;
    }
        }

        private void RbDirecto_CheckedChanged(object sender, EventArgs e)
        {
            CmbAbordaje.Enabled = true;
            CmbDestino.Enabled = true;
        }

        private void RbEscala_CheckedChanged(object sender, EventArgs e)
        {
            CmbAbordaje.Enabled = true;
            CmbDestino.Enabled = true;
        }

        private void CmbAbordaje_SelectedIndexChanged(object sender, EventArgs e)
        {
            //'Indicación de escalas'
            if (CmbAbordaje.Text == "Tegucigalpa (TGU)" & CmbDestino.Text == "Nueva York (NY)")
            {
                TxtEscala.Text = "Atlanta (GA)";
            }

            if (CmbAbordaje.Text == "Nueva York (NY)" & CmbDestino.Text == "Tegucigalpa (TGU)")
            {
                TxtEscala.Text = "Atlanta (GA)";

            }

            //'Restricciones mismos lugares de abordaje y destino'
            if (CmbAbordaje.Text == "Tegucigalpa (TGU)" & CmbDestino.Text == "Tegucigalpa (TGU)")

            {
                MessageBox.Show("El lugar de abordaje no puede ser el mismo que el lugar de destino");
                TxtEscala.Text = "";
                TxtBoleto.Text = "0" + " U$";
                TxtBoleto2.Text = "0" + " Lps";
           }

            if (CmbAbordaje.Text == "San Pedro Sula (SPS)" & CmbDestino.Text =="San Pedro Sula (SPS)" )
          {
                MessageBox .Show ("El lugar de abordaje no puede ser el mismo que el lugar de destino");
                TxtEscala.Text = "";
                TxtBoleto.Text = "0" + " U$";
                TxtBoleto2.Text = "0" + " Lps";
                    }

            if (CmbAbordaje.Text == "Miami Florida (MIA)" & CmbDestino.Text == "Miami Florida (MIA)" )
            
            {
                MessageBox.Show("El lugar de abordaje no puede ser el mismo que el lugar de destino");
            TxtEscala.Text = "";
                TxtBoleto.Text = "0" + " U$";
                TxtBoleto2.Text = "0" + " Lps";
                    }

            if (CmbAbordaje.Text == "Nueva York (NY)" & CmbDestino.Text == "Nueva York (NY)") 
           { MessageBox.Show("El lugar de abordaje no puede ser el mismo que el lugar de destino");
                TxtEscala.Text = "";
                TxtBoleto.Text = "0" + " U$";
                TxtBoleto2.Text = "0" + " Lps";
                    }

            if (CmbAbordaje.Text == "Houston Texas (TX)" & CmbDestino.Text == "Houston Texas (TX)")
            { MessageBox .Show ("El lugar de abordaje no puede ser el mismo que el lugar de destino");
                TxtEscala.Text = "";
                TxtBoleto.Text = "0" + " U$";
                TxtBoleto2.Text = "0" + " Lps";
                    }









        }

        private void CmbDestino_SelectedIndexChanged(object sender, EventArgs e)
        {
            CmbColumna.Enabled = true;
            CmbFila.Enabled = true;
        }

        private void CmbFila_SelectedIndexChanged(object sender, EventArgs e)
        {
            NdMaletas.Enabled = true;
            CmbPeso.Enabled = true;
            RbCredito.Enabled = true;
        RbEfectivo.Enabled = true;
        }

        public Form1()
        {
            InitializeComponent();
        }
       

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            
            TxtNombre.Text = "";
            RbSi.Checked = false ;
            TxtEdad.Text = "";
            McSalida.SelectionEnd = McSalida.TodayDate;
            McRegreso.SelectionEnd = McRegreso.TodayDate;
            McSalida.SelectionStart = McRegreso.TodayDate;
        McRegreso.SelectionStart = McRegreso.SelectionEnd;
        TxtFechaSalida.Text = "";
            TxtFechaRegreso.Text = "";
            RbDirecto.Checked = false ;
            RbEscala.Checked = false ;
            RbDirecto.Enabled = false ;
            RbEscala.Enabled = false ;
            LvVuelos.Enabled = false ;
            LvVuelos.HideSelection = true ;
            CmbAbordaje.Enabled = false ;
            CmbDestino.Enabled = false ;
            TxtEdad.Enabled = false ;
            CmbColumna.Text = "";
            CmbFila.Text = "";
            CmbColumna.Enabled = false ;
            CmbFila.Enabled = false ;
            NdMaletas.Enabled = false ;
            CmbPeso.Enabled = false ;
            RbCredito.Checked = false ;
            RbCredito.Enabled = false ;
            RbEfectivo.Checked = false ;
            RbEfectivo.Enabled = false ;
            BtnCalcular.Enabled = false ;


            CmbAbordaje.Text = "Seleccionar";
            TxtEscala.Text = "";
            CmbDestino.Text = "Seleccionar";
            TxtAsiento.Text = "";
            NdMaletas.Value = 0;
            CmbPeso.Text = "Seleccionar";
            TxtBoleto.Text = "0 U$";
            TxtBoleto2.Text = "0 Lps";
            TxtMaletas.Text = "0 U$";
            TxtMaletas2.Text = "0 Lps";
            TxtImpuesto.Text = "0 U$";
            TxtImpuesto2.Text = "0 Lps";
            TxtSubTotal.Text = "0 U$";
            TxtSubTotal2.Text = "0 Lps";
            TxtDescuento.Text = "0 U$";
            TxtDescuento2.Text = "0 Lps";
            TxtTotal.Text = "0 U$";
            TxtTotal2.Text = "0 Lps";
            
            TxtNombre.Enabled = true ;
            RbSi.Enabled = true ;

        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            Registro miRegistro = new Registro();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            TxtBoleto.Text = precio_boleto + " U$";
            TxtBoleto2.Text = precio_boleto2 + " Lps";
            TxtMaletas.Text = precio_maleta + " U$";

            if (CmbAbordaje.Text == "Miami Florida (MIA)" & CmbAbordaje.Text == "Nueva York (NY)" & CmbAbordaje.Text == "Houston Texas (TX)")
            {
                precio_maleta2 = 0;

            }
            TxtMaletas2.Text = precio_maleta2 + " Lps";

            //'Cálculos en dolares'
      
            impuesto = precio_boleto * (decimal).15;
            TxtImpuesto.Text = impuesto + " U$";

            //'Conversion de dolar a lempira'
            
            impuesto2 = precio_boleto2 * (decimal)0.15;
            TxtImpuesto2.Text = impuesto2 + " Lps";
           
            subtotal = precio_boleto + precio_maleta + impuesto;
            TxtSubTotal.Text = subtotal + " U$";
            subtotal2 = subtotal * cambio_dolar;
            
            //'Descuento'
            if (Convert.ToInt32(TxtEdad.Text) < 21)

            {
                 descuento = subtotal * (decimal).05;

                descuento2 = descuento * cambio_dolar;
            }

            if (Convert.ToInt32(TxtEdad.Text) > 60)
            {
               
            descuento = subtotal * (decimal).1;

                descuento2 = descuento * cambio_dolar;
            }

            if (CmbAbordaje.Text == "Miami Florida (MIA)" & CmbAbordaje.Text == "Nueva York (NY)" & CmbAbordaje.Text == "Houston Texas (TX)")
            {
                descuento2 = 0;
             }

            TxtDescuento.Text = descuento + " U$";
            TxtDescuento2.Text = descuento2 + " Lps";

            //'Total'
           total = subtotal - descuento;
            total2 = subtotal2 - descuento2;

            if (CmbAbordaje.Text == "Miami Florida (MIA)" & CmbAbordaje.Text == "Nueva York (NY)" & CmbAbordaje.Text == "Houston Texas (TX)")
            {
                total2 = 0;
              }


        }
       

        private void Form1_Load(object sender, EventArgs e)
        {
           

            //x1 = 0;
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


            TxtBoleto.Text = "0" + " U$";
            TxtBoleto2.Text = "0" + " Lps";
            TxtMaletas.Text = "0" + " U$";
            TxtMaletas2.Text = "0" + " Lps";
            TxtImpuesto.Text = "0" + " U$";
            TxtImpuesto2.Text = "0" + " Lps";
            TxtSubTotal.Text = "0" + " U$";
            TxtSubTotal2.Text = "0" + " Lps";
            TxtDescuento.Text = "0" + " U$";
            TxtDescuento2.Text = "0" + " Lps";
            TxtTotal.Text = "0" + " U$";
            TxtTotal2.Text = "0" + " Lps";

            
        }
    }
}
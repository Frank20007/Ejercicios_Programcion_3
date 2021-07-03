using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Numeros
{
    public partial class frmNumeros : Form
    {
        public frmNumeros()
        {
            InitializeComponent();
        }

        private void btnEjecutar_Click(object sender, EventArgs e)
        {
            int a;
            int b;

            a = Convert.ToInt32(txtFilas.Text);
            b = Convert.ToInt32(txtColumnas.Text);
            
            int[,] matriz = new int[a, b];
            Random aleatorio = new Random();

            for (int i = 0; i < a; i++)
            {
                for (int J = 0; J < b; J++)
                {
                    matriz[i, J] = aleatorio.Next(0, 100);
                }
            }

            // Impresion de la matriz
            for (int i = 0; i < a; i++)
            {
                
            
                for (int j = 0; j < b; j++)
                {

                    MessageBox.Show (i + "," + j + "=" + matriz [i,j])  ;
                   
                }


            }

           


        }
    }
}

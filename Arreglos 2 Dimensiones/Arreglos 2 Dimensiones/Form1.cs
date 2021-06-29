using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arreglos_2_Dimensiones
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEjecutar_Click(object sender, EventArgs e)
        {
            //Declarar la matriz
            int[,] MatrizDeEjemplo = new int[2, 3] { {5,50,30 }, {40,20,41} };


            //MatrizDeEjemplo[0, 0] = 45;
            //MatrizDeEjemplo[0, 1] = 30;


            int[,] MatrizDeEjemplo2 = new int[3, 3];

            //Llenar la Matriz
            for (int filas = 0; filas < MatrizDeEjemplo2.GetLength(0); filas++)
            {
                for (int colum = 0; colum < MatrizDeEjemplo2.GetLength(1); colum++)
                {
                    MatrizDeEjemplo2[filas, colum] = 3 + (filas+3) * (colum +2); 
                }
            }

            //Mostrar la Matriz
            for (int filas = 0; filas < MatrizDeEjemplo2.GetLength(0); filas++)
            {
                for (int colum = 0; colum < MatrizDeEjemplo2.GetLength(1); colum++)
                {
                    MessageBox.Show("La posicion es : " + filas + "," + colum + " =" + MatrizDeEjemplo2[filas ,colum].ToString()); 
                }
            }

        }
    }
}

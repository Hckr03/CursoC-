using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CursoCsharp.OperadoresRelacionales
{
    public partial class frmOpRelacionales : Form
    {
        public frmOpRelacionales()
        {
            InitializeComponent();
        }
        int numero1;
        int numero2;
        bool resultado;

        private void btnmayor_Click(object sender, EventArgs e)
        {
            Mayorque();
        }
        private void Mayorque()
        {
            asignacion();
            if (numero1 > numero2)
            {
                resultado = true;
            }
            else
            {
                resultado = false;
            }
            lblresultado.Text = resultado.ToString();
        }
        private void asignacion()
        {
            numero1 = Convert.ToInt32(txtnumero1.Text);
            numero2 = Convert.ToInt32(txtnumero2.Text);
        }

        private void btnmenor_Click(object sender, EventArgs e)
        {
            Menorque()
;        }

        private void Menorque()
        {
            asignacion();
            if (numero1 < numero2)
            {
                resultado = true;
            }
            else
            {
                resultado = false;
            }
            lblresultado.Text = resultado.ToString();
        }

        private void btnmenorigual_Click(object sender, EventArgs e)
        {
            Menorigual();
        }
        private void Menorigual()
        {
            asignacion();
            if (numero1 <= numero2)
            {
                resultado = true;
            }
            else
            {
                resultado = false;
            }
            lblresultado.Text = resultado.ToString();
        }

        private void btnmayorigual_Click(object sender, EventArgs e)
        {
            Mayorigual();
        }

        private void Mayorigual()
        {
            asignacion();
            if (numero1 >= numero2)
            {
                resultado = true;
            }
            else
            {
                resultado = false;
            }
            lblresultado.Text = resultado.ToString();
        }

        private void btnigual_Click(object sender, EventArgs e)
        {
            Igual();    
        }
        private void Igual()
        {
            asignacion();
            if (numero1 == numero2)
            {
                resultado = true;
            }
            else
            {
                resultado = false;
            }
            lblresultado.Text = resultado.ToString();
        }

        private void btndistinto_Click(object sender, EventArgs e)
        {
            Distinto();
        }
        private void Distinto()
        {
            asignacion();
            if (numero1 != numero2)
            {
                resultado = true;
            }
            else
            {
                resultado = false;
            }
            lblresultado.Text = resultado.ToString();
        }
    }
}

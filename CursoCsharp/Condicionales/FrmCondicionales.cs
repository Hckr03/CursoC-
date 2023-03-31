using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CursoCsharp.Condicionales
{
    public partial class FrmCondicionales : Form
    {
        public FrmCondicionales()
        {
            InitializeComponent();
        }
        int numero;
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            asignarDatos();
            calcular();
        }
        private void calcular()
        {
            if(numero > 0)
            {
                lblResultado.Text = "Es un numero positivo";
            }
            else if(numero == 0)
            {
                lblResultado.Text = "Es un valor 0";
            }
            else
            {
                lblResultado.Text = "Es un numero negativo";
            }
        }
        private void asignarDatos() 
        { 
            numero = Convert.ToInt32(txtNumero.Text);
        }
    }
}

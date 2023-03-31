using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CursoCsharp.Ejercicios
{
    public partial class Ejercicio4 : UserControl
    {
        public Ejercicio4()
        {
            InitializeComponent();
        }
        public string titulo;

        private void Ejercicio4_Load(object sender, EventArgs e)
        {
            lblejercicio.Text = titulo;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            agregar();
        }
        private void agregar()
        {
            double total = 0;
            string detalle = "";
            if(rbTallaL.Checked)
            {
                total += 200;
                detalle += "Casaca Talla L $200 \r\n";
            }
            if (rbTallaM.Checked)
            {
                total += 100;
                detalle += "Casaca Talla M $100 \r\n";
            }
            if (rbTallaS.Checked)
            {
                total += 50;
                detalle += "Casaca Talla S $50 \r\n";
            }
            if (rbBlanco.Checked)
            {
                total += 10;
                detalle += "Color blanco\r\n";
            }
            if (rbRojo.Checked)
            {
                total += 20;
                detalle += "Color rojo\r\n";
            }
            detalle += "El total a pagar es de: $"+total+"\r\n";
            txtDetalle.Text = detalle;
        }

        private void txtDetalle_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}

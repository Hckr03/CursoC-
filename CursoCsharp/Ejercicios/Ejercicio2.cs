using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CursoCsharp.Ejercicios
{
    public partial class Ejercicio2 : UserControl
    {
        public Ejercicio2()
        {
            InitializeComponent();
        }
        double radio;
        double area;
        double longitud;
        double pi = Math.PI;
        public string titulo;

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            AsignarValores();
            ObtenerRadio();
            ObetenerLongitud();
        }
        private void AsignarValores()
        {
            area = Convert.ToDouble(txtarea.Text);
        }
        private void ObtenerRadio()
        {
            radio = Math.Sqrt(area / pi);
            lblRadioResultado.Text = radio.ToString(("N2"));
        }
        private void ObetenerLongitud()
        {
            longitud = 2 * pi * radio;
            lblResultadoLongitud.Text = longitud.ToString(("N2"));
        }
    }
}

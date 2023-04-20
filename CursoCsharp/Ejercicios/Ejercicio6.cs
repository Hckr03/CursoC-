using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CursoCsharp.Ejercicios
{
    public partial class Ejercicio6 : UserControl
    {
        public Ejercicio6()
        {
            InitializeComponent();
        }
        public string titulo;
        string operacion;
        double num1;
        double num2;
        double resultado;
        bool reiniciar = false;
        bool punto = true;
        private void Ejercicio6_Load(object sender, EventArgs e)
        {
            lblEjercicio6.Text = titulo;
            dibujarTecladoNumerico();
        }
        private void dibujarTecladoNumerico()
        {
            char[] numeros;
            numeros = "9874563210.".ToArray();
            panelNumerico.Controls.Clear();
            foreach (char numero in numeros)
            {
                Button btnNumero = new Button();
                btnNumero.Text = numero.ToString();
                btnNumero.Size = new Size(70, 70);
                btnNumero.FlatStyle = FlatStyle.Flat;
                btnNumero.ForeColor = Color.White;
                btnNumero.BackColor = Color.Transparent;
                btnNumero.BackgroundImage = Properties.Resources.btn3;
                btnNumero.BackgroundImageLayout = ImageLayout.Stretch;
                btnNumero.FlatAppearance.BorderSize = 0;
                btnNumero.FlatAppearance.MouseDownBackColor = Color.Transparent;
                btnNumero.FlatAppearance.MouseOverBackColor = Color.Transparent;
                panelNumerico.Controls.Add(btnNumero);
                btnNumero.Click += BtnNumero_Click;
            }
        }

        private void BtnNumero_Click(object sender, EventArgs e)
        {
            reiniciarProcesos();
            string numeroString = ((Button)sender).Text;
            if (numeroString == ".")
            {
                punto = true;
                if (txtPantalla.Text.Contains("."))
                {
                    punto = false;
                }
                if (punto == true)
                {
                    if (txtPantalla.Text != "")
                    {
                        txtPantalla.Text += ".";
                    }
                }
            }
            else
            {
                if (txtPantalla.Text == "0")
                {
                    txtPantalla.Clear();
                }
                txtPantalla.Text += numeroString;
            }
        }
        private void reiniciarProcesos()
        {
            if (reiniciar == true)
            {
                txtPantalla.Text = "0";
                reiniciar = false;
            }
        }
        private void btnDiv_Click(object sender, EventArgs e)
        {
            operacion = btnDiv.Text;
            definirOperacion();
        }
        private void definirOperacion()
        {
            asignarDatos();
            if (num2 > 0)
            {
                lblNum1.Text = txtPantalla.Text;
                lblOperacion.Text = operacion;
                txtPantalla.Text = "0";
                lblNum1.Visible = true;
                lblOperacion.Visible = true;
            }
        }
        private void asignarDatos()
        {
            num1 = Convert.ToDouble(lblNum1.Text);
            num2 = Convert.ToDouble(txtPantalla.Text);
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            calcular();
        }
        private void calcular()
        {
            asignarDatos();
            if (lblOperacion.Text == btnDiv.Text)
            {
                dividir();
            }
            if (lblOperacion.Text == btnMulti.Text)
            {
                mulitplicar();
            }
            if (lblOperacion.Text == btnRestar.Text)
            {
                restar();
            }
            if (lblOperacion.Text == btnSumar.Text)
            {
                sumar();
            }
            if (lblOperacion.Text == btnPorcentaje.Text)
            {
                porcentaje();
            }
        }
        private void limpiar()
        {
            reiniciar = true;
            lblOperacion.Text = "0";
            lblNum1.Text = "0";
            lblNum1.Visible = false;
            lblOperacion.Visible = false;
        }
        private void dividir()
        {
            resultado = num1 / num2;
            txtPantalla.Text = resultado.ToString(CultureInfo.InvariantCulture);
            limpiar();
        }
        private void mulitplicar()
        {
            resultado = num1 * num2;
            txtPantalla.Text = resultado.ToString(CultureInfo.InvariantCulture);
            limpiar();
        }
        private void restar()
        {
            resultado = num1 - num2;
            txtPantalla.Text = resultado.ToString(CultureInfo.InvariantCulture);
            limpiar();
        }
        private void sumar()
        {
            resultado = num1 + num2;
            txtPantalla.Text = resultado.ToString(CultureInfo.InvariantCulture);
            limpiar();
        }
        private void porcentaje()
        {
            resultado = num1 * num2 / 100;
            txtPantalla.Text = resultado.ToString(CultureInfo.InvariantCulture);
            limpiar();
        }
        private void btnMulti_Click(object sender, EventArgs e)
        {
            operacion = btnMulti.Text;
            definirOperacion();
        }
        private void btnRestar_Click(object sender, EventArgs e)
        {
            operacion = btnRestar.Text;
            definirOperacion();
        }
        private void btnSumar_Click(object sender, EventArgs e)
        {
            operacion = btnSumar.Text;
            definirOperacion();
        }
        private void btnAC_Click(object sender, EventArgs e)
        {
            limpiar();
            txtPantalla.Text = "0";
        }
        private void btnPorcentaje_Click(object sender, EventArgs e)
        {
            operacion = btnPorcentaje.Text;
            definirOperacion();
        }

        private void btnOff_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCopiar_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtPantalla.Text);
        }
    }
}

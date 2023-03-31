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
    public partial class Ejercicio3 : UserControl
    {
        public Ejercicio3()
        {
            InitializeComponent();
        }
        double peso;
        double altura;
        double imc;
        public string titulo;
        private void btncalcular_Click_1(object sender, EventArgs e)
        {
            Asignardatos();
            ObetenerIMC();
            Condicional();
        }
        private void Asignardatos()
        {
            peso = Convert.ToDouble(txtpeso.Text);
            altura = Convert.ToDouble(txtaltura.Text.Replace(".", ","));
        }
        private void ObetenerIMC()
        {
            imc = peso / (Math.Pow(altura, 2));
            lblimcresultado.Text = imc.ToString("N2");
        }
        private void Ejercicio3_Load(object sender, EventArgs e)
        {
            lblejercicio.Text = titulo;
        }
        private void Condicional()
        {
            if(imc < 18.5)
            {
                lblcondicionresultado.Text = "Esta por debajo!";
            }
            if(imc >= 18.5 && imc <= 24.9)
            {
                lblcondicionresultado.Text = "Esta saludable!";
            }
            if(imc >= 25 &&  imc <= 29.9)
            {
                lblcondicionresultado.Text = "Esta con sobrepeso!";
            }
            if(imc > 30)
            {
                lblcondicionresultado.Text = "Esta con obesidad!";
            }
        }
    }
}

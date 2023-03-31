using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CursoCsharp.Listas
{
    public partial class FrmListas_arrays : Form
    {
        public FrmListas_arrays()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            agregarArray();
        }
        private void agregarListas()
        {
            List<string> nombres = new List<string>();
            nombres.Add("Gabriel");
            nombres.Add("Pablo");
            nombres.Add("Joel");
            nombres.Add("Victoria");
            nombres.Add("Graciela");
            foreach (string data in nombres) 
            {
                listDatos.Items.Add(data);
            }
            //for(int i = 0; i < nombres.Count; i++)
            //{
            //    listDatos.Items.Add(nombres[i]);
            //}
        }
        private void agregarArray()
        {
            string[] nombres = new string[5]
            { 
                "Gabriel", "Pablo", "Joel", "Victoria", "Graciela" 
            };
            foreach (string data in nombres)
            {
                listDatos.Items.Add(data);
            }
        }

        private void FrmListas_arrays_Load(object sender, EventArgs e)
        {
            dibujarTecladoNumerico();
        }
        private void dibujarTecladoNumerico()
        {
            char[] numeros;
            numeros = "0123456789".ToCharArray();
            panelNumerico.Controls.Clear();
            foreach (char numero in numeros)
            {
                Button btnNumero = new Button();
                btnNumero.Text = numero.ToString();
                btnNumero.Size = new Size(90, 90);
                btnNumero.FlatStyle = FlatStyle.Flat;
                btnNumero.ForeColor = Color.FromArgb(192, 255, 255);
                btnNumero.FlatAppearance.BorderSize = 2;
                panelNumerico.Controls.Add(btnNumero);
                btnNumero.Click += BtnNumero_Click;
            }
        }

        private void BtnNumero_Click(object sender, EventArgs e)
        {
            string numero = ((Button)sender).Text;
            txtPantalla.Text += numero;
        }
    }
}

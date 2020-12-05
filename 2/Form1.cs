using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2
{
    public partial class Form1 : Form
    {
        Cola Cola = new Cola();
        public Form1()
        {
            InitializeComponent();
        }
        // funciones
        public string prioridad()
        {
            string prioridad;
            if (rbtn1.Checked == true) prioridad = rbtn1.Text;
            else if (rbtn2.Checked == true) prioridad = rbtn2.Text;
            else prioridad = rbtn3.Text;
            return prioridad;
        }

        public void MostrarCola()
        {

        }
        // form
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Length == 0 || (rbtn1.Checked == false && rbtn2.Checked == false && rbtn3.Checked == false))
            {
                MessageBox.Show("Debe ingresar un nombre válido");
            }
            else
            {
                Nodo nuevoNodo = new Nodo();
                nuevoNodo.Nombre = txtNombre.Text;
                nuevoNodo.Prioridad = prioridad();
                Cola.AddCola(nuevoNodo, Convert.ToInt32(nuevoNodo.Prioridad));
                if (nuevoNodo.Prioridad == "1")
                {
                    listboxInscriptos.Items.Add(Cola.BuscarUltimoPrioridad1(Cola.Inicio));
                }
                else if (nuevoNodo.Prioridad == "2")
                {
                    listboxInscriptos.Items.Add(Cola.BuscarUltimoPrioridad2(Cola.Inicio));
                }
                else
                {
                    listboxInscriptos.Items.Add(Cola.BuscarUltimoPrioridad3(Cola.Inicio));
                }

                MostrarCola();

            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace video4_winform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            string elem = txtnombre.Text;
            lvElements.Items.Add(elem);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbcolor.Items.Add("Verde");
            cbcolor.Items.Add("Rojo");
            cbcolor.Items.Add("Blanco");
        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            string nombre = txtnombre.Text;
            DateTime fecha = dtFechaDeNacimiento.Value;
            //operador ternario
            string chocolate = chbChocolate.Checked == true ? "Le gusta el chocolate..." : "Odia el chocolate...";
            string tipo;
            if (rb2muggle.Checked)
                tipo = "Muggle";
            else if (rbWizard.Checked)
                tipo = "Wizard";
            else
                tipo = "Squibs";

            string colorFavorito = cbcolor.SelectedItem.ToString();
            string numeroFavor = cajanumfav1.Value.ToString();

            string mensaje = chocolate + ", es " + tipo + ", su color favorito es " + colorFavorito + ", su numero favoritos es " + numeroFavor;
            MessageBox.Show("Nombre: " + nombre + "Fecha: " + fecha + ", " + mensaje);

        }
    }
}

using EstanciaForm.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstanciaForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /*
        https://docs.google.com/document/d/1-QOtrYj8ci4F8my6M1O7zVMEWF8oNPxk/preview
        */
        //Estancia estancia = new Estancia();

        Campos campitos;
        EstanciaDtosForm ventana;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            ventana = new EstanciaDtosForm();
            ventana.lbDescripcion.Text = "Código RDH950 \n con 350.90 hetareas";
            if (ventana.ShowDialog() == DialogResult.OK) {
                if (campitos.CrearParcela("RDH950", 350.90))
                {
                    MessageBox.Show($"{campitos.VerParcela(0)}");
                }
                else { MessageBox.Show("Puto"); }
            }
        }
    }
}

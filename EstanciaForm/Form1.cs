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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            ventana = new EstanciaDtosForm();
            if (ventana.ShowDialog() == DialogResult.OK) {
                campitos = new Campos("RDH950",350.90);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}

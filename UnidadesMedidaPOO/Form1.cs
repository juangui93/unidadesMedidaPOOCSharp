using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UnidadesMedidaPOO
{
    public partial class Form1 : Form
    {
        ConvertirUnidad convertirUnidad = new ConvertirUnidad(); 
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            convertirUnidad.setValor(double.Parse(txtValor.Text));
            convertirUnidad.setUnidad(cbxUnidad.Text);
            label4.Visible = true;
            lblRespuesta.Visible = true; 
            lblRespuesta.Text = Convert.ToString(convertirUnidad.convertirUnidad());
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtValor.Text = String.Empty;
            cbxUnidad.Text = String.Empty;
            label4.Visible = false;
            lblRespuesta.Text = "0";
            lblRespuesta.Visible = false;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

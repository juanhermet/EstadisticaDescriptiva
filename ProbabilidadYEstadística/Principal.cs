using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProbabilidadYEstadística
{
    public partial class Principal : Form
    {
        List<double> listaDeNumeros = new List<double>();
        public Principal()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if(txtNumero.Text != null)
            {
               
                listaDeNumeros.Add(Convert.ToDouble(txtNumero.Text));
                lstbxNumerosAgregados.Items.Add(txtNumero.Text);
                txtNumero.Text = "";
                txtNumero.Focus();
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //definimos media.
            lblMedia.Text = EstadisticaFactory.calcularPromedio(listaDeNumeros);
            //definimos Mediana.
            lblMediana.Text = EstadisticaFactory.calcularMediana(listaDeNumeros);
            //definimos Quartiles.
            lblPrimerQ.Text = EstadisticaFactory.calcularPrimerCuartil(listaDeNumeros);
            lblTercerQ.Text = EstadisticaFactory.calcularTercerCuartil(listaDeNumeros);
            //definimos Meda.
            lblMeda.Text = EstadisticaFactory.calcularMeda(listaDeNumeros);
            //definimos Varianzas.
            lblVarianza.Text = EstadisticaFactory.calcularVarianza(listaDeNumeros);
            lblDesvEst.Text = EstadisticaFactory.calcularDesviacionEstandar(listaDeNumeros);
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            limpiarValores();
        }
       
        private void txtNumero_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.Enter)
            {
                btnAgregar_Click(sender,e);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarValores();
            listaDeNumeros.Clear();
            lstbxNumerosAgregados.Items.Clear();
        }
        
        private void limpiarValores()
        {
            lblDesvEst.Text = "";
            lblMeda.Text = "";
            lblMedia.Text = "";
            lblMediana.Text = "";
            lblPrimerQ.Text = "";
            lblTercerQ.Text = "";
            lblVarianza.Text = "";
        }
        
    }
}

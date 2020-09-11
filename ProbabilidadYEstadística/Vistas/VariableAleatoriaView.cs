using ProbabilidadYEstadística.Fabricas;
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
    public partial class VariableAleatoriaView : Form
    {
        List<VariableAleatoriaBean> listaDeVariablesAleatorias = new List<VariableAleatoriaBean>();
        public VariableAleatoriaView()
        {
            InitializeComponent();
        }

        private void VariableAleatoriaView_Load(object sender, EventArgs e)
        {
            limpiar();
        }

       

        private void txtNumero_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                txtFuncion.Focus();
            }
        }

        private void txtFuncion_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                btnAgregar_Click(sender,e);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtNumero.Text != "" && txtFuncion.Text != "")
            {
                VariableAleatoriaBean variableAleatoria = new VariableAleatoriaBean(Convert.ToDouble(txtNumero.Text), Convert.ToDouble(txtFuncion.Text));
                listaDeVariablesAleatorias.Add(variableAleatoria);
                lstbxNumerosAgregados.Items.Add(txtNumero.Text + " - " + txtFuncion.Text);
                limpiarTextBoxs();
                txtNumero.Focus();
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if(EsVariableAleatoria.esVariableAleatoria(listaDeVariablesAleatorias))
            {
                //creo Esperanza.
                lblEsperanza.Text = VariableAleatoriaFactory.calcularEsperanza(listaDeVariablesAleatorias);
                //Creo Varianza.
                lblVarianza.Text = VariableAleatoriaFactory.calcularVarianza(listaDeVariablesAleatorias);
            }
            else
            {
                MessageBox.Show("la suma de los p(x) no es igual a 1, por lo tanto no se puede contar como una probabilidad", "Error conceptual");
                limpiar();
                lstbxNumerosAgregados.Items.Clear();
                txtNumero.Focus();
            }    
        }

        private void limpiarTextBoxs()
        {
            txtFuncion.Text = "";
            txtNumero.Text = "";
        }
        private void limpiar()
        {
            lblEsperanza.Text = "";
            lblVarianza.Text = "";
        }

        private void VariableAleatoriaView_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}

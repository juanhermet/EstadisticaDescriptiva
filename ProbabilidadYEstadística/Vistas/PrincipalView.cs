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
    public partial class PrincipalView : Form
    {
        public PrincipalView()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EstadisticaDescriptivaView estadisticaDescriptivaView = new EstadisticaDescriptivaView();
            Hide();
            estadisticaDescriptivaView.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            VariableAleatoriaView variableAleatoria = new VariableAleatoriaView();
            Hide();
            variableAleatoria.ShowDialog();

        }
    }
}

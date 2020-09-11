using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProbabilidadYEstadística.Fabricas
{
    static class VariableAleatoriaFactory
    {
        public static string calcularEsperanza(List<VariableAleatoriaBean> listaDeVariables)
        {
            Esperanza esperanza = new Esperanza(listaDeVariables);
            return esperanza.darEsperanza().ToString();
        }
        public static string calcularVarianza(List<VariableAleatoriaBean> listaDeVariables)
        {
            VarianzaAleatoria varianza = new VarianzaAleatoria(listaDeVariables);
            return varianza.darVarianzaAleatoria().ToString();
        }
    }
}

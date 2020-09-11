using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProbabilidadYEstadística
{
    public class VariablesAleatorias 
    {
        protected List<VariableAleatoriaBean> listaVariablesAleatorias = new List<VariableAleatoriaBean>();

        public VariablesAleatorias(List<VariableAleatoriaBean> listaVariablesAleatorias)
        {
            this.listaVariablesAleatorias = listaVariablesAleatorias;
        }
    }
    public class Esperanza : VariablesAleatorias
    {
        public Esperanza(List<VariableAleatoriaBean> listaVariablesAleatorias) : base(listaVariablesAleatorias)
        {
        }

        public double darEsperanza()
        {
            return listaVariablesAleatorias.Sum(variable => variable.Valor * variable.FuncionMasa);
        }
    }
    public class VarianzaAleatoria : Esperanza
    {
        double esperanza;
        public VarianzaAleatoria(List<VariableAleatoriaBean> listaVariablesAleatorias) : base(listaVariablesAleatorias)
        {
            esperanza = darEsperanza();
        }

        public double darVarianzaAleatoria()
        {
            double varianza = 0;
            for (int indice = 0; indice < listaVariablesAleatorias.Count; indice++) 
            {
                varianza += calcularDiferenciaEsperanza(listaVariablesAleatorias[indice].Valor)
                    * listaVariablesAleatorias[indice].FuncionMasa;
            }

            return varianza;
        }
        
        private double calcularDiferenciaEsperanza(double valor)
        {
            return Math.Round(Math.Pow(valor - esperanza, 2),2);
        }
       
    }
    public class VariableAleatoriaBean
    {
        double valor;
        double funcionMasa;

        public VariableAleatoriaBean(double valor, double funcionMasa)
        {
            this.valor = valor;
            this.funcionMasa = funcionMasa;
        }

        public double Valor { get => valor; set => valor = value; }
        public double FuncionMasa { get => funcionMasa; set => funcionMasa = value; }
        
    }
    public static class EsVariableAleatoria
    {
        public static bool esVariableAleatoria(List<VariableAleatoriaBean> listaVariablesAleatorias)
        {
            double universo = listaVariablesAleatorias.Sum(px => px.FuncionMasa);

            return universo == 1.00d;
        }
    }
}

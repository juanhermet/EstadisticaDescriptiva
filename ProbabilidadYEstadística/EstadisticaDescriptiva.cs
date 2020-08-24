using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProbabilidadYEstadística
{
    public abstract class EstadisticaDescriptiva
    {
        protected List<double> listaDeNumeros = new List<double>();
        public EstadisticaDescriptiva(List<double> listaDeNumeros)
        {
            this.listaDeNumeros = listaDeNumeros;
        }
    }

    public class Promedio : EstadisticaDescriptiva
    {
        public Promedio(List<double> listaDeNumeros) : base(listaDeNumeros) { }
        
        public double darPromedio()
        {
            return listaDeNumeros.Sum() / listaDeNumeros.Count;
        }
    }
    public class Varianza : Promedio
    {
        public Varianza(List<double> listaDeNumeros) : base(listaDeNumeros) { }
        public double darVarianza()
        {
            double varianza = 0;
            for (int numero = 0; numero < listaDeNumeros.Count; numero++)
            {
                varianza += determinarVarianza(listaDeNumeros[numero]);
            }
            return varianza / listaDeNumeros.Count;
        }
        private double determinarVarianza(double numero)
        {
            return Math.Pow(numero - darPromedio(), 2);
        }
        public double darDesviacionEstandar()
        {
            return Math.Pow(darVarianza(), 0.5);
        }
    }
    public class Mediana : EstadisticaDescriptiva
    {
        public Mediana(List<double> listaDeNumeros) : base(listaDeNumeros) { }

        public double darMediana()
        {
            double mediana;
            
            listaDeNumeros.Sort();

            mediana = determinarMediana(Paridad.esPar(listaDeNumeros.Count),listaDeNumeros);

            return mediana;
        }
        protected double determinarMediana(bool esPar,List<double> listaDeNumerosOrdenados)
        {   
            return (esPar) ? cantidadPar(listaDeNumerosOrdenados) :
                cantidadImpar(listaDeNumerosOrdenados);
        }
        protected double cantidadPar(List<double> listaDeValoresOrdenados)
        {
            double mediana;

            mediana = (listaDeValoresOrdenados[posicionMediana()] + listaDeValoresOrdenados[posicionMediana() + 1])/2;
      
            return mediana;
        }
       
        protected double cantidadImpar(List<double> listaDeValoresOrdenados)
        {
            double mediana;
            mediana = listaDeValoresOrdenados[posicionMediana()];
            return mediana;
        }
        protected int posicionMediana()
        {
            return ((listaDeNumeros.Count + 1) / 2)-1;
        }
    }

    public class Quartiles : Mediana
    {
        public Quartiles(List<double> listaDeNumeros) : base(listaDeNumeros) { }

        public double darPrimerQuartil()
        {
            int posicionQuartil;

            posicionQuartil = (posicionMediana() + 1)/2;
            
            return listaDeNumeros[posicionQuartil];
        }
        
        public double darTercerQuartil()
        {
            int posicionQuartil;

            posicionQuartil = listaDeNumeros.Count - ((posicionMediana() ) / 2)-1;
            
            return listaDeNumeros[posicionQuartil];
        }
    }
    public class Meda : Mediana
    {
        public Meda(List<double> listaDeNumeros) : base(listaDeNumeros) { }

        public double darMeda()
        {
            double meda;
            List<double> listaDeValoresAbsolutos = new List<double>();
            listaDeNumeros.Sort();
            for (int numero = 0; numero < listaDeNumeros.Count; numero++)
            {
                listaDeValoresAbsolutos.Add(valorAbsolutoEntreValorYMediana(listaDeNumeros[numero]));
            }

            listaDeValoresAbsolutos.Sort();

            meda = determinarMediana(Paridad.esPar(listaDeValoresAbsolutos.Count),listaDeValoresAbsolutos);

            return meda;
        }
       
        private double valorAbsolutoEntreValorYMediana(double numero)
        {
        return Math.Abs(numero - darMediana());
        }
    }
    public class Paridad
    {
        public static bool esPar(int numero)
        {
            return numero % 2 == 0;
        }
    }
}

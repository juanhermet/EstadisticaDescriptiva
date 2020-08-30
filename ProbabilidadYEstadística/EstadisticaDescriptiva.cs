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
            double varianza = sumarValoresDeVarianza();
            
            return varianza / listaDeNumeros.Count;
        }
        private double sumarValoresDeVarianza()
        {
            double varianza = 0;
            for (int numero = 0; numero < listaDeNumeros.Count; numero++)
            {
                varianza += determinarVarianza(listaDeNumeros[numero]);
            }
            return varianza;
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
            listaDeNumeros.Sort();

            return determinarMediana(Paridad.esPar(listaDeNumeros.Count)
                ,listaDeNumeros);
        }
        protected double determinarMediana(bool esPar,List<double> listaDeNumerosOrdenados)
        {   
            return (esPar) ? cantidadPar(listaDeNumerosOrdenados) :
                cantidadImpar(listaDeNumerosOrdenados);
        }
        protected double cantidadPar(List<double> listaDeValoresOrdenados)
        {
            return (listaDeValoresOrdenados[posicionMediana()] 
                + listaDeValoresOrdenados[posicionMediana() + 1])/2;      
        }
       
        protected double cantidadImpar(List<double> listaDeValoresOrdenados)
        {
            return listaDeValoresOrdenados[posicionMediana()];
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
            return listaDeNumeros[((posicionMediana() + 1) / 2) - 1];   
        }
        
        public double darTercerQuartil()
        {
            listaDeNumeros.Sort();
            return listaDeNumeros
                [listaDeNumeros.Count - ((posicionMediana()) / 2) - 1];
        }
        public double darRangoIntercuartil()
        {
            return darTercerQuartil() - darPrimerQuartil();
        }
    }
    public class CoeficienteDeAsimetria : EstadisticaDescriptiva
    {
        public CoeficienteDeAsimetria(List<double> listaDeNumeros) : base(listaDeNumeros){}
        public double darCoeficienteDeAsimetria()
        {
            Varianza varianza = new Varianza(listaDeNumeros);
            Mediana mediana = new Mediana(listaDeNumeros);

            return Math.Abs((mediana.darMediana() - varianza.darPromedio())
                /varianza.darDesviacionEstandar())*100;
        }
        
    }
    public class ValoresAlejados : Quartiles
    {
        public ValoresAlejados(List<double> listaDeNumeros) : base(listaDeNumeros) { }

        public double darValorAlejadoPorDefecto()
        {  
            return determinarValorAlejadoPorDefecto(determinarExtremos(false));
        }
        private double determinarValorAlejadoPorDefecto(double valorAlejado)
        {
            double valorAlejadoPorDefecto = -9999;
            for (int numeroDelConjunto = 0; numeroDelConjunto < listaDeNumeros.Count; numeroDelConjunto++)
            {
                if (listaDeNumeros[numeroDelConjunto] < valorAlejado)
                {
                    valorAlejadoPorDefecto = listaDeNumeros[numeroDelConjunto];
                }
            }
            return valorAlejadoPorDefecto;
        }

        public double darValorAlejadoPorExceso()
        {
            return determinarValorAlejadoPorExceso(determinarExtremos(true));
        }
        private double determinarValorAlejadoPorExceso(double valorAlejado)
        {
            double valorAlejadoPorExceso = 9999;

            for (int valorDelConjunto = 0; valorDelConjunto < listaDeNumeros.Count; valorDelConjunto++)
            {
                if(listaDeNumeros[valorDelConjunto] > valorAlejado)
                {
                    valorAlejadoPorExceso = listaDeNumeros[valorDelConjunto];
                }
            }
            return valorAlejadoPorExceso;
        }
        
        private double determinarExtremos(bool mayor)
        {
            if (mayor)
            {
                return darTercerQuartil() + 1.5 * darRangoIntercuartil();
            }
            else
            {
                return darPrimerQuartil() - 1.5 * darRangoIntercuartil();
            }
        }
    }
    public class Meda : Mediana
    {
        public Meda(List<double> listaDeNumeros) : base(listaDeNumeros) { }

        public double darMeda()
        {
            List<double> listaDeValoresAbsolutos = new List<double>();

            listaDeNumeros.Sort();
            
            for (int numero = 0; numero < listaDeNumeros.Count; numero++)
            {
                listaDeValoresAbsolutos.Add(valorAbsolutoEntreValorYMediana(listaDeNumeros[numero]));
            }

            listaDeValoresAbsolutos.Sort();

            return determinarMediana(Paridad.esPar(listaDeValoresAbsolutos.Count), listaDeValoresAbsolutos);
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

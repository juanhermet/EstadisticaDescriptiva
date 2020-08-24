using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProbabilidadYEstadística
{
    class EstadisticaFactory
    {
        public static string calcularPromedio(List<double> listaDeNumeros)
        {
            Promedio promedio = new Promedio(listaDeNumeros);
            return promedio.darPromedio().ToString();
        }
        public static string calcularMediana(List<double> listaDeNumeros)
        {
            Mediana mediana = new Mediana(listaDeNumeros);
            return mediana.darMediana().ToString();
        }
        public static string calcularPrimerCuartil(List<double> listaDeNumeros)
        {
            Quartiles quartiles = new Quartiles(listaDeNumeros);
            return quartiles.darPrimerQuartil().ToString();
        }
        public static string calcularTercerCuartil(List<double> listaDeNumeros)
        {
            Quartiles quartiles = new Quartiles(listaDeNumeros);
            return quartiles.darTercerQuartil().ToString();
        }
        public static string calcularMeda(List<double> listaDeNumeros)
        {
            Meda meda = new Meda(listaDeNumeros);
            return meda.darMeda().ToString();
        }
        public static string calcularVarianza(List<double> listaDeNumeros)
        {
            Varianza varianza = new Varianza(listaDeNumeros);
            return varianza.darVarianza().ToString();
        }
        public static string calcularDesviacionEstandar(List<double> listaDeNumeros)
        {
            Varianza varianza = new Varianza(listaDeNumeros);
            return varianza.darDesviacionEstandar().ToString();
        }
    }
}

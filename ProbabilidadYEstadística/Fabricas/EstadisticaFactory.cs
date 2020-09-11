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
            return Math.Round(promedio.darPromedio(),2).ToString();
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
            return Math.Round(varianza.darVarianza(),2).ToString();
        }
        public static string calcularDesviacionEstandar(List<double> listaDeNumeros)
        {
            Varianza varianza = new Varianza(listaDeNumeros);
            return Math.Round(varianza.darDesviacionEstandar(),2).ToString();
        }
        public static string calcularRangoIntercuartil(List<double> listaDeNumeros)
        {
            Quartiles quartiles = new Quartiles(listaDeNumeros);
            return quartiles.darRangoIntercuartil().ToString();
        }
        public static string calcularValorAlejadoPorDefecto(List<double> listaDeNumeros)
        {
            ValoresAlejados valoresAlejados = new ValoresAlejados(listaDeNumeros);
            if(valoresAlejados.darValorAlejadoPorDefecto() == -9999)
            {
                return "no tiene";
            }
            else
            {
                return valoresAlejados.darValorAlejadoPorDefecto().ToString();
            }
        }
        public static string calcularValorAlejadoPorExceso(List<double> listaDeNumeros)
        {
            ValoresAlejados valores = new ValoresAlejados(listaDeNumeros);
            if(valores.darValorAlejadoPorExceso() == 9999)
            {
                return "no tiene";
            }
            else
            {
                return valores.darValorAlejadoPorExceso().ToString();
            }
        }
        public static string calcularCoeficienteDeAsimetria(List<double> listaDeNumeros)
        {
            CoeficienteDeAsimetria coeficienteDeAsimetria = new CoeficienteDeAsimetria(listaDeNumeros);
            return Math.Round(coeficienteDeAsimetria.darCoeficienteDeAsimetria(),0).ToString() + "%";
        }
    }
}

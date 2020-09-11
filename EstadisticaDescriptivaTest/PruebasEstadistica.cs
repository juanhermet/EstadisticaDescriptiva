using NUnit.Framework;
using ProbabilidadYEstadística;
using System;
using System.Collections.Generic;

namespace EstadisticaDescriptivaTest
{
    [TestFixture]
    public class PruebasEstadistica
    {
        [Test]
        public void probarPromedio()
        {
            //arrange
            List<double> listaPrueba = new List<double>();
            Promedio estadistica;
            listaPrueba.Add(4.5);
            listaPrueba.Add(4.3);
            listaPrueba.Add(4.2);
            listaPrueba.Add(4.7);
            listaPrueba.Add(4.9);
            //act
            estadistica = new Promedio(listaPrueba);
            double resultado = estadistica.darPromedio();
            //assert
            Assert.LessOrEqual(4.52,resultado);
        }
        [Test]
        public void probarMediana()
        {
            //arrange
            List<double> listaPrueba = new List<double>();
            listaPrueba.Add(8);
            listaPrueba.Add(4);
            listaPrueba.Add(2);
            listaPrueba.Add(7);
            listaPrueba.Add(10);
            listaPrueba.Add(6);
            listaPrueba.Add(11);
            Mediana mediana = new Mediana(listaPrueba);
            //Act
            double resultado = mediana.darMediana();
            //assert
            Assert.AreEqual(7, resultado);
        }

        [Test]
        public void probarPrimerQuartil()
        {
            //arrange
            List<double> listaPrueba = new List<double>();
            Quartiles quartil;
            listaPrueba.Add(8);
            listaPrueba.Add(4);
            listaPrueba.Add(2);
            listaPrueba.Add(7);
            listaPrueba.Add(10);
            listaPrueba.Add(6);
            listaPrueba.Add(11);
            quartil = new Quartiles(listaPrueba);
            //Act
            double resultado = quartil.darPrimerQuartil();
            //Assert
            Assert.AreEqual(4, resultado);
        }
        [Test]
        public void probarTercerQuartil()
        {
            List<double> listaPrueba = new List<double>();
            Quartiles quartil;
            listaPrueba.Add(8);
            listaPrueba.Add(4);
            listaPrueba.Add(2);
            listaPrueba.Add(7);
            listaPrueba.Add(10);
            listaPrueba.Add(6);
            listaPrueba.Add(11);
            quartil = new Quartiles(listaPrueba);
            //Act
            double resultado = quartil.darTercerQuartil();
            //Assert
            Assert.AreEqual(10, resultado);
        }
        [Test]
        public void probarVarianza()
        {
            //Arrange
            List<double> listaPrueba = new List<double>();
            Varianza varianza;
            listaPrueba.Add(8);
            listaPrueba.Add(4);
            listaPrueba.Add(2);
            listaPrueba.Add(6);
            listaPrueba.Add(10);
            listaPrueba.Add(6);
            varianza = new Varianza(listaPrueba);
            //Act
            double resultado = varianza.darVarianza();
            //Assert
            Assert.LessOrEqual(6.66,resultado);
        }
        [Test]
        public void probarDesviacionEstandar()
        {
            //Arrange
            List<double> listaPrueba = new List<double>();
            Varianza varianza;
            listaPrueba.Add(8);
            listaPrueba.Add(4);
            listaPrueba.Add(2);
            listaPrueba.Add(6);
            listaPrueba.Add(10);
            listaPrueba.Add(6);
            varianza = new Varianza(listaPrueba);
            //Act
            double resultado = varianza.darDesviacionEstandar();
            //Assert
            Assert.LessOrEqual(2.58, resultado);
        }
        [Test]
        public void probarMeda()
        {
            //Arrange
            List<double> listaPrueba = new List<double>();
            Meda varianza;
            listaPrueba.Add(8);
            listaPrueba.Add(4);
            listaPrueba.Add(2);
            listaPrueba.Add(7);
            listaPrueba.Add(10);
            listaPrueba.Add(6);
            
            varianza = new Meda(listaPrueba);
            //Act
            double resultado = varianza.darMeda();
            //Assert
            Assert.AreEqual(2, resultado);
        }
        [Test]
        public void probarRangoIntercuartil()
        {
            //Arrange
            List<double> listaPrueba = new List<double>();
            Quartiles quartil;
            listaPrueba.Add(10);
            listaPrueba.Add(11);
            listaPrueba.Add(12);
            listaPrueba.Add(17);
            listaPrueba.Add(19);
            listaPrueba.Add(15);
            listaPrueba.Add(1);
            quartil = new Quartiles(listaPrueba);
            //Act
            double rangoIntercuartil = quartil.darRangoIntercuartil();
            //Assert
            Assert.LessOrEqual(7, rangoIntercuartil);
        }
        [Test]
        public void probarValorAlejadoPorDefecto()
        {
            //Arrange
            List<double> listaPrueba = new List<double>();
            ValoresAlejados valorAlejado;
            listaPrueba.Add(20);
            listaPrueba.Add(21);
            listaPrueba.Add(22);
            listaPrueba.Add(27);
            listaPrueba.Add(29);
            listaPrueba.Add(25);
            listaPrueba.Add(1);
            valorAlejado = new ValoresAlejados(listaPrueba);
            //Act
            double valorAlejadoPorDefecto = valorAlejado.darValorAlejadoPorDefecto();
            //Assert
            Assert.AreEqual(1, valorAlejadoPorDefecto);
        }
        [Test]
        public void probarValorAlejadoPorExceso()
        {
            //Arrange
            List<double> listaPrueba = new List<double>();
            ValoresAlejados valorAlejado;
            listaPrueba.Add(10.5);
            listaPrueba.Add(10.3);
            listaPrueba.Add(10.2);
            listaPrueba.Add(10.7);
            listaPrueba.Add(10.9);
            listaPrueba.Add(20);
            valorAlejado = new ValoresAlejados(listaPrueba);
            //Act
            double valorAlejadoPorExceso = valorAlejado.darValorAlejadoPorExceso();
            //Assert
            Assert.AreEqual(20, valorAlejadoPorExceso);
        }
    }
}
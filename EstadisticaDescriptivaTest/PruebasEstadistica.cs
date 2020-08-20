using NUnit.Framework;
using ProbabilidadYEstadística;
using System;
using System.Collections.Generic;

namespace EstadisticaDescriptivaTest
{
    [TestFixture]
    public class Tests
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

            Mediana mediana = new Mediana(listaPrueba);
            //Act
            double resultado = mediana.darMediana();
            //assert
            Assert.AreEqual(6.5d, resultado);
        }

        [Test]
        public void probarPrimerQuartil()
        {
            //arrange
            List<double> listaPrueba = new List<double>();
            Quartiles quartil;
            listaPrueba.Add(4.5);
            listaPrueba.Add(4.3);
            listaPrueba.Add(4.2);
            listaPrueba.Add(4.7);
            listaPrueba.Add(4.9);
            quartil = new Quartiles(listaPrueba);
            //Act
            double resultado = quartil.darPrimerQuartil();
            //Assert
            Assert.AreEqual(4.3, resultado);
        }
        [Test]
        public void probarTercerQuartil()
        {
            List<double> listaPrueba = new List<double>();
            Quartiles quartil;
            listaPrueba.Add(4.5);
            listaPrueba.Add(4.3);
            listaPrueba.Add(4.2);
            listaPrueba.Add(4.7);
            listaPrueba.Add(4.9);
            listaPrueba.Add(4.4);
            quartil = new Quartiles(listaPrueba);
            //Act
            double resultado = quartil.darTercerQuartil();
            //Assert
            Assert.AreEqual(4.9, resultado);
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
    }
}
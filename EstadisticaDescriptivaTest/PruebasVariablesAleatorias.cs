using NUnit.Framework;
using ProbabilidadYEstadística;
using System;
using System.Collections.Generic;
using System.Text;

namespace EstadisticaDescriptivaTest
{
    [TestFixture]
    class PruebasVariablesAleatorias
    {
        [Test]
        public void testEsperanza()
        {
            //Arrange
            VariableAleatoriaBean aleatoriaBean1 = new VariableAleatoriaBean(0,0.6);
            VariableAleatoriaBean aleatoriaBean2 = new VariableAleatoriaBean(50, 0.15);
            VariableAleatoriaBean aleatoriaBean3 = new VariableAleatoriaBean(100, 0.10);
            VariableAleatoriaBean aleatoriaBean4 = new VariableAleatoriaBean(500, 0.10);
            VariableAleatoriaBean aleatoriaBean5 = new VariableAleatoriaBean(1000, 0.05);

            List<VariableAleatoriaBean> lista = new List<VariableAleatoriaBean>();
            lista.Add(aleatoriaBean1);
            lista.Add(aleatoriaBean2);
            lista.Add(aleatoriaBean3);
            lista.Add(aleatoriaBean4);
            lista.Add(aleatoriaBean5);

            Esperanza esperanza = new Esperanza(lista);
            //Acting
            double resultado = esperanza.darEsperanza();
            //Assert
            Assert.AreEqual(117.5d, resultado);
        }
        [Test]
        public void testVarianza()
        {
            //Arrange
            VariableAleatoriaBean aleatoriaBean1 = new VariableAleatoriaBean(0, 0.6);
            VariableAleatoriaBean aleatoriaBean2 = new VariableAleatoriaBean(50, 0.15);
            VariableAleatoriaBean aleatoriaBean3 = new VariableAleatoriaBean(100, 0.10);
            VariableAleatoriaBean aleatoriaBean4 = new VariableAleatoriaBean(500, 0.10);
            VariableAleatoriaBean aleatoriaBean5 = new VariableAleatoriaBean(1000, 0.05);

            List<VariableAleatoriaBean> lista = new List<VariableAleatoriaBean>();
            lista.Add(aleatoriaBean1);
            lista.Add(aleatoriaBean2);
            lista.Add(aleatoriaBean3);
            lista.Add(aleatoriaBean4);
            lista.Add(aleatoriaBean5);

            VarianzaAleatoria varianza = new VarianzaAleatoria(lista);
            //Acting
            double resultado = varianza.darVarianzaAleatoria();
            //Assert
            Assert.AreEqual(62568.75, resultado);
        }
        [Test]
        public void testEsProbable()
        {
            //Arrange
            VariableAleatoriaBean aleatoriaBean1 = new VariableAleatoriaBean(0, 0.60);
            VariableAleatoriaBean aleatoriaBean2 = new VariableAleatoriaBean(50, 0.15);
            VariableAleatoriaBean aleatoriaBean3 = new VariableAleatoriaBean(100, 0.10);
            VariableAleatoriaBean aleatoriaBean4 = new VariableAleatoriaBean(500, 0.10);
            VariableAleatoriaBean aleatoriaBean5 = new VariableAleatoriaBean(1000, 0.05);

            List<VariableAleatoriaBean> lista = new List<VariableAleatoriaBean>();
            lista.Add(aleatoriaBean1);
            lista.Add(aleatoriaBean2);
            lista.Add(aleatoriaBean3);
            lista.Add(aleatoriaBean4);
            lista.Add(aleatoriaBean5);

            Esperanza esperanza = new Esperanza(lista);
            //Acting
            bool resultado = EsVariableAleatoria.esVariableAleatoria(lista);
            //Assert
            Assert.IsTrue(resultado);
        }
    }
}

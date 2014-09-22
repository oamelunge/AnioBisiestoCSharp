using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AnioBisiesto
{
    [TestClass] 
    public class TestAnioBisiesto
    {
        

        [TestMethod]
        public void TestAnioBisiestoComun()
        {
            Assert.IsTrue(llamarACalculadorBisiestos(1996));
        }

        [TestMethod]
        public void TestAnioCoum()
        {
            Assert.IsFalse(llamarACalculadorBisiestos(2001));
        }

        [TestMethod]
        public void TestAnioComunNoTipicoDivisibleX4yNoX100()
        {            
            Assert.IsFalse(llamarACalculadorBisiestos(1900));
        }

        [TestMethod]
        public void TestAnioBisiestoNoTipicoDivisiblePor100()
        {            
            Assert.IsTrue(llamarACalculadorBisiestos(2000));
        }

        private bool  llamarACalculadorBisiestos(int anio)
        {
            CalculadorBisiesto _calculadorBisiesto = new CalculadorBisiesto(anio);
            return _calculadorBisiesto.es_bisiesto();
        }
    }
}

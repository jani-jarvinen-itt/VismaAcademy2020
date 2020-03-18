using Microsoft.VisualStudio.TestTools.UnitTesting;
using SqlServerTesti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlServerTesti.Tests
{
    [TestClass()]
    public class LaskentaTests
    {
        [TestMethod()]
        public void SummaTest()
        {
            int a = 100;
            int b = 200;

            Laskenta l = new Laskenta();
            int summa = l.Summa(a, b);

            int odotettu = a + b;
            Assert.AreEqual(odotettu, summa);
        }
    }
}
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyDataStructureProject;

namespace Sort_Testing
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TheIntegerSortFunctionSortsTheArray()
        {
            Program n = new Program();
            int[] Tarr = { 5, 32, 5, 6 };
           int [] e= n.IntegerSorting(Tarr);
            Assert.AreEqual(e[0], 5);

        }
        [TestMethod]
        public void TheStringSortFunctionSortsTheArray()
        {
            Program n = new Program();
            string[] Tarr = {"zya", "wno", "abc", "asd" };
           string [] e= n.StringSorting(Tarr);
            Assert.AreEqual(e[0], "abc");

        }
        [TestMethod]
        public void TheDecimalSortFunctionSortsTheArray()
        {
            Program n = new Program();
            double[] Tarr = { 6.4,2.2,1.1,1.0,88.1,77.5 };
            double[] e = n.DecimalSorting(Tarr);
            Assert.AreEqual(e[0],1.0);

        }
    }
}

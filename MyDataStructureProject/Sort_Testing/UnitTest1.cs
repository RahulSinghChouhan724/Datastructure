using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyDataStructureProject;

namespace Sort_Testing
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]

        public void TheIntegerSortFunctionSortingTheArray()
        {
            Program n = new Program();
            int[] Tarr = { 5, 32, 5, 6 };
           int [] e= n.IntegerSorting(Tarr);
            Assert.AreEqual(e[0], 5);

        }
    }
}

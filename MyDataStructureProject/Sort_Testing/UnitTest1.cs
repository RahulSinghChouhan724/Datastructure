using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyDataStructureProject;
namespace Sort_Testing
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ShouldFind5AtIndex3()
        {
           
            String[] TestArray = { "clo", "yepso", "webb", "polo", "wertimo", "e" };
            var CS = new cSearch<String>();
            var Working = CS.SearchArray(TestArray, "welrtimo");
            Assert.AreEqual(Working, 4);
        }
    }
}
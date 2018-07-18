﻿using System;
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
<<<<<<< HEAD
           
            String[] TestArray = { "clo", "yepso", "webb", "polo", "wertimo", "e" };
            var CS = new cSearch<String>();
            var Working = CS.SearchArray(TestArray, "welrtimo");
            Assert.AreEqual(Working, 4);
=======
            Program n = new Program();
            int[] Tarr = { 5, 32, 3, 6, -1 };
            int[] e = n.IntegerSorting(Tarr);
            Assert.AreEqual(e[0], -1);
        }
        [TestMethod]
        public void TheStringSortFunctionSortsTheArray()
        {
            Program n = new Program();
            string[] Tarr = { "zya", "wno", "abc", "asd" };
            string[] e = n.StringSorting(Tarr);
            Assert.AreEqual(e[0], "abc");
        }
        [TestMethod]
        public void TheDecimalSortFunctionSortsTheArray()
        {
            Program n = new Program();
            double[] Tarr = { 6.4, 2.2, 1.1, 1.0, 88.1, 77.5 };
            double[] e = n.DecimalSorting(Tarr);
            Assert.AreEqual(e[0], 1.0);
        }
        [TestMethod]
        public void TheBinarySearchSearchesSortedArray()
        {
            Program n = new Program();
            int[] TestArray = { 4, 1, 7, 5, 3, 9, 2, 6, 8 };
            int find = 7;
            int Working = n.IntegerSearch(TestArray, find);
            Assert.AreEqual(Working, 6);
        }
        [TestMethod]
        public void TheGenericSortFunctionSortsTheArray()
        {
            var n = new Program();
            int[] Tarr = { 5, 32, 3, 6, -1 };
            int[] e = n.SortingG(Tarr);
            Assert.AreEqual(e[0], -1);
>>>>>>> 90a92869d29c7c8df5f3be73d42cd259ad10659d
        }
    }
}
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Tyuiu.SosninRA.Sprint0.Task2.V0.Lib;

namespace Tyuiu.SosninRA.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ChekGetMessageValid()
        {
            var name = "Руслан";
            var res = DataService.GetMessage(name);

            Assert.AreEqual("Привет, Руслан", res);
        }
    }
}

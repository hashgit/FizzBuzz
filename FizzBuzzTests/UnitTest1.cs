using System;
using System.Collections.Generic;
using System.Linq;
using FizzBuzzLib;
using FizzBuzzLib.Items;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzzTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AllValidItems()
        {
            var app = new FizzBuzzApp(new List<string>() { "15"}, 3, 5);
            var result = app.Execute();

            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.Count);
            Assert.IsInstanceOfType(result.FirstOrDefault(), typeof(FizzBuzzItem));
        }

        [TestMethod]
        public void GivesOneFizzOneBuzz()
        {
            var app = new FizzBuzzApp(new List<string>() { "3", "5" }, 3, 5);
            var result = app.Execute();

            Assert.IsNotNull(result);
            Assert.AreEqual(2, result.Count);
            Assert.IsInstanceOfType(result.FirstOrDefault(), typeof(FizzItem));
            Assert.IsInstanceOfType(result.LastOrDefault(), typeof(BuzzItem));
        }

        [TestMethod]
        public void GivesOneOtherItem()
        {
            var app = new FizzBuzzApp(new List<string>() { "1", "3", "5" }, 3, 5);
            var result = app.Execute();

            Assert.IsNotNull(result);
            Assert.AreEqual(3, result.Count);
            Assert.IsInstanceOfType(result.FirstOrDefault(), typeof(OtherItem));
            Assert.IsInstanceOfType(result[1], typeof(FizzItem));
            Assert.IsInstanceOfType(result.LastOrDefault(), typeof(BuzzItem));
        }

        [TestMethod]
        public void GivesInvalidItem()
        {
            var app = new FizzBuzzApp(new List<string>() { "1", "3", "5","", "15" }, 3, 5);
            var result = app.Execute();

            Assert.IsNotNull(result);
            Assert.AreEqual(5, result.Count);
            Assert.IsInstanceOfType(result.FirstOrDefault(), typeof(OtherItem));
            Assert.IsInstanceOfType(result[1], typeof(FizzItem));
            Assert.IsInstanceOfType(result[2], typeof(BuzzItem));
            Assert.IsInstanceOfType(result[3], typeof(InvalidItem));
            Assert.IsInstanceOfType(result.LastOrDefault(), typeof(FizzBuzzItem));
        }

        [TestMethod]
        public void GivesTwoInvalidItem()
        {
            var app = new FizzBuzzApp(new List<string>() { "1", "3", "5", "", "15", "A", "23" }, 3, 5);
            var result = app.Execute();

            Assert.IsNotNull(result);
            Assert.AreEqual(7, result.Count);
            Assert.IsInstanceOfType(result.FirstOrDefault(), typeof(OtherItem));
            Assert.IsInstanceOfType(result[1], typeof(FizzItem));
            Assert.IsInstanceOfType(result[2], typeof(BuzzItem));
            Assert.IsInstanceOfType(result[3], typeof(InvalidItem));
            Assert.IsInstanceOfType(result[4], typeof(FizzBuzzItem));
            Assert.IsInstanceOfType(result[5], typeof(InvalidItem));
            Assert.IsInstanceOfType(result.LastOrDefault(), typeof(OtherItem));
        }
    }
}

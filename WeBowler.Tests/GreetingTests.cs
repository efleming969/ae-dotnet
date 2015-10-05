using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WeBowler.Domain;

namespace WeBowler.Tests
{
    [TestClass]
    public class GreetingTests
    {
        [TestMethod]
        public void Should_Build_DefaultGreeting()
        {
            var greeting = Greeting.Build();

            Assert.AreEqual("Hello, World!", greeting);
        }
    }
}

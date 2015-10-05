using NUnit.Framework;
using WeBowler.Domain;

namespace WeBowler.Tests
{
    [TestFixture]
    public class GreetingTests
    {
        [Test]
        public void Should_Build_DefaultGreeting()
        {
            var greeting = Greeting.Build();

            Assert.AreEqual("Hello, World!", greeting);
        }
    }
}

using LINQ_Methods;

namespace CalculatorTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Add_ShouldReturnCorrectSum()
        {
            var calculator = new Calculator();
            Assert.That(calculator.Add(1,2), Is.EqualTo(3));
        }
    }
}
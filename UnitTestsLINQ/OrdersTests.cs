using LINQMethods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestsLINQ
{
    public class OrdersTests
    {
        [Test]
        public void Test_Order_WithEmptyInput_ShouldReturnEmptyString()
        {
            // Arrange
            string[] input = new string[] { };

            // Act
            string result = Orders.Order(input);

            // Assert
            Assert.That(result, Is.Empty);
        }

        // TODO: finish test
        [Test]
        public void Test_Order_WithMultipleOrders_ShouldReturnTotalPrice()
        {
            // Arrange
            string[] input = new string[] { "Beer 2.50 10.0", "Cola 1.50 10.0", "Beer 2.00 10.0", "Cola 1.30 5.0" };
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Beer -> 40.00");
            sb.Append("Cola -> 19.50");
            string expected = sb.ToString();


            // Act
            string result = Orders.Order(input);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Test_Order_WithRoundedPrices_ShouldReturnTotalPrice()
        {
            // Arrange
            string[] input = new string[] { "Beer 3.00 10.0", "Cola 2.00 10.0", "Beer 5.00 10.0", "Cola 1.00 5.0" };
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Beer -> 100.00");
            sb.Append("Cola -> 15.00");
            string expected = sb.ToString();


            // Act
            string result = Orders.Order(input);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Test_Order_WithDecimalQuantities_ShouldReturnTotalPrice()
        {
            // Arrange
            string[] input = new string[] { "Beer 3.00 10.0", "Cola 2.00 10.0", "Beer 5.00 10.0", "Cola 1.00 5.50" };
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Beer -> 100.00");
            sb.Append("Cola -> 15.50");
            string expected = sb.ToString();


            // Act
            string result = Orders.Order(input);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}

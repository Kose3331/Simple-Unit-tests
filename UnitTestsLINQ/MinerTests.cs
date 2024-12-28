using LINQMethods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestsLINQ
{
    public class MinerTests
    {
        [Test]
        public void Test_Mine_WithEmptyInput_ShouldReturnEmptyString()
        {
            // Arrange
            string[] input = new string[] { };

            // Act
            string result = Miner.Mine(input);
            // Assert
            Assert.That(result, Is.Empty);

        }

        // TODO: finish test
        [Test]
        public void Test_Mine_WithMixedCaseResources_ShouldBeCaseInsensitive()
        {
            // Arrange
            string[] input = new string[] { "gOlD 150", "sIlveR 100", "Gold 50", "Silver 100" };
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("gold -> 200");
            sb.Append("silver -> 200");
            string expected = sb.ToString();

            // Act
            string result = Miner.Mine(input);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Test_Mine_WithDifferentResources_ShouldReturnResourceCounts()
        {
            // Arrange
            string[] input = new string[] { "gold 150", "silver 100", "gold 50", "silver 100", "bronze 200", "gold 50" };
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("gold -> 250");
            sb.AppendLine("silver -> 200");
            sb.Append("bronze -> 200");
            string expected = sb.ToString();

            // Act
            string result = Miner.Mine(input);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}

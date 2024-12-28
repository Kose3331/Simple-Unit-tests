using LINQMethods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestsLINQ
{
    public class CountRealNumbersTests
    {
       
        [Test]
        public void Test_Count_WithEmptyArray_ShouldReturnEmptyString()
        {
            // Arrange
            int[] input = new int[] { };

            // Act
            string result = CountRealNumbers.Count(input);
            // Assert
            Assert.That(result, Is.Empty);
        }

        [Test]
        public void Test_Count_WithSingleNumber_ShouldReturnCountString()
        {
            // Arrange
            int[] input = new int[] { 9 };

            // Act
            string result = CountRealNumbers.Count(input);
            // Assert
            Assert.That(result, Is.EqualTo("9 -> 1"));
        }

        [Test]
        public void Test_Count_WithMultipleNumbers_ShouldReturnCountString()
        {
            // Arrange
            int[] input = new int[] { 9, 7, 3 };
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("3 -> 1");
            sb.AppendLine("7 -> 1");
            sb.Append("9 -> 1");
            string expected = sb.ToString();
            // Act
            string result = CountRealNumbers.Count(input);
            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Test_Count_WithNegativeNumbers_ShouldReturnCountString()
        {
            // Arrange
            int[] input = new int[] { -9, -7, -3 };
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("-9 -> 1");
            sb.AppendLine("-7 -> 1");
            sb.Append("-3 -> 1");
            string expected = sb.ToString();
            // Act
            string result = CountRealNumbers.Count(input);
            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Test_Count_WithZero_ShouldReturnCountString()
        {
            // Arrange
            int[] input = new int[] { 9, 7, 3, 0 };
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("0 -> 1");
            sb.AppendLine("3 -> 1");
            sb.AppendLine("7 -> 1");
            sb.Append("9 -> 1");
            string expected = sb.ToString();
            // Act
            string result = CountRealNumbers.Count(input);
            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}

using LINQMethods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestsLINQ
{
    public class GroupingTests
    {
        
        [Test]
        public void Test_GroupNumbers_WithEmptyList_ShouldReturnEmptyString()
        {
            // Arrange
            List<int> input = new List<int>();
            // Act
            string result = Grouping.GroupNumbers(input);

            // Assert
            Assert.That(result, Is.Empty);
        }

        [Test]
        public void Test_GroupNumbers_WithEvenAndOddNumbers_ShouldReturnGroupedString()
        {
            // Arrange
            List<int> input = new List<int>() { 3, 4, 5, 6, 7, 8, 9 };
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Odd numbers: 3, 5, 7, 9");
            sb.Append("Even numbers: 4, 6, 8");
            string expected = sb.ToString();
            // Act
            string result = Grouping.GroupNumbers(input);

            // Assert
            Assert.That(result, Is.EqualTo(expected));

        }

        [Test]
        public void Test_GroupNumbers_WithOnlyEvenNumbers_ShouldReturnGroupedString()
        {
            // Arrange
            List<int> input = new List<int>() { 2, 4, 6, 8, 10 };
            StringBuilder sb = new StringBuilder();
            sb.Append("Even numbers: 2, 4, 6, 8, 10");
            string expected = sb.ToString();
            // Act
            string result = Grouping.GroupNumbers(input);

            // Assert
            Assert.That(result, Is.EqualTo(expected));

        }

        [Test]
        public void Test_GroupNumbers_WithOnlyOddNumbers_ShouldReturnGroupedString()
        {
            // Arrange
            List<int> input = new List<int>() { 1, 3, 5, 7, 9 };
            StringBuilder sb = new StringBuilder();
            sb.Append("Odd numbers: 1, 3, 5, 7, 9");
            string expected = sb.ToString();
            // Act
            string result = Grouping.GroupNumbers(input);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Test_GroupNumbers_WithNegativeNumbers_ShouldReturnGroupedString()
        {
            // Arrange
            List<int> input = new List<int>() { -3, -4, -5, -6, -7, -8, -9 };
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Odd numbers: -3, -5, -7, -9");
            sb.Append("Even numbers: -4, -6, -8");
            string expected = sb.ToString();
            // Act
            string result = Grouping.GroupNumbers(input);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}

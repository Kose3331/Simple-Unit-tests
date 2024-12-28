using LINQMethods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestsLINQ
{
    public class OddOccurencesTests
    {
        [Test]
        public void Test_FindOdd_WithEmptyArray_ShouldReturnEmptyString()
        {
            // Arrange
            string[] input = new string[] { };

            // Act
            string result = OddOccurences.FindOdd(input);

            // Assert
            Assert.That(result, Is.Empty);
        }

        // TODO: finish test
        [Test]
        public void Test_FindOdd_WithNoOddOccurrences_ShouldReturnEmptyString()
        {
            // Arrange
            string[] input = new string[] { "abc", "abc", "varna", "varna", "QA", "QA" };
            // Act
            string result = OddOccurences.FindOdd(input);

            // Assert
            Assert.That(result, Is.Empty);
        }

        [Test]
        public void Test_FindOdd_WithSingleOddOccurrence_ShouldReturnTheOddWord()
        {
            // Arrange
            string[] input = new string[] { "sofia", "varna", "sofia" };
            string expected = "varna";
            // Act
            string result = OddOccurences.FindOdd(input);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Test_FindOdd_WithMultipleOddOccurrences_ShouldReturnAllOddWords()
        {
            // Arrange
            string[] input = new string[] { "varna", "sofia", "plovdiv", "varna", "sofia", "sofia" };
            string expected = "sofia plovdiv";


            // Act
            string result = OddOccurences.FindOdd(input);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Test_FindOdd_WithMixedCaseWords_ShouldBeCaseInsensitive()
        {
            // Arrange
            string[] input = new string[] { "varnA", "Sofia", "ploVdiv", "Varna", "SOfia", "sofiA" };
            string expected = "sofia plovdiv";


            // Act
            string result = OddOccurences.FindOdd(input);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}

using LINQMethods;
using System.Text;

namespace UnitTestsLINQ
{
    public class Tests
    {
        [Test]
        public void Test_Count_WithEmptyList_ShouldReturnEmptyString()
        {
            // Arrange
            List<string> input = new();

            // Act
            string result = CountCharacters.Count(input);

            // Assert
            Assert.That(result, Is.Empty);
        }

        
        [Test]
        public void Test_Count_WithNoCharacters_ShouldReturnEmptyString()
        {
            // Arrange
            List<string> input = new List<string> { "" };

            // Act
            string result = CountCharacters.Count(input);

            // Assert
            Assert.That(result, Is.Empty);
        }

        [Test]
        public void Test_Count_WithSingleCharacter_ShouldReturnCountString()
        {
            //Arrange
            List<string> input = new List<string> { "k" };



            // Act
            string result = CountCharacters.Count(input);

            // Assert
            Assert.That(result, Is.EqualTo("k -> 1"));
        }

        [Test]
        public void Test_Count_WithMultipleCharacters_ShouldReturnCountString()
        {
            //Arrange
            List<string> input = new List<string> { "k", "ko", "kose" };

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("k -> 3");
            sb.AppendLine("o -> 2");
            sb.AppendLine("s -> 1");
            sb.Append("e -> 1");
            string expected = sb.ToString();



            // Act
            string result = CountCharacters.Count(input);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Test_Count_WithSpecialCharacters_ShouldReturnCountString()
        {
            //Arrange
            List<string> input = new List<string> { "k", "ko", "@kose" };

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("k -> 3");
            sb.AppendLine("o -> 2");
            sb.AppendLine("@ -> 1");
            sb.AppendLine("s -> 1");
            sb.Append("e -> 1");
            string expected = sb.ToString();



            // Act
            string result = CountCharacters.Count(input);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}
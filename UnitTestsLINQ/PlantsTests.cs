using LINQMethods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestsLINQ
{
    public class PlantsTests
    {
        [Test]
        public void Test_GetFastestGrowing_WithEmptyArray_ShouldReturnEmptyString()
        {
            // Arrange
            string[] input = new string[] { };

            // Act
            string result = Plants.GetFastestGrowing(input);

            // Assert
            Assert.That(result, Is.Empty);
        }

        // TODO: finish test
        [Test]
        public void Test_GetFastestGrowing_WithSinglePlant_ShouldReturnPlant()
        {
            // Arrange
            string[] input = new string[] { "tulip" };
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Plants with 5 letters:");
            sb.Append("tulip");
            string expected = sb.ToString();


            // Act
            string result = Plants.GetFastestGrowing(input);

            // Assert
            Assert.That(result, Is.EqualTo(expected));

        }

        [Test]
        public void Test_GetFastestGrowing_WithMultiplePlants_ShouldReturnGroupedPlants()
        {
            // Arrange
            string[] input = new string[] { "rose", "lily", "mint", "cacti" };
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Plants with 4 letters:");
            sb.AppendLine("rose");
            sb.AppendLine("lily");
            sb.AppendLine("mint");
            sb.AppendLine("Plants with 5 letters:");
            sb.Append("cacti");
            string expected = sb.ToString();

            // Act
            string result = Plants.GetFastestGrowing(input);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Test_GetFastestGrowing_WithMixedCasePlants_ShouldBeCaseInsensitive()
        {
            // Arrange
            string[] input = new string[] { "RosE", "liLY", "MInt", "CaCti" };
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Plants with 4 letters:");
            sb.AppendLine("RosE");
            sb.AppendLine("liLY");
            sb.AppendLine("MInt");
            sb.AppendLine("Plants with 5 letters:");
            sb.Append("CaCti");
            string expected = sb.ToString();

            // Act
            string result = Plants.GetFastestGrowing(input);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}

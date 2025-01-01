using ExceptionHandling;
using System;

namespace ExceptionHandlingTests
{
    public class Tests
    {

        private Exceptions _exceptions = null!;

        [SetUp]
        public void SetUp()
        {
            this._exceptions = new();
        }


        [Test]
        public void Test_Reverse_ValidString_ReturnsReversedString()
        {
            // Arrange
            string input = "hey";
            string expected = "yeh";
            // Act
            string result = _exceptions.ArgumentNullReverse(input);
            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }


        [Test]
        public void Test_Reverse_NullString_ThrowsArgumentNullException()
        {
            // Arrange
            string input = null;

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => _exceptions.ArgumentNullReverse(input));

        }

        [Test]
        public void Test_CalculateDiscount_ValidInput_ReturnsDiscountedPrice()
        {
            //  Act & Assert
            decimal result = _exceptions.ArgumentCalculateDiscount(100, 50);
            Assert.That(result, Is.EqualTo(50));

        }


        [Test]
        public void Test_CalculateDiscount_NegativeDiscount_ThrowsArgumentException()
        {
            // Arrange
            decimal totalPrice = 100;
            decimal discountedPrice = -10;
            // Act & Assert
            Assert.Throws<ArgumentException>(() => _exceptions.ArgumentCalculateDiscount(totalPrice, discountedPrice));
        }


        [Test]
        public void Test_CalculateDiscount_DiscountOver100_ThrowsArgumentException()
        {
            // Arrange
            decimal totalPrice = 100.0m;
            decimal discount = 110.0m;

            // Act & Assert
            Assert.Throws<ArgumentException>(() => _exceptions.ArgumentCalculateDiscount(totalPrice, discount));
        }

        [Test]
        public void Test_GetElement_ValidIndex_ReturnsElement()
        {
            // Arrange
            int[] array = { 1, 2, 3, 4 };
            int index = 3;
            int expected = 4;
            // Act
            int result = _exceptions.IndexOutOfRangeGetElement(array, index);
            // Assert
            Assert.That(result, Is.EqualTo((expected)));
        }


        [Test]
        public void Test_GetElement_IndexLessThanZero_ThrowsIndexOutOfRangeException()
        {
            // Arrange
            // Arrange
            int[] array = { 1, 2, 3, 4 };
            int index = -1;

            // Act & Assert
            Assert.Throws<IndexOutOfRangeException>(() => _exceptions.IndexOutOfRangeGetElement(array, index));
        }


        [Test]
        public void Test_GetElement_IndexEqualToArrayLength_ThrowsIndexOutOfRangeException()
        {
            // Arrange
            int[] array = { 10, 20, 30, 40, 50 };
            int index = array.Length;

            // Act & Assert
            Assert.Throws<IndexOutOfRangeException>(() => _exceptions.IndexOutOfRangeGetElement(array, index));
        }

        [Test]
        public void Test_GetElement_IndexGreaterThanArrayLength_ThrowsIndexOutOfRangeException()
        {
            // Arrange
            int[] array = { 10, 20, 30, 40, 50 };
            int index = 5;
            // Act & Assert
            Assert.Throws<IndexOutOfRangeException>(() => _exceptions.IndexOutOfRangeGetElement(array, index));
        }

        [Test]
        public void Test_PerformSecureOperation_UserLoggedIn_ReturnsUserLoggedInMessage()
        {
            // Arrange
            bool isLogged = true;

            string result = _exceptions.InvalidOperationPerformSecureOperation(isLogged);

            // Act & Assert
            Assert.That(result, Is.EqualTo("User logged in."));
        }

        [Test]
        public void Test_PerformSecureOperation_UserNotLoggedIn_ThrowsInvalidOperationException()
        {
            // Arrange
            bool isLoggedIn = false;

            // Act & Assert
            Assert.Throws<InvalidOperationException>(() => _exceptions.InvalidOperationPerformSecureOperation(isLoggedIn));
        }

        [Test]
        public void Test_ParseInt_ValidInput_ReturnsParsedInteger()
        {
            // Arrrange
            string input = "9";
            bool isParsed = int.TryParse(input, out int result);


            // Assert
            Assert.That(result, Is.EqualTo(9));
        }

        [Test]
        public void Test_ParseInt_InvalidInput_ThrowsFormatException()
        {
            // Arrange
            string input = "abc";



            //Act & Assert
            Assert.Throws<FormatException>(() => _exceptions.FormatExceptionParseInt(input));
        }

        [Test]
        public void Test_FindValueByKey_KeyExistsInDictionary_ReturnsValue()
        {
            //Arrange
            Dictionary<string, int> input = new Dictionary<string, int>()
            {
                ["Kose"] = 30
            };
            string lookUpKey = "Kose";
            int expected = 30;
            // Act
            int result = _exceptions.KeyNotFoundFindValueByKey(input, lookUpKey);

            // Assert
            Assert.That(result, Is.EqualTo(expected));

        }

        [Test]
        public void Test_FindValueByKey_KeyDoesNotExistInDictionary_ThrowsKeyNotFoundException()
        {
            // Arrange
            Dictionary<string, int> input = new Dictionary<string, int>()
            {
                ["Kose"] = 30
            };
            string lookUpKey = "Kosta";

            // Act & Assert
            Assert.Throws<KeyNotFoundException>(() => _exceptions.KeyNotFoundFindValueByKey(input, lookUpKey));

        }

        [Test]
        public void Test_AddNumbers_NoOverflow_ReturnsSum()
        {
            // Arrange
            int numberA = 100590;
            int numberB = 200000;
            int expected = 300590;


            // Act
            int result = _exceptions.OverflowAddNumbers(numberA, numberB);
            // 
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Test_AddNumbers_PositiveOverflow_ThrowsOverflowException()
        {
            // Arrange
            int numberA = int.MaxValue;
            int numberB = 1;

            // Act & Assert
            Assert.Throws<OverflowException>(() => _exceptions.OverflowAddNumbers(numberA, numberB));
        }

        [Test]
        public void Test_AddNumbers_NegativeOverflow_ThrowsOverflowException()
        {
            // Arrange
            int numberA = int.MinValue;
            int numberB = -1;

            // Act & Assert
            Assert.Throws<OverflowException>(() => _exceptions.OverflowAddNumbers(numberA, numberB));
        }

        [Test]
        public void Test_DivideNumbers_ValidDivision_ReturnsQuotient()
        {
            // Arrange
            int dividend = 9;
            int divisor = 9;
            int expected = 1;
            // Act
            int result = _exceptions.DivideByZeroDivideNumbers(dividend, divisor);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Test_DivideNumbers_DivideByZero_ThrowsDivideByZeroException()
        {
            // Arrange
            int dividend = 9;
            int divisor = 0;
            //Act & Assert
            Assert.Throws<DivideByZeroException>(() => _exceptions.DivideByZeroDivideNumbers(dividend, divisor));
        }

        [Test]
        public void Test_SumCollectionElements_ValidCollectionAndIndex_ReturnsSum()
        {
            // Arrange
            int[] input = { 10, 20, 30, 40 };
            int index = 3;
            int expected = 100;
            // Act
            int result = _exceptions.SumCollectionElements(input, index);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Test_SumCollectionElements_NullCollection_ThrowsArgumentNullException()
        {
            // Arrange
            int[] input = null;
            int index = 0;
            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => _exceptions.SumCollectionElements(input, index));
        }

        [Test]
        public void Test_SumCollectionElements_IndexOutOfRange_ThrowsIndexOutOfRangeException()
        {
            // Arrange
            int[] input = { 10, 20, 30, 40 };
            int index = 4;
            // Act & Assert
            Assert.Throws<IndexOutOfRangeException>(() => _exceptions.SumCollectionElements(input, index));
        }

        [Test]
        public void Test_GetElementAsNumber_ValidKey_ReturnsParsedNumber()
        {
            // Arrange
            Dictionary<string, string> input = new Dictionary<string, string>()
            {
                ["Kose"] = "1"
            };
            string key = "Kose";
            int expected = 1;
            // Act
            int result = _exceptions.GetElementAsNumber(input, key);
            // Assert
            Assert.That(result, Is.EqualTo(expected));


        }

        [Test]
        public void Test_GetElementAsNumber_KeyNotFound_ThrowsKeyNotFoundException()
        {
            // Arrange
            Dictionary<string, string> input = new Dictionary<string, string>()
            {
                ["Kose"] = "1"
            };
            string key = "Kosta";



            // Assert
            Assert.Throws<KeyNotFoundException>(() => _exceptions.GetElementAsNumber(input, key));
        }

        [Test]
        public void Test_GetElementAsNumber_InvalidFormat_ThrowsFormatException()
        {
            // Arrange
            Dictionary<string, string> input = new Dictionary<string, string>()
            {
                ["Kose"] = "Radi"
            };
            string key = "Kose";



            // Assert
            Assert.Throws<FormatException>(() => _exceptions.GetElementAsNumber(input, key));

        }
    }
}
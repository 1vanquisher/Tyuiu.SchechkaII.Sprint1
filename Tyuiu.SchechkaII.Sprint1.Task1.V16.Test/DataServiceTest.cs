using Tyuiu.SchechkaII.Sprint1.Task1.V16.Lib;
namespace Tyuiu.SchechkaII.Sprint1.Task1.V16.Test
{
    [TestClass]
    public class DataServiceTests
    {
        private DataService _dataService;

        [TestInitialize]
        public void Setup()
        {
            _dataService = new DataService();
        }

        [TestMethod]
        public void Calculate_WithPositiveNumbers_ReturnsCorrectResult()
        {
            // Arrange
            double x = 2, a = 3, y = 4;
            double expected = 2 * 5 * 3 + 2 * 4; // 38

            // Act
            double actual = _dataService.Calculate(x, a, y);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Calculate_WithZero_ReturnsCorrectResult()
        {
            double x = 0, a = 5, y = 10;
            double expected = 0 * 5 * 5 + 2 * 10; // 20
            double actual = _dataService.Calculate(x, a, y);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Calculate_WithNegativeNumbers_ReturnsCorrectResult()
        {
            double x = -1, a = 2, y = -3;
            double expected = -1 * 5 * 2 + 2 * (-3); // -16
            double actual = _dataService.Calculate(x, a, y);
            Assert.AreEqual(expected, actual);
        }
    }
}

using Tyuiu.SchechkaII.Sprint1.Task0.V14.Lib;
namespace Tyuiu.SchechkaII.Sprint1.Task0.V14.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CalculateReturn()
        {
            int a = 2 * 3 * 3 + 7;

            int actual = DataService.Calculate();
            Assert.AreEqual(a, actual);
        }
        public void CalculateResult25()
        {
            Assert.AreEqual(25, DataService.Calculate());
        }
    }
}

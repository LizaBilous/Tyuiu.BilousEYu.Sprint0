using Tyuiu.BilousEYu.Sprint0.Task3.V0.Lib;
namespace Tyuiu.BilousEYu.Sprint0.Task3.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedValid()
        {
            Assert.AreEqual(10, DataService.Sum(5, 5));
        }
    }
}
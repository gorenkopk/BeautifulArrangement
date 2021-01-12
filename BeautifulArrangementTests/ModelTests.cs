using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BeautifulArrangement
{
    [TestClass()]
    public class ModelTests
    {
        [TestMethod()]
        public void GetBeautifulArrangementTest()
        {
            Model model = new Model();
            Assert.AreEqual(1, model.CountArrangement(1));

            model = new Model();
            Assert.AreEqual(2, model.CountArrangement(2));

            model = new Model();
            Assert.AreEqual(10, model.CountArrangement(5));
        }
    }
}
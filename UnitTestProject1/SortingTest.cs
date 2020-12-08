using Microsoft.VisualStudio.TestTools.UnitTesting;
using You_Source._Model;
namespace UnitTestProject1
{
    [TestClass]
    public class SortingTest
    {
        readonly Model model = new Model();
        [TestMethod]
        public void Controller_BubbleSort_Test()
        {
            string inputValue = "CAAA";
            string expectedValue = "aaac";
            string resultBubbleSort =model.GetBubbleSort(inputValue);
            Assert.AreEqual(expectedValue, resultBubbleSort);
         
        }

        [TestMethod]
        public void Controller_QuickSort_Test()
        {
            string inputValue = "caaa";
            string expectedValue = "aaac";
                string resultQuickSort = model.GetQuickSort(inputValue);
            Assert.AreEqual(expectedValue, resultQuickSort);
        }


    }
}

using MyClassLibrary1;

namespace TestProject8ICar
{
    [TestClass]
    public class UnitTest1ICar
    {
        [TestMethod]
        public void TestGetPrice()
        {
            Bmw b = new Bmw();
            int execpted = 1300000;
            int actual = b.GetPrice("M3");
             Assert. AreEqual(execpted, actual);
       
            }
    }
} 
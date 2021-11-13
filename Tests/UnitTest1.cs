using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Numerics;
using RPP_task_01;

namespace Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            BigInteger test = Factorial.Result(3);
            BigInteger res = 1 * 2 * 3;
            Assert.AreEqual(res, test);
        }

        [TestMethod]
        public void TestMethod2()
        {
            double test = Formula.Result(3);
            double res = 1 / 1D + 1 / 1D + 1 / (1D * 2D) + 1 / (1D * 2D * 3D);
            Assert.AreEqual(res, test);
        }
    }
}

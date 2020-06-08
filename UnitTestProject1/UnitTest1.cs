using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary1;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test1_2_6_9()
        {
            int a = 2, b = 6, c = 9;
            string actError, expectedError = "";//expected - то с чем сравниваем, actual - что приходит из теста
            double[] expResult = new double[0];
            double[] actResult = Class1.Eqal(a, b, c, out actError);
            Assert.AreEqual(expectedError, actError, "Полученое сообщение (" + actError + ") не совпадает с ожидаемым (" + expectedError + ")");
            Assert.AreEqual(expResult.Length, actResult.Length);
            for (int i = 0; i < expResult.Length; i++)
                Assert.AreEqual(expResult[i], actResult[i]);

        }
    }
}

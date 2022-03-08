using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WindowsFormsApp1;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            double ureg = 100, dreg = 100, numbPart = 0.00001;
            Func<double, double> func = x => x*x;
            Integral integral = new Integral(numbPart);
            double res = integral.Calculate(func, dreg, ureg);
            Assert.AreEqual(0, res, 0.001);
        }
        [TestMethod]
        public void TestMethod2()
        {
            double ureg = 1000, dreg = 0, numbPart = 0.00001;
            Func<double, double> func = x => x * x + 2 * x + 3;
            Integral integral = new Integral(numbPart);
            double res = integral.Calculate(func, dreg, ureg);
            Assert.AreEqual(334336333.333, res, 0.001);
        }
        [TestMethod]
        public void TestMethod3()
        {
            double ureg = 50, dreg = 1, numbPart = 0.00001;
            Func<double, double> func = x => 7 / x - x * x + ((9 * x + 1) / (x * x * x - 3));
            Integral integral = new Integral(numbPart);
            double res = integral.Calculate(func, dreg, ureg);
            Assert.AreEqual(-41632.9496, res, 0.001);
        }
        [TestMethod]
        public void TestMethod4()
        {
            double ureg = 10, dreg = 0, numbPart = 0.00001;
            Func<double, double> func = x => 1;
            Integral integral = new Integral(numbPart);
            double res = integral.Calculate(func, dreg, ureg);
            Assert.AreNotEqual(2, res, 0.001);
        }
        [TestMethod]
        public void TestMethod5()
        {
            double ureg = 10, dreg = 100, numbPart = 0.00001;
            Func<double, double> func = x => x * x;
            Integral integral = new Integral(numbPart);
            double res = integral.Calculate(func, dreg, ureg);
            Assert.AreNotEqual(1, res, 0.001);
        }
    }
}

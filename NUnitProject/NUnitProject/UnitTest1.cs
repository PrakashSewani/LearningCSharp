using NUnit.Framework;
namespace NUnitProject
{
    [TestFixture]
    public class Tests
    {

        [Test]
        [TestCase(1001,950.95)]
        [TestCase(2500,2250)]
        [TestCase(4700,3995)]
        public void TestDiscount(double n1,double n2)
        {
            TestProgram cpp=new TestProgram();
            double result = cpp.Discount((int)n1);
            Assert.That(n2,Is.EqualTo(result));
        }
        [Test]
        [TestCase(100000,8792)]
        [TestCase(190000, 17875)]
        [TestCase(300000, 29099)]
        public void TestEMI(double p1,double p2)
        {
            TestProgram cpp = new TestProgram();
            Assert.That(p2, Is.EqualTo(Math.Round(cpp.EMICalculator(p1))));
        }

        [Test]
        [TestCase(1000,1020)]
        [TestCase(15000,15750)]
        [TestCase(57800,63002)]
        public void TestSI(double p1, double p2)
        {
            TestProgram cpp = new TestProgram();
            Assert.That(p2, Is.EqualTo(cpp.SICalculator(p1)));
        }

        [Test]
        [TestCase(5000,5255.80)]
        [TestCase(17000,18228.93)]
        [TestCase(75000,83678.91)]
        public void TestCI(double p1,double p2)
        {
            TestProgram cpp = new TestProgram();
            Assert.That(p2,Is.EqualTo(cpp.CICalculator(p1)).Within(0.1));
        }
    }
}
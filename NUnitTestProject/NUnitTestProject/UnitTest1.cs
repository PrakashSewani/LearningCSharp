
namespace NUnitTestProject
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Test1()
        {
            TestProgram myobj=new TestProgram();
            int result = myobj.Add(15, 65);
            Assert.That(result,Is.EqualTo(80));
        }
        [Test]
        [TestCase(15,35,50)]
        [TestCase(10,45,55)]
        [TestCase(10,10,25)]
        public void AddMethodTest(int n1,int n2, int n3)
        {
            TestProgram myobj = new TestProgram();
            Assert.AreEqual(n3,myobj.Add(n1,n2));
        }
    }
}
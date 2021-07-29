using NUnit.Framework;
using NUnit.Framework.Internal;

namespace TestProject1
{
    [TestFixture]
    public class UnitTest1
    {
        TestDemo t = new TestDemo();
        TestDemo1 t1 = new TestDemo1();
        Banking b = new Banking();

        [Test]
        public void TestMethod1()
        {
            int actual = t.add(3, 5);
            Assert.AreEqual(8, actual);
        }

        [Test]
        public void TestMethod2()
        {
            int actual = t1.add(3, 5);
            Assert.AreEqual(8, actual);
        }

        [Test]
        public void TestMethod3()
        {
            int actual = b.withdraw(5000);
            Assert.AreEqual(5000, actual);
        }

        [Test]
        public void TestMethod4()
        {
            int actual = b.withdraw(15000);
            Assert.AreEqual(0, actual);
        }

        [Test]
        public void TestMethod5()
        {
            int actual = b.deposit(3000);
            Assert.AreEqual(13000, actual);
        }

        [Test]
        public void TestMethod()
        {
            int actual = b.deposit(5000);
            Assert.AreEqual(15500, actual);
        }
    }
}

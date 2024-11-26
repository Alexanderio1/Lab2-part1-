using Lab2;
namespace TestLab2_part1_
{
    [TestClass]
    public class PasswordTests
    {
        Password p1 = new Password("Password123");
        Password p2 = new Password("Password2");
        [TestMethod]
        public void TestOperator1()
        {
            p1.value=(p1 - 'a').value;
            Assert.AreEqual("Password12a", p1.value);
        }
        [TestMethod]
        public void TestOperator2()
        {
            var res = p1 > p2;
            Assert.IsTrue(res);
        }
        [TestMethod]
        public void TestOperator3()
        {
            var res = p1 != p2;
            Assert.IsTrue(res);
        }
        [TestMethod]
        public void TestOperator4()
        {
            Assert.AreEqual("default", (++p1).value);
        }
        [TestMethod]
        public void TestOperator5() 
        {
            Assert.IsTrue(p2 ? true : false);
        }
    }
    [TestClass]
    public class ExtensionTest()
    {
        Password p2 = new Password("Password2");
        [TestMethod]
        public void TestExtension1()
        {
            Assert.AreEqual('w', p2.value.Highlighter());
        }
        [TestMethod]
        public void TestExtension2()
        {
            Assert.AreEqual("Пароль имеет допустимую длину", p2.CheckPassword());
        }
    }
}
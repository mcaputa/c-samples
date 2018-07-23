namespace Singleton
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
   

    [TestClass]
    public class Test
    {
        [TestMethod]
        public void SingletonTest()
        {
            var singleton1 = Singleton.Instance;
            var singleton2 = Singleton.Instance;

           Assert.AreEqual(singleton2, singleton1);
        }
    }
}

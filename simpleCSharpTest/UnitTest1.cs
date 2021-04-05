using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimpleCSharpTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            SimpleLibCSharpProject.Class1 a = new SimpleLibCSharpProject.Class1();
            if (!a.function1().Equals("function1"))
                Assert.Fail("function1 doesn't return string 'function1'");
        }

        [TestMethod]
        public void TestMethod2()
        {
            SimpleLibCSharpProject.Class1 a = new SimpleLibCSharpProject.Class1();
            if (!a.function2("wow").Equals("wow"))
                Assert.Fail("function2 doesn't return string 'wow'");
        }

        [TestMethod]
        public void TestMethod3()
        {
            SimpleLibCSharpProject.Class1 a = new SimpleLibCSharpProject.Class1();
            if (a.function2("a").Equals("a"))
                Assert.Inconclusive("skipped");
        }


        [TestMethod]
        public void TestMethod4()
        {
            SimpleLibCSharpProject.Class1 a = new SimpleLibCSharpProject.Class1();
            if (!a.function2("a").Equals("b"))
                Assert.Fail("failed");
        }
    }
}

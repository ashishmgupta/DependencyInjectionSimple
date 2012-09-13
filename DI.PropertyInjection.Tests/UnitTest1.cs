using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DI.PropertyInjection.Tests.Test_Doubles;
using DI.PropertyInjection.Dependents;

namespace DI.PropertyInjection.Tests
{
    /// <summary>
    /// Summary description for UnitTest1
    /// </summary>
    [TestClass]
    public class UnitTest1
    {
        public UnitTest1()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void TestMethod1()
        {
            string expected = "God - loves - you.";
            TestDependency1 testDependency1 = new TestDependency1();
            TestDependency2 testDependency2 = new TestDependency2();
            TestDependency3 testDependency3 = new TestDependency3();
            Dependent dependent = new Dependent();
            dependent.IDependency1 = new TestDependency1();
            dependent.IDependency2 = new TestDependency2();
            dependent.IDependency3 = new TestDependency3();
            string actual = dependent.DoSomeATestWorkWithPropertyInjection();
            Assert.AreEqual(expected, actual);
        }
    }
}

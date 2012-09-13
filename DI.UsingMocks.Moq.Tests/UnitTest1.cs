using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using DI.UsingMocks.Moq.Interfaces;
using DI.UsingMocks.Moq.Dependents;

namespace DI.UsingMocks.Moq.Tests
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
        public void DoSomeATestWorkWithMoq_NoParametersOnDependencies_Test()
        {
            string expected = "God - is - great.";
            Mock<IDependency1> mockDependency1 = new Mock<IDependency1>();
            Mock<IDependency2> mockDependency2 = new Mock<IDependency2>();
            Mock<IDependency3> mockDependency3 = new Mock<IDependency3>();

            mockDependency1.Setup(d1=>d1.Dependency1Method()).Returns("God");
            mockDependency2.Setup(d2=>d2.Dependency2Method()).Returns("is");
            mockDependency3.Setup(d3=>d3.Dependency3Method()).Returns("great.");
            Dependent dependent = new Dependent(mockDependency1.Object, mockDependency2.Object, mockDependency3.Object);
            string actual = dependent.DoSomeATestWorkWithMoq();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DoSomeATestWorkWithMoq_ParameterOnDependency_Test()
        {
            string expected = "[God] - is - great.";
            Mock<IDependency1> mockDependency1 = new Mock<IDependency1>();
            Mock<IDependency2> mockDependency2 = new Mock<IDependency2>();
            Mock<IDependency3> mockDependency3 = new Mock<IDependency3>();

            mockDependency1.Setup(d1 => d1.Dependency1Method(It.IsAny<string>(), It.IsAny<string>())).Returns("[God]");
            mockDependency2.Setup(d2 => d2.Dependency2Method()).Returns("is");
            mockDependency3.Setup(d3 => d3.Dependency3Method()).Returns("great.");

            Dependent dependent = new Dependent(mockDependency1.Object, mockDependency2.Object, mockDependency3.Object);
            string actual = dependent.DoSomeATestWorkWithMoq("[", "]");
            Assert.AreEqual(expected, actual);
        }
    }
}

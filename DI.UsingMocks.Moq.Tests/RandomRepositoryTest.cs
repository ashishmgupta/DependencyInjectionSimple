using DI.UsingMocks.Moq.Dependents;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Moq;
using DI.UsingMocks.Moq.Interfaces;
using DI.UsingMocks.Moq.Dependencies;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;

namespace DI.UsingMocks.Moq.Tests
{
    
    
    /// <summary>
    ///This is a test class for RandomRepositoryTest and is intended
    ///to contain all RandomRepositoryTest Unit Tests
    ///</summary>
    [TestClass()]
    public class RandomRepositoryTest
    {


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
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for OneStaticFactoryMethod
        ///</summary>
        [TestMethod()]
        public void RandomRepositoryMethodTest_UsingPropertyInjection()
        {
            Guid idValue = new Guid("73592249-AD57-4CDF-B5FC-9C30F65C2376");
            string nameValue = "test";
            var dataAccess = new Mock<IDataAccess>();
            IDataAccess actualDataAccess = new DataAccess();
            dataAccess.Setup(a => a.CreateParameter(It.IsAny<string>(), It.IsAny<SqlDbType>(), It.IsAny<object>()))
                .Returns<string, SqlDbType, object>((name, type, value) => actualDataAccess.CreateParameter(name, type, value));

            RandomRepository.DataAccessObject = dataAccess.Object;
            RandomRepository.RandomRepositoryMethod(idValue, nameValue);
            dataAccess.Verify(
                d => d.ExecuteNonQuery(It.IsAny<string>(), "SomeRandomTable_Insert", new DbParameter[]{
                    It.Is<SqlParameter>(p=>p.ParameterName == "@Id" && p.SqlDbType == SqlDbType.UniqueIdentifier && (Guid)p.Value == idValue),
                    It.Is<SqlParameter>(p=>p.ParameterName == "@Name" && p.SqlDbType == SqlDbType.NVarChar && (string)p.Value == nameValue)}
                    ), Times.Once());
        }

        /// <summary>
        ///A test for OneStaticFactoryMethod
        ///</summary>
        [TestMethod()]
        public void RandomRepositoryMethodTest_UsingMethodInjection()
        {
            Guid idValue = new Guid("73592249-AD57-4CDF-B5FC-9C30F65C2376");
            string nameValue = "test";
            var dataAccess = new Mock<IDataAccess>();
            IDataAccess actualDataAccess = new DataAccess();
            dataAccess.Setup(a => a.CreateParameter(It.IsAny<string>(), It.IsAny<SqlDbType>(), It.IsAny<object>()))
                .Returns<string, SqlDbType, object>((name, type, value) => actualDataAccess.CreateParameter(name, type, value));

            RandomRepository.RandomRepositoryMethod(idValue, nameValue, dataAccess.Object);
            dataAccess.Verify(
                d => d.ExecuteNonQuery(It.IsAny<string>(), "SomeRandomTable_Insert", new DbParameter[]{
                    It.Is<SqlParameter>(p=>p.ParameterName == "@Id" && p.SqlDbType == SqlDbType.UniqueIdentifier && (Guid)p.Value == idValue),
                    It.Is<SqlParameter>(p=>p.ParameterName == "@Name" && p.SqlDbType == SqlDbType.NVarChar && (string)p.Value == nameValue)}
                    ), Times.Once());
        }
    }
}

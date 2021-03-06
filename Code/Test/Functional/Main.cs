﻿using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Globalization;
using CUBRID.Data.CUBRIDClient;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test.Functional
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
         [ClassInitialize()]
         public static void MyClassInitialize(TestContext testContext) 
         {
             TestCases.Test_init();
         }
        //
         //Use ClassCleanup to run code after all tests in a class have run
         [ClassCleanup()]
         public static void MyClassCleanup() 
         {
             TestCases.Test_dinit();
         }
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
        public void TestMethodCommon()
        {
            //
            // TODO: Add test logic here
            // Test case:78
            TestCases.Run();
        }
        [TestMethod]
        public void TestMethodSequence()
        {
            //
            // TODO: Add test logic here
            // Test case:15
            TestCases.TestSequenceRun();
        }

        [TestMethod]
        public void TestBeginDbTransaction()
        {
            //
            // TODO: Add test logic here
            //
            Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("en");

            TestCases.Test_dinit();
            TestCases.Test_BeginDbTransaction();
            TestCases.Test_init();
        }
        [TestMethod]
        public void TestCUBRIDConnectionRun()
        {
            //
            // TODO: Add test logic here
            //
            TestCases.CUBRIDConnectionRun();
            TestCases.TestCUBRIDMetaDataRun();
            TestCases.TestCUBRIDDataReaderRun();
            TestCases.TestParameterRun();
            TestCases.TestIssueRun();
            TestCases.CUBRIDExceptionRun();
        }
    }
}

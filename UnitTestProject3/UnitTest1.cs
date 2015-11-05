using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Integration_Testing;
namespace UnitTestProject3
{
    [TestClass]
    public class UnitTest1
    {
        /* 1.
        * Test Identifier:0.
        * Test Description: age is greater than 18
        * Method of Execution: Automated.
        * Input Data: 2015-1990.
        * Expected Output: 25.
        * Observed Output:  25.
        * Actions: No action is required.
        */
        [TestMethod]
        public void Test1()
        {
           int tday =2015;
            int dob =1990;
            //Act
            int result = Integration_Testing.Form1.findage(tday, dob);
            //Report
            Assert.AreEqual(25, result, "passed");

        }
        /* 2.
      * Test Identifier:2015,2010.
      * Test Description:  age is less than 18.
      * Method of Execution: Automated.
      * Input Data: 2015-2010.
      * Expected Output: 15.
      * Observed Output:  Infinity.
      * Actions: no action is required test is passed.
      */
        [TestMethod]
        public void Test2()
        {
            int tday = 2015;
            int dob = 2010;
            //Act
            int result = Integration_Testing.Form1.findage(tday, dob);
            //Report
            Assert.AreEqual(15, result, "passed");

        }
        /* 3.
      * Test Identifier:2015,2015.
      * Test Description:  current year.
      * Method of Execution: Automated.
      * Input Data: 2015-2015
      * Expected Output: 0.
      * Observed Output:  0.
      * Actions: 0
      */
        [TestMethod]
        public void Test3()
        {
            int tday = 2015;
            int dob = 2015;
            //Act
            int result = Integration_Testing.Form1.findage(tday, dob);
            //Report
            Assert.AreEqual(0, result, "cannot take smokes");

        }
    }
}

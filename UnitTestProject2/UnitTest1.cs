using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Integration_Testing;
namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
       
        /* 1.
         * Test Identifier:0.
         * Test Description:  age=18
         * Method of Execution: Automated.
         * Input Data: 1997.
         * Expected Output: 18.
         * Observed Output:  Test passed.
         * Actions:nothing
         */
        public void age_equal()
        { 
            int tday=2015;
            int dob =1997;
            int result = Integration_Testing.Form1.findage(tday, dob);
            Assert.AreEqual(18,result , "TEST PASSED");
        }
        /* 2.
         * Test Identifier:0.
         * Test Description:  age=20
         * Method of Execution: Automated.
         * Input Data: 1998.
         * Expected Output: 20.
         * Observed Output:  Test failed.
         * Actions:nothing
         */
          [TestMethod]
        public void age_less()
        {
            int tday = 2015;
            int dob = 1998;
            int result = Integration_Testing.Form1.findage(tday, dob);
            Assert.AreEqual(20, result, "TEST FAILED");
        }
          /* 3.
           * Test Identifier:0.
           * Test Description:  age=18
           * Method of Execution: Automated.
           * Input Data: 1976
           * Expected Output: 39.
           * Observed Output:  Test passed.
           * Actions:nothing
           */
          [TestMethod]
        public void age_more()
        {
            int tday = 2015;
            int dob = 1976;
            int result = Integration_Testing.Form1.findage(tday, dob);
            Assert.AreEqual(39, result, "TEST FAILED");
        }
        }
   }
    

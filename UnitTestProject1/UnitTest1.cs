using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Integration_Testing;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {


        /* 1.
         * Test Identifier:1999.
         * Test Description:  Find whether age is equal to 16
         * Method of Execution: Automated.
         * Input Data:2015-1999 .
         * Expected Output: 16.
         * Observed Output:  Test passed,Alcohol is not allowed in Germany.
         * Actions:nothing
         */
        [TestMethod]
        public void AgeisEqual()
        {
             int tdy = 2015;
            int dob = 1999;
            int result =Integration_Testing.Form1.findage(tdy, dob);
            Assert.AreEqual(16, result, "Alcohol is not allowed in Germany");
        }
         /* 2.
         * Test Identifier:1979.
         * Test Description: Find whether age is grater than 16 
         * Method of Execution: Automated.
         * Input Data: .
         * Expected Output: 36
         * Observed Output:  Test passed,Alcohol is Allowed in Germany.
         * Actions:nothing
         */
         [TestMethod]
         public void Ageisgreater()
         {
             int tdy = 2015;
             int dob = 1979;
             int result = Integration_Testing.Form1.findage(tdy, dob);
             Assert.AreEqual(36, result, "Alcohol is Allowed in Germany");
         }
         /* 3.
         * Test Identifier:1998
         * Test Description:  Find whether age is smaller than 16  
         
         * Method of Execution: Automated.
         * Input Data: .
         * Expected Output: 14.
         * Observed Output:  Test failed.
         * Actions:Change the expected value to 17
         */
         [TestMethod]
         public void Ageissmaller()
         {
             int tdy = 2015;
             int dob = 1998;
             int result = Integration_Testing.Form1.findage(tdy, dob);
             Assert.AreEqual(17, result, "Alcohol is not allowed in Germany");
         }
        }
    }


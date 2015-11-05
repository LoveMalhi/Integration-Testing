using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
        /* 1.
         * Test Identifier:0.
         * Test Description:  age=18
         * Method of Execution: Automated.
         * Input Data: .
         * Expected Output: 18.
         * Observed Output:  Test passed.
         * Actions:nothing
         */

        public void age_equal()
        {
             int i = 2015;
            int Age =1997;
            int result =
            Assert.AreEqual(50, result, "Test Passed");
        }
        }
    }
}

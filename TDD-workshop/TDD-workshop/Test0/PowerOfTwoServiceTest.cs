using NUnit.Framework;
using System;
using TDDWorkshop.Test2.Services;

namespace Tests
{
    public class PowerOfTwoServiceTest
    {
        public class TheTwoToThePowerOfMethod
        {
            #region Specification
            /* Specification: When given a number, return 2 to the power of that number */
            #endregion

            [TestCase(4)]
            [TestCase(5)]
            //[TestCase(6)]
            public void ReturnsCorrectResultWhenRaises2ToThePowerOf(int power)
            {
                #region Step1
                /* Create a service that manipulates the number */
                var powerOfTwoService = new PowerOfTwoService();
                #endregion

                #region Step2
                /* Invoke a method, and assert the result */
                var result = powerOfTwoService.RaiseTwoToThePowerOf(power);
                Assert.IsTrue(result == Math.Pow(2, power));
                #endregion
            }
        }
    }
}
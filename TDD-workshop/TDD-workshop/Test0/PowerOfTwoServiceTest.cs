using NUnit.Framework;
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

            [Test]
            public void Returns16WhenRaises2ToThePowerOf4()
            {
                #region Step1
                /* Create a service for reading a database */
                var powerOfTwoService = new PowerOfTwoService();
                #endregion

                #region Step2
                /* Invoke a method, and assert the result */
                var result = powerOfTwoService.RaiseTwoToThePowerOf(4);
                Assert.IsTrue(result == 16);
                #endregion
            }

            [Test]
            public void Returns32WhenRaises2ToThePowerOf5()
            {
                #region Step1
                /* Create a service for reading a database */
                var powerOfTwoService = new PowerOfTwoService();
                #endregion

                #region Step2
                /* Invoke a method, and assert the result */
                var result = powerOfTwoService.RaiseTwoToThePowerOf(5);
                Assert.IsTrue(result == 32);
                #endregion
            }
        }
    }
}
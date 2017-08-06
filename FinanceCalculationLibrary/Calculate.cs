using System;

namespace FinanceCalculationLibrary
{
    /// <summary>
    /// Static class containing financial calculations
    /// </summary>
    public static class Calculate
    {
        /// <summary>
        /// Calculates and returns the future value of an annuity with the specified principal, payment amount, interest, and number of periods
        /// </summary>
        /// <param name="principal">The principal</param>
        /// <param name="payment">The payment amount</param>
        /// <param name="interest">The interest rate</param>
        /// <param name="periods">The number of payment and interest accrual periods</param>
        /// <returns>The future value</returns>
        public static decimal FutureValue(decimal principal, decimal payment, decimal interest, decimal periods)
        {
            return principal * InterestFactor(interest, periods) + payment * (InterestFactor(interest, periods) - 1) / interest;
        }

        /// <summary>
        /// Calculates and returns the present value of an annuity with the specified principal, payment amount, interest, and number of periods
        /// </summary>
        /// <param name="principal">The principal</param>
        /// <param name="payment">The payment amount</param>
        /// <param name="interest">The interest rate</param>
        /// <param name="periods">The number of payment and interest accrual periods</param>
        /// <returns>The present value</returns>
        public static decimal PresentValue(decimal principal, decimal payment, decimal interest, decimal periods)
        {
            return FutureValue(principal, payment, interest, periods) / InterestFactor(interest, periods);
        }

        /// <summary>
        /// Calculates and returns the compound interest factor from the specified interest rate and number of periods
        /// </summary>
        /// <param name="interest">The interest rate</param>
        /// <param name="periods">The number of periods</param>
        /// <returns>The interest factor</returns>
        public static decimal InterestFactor(decimal interest, decimal periods)
        {
            return (decimal)Math.Pow((double)(1 + interest), (double)periods);
        }

        /// <summary>
        /// Calculates the payment amount necessary to pay off a loan with the speicifed principal and interest in the specified number of periods
        /// </summary>
        /// <param name="principal">The principal</param>
        /// <param name="interest">The interest rate</param>
        /// <param name="periods">The number of periods</param>
        /// <returns>The necessary payment amount</returns>
        public static decimal PaymentAmount(decimal principal, decimal interest, decimal periods)
        {
            return (principal * interest * InterestFactor(interest, periods)) / (InterestFactor(interest, periods) - 1);
        }
    }
}

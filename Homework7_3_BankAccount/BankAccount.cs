using System;
namespace Homework7_3_BankAccount
{
    public class BankAccount
    {
        public DateTime OpenDate { get; set; }
        public double InterestRate { get; set; }
        public double Balance { get; set; }

        private double DaysTotal()
        {
            DateTime currentDate = DateTime.Now;
            return (currentDate - OpenDate).TotalDays;
        }

        public void DaysTotalInfo()
        {
            Console.WriteLine($"Your account has been operating for {DaysTotal():0} days.");
        }

        private double BalanceWithInterest(int years)
        {
            double withInterest = Balance;
            for (int i = 0; i < years + 1; i++)
            {
                withInterest += withInterest * (InterestRate / 100);
            }
            return withInterest;
        }

        public void BalanceWithInterestInfo(int years)
        {
            Console.WriteLine($"Your current balance is {Balance} USD. In {years} years it will be {BalanceWithInterest(years):0.00} USD.");
        }
    }
}


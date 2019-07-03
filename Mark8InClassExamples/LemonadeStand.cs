using System;
using System.Collections.Generic;
using System.Text;

namespace Mark8InClassExamples
{
    public class LemonadeStand
    {
        public string Name { get; set; }
        public decimal TableCost { get; set; }
        public decimal ChairCost { get; set; }
        public decimal SignCost { get; set; }
        public decimal LemonsCostPerCup { get; set; }
        public decimal SugarCostPerCup { get; set; }
        public decimal PricePerCup { get; set; }

        private int numberOfCupsSold;
        public int NumberOfCupsSold
        {
            get
            {
                Console.WriteLine("Getting the value of NumberOfCupsSold");
                return numberOfCupsSold;
            }
            set
            {
                Console.WriteLine("Assigning a value to NumberOfCupsSold");
                numberOfCupsSold = value;
            }
        }

        public decimal GetTotalRevenue()
        {
            return NumberOfCupsSold * PricePerCup;
        }

        public decimal GetTotalExpenses()
        {
            return getFixedCosts() + getVariableCosts();
        }

        private decimal getFixedCosts()
        {
            return TableCost + ChairCost + SignCost;
        }

        private decimal getVariableCosts()
        {
            return (LemonsCostPerCup + SugarCostPerCup) * NumberOfCupsSold;
        }

        public decimal GetTotalProfit()
        {
            // We could do these 3 lines, or just the 1 line below them:
            //decimal totalRevenue = GetTotalRevenue();
            //decimal totalExpenses = GetTotalExpenses();
            //return totalRevenue - totalExpenses;
            return GetTotalRevenue() - GetTotalExpenses();
        }
    }
}

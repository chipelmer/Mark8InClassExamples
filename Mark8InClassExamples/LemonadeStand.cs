using System;
using System.Collections.Generic;
using System.Text;

namespace Mark8InClassExamples
{
    public class LemonadeStand
    {
        public LemonadeStand(string name)
        {
            if (name == null)
            {
                Name = "";
            }
            else
            {
                Name = name;
            }
        }

        public string Name { get; set; }
        public decimal PricePerCup { get; set; }
        public decimal CostPerCup { get; set; }
        public int NumberOfCupsSold { get; set; }

        public decimal GetTotalProfit()
        {
            return (PricePerCup - CostPerCup) * NumberOfCupsSold;
        }
    }
}

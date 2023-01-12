using System;
using System.Collections.Generic;
using System.Text;

namespace Working_With_Abstraction.Problem_4
{
    internal class PriceCalculator
    {
        private decimal pricePerDay;
        private int numberOfDays;
        private Season season;
        private Discount discount;

        public decimal PricePerDay { get => pricePerDay; set => pricePerDay=value; }
        public int NumberOfDays { get => numberOfDays; set => numberOfDays=value; }
        internal Season Season { get => season; set => season=value; }
        internal Discount Discount { get => discount; set => discount=value; }

        public PriceCalculator(decimal pricePerDay, int numberOfDays, Season season, Discount discount)
        {
            PricePerDay=pricePerDay;
            NumberOfDays=numberOfDays;
            Season=season;
            Discount=discount;
        }


     /*   public void Input()
        {
            Console.Write("Enter price per day: ");
            PricePerDay = decimal.Parse(Console.ReadLine());
            Console.Write("Enter number of days: ");
            NumberOfDays = int.Parse(Console.ReadLine());
            Console.Write("Chose season (Spring - Summer - Autumn - Winter): ");

            Console.Write("Chose discount type (None - SecondVisit - VIP):");

        }*/

        public static decimal Calculate(PriceCalculator myReserve)
        {
            int multiplier = (int)myReserve.season;
            decimal discountMultiplier = (decimal)myReserve.discount/100;
            decimal priceBeforeDiscount = myReserve.numberOfDays * myReserve.pricePerDay * multiplier;
            decimal discountedAmount = priceBeforeDiscount * discountMultiplier;
            decimal finalPrice = priceBeforeDiscount - discountedAmount;
            return finalPrice;
        }

    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculeInterest 
{
    public class VisaCard : ICards
    {
        private static decimal ActualBalance = 100;
        private static decimal InterestRate = 10;

        public decimal CalculateInterestByMonth()
        {
            return ActualBalance * InterestRate/100;
        }

        public decimal GetInterestCalculated()
        {
            return CalculateInterestByMonth();
        }

    }
}

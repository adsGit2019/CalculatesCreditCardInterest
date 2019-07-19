using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculeInterest
{
    public interface ICards
    {

        decimal CalculateInterestByMonth();

        decimal GetInterestCalculated();
        
    }
}

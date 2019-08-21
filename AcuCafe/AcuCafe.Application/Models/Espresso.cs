using AcuCafe.Application.Services.Abstract;

namespace AcuCafe.Application.Models
{
    public class Espresso : Drink, ICostService
    {
        public new double Cost()
        { 
            double cost = 1.8;

            if (HasMilk)
            {
                cost += Constants.Cost.MilkCost;
            }

            if (HasSugar)
            {
                cost += Constants.Cost.SugarCost;
            }

            return cost;
        }
    }
}

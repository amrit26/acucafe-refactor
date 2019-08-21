using AcuCafe.Application.Services.Abstract;

namespace AcuCafe.Application.Models
{
    public class Tea : Drink, ICostService
    {
        public string Description => Constants.Description.Tea;

        public new double Cost()
        {
            double cost = 1;

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

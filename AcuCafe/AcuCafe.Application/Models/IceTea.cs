using AcuCafe.Application.Services.Abstract;

namespace AcuCafe.Application.Models
{
    public class IceTea : Drink, ICostService
    {
        public string Description => Constants.Description.IceTea;

        public new double Cost()
        {
            double cost = 1.5;

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

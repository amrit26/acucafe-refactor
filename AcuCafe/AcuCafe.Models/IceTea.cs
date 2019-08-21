namespace AcuCafe.Models
{
    public class IceTea : Drink
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

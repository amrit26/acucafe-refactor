namespace AcuCafe.Models
{
    public class Espresso : Drink
    {
        public string Description => Constants.Description.Espresso;

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

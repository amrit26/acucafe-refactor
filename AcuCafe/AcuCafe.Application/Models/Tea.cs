namespace AcuCafe.Application.Models
{
    public class Tea : Drink
    {
        public override double Cost()
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

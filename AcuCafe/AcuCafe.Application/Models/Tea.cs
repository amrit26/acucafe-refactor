namespace AcuCafe.Application.Models
{
    public class Tea : Drink
    {
        public override double Cost()
        {
            double cost = 1;

            if (Preparation.HasMilk)
            {
                cost += Constants.Cost.MilkCost;
            }

            if (Preparation.HasSugar)
            {
                cost += Constants.Cost.SugarCost;
            }

            return cost;
        }
    }
}

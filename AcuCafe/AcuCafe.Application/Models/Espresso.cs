namespace AcuCafe.Application.Models
{
    public class Espresso : Drink
    {
        public override double Cost()
        { 
            double cost = 1.8;

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

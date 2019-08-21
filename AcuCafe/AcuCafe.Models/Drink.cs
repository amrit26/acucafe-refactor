namespace AcuCafe.Models
{
    public class Drink
    {
        public bool HasSugar { get; set; }
        public bool HasMilk { get; set; }

        public double Cost()
        {
            return 0;
        }
    }
}

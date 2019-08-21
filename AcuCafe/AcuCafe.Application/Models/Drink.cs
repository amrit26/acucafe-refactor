namespace AcuCafe.Application.Models
{
    public class Drink
    {
        public bool HasSugar { get; set; }
        public bool HasMilk { get; set; }

        public virtual double Cost()
        {
            return 0;
        }
    }
}

namespace AcuCafe.Application.Models
{
    public class Drink
    {
        public Preparation Preparation { get; set; }
        public virtual double Cost() => 0;
    }
}

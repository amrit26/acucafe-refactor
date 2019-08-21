using AcuCafe.Application.Services.Abstract;

namespace AcuCafe.Application.Models
{
    public class Drink : ICostService
    {
        public bool HasSugar { get; set; }
        public bool HasMilk { get; set; }

        public double Cost()
        {
            return 0;
        }
    }
}

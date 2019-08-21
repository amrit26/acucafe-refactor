using AcuCafe.Application.Builders.Abstract;
using AcuCafe.Application.Models;

namespace AcuCafe.Application.Builders.Concrete
{
    public class PreparationBuilder : IPreparationBuilder
    {
        public Preparation Build(string type, bool hasMilk, bool hasSugar, string description)
        {
            return new Preparation
            {
                Description = description,
                Drink = type,
                HasMilk = hasMilk,
                HasSugar = hasSugar
            };
        }
    }
}

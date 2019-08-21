using AcuCafe.Application.Models;

namespace AcuCafe.Application.Builders.Abstract
{
    public interface IPreparationBuilder
    {
        Preparation Build(string type, bool hasMilk, bool hasSugar, string description);
    }
}

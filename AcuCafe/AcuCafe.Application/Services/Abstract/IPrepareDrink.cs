namespace AcuCafe.Application.Services.Abstract
{
    public interface IPrepareDrink
    {
        void Prepare(string drink, string description, bool hasMilk, bool hasSugar);
    }
}

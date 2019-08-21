namespace AcuCafe.Application.Services.Abstract
{
    public interface IPrepareService
    {
        void Prepare(string drink, string description, bool hasMilk, bool hasSugar);
    }
}

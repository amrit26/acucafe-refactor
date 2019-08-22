using AcuCafe.Application.Models;

namespace AcuCafe.Application.Services.Abstract
{
    public interface IPrepareService
    {
        string Prepare(Preparation drinkPrep);
    }
}

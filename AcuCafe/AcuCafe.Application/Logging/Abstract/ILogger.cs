using System;

namespace AcuCafe.Application.Logging.Abstract
{
    public interface ILogger
    {
        void PreparationMessage(string message);
        void UnableToPrepareDrinkMessage(Exception ex);
    }
}

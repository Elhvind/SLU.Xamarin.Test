using SLU.ApiTest.Models.Wholesalers;
using System.Collections.Generic;

namespace SLU.ApiTest.Services.Interfaces
{
    public interface IWholesalerService
    {
        ICollection<WholesalerDTO> GetAllWholesalers();
        WholesalerDTO GetWholesaler(int id);
        int CreateWholesaler(WholesalerDTO item);
        bool UpdateWholesaler(int id, WholesalerDTO item);
        bool DeleteWholesaler(int id);
    }
}

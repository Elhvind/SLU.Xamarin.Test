using SLU.XamarinFormsTest.Models.Items;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SLU.XamarinFormsTest.Services
{
    public interface IItemsService
    {
        Task<ICollection<ItemDTO>> GetAll();
        Task<ItemDTO> Get(int id);
        Task<ItemDetailsDTO> GetDetails(int id);
    }
}
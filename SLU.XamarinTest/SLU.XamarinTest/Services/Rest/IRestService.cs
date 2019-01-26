using System.Collections.Generic;
using System.Threading.Tasks;

namespace SLU.XamarinTest.Services.Rest
{
    public interface IRestService
    {
        Task<List<T>> Get<T>(string url) where T : new();
    }
}
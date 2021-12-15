using System.Collections.Generic;
using System.Threading.Tasks;

namespace ShareService.ApiClient
{
    public interface IPeopleApiClient
    {
        Task<IEnumerable<Person>> GetAllPeople();
    }
}

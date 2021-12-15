using Microsoft.AspNetCore.Mvc;
using ShareService;
using ShareService.ApiClient;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Billing.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BillingController : ControllerBase
    {
        private readonly IPeopleApiClient _peopleApiClient;
        public BillingController(IPeopleApiClient peopleApiClient)
        {
            _peopleApiClient = peopleApiClient;
        }

        public async Task<ActionResult<IEnumerable<Person>>> GetPersons()
        {
            var persons = await _peopleApiClient.GetAllPeople();
            return Ok(persons);
        }
    }
}

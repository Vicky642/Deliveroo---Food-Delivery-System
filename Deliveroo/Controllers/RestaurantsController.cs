using Deliveroo.Models;
using Deliveroo.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Deliveroo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RestaurantsController : MainController<Restaurant, RestaurantRepository>
    {
        public RestaurantsController(RestaurantRepository repository) : base(repository)
        {

        }
    }
}

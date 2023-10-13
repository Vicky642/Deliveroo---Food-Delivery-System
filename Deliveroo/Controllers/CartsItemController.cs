using Deliveroo.Models;
using Deliveroo.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Deliveroo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartsItemController : MainController<CartItem, CartItemRepository>
    {
        public CartsItemController(CartItemRepository repository) : base(repository)
        {

        }
    }
}

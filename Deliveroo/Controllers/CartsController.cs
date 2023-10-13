using Deliveroo.Data;
using Deliveroo.Models;
using Deliveroo.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Deliveroo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartsController : MainController<Cart, CartRepository>
    {
        public CartsController(CartRepository repository) : base(repository)
        {

        }
    }
}

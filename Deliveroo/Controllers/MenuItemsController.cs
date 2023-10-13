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
    public class MenuItemsController : MainController<MenuItem, MenuItemRepository>
    {
         public MenuItemsController(MenuItemRepository repository) : base(repository)
    {

    }
}
}

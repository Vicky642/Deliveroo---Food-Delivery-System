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
    public class MenusController : MainController<Menu, MenuRepository>
    {
        public MenusController(MenuRepository repository) : base(repository)
        {

        }
    }
}

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
    public class UsersController : MainController<User, UserRepository>
    {
        public UsersController(UserRepository repository) : base(repository)
        {

        }
    }
}

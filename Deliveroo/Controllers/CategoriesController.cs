using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Deliveroo.Data;
using Deliveroo.Models;
using Deliveroo.Repository;

namespace Deliveroo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : MainController<Category, CategoryRepository>
    {
        public CategoriesController(CategoryRepository repository) : base(repository)
        {

        }
    }
}

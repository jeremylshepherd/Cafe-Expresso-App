using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CafeAPI.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CafeAPI.Controllers
{
    [Route("api/[controller]")]
    public class MenusController : Controller
    {
        private CafeDbContext _cafeDbContext;

        public MenusController(CafeDbContext cafeDbContext)
        {
            _cafeDbContext = cafeDbContext;
        }

        // GET: api/values
        [HttpGet]
        public IActionResult GetMenus()
        {
            var menus = _cafeDbContext.Menus.Include("SubMenus");
            return Ok(menus);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public IActionResult GetMenu(int id)
        {
            var menu = _cafeDbContext.Menus.Include("SubMenus").FirstOrDefault(x => x.Id == id);
            if (menu == null)
                return NotFound("The menu you seek was not found...");
            return Ok(menu);
        }
    }
}

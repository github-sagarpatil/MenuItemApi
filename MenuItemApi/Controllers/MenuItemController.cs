using MenuItemApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MenuItemApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MenuItemController : ControllerBase
    {
        List<MenuItem> m = new List<MenuItem>()
        {
                new MenuItem{Id=1,Name="Paneer Manchurian",Price=150,DateOfLaunch=new DateTime(2022,06,27),Active=true,FreeDelivery=true},
                new MenuItem{Id=2,Name="Chicken Fried Rice",Price=180,DateOfLaunch=new DateTime(2022,06,27),Active=true,FreeDelivery=false},
                new MenuItem{Id=3,Name="Chicken Lollipop",Price=200,DateOfLaunch=new DateTime(2022,06,27),Active=false,FreeDelivery=true}
        };

        [HttpGet]
        [ProducesResponseType(200)]
        public IActionResult Get()
        {

            return Ok(m);

        }
        [HttpGet("{id}")]
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        public IActionResult GetById(int id)
        {

            MenuItem i = m.SingleOrDefault(m => m.Id == id);
            if (i != null)
            {
                return Ok(i);
            }
            else
            {
                return NotFound();
            }

        }

    }
}

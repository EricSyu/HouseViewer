using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HouseViewer.Models;

namespace HouseViewer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HouseController : ControllerBase
    {
        private readonly SearchHouseAppContext searchHouseAppContext;

        public HouseController(SearchHouseAppContext searchHouseAppContext)
        {
            this.searchHouseAppContext = searchHouseAppContext;
        }

        [HttpGet("")]
        public ActionResult<IEnumerable<House>> GetHouses()
        {
            List<House> houses = searchHouseAppContext.Houses.ToList();
            return houses;
        }

        [HttpGet("{id}")]
        public ActionResult<House> GetHouseById(int id)
        {
            return null;
        }

        [HttpPost("")]
        public ActionResult<House> PostHouse(House model)
        {
            return null;
        }

        [HttpPut("{id}")]
        public IActionResult PutHouse(int id, House model)
        {
            return NoContent();
        }

        [HttpDelete("{id}")]
        public ActionResult<House> DeleteHouseById(int id)
        {
            return null;
        }
    }
}
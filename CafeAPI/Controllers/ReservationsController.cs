using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CafeAPI.Data;
using CafeAPI.Models;
using Microsoft.AspNetCore.Http;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CafeAPI.Controllers
{
    [Route("api/[controller]")]
    public class ReservationsController : Controller
    {

        private CafeDbContext _cafeDbContext;

        public ReservationsController(CafeDbContext cafeDbContext)
        {
            _cafeDbContext = cafeDbContext;
        }
        // GET: api/values
        [HttpGet]
        public IActionResult Get()
        {
            var reservations = _cafeDbContext.Reservations;
            return Ok(reservations);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public IActionResult Post([FromBody]ReservationModel reservation)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _cafeDbContext.Reservations.Add(reservation);
            _cafeDbContext.SaveChanges();
            return StatusCode(StatusCodes.Status201Created);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

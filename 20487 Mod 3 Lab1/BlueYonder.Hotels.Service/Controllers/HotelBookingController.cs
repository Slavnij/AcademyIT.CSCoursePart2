﻿using System.Threading.Tasks;
using DAL.Models;
using DAL.Repository;
using Microsoft.AspNetCore.Mvc;

namespace BlueYonder.Hotels.Service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HotelBookingController : ControllerBase
    {
        private HotelBookingRepository repo;
        public HotelBookingController()
        {
            repo = new HotelBookingRepository();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Booking>> Get(int id)
        {
            Booking booking = await repo.GetBooking(id);
            if (booking != null)
                return Ok(booking);
            else
                return NotFound();
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] Booking booking)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            Booking BookingDb = await repo.Add(booking);
            if (BookingDb != null)
                return Ok(BookingDb);
            else
                return StatusCode(500);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Booking>> Put(int id, [FromBody] Booking booking)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            Booking updatedBooking = await repo.Update(booking);
            return Ok(updatedBooking);
        }

    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CloudBnB.API.Data;
using CloudBnB.API.Models;

namespace CloudBnB.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocationsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public LocationsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Locations/GetAll
        [HttpGet]
        [Route("GetAll")]
        public async Task<IActionResult> GetLocations()
        {
            var locations = await this._context.Locations
                .Include(location => location.Landlord)
                .ToListAsync();

            return Ok(locations);
        }
    }
}

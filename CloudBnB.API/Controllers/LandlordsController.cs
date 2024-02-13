using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CloudBnB.API.Data;
using CloudBnB.API.Models;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CloudBnB.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LandlordsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public LandlordsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Landlords/GetAll
        [HttpGet]
        [Route("GetAll")]
        public async Task<IActionResult> GetLandlords()
        {
            var landlords = await this._context.Landlords
                .Include(landlord => landlord.Avatar)
                .ToListAsync();

            return Ok(landlords);
        }
    }
}

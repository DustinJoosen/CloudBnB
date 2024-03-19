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
using CloudBnB.API.Services.Interfaces;

namespace CloudBnB.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LandlordsController : ControllerBase
    {
        private readonly ILandlordRepository _landlordRepos;

        public LandlordsController(ILandlordRepository landlordRepos)
        {
            _landlordRepos = landlordRepos;
        }

        /// <summary>
        /// Returns a list of all landlords.
        /// </summary>
        [HttpGet]
        [Route("")]
        [Route("GetAll")]
        public async Task<IActionResult> GetLandlords()
        {
            var landlords = await _landlordRepos.GetAll();
            return Ok(landlords);
        }
    }
}

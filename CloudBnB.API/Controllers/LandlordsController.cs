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
            this._landlordRepos = landlordRepos;
        }

        // GET: api/Landlords/GetAll
        [HttpGet]
        [Route("")]
        [Route("GetAll")]
        public async Task<IActionResult> GetLandlords()
        {
            var landlords = await this._landlordRepos.GetAll();
            return Ok(landlords);
        }
    }
}

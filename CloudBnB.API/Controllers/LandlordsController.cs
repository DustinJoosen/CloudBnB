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

        /// <summary>
        /// Returns a list of all landlords.
        /// </summary>
        /// <param name="cancellationToken">Token to cancel execution</param>
        [HttpGet]
        [Route("")]
        [Route("GetAll")]
        public async Task<IActionResult> GetLandlords(CancellationToken cancellationToken)
        {
            var landlords = await this._landlordRepos.GetAll(cancellationToken);
            return Ok(landlords);
        }
    }
}

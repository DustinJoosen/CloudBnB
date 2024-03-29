﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CloudBnB.API.Data;
using CloudBnB.API.Models;
using CloudBnB.API.Services.Interfaces;
using CloudBnB.API.Services;
using CloudBnB.API.Dtos;
using AutoMapper;
using Asp.Versioning;

namespace CloudBnB.API.Controllers.V2
{
    [Route("api/Locations")]
    [ApiVersion("2.0")]
    [ApiExplorerSettings(GroupName = "v2")]
    [ApiController]
    public class LocationsController : ControllerBase
    {
        private readonly ILocationRepository _locationRepos;
        private readonly IMapper _mapper;

        public LocationsController(ILocationRepository locationRepos, IMapper mapper)
        {
            this._locationRepos = locationRepos;
            this._mapper = mapper;
        }

        /// <summary>
        /// Returns a list of all locations.
        /// </summary>
        /// <param name="cancellationToken">Token to cancel execution</param>
        [HttpGet]
        [Route("")]
        public async Task<IActionResult> GetLocations(CancellationToken cancellationToken)
        {
            var locations = await this._locationRepos.GetAll(cancellationToken);
            return Ok(this._mapper.Map<List<ExpandedLocationDto>>(locations));
        }
    }
}

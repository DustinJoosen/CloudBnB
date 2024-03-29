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

namespace CloudBnB.API.Controllers
{
    [Route("api/[controller]")]
    [ApiVersion("1.0")]
    [ApiExplorerSettings(GroupName = "v1")]
    [ApiController]
    public class LocationsController : ControllerBase
    {
        private readonly ILocationRepository _locationRepos;
        private readonly ISearchService _searchService;
        private readonly IImageService _imageService;
        private readonly IMapper _mapper;

        public LocationsController(ILocationRepository locationRepos,
            ISearchService searchService, IImageService imageService, IMapper mapper)
        {
            this._locationRepos = locationRepos;
            this._searchService = searchService;
            this._imageService = imageService;
            this._mapper = mapper;
        }

        /// <summary>
        /// Returns a list of all locations.
        /// </summary>
        /// <param name="cancellationToken">Token to cancel execution</param>
        [HttpGet]
        [Route("")]
        [Route("GetAll")]
        public async Task<IActionResult> GetLocations(CancellationToken cancellationToken)
        {
            var locations = await this._locationRepos.GetAll(cancellationToken);
            return Ok(this._mapper.Map<List<LocationDto>>(locations));
        }

        /// <summary>
        /// Returns the max price of any location.
        /// </summary>
        /// <param name="cancellationToken">Token to cancel execution</param>
        [HttpGet]
        [Route("GetMaxPrice")]
        public async Task<IActionResult> GetMaxPrice(CancellationToken cancellationToken)
        {
            var maxPrice = await this._locationRepos.GetMaxPrice(cancellationToken);
            return Ok(new MaxPriceDto { Price = maxPrice });
        }

        /// <summary>
        /// Searches for specified locations.
        /// </summary>
        /// <param name="search">Search parameters</param>
        /// <param name="cancellationToken">Token to cancel execution</param>
        [HttpPost]
        [Route("Search")]
        public async Task<IActionResult> Search([FromBody]SearchDto search, CancellationToken cancellationToken)
        {
            var locations = await this._searchService.Search(search, cancellationToken);
            return Ok(this._mapper.Map<List<ExpandedLocationDto>>(locations));
        }

        /// <summary>
        /// Returns detailed info about a specified location.
        /// </summary>
        /// <param name="locationId">Id of the location to find</param>
        /// <param name="cancellationToken">Token to cancel execution</param>
        [HttpGet]
        [Route("GetDetails/{locationId:int}")]
        public async Task<IActionResult> GetDetails([FromRoute]int? locationId, CancellationToken cancellationToken)
        {
            if (locationId == null)
                return NotFound();

            var location = await this._locationRepos.Details((int)locationId, cancellationToken);
            if (location == null)
                return NotFound();

            return Ok(this._mapper.Map<DetailedLocationDto>(location));
            
        }

        /// <summary>
        /// Returns a list of all unavailable dates for a specific location.
        /// </summary>
        /// <param name="locationId">Id of location to check</param>
        /// <param name="cancellationToken">Token to cancel execution</param>
        [HttpGet]
        [Route("UnAvailableDates/{locationId:int}")]
        public async Task<IActionResult> UnavailableDates([FromRoute]int? locationId, CancellationToken cancellationToken)
        {
            if (locationId == null)
                return NotFound();

            var locationExists = await this._locationRepos.Exists((int)locationId, cancellationToken);
            if (!locationExists)
                return NotFound();

            var unavailableDates = await this._locationRepos.UnavailableDates((int)locationId, cancellationToken);

            return Ok(new UnavailableDatesDto
            {
                UnAvailableDates = unavailableDates
            });
        }

        /// <summary>
        /// Uploads an image and links it to a location.
        /// </summary>
        /// <param name="image">Image to be uploaded</param>
        /// <param name="locationId">Location to link the image to</param>
        /// <param name="cancellationToken">Token to cancel execution</param>
        [HttpPost]
        [Route("Upload")]
        public async Task<IActionResult> Upload(IFormFile image, int? locationId, CancellationToken cancellationToken)
        {
            if (locationId == null || image == null)
                return BadRequest("Missing fields.");

            var locationExists = await this._locationRepos.Exists((int)locationId, cancellationToken);
            if (!locationExists)
                return NotFound();

            string? uri = await this._imageService.Upload(image, cancellationToken);
            if (uri == null)
                return BadRequest("Could not upload image");

            await this._locationRepos.AddImage((int)locationId, uri, cancellationToken);
            return Ok(uri);
        }
    }
}
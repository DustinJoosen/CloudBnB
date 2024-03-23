using System;
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
            _locationRepos = locationRepos;
            _searchService = searchService;
            _imageService = imageService;
            _mapper = mapper;
        }

        /// <summary>
        /// Returns a list of all locations.
        /// </summary>
        [HttpGet]
        [Route("")]
        [Route("GetAll")]
        public async Task<IActionResult> GetLocations()
        {
            var locations = await _locationRepos.GetAll();
            return Ok(_mapper.Map<List<LocationDto>>(locations));
        }

        /// <summary>
        /// Returns the max price of any location.
        /// </summary>
        [HttpGet]
        [Route("GetMaxPrice")]
        public async Task<IActionResult> GetMaxPrice()
        {
            var maxPrice = await _locationRepos.GetMaxPrice();
            return Ok(new MaxPriceDto { Price = maxPrice });
        }
        
        /// <summary>
        /// Searches for specified locations.
        /// </summary>
        /// <param name="search">Search parameters</param>
        [HttpPost]
        [Route("Search")]
        public async Task<IActionResult> Search([FromBody] SearchDto search)
        {
            var locations = await _searchService.Search(search);
            return Ok(_mapper.Map<List<ExpandedLocationDto>>(locations));
        }

        /// <summary>
        /// Returns detailed info about a specified location.
        /// </summary>
        /// <param name="locationId">Id of the location to find</param>
        [HttpGet]
        [Route("GetDetails/{locationId:int}")]
        public async Task<IActionResult> GetDetails([FromRoute]int? locationId)
        {
            if (locationId == null)
                return NotFound();

            var location = await this._locationRepos.Details((int)locationId);
            if (location == null)
                return NotFound();

            return Ok(_mapper.Map<DetailedLocationDto>(location));
            
        }

        /// <summary>
        /// Returns a list of all unavailable dates for a specific location
        /// </summary>
        /// <param name="locationId">Id of location to check</param>
        [HttpGet]
        [Route("UnAvailableDates/{locationId:int}")]
        public async Task<IActionResult> UnavailableDates([FromRoute]int? locationId)
        {
            if (locationId == null)
                return NotFound();

            var unavailableDates = await this._locationRepos.UnavailableDates((int)locationId);

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
        [HttpPost]
        [Route("Upload")]
        public async Task<IActionResult> Upload(IFormFile image, int locationId)
        {
            if (image == null)
                return BadRequest("Missing fields.");

            string? uri = await _imageService.Upload(image);
            if (uri == null)
                return BadRequest("Could not upload image");

            await _locationRepos.AddImage(locationId, uri);
            return Ok(uri);
        }
    }
}

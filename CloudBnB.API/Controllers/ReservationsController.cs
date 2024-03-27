using CloudBnB.API.Dtos;
using CloudBnB.API.Models;
using CloudBnB.API.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CloudBnB.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservationsController : ControllerBase
    {
        private readonly IReservationService _reservationService;

        public ReservationsController(IReservationService reservationService)
        {
            this._reservationService = reservationService;
        }

        /// <summary>
        /// Creates a reservation.
        /// </summary>
        /// <param name="reservationCreation">Reservation to create</param>
        /// <param name="cancellationToken">Token to cancel execution</param>
        [HttpPost]
        [Route("")]
        public async Task<IActionResult> Reserve([FromBody]ReservationCreationDto reservationCreation, CancellationToken cancellationToken)
        {
            if (!await this._reservationService.PeriodOfTimeFree(
                locationId: reservationCreation.LocationId, 
                startDate: reservationCreation.StartDate, 
                endDate: reservationCreation.EndDate,
                cancellationToken: cancellationToken))
            {
                return Conflict("This location is already reserved for this period");
            }

            var creationInfo = await this._reservationService.Reserve(reservationCreation, cancellationToken);
            return Ok(creationInfo);
        }
    }
}

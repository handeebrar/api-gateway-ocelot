using Microsoft.AspNetCore.Mvc;
using Reservation.Infrastructure;

namespace Reservation.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservationController
    {
        private readonly IReservationService reservationService;

        public ReservationController(IReservationService reservationService)
        {
            this.reservationService = reservationService;
        }

        [HttpGet("{id}")]
        public Models.Reservation Get(string id)
        {
            return reservationService.GetReservationById(id);
        }
    }
}
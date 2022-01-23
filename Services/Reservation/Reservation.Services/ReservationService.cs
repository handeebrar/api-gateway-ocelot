using System;
using Reservation.Infrastructure;

namespace Reservation.Services
{
    public class ReservationService : IReservationService
    {
        public Models.Reservation GetReservationById(string id)
        {
            return new Models.Reservation()
            {
                Id = id,
                TicketBarcode = (new Random().Next(100)),
                ReservationDate = DateTime.Now.Date.AddDays(5),
                Amount = (new Random().Next(5000)),
            };
        }
    }
}
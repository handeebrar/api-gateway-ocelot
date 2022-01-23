using System;

namespace Reservation.Models
{
    public class Reservation
    {
        public string Id { get; set; }
        public int TicketBarcode { get; set; }
        public DateTime? ReservationDate { get; set; }
        public double Amount { get; set; }
    }
}
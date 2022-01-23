namespace Reservation.Infrastructure
{
    public interface IReservationService
    {
        public Models.Reservation GetReservationById(string id);
    }
}
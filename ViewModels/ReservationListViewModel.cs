using RestRes.Models;

namespace RestRes.ViewModels
{
    public class ReservationListViewModel
    {
        public IEnumerable<Reservation>? Reservations { get; set; }
        public List<string> Restaurants = new List<string> { };
    }
}

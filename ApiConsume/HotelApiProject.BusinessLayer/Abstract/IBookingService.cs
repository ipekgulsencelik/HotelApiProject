using HotelApiProject.EntityLayer.Concrete;

namespace HotelApiProject.BusinessLayer.Abstract
{
    public interface IBookingService : IGenericService<Booking>
    {
        void TBookingStatusChangeApproved(int id);
    }
}

using HotelApiProject.EntityLayer.Concrete;

namespace HotelApiProject.DataAccessLayer.Abstract
{
    public interface IBookingDAL : IGenericDAL<Booking>
    {
        void BookingStatusChangeApproved(int id);
    }
}

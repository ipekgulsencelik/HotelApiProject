using HotelApiProject.BusinessLayer.Abstract;
using HotelApiProject.DataAccessLayer.Abstract;
using HotelApiProject.EntityLayer.Concrete;

namespace HotelApiProject.BusinessLayer.Concrete
{
    public class BookingManager : IBookingService
    {
        private readonly IBookingDAL _bookingDAL;

        public BookingManager(IBookingDAL bookingDAL)
        {
            _bookingDAL = bookingDAL;
        }

        public void TDelete(Booking entity)
        {
            _bookingDAL.Delete(entity);
        }

        public Booking TGetByID(int id)
        {
            return _bookingDAL.GetByID(id);
        }

        public List<Booking> TGetList()
        {
            return _bookingDAL.GetList();
        }

        public void TInsert(Booking entity)
        {
            _bookingDAL.Insert(entity);
        }

        public void TUpdate(Booking entity)
        {
            _bookingDAL.Update(entity);
        }
    }
}
using HotelApiProject.DataAccessLayer.Abstract;
using HotelApiProject.DataAccessLayer.Concrete.Repository;
using HotelApiProject.EntityLayer.Concrete;

namespace HotelApiProject.DataAccessLayer.Concrete.EntityFramework
{
    public class EFBookingDAL : GenericRepository<Booking>, IBookingDAL
    {
        public EFBookingDAL(Context context) : base(context)
        {
        }

        public void BookingStatusChangeApproved(int id)
        {
            var context = new Context();
            var values = context.Bookings.Find(id);
            values.Status = "Approved";
            context.SaveChanges();
        }
    }
}

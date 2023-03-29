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
    }
}

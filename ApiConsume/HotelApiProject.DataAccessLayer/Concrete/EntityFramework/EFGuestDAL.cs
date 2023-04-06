using HotelApiProject.DataAccessLayer.Abstract;
using HotelApiProject.DataAccessLayer.Concrete.Repository;
using HotelApiProject.EntityLayer.Concrete;

namespace HotelApiProject.DataAccessLayer.Concrete.EntityFramework
{
    public class EFGuestDAL : GenericRepository<Guest>, IGuestDAL
    {
        public EFGuestDAL(Context context) : base(context)
        {

        }
    }
}

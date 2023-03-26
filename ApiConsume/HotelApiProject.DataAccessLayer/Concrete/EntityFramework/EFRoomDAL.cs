using HotelApiProject.DataAccessLayer.Abstract;
using HotelApiProject.DataAccessLayer.Concrete.Repository;
using HotelApiProject.EntityLayer.Concrete;

namespace HotelApiProject.DataAccessLayer.Concrete.EntityFramework
{
    public class EFRoomDAL : GenericRepository<Room>, IRoomDAL
    {
        public EFRoomDAL(Context context) : base(context)
        {

        }
    }
}

using HotelApiProject.DataAccessLayer.Abstract;
using HotelApiProject.DataAccessLayer.Concrete.Repository;
using HotelApiProject.EntityLayer.Concrete;

namespace HotelApiProject.DataAccessLayer.Concrete.EntityFramework
{
    public class EFSubscribeDAL : GenericRepository<Subscribe>, ISubscribeDAL
    {
        public EFSubscribeDAL(Context context) : base(context)
        {
        }
    }
}

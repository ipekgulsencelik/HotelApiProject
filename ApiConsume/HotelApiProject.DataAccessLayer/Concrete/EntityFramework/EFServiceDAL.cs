using HotelApiProject.DataAccessLayer.Abstract;
using HotelApiProject.DataAccessLayer.Concrete.Repository;
using HotelApiProject.EntityLayer.Concrete;

namespace HotelApiProject.DataAccessLayer.Concrete.EntityFramework
{
    public class EFServiceDAL : GenericRepository<Service>, IServiceDAL
    {
        public EFServiceDAL(Context context) : base(context)
        {
        }
    }
}

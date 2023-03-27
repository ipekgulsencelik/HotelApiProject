using HotelApiProject.DataAccessLayer.Abstract;
using HotelApiProject.DataAccessLayer.Concrete.Repository;
using HotelApiProject.EntityLayer.Concrete;

namespace HotelApiProject.DataAccessLayer.Concrete.EntityFramework
{
    public class EFAboutDAL : GenericRepository<About>, IAboutDAL
    {
        public EFAboutDAL(Context context) : base(context)
        {
        }
    }
}

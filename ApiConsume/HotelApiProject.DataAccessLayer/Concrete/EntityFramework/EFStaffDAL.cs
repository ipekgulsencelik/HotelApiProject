using HotelApiProject.DataAccessLayer.Abstract;
using HotelApiProject.DataAccessLayer.Concrete.Repository;
using HotelApiProject.EntityLayer.Concrete;

namespace HotelApiProject.DataAccessLayer.Concrete.EntityFramework
{
    public class EFStaffDAL : GenericRepository<Staff>, IStaffDAL
    {
        public EFStaffDAL(Context context) : base(context)
        {
        }
    }
}

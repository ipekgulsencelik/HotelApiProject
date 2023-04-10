using HotelApiProject.DataAccessLayer.Abstract;
using HotelApiProject.DataAccessLayer.Concrete.Repository;
using HotelApiProject.EntityLayer.Concrete;

namespace HotelApiProject.DataAccessLayer.Concrete.EntityFramework
{
    public class EFWorkLocationDAL : GenericRepository<WorkLocation>, IWorkLocationDAL
    {
        public EFWorkLocationDAL(Context context) : base(context)
        {

        }
    }
}


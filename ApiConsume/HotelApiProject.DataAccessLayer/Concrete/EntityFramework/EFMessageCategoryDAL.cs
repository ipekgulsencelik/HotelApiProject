using HotelApiProject.DataAccessLayer.Abstract;
using HotelApiProject.DataAccessLayer.Concrete.Repository;
using HotelApiProject.EntityLayer.Concrete;

namespace HotelApiProject.DataAccessLayer.Concrete.EntityFramework
{
    public class EFMessageCategoryDAL : GenericRepository<MessageCategory>, IMessageCategoryDAL
    {
        public EFMessageCategoryDAL(Context context) : base(context)
        {

        }
    }
}

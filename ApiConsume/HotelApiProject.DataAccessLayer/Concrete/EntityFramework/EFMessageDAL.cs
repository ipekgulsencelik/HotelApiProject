using HotelApiProject.DataAccessLayer.Abstract;
using HotelApiProject.DataAccessLayer.Concrete.Repository;
using HotelApiProject.EntityLayer.Concrete;

namespace HotelApiProject.DataAccessLayer.Concrete.EntityFramework
{
    public class EFMessageDAL : GenericRepository<Message>, IMessageDAL
    {
        public EFMessageDAL(Context context) : base(context)
        {

        }

        public int GetMessageCount()
        {
            var context = new Context();

            return context.Messages.Count();
        }
    }
}

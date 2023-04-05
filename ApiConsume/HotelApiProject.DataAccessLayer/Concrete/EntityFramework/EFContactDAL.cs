using HotelApiProject.DataAccessLayer.Abstract;
using HotelApiProject.DataAccessLayer.Concrete.Repository;
using HotelApiProject.EntityLayer.Concrete;

namespace HotelApiProject.DataAccessLayer.Concrete.EntityFramework
{
    public class EFContactDAL : GenericRepository<Contact>, IContactDAL
    {
        public EFContactDAL(Context context) : base(context)
        {

        }

        public int GetContactCount()
        {
            var context = new Context();

            return context.Contacts.Count();
        }
    }
}

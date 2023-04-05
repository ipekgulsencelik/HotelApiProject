using HotelApiProject.EntityLayer.Concrete;

namespace HotelApiProject.DataAccessLayer.Abstract
{
    public interface IContactDAL : IGenericDAL<Contact>
    {
        public int GetContactCount();
    }
}

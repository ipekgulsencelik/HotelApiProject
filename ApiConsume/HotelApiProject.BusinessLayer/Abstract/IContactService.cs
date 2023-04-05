using HotelApiProject.EntityLayer.Concrete;

namespace HotelApiProject.BusinessLayer.Abstract
{
    public interface IContactService : IGenericService<Contact>
    {
        public int TGetContactCount();
    }
}

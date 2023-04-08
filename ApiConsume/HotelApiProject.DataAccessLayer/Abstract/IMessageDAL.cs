using HotelApiProject.EntityLayer.Concrete;

namespace HotelApiProject.DataAccessLayer.Abstract
{
    public interface IMessageDAL : IGenericDAL<Message>
    {
        public int GetMessageCount();
    }
}

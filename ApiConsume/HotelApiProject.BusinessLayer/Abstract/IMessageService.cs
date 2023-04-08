using HotelApiProject.EntityLayer.Concrete;

namespace HotelApiProject.BusinessLayer.Abstract
{
    public interface IMessageService : IGenericService<Message>
    {
        public int TGetMessageCount();
    }
}

using HotelApiProject.BusinessLayer.Abstract;
using HotelApiProject.DataAccessLayer.Abstract;
using HotelApiProject.EntityLayer.Concrete;

namespace HotelApiProject.BusinessLayer.Concrete
{
    public class MessageManager : IMessageService
    {
        private readonly IMessageDAL _messageDAL;

        public MessageManager(IMessageDAL messageDAL)
        {
            _messageDAL = messageDAL;
        }

        public void TDelete(Message entity)
        {
            _messageDAL.Delete(entity);
        }

        public Message TGetByID(int id)
        {
            return _messageDAL.GetByID(id);
        }

        public List<Message> TGetList()
        {
            return _messageDAL.GetList();
        }

        public int TGetMessageCount()
        {
            return _messageDAL.GetMessageCount();
        }

        public void TInsert(Message entity)
        {
            _messageDAL.Insert(entity);
        }

        public void TUpdate(Message entity)
        {
            _messageDAL.Update(entity);
        }
    }
}

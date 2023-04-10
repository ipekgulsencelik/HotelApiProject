using HotelApiProject.BusinessLayer.Abstract;
using HotelApiProject.DataAccessLayer.Abstract;
using HotelApiProject.EntityLayer.Concrete;

namespace HotelApiProject.BusinessLayer.Concrete
{
    public class MessageCategoryManager : IMessageCategoryService
    {
        private readonly IMessageCategoryDAL _messageCategoryDAL;

        public MessageCategoryManager(IMessageCategoryDAL messageCategoryDAL)
        {
            _messageCategoryDAL = messageCategoryDAL;
        }

        public void TDelete(MessageCategory entity)
        {
            _messageCategoryDAL.Delete(entity);
        }

        public MessageCategory TGetByID(int id)
        {
            return _messageCategoryDAL.GetByID(id);
        }

        public List<MessageCategory> TGetList()
        {
            return _messageCategoryDAL.GetList();
        }

        public void TInsert(MessageCategory entity)
        {
            _messageCategoryDAL.Insert(entity);
        }

        public void TUpdate(MessageCategory entity)
        {
            _messageCategoryDAL.Update(entity);
        }
    }
}

using HotelApiProject.BusinessLayer.Abstract;
using HotelApiProject.DataAccessLayer.Abstract;
using HotelApiProject.EntityLayer.Concrete;

namespace HotelApiProject.BusinessLayer.Concrete
{
    public class GuestManager : IGuestService
    {
        private readonly IGuestDAL _guestDAL;

        public GuestManager(IGuestDAL guestDAL)
        {
            _guestDAL = guestDAL;
        }

        public void TDelete(Guest entity)
        {
            _guestDAL.Delete(entity);
        }

        public Guest TGetByID(int id)
        {
            return _guestDAL.GetByID(id);
        }

        public List<Guest> TGetList()
        {
            return _guestDAL.GetList();
        }

        public void TInsert(Guest entity)
        {
            _guestDAL.Insert(entity);
        }

        public void TUpdate(Guest entity)
        {
            _guestDAL.Update(entity);
        }
    }
}

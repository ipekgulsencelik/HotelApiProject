using HotelApiProject.BusinessLayer.Abstract;
using HotelApiProject.DataAccessLayer.Abstract;
using HotelApiProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelApiProject.BusinessLayer.Concrete
{
    public class ContactManager : IContactService
    {
        private readonly IContactDAL _contactDAL;

        public ContactManager(IContactDAL contactDAL)
        {
            _contactDAL = contactDAL;
        }

        public void TDelete(Contact entity)
        {
            throw new NotImplementedException();
        }

        public Contact TGetByID(int id)
        {
            return _contactDAL.GetByID(id);
        }

        public int TGetContactCount()
        {
            return _contactDAL.GetContactCount();
        }

        public List<Contact> TGetList()
        {
            return _contactDAL.GetList();
        }

        public void TInsert(Contact entity)
        {
            _contactDAL.Insert(entity);
        }

        public void TUpdate(Contact entity)
        {
            throw new NotImplementedException();
        }
    }
}

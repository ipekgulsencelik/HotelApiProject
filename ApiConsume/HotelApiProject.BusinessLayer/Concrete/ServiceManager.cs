using HotelApiProject.BusinessLayer.Abstract;
using HotelApiProject.DataAccessLayer.Abstract;
using HotelApiProject.EntityLayer.Concrete;

namespace HotelApiProject.BusinessLayer.Concrete
{
    public class ServiceManager : IServiceService
    {
        private readonly IServiceDAL _serviceDAL;

        public ServiceManager(IServiceDAL serviceDAL)
        {
            _serviceDAL = serviceDAL;
        }

        public void TDelete(Service entity)
        {
            _serviceDAL.Delete(entity);
        }

        public Service TGetByID(int id)
        {
            return _serviceDAL.GetByID(id);
        }

        public List<Service> TGetList()
        {
            return _serviceDAL.GetList();
        }

        public void TInsert(Service entity)
        {
            _serviceDAL.Insert(entity);
        }

        public void TUpdate(Service entity)
        {
            _serviceDAL.Update(entity);
        }
    }
}

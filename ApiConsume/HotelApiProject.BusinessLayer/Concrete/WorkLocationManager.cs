using HotelApiProject.BusinessLayer.Abstract;
using HotelApiProject.DataAccessLayer.Abstract;
using HotelApiProject.EntityLayer.Concrete;

namespace HotelApiProject.BusinessLayer.Concrete
{
    public class WorkLocationManager : IWorkLocationService
    {
        private readonly IWorkLocationDAL _workLocationDAL;

        public WorkLocationManager(IWorkLocationDAL workLocationDAL)
        {
            _workLocationDAL = workLocationDAL;
        }

        public void TDelete(WorkLocation entity)
        {
            _workLocationDAL.Delete(entity);
        }

        public WorkLocation TGetByID(int id)
        {
            return _workLocationDAL.GetByID(id);
        }

        public List<WorkLocation> TGetList()
        {
            return _workLocationDAL.GetList();
        }

        public void TInsert(WorkLocation entity)
        {
            _workLocationDAL.Insert(entity);
        }

        public void TUpdate(WorkLocation entity)
        {
            _workLocationDAL.Update(entity);
        }
    }
}

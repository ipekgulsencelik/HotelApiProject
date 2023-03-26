﻿using HotelApiProject.BusinessLayer.Abstract;
using HotelApiProject.DataAccessLayer.Abstract;
using HotelApiProject.EntityLayer.Concrete;

namespace HotelApiProject.BusinessLayer.Concrete
{
    public class TestimonialManager : ITestimonialService
    {
        private readonly ITestimonialDAL _testimonialDAL;

        public TestimonialManager(ITestimonialDAL testimonialDAL)
        {
            _testimonialDAL = testimonialDAL;
        }

        public void TDelete(Testimonial entity)
        {
            _testimonialDAL.Delete(entity);
        }

        public Testimonial TGetByID(int id)
        {
            return _testimonialDAL.GetByID(id);
        }

        public List<Testimonial> TGetList()
        {
            return _testimonialDAL.GetList();
        }

        public void TInsert(Testimonial entity)
        {
            _testimonialDAL.Insert(entity);
        }

        public void TUpdate(Testimonial entity)
        {
            _testimonialDAL.Update(entity);
        }
    }
}

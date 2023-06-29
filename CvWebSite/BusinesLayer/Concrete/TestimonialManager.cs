using BusinesLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinesLayer.Concrete
{
    public class TestimonialManager : ITestimonialService
    {
        ITestimonialDal _testimonialDal;

        public TestimonialManager(ITestimonialDal testimonialDal)
        {
            _testimonialDal = testimonialDal;
        }

        public void TAdd(Testimonial t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Testimonial t)
        {
            throw new NotImplementedException();
        }

        public Testimonial TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Testimonial> TGetList()
        {
            return _testimonialDal.GetList();
        }

        public List<Testimonial> TGetListByFilter(string p)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Testimonial t)
        {
            throw new NotImplementedException();
        }
    }
}

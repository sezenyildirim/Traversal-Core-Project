using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace TraverselCoreApplication.ViewComponents.Default
{
    public class _Testimonial:ViewComponent
    {
        TestimonialManager _testimonialManager = new TestimonialManager(new EfTestimonialDal());
        public IViewComponentResult Invoke()
        {

            var values = _testimonialManager.TGetList();
            return View(values);
        }
    }
}

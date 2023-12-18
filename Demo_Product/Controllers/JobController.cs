using BusinessLayer.Concrete;
using BusinessLayer.FluentValidation;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Demo_Product.Controllers
{
    public class JobController : Controller
    {

        JobManager JobManager = new JobManager(new EfJobDal());

        public IActionResult Index()
        {
            var values = JobManager.TGetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddJob()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddJob(Job p)
        {

            JobManager.TInsert(p);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteJob(int id)
        {
            var value = JobManager.GetById(id);
            JobManager.TDelete(value);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateJob(int id)
        {
            var value = JobManager.GetById(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateJob(Job p)
        {
            JobManager.TUpdate(p);
            return View("Index");
        }
    }
}

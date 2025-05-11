using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarShop25.Controllers
{
    public class OrderCarController : Controller
    {
        // GET: OrderCarController1
        public ActionResult Index()
        {
            return View();
        }

        // GET: OrderCarController1/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: OrderCarController1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: OrderCarController1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: OrderCarController1/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: OrderCarController1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: OrderCarController1/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: OrderCarController1/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}

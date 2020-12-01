using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ZoNaN.Areas.Manager.Controllers
{
    public class ChekoutsController : Controller
    {
        // GET: ChekoutsController
        public ActionResult Index()
        {
            return View();
        }
        // GET: ChekoutsController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }
        // POST: ChekoutsController/Edit/5
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
        // POST: ChekoutsController/Delete/5
        [HttpPost]
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

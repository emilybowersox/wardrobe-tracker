using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WardrobeTracker.Controllers
{
    public class OutfitsController : Controller
    {
        // GET: OutfitsController
        public ActionResult Index()
        {
            return View();
        }

        // GET: OutfitsController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: OutfitsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: OutfitsController/Create
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

        // GET: OutfitsController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: OutfitsController/Edit/5
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

        // GET: OutfitsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: OutfitsController/Delete/5
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

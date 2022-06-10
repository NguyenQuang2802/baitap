using baitap.Data;
using baitap.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace baitap.Controllers
{
    public class SanPhamController : Controller
    {
        private readonly ApplicationDBContext _db;
        public SanPhamController(ApplicationDBContext db)
        {
            _db = db;
        }
        // GET: SanPhamController
        public ActionResult Index(string searchString = "")
        {
            var quer = from sp in _db.SanPhams
                       select sp;

            if (!String.IsNullOrEmpty(searchString))
            {
                quer = quer.Where(x => x.Tensp.Contains(searchString));
            }
            var q = quer.OrderBy(x => x.Idsp);


            return View("Index", q);
        }

        // POST: SanPhamController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(SanPham sanPham)
        {
             try
            {
                _db.SanPhams.Add(sanPham);
                _db.SaveChanges();
                return RedirectToAction("");
            }
            catch
            {
                return View();
            }
        }

        // GET: SanPhamController/Edit/5
        public ActionResult Edit(int Idsp)
        {
            var edit = _db.SanPhams.Find(Idsp);
            return View(edit);
        }

        // POST: SanPhamController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(SanPham sanPham)
        {
            try
            {
                var Edit = _db.SanPhams.Find(sanPham.Idsp);
                Edit.Tensp = sanPham.Tensp;
                Edit.Gianap = sanPham.Gianap;
                Edit.Giaban = sanPham.Giaban;
                Edit.Soluong = sanPham.Soluong;

                _db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
       
        // GET: SanPhamController/Delete/5
        public ActionResult Delete(int Idsp)
        {
            var Delete = _db.SanPhams.Find(Idsp);
            return View(Delete);
        }

        // POST: SanPhamController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(SanPham sanPham)
        {
            try
            {
                var Delete = _db.SanPhams.Find(sanPham.Idsp);
                _db.SanPhams.Remove(Delete);
                _db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}

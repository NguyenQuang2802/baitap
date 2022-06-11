using baitap.Data;
using baitap.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

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
                quer = quer.Where(x => x.TenSP.Contains(searchString));
            }
            var q = quer.OrderBy(x => x.IdSP);


            return View("Index", q);
        }
        public ActionResult Create()
        {
            return View();
        }
        // POST: SanPhamController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]/// bao mat ngan tan cong gia mao
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
        public ActionResult Edit(int idSP)
        {
            var edit = _db.SanPhams.Find(idSP);
            return View(edit);
        }

        // POST: SanPhamController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(SanPham sanPham)
        {
            try
            {
                var Edit = _db.SanPhams.Find(sanPham.IdSP);
                Edit.TenSP = sanPham.TenSP;
                Edit.GiaNhap = sanPham.GiaNhap;
                Edit.GiaBan = sanPham.GiaBan;
                Edit.SoLuong = sanPham.SoLuong;
                Edit.NgayNhap=sanPham.NgayNhap;
                Edit.NhaCC=sanPham.NhaCC;

                _db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: SanPhamController/Delete/5
        public ActionResult Delete(int idSP)
        {
            var Delete = _db.SanPhams.Find(idSP);
            return View(Delete);
        }

        // POST: SanPhamController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(SanPham sanPham)
        {
            try
            {
                var Delete = _db.SanPhams.Find(sanPham.IdSP);
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

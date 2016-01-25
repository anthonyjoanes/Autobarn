using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoBarn.WebUI.Data;
using AutoBarn.WebUI.Data.Entities;

namespace AutoBarn.WebUI.Areas.Admin.Controllers
{
    public class BlockDateController : Controller
    {
        private readonly IRepository<BlockDate> _blockDateRepository;

        public BlockDateController(IRepository<BlockDate> blockDateRepository)
        {
            _blockDateRepository = blockDateRepository;
        }

        // GET: Admin/BlockDate
        public ActionResult Index()
        {
            var blockDates = _blockDateRepository.GetAll().Where(x => x.Date >= DateTime.Now);
            return View(blockDates);
        }

        public ActionResult Add(DateTime? NewBlockDate)
        {
            if (NewBlockDate != null)
            {
                var newDate = new BlockDate {Date = NewBlockDate.Value};
                _blockDateRepository.Add(newDate);
                _blockDateRepository.Commit();
            }
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            var blockDate = _blockDateRepository.Find(id);

            if (blockDate != null)
            {
                _blockDateRepository.Delete(blockDate);
                _blockDateRepository.Commit();
            }
            

            return RedirectToAction("Index");
        }
    }
}
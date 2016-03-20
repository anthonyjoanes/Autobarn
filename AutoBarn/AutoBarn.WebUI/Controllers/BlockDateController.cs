using System;
using System.Linq;
using System.Web.Mvc;
using AutoBarn.WebUI.Data;
using AutoBarn.WebUI.Data.Entities;

namespace AutoBarn.WebUI.Controllers
{
    [Authorize]
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

        public ActionResult Add(DateTime? newBlockDate)
        {
            if (newBlockDate != null)
            {
                var newDate = new BlockDate {Date = newBlockDate.Value};
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
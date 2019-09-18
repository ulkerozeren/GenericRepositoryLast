using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using testRepository2.Interfaces;
using testRepository2.Models;

namespace testRepository2.Controllers
{
    public class PenController : Controller
    {
        private readonly IPenRepository _penRepository;
        public PenController(IPenRepository penRepository)
        {
            _penRepository = penRepository;
        }
        public IActionResult Index()
        {
            return View();
        }

        public JsonResult Add([FromQuery]Pen pen)
        {
            _penRepository.Add(pen);
            return new JsonResult(pen);
        }

        public JsonResult Update([FromBody]Pen pen)
        {
            var model=_penRepository.Update(pen);
            return new JsonResult(model);
        }

        public JsonResult Delete([FromQuery]int id)
        {
            var model=_penRepository.Delete(id);
            return new JsonResult(model);
        }

    }
}
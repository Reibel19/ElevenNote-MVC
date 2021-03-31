using ElevenNote.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ElevenNote.WebMVC.Controllers
{
    [Authorize]
    public class NoteController : Controller
    {
        // GET: Note
        // note/index
        public ActionResult Index()
        {
            var model = new NoteListItem[0];

            return View(model);
        }

        // get: note/create
        public ActionResult Create()
        {
            return View();
        }

        // post: note/create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(NoteCreate model)
        {
            if (ModelState.IsValid)
            {

            }
            return View(model);
        }
    }
}
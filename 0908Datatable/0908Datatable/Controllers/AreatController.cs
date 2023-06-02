using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _0908Datatable.Controllers
{
    public class AreatController : Controller
    {
        ALGCAMEntities1 algcam = new ALGCAMEntities1(); 
        // GET: Areat
        public ActionResult Index()
        {
            IEnumerable<SPM_Auto_Record_Log> area = algcam.SPM_Auto_Record_Log;
            return View(area);
        }
        public ActionResult Edit()
        {
            return View();
        }
        public ActionResult Delete()
        {
            return View();
        }
 
        public ViewResult Create()
        {
            ViewBag.LogList = algcam.SPM_Routing_TemplateInfo;
            return View();
        }
        [HttpPost]
        public ActionResult Create(SPM_Auto_Record_Log mode)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    algcam.SPM_Auto_Record_Log.Add(mode);
                    algcam.SaveChanges();
                    return RedirectToAction("Index");
                }
                catch (Exception)
                {
                    
                    ModelState.AddModelError("","Invalid operation");
                    return View();
                }
                
            }
            else
            {
                ModelState.AddModelError("","Invalid Data");
                return View();
            }
        
        }
        public ActionResult Details()
        {
            return View();
        }
        
    }
}
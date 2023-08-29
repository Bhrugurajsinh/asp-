using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Computer_Model.Models;

namespace Computer_Model.Controllers
{
    public class ComputerController : Controller
    {
        readonly Database db = new Database();
        // GET: Computer
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ViewAll()
        {
            

           

            //ComputerModel model = new ComputerModel();
            //model.Computer_Name = "Acer Nitro";
            //model.Computer_Price = "44000";
            //model.Document_Date = DateTime.Now;
            //model.OS = "Windows";
            //List<ComputerModel> comp = new List<ComputerModel>();
            //comp.Add(model);
            return View(db.Computers.ToList());
        }
    }
}
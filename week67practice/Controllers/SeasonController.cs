using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using week67practice.Models; //added 

namespace week67practice.Controllers
{
    public class SeasonController : Controller
    {
        // GET: /Season/Index
        // GET: /Season
        public ActionResult Index()
        {
            return View();
        }

        // POST: /Season/Show
        //Acquire information about the season and send it to Show.cshtml
       
        [HttpPost]
        public ActionResult Show(int? temperature)
        {
           

            //we will gather the seaon informaiotn from the temperature provided
            SeasonAPIController controller = new SeasonAPIController();
            
            Season SeasonInfo = controller.GetSeason(temperature);
            return View(SeasonInfo); 
            //pass along   the argument of our season info   
            //which is the season model that we had   just created.   
        }
    }

}
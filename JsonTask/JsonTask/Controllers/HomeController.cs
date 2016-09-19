using JsonTask.Models;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace JsonTask.Controllers
{


    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            PeopleViewModel peopleViewModel = new PeopleViewModel();
            using (WebClient wc = new WebClient())
            {
                var json = wc.DownloadString(" http://agl-developer-test.azurewebsites.net/people.json");
                //DeSeriloize the data
                var serializer = new JavaScriptSerializer();
                var lstData = serializer.Deserialize<List<People>>(json);
                var lstPeople = (from p in lstData where (p.Pets != null) && p.Pets.Any(x => x.Type == "Cat") select p).OrderBy(y => y.Name).ToList();

                peopleViewModel.Male = (from p in lstPeople where p.Gender == "Male" select p).ToList();
                peopleViewModel.Female = (from p in lstPeople where p.Gender == "Female" select p).ToList(); ;

            }
            return View(peopleViewModel);
        }
    }
}
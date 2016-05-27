
using Debugging_project.Models;
using Debugging_project.Utilities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web.Mvc;

namespace Debugging_project.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            ///https://channel9.msdn.com/Shows/Visual-Studio-Toolbox/Visual-Studio-Debugging-Tips-and-Tricks
            ///http://stackoverflow.com/questions/794255/how-do-you-use-the-immediate-window-in-visual-studio
            ///
            ///


            //Breakpoints, F5, F9, F10, F11, Shift+F11
            //Autos, Locals, Watch, and Immediate Window expressions and function calls and object comparison.
            var a = 10;
            var b = 15;
            var c = a + b;
            var d = 2;
           
            //Delete reference, show lightbulb
            
            //Show Returned function value in Autos/Locals, and Stepping into multiple functions
            var thing = Utilities1.doThings(Utilities1.multiplyThings(3, 4), Utilities1.multiplyThings(2, 5));



            //Show moving the current line
            int thing1 = 3;
            switch (thing1)
            {
                case 0:
                    a = 14;
                    break;
                case 1:
                    a = 15;
                    break;
                case 2:
                    b = 24;
                    break;
                default:
                    break;
            }

            List<OtherClass> oClasses = Utilities1.returnList();

            //Show Dropdown view, DebuggerDisplay, and pinned watches + comments e.g. (i = 0: oc = 1)
            //Breakpoints: Conditional && hit-count
            foreach (var oClass in oClasses) {
                var testInt = oClass.otherField;
                Debug.Assert(testInt != -1);
            }


            //Showcase Try/Catch
            IEnumerable<int> intEnum = null;

            try
            {
                intEnum.Last<int>(); 
            }
            catch (Exception e)
            {

            }


            //Showcase text/Json/XML visualizer
            var stringThing = Utilities1.returnJsonString();

            return View();
        }


        //Showcase FormCollection
        [HttpPost]
        public ActionResult Index(FormCollection model)
        {
            return View();
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public JsonResult makeSOmeJSON() {
            return Json(Utilities.Utilities1.returnList());
        }
    }
}
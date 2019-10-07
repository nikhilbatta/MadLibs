using Microsoft.AspNetCore.Mvc;
using MadLibs.Models;
using System;

namespace MadLibs.Controllers
{
    public class HomeController : Controller
    {
        [Route("/form")]
        public ActionResult Form() {return View();}// call on function that will start form. 
        [Route("/madlib")]
      public ActionResult MadLib(string verb, string adjective, string verb2, string adjective2, string verb3, string noun, string nountwo)
      {
        NewMadLib mymadLib = new NewMadLib();
        mymadLib.Verb = verb;
        mymadLib.Adjective = adjective;
        mymadLib.Verb2 = verb2;
        mymadLib.Adjective2 = adjective2;
        mymadLib.Verb3 = verb3;
        mymadLib.Noun = noun;
        mymadLib.Nountwo = nountwo;
        return View(mymadLib);
      }
      [Route("/celebrity")]
      public ActionResult CelebrityTheme(string verb, string adjective, string verb2, string adjective2, string verb3, string noun, string nountwo)
      {
          NewMadLib mymadLib = new NewMadLib();
        mymadLib.Verb = verb;
        mymadLib.Adjective = adjective;
        mymadLib.Verb2 = verb2;
        mymadLib.Adjective2 = adjective2;
        mymadLib.Verb3 = verb3;
        mymadLib.Noun = noun;
        mymadLib.Nountwo = nountwo;
        return View(mymadLib);
      }
    }
}
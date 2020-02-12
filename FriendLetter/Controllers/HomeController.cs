using Microsoft.AspNetCore.Mvc;
using FriendLetter.Models;
namespace FriendLetter.Controllers
{
    public class HomeController : Controller
    {

        [Route("/hello")]
        public string Hello() { return "Hello friend!"; }

        [Route("/goodbye")]
        public string Goodbye() { return "Goodbye friend."; }

        [Route("/postcard")]
        public ActionResult Letter(string recipient, string sender, string noun, string verb, string adjective)
        {
            LetterVariable myLetterVariable = new LetterVariable();
            myLetterVariable.Recipient = "Lina";
            myLetterVariable.Sender = "Jasmine";
            myLetterVariable.Noun = "Dead Rat";
            myLetterVariable.Verb = "Yell";
            myLetterVariable.Adjective = "Angry";
            return View(myLetterVariable);
        }
        
        [Route("/form")]
        public ActionResult Form() { return View(); }
    }
}
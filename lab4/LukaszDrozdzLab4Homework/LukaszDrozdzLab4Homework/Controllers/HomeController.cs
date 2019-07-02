using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using LukaszDrozdzLab4Homework.Models;
using System.Net.Mail;

namespace LukaszDrozdzLab4Homework.Controllers
{
    public class HomeController : Controller
    {
       
        List<MemeViewModel> memes = new List<MemeViewModel>();
        public HomeController()
        {
            memes.Add(new MemeViewModel(0, "https://i1.jbzdy.pl/contents/2019/05/50bb1dee0b9e6b12c3243d1daec9a9ea.jpg", "Kim Jong Il", "That guy gives me creeps"));
            memes.Add(new MemeViewModel(1, "https://i1.jbzdy.pl/contents/2019/05/637c2de4dfa51648226fae707d9f0529.jpg", "Prezenty", "I love 'em gifts"));
            memes.Add(new MemeViewModel(2, "https://i1.jbzdy.pl/contents/2019/04/41ca4df8e0e7da57e41293f5fae4abf3.jpg", "Statek", "That stuff boi"));
        }

        /// <summary>
        /// Longest common substring
        /// </summary>
        /// <param name="s1"></param>
        /// <param name="s2"></param>
        /// <returns></returns>
        private int LCS(string s1, string s2)
        {
            string longer = s1.Length > s2.Length ?  s1 : s2;
            string shorter = s1.Length < s2.Length ? s1 : s2;
            longer = longer.ToLower();
            shorter = shorter.ToLower();
            int longestSubstring = 0;
            int j = 0;
            for(int i = 0; i < shorter.Length; i++)
            {
                j = 0;
                for (; j < shorter.Length && longer[i+j] == shorter[j]; j++) ;
                longestSubstring = j > longestSubstring ? j : longestSubstring;
            }
            return longestSubstring;
        }

        /// <summary>
        /// Home page
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// Present user with information about the page
        /// </summary>
        /// <returns></returns>
        public IActionResult About()
        {
            ViewBag.Description = "Your application description page.";
            return View();
        }

        /// <summary>
        /// Display all memes
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Browse()
        {
            ViewBag.Description = "Browse all memes";
            return View("DisplayMemes", memes);
        }


        /// <summary>
        /// Present user with meme with specific ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        public IActionResult FindByID(int id)
        {
            MemeViewModel selectedMeme = memes.Where(meme => meme.ID == id).First();
            ViewBag.Description = "Display meme by ID";
            return View("DisplayMeme", selectedMeme);
        }


        /// <summary>
        /// Present user with meme finding form
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult FindByDesc()
        {
            ViewBag.Description = "Find meme by description";
            return View();
        }

        /// <summary>
        /// Receive data and present memes sorted by description similarity
        /// </summary>
        /// <param name="meme"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult FindByDesc(MemeViewModel meme)
        {
            string description = meme.Description;

            //Compares two memes against external context
            int CompareMemes(MemeViewModel m1, MemeViewModel m2)
            {
                description = description.ToLower();
                if (LCS(description, m1.Description) > LCS(description, m2.Description)) return -1;
                if (LCS(description, m1.Description) < LCS(description, m2.Description)) return 1;
                else return 0;
            }

            if (description == null)
            {
                ViewBag.ErrorMessage = "Please enter correct string";
                return View();
            }

            memes.Sort(CompareMemes);
            ViewBag.Description = "Memes matching \""+meme.Description+"\"";
            return View("DisplayMemes",memes);
        }
        
        /// <summary>
        /// Present user with meme suggestion form
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult SuggestNewMeme()
        {
            ViewBag.Description = "Suggest a new meme";
            return View();
        }

        /// <summary>
        /// Receive data and present user with confirmation
        /// </summary>
        /// <param name="memeSuggestionViewModel"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult SuggestNewMeme(MemeSuggestionViewModel memeSuggestionViewModel)
        {
         
            //Anti spam
            if(TempData["Suggested"]!=null && (bool)TempData["Suggested"] == true)
            {
                ViewBag.ErrorMessage = "You've already suggested a new meme";
                return View();
            }

            if(memeSuggestionViewModel.AuthorEmail == null)
            {
                ViewBag.ErrorMessage = "Please enter correct email";
                return View();
            }

            if(memeSuggestionViewModel.Description == null)
            {
                ViewBag.ErrorMessage = "Please enter correct description";
                return View();
            }

            if(memeSuggestionViewModel.Image == null)
            {
                ViewBag.ErrorMessage = "Please provide image url";
                return View();
            }

            if(memeSuggestionViewModel.Title == null)
            {
                ViewBag.ErrorMessage = "Please provide correct title";
                return View();
            }

            TempData["Suggested"] = true;
            ViewBag.Message = "Request sent. Thank you";
            Console.WriteLine("New meme suggestion:");
            Console.WriteLine("email:" + memeSuggestionViewModel.AuthorEmail);
            Console.WriteLine("url:" + memeSuggestionViewModel.Image);
            Console.WriteLine("Title:" + memeSuggestionViewModel.Title);
            Console.WriteLine("Description: " + memeSuggestionViewModel.Description);
            TempData.Keep();
            return View();
        }

        /// <summary>
        /// Present user with contact form
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Contact()
        {
            return View();
        }

        /// <summary>
        /// Get user data and do nothing ;>
        /// </summary>
        /// <param name="contactFormViewModel"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Contact(ContactFormViewModel contactFormViewModel)
        {
            //We don't save them requests :>
            return View("ContactThankYou",contactFormViewModel);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]

        ///<summary>
        ///Generate error
        ///</summary>
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

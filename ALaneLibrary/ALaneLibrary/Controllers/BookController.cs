using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ALaneLibrary.Controllers;
using ALaneLibrary.Models;
using ALaneLibrary.ViewModels;
using Microsoft.AspNetCore.Identity;

namespace ALaneLibrary.Controllers
{
    public class BookController : Controller
    {
        //private readonly ApplicatonDbContext _dbcontext;
        public BookController() 
        { 
        
        }
        public ActionResult Index()
        {
            var Books = new List<Book>()
            {
                new Book { Title = "C++ for Dummies"},
                new Book { Title = "Java for Scrubs"}
            };

            var Members = new List<Member>()
            {
                new Member { MemberName = "Alexis"},
                new Member { MemberName = "Dylan"}
            };

            var PassMemberViewModel = new MemberViewModel
            {
                BookCollection = Books,
                MemberList = Members
            };

            return View(PassMemberViewModel);
        }

        /*public ActionResult Create() {
            return View();
        }*/

    }
}
using biteknoLady.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace biteknoLady.ViewComponents
{
    public class CommentList : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var commentvalues = new List<UserComment>
            {
                new UserComment
                {
                    ID=1,
                    Username="Asel"
                },
                new UserComment
                {
                    ID=2,
                    Username="Betul"
                },
                new UserComment
                {
                    ID=3,
                    Username="Sehle"
                }
            };
            return View(commentvalues);
        }
    }
}

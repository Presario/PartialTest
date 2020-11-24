using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PartialTest.Pages
{
    public class vueModel : PageModel
    {
        public string Message { get; set; }
        public void OnGet()
        {
            Message = "OnGet ...";
        }

        public ActionResult OnPost(vueModel model)
        {
            return Page();
        }


    }
}

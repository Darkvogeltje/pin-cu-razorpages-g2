using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesDemo.Pages
{
    [BindProperties]
    public class ContactModel : PageModel
    {
        
        public string Name { get; set; }
        public string Email { get; set; }
        public string Message { get; set; }
        public string Feedback { get; set; }

        public void OnGet()
        {
        }

        public void OnPost()
        {
            Feedback = $"Thank you {Name} for your message. We will reply as soon as possible to {Email}";
        }
    }
}

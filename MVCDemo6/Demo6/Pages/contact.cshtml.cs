using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Demo6.Pages
{
    public class ContactModel:PageModel
    {
        [BindProperty]
        public int Id { get; set; }
        [BindProperty]
        public string Name { get; set; }

        public void OnGet()
        {
            Id = 10;
            Name = "alyaa";
        }
        public IActionResult OnPost()
        {
            
            return Page();
        }
        //public void OnPost(int id,string name)
        //{
        //    Id = id;
        //    Name = name;
        //}

    }
}

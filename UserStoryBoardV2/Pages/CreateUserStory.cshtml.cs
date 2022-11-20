using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Reflection;
using UserStoryBoard.Services;
using UserStoryProject.Models;

namespace UserStoryBoardV2.Pages
{
    public class CreateUserStoryModel : PageModel
    {
        private UserStoryService _userStoryService;
        //public IEnumerable<SelectListItem> StoryPoints { get; set; }

        //injected in the constructor
        public CreateUserStoryModel(UserStoryService service)
        {
            _userStoryService = service;

        }

        //bundet til felterne
        //først når jeg sender med min onpost
        [BindProperty] public UserStory US { get; set; }

        public List<UserStory> UserStories;

        public IActionResult OnGet()
        {
            return Page();
        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            _userStoryService.CreateUserStory(US);
            return RedirectToPage("UserStories");
        }

    }
}

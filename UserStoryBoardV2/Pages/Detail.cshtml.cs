using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using UserStoryBoard.Services;
using UserStoryProject.Models;

namespace UserStoryBoardV2.Pages
{
    public class DetailModel : PageModel
    {
        [BindProperty] public UserStory UserStory { get; set; }
        public List<UserStory> UserStories { get; private set; }
        private UserStoryService _userStoryService;


        public DetailModel(UserStoryService service)
        {
            _userStoryService = service;
        }

        public void OnGet(int id)
        {
            UserStories = _userStoryService.GetUserStories();
            UserStory = _userStoryService.GetUserStory(id);
        } 
    }
}

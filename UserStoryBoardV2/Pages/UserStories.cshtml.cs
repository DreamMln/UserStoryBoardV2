using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using UserStoryBoard.Services;
using UserStoryProject.Models;

namespace UserStoryBoardV2.Pages
{
    public class UserStoriesModel : PageModel
    {
        //injected UserStoryService
        private UserStoryService _userStoryService;

        public List<UserStory> UserStories { get; private set; }

        public UserStoriesModel(UserStoryService service)
        {
            _userStoryService = service;
        }

        public IActionResult OnGet()
        {
            UserStories = _userStoryService.GetUserStories();
            return Page();
        }

        public void OnGetMoveRight(int id)
        {
            _userStoryService.MoveRight(id);
            //?
            OnGet();
        }
        public void OnGetMoveLeft(int id)
        {
            _userStoryService.MoveLeft(id);
            //?
            OnGet();
        }


    }
}

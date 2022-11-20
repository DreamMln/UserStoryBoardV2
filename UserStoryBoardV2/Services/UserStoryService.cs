using UserStoryProject.Models;
using System.Threading.Tasks;
using UserStoryProject.MockData;
using System.Collections.Generic;

namespace UserStoryBoard.Services
{
    public class UserStoryService
    {
        public List<UserStory> userStories;

        //constructor initializes userStories by GetMockUserStories() from MockUserStories.
        public UserStoryService()
        {
            //JsonFileUserService = jsonFileUserService;
            //converter fra MockUserStories til json

            userStories = MockData.GetMockData();
            //userStories = jsonFileUserService.GetJsonUser().ToList();
        }

        //Get a userstory with the id
        public UserStory GetUserStory(int id)
        {
            foreach (UserStory userStory in userStories)
            {
                if (userStory.Id == id)
                    return userStory;
            }
            return null;
        }
        public List<UserStory> GetUserStories()
        {
            return userStories;
        }

        //add - create user story to the list
        //parameters, and arguments when we call the constructor.
        public void CreateUserStory(UserStory userStory)
        {
            userStories.Add(userStory);
        }

        public void MoveRight(int id)
        {
            //for at flytte user en story, henter vi den med dens id
            UserStory us = GetUserStory(id);
            //us ++ boardstatus
            us.BoardStatus++;
        }
        public void MoveLeft(int id)
        {
            //for at flytte user en story, henter vi den med dens id
            UserStory us = GetUserStory(id);
            //us ++ boardstatus
            us.BoardStatus--;
        }
    }
}

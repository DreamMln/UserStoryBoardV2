using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserStoryProject.Models;

namespace UserStoryProject.MockData
{
    public class MockData
    {
        private static List<UserStory> userStories = new List<UserStory>()
        {
            new UserStory("Make a user story list", "As a developer, I want to make a user story list. So that I can create user stories in a list. Acceptance Criteria: When the developer can add a list, and add a user story to that list.", 4, 1, "Large", UserStory.BoardOfStatus.ToDo),
            new UserStory("User Story Board", "kunne flytte en user story", 2, 1, "Large", UserStory.BoardOfStatus.ToDo),
            new UserStory("Add til listen", "Tilføje en user story til selve listen", 5, 3, "Large", UserStory.BoardOfStatus.Doing),
            new UserStory("Slet", "Slette en user story...",4, 4, "medium", UserStory.BoardOfStatus.Doing),
            new UserStory("Se en enkelt user story", "Kunne se en enkelt user story", 2, 5, "small", UserStory.BoardOfStatus.ToDo),
            new UserStory("Rediger", "Redigere en user story...", 3, 6, "Large", UserStory.BoardOfStatus.ToDo),
            new UserStory("Hvem laver hvad i opg.", "Kunne se hvem der er i færrd med opgaven", 3, 7, "medium", UserStory.BoardOfStatus.ToDo)
        };

        public static List<UserStory> GetMockData()
        {
            return userStories;
        }

    }
}

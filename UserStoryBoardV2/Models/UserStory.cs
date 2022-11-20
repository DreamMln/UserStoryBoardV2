using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UserStoryProject.Models
{
    public class UserStory
    {
        //enum, a group of constants, unchangable
        public enum BoardOfStatus
        {
            ToDo,
            Doing,
            Done,
        }

        public int Id { get; set; }
        //auto increment
        private static int NextId = 1;
        public string Title { get; set; }
        public string Description { get; set; }
        //Udvid
        public int BusinessValue { get; set; }
        public DateTime CreationDate { get; set; }
        public int Priority { get; set; }
        public string StoryPoints { get; set; }
        //ref, enum
        public BoardOfStatus BoardStatus { get; set; }


        //public string State { get; set; }

        public UserStory()
        {
            //Constructor - default, no parameters
        }

        public UserStory(string title, string description, int businessValue, int priority, string storyPoints, BoardOfStatus boardStatus)
        {
            Id = NextId++;
            Title = title;
            Description = description;
            BusinessValue = businessValue;
            CreationDate = DateTime.Now;
            Priority = priority;
            StoryPoints = storyPoints;
            BoardStatus = boardStatus;
            
        }

        public override string ToString()
        {
            return $"\nId: {Id} - Title: {Title} - Description: {Description} - BusinessValue: {BusinessValue} - Priority: {Priority} - StoryPoints: {StoryPoints}.";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject.Models
{
    public class Game
    {
        public Game(string name, string studioName, int yearRelease, float score, float storage, bool passed, string description, string[] genres)
        {
            Name = name;
            StudioName = studioName;
            Description = description;
            YearRelease = yearRelease;
            Score = score;
            Storage = storage;
            Passed = passed;
            Genres = genres;
        }

        public Game() { }


        public string Name { get; set; }
        public string StudioName { get; set; }
        public string Description { get; set; }

        public int YearRelease { get; set; }

        public float Score { get; set; }

        public float Storage { get; set; }

        public bool Passed { get; set; }

        public string[] Genres { get; set; }

        public string GetInfo()
        {
            return $"Name: {Name}\nStudio: {StudioName}\nYear: {YearRelease}\nScore: {Score}/10\nStorage: {Storage}\nPassed: {Passed}\nDescribtion:{Description}\n------------\n";
        }


        /// Властивість жанрів???
    }
}


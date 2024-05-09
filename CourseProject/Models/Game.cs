﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject.Models
{
    internal class Game
    {
        public Game(string name, string studioName, string description, int yearRelease, float score, float storage, bool passed)
        {
            Name = name;
            StudioName = studioName;
            Description = description;
            YearRelease = yearRelease;
            Score = score;
            Storage = storage;
            Passed = passed;
        }

        public string Name { get; set; }
        public string StudioName { get; set; }
        public string Description { get; set; }

        public int YearRelease { get; set; }

        public float Score { get; set; }

        public float Storage { get; set; }

        public bool Passed { get; set; }




        /// Властивість жанрів???
    }
}

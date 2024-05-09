using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject.Models
{

    public class GameLibrary<Game> : List<Game>
    {


        public GameLibrary()
        {
        }

        public GameLibrary<Game> Search(string nameInput, string studioInput, int yearInput, float scoreInput, float storageInput, bool passedInput)
        {
            GameLibrary<Game> searchedGames = new GameLibrary<Game>();

            foreach (Game game in this)
            {
            }

            return searchedGames
                ;
        }
    }
}

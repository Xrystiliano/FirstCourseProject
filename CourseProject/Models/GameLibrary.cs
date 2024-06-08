using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace CourseProject.Models
{

    public class GameLibrary : List<Game>
    {



        private static GameLibrary _instance;

        public static GameLibrary Instance
        {
            get { return _instance ?? (_instance = new GameLibrary()); }
        }



        public GameLibrary() { }


        public GameLibrary Search(string nameInput, string studioInput, int? yearInput, float? scoreInput, bool? scoreGreater, float? storageInput, bool? storageGreater, bool? passedInput, List<string> genresInput)
        {
            GameLibrary searchedGames = new GameLibrary();

            foreach (Game game in this)
            {
                bool matches = true;

                if (!string.IsNullOrWhiteSpace(nameInput) && !game.Name.Contains(nameInput, StringComparison.OrdinalIgnoreCase))
                {
                    matches = false;
                }

                if (!string.IsNullOrWhiteSpace(studioInput) && !game.StudioName.Contains(studioInput, StringComparison.OrdinalIgnoreCase))
                {
                    matches = false;
                }

                if (yearInput.HasValue && game.YearRelease != yearInput.Value)
                {
                    matches = false;
                }

                if (scoreInput.HasValue)
                {
                    if (scoreGreater.HasValue)
                    {
                        if (scoreGreater.Value && game.Score <= scoreInput.Value)
                        {
                            matches = false;
                        }
                        else if (!scoreGreater.Value && game.Score >= scoreInput.Value)
                        {
                            matches = false;
                        }
                    }
                    else if (game.Score != scoreInput.Value)
                    {
                        matches = false;
                    }
                }

                if (storageInput.HasValue)
                {
                    if (storageGreater.HasValue)
                    {
                        if (storageGreater.Value && game.Storage <= storageInput.Value)
                        {
                            matches = false;
                        }
                        else if (!storageGreater.Value && game.Storage >= storageInput.Value)
                        {
                            matches = false;
                        }
                    }
                    else if (game.Storage != storageInput.Value)
                    {
                        matches = false;
                    }
                }

                if (passedInput.HasValue && game.Passed != passedInput.Value)
                {
                    matches = false;
                }

                if (genresInput != null && genresInput.Count > 0)
                {
                    if (!genresInput.All(genre => game.Genres.Contains(genre, StringComparer.OrdinalIgnoreCase)))
                    {
                        matches = false;
                    }
                }

                if (matches)
                {
                    searchedGames.Add(game);
                }
            }

            return searchedGames;
        }

        public void SaveData(string PATH_DATA)
        {
            var jsonString = JsonSerializer.Serialize(this);
            File.WriteAllText(PATH_DATA, jsonString);
        }

        public GameLibrary LoadData(string PATH_DATA)
        {
            var jsonString = File.ReadAllText(PATH_DATA);
            return JsonSerializer.Deserialize<GameLibrary>(jsonString);
        }

        public void RemoveGame(Game game)
        {
            if (game != null && this.Contains(game))
            {
                this.Remove(game);
            }
        }
    }
}

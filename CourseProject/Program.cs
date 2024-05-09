using CourseProject.Forms;
using CourseProject.Models;

namespace CourseProject
{
    internal static class Program
    {
            /// <summary>
            ///  The main entry point for the application.
            /// </summary>
            [STAThread]
        static void Main()
        {

            Game Game1 = new Game("Dota 2", "Valve", "Dota 2 Ч компьютерна€ многопользовательска€ командна€ игра жанра стратеги€ в реальном времени с элементами компьютерной ролевой игры, реализаци€ известной карты DotA дл€ игры Warcraft III в отдельном клиенте.", 2013, 9.3f, 30, true);

            Game Game2 = new Game("The Witcher 3", "CD Projekt Red", "Open-world RPG", 2015, 9.5f, 50f, true);

            Game Game3 = new Game("Genshin Impact", "Mihuyo", "Gacha open-world casino", 2020, 0f, 80f, true);

            List<Game> GameLibrary = new List<Game>();

            GameLibrary.Add(Game1);
            GameLibrary.Add(Game2);
            GameLibrary.Add(Game3);

            foreach (Game game in GameLibrary)
            {
                game.PrintInfo();
                Console.WriteLine("------------------------");
            }

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());


        }
    }
}
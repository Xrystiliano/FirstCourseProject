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

            var Game1 = new Game("Dota 2", "Valve", "Dota 2 Ч компьютерна€ многопользовательска€ командна€ игра жанра стратеги€ в реальном времени с элементами компьютерной ролевой игры, реализаци€ известной карты DotA дл€ игры Warcraft III в отдельном клиенте.", 2013, 9.3f, 30, true);

            Console.WriteLine(Game1.Description);

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());


        }
    }
}
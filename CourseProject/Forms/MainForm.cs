using CourseProject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseProject.Forms
{
    public partial class MainForm : Form
    {
        List<Game> GameLibrary = new List<Game>
        {
            new Game("Game 1", "Studio A", "An action-packed adventure game.", 2021, 8.5f, 15.0f, true),
            new Game("Game 2", "Studio B", "A deep and engaging RPG.", 2020, 9.2f, 50.0f, false),
            new Game("Game 3", "Studio C", "An exciting racing game.", 2022, 7.8f, 20.0f, true),
            new Game("Game 4", "Studio D", "A survival horror game.", 2019, 8.0f, 25.0f, false),
            new Game("Game 5", "Studio E", "A strategy game with deep mechanics.", 2023, 9.0f, 30.0f, true),
            new Game("Game 6", "Studio F", "Fantasy MMORPG with expansive world.", 2018, 7.5f, 70.0f, false),
            new Game("Game 7", "Studio G", "A narrative-driven indie game.", 2021, 8.3f, 5.0f, true),
            new Game("Game 8", "Studio H", "A classic platformer revisited.", 2022, 8.1f, 10.0f, true),
            new Game("Game 9", "Studio I", "A challenging puzzle game.", 2019, 7.9f, 2.0f, false),
            new Game("Game 10", "Studio J", "An open-world sandbox game.", 2020, 9.5f, 80.0f, true),
            new Game("Game 11", "Studio K", "A fast-paced shooter.", 2023, 8.6f, 40.0f, false),
            new Game("Game 12", "Studio L", "A co-op adventure game.", 2021, 8.2f, 15.0f, true),
            new Game("Game 13", "Studio M", "A realistic simulation game.", 2018, 7.7f, 50.0f, false),
            new Game("Game 14", "Studio N", "A sci-fi space exploration game.", 2022, 9.1f, 60.0f, true),
            new Game("Game 15", "Studio O", "A historical grand strategy game.", 2020, 9.0f, 35.0f, false),
            new Game("Game 16", "Studio P", "A cyberpunk action game.", 2023, 8.8f, 70.0f, true),
            new Game("Game 17", "Studio Q", "A stealth-based espionage game.", 2019, 8.4f, 15.0f, false),
            new Game("Game 18", "Studio R", "A mobile puzzle game.", 2021, 7.6f, 0.5f, true),
            new Game("Game 19", "Studio S", "An arcade style racing game.", 2022, 8.0f, 30.0f, false),
            new Game("Game 20", "Studio T", "A VR exploration adventure.", 2023, 9.3f, 25.0f, true)
        };

        List<Game> SearchedGames = new List<Game>();


    public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void NameInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void StorageInput_Click(object sender, EventArgs e)
        {

        }

        private void ScoreLabel_Click(object sender, EventArgs e)
        {

        }

        private void LessStorage_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void BiggerScore_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            
        }
    }
}

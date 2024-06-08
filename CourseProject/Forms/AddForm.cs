using CourseProject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseProject.Forms
{
    public partial class AddForm : Form
    {

        private GameLibrary UserGames;
        public bool IsValidated = false;

        public AddForm(GameLibrary gameLibrary)
        {
            InitializeComponent();
            UserGames = gameLibrary;
        }

        public AddForm()
        {  }

        private void ScoreLabel_Click(object sender, EventArgs e)
        {

        }

        private void ConfirmAddButton_Click(object sender, EventArgs e)
        {

            if (NameInput.Text.Trim().Length == 0)
            {
                MessageBox.Show("Назва ігри не може бути пустою!");
                return;
            }

            if (StudioNameInput.Text.Trim().Length == 0)
            {

                MessageBox.Show("Назва студії-розробника не може бути пустою!");
                return;
            }

            bool isNumber = int.TryParse(YearReleaseInput.Text, out int year);
            if (!isNumber || year <= 1970 || year >= 2065)
            {
                MessageBox.Show("Некоректний рік випуску");
                return;
            }

            isNumber = int.TryParse(StorageInput.Text, out int maxstorage);
            if (!isNumber || maxstorage <= 1 || maxstorage >= 999)
            {
                MessageBox.Show("Некоректне місце на диску");
                return;
            }

            isNumber = int.TryParse(ScoreInput.Text, out int maxscore);
            if (!isNumber || maxscore < 0 || maxscore > 10)
            {
                MessageBox.Show("Некоректна оцінка");
                return;
            }
            
            if (!PassedNo.Checked && !PassedYes.Checked)
            {
                MessageBox.Show("Некоректна позначка пройшли/непройшли");
                return;
            }

            string genresInput = GenresInput.Text;
            string[] genres = genresInput.Split(new[] { ',', ';' }, StringSplitOptions.RemoveEmptyEntries)
                                         .Select(genre => genre.Trim())
                                         .ToArray();

            Game newGame = new Game
            {
                Name = NameInput.Text,
                StudioName = StudioNameInput.Text,
                YearRelease = Int32.Parse(YearReleaseInput.Text),
                Score = Int32.Parse(ScoreInput.Text),
                Storage = Int32.Parse(StorageInput.Text),
                Passed = PassedYes.Checked,
                Description = DescriptionInput.Text,
                Genres = genres,
        };

            UserGames.Add(newGame);

            MessageBox.Show("Гра успішно додана до бібліотеки!");
                Close();
        }
    }
}

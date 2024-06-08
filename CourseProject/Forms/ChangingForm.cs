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
using static System.Formats.Asn1.AsnWriter;

namespace CourseProject.Forms
{
    public partial class ChangingForm : Form
    {
        public delegate void GameChangedHandler(Game updatedGame);
        public event GameChangedHandler GameChanged;

        public Game game = new Game();

        private GameLibrary UserGames;
        public ChangingForm(Game game, GameLibrary gameLibrary)
        {
            InitializeComponent();

            this.game = game;

            NameInput.Text = game.Name;
            StudioNameInput.Text = game.StudioName;
            YearReleaseInput.Text = game.YearRelease.ToString();
            ScoreInput.Text = game.Score.ToString();
            StorageInput.Text = game.Storage.ToString();
            if (game.Passed)
            {
                PassedYes.Checked = true;
            }
            else
            {
                PassedNo.Checked = false;
            }
            GenresInput.Text = String.Join(", ", game.Genres);

            NameInput.ReadOnly = true;
            StudioNameInput.ReadOnly = true;
            YearReleaseInput.ReadOnly = true;
            ScoreInput.ReadOnly = true;
            StorageInput.ReadOnly = true;
            DescriptionInput.ReadOnly = true;
            GenresInput.ReadOnly = true;

            DescriptionInput.Text = game.Description;

            UserGames = gameLibrary;

        }



        private void ChangingForm_Load(object sender, EventArgs e)
        {

        }

        private void NameInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
                var result = MessageBox.Show("Ви впевнені, що хочете видалити цю гру?", "Підтвердження видалення", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    UserGames.RemoveGame(game);

                    MessageBox.Show("Гра успішно видалена!");
                    GameChanged?.Invoke(game);
                    Close();
                }
            }

        private void ChangeButton_Click(object sender, EventArgs e)
        {
            NameInput.ReadOnly = false;
            StudioNameInput.ReadOnly = false;
            YearReleaseInput.ReadOnly = false;
            ScoreInput.ReadOnly = false;
            StorageInput.ReadOnly = false;
            DescriptionInput.ReadOnly = false;
            PassedYes.Enabled = true;
            PassedNo.Enabled = true; 
            GenresInput.ReadOnly = false;


            ConfirmChangeButton.Enabled = true;
            ConfirmChangeButton.Visible = true;
        }

        private void ConfirmChangeButton_Click(object sender, EventArgs e)
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
                if (!isNumber || maxscore <= 0 || maxscore > 10)
                {
                    MessageBox.Show("Некоректна оцінка");
                    return;
                }

                if (!PassedNo.Checked && !PassedYes.Checked)
                {
                    MessageBox.Show("Некоректна позначка пройшли/непройшли");
                    return;
                }

               

                game.Name = NameInput.Text;
                game.StudioName = StudioNameInput.Text;
                game.YearRelease = Int32.Parse(YearReleaseInput.Text);
                game.Score = Int32.Parse(ScoreInput.Text);
                game.Storage = Int32.Parse(StorageInput.Text);
                game.Passed = PassedYes.Checked;
                game.Description = DescriptionInput.Text;
                string genresInput = GenresInput.Text;
                string[] genres = genresInput.Split(new[] { ',', ';' }, StringSplitOptions.RemoveEmptyEntries)
                                             .Select(genre => genre.Trim())
                                             .ToArray();
                game.Genres = genres;

                GameChanged?.Invoke(game);

            MessageBox.Show("Гра успішно змінена!");

            NameInput.ReadOnly = true;
            StudioNameInput.ReadOnly = true;
            YearReleaseInput.ReadOnly = true;
            ScoreInput.ReadOnly = true;
            StorageInput.ReadOnly = true;
            DescriptionInput.ReadOnly = true;
            PassedYes.Enabled = false;
            PassedNo.Enabled = false;
            GenresInput.ReadOnly = true;
            ConfirmChangeButton.Enabled = false;
            ConfirmChangeButton.Visible = false;

        }
        }
    }

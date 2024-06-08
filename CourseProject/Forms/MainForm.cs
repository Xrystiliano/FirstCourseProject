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
        const string PATH_DATA = ".//GameLibrary.txt";

        public static GameLibrary UserGames = new GameLibrary()
        {
        };

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            UserGames = UserGames.LoadData(PATH_DATA);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (UserGames.Count == 0)
            {
                MessageBox.Show("Це виглядає як ваша ігротека зовсім порожня! Додайте ігри за відповідною кнопкою!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string nameInput = NameInput.Text;
            string studioInput = StudioNameInput.Text;

            int? yearInput = string.IsNullOrWhiteSpace(YearReleaseInput.Text) ? (int?)null : (int.TryParse(YearReleaseInput.Text, out int year) && year > 1970 && year < 2065 ? year : (int?)null);
            if (yearInput == null && !string.IsNullOrWhiteSpace(YearReleaseInput.Text))
            {
                MessageBox.Show("Некоректний рік випуску");
                return;
            }

            float? scoreInput = string.IsNullOrWhiteSpace(ScoreInput.Text) ? (float?)null : (float.TryParse(ScoreInput.Text, out float score) && score > 0 && score <= 10 ? score : (float?)null);
            if (scoreInput == null && !string.IsNullOrWhiteSpace(ScoreInput.Text))
            {
                MessageBox.Show("Некоректна оцінка");
                return;
            }

            float? storageInput = string.IsNullOrWhiteSpace(StorageInput.Text) ? (float?)null : (float.TryParse(StorageInput.Text, out float storage) && storage > 1 && storage < 999 ? storage : (float?)null);
            if (storageInput == null && !string.IsNullOrWhiteSpace(StorageInput.Text))
            {
                MessageBox.Show("Некоректне місце на диску");
                return;
            }

            bool? scoreGreater = ScoreGreater.Checked ? true : (ScoreLess.Checked ? (bool?)false : null);
            bool? storageGreater = StorageGreater.Checked ? true : (StorageLess.Checked ? (bool?)false : null);
            bool? passedInput = PassedYes.Checked ? true : (PassedNo.Checked ? (bool?)false : null);
            List<string> genresInput = GenresInput.Text.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries).Select(g => g.Trim()).ToList();

            var result = UserGames.Search(nameInput, studioInput, yearInput, scoreInput, scoreGreater, storageInput, storageGreater, passedInput, genresInput);

            if (result.Count == 0)
            {
                MessageBox.Show("Нажаль, за вашим запитом нічого не знайдено!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            gameBindingSource.DataSource = result;


        }
        private void AddButton_Click(object sender, EventArgs e)
        {
            var AddForm = new AddForm(UserGames);
            AddForm.ShowDialog();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserGames.SaveData(PATH_DATA);
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserGames = UserGames.LoadData(PATH_DATA);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            UserGames.SaveData(PATH_DATA);
        }

        private void AddToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ShowAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (UserGames.Count == 0)
            {
                MessageBox.Show("Це виглядає як ваша ігротека зовсім порожня! Додайте ігри за відповідною кнопкою!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                gameBindingSource.ResetBindings(false);
                gameBindingSource.DataSource = UserGames;
            }


        }

        private void resultList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (resultList.SelectedItems.Count > 0)
            {
                Game game = resultList.SelectedItem as Game;
                var ChangeForm = new ChangingForm(game, UserGames);

                ChangeForm.GameChanged += OnGameChanged;

                ChangeForm.ShowDialog();

            }

        }
        private void OnGameChanged(Game updatedGame)
        {

            gameBindingSource.ResetBindings(false);
        }

        private void DeleteAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Ви впевнені, що хочете видалити всі ігри у бібліотеці?", "Підтвердження видалення", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                UserGames.Clear();
                gameBindingSource.ResetBindings(false);
                MessageBox.Show("Усі ігри  успішно видалено!");
            }
        }

        private void AddGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var AddForm = new AddForm(UserGames);
            AddForm.ShowDialog();
        }
    }

}


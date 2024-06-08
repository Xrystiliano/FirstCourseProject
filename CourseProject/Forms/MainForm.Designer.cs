namespace CourseProject.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Label ScoreLabel;
            Label PassedLabel;
            Label GenresLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator = new ToolStripSeparator();
            saveToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripSeparator2 = new ToolStripSeparator();
            exitToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            toolStripSeparator4 = new ToolStripSeparator();
            this.показатиВсеToolStripMenuItem = new ToolStripMenuItem();
            this.видалитиВсеToolStripMenuItem = new ToolStripMenuItem();
            AddToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            contentsToolStripMenuItem = new ToolStripMenuItem();
            indexToolStripMenuItem = new ToolStripMenuItem();
            searchToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator5 = new ToolStripSeparator();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            SearchContainer = new Panel();
            GenresInput = new TextBox();
            SearchButton = new Button();
            PassedRadioPanel = new Panel();
            PassedYes = new RadioButton();
            PassedNo = new RadioButton();
            ScoreRadioPanel = new Panel();
            ScoreGreater = new RadioButton();
            ScoreLess = new RadioButton();
            StorageRadioPanel = new Panel();
            StorageLess = new RadioButton();
            StorageGreater = new RadioButton();
            ScoreInput = new TextBox();
            StorageInput = new TextBox();
            StorageLabel = new Label();
            YearReleaseInput = new TextBox();
            YearReleaseLabel = new Label();
            StudioNameInput = new TextBox();
            StudioLabel = new Label();
            NameInput = new TextBox();
            NameLabel = new Label();
            AddButton = new Button();
            resultList = new ListBox();
            gameBindingSource = new BindingSource(components);
            ScoreLabel = new Label();
            PassedLabel = new Label();
            GenresLabel = new Label();
            menuStrip1.SuspendLayout();
            SearchContainer.SuspendLayout();
            PassedRadioPanel.SuspendLayout();
            ScoreRadioPanel.SuspendLayout();
            StorageRadioPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gameBindingSource).BeginInit();
            SuspendLayout();
            // 
            // ScoreLabel
            // 
            ScoreLabel.AutoSize = true;
            ScoreLabel.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ScoreLabel.Location = new Point(82, 211);
            ScoreLabel.Name = "ScoreLabel";
            ScoreLabel.Size = new Size(86, 26);
            ScoreLabel.TabIndex = 8;
            ScoreLabel.Text = "Оцінка:";
            // 
            // PassedLabel
            // 
            PassedLabel.AutoSize = true;
            PassedLabel.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            PassedLabel.Location = new Point(58, 292);
            PassedLabel.Name = "PassedLabel";
            PassedLabel.Size = new Size(110, 26);
            PassedLabel.TabIndex = 14;
            PassedLabel.Text = "Пройшли:";
            // 
            // GenresLabel
            // 
            GenresLabel.AutoSize = true;
            GenresLabel.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            GenresLabel.Location = new Point(84, 252);
            GenresLabel.Name = "GenresLabel";
            GenresLabel.Size = new Size(84, 26);
            GenresLabel.TabIndex = 22;
            GenresLabel.Text = "Жанри:";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1333, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openToolStripMenuItem, toolStripSeparator, saveToolStripMenuItem, toolStripSeparator1, toolStripSeparator2, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "&File";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Image = (Image)resources.GetObject("openToolStripMenuItem.Image");
            openToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
            openToolStripMenuItem.Size = new Size(235, 26);
            openToolStripMenuItem.Text = "Завантажити";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // toolStripSeparator
            // 
            toolStripSeparator.Name = "toolStripSeparator";
            toolStripSeparator.Size = new Size(232, 6);
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Image = (Image)resources.GetObject("saveToolStripMenuItem.Image");
            saveToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            saveToolStripMenuItem.Size = new Size(235, 26);
            saveToolStripMenuItem.Text = "Зберегти";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(232, 6);
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(232, 6);
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(235, 26);
            exitToolStripMenuItem.Text = "E&xit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripSeparator3, toolStripSeparator4, this.показатиВсеToolStripMenuItem, this.видалитиВсеToolStripMenuItem, AddToolStripMenuItem });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(49, 24);
            editToolStripMenuItem.Text = "&Edit";
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(221, 6);
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(221, 6);
            // 
            // ShowAllToolStripMenuItem
            // 
            this.показатиВсеToolStripMenuItem.Name = "ShowAllToolStripMenuItem";
            this.показатиВсеToolStripMenuItem.Size = new Size(224, 26);
            this.показатиВсеToolStripMenuItem.Text = "Показати все";
            this.показатиВсеToolStripMenuItem.Click += this.ShowAllToolStripMenuItem_Click;
            // 
            // DeleteAllToolStripMenuItem
            // 
            this.видалитиВсеToolStripMenuItem.Name = "DeleteAllToolStripMenuItem";
            this.видалитиВсеToolStripMenuItem.Size = new Size(224, 26);
            this.видалитиВсеToolStripMenuItem.Text = "Видалити Все";
            this.видалитиВсеToolStripMenuItem.Click += this.DeleteAllToolStripMenuItem_Click;
            // 
            // AddToolStripMenuItem
            // 
            AddToolStripMenuItem.Name = "AddToolStripMenuItem";
            AddToolStripMenuItem.Size = new Size(224, 26);
            AddToolStripMenuItem.Text = "Додати";
            AddToolStripMenuItem.Click += AddGameToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { contentsToolStripMenuItem, indexToolStripMenuItem, searchToolStripMenuItem, toolStripSeparator5, aboutToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(55, 24);
            helpToolStripMenuItem.Text = "&Help";
            // 
            // contentsToolStripMenuItem
            // 
            contentsToolStripMenuItem.Name = "contentsToolStripMenuItem";
            contentsToolStripMenuItem.Size = new Size(150, 26);
            contentsToolStripMenuItem.Text = "&Contents";
            // 
            // indexToolStripMenuItem
            // 
            indexToolStripMenuItem.Name = "indexToolStripMenuItem";
            indexToolStripMenuItem.Size = new Size(150, 26);
            indexToolStripMenuItem.Text = "&Index";
            // 
            // searchToolStripMenuItem
            // 
            searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            searchToolStripMenuItem.Size = new Size(150, 26);
            searchToolStripMenuItem.Text = "&Search";
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new Size(147, 6);
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(150, 26);
            aboutToolStripMenuItem.Text = "&About...";
            // 
            // SearchContainer
            // 
            SearchContainer.Anchor = AnchorStyles.Top;
            SearchContainer.BorderStyle = BorderStyle.FixedSingle;
            SearchContainer.Controls.Add(GenresInput);
            SearchContainer.Controls.Add(GenresLabel);
            SearchContainer.Controls.Add(SearchButton);
            SearchContainer.Controls.Add(PassedRadioPanel);
            SearchContainer.Controls.Add(ScoreRadioPanel);
            SearchContainer.Controls.Add(StorageRadioPanel);
            SearchContainer.Controls.Add(PassedLabel);
            SearchContainer.Controls.Add(ScoreInput);
            SearchContainer.Controls.Add(ScoreLabel);
            SearchContainer.Controls.Add(StorageInput);
            SearchContainer.Controls.Add(StorageLabel);
            SearchContainer.Controls.Add(YearReleaseInput);
            SearchContainer.Controls.Add(YearReleaseLabel);
            SearchContainer.Controls.Add(StudioNameInput);
            SearchContainer.Controls.Add(StudioLabel);
            SearchContainer.Controls.Add(NameInput);
            SearchContainer.Controls.Add(NameLabel);
            SearchContainer.Location = new Point(12, 31);
            SearchContainer.Name = "SearchContainer";
            SearchContainer.Size = new Size(700, 396);
            SearchContainer.TabIndex = 1;
            // 
            // GenresInput
            // 
            GenresInput.Location = new Point(174, 253);
            GenresInput.MaxLength = 50;
            GenresInput.Name = "GenresInput";
            GenresInput.Size = new Size(280, 27);
            GenresInput.TabIndex = 23;
            // 
            // SearchButton
            // 
            SearchButton.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            SearchButton.Location = new Point(261, 355);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(141, 36);
            SearchButton.TabIndex = 15;
            SearchButton.Text = "Пошук";
            SearchButton.UseVisualStyleBackColor = true;
            SearchButton.Click += SearchButton_Click;
            // 
            // PassedRadioPanel
            // 
            PassedRadioPanel.Controls.Add(PassedYes);
            PassedRadioPanel.Controls.Add(PassedNo);
            PassedRadioPanel.Location = new Point(171, 292);
            PassedRadioPanel.Name = "PassedRadioPanel";
            PassedRadioPanel.Size = new Size(106, 27);
            PassedRadioPanel.TabIndex = 3;
            // 
            // PassedYes
            // 
            PassedYes.AutoSize = true;
            PassedYes.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            PassedYes.Location = new Point(3, 3);
            PassedYes.Name = "PassedYes";
            PassedYes.Size = new Size(59, 24);
            PassedYes.TabIndex = 12;
            PassedYes.TabStop = true;
            PassedYes.Text = "Так";
            PassedYes.UseVisualStyleBackColor = true;
            // 
            // PassedNo
            // 
            PassedNo.AutoSize = true;
            PassedNo.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            PassedNo.Location = new Point(62, 3);
            PassedNo.Name = "PassedNo";
            PassedNo.Size = new Size(47, 24);
            PassedNo.TabIndex = 13;
            PassedNo.TabStop = true;
            PassedNo.Text = "Ні";
            PassedNo.UseVisualStyleBackColor = true;
            // 
            // ScoreRadioPanel
            // 
            ScoreRadioPanel.Controls.Add(ScoreGreater);
            ScoreRadioPanel.Controls.Add(ScoreLess);
            ScoreRadioPanel.Location = new Point(460, 212);
            ScoreRadioPanel.Name = "ScoreRadioPanel";
            ScoreRadioPanel.Size = new Size(223, 27);
            ScoreRadioPanel.TabIndex = 3;
            // 
            // ScoreGreater
            // 
            ScoreGreater.AutoSize = true;
            ScoreGreater.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ScoreGreater.Location = new Point(0, 3);
            ScoreGreater.Name = "ScoreGreater";
            ScoreGreater.Size = new Size(114, 24);
            ScoreGreater.TabIndex = 10;
            ScoreGreater.TabStop = true;
            ScoreGreater.Text = "Більше ніж";
            ScoreGreater.UseVisualStyleBackColor = true;
            // 
            // ScoreLess
            // 
            ScoreLess.AutoSize = true;
            ScoreLess.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ScoreLess.Location = new Point(120, 3);
            ScoreLess.Name = "ScoreLess";
            ScoreLess.Size = new Size(109, 24);
            ScoreLess.TabIndex = 11;
            ScoreLess.TabStop = true;
            ScoreLess.Text = "Менш ніж";
            ScoreLess.UseVisualStyleBackColor = true;
            // 
            // StorageRadioPanel
            // 
            StorageRadioPanel.Controls.Add(StorageLess);
            StorageRadioPanel.Controls.Add(StorageGreater);
            StorageRadioPanel.Location = new Point(460, 169);
            StorageRadioPanel.Name = "StorageRadioPanel";
            StorageRadioPanel.Size = new Size(223, 27);
            StorageRadioPanel.TabIndex = 2;
            // 
            // StorageLess
            // 
            StorageLess.AutoSize = true;
            StorageLess.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            StorageLess.Location = new Point(120, 3);
            StorageLess.Name = "StorageLess";
            StorageLess.Size = new Size(109, 24);
            StorageLess.TabIndex = 16;
            StorageLess.TabStop = true;
            StorageLess.Text = "Менш ніж";
            StorageLess.UseVisualStyleBackColor = true;
            // 
            // StorageGreater
            // 
            StorageGreater.AutoSize = true;
            StorageGreater.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            StorageGreater.Location = new Point(3, 3);
            StorageGreater.Name = "StorageGreater";
            StorageGreater.Size = new Size(114, 24);
            StorageGreater.TabIndex = 15;
            StorageGreater.TabStop = true;
            StorageGreater.Text = "Більше ніж";
            StorageGreater.UseVisualStyleBackColor = false;
            // 
            // ScoreInput
            // 
            ScoreInput.Location = new Point(174, 212);
            ScoreInput.MaxLength = 2;
            ScoreInput.Name = "ScoreInput";
            ScoreInput.Size = new Size(280, 27);
            ScoreInput.TabIndex = 9;
            // 
            // StorageInput
            // 
            StorageInput.Location = new Point(174, 169);
            StorageInput.Name = "StorageInput";
            StorageInput.Size = new Size(280, 27);
            StorageInput.TabIndex = 7;
            // 
            // StorageLabel
            // 
            StorageLabel.AutoSize = true;
            StorageLabel.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            StorageLabel.Location = new Point(3, 168);
            StorageLabel.Name = "StorageLabel";
            StorageLabel.Size = new Size(165, 26);
            StorageLabel.TabIndex = 6;
            StorageLabel.Text = "Місце на диску:";
            // 
            // YearReleaseInput
            // 
            YearReleaseInput.Location = new Point(174, 116);
            YearReleaseInput.Name = "YearReleaseInput";
            YearReleaseInput.Size = new Size(280, 27);
            YearReleaseInput.TabIndex = 5;
            // 
            // YearReleaseLabel
            // 
            YearReleaseLabel.AutoSize = true;
            YearReleaseLabel.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            YearReleaseLabel.Location = new Point(36, 115);
            YearReleaseLabel.Name = "YearReleaseLabel";
            YearReleaseLabel.Size = new Size(132, 26);
            YearReleaseLabel.TabIndex = 4;
            YearReleaseLabel.Text = "Рік випуску:";
            // 
            // StudioNameInput
            // 
            StudioNameInput.Location = new Point(174, 69);
            StudioNameInput.Name = "StudioNameInput";
            StudioNameInput.Size = new Size(280, 27);
            StudioNameInput.TabIndex = 3;
            // 
            // StudioLabel
            // 
            StudioLabel.AutoSize = true;
            StudioLabel.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            StudioLabel.Location = new Point(46, 70);
            StudioLabel.Name = "StudioLabel";
            StudioLabel.Size = new Size(122, 26);
            StudioLabel.TabIndex = 2;
            StudioLabel.Text = "Розробник:";
            // 
            // NameInput
            // 
            NameInput.Location = new Point(174, 18);
            NameInput.Name = "NameInput";
            NameInput.Size = new Size(280, 27);
            NameInput.TabIndex = 1;
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            NameLabel.Location = new Point(95, 17);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(73, 26);
            NameLabel.TabIndex = 0;
            NameLabel.Text = "Назва:";
            // 
            // AddButton
            // 
            AddButton.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            AddButton.Location = new Point(277, 433);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(138, 43);
            AddButton.TabIndex = 2;
            AddButton.Text = "Додати";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // resultList
            // 
            resultList.DataSource = gameBindingSource;
            resultList.DisplayMember = "Name";
            resultList.FormattingEnabled = true;
            resultList.Location = new Point(708, 31);
            resultList.Name = "resultList";
            resultList.Size = new Size(625, 624);
            resultList.TabIndex = 3;
            resultList.MouseDoubleClick += resultList_MouseDoubleClick;
            // 
            // gameBindingSource
            // 
            gameBindingSource.DataSource = typeof(Models.Game);
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1333, 647);
            Controls.Add(resultList);
            Controls.Add(AddButton);
            Controls.Add(SearchContainer);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            MinimumSize = new Size(810, 523);
            Name = "MainForm";
            Text = "MainForm";
            FormClosing += MainForm_FormClosing;
            Load += MainForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            SearchContainer.ResumeLayout(false);
            SearchContainer.PerformLayout();
            PassedRadioPanel.ResumeLayout(false);
            PassedRadioPanel.PerformLayout();
            ScoreRadioPanel.ResumeLayout(false);
            ScoreRadioPanel.PerformLayout();
            StorageRadioPanel.ResumeLayout(false);
            StorageRadioPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gameBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem printToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem contentsToolStripMenuItem;
        private ToolStripMenuItem indexToolStripMenuItem;
        private ToolStripMenuItem searchToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private Panel SearchContainer;
        private Label NameLabel;
        private TextBox StudioNameInput;
        private Label StudioLabel;
        private TextBox NameInput;
        private TextBox YearReleaseInput;
        private Label YearReleaseLabel;
        private TextBox StorageInput;
        private Label StorageLabel;
        private TextBox ScoreInput;
        private Label ScoreLabel;
        private RadioButton ScoreLess;
        private RadioButton ScoreGreater;
        private RadioButton PassedNo;
        private RadioButton PassedYes;
        private RadioButton StorageLess;
        private RadioButton StorageGreater;
        private Panel StorageRadioPanel;
        private Panel ScoreRadioPanel;
        private Panel PassedRadioPanel;
        private Button SearchButton;
        private Button AddButton;
        private ListBox resultList;
        private BindingSource gameBindingSource;
        private ToolStripMenuItem показатиВсеToolStripMenuItem;
        private ToolStripMenuItem видалитиВсеToolStripMenuItem;
        private ToolStripMenuItem AddToolStripMenuItem;
        private TextBox GenresInput;
    }
}
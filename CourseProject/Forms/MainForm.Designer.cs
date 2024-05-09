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
            Label ScoreLabel;
            Label PassedLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            newToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator = new ToolStripSeparator();
            saveToolStripMenuItem = new ToolStripMenuItem();
            saveAsToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            printToolStripMenuItem = new ToolStripMenuItem();
            printPreviewToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            exitToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            undoToolStripMenuItem = new ToolStripMenuItem();
            redoToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            cutToolStripMenuItem = new ToolStripMenuItem();
            copyToolStripMenuItem = new ToolStripMenuItem();
            pasteToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator4 = new ToolStripSeparator();
            selectAllToolStripMenuItem = new ToolStripMenuItem();
            toolsToolStripMenuItem = new ToolStripMenuItem();
            customizeToolStripMenuItem = new ToolStripMenuItem();
            optionsToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            contentsToolStripMenuItem = new ToolStripMenuItem();
            indexToolStripMenuItem = new ToolStripMenuItem();
            searchToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator5 = new ToolStripSeparator();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            SearchContainer = new Panel();
            PassedRadioPanel = new Panel();
            PassedYes = new RadioButton();
            PassedNo = new RadioButton();
            ScoreRadioPanel = new Panel();
            BiggerScore = new RadioButton();
            LessScore = new RadioButton();
            StorageRadioPanel = new Panel();
            LessStorage = new RadioButton();
            BiggerStorage = new RadioButton();
            ScoreInput = new TextBox();
            StorageInput = new TextBox();
            StorageLabel = new Label();
            YaerReleaseInput = new TextBox();
            YearReleaseLabel = new Label();
            StudioNameInput = new TextBox();
            StudioLabel = new Label();
            NameInput = new TextBox();
            NameLabel = new Label();
            SearchButton = new Button();
            ScoreLabel = new Label();
            PassedLabel = new Label();
            menuStrip1.SuspendLayout();
            SearchContainer.SuspendLayout();
            PassedRadioPanel.SuspendLayout();
            ScoreRadioPanel.SuspendLayout();
            StorageRadioPanel.SuspendLayout();
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
            ScoreLabel.Click += ScoreLabel_Click;
            // 
            // PassedLabel
            // 
            PassedLabel.AutoSize = true;
            PassedLabel.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            PassedLabel.Location = new Point(61, 255);
            PassedLabel.Name = "PassedLabel";
            PassedLabel.Size = new Size(110, 26);
            PassedLabel.TabIndex = 14;
            PassedLabel.Text = "Пройшли:";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, toolsToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1372, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newToolStripMenuItem, openToolStripMenuItem, toolStripSeparator, saveToolStripMenuItem, saveAsToolStripMenuItem, toolStripSeparator1, printToolStripMenuItem, printPreviewToolStripMenuItem, toolStripSeparator2, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Image = (Image)resources.GetObject("newToolStripMenuItem.Image");
            newToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
            newToolStripMenuItem.Size = new Size(181, 26);
            newToolStripMenuItem.Text = "&New";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Image = (Image)resources.GetObject("openToolStripMenuItem.Image");
            openToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
            openToolStripMenuItem.Size = new Size(181, 26);
            openToolStripMenuItem.Text = "&Open";
            // 
            // toolStripSeparator
            // 
            toolStripSeparator.Name = "toolStripSeparator";
            toolStripSeparator.Size = new Size(178, 6);
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Image = (Image)resources.GetObject("saveToolStripMenuItem.Image");
            saveToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            saveToolStripMenuItem.Size = new Size(181, 26);
            saveToolStripMenuItem.Text = "&Save";
            // 
            // saveAsToolStripMenuItem
            // 
            saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            saveAsToolStripMenuItem.Size = new Size(181, 26);
            saveAsToolStripMenuItem.Text = "Save &As";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(178, 6);
            // 
            // printToolStripMenuItem
            // 
            printToolStripMenuItem.Image = (Image)resources.GetObject("printToolStripMenuItem.Image");
            printToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            printToolStripMenuItem.Name = "printToolStripMenuItem";
            printToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.P;
            printToolStripMenuItem.Size = new Size(181, 26);
            printToolStripMenuItem.Text = "&Print";
            // 
            // printPreviewToolStripMenuItem
            // 
            printPreviewToolStripMenuItem.Image = (Image)resources.GetObject("printPreviewToolStripMenuItem.Image");
            printPreviewToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            printPreviewToolStripMenuItem.Name = "printPreviewToolStripMenuItem";
            printPreviewToolStripMenuItem.Size = new Size(181, 26);
            printPreviewToolStripMenuItem.Text = "Print Pre&view";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(178, 6);
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(181, 26);
            exitToolStripMenuItem.Text = "E&xit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { undoToolStripMenuItem, redoToolStripMenuItem, toolStripSeparator3, cutToolStripMenuItem, copyToolStripMenuItem, pasteToolStripMenuItem, toolStripSeparator4, selectAllToolStripMenuItem });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(49, 24);
            editToolStripMenuItem.Text = "&Edit";
            // 
            // undoToolStripMenuItem
            // 
            undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            undoToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Z;
            undoToolStripMenuItem.Size = new Size(179, 26);
            undoToolStripMenuItem.Text = "&Undo";
            // 
            // redoToolStripMenuItem
            // 
            redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            redoToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Y;
            redoToolStripMenuItem.Size = new Size(179, 26);
            redoToolStripMenuItem.Text = "&Redo";
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(176, 6);
            // 
            // cutToolStripMenuItem
            // 
            cutToolStripMenuItem.Image = (Image)resources.GetObject("cutToolStripMenuItem.Image");
            cutToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            cutToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.X;
            cutToolStripMenuItem.Size = new Size(179, 26);
            cutToolStripMenuItem.Text = "Cu&t";
            // 
            // copyToolStripMenuItem
            // 
            copyToolStripMenuItem.Image = (Image)resources.GetObject("copyToolStripMenuItem.Image");
            copyToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            copyToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.C;
            copyToolStripMenuItem.Size = new Size(179, 26);
            copyToolStripMenuItem.Text = "&Copy";
            // 
            // pasteToolStripMenuItem
            // 
            pasteToolStripMenuItem.Image = (Image)resources.GetObject("pasteToolStripMenuItem.Image");
            pasteToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            pasteToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.V;
            pasteToolStripMenuItem.Size = new Size(179, 26);
            pasteToolStripMenuItem.Text = "&Paste";
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(176, 6);
            // 
            // selectAllToolStripMenuItem
            // 
            selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            selectAllToolStripMenuItem.Size = new Size(179, 26);
            selectAllToolStripMenuItem.Text = "Select &All";
            // 
            // toolsToolStripMenuItem
            // 
            toolsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { customizeToolStripMenuItem, optionsToolStripMenuItem });
            toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            toolsToolStripMenuItem.Size = new Size(58, 24);
            toolsToolStripMenuItem.Text = "&Tools";
            // 
            // customizeToolStripMenuItem
            // 
            customizeToolStripMenuItem.Name = "customizeToolStripMenuItem";
            customizeToolStripMenuItem.Size = new Size(161, 26);
            customizeToolStripMenuItem.Text = "&Customize";
            // 
            // optionsToolStripMenuItem
            // 
            optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            optionsToolStripMenuItem.Size = new Size(161, 26);
            optionsToolStripMenuItem.Text = "&Options";
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
            SearchContainer.Controls.Add(SearchButton);
            SearchContainer.Controls.Add(PassedRadioPanel);
            SearchContainer.Controls.Add(ScoreRadioPanel);
            SearchContainer.Controls.Add(StorageRadioPanel);
            SearchContainer.Controls.Add(PassedLabel);
            SearchContainer.Controls.Add(ScoreInput);
            SearchContainer.Controls.Add(ScoreLabel);
            SearchContainer.Controls.Add(StorageInput);
            SearchContainer.Controls.Add(StorageLabel);
            SearchContainer.Controls.Add(YaerReleaseInput);
            SearchContainer.Controls.Add(YearReleaseLabel);
            SearchContainer.Controls.Add(StudioNameInput);
            SearchContainer.Controls.Add(StudioLabel);
            SearchContainer.Controls.Add(NameInput);
            SearchContainer.Controls.Add(NameLabel);
            SearchContainer.Location = new Point(129, 46);
            SearchContainer.Name = "SearchContainer";
            SearchContainer.Size = new Size(700, 366);
            SearchContainer.TabIndex = 1;
            // 
            // PassedRadioPanel
            // 
            PassedRadioPanel.Controls.Add(PassedYes);
            PassedRadioPanel.Controls.Add(PassedNo);
            PassedRadioPanel.Location = new Point(174, 255);
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
            ScoreRadioPanel.Controls.Add(BiggerScore);
            ScoreRadioPanel.Controls.Add(LessScore);
            ScoreRadioPanel.Location = new Point(460, 212);
            ScoreRadioPanel.Name = "ScoreRadioPanel";
            ScoreRadioPanel.Size = new Size(223, 27);
            ScoreRadioPanel.TabIndex = 3;
            // 
            // BiggerScore
            // 
            BiggerScore.AutoSize = true;
            BiggerScore.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            BiggerScore.Location = new Point(0, 3);
            BiggerScore.Name = "BiggerScore";
            BiggerScore.Size = new Size(114, 24);
            BiggerScore.TabIndex = 10;
            BiggerScore.TabStop = true;
            BiggerScore.Text = "Більше ніж";
            BiggerScore.UseVisualStyleBackColor = true;
            BiggerScore.CheckedChanged += BiggerScore_CheckedChanged;
            // 
            // LessScore
            // 
            LessScore.AutoSize = true;
            LessScore.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            LessScore.Location = new Point(120, 3);
            LessScore.Name = "LessScore";
            LessScore.Size = new Size(109, 24);
            LessScore.TabIndex = 11;
            LessScore.TabStop = true;
            LessScore.Text = "Менш ніж";
            LessScore.UseVisualStyleBackColor = true;
            // 
            // StorageRadioPanel
            // 
            StorageRadioPanel.Controls.Add(LessStorage);
            StorageRadioPanel.Controls.Add(BiggerStorage);
            StorageRadioPanel.Location = new Point(460, 169);
            StorageRadioPanel.Name = "StorageRadioPanel";
            StorageRadioPanel.Size = new Size(223, 27);
            StorageRadioPanel.TabIndex = 2;
            // 
            // LessStorage
            // 
            LessStorage.AutoSize = true;
            LessStorage.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            LessStorage.Location = new Point(120, 3);
            LessStorage.Name = "LessStorage";
            LessStorage.Size = new Size(109, 24);
            LessStorage.TabIndex = 16;
            LessStorage.TabStop = true;
            LessStorage.Text = "Менш ніж";
            LessStorage.UseVisualStyleBackColor = true;
            LessStorage.CheckedChanged += LessStorage_CheckedChanged;
            // 
            // BiggerStorage
            // 
            BiggerStorage.AutoSize = true;
            BiggerStorage.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            BiggerStorage.Location = new Point(3, 3);
            BiggerStorage.Name = "BiggerStorage";
            BiggerStorage.Size = new Size(114, 24);
            BiggerStorage.TabIndex = 15;
            BiggerStorage.TabStop = true;
            BiggerStorage.Text = "Більше ніж";
            BiggerStorage.UseVisualStyleBackColor = false;
            // 
            // ScoreInput
            // 
            ScoreInput.Location = new Point(174, 212);
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
            StorageLabel.Click += StorageInput_Click;
            // 
            // YaerReleaseInput
            // 
            YaerReleaseInput.Location = new Point(174, 116);
            YaerReleaseInput.Name = "YaerReleaseInput";
            YaerReleaseInput.Size = new Size(280, 27);
            YaerReleaseInput.TabIndex = 5;
            YaerReleaseInput.TextChanged += textBox2_TextChanged;
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
            StudioNameInput.TextChanged += textBox1_TextChanged;
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
            NameInput.TextChanged += NameInput_TextChanged;
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
            // SearchButton
            // 
            SearchButton.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            SearchButton.Location = new Point(554, 325);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(141, 36);
            SearchButton.TabIndex = 15;
            SearchButton.Text = "Пошук";
            SearchButton.UseVisualStyleBackColor = true;
            SearchButton.Click += SearchButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1372, 572);
            Controls.Add(SearchContainer);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            MinimumSize = new Size(810, 523);
            Name = "MainForm";
            Text = "MainForm";
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
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem saveAsToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem printToolStripMenuItem;
        private ToolStripMenuItem printPreviewToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem undoToolStripMenuItem;
        private ToolStripMenuItem redoToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem cutToolStripMenuItem;
        private ToolStripMenuItem copyToolStripMenuItem;
        private ToolStripMenuItem pasteToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripMenuItem selectAllToolStripMenuItem;
        private ToolStripMenuItem toolsToolStripMenuItem;
        private ToolStripMenuItem customizeToolStripMenuItem;
        private ToolStripMenuItem optionsToolStripMenuItem;
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
        private TextBox YaerReleaseInput;
        private Label YearReleaseLabel;
        private TextBox StorageInput;
        private Label StorageLabel;
        private TextBox ScoreInput;
        private Label ScoreLabel;
        private RadioButton LessScore;
        private RadioButton BiggerScore;
        private RadioButton PassedNo;
        private RadioButton PassedYes;
        private RadioButton LessStorage;
        private RadioButton BiggerStorage;
        private Panel StorageRadioPanel;
        private Panel ScoreRadioPanel;
        private Panel PassedRadioPanel;
        private Button SearchButton;
    }
}
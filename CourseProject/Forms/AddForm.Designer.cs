namespace CourseProject.Forms
{
    partial class AddForm
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
            Label PassedLabel;
            Label ScoreLabel;
            Label GenresLabel;
            AddContainer = new Panel();
            GenresInput = new TextBox();
            DescriptionInput = new TextBox();
            DescriptionLabel = new Label();
            ConfirmAddButton = new Button();
            PassedRadioPanel = new Panel();
            PassedYes = new RadioButton();
            PassedNo = new RadioButton();
            ScoreInput = new TextBox();
            StorageInput = new TextBox();
            StorageLabel = new Label();
            YearReleaseInput = new TextBox();
            YearReleaseLabel = new Label();
            StudioNameInput = new TextBox();
            StudioLabel = new Label();
            NameInput = new TextBox();
            NameLabel = new Label();
            PassedLabel = new Label();
            ScoreLabel = new Label();
            GenresLabel = new Label();
            AddContainer.SuspendLayout();
            PassedRadioPanel.SuspendLayout();
            SuspendLayout();
            // 
            // PassedLabel
            // 
            PassedLabel.AutoSize = true;
            PassedLabel.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            PassedLabel.Location = new Point(58, 247);
            PassedLabel.Name = "PassedLabel";
            PassedLabel.Size = new Size(110, 26);
            PassedLabel.TabIndex = 14;
            PassedLabel.Text = "Пройшли:";
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
            // GenresLabel
            // 
            GenresLabel.AutoSize = true;
            GenresLabel.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            GenresLabel.Location = new Point(84, 288);
            GenresLabel.Name = "GenresLabel";
            GenresLabel.Size = new Size(84, 26);
            GenresLabel.TabIndex = 18;
            GenresLabel.Text = "Жанри:";
            // 
            // AddContainer
            // 
            AddContainer.Controls.Add(GenresInput);
            AddContainer.Controls.Add(GenresLabel);
            AddContainer.Controls.Add(DescriptionInput);
            AddContainer.Controls.Add(DescriptionLabel);
            AddContainer.Controls.Add(ConfirmAddButton);
            AddContainer.Controls.Add(PassedRadioPanel);
            AddContainer.Controls.Add(PassedLabel);
            AddContainer.Controls.Add(ScoreInput);
            AddContainer.Controls.Add(ScoreLabel);
            AddContainer.Controls.Add(StorageInput);
            AddContainer.Controls.Add(StorageLabel);
            AddContainer.Controls.Add(YearReleaseInput);
            AddContainer.Controls.Add(YearReleaseLabel);
            AddContainer.Controls.Add(StudioNameInput);
            AddContainer.Controls.Add(StudioLabel);
            AddContainer.Controls.Add(NameInput);
            AddContainer.Controls.Add(NameLabel);
            AddContainer.Location = new Point(12, 12);
            AddContainer.Name = "AddContainer";
            AddContainer.Size = new Size(470, 760);
            AddContainer.TabIndex = 2;
            // 
            // GenresInput
            // 
            GenresInput.Location = new Point(174, 289);
            GenresInput.MaxLength = 50;
            GenresInput.Name = "GenresInput";
            GenresInput.Size = new Size(280, 27);
            GenresInput.TabIndex = 19;
            // 
            // DescriptionInput
            // 
            DescriptionInput.Location = new Point(78, 332);
            DescriptionInput.MaxLength = 900;
            DescriptionInput.Multiline = true;
            DescriptionInput.Name = "DescriptionInput";
            DescriptionInput.Size = new Size(300, 339);
            DescriptionInput.TabIndex = 17;
            // 
            // DescriptionLabel
            // 
            DescriptionLabel.AutoSize = true;
            DescriptionLabel.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            DescriptionLabel.Location = new Point(3, 331);
            DescriptionLabel.Name = "DescriptionLabel";
            DescriptionLabel.Size = new Size(69, 26);
            DescriptionLabel.TabIndex = 16;
            DescriptionLabel.Text = "Опис:";
            // 
            // ConfirmAddButton
            // 
            ConfirmAddButton.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ConfirmAddButton.Location = new Point(145, 697);
            ConfirmAddButton.Name = "ConfirmAddButton";
            ConfirmAddButton.Size = new Size(156, 36);
            ConfirmAddButton.TabIndex = 15;
            ConfirmAddButton.Text = "Підтвердити";
            ConfirmAddButton.UseVisualStyleBackColor = true;
            ConfirmAddButton.Click += ConfirmAddButton_Click;
            // 
            // PassedRadioPanel
            // 
            PassedRadioPanel.Controls.Add(PassedYes);
            PassedRadioPanel.Controls.Add(PassedNo);
            PassedRadioPanel.Location = new Point(174, 247);
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
            StorageInput.MaxLength = 3;
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
            YearReleaseInput.MaxLength = 4;
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
            StudioNameInput.MaxLength = 30;
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
            NameInput.MaxLength = 30;
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
            // AddForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(490, 772);
            Controls.Add(AddContainer);
            MaximumSize = new Size(508, 819);
            MinimumSize = new Size(508, 819);
            Name = "AddForm";
            Text = "AddForm";
            AddContainer.ResumeLayout(false);
            AddContainer.PerformLayout();
            PassedRadioPanel.ResumeLayout(false);
            PassedRadioPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel AddContainer;
        private Button ConfirmAddButton;
        private Panel PassedRadioPanel;
        private RadioButton PassedYes;
        private RadioButton PassedNo;
        private TextBox ScoreInput;
        private TextBox StorageInput;
        private Label StorageLabel;
        private TextBox YearReleaseInput;
        private Label YearReleaseLabel;
        private TextBox StudioNameInput;
        private Label StudioLabel;
        private TextBox NameInput;
        private Label NameLabel;
        private TextBox DescriptionInput;
        private Label DescriptionLabel;
        private TextBox GenresInput;
    }
}
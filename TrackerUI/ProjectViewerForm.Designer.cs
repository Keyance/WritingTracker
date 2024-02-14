namespace TrackerUI
{
    partial class ProjectViewerForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            nameLabel = new Label();
            nameValue = new TextBox();
            descriptionLabel = new Label();
            descriptionTextBox = new RichTextBox();
            wordsNeededValue = new TextBox();
            wordsNeededLabel = new Label();
            currentWordsValue = new TextBox();
            currentWordsLabel = new Label();
            fromValue = new TextBox();
            fromLabel = new Label();
            untilValue = new TextBox();
            untilLabel = new Label();
            modifyProjectButton = new Button();
            viewProjectDataButton = new Button();
            selectMonthComboBox = new ComboBox();
            selectMonthLabel = new Label();
            SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Yu Mincho", 12F, FontStyle.Regular, GraphicsUnit.Point);
            nameLabel.Location = new Point(33, 24);
            nameLabel.Margin = new Padding(4, 0, 4, 0);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(71, 26);
            nameLabel.TabIndex = 1;
            nameLabel.Text = "Name:";
            // 
            // nameValue
            // 
            nameValue.Location = new Point(129, 10);
            nameValue.Name = "nameValue";
            nameValue.ReadOnly = true;
            nameValue.Size = new Size(466, 40);
            nameValue.TabIndex = 2;
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Font = new Font("Yu Mincho", 12F, FontStyle.Regular, GraphicsUnit.Point);
            descriptionLabel.Location = new Point(33, 79);
            descriptionLabel.Margin = new Padding(4, 0, 4, 0);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new Size(123, 26);
            descriptionLabel.TabIndex = 3;
            descriptionLabel.Text = "Description:";
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.Location = new Point(33, 108);
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.ReadOnly = true;
            descriptionTextBox.Size = new Size(815, 217);
            descriptionTextBox.TabIndex = 5;
            descriptionTextBox.Text = "";
            // 
            // wordsNeededValue
            // 
            wordsNeededValue.Location = new Point(242, 346);
            wordsNeededValue.Name = "wordsNeededValue";
            wordsNeededValue.ReadOnly = true;
            wordsNeededValue.Size = new Size(217, 40);
            wordsNeededValue.TabIndex = 7;
            // 
            // wordsNeededLabel
            // 
            wordsNeededLabel.AutoSize = true;
            wordsNeededLabel.Font = new Font("Yu Mincho", 12F, FontStyle.Regular, GraphicsUnit.Point);
            wordsNeededLabel.Location = new Point(33, 360);
            wordsNeededLabel.Margin = new Padding(4, 0, 4, 0);
            wordsNeededLabel.Name = "wordsNeededLabel";
            wordsNeededLabel.Size = new Size(202, 26);
            wordsNeededLabel.TabIndex = 6;
            wordsNeededLabel.Text = "Word Count Needed:";
            // 
            // currentWordsValue
            // 
            currentWordsValue.Location = new Point(242, 401);
            currentWordsValue.Name = "currentWordsValue";
            currentWordsValue.ReadOnly = true;
            currentWordsValue.Size = new Size(217, 40);
            currentWordsValue.TabIndex = 9;
            // 
            // currentWordsLabel
            // 
            currentWordsLabel.AutoSize = true;
            currentWordsLabel.Font = new Font("Yu Mincho", 12F, FontStyle.Regular, GraphicsUnit.Point);
            currentWordsLabel.Location = new Point(33, 415);
            currentWordsLabel.Margin = new Padding(4, 0, 4, 0);
            currentWordsLabel.Name = "currentWordsLabel";
            currentWordsLabel.Size = new Size(205, 26);
            currentWordsLabel.TabIndex = 8;
            currentWordsLabel.Text = "Current Word Count:";
            // 
            // fromValue
            // 
            fromValue.Location = new Point(611, 346);
            fromValue.Name = "fromValue";
            fromValue.ReadOnly = true;
            fromValue.Size = new Size(223, 40);
            fromValue.TabIndex = 11;
            // 
            // fromLabel
            // 
            fromLabel.AutoSize = true;
            fromLabel.Font = new Font("Yu Mincho", 12F, FontStyle.Regular, GraphicsUnit.Point);
            fromLabel.Location = new Point(538, 360);
            fromLabel.Margin = new Padding(4, 0, 4, 0);
            fromLabel.Name = "fromLabel";
            fromLabel.Size = new Size(66, 26);
            fromLabel.TabIndex = 10;
            fromLabel.Text = "From:";
            // 
            // untilValue
            // 
            untilValue.Location = new Point(611, 401);
            untilValue.Name = "untilValue";
            untilValue.ReadOnly = true;
            untilValue.Size = new Size(223, 40);
            untilValue.TabIndex = 13;
            // 
            // untilLabel
            // 
            untilLabel.AutoSize = true;
            untilLabel.Font = new Font("Yu Mincho", 12F, FontStyle.Regular, GraphicsUnit.Point);
            untilLabel.Location = new Point(538, 415);
            untilLabel.Margin = new Padding(4, 0, 4, 0);
            untilLabel.Name = "untilLabel";
            untilLabel.Size = new Size(64, 26);
            untilLabel.TabIndex = 12;
            untilLabel.Text = "Until:";
            // 
            // modifyProjectButton
            // 
            modifyProjectButton.FlatAppearance.BorderColor = Color.FromArgb(192, 0, 0);
            modifyProjectButton.FlatAppearance.BorderSize = 2;
            modifyProjectButton.FlatAppearance.MouseDownBackColor = Color.Gainsboro;
            modifyProjectButton.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            modifyProjectButton.FlatStyle = FlatStyle.Flat;
            modifyProjectButton.Location = new Point(490, 615);
            modifyProjectButton.Name = "modifyProjectButton";
            modifyProjectButton.Size = new Size(346, 60);
            modifyProjectButton.TabIndex = 14;
            modifyProjectButton.Text = "Modify Project";
            modifyProjectButton.UseVisualStyleBackColor = true;
            // 
            // viewProjectDataButton
            // 
            viewProjectDataButton.FlatAppearance.BorderColor = Color.FromArgb(192, 0, 0);
            viewProjectDataButton.FlatAppearance.BorderSize = 2;
            viewProjectDataButton.FlatAppearance.MouseDownBackColor = Color.Gainsboro;
            viewProjectDataButton.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            viewProjectDataButton.FlatStyle = FlatStyle.Flat;
            viewProjectDataButton.Location = new Point(55, 615);
            viewProjectDataButton.Name = "viewProjectDataButton";
            viewProjectDataButton.Size = new Size(346, 60);
            viewProjectDataButton.TabIndex = 15;
            viewProjectDataButton.Text = "View Project Data";
            viewProjectDataButton.UseVisualStyleBackColor = true;
            // 
            // selectMonthComboBox
            // 
            selectMonthComboBox.BackColor = Color.WhiteSmoke;
            selectMonthComboBox.FormattingEnabled = true;
            selectMonthComboBox.Location = new Point(33, 525);
            selectMonthComboBox.Name = "selectMonthComboBox";
            selectMonthComboBox.Size = new Size(396, 34);
            selectMonthComboBox.TabIndex = 17;
            // 
            // selectMonthLabel
            // 
            selectMonthLabel.AutoSize = true;
            selectMonthLabel.Font = new Font("Yu Mincho", 12F, FontStyle.Regular, GraphicsUnit.Point);
            selectMonthLabel.Location = new Point(33, 482);
            selectMonthLabel.Margin = new Padding(4, 0, 4, 0);
            selectMonthLabel.Name = "selectMonthLabel";
            selectMonthLabel.Size = new Size(135, 26);
            selectMonthLabel.TabIndex = 16;
            selectMonthLabel.Text = "Select Month:";
            // 
            // ProjectViewerForm
            // 
            AutoScaleDimensions = new SizeF(12F, 26F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(890, 708);
            Controls.Add(selectMonthComboBox);
            Controls.Add(selectMonthLabel);
            Controls.Add(viewProjectDataButton);
            Controls.Add(modifyProjectButton);
            Controls.Add(untilValue);
            Controls.Add(untilLabel);
            Controls.Add(fromValue);
            Controls.Add(fromLabel);
            Controls.Add(currentWordsValue);
            Controls.Add(currentWordsLabel);
            Controls.Add(wordsNeededValue);
            Controls.Add(wordsNeededLabel);
            Controls.Add(descriptionTextBox);
            Controls.Add(descriptionLabel);
            Controls.Add(nameValue);
            Controls.Add(nameLabel);
            Font = new Font("Yu Mincho", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "ProjectViewerForm";
            Text = "Project <Project>";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label nameLabel;
        private TextBox nameValue;
        private Label descriptionLabel;
        private RichTextBox descriptionTextBox;
        private TextBox wordsNeededValue;
        private Label wordsNeededLabel;
        private TextBox currentWordsValue;
        private Label currentWordsLabel;
        private TextBox fromValue;
        private Label fromLabel;
        private TextBox untilValue;
        private Label untilLabel;
        private Button modifyProjectButton;
        private Button viewProjectDataButton;
        private ComboBox selectMonthComboBox;
        private Label selectMonthLabel;
    }
}
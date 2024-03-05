namespace TrackerUI
{
    partial class StatsViewerForm
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
            totalWordsProgressBar = new ProgressBar();
            totalWordsGroupBox = new GroupBox();
            totalWordNumberLabel = new Label();
            wordsTodayGroupBox = new GroupBox();
            wordsTodayLabel = new Label();
            wordsTodayProgressBar = new ProgressBar();
            maxWordsGroupBox = new GroupBox();
            maxWordsLabel = new Label();
            leastWordsGroupBox = new GroupBox();
            leastWordsLabel = new Label();
            dailyListingListBox = new ListBox();
            dailyListingLabel = new Label();
            quickAddButton = new Button();
            updateButton = new Button();
            quickAddValue = new TextBox();
            totalWordsGroupBox.SuspendLayout();
            wordsTodayGroupBox.SuspendLayout();
            maxWordsGroupBox.SuspendLayout();
            leastWordsGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // totalWordsProgressBar
            // 
            totalWordsProgressBar.Location = new Point(35, 89);
            totalWordsProgressBar.Name = "totalWordsProgressBar";
            totalWordsProgressBar.Size = new Size(173, 19);
            totalWordsProgressBar.TabIndex = 0;
            // 
            // totalWordsGroupBox
            // 
            totalWordsGroupBox.Controls.Add(totalWordNumberLabel);
            totalWordsGroupBox.Controls.Add(totalWordsProgressBar);
            totalWordsGroupBox.Location = new Point(39, 33);
            totalWordsGroupBox.Name = "totalWordsGroupBox";
            totalWordsGroupBox.Size = new Size(250, 125);
            totalWordsGroupBox.TabIndex = 1;
            totalWordsGroupBox.TabStop = false;
            totalWordsGroupBox.Text = "Total Words ";
            // 
            // totalWordNumberLabel
            // 
            totalWordNumberLabel.AutoSize = true;
            totalWordNumberLabel.Font = new Font("Yu Mincho", 12F, FontStyle.Regular, GraphicsUnit.Point);
            totalWordNumberLabel.Location = new Point(43, 46);
            totalWordNumberLabel.Margin = new Padding(4, 0, 4, 0);
            totalWordNumberLabel.Name = "totalWordNumberLabel";
            totalWordNumberLabel.Size = new Size(157, 26);
            totalWordNumberLabel.TabIndex = 4;
            totalWordNumberLabel.Text = "<wordNumber>";
            // 
            // wordsTodayGroupBox
            // 
            wordsTodayGroupBox.Controls.Add(wordsTodayLabel);
            wordsTodayGroupBox.Controls.Add(wordsTodayProgressBar);
            wordsTodayGroupBox.Location = new Point(355, 33);
            wordsTodayGroupBox.Name = "wordsTodayGroupBox";
            wordsTodayGroupBox.Size = new Size(250, 125);
            wordsTodayGroupBox.TabIndex = 2;
            wordsTodayGroupBox.TabStop = false;
            wordsTodayGroupBox.Text = "Words Needed Today";
            // 
            // wordsTodayLabel
            // 
            wordsTodayLabel.AutoSize = true;
            wordsTodayLabel.Font = new Font("Yu Mincho", 12F, FontStyle.Regular, GraphicsUnit.Point);
            wordsTodayLabel.Location = new Point(43, 46);
            wordsTodayLabel.Margin = new Padding(4, 0, 4, 0);
            wordsTodayLabel.Name = "wordsTodayLabel";
            wordsTodayLabel.Size = new Size(157, 26);
            wordsTodayLabel.TabIndex = 4;
            wordsTodayLabel.Text = "<wordNumber>";
            // 
            // wordsTodayProgressBar
            // 
            wordsTodayProgressBar.Location = new Point(35, 89);
            wordsTodayProgressBar.Name = "wordsTodayProgressBar";
            wordsTodayProgressBar.Size = new Size(173, 19);
            wordsTodayProgressBar.TabIndex = 0;
            // 
            // maxWordsGroupBox
            // 
            maxWordsGroupBox.Controls.Add(maxWordsLabel);
            maxWordsGroupBox.Location = new Point(746, 144);
            maxWordsGroupBox.Name = "maxWordsGroupBox";
            maxWordsGroupBox.Size = new Size(250, 99);
            maxWordsGroupBox.TabIndex = 3;
            maxWordsGroupBox.TabStop = false;
            maxWordsGroupBox.Text = "Max Words";
            // 
            // maxWordsLabel
            // 
            maxWordsLabel.AutoSize = true;
            maxWordsLabel.Font = new Font("Yu Mincho", 12F, FontStyle.Regular, GraphicsUnit.Point);
            maxWordsLabel.Location = new Point(43, 46);
            maxWordsLabel.Margin = new Padding(4, 0, 4, 0);
            maxWordsLabel.Name = "maxWordsLabel";
            maxWordsLabel.Size = new Size(157, 26);
            maxWordsLabel.TabIndex = 4;
            maxWordsLabel.Text = "<wordNumber>";
            // 
            // leastWordsGroupBox
            // 
            leastWordsGroupBox.Controls.Add(leastWordsLabel);
            leastWordsGroupBox.Location = new Point(746, 33);
            leastWordsGroupBox.Name = "leastWordsGroupBox";
            leastWordsGroupBox.Size = new Size(250, 90);
            leastWordsGroupBox.TabIndex = 4;
            leastWordsGroupBox.TabStop = false;
            leastWordsGroupBox.Text = "Least words";
            // 
            // leastWordsLabel
            // 
            leastWordsLabel.AutoSize = true;
            leastWordsLabel.Font = new Font("Yu Mincho", 12F, FontStyle.Regular, GraphicsUnit.Point);
            leastWordsLabel.Location = new Point(43, 46);
            leastWordsLabel.Margin = new Padding(4, 0, 4, 0);
            leastWordsLabel.Name = "leastWordsLabel";
            leastWordsLabel.Size = new Size(157, 26);
            leastWordsLabel.TabIndex = 4;
            leastWordsLabel.Text = "<wordNumber>";
            // 
            // dailyListingListBox
            // 
            dailyListingListBox.FormattingEnabled = true;
            dailyListingListBox.ItemHeight = 26;
            dailyListingListBox.Location = new Point(39, 216);
            dailyListingListBox.Name = "dailyListingListBox";
            dailyListingListBox.Size = new Size(305, 264);
            dailyListingListBox.TabIndex = 5;
            // 
            // dailyListingLabel
            // 
            dailyListingLabel.AutoSize = true;
            dailyListingLabel.Font = new Font("Yu Mincho", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dailyListingLabel.Location = new Point(39, 187);
            dailyListingLabel.Margin = new Padding(4, 0, 4, 0);
            dailyListingLabel.Name = "dailyListingLabel";
            dailyListingLabel.Size = new Size(133, 26);
            dailyListingLabel.TabIndex = 6;
            dailyListingLabel.Text = "Daily Listing:";
            // 
            // quickAddButton
            // 
            quickAddButton.FlatAppearance.BorderColor = Color.FromArgb(192, 0, 0);
            quickAddButton.FlatAppearance.BorderSize = 2;
            quickAddButton.FlatAppearance.MouseDownBackColor = Color.Gainsboro;
            quickAddButton.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            quickAddButton.FlatStyle = FlatStyle.Flat;
            quickAddButton.Location = new Point(683, 360);
            quickAddButton.Name = "quickAddButton";
            quickAddButton.Size = new Size(313, 45);
            quickAddButton.TabIndex = 7;
            quickAddButton.Text = "Quick Add";
            quickAddButton.UseVisualStyleBackColor = true;
            // 
            // updateButton
            // 
            updateButton.FlatAppearance.BorderColor = Color.FromArgb(192, 0, 0);
            updateButton.FlatAppearance.BorderSize = 2;
            updateButton.FlatAppearance.MouseDownBackColor = Color.Gainsboro;
            updateButton.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            updateButton.FlatStyle = FlatStyle.Flat;
            updateButton.Location = new Point(683, 435);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(313, 45);
            updateButton.TabIndex = 8;
            updateButton.Text = "Update";
            updateButton.UseVisualStyleBackColor = true;
            // 
            // quickAddValue
            // 
            quickAddValue.Location = new Point(683, 314);
            quickAddValue.Name = "quickAddValue";
            quickAddValue.Size = new Size(313, 40);
            quickAddValue.TabIndex = 9;
            // 
            // StatsViewerForm
            // 
            AutoScaleDimensions = new SizeF(12F, 26F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1083, 516);
            Controls.Add(quickAddValue);
            Controls.Add(updateButton);
            Controls.Add(quickAddButton);
            Controls.Add(dailyListingLabel);
            Controls.Add(dailyListingListBox);
            Controls.Add(leastWordsGroupBox);
            Controls.Add(maxWordsGroupBox);
            Controls.Add(wordsTodayGroupBox);
            Controls.Add(totalWordsGroupBox);
            Font = new Font("Yu Mincho", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "StatsViewerForm";
            Text = "<project> Stats";
            totalWordsGroupBox.ResumeLayout(false);
            totalWordsGroupBox.PerformLayout();
            wordsTodayGroupBox.ResumeLayout(false);
            wordsTodayGroupBox.PerformLayout();
            maxWordsGroupBox.ResumeLayout(false);
            maxWordsGroupBox.PerformLayout();
            leastWordsGroupBox.ResumeLayout(false);
            leastWordsGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ProgressBar totalWordsProgressBar;
        private GroupBox totalWordsGroupBox;
        private Label totalWordNumberLabel;
        private GroupBox wordsTodayGroupBox;
        private Label wordsTodayLabel;
        private ProgressBar wordsTodayProgressBar;
        private GroupBox maxWordsGroupBox;
        private Label maxWordsLabel;
        private GroupBox leastWordsGroupBox;
        private Label leastWordsLabel;
        private ListBox dailyListingListBox;
        private Label dailyListingLabel;
        private Button quickAddButton;
        private Button updateButton;
        private TextBox quickAddValue;
    }
}
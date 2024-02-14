namespace TrackerUI
{
    partial class TrackerMenuForm
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
            createNewProjectButton = new Button();
            selectProjectComboBox = new ComboBox();
            selectMonthLabel = new Label();
            selectMonthComboBox = new ComboBox();
            openProjectButton = new Button();
            viewProjectDataButton = new Button();
            selectProjectLabel = new Label();
            SuspendLayout();
            // 
            // createNewProjectButton
            // 
            createNewProjectButton.FlatAppearance.BorderColor = Color.FromArgb(192, 0, 0);
            createNewProjectButton.FlatAppearance.BorderSize = 2;
            createNewProjectButton.FlatAppearance.MouseDownBackColor = Color.Gainsboro;
            createNewProjectButton.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            createNewProjectButton.FlatStyle = FlatStyle.Flat;
            createNewProjectButton.Location = new Point(216, 424);
            createNewProjectButton.Name = "createNewProjectButton";
            createNewProjectButton.Size = new Size(313, 45);
            createNewProjectButton.TabIndex = 1;
            createNewProjectButton.Text = "Create New Project";
            createNewProjectButton.UseVisualStyleBackColor = true;
            // 
            // selectProjectComboBox
            // 
            selectProjectComboBox.BackColor = Color.WhiteSmoke;
            selectProjectComboBox.FormattingEnabled = true;
            selectProjectComboBox.Location = new Point(47, 63);
            selectProjectComboBox.Name = "selectProjectComboBox";
            selectProjectComboBox.Size = new Size(651, 34);
            selectProjectComboBox.TabIndex = 2;
            // 
            // selectMonthLabel
            // 
            selectMonthLabel.AutoSize = true;
            selectMonthLabel.Font = new Font("Yu Mincho", 12F, FontStyle.Regular, GraphicsUnit.Point);
            selectMonthLabel.Location = new Point(87, 138);
            selectMonthLabel.Margin = new Padding(4, 0, 4, 0);
            selectMonthLabel.Name = "selectMonthLabel";
            selectMonthLabel.Size = new Size(135, 26);
            selectMonthLabel.TabIndex = 3;
            selectMonthLabel.Text = "Select Month:";
            // 
            // selectMonthComboBox
            // 
            selectMonthComboBox.BackColor = Color.WhiteSmoke;
            selectMonthComboBox.FormattingEnabled = true;
            selectMonthComboBox.Location = new Point(47, 178);
            selectMonthComboBox.Name = "selectMonthComboBox";
            selectMonthComboBox.Size = new Size(651, 34);
            selectMonthComboBox.TabIndex = 4;
            // 
            // openProjectButton
            // 
            openProjectButton.FlatAppearance.BorderColor = Color.FromArgb(192, 0, 0);
            openProjectButton.FlatAppearance.BorderSize = 2;
            openProjectButton.FlatAppearance.MouseDownBackColor = Color.Gainsboro;
            openProjectButton.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            openProjectButton.FlatStyle = FlatStyle.Flat;
            openProjectButton.Location = new Point(216, 249);
            openProjectButton.Name = "openProjectButton";
            openProjectButton.Size = new Size(313, 45);
            openProjectButton.TabIndex = 5;
            openProjectButton.Text = "Open Project";
            openProjectButton.UseVisualStyleBackColor = true;
            // 
            // viewProjectDataButton
            // 
            viewProjectDataButton.FlatAppearance.BorderColor = Color.FromArgb(192, 0, 0);
            viewProjectDataButton.FlatAppearance.BorderSize = 2;
            viewProjectDataButton.FlatAppearance.MouseDownBackColor = Color.Gainsboro;
            viewProjectDataButton.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            viewProjectDataButton.FlatStyle = FlatStyle.Flat;
            viewProjectDataButton.Location = new Point(216, 314);
            viewProjectDataButton.Name = "viewProjectDataButton";
            viewProjectDataButton.Size = new Size(313, 45);
            viewProjectDataButton.TabIndex = 6;
            viewProjectDataButton.Text = "View Project Data";
            viewProjectDataButton.UseVisualStyleBackColor = true;
            // 
            // selectProjectLabel
            // 
            selectProjectLabel.AutoSize = true;
            selectProjectLabel.Font = new Font("Yu Mincho", 12F, FontStyle.Regular, GraphicsUnit.Point);
            selectProjectLabel.Location = new Point(85, 23);
            selectProjectLabel.Margin = new Padding(4, 0, 4, 0);
            selectProjectLabel.Name = "selectProjectLabel";
            selectProjectLabel.Size = new Size(137, 26);
            selectProjectLabel.TabIndex = 0;
            selectProjectLabel.Text = "Select project:";
            // 
            // TrackerMenuForm
            // 
            AutoScaleDimensions = new SizeF(12F, 26F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(745, 500);
            Controls.Add(viewProjectDataButton);
            Controls.Add(openProjectButton);
            Controls.Add(selectMonthComboBox);
            Controls.Add(selectMonthLabel);
            Controls.Add(selectProjectComboBox);
            Controls.Add(createNewProjectButton);
            Controls.Add(selectProjectLabel);
            Font = new Font("Yu Mincho", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5, 4, 5, 4);
            Name = "TrackerMenuForm";
            Text = "Tracker Menu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button createNewProjectButton;
        private ComboBox selectProjectComboBox;
        private Label selectMonthLabel;
        private ComboBox selectMonthComboBox;
        private Button openProjectButton;
        private Button viewProjectDataButton;
        private Label selectProjectLabel;
    }
}
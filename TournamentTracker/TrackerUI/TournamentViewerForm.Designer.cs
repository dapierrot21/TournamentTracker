
namespace TrackerUI
{
    partial class roundDropDown
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
            this.tournamentViewer = new System.Windows.Forms.Label();
            this.TournamentName = new System.Windows.Forms.Label();
            this.roundLabel = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.unplayedCheckBox = new System.Windows.Forms.CheckBox();
            this.matchupListBox = new System.Windows.Forms.ListBox();
            this.teamOneName = new System.Windows.Forms.Label();
            this.teamOneScore = new System.Windows.Forms.Label();
            this.teamOneScoreValue = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.teamTwoScoreValue = new System.Windows.Forms.Label();
            this.teamTwoName = new System.Windows.Forms.Label();
            this.vsLabel = new System.Windows.Forms.Label();
            this.scoreButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tournamentViewer
            // 
            this.tournamentViewer.AutoSize = true;
            this.tournamentViewer.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tournamentViewer.ForeColor = System.Drawing.Color.White;
            this.tournamentViewer.Location = new System.Drawing.Point(0, -1);
            this.tournamentViewer.Name = "tournamentViewer";
            this.tournamentViewer.Size = new System.Drawing.Size(339, 70);
            this.tournamentViewer.TabIndex = 0;
            this.tournamentViewer.Text = "Tournament:";
            this.tournamentViewer.Click += new System.EventHandler(this.label1_Click);
            // 
            // TournamentName
            // 
            this.TournamentName.AutoSize = true;
            this.TournamentName.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TournamentName.ForeColor = System.Drawing.Color.White;
            this.TournamentName.Location = new System.Drawing.Point(335, 3);
            this.TournamentName.Name = "TournamentName";
            this.TournamentName.Size = new System.Drawing.Size(209, 65);
            this.TournamentName.TabIndex = 1;
            this.TournamentName.Text = "<none>";
            // 
            // roundLabel
            // 
            this.roundLabel.AutoSize = true;
            this.roundLabel.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundLabel.ForeColor = System.Drawing.Color.Aqua;
            this.roundLabel.Location = new System.Drawing.Point(42, 132);
            this.roundLabel.Name = "roundLabel";
            this.roundLabel.Size = new System.Drawing.Size(161, 60);
            this.roundLabel.TabIndex = 2;
            this.roundLabel.Text = "Round";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(209, 146);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(224, 46);
            this.comboBox1.TabIndex = 3;
            // 
            // unplayedCheckBox
            // 
            this.unplayedCheckBox.AutoSize = true;
            this.unplayedCheckBox.ForeColor = System.Drawing.Color.Aqua;
            this.unplayedCheckBox.Location = new System.Drawing.Point(209, 217);
            this.unplayedCheckBox.Name = "unplayedCheckBox";
            this.unplayedCheckBox.Size = new System.Drawing.Size(230, 42);
            this.unplayedCheckBox.TabIndex = 4;
            this.unplayedCheckBox.Text = "Unplayed Only";
            this.unplayedCheckBox.UseVisualStyleBackColor = true;
            // 
            // matchupListBox
            // 
            this.matchupListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.matchupListBox.FormattingEnabled = true;
            this.matchupListBox.ItemHeight = 38;
            this.matchupListBox.Location = new System.Drawing.Point(52, 308);
            this.matchupListBox.Name = "matchupListBox";
            this.matchupListBox.Size = new System.Drawing.Size(381, 268);
            this.matchupListBox.TabIndex = 5;
            // 
            // teamOneName
            // 
            this.teamOneName.AutoSize = true;
            this.teamOneName.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamOneName.ForeColor = System.Drawing.Color.Aqua;
            this.teamOneName.Location = new System.Drawing.Point(506, 308);
            this.teamOneName.Name = "teamOneName";
            this.teamOneName.Size = new System.Drawing.Size(187, 38);
            this.teamOneName.TabIndex = 6;
            this.teamOneName.Text = "<Team One>";
            // 
            // teamOneScore
            // 
            this.teamOneScore.AutoSize = true;
            this.teamOneScore.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamOneScore.ForeColor = System.Drawing.Color.Aqua;
            this.teamOneScore.Location = new System.Drawing.Point(506, 374);
            this.teamOneScore.Name = "teamOneScore";
            this.teamOneScore.Size = new System.Drawing.Size(89, 38);
            this.teamOneScore.TabIndex = 7;
            this.teamOneScore.Text = "Score";
            // 
            // teamOneScoreValue
            // 
            this.teamOneScoreValue.Location = new System.Drawing.Point(640, 367);
            this.teamOneScoreValue.Name = "teamOneScoreValue";
            this.teamOneScoreValue.Size = new System.Drawing.Size(100, 45);
            this.teamOneScoreValue.TabIndex = 8;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(641, 537);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 45);
            this.textBox1.TabIndex = 11;
            // 
            // teamTwoScoreValue
            // 
            this.teamTwoScoreValue.AutoSize = true;
            this.teamTwoScoreValue.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamTwoScoreValue.ForeColor = System.Drawing.Color.Aqua;
            this.teamTwoScoreValue.Location = new System.Drawing.Point(507, 544);
            this.teamTwoScoreValue.Name = "teamTwoScoreValue";
            this.teamTwoScoreValue.Size = new System.Drawing.Size(89, 38);
            this.teamTwoScoreValue.TabIndex = 10;
            this.teamTwoScoreValue.Text = "Score";
            // 
            // teamTwoName
            // 
            this.teamTwoName.AutoSize = true;
            this.teamTwoName.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamTwoName.ForeColor = System.Drawing.Color.Aqua;
            this.teamTwoName.Location = new System.Drawing.Point(507, 484);
            this.teamTwoName.Name = "teamTwoName";
            this.teamTwoName.Size = new System.Drawing.Size(188, 38);
            this.teamTwoName.TabIndex = 9;
            this.teamTwoName.Text = "<Team Two>";
            // 
            // vsLabel
            // 
            this.vsLabel.AutoSize = true;
            this.vsLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vsLabel.ForeColor = System.Drawing.Color.Aqua;
            this.vsLabel.Location = new System.Drawing.Point(575, 433);
            this.vsLabel.Name = "vsLabel";
            this.vsLabel.Size = new System.Drawing.Size(70, 30);
            this.vsLabel.TabIndex = 12;
            this.vsLabel.Text = "- VS -";
            this.vsLabel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // scoreButton
            // 
            this.scoreButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.scoreButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.scoreButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.scoreButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.scoreButton.ForeColor = System.Drawing.Color.Aqua;
            this.scoreButton.Location = new System.Drawing.Point(772, 433);
            this.scoreButton.Name = "scoreButton";
            this.scoreButton.Size = new System.Drawing.Size(144, 80);
            this.scoreButton.TabIndex = 13;
            this.scoreButton.Text = "Score";
            this.scoreButton.UseVisualStyleBackColor = true;
            // 
            // roundDropDown
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 38F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(979, 629);
            this.Controls.Add(this.scoreButton);
            this.Controls.Add(this.vsLabel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.teamTwoScoreValue);
            this.Controls.Add(this.teamTwoName);
            this.Controls.Add(this.teamOneScoreValue);
            this.Controls.Add(this.teamOneScore);
            this.Controls.Add(this.teamOneName);
            this.Controls.Add(this.matchupListBox);
            this.Controls.Add(this.unplayedCheckBox);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.roundLabel);
            this.Controls.Add(this.TournamentName);
            this.Controls.Add(this.tournamentViewer);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "roundDropDown";
            this.Text = "Tournament Viewer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tournamentViewer;
        private System.Windows.Forms.Label TournamentName;
        private System.Windows.Forms.Label roundLabel;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.CheckBox unplayedCheckBox;
        private System.Windows.Forms.ListBox matchupListBox;
        private System.Windows.Forms.Label teamOneName;
        private System.Windows.Forms.Label teamOneScore;
        private System.Windows.Forms.TextBox teamOneScoreValue;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label teamTwoScoreValue;
        private System.Windows.Forms.Label teamTwoName;
        private System.Windows.Forms.Label vsLabel;
        private System.Windows.Forms.Button scoreButton;
    }
}


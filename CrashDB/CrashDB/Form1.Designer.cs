namespace CrashDB
{
    partial class Form1
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
            playerTagLabel = new Label();
            playerTag = new TextBox();
            lastConnectionLabel = new Label();
            scoreLabel = new Label();
            levelLabel = new Label();
            lastConnection = new DateTimePicker();
            level = new NumericUpDown();
            splitContainer1 = new SplitContainer();
            playerScore = new NumericUpDown();
            createButton = new Button();
            panel1 = new Panel();
            connectButton = new Button();
            searchButton = new Button();
            deleteButton = new Button();
            updateButton = new Button();
            crashDBView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)level).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)playerScore).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)crashDBView).BeginInit();
            SuspendLayout();
            // 
            // playerTagLabel
            // 
            playerTagLabel.AutoSize = true;
            playerTagLabel.Location = new Point(57, 30);
            playerTagLabel.Name = "playerTagLabel";
            playerTagLabel.Size = new Size(60, 15);
            playerTagLabel.TabIndex = 0;
            playerTagLabel.Text = "Player Tag";
            // 
            // playerTag
            // 
            playerTag.Location = new Point(13, 22);
            playerTag.Name = "playerTag";
            playerTag.Size = new Size(100, 23);
            playerTag.TabIndex = 1;
            // 
            // lastConnectionLabel
            // 
            lastConnectionLabel.AutoSize = true;
            lastConnectionLabel.Location = new Point(24, 117);
            lastConnectionLabel.Name = "lastConnectionLabel";
            lastConnectionLabel.Size = new Size(93, 15);
            lastConnectionLabel.TabIndex = 2;
            lastConnectionLabel.Text = "Last Connection";
            // 
            // scoreLabel
            // 
            scoreLabel.AutoSize = true;
            scoreLabel.Location = new Point(81, 88);
            scoreLabel.Name = "scoreLabel";
            scoreLabel.Size = new Size(36, 15);
            scoreLabel.TabIndex = 3;
            scoreLabel.Text = "Score";
            // 
            // levelLabel
            // 
            levelLabel.AutoSize = true;
            levelLabel.Location = new Point(83, 59);
            levelLabel.Name = "levelLabel";
            levelLabel.Size = new Size(34, 15);
            levelLabel.TabIndex = 4;
            levelLabel.Text = "Level";
            // 
            // lastConnection
            // 
            lastConnection.Location = new Point(13, 109);
            lastConnection.Name = "lastConnection";
            lastConnection.Size = new Size(200, 23);
            lastConnection.TabIndex = 5;
            // 
            // level
            // 
            level.Location = new Point(13, 51);
            level.Name = "level";
            level.Size = new Size(120, 23);
            level.TabIndex = 6;
            // 
            // splitContainer1
            // 
            splitContainer1.Location = new Point(162, 30);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(playerTagLabel);
            splitContainer1.Panel1.Controls.Add(levelLabel);
            splitContainer1.Panel1.Controls.Add(lastConnectionLabel);
            splitContainer1.Panel1.Controls.Add(scoreLabel);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(playerScore);
            splitContainer1.Panel2.Controls.Add(playerTag);
            splitContainer1.Panel2.Controls.Add(lastConnection);
            splitContainer1.Panel2.Controls.Add(level);
            splitContainer1.Size = new Size(393, 151);
            splitContainer1.SplitterDistance = 143;
            splitContainer1.TabIndex = 0;
            // 
            // playerScore
            // 
            playerScore.Location = new Point(13, 80);
            playerScore.Name = "playerScore";
            playerScore.Size = new Size(120, 23);
            playerScore.TabIndex = 7;
            // 
            // createButton
            // 
            createButton.Location = new Point(123, 18);
            createButton.Name = "createButton";
            createButton.Size = new Size(75, 23);
            createButton.TabIndex = 1;
            createButton.Text = "Create";
            createButton.UseVisualStyleBackColor = true;
            createButton.Click += createButton_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(connectButton);
            panel1.Controls.Add(searchButton);
            panel1.Controls.Add(deleteButton);
            panel1.Controls.Add(updateButton);
            panel1.Controls.Add(createButton);
            panel1.Location = new Point(162, 187);
            panel1.Name = "panel1";
            panel1.Size = new Size(393, 100);
            panel1.TabIndex = 2;
            // 
            // connectButton
            // 
            connectButton.Location = new Point(285, 57);
            connectButton.Name = "connectButton";
            connectButton.Size = new Size(75, 23);
            connectButton.TabIndex = 5;
            connectButton.Text = "Connect";
            connectButton.UseVisualStyleBackColor = true;
            connectButton.Click += connectButton_Click;
            // 
            // searchButton
            // 
            searchButton.Location = new Point(204, 57);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(75, 23);
            searchButton.TabIndex = 4;
            searchButton.Text = "Search";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += searchButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(285, 18);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(75, 23);
            deleteButton.TabIndex = 3;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = true;
            // 
            // updateButton
            // 
            updateButton.Location = new Point(204, 18);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(75, 23);
            updateButton.TabIndex = 2;
            updateButton.Text = "Update";
            updateButton.UseVisualStyleBackColor = true;
            updateButton.Click += updateButton_Click;
            // 
            // crashDBView
            // 
            crashDBView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            crashDBView.Location = new Point(162, 293);
            crashDBView.Name = "crashDBView";
            crashDBView.Size = new Size(393, 150);
            crashDBView.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(crashDBView);
            Controls.Add(panel1);
            Controls.Add(splitContainer1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)level).EndInit();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)playerScore).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)crashDBView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label playerTagLabel; // 
        private Label levelLabel;
        private Label scoreLabel;
        private Label lastConnectionLabel;
        private TextBox playerTag;
        private NumericUpDown level; // Level
        private NumericUpDown playerScore; // Score
        private DateTimePicker lastConnection;
        private SplitContainer splitContainer1;
        private Panel panel1;
        private Button createButton;
        private Button updateButton;
        private Button deleteButton;
        private Button searchButton;
        private Button connectButton;
        private DataGridView crashDBView;
    }
}

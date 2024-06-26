﻿namespace FacebookWinFormsApp
{
    internal partial class FormMain
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
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.panelSidebarProfile = new System.Windows.Forms.Panel();
            this.labelProfileName = new System.Windows.Forms.Label();
            this.pictureBoxProfilePicture = new System.Windows.Forms.PictureBox();
            this.panelSidebarButtons = new System.Windows.Forms.Panel();
            this.buttonFriends = new System.Windows.Forms.Button();
            this.buttonLikedPages = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.buttonPosts = new System.Windows.Forms.Button();
            this.buttonStatistics = new System.Windows.Forms.Button();
            this.buttonAlbums = new System.Windows.Forms.Button();
            this.buttonEvents = new System.Windows.Forms.Button();
            this.buttonFavoriteTeams = new System.Windows.Forms.Button();
            this.buttonGroups = new System.Windows.Forms.Button();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.panelLogin = new System.Windows.Forms.Panel();
            this.checkBoxRememberMe = new System.Windows.Forms.CheckBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.labelLoginMessage = new System.Windows.Forms.Label();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.panelSidebar.SuspendLayout();
            this.panelSidebarProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfilePicture)).BeginInit();
            this.panelSidebarButtons.SuspendLayout();
            this.panelDesktop.SuspendLayout();
            this.panelLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSidebar
            // 
            this.panelSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.panelSidebar.Controls.Add(this.panelSidebarProfile);
            this.panelSidebar.Controls.Add(this.panelSidebarButtons);
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidebar.Location = new System.Drawing.Point(0, 0);
            this.panelSidebar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(300, 680);
            this.panelSidebar.TabIndex = 53;
            // 
            // panelSidebarProfile
            // 
            this.panelSidebarProfile.Controls.Add(this.labelProfileName);
            this.panelSidebarProfile.Controls.Add(this.pictureBoxProfilePicture);
            this.panelSidebarProfile.Location = new System.Drawing.Point(0, 2);
            this.panelSidebarProfile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelSidebarProfile.Name = "panelSidebarProfile";
            this.panelSidebarProfile.Size = new System.Drawing.Size(300, 154);
            this.panelSidebarProfile.TabIndex = 12;
            // 
            // labelProfileName
            // 
            this.labelProfileName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelProfileName.AutoSize = true;
            this.labelProfileName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProfileName.ForeColor = System.Drawing.Color.White;
            this.labelProfileName.Location = new System.Drawing.Point(55, 128);
            this.labelProfileName.Name = "labelProfileName";
            this.labelProfileName.Size = new System.Drawing.Size(201, 28);
            this.labelProfileName.TabIndex = 1;
            this.labelProfileName.Text = "Firstname Lastname";
            this.labelProfileName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelProfileName.Visible = false;
            this.labelProfileName.Click += new System.EventHandler(this.showUsersProfileForm);
            // 
            // pictureBoxProfilePicture
            // 
            this.pictureBoxProfilePicture.Location = new System.Drawing.Point(86, 21);
            this.pictureBoxProfilePicture.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxProfilePicture.Name = "pictureBoxProfilePicture";
            this.pictureBoxProfilePicture.Size = new System.Drawing.Size(121, 106);
            this.pictureBoxProfilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxProfilePicture.TabIndex = 0;
            this.pictureBoxProfilePicture.TabStop = false;
            this.pictureBoxProfilePicture.Click += new System.EventHandler(this.showUsersProfileForm);
            // 
            // panelSidebarButtons
            // 
            this.panelSidebarButtons.Controls.Add(this.buttonFriends);
            this.panelSidebarButtons.Controls.Add(this.buttonLikedPages);
            this.panelSidebarButtons.Controls.Add(this.buttonLogout);
            this.panelSidebarButtons.Controls.Add(this.buttonPosts);
            this.panelSidebarButtons.Controls.Add(this.buttonStatistics);
            this.panelSidebarButtons.Controls.Add(this.buttonAlbums);
            this.panelSidebarButtons.Controls.Add(this.buttonEvents);
            this.panelSidebarButtons.Controls.Add(this.buttonFavoriteTeams);
            this.panelSidebarButtons.Controls.Add(this.buttonGroups);
            this.panelSidebarButtons.Location = new System.Drawing.Point(3, 174);
            this.panelSidebarButtons.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelSidebarButtons.Name = "panelSidebarButtons";
            this.panelSidebarButtons.Size = new System.Drawing.Size(280, 482);
            this.panelSidebarButtons.TabIndex = 11;
            // 
            // buttonFriends
            // 
            this.buttonFriends.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.buttonFriends.Enabled = false;
            this.buttonFriends.FlatAppearance.BorderSize = 0;
            this.buttonFriends.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFriends.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonFriends.ForeColor = System.Drawing.Color.White;
            this.buttonFriends.Image = global::BasicFacebookFeatures.Properties.Resources.Friends;
            this.buttonFriends.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonFriends.Location = new System.Drawing.Point(2, 268);
            this.buttonFriends.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonFriends.Name = "buttonFriends";
            this.buttonFriends.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonFriends.Size = new System.Drawing.Size(280, 43);
            this.buttonFriends.TabIndex = 6;
            this.buttonFriends.Text = "Friends";
            this.buttonFriends.UseVisualStyleBackColor = false;
            this.buttonFriends.Click += new System.EventHandler(this.buttonFriends_Click);
            // 
            // buttonLikedPages
            // 
            this.buttonLikedPages.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.buttonLikedPages.Enabled = false;
            this.buttonLikedPages.FlatAppearance.BorderSize = 0;
            this.buttonLikedPages.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLikedPages.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonLikedPages.ForeColor = System.Drawing.Color.White;
            this.buttonLikedPages.Image = global::BasicFacebookFeatures.Properties.Resources.Liked_Pages;
            this.buttonLikedPages.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLikedPages.Location = new System.Drawing.Point(2, 224);
            this.buttonLikedPages.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonLikedPages.Name = "buttonLikedPages";
            this.buttonLikedPages.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonLikedPages.Size = new System.Drawing.Size(280, 43);
            this.buttonLikedPages.TabIndex = 5;
            this.buttonLikedPages.Text = "Liked Pages";
            this.buttonLikedPages.UseVisualStyleBackColor = false;
            this.buttonLikedPages.Click += new System.EventHandler(this.buttonLikedPages_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.buttonLogout.Enabled = false;
            this.buttonLogout.FlatAppearance.BorderSize = 0;
            this.buttonLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogout.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonLogout.ForeColor = System.Drawing.Color.White;
            this.buttonLogout.Location = new System.Drawing.Point(5, 472);
            this.buttonLogout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(280, 43);
            this.buttonLogout.TabIndex = 9;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = false;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // buttonPosts
            // 
            this.buttonPosts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.buttonPosts.Enabled = false;
            this.buttonPosts.FlatAppearance.BorderSize = 0;
            this.buttonPosts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPosts.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonPosts.ForeColor = System.Drawing.Color.White;
            this.buttonPosts.Image = global::BasicFacebookFeatures.Properties.Resources.Posts;
            this.buttonPosts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPosts.Location = new System.Drawing.Point(2, 2);
            this.buttonPosts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonPosts.Name = "buttonPosts";
            this.buttonPosts.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonPosts.Size = new System.Drawing.Size(280, 43);
            this.buttonPosts.TabIndex = 0;
            this.buttonPosts.Text = "Posts";
            this.buttonPosts.UseVisualStyleBackColor = true;
            this.buttonPosts.Click += new System.EventHandler(this.buttonPosts_Click);
            // 
            // buttonStatistics
            // 
            this.buttonStatistics.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.buttonStatistics.Enabled = false;
            this.buttonStatistics.FlatAppearance.BorderSize = 0;
            this.buttonStatistics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStatistics.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonStatistics.ForeColor = System.Drawing.Color.White;
            this.buttonStatistics.Image = global::BasicFacebookFeatures.Properties.Resources.Statistics;
            this.buttonStatistics.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonStatistics.Location = new System.Drawing.Point(2, 312);
            this.buttonStatistics.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonStatistics.Name = "buttonStatistics";
            this.buttonStatistics.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonStatistics.Size = new System.Drawing.Size(280, 43);
            this.buttonStatistics.TabIndex = 7;
            this.buttonStatistics.Text = "Statistics";
            this.buttonStatistics.UseVisualStyleBackColor = false;
            this.buttonStatistics.Click += new System.EventHandler(this.buttonStatistics_Click);
            // 
            // buttonAlbums
            // 
            this.buttonAlbums.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.buttonAlbums.Enabled = false;
            this.buttonAlbums.FlatAppearance.BorderSize = 0;
            this.buttonAlbums.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAlbums.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonAlbums.ForeColor = System.Drawing.Color.White;
            this.buttonAlbums.Image = global::BasicFacebookFeatures.Properties.Resources.Albums;
            this.buttonAlbums.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAlbums.Location = new System.Drawing.Point(2, 46);
            this.buttonAlbums.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAlbums.Name = "buttonAlbums";
            this.buttonAlbums.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonAlbums.Size = new System.Drawing.Size(280, 43);
            this.buttonAlbums.TabIndex = 1;
            this.buttonAlbums.Text = "Albums";
            this.buttonAlbums.UseVisualStyleBackColor = false;
            this.buttonAlbums.Click += new System.EventHandler(this.buttonAlbums_Click);
            // 
            // buttonEvents
            // 
            this.buttonEvents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.buttonEvents.Enabled = false;
            this.buttonEvents.FlatAppearance.BorderSize = 0;
            this.buttonEvents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEvents.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonEvents.ForeColor = System.Drawing.Color.White;
            this.buttonEvents.Image = global::BasicFacebookFeatures.Properties.Resources.Events;
            this.buttonEvents.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEvents.Location = new System.Drawing.Point(2, 91);
            this.buttonEvents.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonEvents.Name = "buttonEvents";
            this.buttonEvents.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonEvents.Size = new System.Drawing.Size(280, 43);
            this.buttonEvents.TabIndex = 2;
            this.buttonEvents.Text = "Events";
            this.buttonEvents.UseVisualStyleBackColor = false;
            this.buttonEvents.Click += new System.EventHandler(this.buttonEvents_Click);
            // 
            // buttonFavoriteTeams
            // 
            this.buttonFavoriteTeams.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.buttonFavoriteTeams.Enabled = false;
            this.buttonFavoriteTeams.FlatAppearance.BorderSize = 0;
            this.buttonFavoriteTeams.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFavoriteTeams.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonFavoriteTeams.ForeColor = System.Drawing.Color.White;
            this.buttonFavoriteTeams.Image = global::BasicFacebookFeatures.Properties.Resources.Favorite_Teams;
            this.buttonFavoriteTeams.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonFavoriteTeams.Location = new System.Drawing.Point(2, 180);
            this.buttonFavoriteTeams.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonFavoriteTeams.Name = "buttonFavoriteTeams";
            this.buttonFavoriteTeams.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonFavoriteTeams.Size = new System.Drawing.Size(280, 43);
            this.buttonFavoriteTeams.TabIndex = 4;
            this.buttonFavoriteTeams.Text = "Favorite Teams";
            this.buttonFavoriteTeams.UseVisualStyleBackColor = false;
            this.buttonFavoriteTeams.Click += new System.EventHandler(this.buttonFavoriteTeams_Click);
            // 
            // buttonGroups
            // 
            this.buttonGroups.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.buttonGroups.Enabled = false;
            this.buttonGroups.FlatAppearance.BorderSize = 0;
            this.buttonGroups.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGroups.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonGroups.ForeColor = System.Drawing.Color.White;
            this.buttonGroups.Image = global::BasicFacebookFeatures.Properties.Resources.Groups;
            this.buttonGroups.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonGroups.Location = new System.Drawing.Point(2, 136);
            this.buttonGroups.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonGroups.Name = "buttonGroups";
            this.buttonGroups.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonGroups.Size = new System.Drawing.Size(280, 43);
            this.buttonGroups.TabIndex = 3;
            this.buttonGroups.Text = "Groups";
            this.buttonGroups.UseVisualStyleBackColor = false;
            this.buttonGroups.Click += new System.EventHandler(this.buttonGroups_Click);
            // 
            // panelDesktop
            // 
            this.panelDesktop.Controls.Add(this.panelLogin);
            this.panelDesktop.Controls.Add(this.panelSidebar);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(0, 0);
            this.panelDesktop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1147, 680);
            this.panelDesktop.TabIndex = 54;
            // 
            // panelLogin
            // 
            this.panelLogin.BackColor = System.Drawing.Color.White;
            this.panelLogin.Controls.Add(this.checkBoxRememberMe);
            this.panelLogin.Controls.Add(this.buttonLogin);
            this.panelLogin.Controls.Add(this.labelLoginMessage);
            this.panelLogin.Controls.Add(this.labelWelcome);
            this.panelLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLogin.Location = new System.Drawing.Point(300, 0);
            this.panelLogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(847, 680);
            this.panelLogin.TabIndex = 54;
            // 
            // checkBoxRememberMe
            // 
            this.checkBoxRememberMe.AutoSize = true;
            this.checkBoxRememberMe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.checkBoxRememberMe.Location = new System.Drawing.Point(356, 314);
            this.checkBoxRememberMe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxRememberMe.Name = "checkBoxRememberMe";
            this.checkBoxRememberMe.Size = new System.Drawing.Size(161, 29);
            this.checkBoxRememberMe.TabIndex = 42;
            this.checkBoxRememberMe.Text = "Remember me";
            this.checkBoxRememberMe.UseVisualStyleBackColor = true;
            this.checkBoxRememberMe.Visible = false;
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(338, 270);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(217, 40);
            this.buttonLogin.TabIndex = 41;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Visible = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // labelLoginMessage
            // 
            this.labelLoginMessage.AutoSize = true;
            this.labelLoginMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelLoginMessage.Location = new System.Drawing.Point(249, 229);
            this.labelLoginMessage.Name = "labelLoginMessage";
            this.labelLoginMessage.Size = new System.Drawing.Size(379, 39);
            this.labelLoginMessage.TabIndex = 40;
            this.labelLoginMessage.Text = "Please login to continue";
            this.labelLoginMessage.Visible = false;
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelWelcome.Location = new System.Drawing.Point(144, 126);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(572, 113);
            this.labelWelcome.TabIndex = 39;
            this.labelWelcome.Text = "WELCOME";
            this.labelWelcome.Visible = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1147, 680);
            this.Controls.Add(this.panelDesktop);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facebook";
            this.panelSidebar.ResumeLayout(false);
            this.panelSidebarProfile.ResumeLayout(false);
            this.panelSidebarProfile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfilePicture)).EndInit();
            this.panelSidebarButtons.ResumeLayout(false);
            this.panelDesktop.ResumeLayout(false);
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            this.ResumeLayout(false);

        }

		#endregion
        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Button buttonStatistics;
        private System.Windows.Forms.Button buttonLikedPages;
        private System.Windows.Forms.Button buttonFavoriteTeams;
        private System.Windows.Forms.Button buttonGroups;
        private System.Windows.Forms.Button buttonEvents;
        private System.Windows.Forms.Button buttonAlbums;
        private System.Windows.Forms.Button buttonPosts;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.CheckBox checkBoxRememberMe;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Label labelLoginMessage;
        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.Panel panelSidebarButtons;
        private System.Windows.Forms.Panel panelSidebarProfile;
        private System.Windows.Forms.Label labelProfileName;
        private System.Windows.Forms.PictureBox pictureBoxProfilePicture;
        private System.Windows.Forms.Button buttonFriends;
    }
}

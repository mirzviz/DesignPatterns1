using FacebookWrapper;
using Facebook;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace DesignPatterns1
{
    public partial class Form1 : Form
    {
        private LoginResult m_LoggedInUser;
        private AppSettings m_AppSettings;

        public Form1()
        {
            InitializeComponent();
            m_AppSettings = AppSettings.LoadFromFile();
            this.Size = m_AppSettings.m_LastWindowSize;
            this.Location = m_AppSettings.m_LastWindowLocation;
            checkBoxRememberUser.Checked = m_AppSettings.m_RememberUser;
        }


        private void loginAndInit()
        {
            LoginResult result;
            if (string.IsNullOrEmpty(m_AppSettings.m_LastAccessToke) || !m_AppSettings.m_RememberUser)
            {
                /// Use the FacebookService.Login method to display the login form to any user who wish to use this application.
                /// You can then save the result.AccessToken for future auto-connect to this user:
                result = FacebookService.Login("998614020318861", /// (desig patter's "Design Patterns Course App 2.4" app)
                "public_profile",
                    //"user_education_history",
                    //"user_birthday",
                    //"user_actions.video",
                    //"user_actions.news",
                    //"user_actions.music"
                    //"user_actions.fitness",
                    //"user_actions.books",
                    //"user_about_me",
                    "user_friends",
                    //"publish_actions",
                    //"user_events",
                    //"user_games_activity",
                    //"user_groups" (This permission is only available for apps using Graph API version v2.3 or older.)
                    //"user_hometown",
                    //"user_likes",
                    //"user_location",
                    //"user_managed_groups",
                    //"user_photos",
                    "user_posts",
                    //"user_relationships",
                    //"user_relationship_details",
                    //"user_religion_politics",

                    //"user_status" (This permission is only available for apps using Graph API version v2.3 or older.)
                    //"user_tagged_places",
                    //"user_videos",
                    //"user_website",
                    //"user_work_history",
                    //"read_custom_friendlists",

                    // "read_mailbox", (This permission is only available for apps using Graph API version v2.3 or older.)
                    //"read_page_mailboxes",
                    // "read_stream", (This permission is only available for apps using Graph API version v2.3 or older.)
                    // "manage_notifications", (This permission is only available for apps using Graph API version v2.3 or older.)
                    "manage_pages",
                    "publish_pages"
                    //"publish_actions",

                    //"rsvp_event"
                    );
                // These are NOT the complete list of permissions. Other permissions for example:
                // "user_birthday", "user_education_history", "user_hometown", "user_likes","user_location","user_relationships","user_relationship_details","user_religion_politics", "user_videos", "user_website", "user_work_history", "email","read_insights","rsvp_event","manage_pages"
                // The documentation regarding facebook login and permissions can be found here: 
                // https://developers.facebook.com/docs/facebook-login/permissions#reference
            }
            else
            {
                result = FacebookService.Connect(m_AppSettings.m_LastAccessToke);
            }

            if (!string.IsNullOrEmpty(result.AccessToken))
            {
                m_LoggedInUser = result;
                fetchUsersPhoto();
            }
            else
            {
                MessageBox.Show(result.ErrorMessage);
            }
        }

        private void fetchUsersPhoto()
        {
            pictureBox.LoadAsync(m_LoggedInUser.LoggedInUser.PictureNormalURL);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loginAndInit();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            if (m_AppSettings.m_RememberUser)
            {
                loginAndInit();
                fetchUsersPhoto();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void buttonFetchFriends_Click(object sender, EventArgs e)
        {
            fetchFriends();
        }

        private void fetchFriends()
        {
            listBoxFriends.Items.Clear();
            listBoxFriends.DisplayMember = "Name";
            foreach (User friend in m_LoggedInUser.LoggedInUser.Friends)
            {
                listBoxFriends.Items.Add(friend);
                friend.ReFetch(DynamicWrapper.eLoadOptions.Full);
            }

            if (m_LoggedInUser.LoggedInUser.Friends.Count == 0)
            {
                MessageBox.Show("No Friends to retrieve :(");
            }
        }

        private void buttonPostStatus_Click(object sender, EventArgs e)
        {
            Status postedStatus = m_LoggedInUser.LoggedInUser.PostStatus(textBoxStatus.Text);
            MessageBox.Show("Status Posted! ID: " + postedStatus.Id);
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            m_AppSettings.m_LastWindowLocation = this.Location;
            m_AppSettings.m_LastWindowSize = this.Size;
            m_AppSettings.m_RememberUser = checkBoxRememberUser.Checked;
            if(checkBoxRememberUser.Checked)
            {
                m_AppSettings.m_LastAccessToke = m_LoggedInUser.AccessToken;
            }
            else
            {
                m_AppSettings.m_LastAccessToke = string.Empty;
            }

            m_AppSettings.SaveToFile();
        }



        
    }
}

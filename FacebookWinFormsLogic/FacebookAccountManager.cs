using System;
using System.Drawing;
using FacebookExceptions;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using static FacebookWrapper.ObjectModel.User;

namespace FacebookWinFormsLogic
{
    sealed public class FacebookAccountManager
    {

        //----------------------------------------------- Locks -----------------------------------------------//
        private static object s_InstanceCreationLock = new object();
        private object m_ConnectToFacebookAccountLock = new object();
        private object m_PostsLock = new object();
        private object m_AlbumsLock = new object();
        private object m_FavoriteTeamsLock = new object();
        private object m_LikedPagesLock = new object();
        private object m_FriendsLock = new object();
        private object m_GroupsLock = new object();
        private object m_EventsLock = new object();

        //----------------------------------------- Original Properties ---------------------------------------//
        private static FacebookAccountManager s_AccountManager { get; set; }
        private User LoggedInUser { get; set; }
        public string AccessToken { get; private set; }

        public Image ProfilePicture => LoggedInUser.ImageLarge;
        public string Name => LoggedInUser.Name;
        public string Birthday => LoggedInUser.Birthday;
        public static bool LoggedIn => s_AccountManager != null;
        public eGender? Gender => LoggedInUser.Gender;
        public City Hometown => LoggedInUser.Hometown;
        public City Location => LoggedInUser.Location;
        public FacebookObjectCollection<Post> WallPosts => LoggedInUser.WallPosts;
        public string About => LoggedInUser.About;
        public Education[] Education => LoggedInUser.Educations;
        public FacebookObjectCollection<Event> EventsCreated => LoggedInUser.EventsCreated;
        public FacebookObjectCollection<Event> EventsDeclined => LoggedInUser.EventsDeclined;
        public FacebookObjectCollection<Event> EventsMaybe => LoggedInUser.EventsMaybe;
        public FacebookObjectCollection<Event> EventsNotYetReplied => LoggedInUser.EventsNotYetReplied;

        public string Quotes => LoggedInUser.Quotes;
        public FacebookObjectCollection<Checkin> Checkins => LoggedInUser.Checkins;
        public Cover Cover => LoggedInUser.Cover;
        public string Email => LoggedInUser.Email;
        public Page[] Languages => LoggedInUser.Languages;
        public string Locale => LoggedInUser.Locale;
        public double? TimeZone => LoggedInUser.TimeZone;
        public FacebookObjectCollection<FriendList> FriendLists => LoggedInUser.FriendLists;
        public string Id => LoggedInUser.Id;
        public eGender[] InterestedIn => LoggedInUser.InterestedIn;
        public string Link => LoggedInUser.Link;
        public string MiddleName => LoggedInUser.MiddleName;
        public FacebookObjectCollection<Post> NewsFeed => LoggedInUser.NewsFeed;
        public eOnlineStatus? OnlineStatus => LoggedInUser.OnlineStatus;
        public eRelationshipStatus? RelationshipStatus => LoggedInUser.RelationshipStatus;
        public FacebookObjectCollection<Status> Statuses => LoggedInUser.Statuses;
        public FacebookObjectCollection<Photo> PhotosTaggedIn => LoggedInUser.PhotosTaggedIn;
        public FacebookObjectCollection<Poke> Pokes => LoggedInUser.Pokes;
        public FacebookObjectCollection<Link> PostedLinks => LoggedInUser.PostedLinks;
        public FacebookObjectCollection<User> Subscribers => LoggedInUser.Subscribers;
        public FacebookObjectCollection<User> SubscribedTo => LoggedInUser.SubscribedTo;
        public PicturesColleciton Pictures => LoggedInUser.Pictures;
        public FacebookObjectCollection<Message> MessageUpdates => LoggedInUser.MessageUpdates;
        public string Religion => LoggedInUser.Religion;
        public User SignificantOther => LoggedInUser.SignificantOther;
        public string UserName => LoggedInUser.UserName;
        public bool? Verfied => LoggedInUser.Verfied;
        public FacebookObjectCollection<Video> Videos => LoggedInUser.Videos;
        public WorkExperience[] WorkExperiences => LoggedInUser.WorkExperiences;

        //------------------------------------------ Cached Properties ----------------------------------------//
        private FacebookObjectCollection<Event> m_Events;
        private FacebookObjectCollection<Group> m_Groups;
        private Page[] m_FavoriteTeams;
        private FacebookObjectCollection<Album> m_Albums;
        private FacebookObjectCollection<Post> m_Posts;
        private FacebookObjectCollection<Page> m_LikedPages;
        private FacebookObjectCollection<User> m_Friends;

        public FacebookObjectCollection<Event> Events
        {
            get { return getObjectFromCacheOrGetFromWebServiceForTheFirstTime(ref m_Events, ref m_EventsLock, () => m_Events = LoggedInUser.Events); }
        }

        public FacebookObjectCollection<Group> Groups
        {
            get { return getObjectFromCacheOrGetFromWebServiceForTheFirstTime(ref m_Groups, ref m_GroupsLock, () => m_Groups = LoggedInUser.Groups); }
        }

        public Page[] FavoriteTeams
        {
            get { return getObjectFromCacheOrGetFromWebServiceForTheFirstTime(ref m_FavoriteTeams, ref m_FavoriteTeamsLock, () => m_FavoriteTeams = LoggedInUser.FavofriteTeams); }
        }

        public FacebookObjectCollection<Album> Albums
        {
            get { return getObjectFromCacheOrGetFromWebServiceForTheFirstTime(ref m_Albums, ref m_AlbumsLock, () => m_Albums = LoggedInUser.Albums); }
        }

        public FacebookObjectCollection<Page> LikedPages
        {
            get { return getObjectFromCacheOrGetFromWebServiceForTheFirstTime(ref m_LikedPages, ref m_LikedPagesLock, () => m_LikedPages = LoggedInUser.LikedPages); }
        }

        public FacebookObjectCollection<Post> Posts
        {
            get { return getObjectFromCacheOrGetFromWebServiceForTheFirstTime(ref m_Posts, ref m_PostsLock, () => m_Posts = LoggedInUser.Posts); }
        }

        public FacebookObjectCollection<User> Friends
        {
            get { return getObjectFromCacheOrGetFromWebServiceForTheFirstTime(ref m_Friends, ref m_FriendsLock, () => m_Friends = LoggedInUser.Friends); }
        }

        private T getObjectFromCacheOrGetFromWebServiceForTheFirstTime<T>(ref T io_DesiredObject, ref object i_DesiredObjectLock, Func<T> i_GetTheDesiredObjectFromWebService)
        {
            if (io_DesiredObject == null)
            {
                lock (i_DesiredObjectLock)
                {
                    if (io_DesiredObject == null)
                    {
                        io_DesiredObject = i_GetTheDesiredObjectFromWebService.Invoke();
                    }
                }
            }

            return io_DesiredObject;
        }

        //-------------------------------------------- Constructor --------------------------------------------//
        private FacebookAccountManager()
        {
        }

        //---------------------------------------------- Instance ---------------------------------------------//
        public static FacebookAccountManager Instance
        {
            get
            {
                if (s_AccountManager == null)
                {
                    lock (s_InstanceCreationLock)
                    {
                        if (s_AccountManager == null)
                        {
                            s_AccountManager = new FacebookAccountManager();
                        }
                    }
                }

                return s_AccountManager;
            }
        }

        //----------------------------------------------- Login -----------------------------------------------//
        public void Login()
        {
            LoginResult loginResult;
            bool isExecuted = false;

            if (LoggedInUser == null)
            {
                lock (m_ConnectToFacebookAccountLock)
                {
                    if (LoggedInUser == null)
                    {
                        loginResult = FacebookService.Login(
                            "686965656096037",
                            "email",
                            "public_profile",
                            "user_age_range",
                            "user_birthday",
                            "user_events",
                            "user_friends",
                            "user_gender",
                            "user_hometown",
                            "user_likes",
                            "user_link",
                            "user_location",
                            "user_photos",
                            "user_posts",
                            "user_videos",
                            "groups_access_member_info",
                            "publish_to_groups",
                            "pages_manage_posts");
                        verifyIfLoginWasSuccessful(loginResult);
                        isExecuted = !string.IsNullOrEmpty(loginResult.AccessToken);
                    }
                }
            }

            if (!isExecuted)
            {
                throw new UserAlreadyLoggedInException();
            }
        }

        public void Connect(string i_AccessToken)
        {
            LoginResult loginResult;
            bool isExecuted = false;

            if (LoggedInUser == null)
            {
                lock (m_ConnectToFacebookAccountLock)
                {
                    if (LoggedInUser == null)
                    {
                        loginResult = FacebookService.Connect(i_AccessToken);
                        isExecuted = true;
                        verifyIfLoginWasSuccessful(loginResult);
                    }
                }
            }

            if (!isExecuted)
            {
                throw new UserAlreadyLoggedInException();
            }
        }
        
        //---------------------------------------------- Methods ----------------------------------------------//
        private void verifyIfLoginWasSuccessful(LoginResult i_LoginResult)
        {
            if (i_LoginResult.AccessToken != null)
            {
                LoggedInUser = i_LoginResult.LoggedInUser;
                AccessToken = i_LoginResult.AccessToken;
            }
            else
            {
                throw new LoginFailureException();
            }
        }

        public void Checkin(Checkin i_Checkin)
        {
            LoggedInUser.Checkin(i_Checkin);
        }

        public FriendList CreateFriendList(string i_FriendList)
        {
            return LoggedInUser.CreateFriendList(i_FriendList);
        }

        public void PostPhoto(string i_PictureFilePath, string i_Title = null, string i_Caption = null, string i_PrivacyParameterValue = null)
        {
            LoggedInUser.PostPhoto(i_PictureFilePath, i_Title, i_Caption, i_PrivacyParameterValue);
        }

        public void PostLink(string i_Url, string i_Message = null, string i_PrivacyParameterValue = null)
        {
            LoggedInUser.PostLink(i_Url, i_Message, i_PrivacyParameterValue);
        }

        public void CreateEvent_DeprecatedSinceV2(string i_Name, DateTime i_StartTime, DateTime? i_EndTime = null, string i_Description = null, string i_Location = null, Event.ePrivacy? i_PrivacyType = null, string i_PlaceID = null)
        {
            LoggedInUser.CreateEvent_DeprecatedSinceV2(i_Name, i_StartTime, i_EndTime, i_Description, i_Location, i_PrivacyType, i_PlaceID);
        }

        public Status Post(string i_NewPost)
        {
            Status postedStatus;

            if (LoggedInUser == null)
            {
                throw new InvalidOperationException("User must be logged in to create a new post.");
            }

            try
            {
                postedStatus = LoggedInUser.PostStatus(i_NewPost);
            }
            catch
            {
                postedStatus = null;
            }

            return postedStatus;
        }

        //---------------------------------------------- Logout -----------------------------------------------//
        public void Logout()
        {
            FacebookService.Logout();
            AccessToken = null;
            LoggedInUser = null;
        }
    }
}

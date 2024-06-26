﻿using System;
using FacebookWrapper.ObjectModel;

namespace FacebookWinFormsLogic
{
    public class MostPopularFeedLogic
    {
        //---------------------------------------------- Members ----------------------------------------------//
        private readonly FacebookObjectCollection<Post> r_Posts;
        private readonly FacebookObjectCollection<Album> r_Albums;

        //-------------------------------------------- Constructor --------------------------------------------//
        public MostPopularFeedLogic()
        {
            r_Albums = FacebookAccountManager.Instance.Albums;
            r_Posts = FacebookAccountManager.Instance.Posts;
        }

        //---------------------------------------------- Methods ----------------------------------------------//
        public Post FindMostPopularPost(DateTime i_ChosenDate)
        {
            Post mostPopularPost = null;

            foreach (Post post in r_Posts)
            {
                if (post.CreatedTime.Value.Year == i_ChosenDate.Year)
                {
                    if (mostPopularPost == null || (post.Comments.Count > mostPopularPost.Comments.Count))
                    {
                        mostPopularPost = post;
                    }
                }
            }

            return mostPopularPost;
        }

        public Photo FindMostPopularPhoto(DateTime i_ChosenDate)
        {
            Photo mostPopularPhoto = null;

            foreach (Album album in r_Albums)
            {
                foreach (Photo photo in album.Photos)
                {
                    if (photo.CreatedTime.Value.Year == i_ChosenDate.Year)
                    {
                        if (mostPopularPhoto == null || (photo.Comments.Count > mostPopularPhoto.Comments.Count))
                        {
                            mostPopularPhoto = photo;
                        }
                    }
                }
            }

            return mostPopularPhoto;
        }
    }
}

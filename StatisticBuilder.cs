using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesktopFacebook
{
    public class StatisticBuilder
    {    
        public List<ActiveLiker> GetActiveLikersList(FacebookObjectCollection<Post> i_Posts)
        {
            List<ActiveLiker> activeLikersList = new List<ActiveLiker>();

            foreach (Post post in i_Posts)
            {
                foreach (User liker in post.LikedBy)
                {
                    bool ifExists = false;
                    foreach (ActiveLiker activeLiker in activeLikersList)
                    {
                        if (liker.Id.Equals(activeLiker.UserId))
                        {
                            ifExists = true;
                            encreaseNumber(activeLiker);
                            break;
                        }
                    }

                    if (!ifExists)
                    {
                        IActiveUser activeUser = ActiveUserCreator.CreateActiveUser(liker.GetType());
                        activeUser.UserName = liker.Name;
                        activeUser.UserId = liker.Id;
                        activeLikersList.Add(activeUser as ActiveLiker);
                    }
                }
            }

            return activeLikersList;
        }

        public List<ActiveCommentator> GetActiveCommentatorsList(FacebookObjectCollection<Post> i_Posts)
        {
            List<ActiveCommentator> activeCommentatorsList = new List<ActiveCommentator>();

            foreach (Post post in i_Posts)
            {
                foreach (Comment comment in post.Comments)
                {
                    bool ifExists = false;
                    foreach (ActiveCommentator activeCommentator in activeCommentatorsList)
                    {
                        if (comment.From.Id.Equals(activeCommentator.UserId))
                        {
                            ifExists = true;
                            encreaseNumber(activeCommentator);
                            break;
                        }
                    }

                    if (!ifExists)
                    {
                        IActiveUser activeUser = ActiveUserCreator.CreateActiveUser(comment.GetType());
                        activeUser.UserName = comment.From.Name;
                        activeUser.UserId = comment.From.Id;
                        activeCommentatorsList.Add(activeUser as ActiveCommentator);
                    }
                }
            }

            return activeCommentatorsList;
        }

        private void encreaseNumber(IActiveUser activeUser)
        {
            if(activeUser is ActiveCommentator)
            {
                (activeUser as ActiveCommentator).NumOfComments++;
            }
            else if(activeUser is ActiveLiker)
            {
                (activeUser as ActiveLiker).NumOfLikes++;
            }
        }        
    }
}

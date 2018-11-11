using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;

namespace DesignPatterns1
{
    public class WomenFriendFinder
    {
        public User Me { get; set; }

        public List<User> GetFemaleFriends()
        {
            List<User> users = new List<User>();
            foreach(User friend in Me.Friends)
            {
                if (friend.Gender == User.eGender.female)
                {
                    users.Add(friend);
                }
            }

            return users;
        }
    }
}

using SplitWise.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SplitWise.Utils
{
    class FriendUtil
    {
        public Friend GetFriend(List<Friend> friends, int idToFind)
        {
            return friends.First(x => x.id == idToFind);
        }

        public Friend GenerateFriend(string[] friendDetails)
        {
            return new Friend(Convert.ToInt32(friendDetails[0]), friendDetails[1]);
        }

        public void ShowSettlementAmount(List<Friend> friends)
        {
            foreach (var friend in friends)
            {
                friend.ShowBalanceDetails();
            }
        }
    }
}

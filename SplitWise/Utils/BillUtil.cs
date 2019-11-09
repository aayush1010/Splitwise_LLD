using SplitWise.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SplitWise.Utils
{
    class BillUtil
    {
        public static Bill GenerateBill(string[] billDetails, List<Friend> friends)
        {
            var paidByFriendId = Convert.ToInt32(billDetails[0]);
            var billAmount = Convert.ToDouble(billDetails[1]);
            var spentOn = billDetails[2];
            var friendsIncludedIds = billDetails[3].Split(Constants.Constants.FriendsIncludeSplitter).Select(Int32.Parse).ToList();
            var paidBy = FriendUtil.GetFriend(friends, paidByFriendId);
            var friendsIncluded = new List<Friend>();
            foreach (var friendId in friendsIncludedIds)
            {
                friendsIncluded.Add(FriendUtil.GetFriend(friends, friendId));
            }
            return new Bill(paidBy, billAmount, spentOn, friendsIncluded);
        }

        public static void SettleBills(List<Bill> bills)
        {
            foreach (var bill in bills)
            {
                bill.SettleBill();
            }
        }
    }
}

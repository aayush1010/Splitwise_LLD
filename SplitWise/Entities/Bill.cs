using System.Collections.Generic;

namespace SplitWise.Entities
{
    class Bill
    {
        private readonly Friend paidBy;
        private readonly string spentOn;
        private readonly double billAmount;
        private readonly List<Friend> friendsIncluded;

        public Bill(Friend paidBy, double billAmount, string spentOn, List<Friend> friendsIncluded)
        {
            this.paidBy = paidBy;
            this.spentOn = spentOn;
            this.friendsIncluded = friendsIncluded;
            this.billAmount = billAmount;
        }
        
        public void SettleBill()
        {
            int friendsIncludedCount = friendsIncluded.Count;
            double eachOneShare = billAmount / friendsIncludedCount;
            paidBy.UpdateSettlementAmount(billAmount);
            foreach (var friend in friendsIncluded)
            {
                friend.UpdateSettlementAmount(-1 * eachOneShare);
            }
        }
    }
}

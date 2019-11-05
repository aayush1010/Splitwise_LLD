using System.Collections.Generic;

namespace SplitWise.Entities
{
    class Bill
    {
        private readonly Friend paidBy;
        private readonly string spentOn;
        private readonly int billAmount;
        private readonly List<Friend> friendsIncluded;

        public Bill(Friend paidBy, int billAmount, string spentOn, List<Friend> friendsIncluded)
        {
            this.paidBy = paidBy;
            this.spentOn = spentOn;
            this.friendsIncluded = friendsIncluded;
            this.billAmount = billAmount;
        }
        
    }
}

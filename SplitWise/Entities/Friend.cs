using System;
using static SplitWise.Constants.Enums;

namespace SplitWise.Entities
{
    class Friend
    {
        public readonly int id;
        private readonly string name;
        private double settlementAmount;
        private SettlementType settlementType
        {
            get
            {
                return settlementAmount < default(double) ? SettlementType.give : SettlementType.gets;
            }
        }

        public Friend(int id, string name)
        {
            this.id = id;
            this.name = name;
            this.settlementAmount = 0;
        }

        public void UpdateSettlementAmount(double amount)
        {
            this.settlementAmount += amount;
        }
        
        public void ShowBalanceDetails()
        {
            Console.WriteLine(name + " " + Enum.GetName(typeof(SettlementType), settlementType) + " " + Math.Abs(settlementAmount));
        }
    }
}

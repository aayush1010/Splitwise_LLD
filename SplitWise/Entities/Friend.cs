namespace SplitWise.Entities
{
    class Friend
    {
        public readonly int id;
        private readonly string name;
        private int settlementAmount;

        public Friend(int id, string name)
        {
            this.id = id;
            this.name = name;
            this.settlementAmount = 0;
        }

        public Friend CreateFriend(int id, string name)
        {
            return new Friend(id, name);
        }

        public void UpdateSettlementAmount(int amount)
        {

        }
        
        public int GetBalance()
        {
            return this.settlementAmount;
        }
    }
}

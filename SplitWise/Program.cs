using SplitWise.Utils;
using System;

namespace SplitWise
{
    class Program
    {
        static void Main(string[] args)
        {
            Reader reader = new Reader();
            var readerDto = reader.ReadFile();
            BillUtil billUtil = new BillUtil();
            billUtil.SettleBills(readerDto.Bills);
            FriendUtil friendUtil = new FriendUtil();
            friendUtil.ShowSettlementAmount(readerDto.Friends);
            Console.ReadLine();
        }
    }
}

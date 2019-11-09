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
            BillUtil.SettleBills(readerDto.Bills);
            FriendUtil.ShowSettlementAmount(readerDto.Friends);
            Console.ReadLine();
        }
    }
}

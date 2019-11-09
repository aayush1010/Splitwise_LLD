using System.Configuration;
using System.Collections.Generic;
using System.IO;
using SplitWise.Entities;
using SplitWise.DTO;

namespace SplitWise.Utils
{
    class Reader
    {
        private readonly string billDataFilePath;
        private readonly string friendDataFilePath;
        private List<Friend> friends;
        private List<Bill> bills;


        public Reader()
        {
            friends = new List<Friend>();
            bills = new List<Bill>();
            billDataFilePath = ConfigurationSettings.AppSettings[Constants.Constants.BillDataFilePath];
            friendDataFilePath = ConfigurationSettings.AppSettings[Constants.Constants.FriendDataFilePath];
        }

        public ReaderDTO ReadFile()
        {
            ReadFriendDetails();
            ReadBillDetails();
            return new ReaderDTO { Bills = bills, Friends = friends };
        }

        private void ReadFriendDetails()
        {
            using (var reader = new StreamReader(friendDataFilePath))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var friendDetails = line.Split(Constants.Constants.Splitter);
                    friends.Add(FriendUtil.GenerateFriend(friendDetails));
                }
            }
        }

        private void ReadBillDetails()
        {
            using (var reader = new StreamReader(billDataFilePath))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var billDetails = line.Split(Constants.Constants.Splitter);
                    bills.Add(BillUtil.GenerateBill(billDetails, friends));
                }
            }
        }
    }
}

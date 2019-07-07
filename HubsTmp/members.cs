using SignalRChat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for members
/// </summary>
/// 
namespace SignalRChat
{
    public class member
    {
        //public string whoSend { get; set; }
        public string guid { get; set; }
        public Guid RndNumber { get; set; }
        public string name { get; set; }
        public string whoSend { get; set; }
        public string CustomerGuid { get; set; }
        public int supplierID { get; set; }
        public int customerID { get; set; }
        public int supplierOnlineStatus { get; set; }
        public int SumUserBalance { get; set; }
        public string gid { get; set; }
        public string memberID { get; set; }
        public string show()
        {
            return "whoSend=" + whoSend + " supplierID=" + supplierID + " customerID=" + customerID + " RndNumber=" + RndNumber;
        }
    }


    public class Class2
    {
        private static object _lock = new object();
        public static List<member> removeCustomerMemberList(member member_, List<member> MemebersList)
        {
            //var MemebersList = (List<member>)HttpContext.Current.Cache["members"];
            var memeberList = (from a in MemebersList where a.supplierID == member_.supplierID && a.whoSend == "0" select a).FirstOrDefault();
            if (memeberList != null)
            {
                lock (_lock)
                {
                    MemebersList.Remove(memeberList);
                    //HttpContext.Current.Cache["members"] = MemebersList.ToList();
                }
            }
            return MemebersList;
        }
        public static List<member> addTomemberList(member member_, List<member> MemebersList,string saveLogForWebRTC)
        {
            errors.addErrorString("addTomemberList1", saveLogForWebRTC);
            var memeberList = MemebersList.FirstOrDefault(a => a.supplierID == member_.supplierID && a.whoSend == member_.whoSend);
            // var memeberList = (from a in MemebersList where a.supplierID == member_.supplierID && a.whoSend == member_.whoSend select a).First();
            errors.addErrorString("addTomemberList2", saveLogForWebRTC);
            if (memeberList == null)
            {
                lock (_lock)
                {
                    MemebersList.Add(member_);
                }
            }
            else
            {
                if (memeberList.memberID != member_.memberID)
                {
                    lock (_lock)
                    {
                        MemebersList.Remove(memeberList);
                        MemebersList.Add(member_);
                    }
                }

            }
            //HttpContext.Current.Cache["members"] = MemebersList.ToList();
            return MemebersList;
        }
        public static member getOtherMember(member member_, List<member> MemebersList)
        {
            //var MemebersList = (List<member>)HttpContext.Current.Cache["CacheItem1"];
            //var MembersList = (List<member>)HttpContext.Current.Cache["members"];
            if (member_.whoSend == "0")
            {
                return (from a in MemebersList where a.supplierID == member_.supplierID && a.whoSend == "749" select a).FirstOrDefault();
            }
            else
            {
                return (from a in MemebersList where a.supplierID == member_.supplierID && a.whoSend == "0" select a).FirstOrDefault();
            }

        }
    }

}
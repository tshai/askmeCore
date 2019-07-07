using System;
using System.Web;
using System.Collections.Generic;
using Microsoft.AspNetCore.SignalR;
using SignalRChat.Models;
using System.Threading.Tasks;
using static Microsoft.AspNetCore.Hosting.Internal.HostingApplication;
using System.Linq;
namespace SignalRChat.Hubs
{
    public class ChatHub : Hub
    {
        
        public static List<member> MemebersList = new List<member>();
     
        private void initialize(string Message,string RndNumber, string UserGuid,string WhoSend, Guid MainModelGuid, member member_)
        {
            MemebersList = Class2.addTomemberList(member_, MemebersList);
            if (member_.WhoSend == "0")//this is user
            {
                Clients.Client(Class2.getOtherMember(member_, MemebersList).memberID).SendAsync("SendMessage", "newUser98541");
            }
            else
            {
                Clients.Client(Context.ConnectionId).SendAsync("SendMessage", "connect");
                errors.addErrorString("initialize-connect");
            }
            errors.addErrorString("initialize2");
        }
        Validation Validation_ = new Validation();
        supplierAutoUpdate supplierAutoUpdate_ = new supplierAutoUpdate();



        private void Send(string Message,string RndNumber, string UserGuid,string WhoSend, Guid MainModelGuid, member member_)
        {
            MemebersList = Class2.addTomemberList(member_, MemebersList);
            Class1.addChatConv(member_.OnlineUsersShort_.GirlNum, Message);
            Clients.Client(Context.ConnectionId).SendAsync("SendMessage", Message);
            Clients.Client(Class2.getOtherMember(member_, MemebersList).memberID).SendAsync("SendMessage", Message);

        }
        public void S1(string Message)
        {
            errors.addErrorString(Message);

        }
        public void S2(string Message)
        {
            errors.addErrorString("s2");

        }
        //public void genericMessage(string MessageType, string Message, string RndNumber, string UserGuid, string WhoSend, Guid MainModelGuid)
        public void genericMessage(string message)
        {
            errors.addErrorString(message);
            //int UserNum=0;
            //int GirlNum=0;
            //if (WhoSend != "749")//check if this user is valid
            //{
            //    UserNum = int.Parse(Class1.QuerySql("select UserNum from UserDetails where UserGuid='" + UserGuid + "'"));
            //    string CheckifValidClient = Validation.CheckifValidClient(UserNum, Guid.Parse(RndNumber));
            //    if (CheckifValidClient == "false")
            //    {
            //        errors.addErrorString("user not suppose to be inside");
            //        populateClassFromDB.addWindowsServiceLogs(new WindowsServiceLogs { DateIn = DateTime.Now, GirlNum = 1, RndNumber = RndNumber.ToString(), UserNum = UserNum, EventDesc = "supplier Online was not 1 from TestWebSocketHandler 44 disconnectChat17" + 0, IsError = 1 });
            //        Clients.Client(Context.ConnectionId).SendAsync("SendMessage", "disconnectChat17");
            //        return;
            //    }
            //    else
            //    {
            //        GirlNum = int.Parse(CheckifValidClient);
            //    }
            //    Class1.updateUlastvisit(GirlNum, UserNum);
            //}
            //else if (WhoSend == "749")
            //{
            //    GirlNum= int.Parse(Class1.QuerySql("select GirlNum from Users where MainModelGuid='" + MainModelGuid + "'"));
            //}

            //member member_ = TestWebSocketHandlerMemeberProperties(RndNumber, UserGuid, WhoSend, MainModelGuid, GirlNum, UserNum);
            //member_.memberID = Context.ConnectionId;
            //if (MessageType== "Initialize")
            //{
            //    initialize(Message, RndNumber, UserGuid, WhoSend, MainModelGuid, member_);
            //}
            //else if(MessageType == "Login")
            //{
            //    Clients.Client(Context.ConnectionId).SendAsync("SendMessage", Message);
            //}
            //else if (MessageType == "Update")
            //{
            //    Update(Message, RndNumber, UserGuid, WhoSend, MainModelGuid, member_);
            //}
            //else if (MessageType == "Send")
            //{
            //    Send(Message, RndNumber, UserGuid, WhoSend, MainModelGuid, member_);
            //}
            //else
            //{
            //    try
            //    {
            //        String memberID = Class2.getOtherMember(member_, MemebersList).memberID;
            //        Clients.Client(memberID).SendAsync("SendMessage", Message);
            //    }
            //    catch (Exception ex)
            //    {
            //        errors.addErrorString(ex.StackTrace);
            //    }
            //}
           

        }
        //public void Login(string Message, string RndNumber, string UserGuid, string WhoSend, Guid MainModelGuid)
        //{
        //    errors.addErrorString("login");
        //    try
        //    {
        //        member member_ = TestWebSocketHandlerMemeberProperties(RndNumber, UserGuid, WhoSend, MainModelGuid);
        //    }
        //    catch (Exception ex)
        //    {
        //        errors.addErrorString(ex.StackTrace);
        //        // errors.WriteErrorLogtmp(ex.StackTrace, 1);

        //    }
        //    errors.WriteErrorLogtmp("login2", 1);
        //    Clients.Client(Context.ConnectionId).SendAsync("SendMessage", Message);
        //    errors.WriteErrorLogtmp("login3", 1);

        //}

        private member TestWebSocketHandlerMemeberProperties(string RndNumber, string UserGuid,string WhoSend, Guid MainModelGuid,int GirlNum,int UserNum)
        {
            member member_ = new member();
            errors.addErrorString("*125-" + GirlNum);
            member_.RndNumber =Guid.Parse(RndNumber);
            if (WhoSend == "749")
            {
                try
                {
                    OnlineUsersShort OnlineUsersShort_ = new OnlineUsersShort();
                    OnlineUsers OnlineUsers_ = new OnlineUsers();
                    using (var db = new AskMeContext())
                    {
                        var q = from a in db.OnlineUsers where a.GirlNum == GirlNum select a;
                        if (q.Any() == true)
                        {
                            OnlineUsers_ = q.First();
                        }
                    }
                    OnlineUsersShort_.GirlNum = OnlineUsers_.GirlNum;
                    OnlineUsersShort_.UserNum = OnlineUsers_.UserNum;
                    OnlineUsersShort_.RndNumber = OnlineUsers_.RndNumber;
                    OnlineUsersShort_.Online = OnlineUsers_.Online;
                    OnlineUsersShort_.SumUserBalance = OnlineUsers_.SumUserBalance;
                    //OnlineUsersShort_.NewTip = short.Parse(OnlineUsers_.NewTip.ToString());
                    OnlineUsersShort_.NewTip = 0;
                    OnlineUsersShort_.LastStatusChange = OnlineUsers_.LastStatusChange;





                    //member_.OnlineUsersShort_ = populateClassFromDB.getOnlineUsers(MainModelGuid);
                    OnlineUsersShort_.MainModelGuid = MainModelGuid;
                    member_.OnlineUsersShort_ = OnlineUsersShort_;
                }
                catch (Exception ex)
                {
                    errors.addError("getOnlineUsers-148" + MainModelGuid, ex);
                    //errors.addError("",ex);
                }
                Class1.updatelastvisit(member_.OnlineUsersShort_.GirlNum);
                member_.GirlNum = member_.OnlineUsersShort_.GirlNum;
                member_.UserNum = UserNum;
            }
            else
            {
                using (var db = new AskMeContext())
                {
                    member_.GirlNum = (from a in db.Users where a.MainModelGuid == MainModelGuid select a.GirlNum).FirstOrDefault();
                    member_.SumUserBalance = (from a in db.OnlineUsers  where a.GirlNum == member_.GirlNum select a.SumUserBalance).FirstOrDefault();
                }
               
                member_.GirlNum = GirlNum;
            }
            member_.UserGuid = UserGuid;
            if(UserGuid!="0" && WhoSend!="749")
            {
                member_.UserNum = int.Parse(Class1.QuerySql("select UserNum from UserDetails where UserGuid='" + UserGuid + "'"));
            }
            
            member_.WhoSend = WhoSend;
            return member_;
        }

        private  void Update(string Message, string RndNumber, string UserGuid, string WhoSend, Guid MainModelGuid, member member_)
        {
            if (member_.WhoSend == "749")
            {
                if (member_.OnlineUsersShort_.Online != 1)
                {
                    MemebersList = Class2.removeCustomerMemberList(member_, MemebersList);
                }

                MemebersList = Class2.addTomemberList(member_, MemebersList);
                string ans = supplierAutoUpdate_.checkSupplierStatus(member_, Message);
                if (ans != "z0z")
                {
                    Clients.Client(Context.ConnectionId).SendAsync("SendMessage", ans);
                    return;

                }
                if (member_.OnlineUsersShort_.NewTip == 2)
                {
                    Clients.Client(Context.ConnectionId).SendAsync("SendMessage", "You got new Tip from this customer");
                    Class1.nonQuerySql("update OnlineUsers set newTip=1 where GirlNum=" + member_.OnlineUsersShort_.GirlNum);
                    return;

                }
                Clients.Client(Context.ConnectionId).SendAsync("SendMessage", "update24a5ff");
                return;


            }
            else
            {
                MemebersList = Class2.addTomemberList(member_, MemebersList);
                if (member_.SumUserBalance < 60)
                {
                    Clients.Client(Context.ConnectionId).SendAsync("SendMessage", "disconnectChat18");
                    return;
                }
                Clients.Client(Context.ConnectionId).SendAsync("SendMessage", "update75ta33");
                return;
            }


        }

    }
}
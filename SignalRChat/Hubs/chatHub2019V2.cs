using System;
using Microsoft.AspNet.SignalR;
using System.Linq;
using System.Collections.Generic;
using Microsoft.AspNetCore.SignalR;
using SignalRChat.Models;
using Microsoft.Extensions.Caching.Memory;

namespace SignalRChat.Hubs
{
    public class chatHub2019V2 : Hub
    {

        public static List<member> MemebersList = new List<member>();
        private readonly IMemoryCache _cache;
        public string saveLogForWebRTC =null;
        public void Generic(string MessageType, string message, string RndNumber, int customerID, int supplierID, string whoSend, string MainModelGuid)
        {

            //_cache.TryGetValue("saveLogForWebRTC", out saveLogForWebRTC);
            //if (saveLogForWebRTC == null)
            //{
                using (var db = new AskMeContext())
                {
                    saveLogForWebRTC = (from a in db.Setting select a.SaveLogForWebRtc).First().ToString();
                    //_cache.Set("saveLogForWebRTC", saveLogForWebRTC, DateTime.Now.AddMinutes(1));
                }

            //}




            errors.addErrorString(MessageType + "-" + whoSend + "_RndNumber-" + RndNumber+ "CustomerID: "+ customerID, saveLogForWebRTC);
            member member_ = TestWebSocketHandlerMemeberProperties(RndNumber, customerID, supplierID, whoSend, MainModelGuid);
            //errors.addErrorString(MessageType + "-" + member_.whoSend);
            //errors.addErrorString("1a"+member_.whoSend);
            member_.memberID = Context.ConnectionId;
            models models_ = new models();
            models_ = populateClassFromDB.getOnlineUsers(member_.supplierID);
            //errors.addErrorString("1194");
            //Validation Validation = new Validation();
            //errors.addErrorString("2a1" + member_.whoSend);
            if (member_.whoSend == "749")
            {

                if (models_.Users_.MainModelGuid.ToString() != member_.gid.ToString()) //fake supplier
                {
                    populateClassFromDB.addWindowsServiceLogs(new WindowsServiceLogs { DateIn = DateTime.Now, SupplierId = member_.supplierID, RndNumber = member_.RndNumber.ToString(), CustomerId = member_.customerID, EventDesc = "supplier wrong guid" + member_.supplierID, IsError = 1 }, saveLogForWebRTC);

                    return;
                }
                Class1.updatelastvisit(member_.supplierID);
            }
            else
            {
                if (Validation.CheckifValidClient(models_.OnlineUsers_, member_, saveLogForWebRTC) == 1)
                {
                    errors.addErrorString("disconnectChat17" + "-" + member_.whoSend, saveLogForWebRTC);
                    Clients.Client(Context.ConnectionId).SendAsync("SendMessage", "disconnectChat17");
                    return;
                };
            }
            errors.addErrorString("2a2" + member_.whoSend, saveLogForWebRTC);









            if (MessageType == "Initialize")
            {
                Initialize(member_, models_);
            }
            else if (MessageType == "Login")
            {
                //Clients.Client(Class2.getOtherMember(member_, MemebersList).memberID).SendAsync("SendMessage", message);
               // Clients.Client(Context.ConnectionId).SendAsync("SendMessage", message);


            }
            else if (MessageType == "Update")
            {
                errors.addErrorString(MessageType + "-22-" + whoSend, saveLogForWebRTC);
                Update(member_, message, models_);
                errors.addErrorString(MessageType + "-33-" + whoSend, saveLogForWebRTC);
            }
            else if (MessageType == "Wrtc")
            {
                //errors.addErrorString("2a3" + member_.whoSend);
                //LogRtc LogRtc_ = new LogRtc();
               // LogRtc_.DateIn = DateTime.Now;
                using (var db = new AskMeContext())
                {
                    //errors.addErrorString("1-"+ member_.RndNumber);
                    if (member_.whoSend == "749")
                    {
                       // LogRtc_.Supplier = message.ToString();
                       // LogRtc_.Customer = "0";
                    }
                    else
                    {

                       // LogRtc_.Supplier = "0";
                        //LogRtc_.Customer = message.ToString();
                    }
                    try
                    {
                        //Class1.nonQuerySql("insert into LogRtc(Supplier,ChatTimeUseID,Customer)values('" + LogRtc_.Supplier + "',1,'" + LogRtc_.Customer + "')");
                    }
                    catch (Exception ex)
                    {
                        errors.addErrorString("5", saveLogForWebRTC);
                        errors.addError("90", ex);
                    }

                    errors.addErrorString("2a5" + member_.whoSend, saveLogForWebRTC);
                }
                Clients.Client(Class2.getOtherMember(member_, MemebersList).memberID).SendAsync("SendMessage", message);
                //Clients.Client(Class2.getOtherMember(member_, MemebersList).memberID).newMessage(message);
            }

        }
        
        private void Initialize(member member_, models models_)
        {
            errors.addErrorString("Initialize1", saveLogForWebRTC);
            MemebersList = Class2.addTomemberList(member_, MemebersList,saveLogForWebRTC);
            errors.addErrorString("Initialize2", saveLogForWebRTC);
            if (member_.whoSend == "0")
            {
                Clients.Client(Context.ConnectionId).SendAsync("SendMessage", "Initialize");
                //Clients.Client(Class2.getOtherMember(member_, MemebersList).memberID).SendAsync("SendMessage", "newUser98541");
                //Clients.Client(Class2.getOtherMember(member_, MemebersList).memberID).SendAsync("SendMessage", "new chat");
            }
            else
            {
                Clients.Client(Context.ConnectionId).SendAsync("SendMessage", "Initialize");
            }
            errors.addErrorString("Initialize3", saveLogForWebRTC);
        }

        private void Update(member member_, string message, models models_)
        {
            if (member_.whoSend == "749")
            {
                if (models_.OnlineUsers_.Online != 1)
                {
                    MemebersList = Class2.removeCustomerMemberList(member_, MemebersList);
                    Clients.Client(Context.ConnectionId).SendAsync("SendMessage", "FinishConversation");
                }
                else
                {
                    Class1.updatelastvisit(member_.supplierID);
                    //remove in 27/2/19 still have to think about it
                    MemebersList = Class2.addTomemberList(member_, MemebersList, saveLogForWebRTC);
                    //string ans = supplierAutoUpdate_.checkSupplierStatus(models_.OnlineUsers_, member_, message);
                    //if (ans != "z0z")
                    //{
                    //    Clients.Client(Context.ConnectionId).SendAsync("SendMessage", ans);
                    //    //Clients.Client(Context.ConnectionId).newMessage(ans);
                    //    return;
                    //}
                    /////end remove 27/2/19
                    Clients.Client(Context.ConnectionId).SendAsync("SendMessage", "Update24a5ff");
                }
               
                //Clients.Client(Context.ConnectionId).newMessage("Update24a5ff");
                return;

            }
            else
            {

                MemebersList = Class2.addTomemberList(member_, MemebersList, saveLogForWebRTC);
                //int CusrtmerID;
                //using (var db = new AskMeContext())
                //{
                //    Guid CustomerGuid = Guid.Parse(member_.CustomerGuid);
                //    CusrtmerID = (from a in db.Users where a.MainModelGuid == CustomerGuid select a.SupplierID).FirstOrDefault();
                //}
                Class1.updateUlastvisit(member_.supplierID, member_.customerID);
                if (models_.OnlineUsers_.SumUserTime < 60)
                {
                    Clients.Client(Context.ConnectionId).SendAsync("SendMessage", "disconnectChat18");
                    return;
                }
                Clients.Client(Context.ConnectionId).SendAsync("SendMessage", "Update75ta33");
                return;
            }


        }



        private member TestWebSocketHandlerMemeberProperties(string RndNumber, int customerID, int supplierID, string whoSend, string MainModelGuid)
        {
            member member_ = new member();
            member_.RndNumber = Guid.Parse(RndNumber);
            member_.name = "";
            member_.customerID = customerID;
            member_.supplierID = supplierID;
            member_.whoSend = whoSend;
            member_.gid = MainModelGuid;
            member_.guid = MainModelGuid;
            return member_;
        }

       

    }
}
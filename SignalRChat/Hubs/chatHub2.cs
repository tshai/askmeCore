using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;
namespace SignalRChat.Hubs
{
    public class chatHub2 : Hub
    {
        string saveLogForWebRTC = null;
        // public static List<member> testList = new List<member>();
        public async Task SendMessage(string user, string message)
        {
            errors.addErrorString("ReceiveMessage", saveLogForWebRTC);
            await Clients.All.SendAsync("ReceiveMessage",user,message);
        }
        //public async Task Send(string message)
        //{
        //    //errors.addErrorString("ReceiveMessage");
        //    await Clients.All.SendAsync("ReceiveMessage",message);
        //}
        public void Send(string message)
        {
            errors.addErrorString("ReceiveMessage2", saveLogForWebRTC);
            //Clients.Client(Context.ConnectionId).SendAsync("Send", message);
            Clients.All.SendAsync("Send", message);
        }
        ////public static member getOtherMember(int userID, List<member> testsList)
        ////{
        ////        return (from a in testsList where a.UserNum != testsList.UserNum && a.WhoSend == "749" select a).FirstOrDefault();
        ////}
        //private member TestWebSocketHandlerMemeberProperties1(int UserNum)
        //{
        //    member member_ = new member();
        //    member_.UserNum = UserNum;

        //    return member_;
        //}
    }
   
}

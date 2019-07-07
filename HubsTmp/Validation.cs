//using SignalRChat.Models;
using SignalRChat.Models;
using System;
using System.Linq;
namespace SignalRChat
{

    public class Validation
    {
        public static int CheckifValidClient(OnlineUsers OnlineUsersShort_, member  memberProperties_,string saveLogForWebRTC)
        {
            int answer = 0;
            
                if ((OnlineUsersShort_.CustomerId == memberProperties_.customerID && OnlineUsersShort_.Online == 1 && OnlineUsersShort_.RndNumber == memberProperties_.RndNumber) == false)
                {
                errors.addErrorString("OnlineUsersShort_.CustomerId" + "-" + OnlineUsersShort_.CustomerId+ "OnlineUsersShort_.Online" + "-" + OnlineUsersShort_.Online + "OnlineUsersShort_.RndNumber" + "-" + OnlineUsersShort_.RndNumber +"-----"+ memberProperties_.RndNumber+ " -SUPPLIERid:"+OnlineUsersShort_.SupplierId, saveLogForWebRTC);
                return 1;
                }
            return answer;
        }
       
        public string show(member memberProperties_)
        {
            return "whoSend=" + memberProperties_.whoSend + " supplierID=" + memberProperties_.supplierID + " customerID=" + memberProperties_.customerID + " RndNumber=" + memberProperties_.RndNumber;
        }
    }


}
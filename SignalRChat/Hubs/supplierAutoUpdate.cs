using System;
using SignalRChat.Models;
/// <summary>
/// Summary description for supplierAutoUpdate
/// </summary>
/// 
namespace SignalRChat
{

    public class supplierAutoUpdate
    {
        public supplierAutoUpdate()
        {
            //
            // TODO: Add constructor logic here
            //
        }
        public string checkSupplierStatus(OnlineUsers OnlineUsersShort_, member memberProperties_, string message, string saveLogForWebRTC)
        {
            try
            {
                Class1.updatelastvisit(memberProperties_.supplierID);
                memberProperties_.supplierOnlineStatus = int.Parse(message.Trim().Substring(10, 1));
                //if (supplierOnlineDB == 4 || supplierOnlineDB == 1)
                //{
                if (memberProperties_.supplierOnlineStatus != OnlineUsersShort_.Online)
                {
                    if (OnlineUsersShort_.Online != 2)//28-3-17 this add because the girl return to mitargenet sometime
                    {
                        if ((OnlineUsersShort_.Online == 4 && memberProperties_.supplierOnlineStatus == 2) && (Class1.get_sql_time() - OnlineUsersShort_.LastStatusChange).Seconds < 4)
                        {
                            return "z0z";
                        }
                        else
                        {
                            
                            populateClassFromDB.addWindowsServiceLogs(new WindowsServiceLogs { DateIn = DateTime.Now, SupplierId = memberProperties_.supplierID, RndNumber = memberProperties_.RndNumber.ToString(), CustomerId = memberProperties_.customerID, EventDesc = "updateStatus741=" + OnlineUsersShort_.Online + "memberProperties_.supplierOnlineStatus=" + memberProperties_.supplierOnlineStatus, IsError = 0 }, saveLogForWebRTC);
                            return "updateStatus741=" + OnlineUsersShort_.Online;
                        }

                    }
                    else
                    {
                        populateClassFromDB.addWindowsServiceLogs(new WindowsServiceLogs { DateIn = DateTime.Now, SupplierId = memberProperties_.supplierID, RndNumber = memberProperties_.RndNumber.ToString(), CustomerId = memberProperties_.customerID, EventDesc = "updateStatus741 : " + OnlineUsersShort_.Online, IsError = 0 }, saveLogForWebRTC);
                        return "updateStatus741=2";

                    }

                }
                //Thread.Sleep(300);
                if (OnlineUsersShort_.Online == 1)
                {
                    return "updateStatus742=" + OnlineUsersShort_.SupplierId + "-SumUserBalance=" + OnlineUsersShort_.SumUserTime;
                    //errors.WriteErrorLogtmp("supplierOnlineDB5" + item.whoSend, memberProperties_.writeError);
                }
                return "z0z";
                //}
                //errors.WriteErrorLogtmp("supplierOnlineDB" + supplierOnlineDB, memberProperties_.writeError);

            }
            catch (Exception ex)
            {
                //errors.WriteErrorLogtmp("supplierOnlineDBdddd", memberProperties_.writeError);
                
                errors.addError("supplier_update257", ex);
                return "1";
            }
        }
    }

}
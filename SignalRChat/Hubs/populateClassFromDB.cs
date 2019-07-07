
using SignalRChat.Models;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Data;

using System.Data.SqlClient;
using System.Linq;

public class populateClassFromDB
{
    //public static Users getUsers(int SupplierID)
    //{
    //    using (cam2009Entities db = New cam2009Entities()) {
    //        return (from a in db.Userswhere a.SupplierID == SupplierIDa).FirstOrDefault();
    //    }
    //}

    public static models getOnlineUsers(int SupplierId)
    {
        using (var db = new AskMeContext())
        {
            //return db.OnlineUsers.Find(SupplierID);
            models models_ = new models();
            Users Users_ = new Users();
            OnlineUsers OnlineUsers_ = new OnlineUsers();
            try
            {
                //errors.addErrorString("DD1"+ SupplierID);
                models_.OnlineUsers_= (from a in db.OnlineUsers where a.SupplierId == SupplierId select a).FirstOrDefault();
                //errors.addErrorString("DD2" + SupplierID);
                Users_.MainModelGuid = (from a in db.Users where a.Id== SupplierId select a.MainModelGuid).FirstOrDefault();
                models_.Users_ = Users_;
                //errors.addErrorString("DD2");
            }
            catch(Exception ex)
            {
                errors.addErrorString("DD","1");
                errors.addError("36",ex);
            }
            return models_;
        }
    }
    public static ChatTimeUse getChatTimeUse(int SupplierId, int CustomerId, Guid RndNum)
    {
        using (var db = new AskMeContext())
        {
            return (from a in db.ChatTimeUse where a.SupplierId == SupplierId && a.CustomerId== CustomerId && a.RndNum==RndNum select a).OrderByDescending(a=> a.Id).FirstOrDefault();
        }
    }
    public static void addWindowsServiceLogs(WindowsServiceLogs WindowsServiceLogs_,string saveLogForWebRTC)
    {
        if (saveLogForWebRTC=="1")
        {
            Class1.nonQuerySql("INSERT INTO WindowsServiceLogs(SupplierId, CustomerId, EventDesc, RndNumber, IsError) VALUES (" + WindowsServiceLogs_.SupplierId + " ," + WindowsServiceLogs_.CustomerId + ",'" + WindowsServiceLogs_.EventDesc + "','" + WindowsServiceLogs_.RndNumber + "'," + WindowsServiceLogs_.IsError + ")");
        }

    
    }
  
}
public class models
{
  public OnlineUsers OnlineUsers_ { get; set; }
    public Users Users_ { get; set; }
}
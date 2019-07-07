using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for localClass
/// </summary>

public class OnlineUsersShort
{
    public int Online { get; set; }
    public int UserID { get; set; }
    public int SumUserBalance { get; set; }
    public int SupplierID { get; set; }
    //public System.DateTime Lastvisit { get; set; }
    //public System.DateTime Ulastvisit { get; set; }
    public Guid RndNumber { get; set; }
    public System.DateTime LastStatusChange { get; set; }
    //public byte ClientAlert { get; set; }
    //public byte UserSendAlert { get; set; }
    //public byte AdminAlert { get; set; }
    public Nullable<System.Guid> MainModelGuid { get; set; }
    //public byte FreeChat { get; set; }
    //public System.DateTime timeTheChatStart { get; set; }
    //public string UserPeerId { get; set; }
    public Int16 NewTip { get; set; }
    // Other field you may need from the Product entity
}

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.IO;
using Microsoft.AspNetCore.Http.Headers;
using Microsoft.AspNetCore.Http;
using static Microsoft.AspNetCore.WebSockets.Internal.Constants;
using SignalRChat;
/// <summary>
/// Summary description for Class1
/// </summary>
public class Class1
{
    public static SqlConnection create_sql_con()
    {
        SqlConnection con = new SqlConnection(@"Server=(local);Database=AskMe;user id=askMe587z;password=askr8521;Integrated Security=false");
        con.Open();
        return con;
    }
    public static SqlConnection create_sql_error()
    {
             SqlConnection con = new SqlConnection(@"Server=(local);Database=Errors;user id=cmsUser;password=244524;Integrated Security=false");
        con.Open();
        return con;
    }
    public static string ReplaceBadCharacter(string conv)
    {
        string functionReturnValue = null;
        if (string.IsNullOrEmpty(conv))
        {
            functionReturnValue = "";
            return functionReturnValue;
        }
        if (conv.Contains("&") == true)
        {
            functionReturnValue = conv.Replace("&", " ");
        }
        else
        {
            functionReturnValue = conv;
        }
        return functionReturnValue;

    }
    public static void addChatConv(int supplierID, string txt)
    {
        using (SqlConnection con = create_sql_con())
        {
            SqlCommand cmd = new SqlCommand("addRoomConversation", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@SupplierID", SqlDbType.Int).Value = supplierID;
            cmd.Parameters.Add("@WhoSend", SqlDbType.Int).Value = 1;
            cmd.Parameters.Add("@conversation", SqlDbType.NVarChar, 300).Value = HttpUtility.HtmlEncode(ReplaceBadCharacter(txt.Trim()));
            cmd.ExecuteNonQuery();
        }
    }
   
    public static string extractUserIp()
    {
        return ""; //userIp;

    }
    public static DateTime get_sql_time()
    {
        using (SqlConnection con = create_sql_con())
        {
            SqlCommand cmd = new SqlCommand("getSqlDate", con);
            cmd.CommandType = CommandType.StoredProcedure;
            return DateTime.Parse(cmd.ExecuteScalar().ToString());
        }
    }
    public static void updateUlastvisit(int SupplierID,int CustomerID)
    {
        nonQuerySql("update OnlineUsers set CustomerLastVisit=getdate() where SupplierID=" + SupplierID + " and CustomerID=" + CustomerID + " and Online=1");
        nonQuerySql("INSERT INTO LogLastVisit (UserID)VALUES(" + CustomerID + ")");
    }
    public static void updatelastvisit(int SupplierID)
    {
        Class1.nonQuerySql("update OnlineUsers set SupplierLastVisit=getdate() where SupplierID=" + SupplierID);
        Class1.nonQuerySql("INSERT INTO LogLastVisit (UserID,gender)VALUES(" + SupplierID + ",1)");
    }

    public static void nonQuerySql(string sqlQuery)//user didnt respond long time
    {
        using (SqlConnection con = create_sql_con())
        {
            SqlCommand cmd = new SqlCommand(sqlQuery, con);
            cmd.ExecuteNonQuery();
        }
    }
    public static string QuerySql(string sqlQuery)//user didnt respond long time
    {
        using (SqlConnection con = create_sql_con())
        {
            SqlCommand cmd = new SqlCommand(sqlQuery, con);
           return  cmd.ExecuteScalar().ToString();
        }
    }
   
}
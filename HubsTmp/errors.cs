using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Web;
/// <summary>
/// Summary description for errors
/// </summary>
public class errors
{
    //readonly IHostingEnvironment env;
    public static IHttpContextAccessor _accessor;
    //private readonly IHostingEnvironment _hostingEnvironment;
   // public errors(IHostingEnvironment _hostingEnvironment)
   // {
   //     _hostingEnvironment = hostingEnvironment;

   //// TODO: Add constructor logic here


   // }

 
    public static void addError(string desc, Exception erorr1)
    {

        //string connection = ConfigurationManager.ConnectionStrings["errorReports"].ConnectionString;
        //dynamic website = HttpContext.Current.Request.Url.ToString().Replace("http://", string.Empty);
        using (SqlConnection con = Class1.create_sql_error())
        {
            errors c = new errors();
            
            SqlCommand cmd = new SqlCommand("insertError", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("shortName", SqlDbType.VarChar).Value = erorr1.Message;
            cmd.Parameters.Add("longName", SqlDbType.VarChar).Value = erorr1.StackTrace + erorr1.InnerException + erorr1.Data;
            cmd.Parameters.Add("userIP", SqlDbType.VarChar).Value = "";// _accessor.HttpContext.Connection.RemoteIpAddress.ToString();
            cmd.Parameters.Add("website", SqlDbType.VarChar).Value = "SignalRChat";
            cmd.Parameters.Add("webpage", SqlDbType.VarChar).Value = desc;
            try
            {
                cmd.ExecuteNonQuery();
                //HttpContext.Current.Server.ClearError();
            }
            catch(Exception ex)
            {
               
                WriteErrorLog(ex.StackTrace);
            }
        }
    }

    public static void WriteErrorLog(string Message)
    {
        //errors c = new errors();
        //string webRoot = c._hostingEnvironment.WebRootPath;
        ////var file = System.IO.Path.Combine(webRoot, "LogFile.txt");
        //StreamWriter sw = null;
        //sw = new StreamWriter(System.IO.Path.Combine(webRoot, "LogFile.txt"), false);
        //sw.WriteLine(DateTime.Now.ToString() + ": " + Message);
        //sw.Flush();
        //sw.Close();
    }
    public static void WriteErrorLogtmp(string Message, int m)
    {
        //if (m == 1)
        //{
        //    errors c = new errors();
        //    string webRoot = c._hostingEnvironment.WebRootPath;
        //    StreamWriter sw = null;
        //    sw = new StreamWriter(System.IO.Path.Combine(webRoot, "../LogFile.txt"), false);
        //    sw.WriteLine(DateTime.Now.ToString() + ": " + Message);
        //    sw.Flush();
        //    sw.Close();
        //}

    }
    public static void addErrorString(string desc,string saveLogForWebRTC)
    {
        if (saveLogForWebRTC == "0")
        {
            return;
        }
        //dynamic website = HttpContext.Current.Request.Url.ToString().Replace("http://", string.Empty);
        using (SqlConnection con = Class1.create_sql_error())
        {



            
            SqlCommand cmd = new SqlCommand("insertError", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("shortName", SqlDbType.VarChar).Value = desc;
            cmd.Parameters.Add("longName", SqlDbType.VarChar).Value = desc;
            cmd.Parameters.Add("userIP", SqlDbType.VarChar).Value = "";
            cmd.Parameters.Add("website", SqlDbType.VarChar).Value = "askmeCore";
            cmd.Parameters.Add("webpage", SqlDbType.VarChar).Value = "";
            cmd.ExecuteNonQuery();
        }
    }
}
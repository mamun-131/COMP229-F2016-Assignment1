using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.UI;
using System.Web.UI.WebControls;
/**
 * This is a mini profile extended web application which is all about Md Mamunur Rahman 
 * 
 * @FileName: Contact.aspx.cs
 * @Author Md Mamunur Rahman
 * @student ID: 300872772
 * @Last Update 30-September-2016
 * @website: http://mamun-portfolio.azurewebsites.net/Default.aspx
 * @description: this file is main cs file for the website
 */
namespace COMP229_F2016_Assignment1.Pages
{
    public partial class Contact : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void sendButton_Click(object sender, EventArgs e)
        {/*
            var customerName = Request["customerName"];
            var customerEmail = Request["customerEmail"];
            var customerRequest = Request["customerRequest"];
            var errorMessage = "";
            var debuggingFlag = false;
            try
            {
                // Initialize WebMail helper
                WebMail.SmtpServer = "your-SMTP-host";
                WebMail.SmtpPort = 25;
                WebMail.UserName = "your-user-name-here";
                WebMail.Password = "your-account-password";
                WebMail.From = "your-email-address-here";

                // Send email
                WebMail.Send(to: customerEmail,
                    subject: "Help request from - " + customerName,
                    body: customerRequest
                );
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
            }*/

            Response.Redirect("default.aspx");
        }
    }
}
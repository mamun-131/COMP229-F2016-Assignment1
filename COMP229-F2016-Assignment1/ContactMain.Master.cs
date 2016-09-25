using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace COMP229_F2016_Assignment1
{
    public partial class Contact : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            switch (Page.Title)
            {

                case "Home":
                    Home.Attributes.Add("class", "active");
                    break;
                case "Projects":
                    Projects.Attributes.Add("class", "active");
                    break;
                case "Services":
                    Services.Attributes.Add("class", "active");
                    break;
                case "Biography":
                    Biography.Attributes.Add("class", "active");
                    break;
                case "Contacts":
                    
                    Contacts.Attributes.Add("class", "active");
                    break;



            }
        }
    }
}
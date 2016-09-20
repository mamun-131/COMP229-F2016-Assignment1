using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace COMP229_F2016_Assignment1
{
    public partial class Site : System.Web.UI.MasterPage
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
                case "Contact":
                    Contact.Attributes.Add("class", "active");
                    break;



            }

        }
    }
}
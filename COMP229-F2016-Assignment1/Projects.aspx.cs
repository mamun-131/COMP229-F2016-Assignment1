using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace COMP229_F2016_Assignment1.Pages
{
    public partial class Products : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String projectName, projectImage, projectUrl, gitHubUrl, webSiteUrl;
            String projectDetail, programingLanguage, framework, database;

            projectName = "Online Shopping";
            projectImage = "myrasona.jpg";
            projectUrl = "http://mywebshopping.azurewebsites.net";
            gitHubUrl = "http://github.com/300872772/MyShop_Template";
            webSiteUrl = "http://mywebshopping.azurewebsites.net";
            projectDetail = "This is an Online shopping solution, particularly for grocery shop." + 
                "There is an addcart option and product and product catagory uploading option. "+
                "There is a customer registration and login system to ensure protected online sales."+
                "Any business can use for online shopping with minimum code modification.";
            programingLanguage = "C#, CSS, HTML";
            framework = "ASP.NET MVC 4.5";
            database = "SQL SERVER";

            addProject(1,projectName,projectImage, projectUrl, gitHubUrl, webSiteUrl, projectDetail, programingLanguage, framework, database);


            addProject(2,projectName, projectImage, projectUrl, gitHubUrl, webSiteUrl, projectDetail, programingLanguage, framework, database);


            addProject(3,projectName, projectImage, projectUrl, gitHubUrl, webSiteUrl, projectDetail, programingLanguage, framework, database);



        }

        private void addProject(int index, String projectName, String projectImage,String projectUrl,String gitHubUrl,String webSiteUrl,
            String projectDetail, String programingLanguage, String framework, String database) {

            //Creae the image button
            ImageButton btnImage = new ImageButton
            {

                ImageUrl = string.Format("~/Assets/{0}", projectImage),
                // PostBackUrl = string.Format("{0}", projectUrl),
                CssClass = "img-responsive",
                OnClientClick = "window.open('"+ projectUrl + "')"
            };

            //Create the gitHub link

            LinkButton lnkGithub = new LinkButton
            {

                OnClientClick = "window.open('" + gitHubUrl + "')",
                Text = "  GitHub  Link  ",
                ID = "gitHubLink" + index,
                CssClass = "btn btn-primary btn-lg btn-block responsive-width", BorderWidth = 5 ,BorderStyle = BorderStyle.None
               
            };

            //Create the website link

            LinkButton lnkWebSite = new LinkButton
            {

                OnClientClick = "window.open('" + webSiteUrl + "')",
                Text = "Website Link",
                ID = "webSiteLink" + index,
                CssClass = "btn btn-primary btn-lg btn-block responsive-width"
            };

            //Add an onClick event
            //  lnkDelete.Click += Delete_Items;


            //Create HTML table with tow rows
            Table table = new Table { CssClass = "table table-striped" };
            TableRow row1 = new TableRow();
            TableRow row2 = new TableRow();

            //Create 6 cells for Row row1
            TableCell row1_c1 = new TableCell { Text = "<b>" + projectName + "</b>", 
                HorizontalAlign = HorizontalAlign.Center, ForeColor = System.Drawing.Color.DarkRed
            };
            TableCell row1_c2 = new TableCell
            {

                Text = "<b>Project Detail </b>",
                HorizontalAlign = HorizontalAlign.Center
            };
            TableCell row1_c3 = new TableCell { Text = "<b>Languages</b> ",
                HorizontalAlign = HorizontalAlign.Center
            };
           /* TableCell row1_c4 = new TableCell { Text = "<b>Framework </b>",
                HorizontalAlign = HorizontalAlign.Center
            };
            TableCell row1_c5 = new TableCell { Text = "<b>Database</b> ",
                HorizontalAlign = HorizontalAlign.Center
            };*/
            TableCell row1_c6 = new TableCell {
                Text = "<b>Links </b>",
                HorizontalAlign = HorizontalAlign.Center};


            //Create 6 cells for Row row2
            TableCell row2_c1 = new TableCell {};
            TableCell row2_c2 = new TableCell
            {
                Text = projectDetail ,
                HorizontalAlign = HorizontalAlign.Justify
            };
            TableCell row2_c3 = new TableCell
            {
                Text = programingLanguage + ", " + framework + ", " + database,
                HorizontalAlign = HorizontalAlign.Center
            };
           /* TableCell row2_c4 = new TableCell
            {
                Text = framework ,
                HorizontalAlign = HorizontalAlign.Center
            };
            TableCell row2_c5 = new TableCell
            {
                Text = database ,
                HorizontalAlign = HorizontalAlign.Center
            };*/
            TableCell row2_c6 = new TableCell { 
                HorizontalAlign = HorizontalAlign.Justify};

            //Set special controls
            Label gap = new Label();
            gap.Text = ".......................... ";
            
            row2_c1.Controls.Add(btnImage);
            row2_c6.Controls.Add(gap);
            row2_c6.Controls.Add(lnkGithub);
            row2_c6.Controls.Add(gap);
            row2_c6.Controls.Add(lnkWebSite);

            //Add cells to row

            row1.Cells.Add(row1_c1);
            row1.Cells.Add(row1_c2);
            row1.Cells.Add(row1_c3);
          //  row1.Cells.Add(row1_c4);
          //  row1.Cells.Add(row1_c5);
            row1.Cells.Add(row1_c6);

            row2.Cells.Add(row2_c1);
            row2.Cells.Add(row2_c2);
            row2.Cells.Add(row2_c3);
          //  row2.Cells.Add(row2_c4);
          //  row2.Cells.Add(row2_c5);
            row2.Cells.Add(row2_c6);

            //Add rows to table

            table.Rows.Add(row1);
            table.Rows.Add(row2);

            //Add table to pnlShoppingCart
            pnlProject.Controls.Add(table);
        }
    }
}
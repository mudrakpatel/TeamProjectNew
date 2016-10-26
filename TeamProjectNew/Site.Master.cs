using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//required using statements
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin.Security;

namespace TeamProjectNew
{
    public partial class Site : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Debug.WriteLine(Page.Title + " loaded...");

            if (!IsPostBack){
                //check if a user is logged in
                if (HttpContext.Current.User.Identity.IsAuthenticated){
                    //show the UserNavbar area
                    UserNavbar.Visible = true;
                    PublicNavbar.Visible = false;
                } else {
                    //only show PublicNavbar
                    UserNavbar.Visible = false;
                    PublicNavbar.Visible = true;
                }
            }

            SetActivePage();

        }

        private void SetActivePage()
        {
            switch (Page.Title)
            {
                case "Home":
                    HomeLink.Attributes.Add("class", "active");
                    break;

                case "Login":
                    LoginLink.Attributes.Add("class", "active");
                    break;

                case "Contact":
                    ContactLink.Attributes.Add("class", "active");
                    break;

                case "Register":
                    RegisterLink.Attributes.Add("class", "active");
                    break;

                case "Logout":
                    LogoutLink.Attributes.Add("class", "active");
                    break;
            }
        }
    }
}
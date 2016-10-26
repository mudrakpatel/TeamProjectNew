using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//required using statements
using TeamProjectNew;
using TeamProjectNew.Models;
using System.Web.ModelBinding;


namespace TeamProjectNew
{
    public partial class fifa17Page : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.getFifa();
            }
        }

        /// <summary>
        /// This method gets fifa 17 data from the database
        /// </summary>
        protected void getFifa()
        {
            using (GameContextAzure db = new GameContextAzure())
            {
                var fifa17Data = (
                                from fifa17 in db.GameTable
                                where fifa17.GAME_NAME.Equals("Fifa17")
                                select fifa17
                                    );
                fifa17GridView.DataSource = fifa17Data.ToList();
                fifa17GridView.DataBind();
            }
        }
    }
}
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
    public partial class callOfDutyPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.getCallOfDuty();
            }
        }

        ///
        ///<Summary>
        ///This method gets call of duty data from database
        ///</Summary>
        ///
        protected void getCallOfDuty()
        {
            using (GameContextAzure db = new GameContextAzure())
            {
                var callOfDutyData = (
                from callOfDuty in db.GameTable
                where callOfDuty.GAME_NAME.Equals("CallOfDuty")
                select callOfDuty
                    );
                callofdutyGridView.DataSource = callOfDutyData.ToList();
                callofdutyGridView.DataBind();
            }
        }
    }
}
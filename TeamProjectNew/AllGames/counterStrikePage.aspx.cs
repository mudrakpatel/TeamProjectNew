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
    public partial class counterStrikePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.getCounterStrike();

            }

        }

        /// <summary>
        /// This method displays Counter Strike scores
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void getCounterStrike()
        {
            using (GameContextAzure db = new GameContextAzure())
            {
                var counterstrikeData = (
                from counterstrike in db.GameTable
                where counterstrike.GAME_NAME.Equals("CounterStrike")
                select counterstrike
                    );
                CounterStrikeGridView.DataSource = counterstrikeData.ToList();
                CounterStrikeGridView.DataBind();
            }
        }

        protected void CounterStrikeGridView_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

        }
    }
}
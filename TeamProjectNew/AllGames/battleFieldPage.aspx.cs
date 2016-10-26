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
    public partial class battleFieldPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.getBattlefield();
            }
        }

        /// <summary>
        /// This method gets battlefield data from the database
        /// </summary>

        protected void getBattlefield()
        {
            using (GameContextAzure db = new GameContextAzure())
            {
                var battlefieldData = (
                from battlefield in db.GameTable
                where battlefield.GAME_NAME.Equals("BattleField")
                select battlefield
                    );
                BattleFieldGridView.DataSource = battlefieldData.ToList();
                BattleFieldGridView.DataBind();
            }
        }
    }
}
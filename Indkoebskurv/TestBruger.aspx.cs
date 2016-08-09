using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Indkoebskurv
{
    public partial class TestBruger : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Indkoebskurv.User user = new Indkoebskurv.User("frg", "Frank", "Goldmann", 3);
            //user.Username = "Frank";
            lbl_name.Text = user.Username;

            SetLoginStatus();
        }

        private void SetLoginStatus()
        {
            if (Indkoebskurv.User.IsUser())
            {
                lbl_user.Text = "Du er logget på";
            }
            else
            {
                lbl_user.Text = "Du er IKKE logget på";
            }
        }

        protected void btn_opret_Click(object sender, EventArgs e)
        {
            Indkoebskurv.User.CreateSession();
        }

        protected void btn_slet_Click(object sender, EventArgs e)
        {
            Indkoebskurv.User.RemoveSession();
        }
    }
}
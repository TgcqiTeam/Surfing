using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Matisoft.Web
{
    public partial class Login : System.Web.UI.Page, IPostBackEventHandler
    {
        public static string CustomerEmail;
        public static string Password;
        protected void Page_Load(object sender, EventArgs e)
        {
            this.Login_dl.Attributes["onclick"] = this.Page.ClientScript.GetPostBackEventReference(this.Page, "点击myDiv");
        }
        public void RaisePostBackEvent(string eventArgument)
        {
            if (eventArgument == "点击myDiv")
            {

                    CustomerEmail = this.CustomerEmailtxt.Value;
                    Password = this.Passwordtxt.Value;
                  //  ScriptManager.RegisterStartupScript(this, this.GetType(), this.GetHashCode().ToString(),
                 // "alert("+Password+")", true);
                
                
               // BLL.Customer me = new BLL.Customer();
               // Model.userInfo user = bllUserInfo.GetModel(Convert.ToInt32(userID));
            
            }
        }
    }
}
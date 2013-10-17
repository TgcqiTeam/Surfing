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
            this.Login_dl.Attributes["onclick"] = this.Page.ClientScript.GetPostBackEventReference(this.Page, "登录");
        }
        public void RaisePostBackEvent(string eventArgument)
        {
            if (eventArgument == "登录")
            {
                CustomerEmail = this.Customertx.Text;
                Password = this.Passwordtx.Text;
                BLL.Customer bllcustomer = new BLL.Customer();
                List<Model.Customer> customerlist = bllcustomer.GetModelList("1=1");

                Model.Customer customer = new Model.Customer();
                customer.CustomerName = "123";

            }

        }
    }
}

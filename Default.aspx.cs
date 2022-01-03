using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication42
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string strcon = ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString;
            SqlConnection con = null;

            try
            {
                string Email = email.Text;
                string Password = password.Text;
           

                con = new SqlConnection(strcon);
                string sql = "insert into logins(email,password) values('" + Email + "', '" + Password + "')";

                SqlCommand cmd = new SqlCommand(sql, con);
                con.Open();
                int status = cmd.ExecuteNonQuery();
                if (status > 0)
               if (Email == "harshadpatil242412@gmail.com" && Password == "22555")                    
                        {
                            Response.Redirect("https://www.youtube.com/");
                }
                else
                {
                        Response.Redirect("404");
                    }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
    }
}
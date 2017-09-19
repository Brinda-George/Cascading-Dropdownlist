using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormCustomer
{
    public partial class LoginUser : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }
        protected void Submit_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=SUYPC211;Initial Catalog=CustomerDb;Persist Security Info=True;User ID=sa;Password=Suyati123");
            string query = "Select count(*) from Login where Username='" + txtName.Text + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            int verify = Convert.ToInt32(cmd.ExecuteScalar());
            if (verify == 1)
            {
                string password;
                string query1 = "Select Password from Login where Username='" + txtName.Text + "'";
                SqlCommand cmd1 = new SqlCommand(query1, con);
                password = cmd1.ExecuteScalar().ToString();
                if (password == txtPassword.Text)
                {
                    string query2 = "Select * from Login where Username='" + txtName.Text + "'";
                    SqlCommand cmd2 = new SqlCommand(query2, con);
                    SqlDataReader rd = cmd2.ExecuteReader();
                    while (rd.Read())
                    {
                        Session["Username"] = txtName.Text;
                    }
                    rd.Close();
                    Server.Transfer("Welcome.aspx");
                }
                else
                {
                    Response.Write("<script>alert('Invalid Username or Password')</script>");
                }
            }
            else
            {
                Response.Write("<script>alert('Invalid Username or Password')</script>");
            }
            con.Close();
        }
    }
}
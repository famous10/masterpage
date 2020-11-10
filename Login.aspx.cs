using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["uname"] != null)
        {
            Response.Redirect("~/Default.aspx");
        }
    }


    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-KR6N1AN;Initial Catalog=MasterLoginDb;Integrated Security=True");


       
        
        con.Open();
        string query = "select count(*) from ml  where uname = '" + txtuname.Text + "' and psw = '" + txtpsw.Text + "'";
        SqlCommand cmd = new SqlCommand(query, con);
        cmd.ExecuteScalar();
        string output = cmd.ExecuteScalar().ToString();
        if (output == "1")
        {
            Session["uname"] = txtuname.Text;
            Session["psw"] = txtpsw.Text;
             Response.Redirect("~/Default.aspx");
            
        }
        else
        {
            Response.Write("INVAILD USERNAME AND PASSWORD");
        }
    }
}
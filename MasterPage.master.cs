﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MasterPage : System.Web.UI.MasterPage
{

    protected void Page_Load(object sender, EventArgs e)
    {

        //if (Session["uname"] != null)
        //{
        //    Response.Redirect("~/Default.aspx");

        //}
        //else
        //{

        //}

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Session.Remove("uname");
        Session.Remove("psw");
        Response.Redirect("~/Login.aspx");
    }
}

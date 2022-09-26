using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Chat : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //if (Session["lstChat"] != null)
        //{
        //   lstChat.Items.Clear();
        //   var items =(ListItemCollection) Session["lstChat"];
        //    foreach(ListItem item in items)
        //        lstChat.Items.Add(item);   
        //}
        if (Application["lstChat"] != null)
        {
            lstChat.Items.Clear();
            var items = (ListItemCollection)Application["lstChat"];
            foreach (ListItem item in items)
                lstChat.Items.Add(item);
        }

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        lstChat.Items.Add(txtChat.Text);
        Session["lstChat"] = lstChat.Items;
        Application["lstChat"] = lstChat.Items;
        txtChat.Text = "";
    }



   
}
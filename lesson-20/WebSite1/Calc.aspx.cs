using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Calc : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }



    protected void BtnSqure_Click(object sender, EventArgs e)
    {
        var calc = new Calculator();
        lblResult.Text = calc.Square(txtNumber.Text);

    }

    protected void BtnSqrt_Click(object sender, EventArgs e)
    {
        var calc = new Calculator();
        lblResult.Text = calc.Sqrt(txtNumber.Text);
    }
}
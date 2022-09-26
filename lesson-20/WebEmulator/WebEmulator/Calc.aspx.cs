using EmulatorLogic;
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

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        var calc = new Algebra();
        lblResult.Text = calc.AddByString(txtNumber1.Text,txtNumber2.Text);
    }



    protected void btnSub_Click(object sender, EventArgs e)
    {
        var calc = new Algebra();
        lblResult.Text = calc.SubtractByString(txtNumber1.Text, txtNumber2.Text);

    }

    protected void btnMul_Click(object sender, EventArgs e)
    {
        
        var calc = new Algebra();
        lblResult.Text = calc.MulByString(txtNumber1.Text, txtNumber2.Text);

    }

    protected void btnDiv_Click(object sender, EventArgs e)
    {
        var calc = new Algebra();
        lblResult.Text = calc.OnDivOperation(txtNumber1.Text, txtNumber2.Text);
    }

    protected void btnModule_Click(object sender, EventArgs e)
    {
        var calc = new Algebra();
        lblResult.Text = calc.OnMudulu(txtNumber1.Text, txtNumber2.Text);
    }


    protected void btnPow_Click(object sender, EventArgs e)
    {
        var calc = new Algebra();
        lblResult.Text = calc.Square(txtNumber1.Text);
    }



    protected void btnRoot_Click(object sender, EventArgs e)
    {
        var calc = new Algebra();
        lblResult.Text = calc.Sqrt(txtNumber1.Text);
    }
}
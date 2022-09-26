using System;

/// <summary>
/// Summary description for calculator
/// </summary>
public class Calculator
{
    public Calculator()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public string Square(string text)
    {
        if (double.TryParse(text, out double result))
        {
            var r=result*result;
            return r.ToString();
        }
        return "Error";
    }

    public string Sqrt(string text)
    {
        if (double.TryParse(text, out double result))
        {
            var r = Math.Sqrt(result);
            return r.ToString();
        }
        return "Error";
    }
}
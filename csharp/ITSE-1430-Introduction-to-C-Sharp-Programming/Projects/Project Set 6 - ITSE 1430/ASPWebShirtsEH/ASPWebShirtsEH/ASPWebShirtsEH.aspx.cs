// Esau Hervert
// ITSE 1430
// Project 6 - Program 3
// Options/References: None.

using System;

public partial class ASPWebShirtsEH : System.Web.UI.Page
{
    int S = 0, M = 0, L = 0, XL = 0, XXL = 0; // Number of shirts of each kind.
    string FN = "Joe", LN = "Smith", Em = "Joe.Smith@Email.com", PN = "817 - 123 - 4567"; // Information on the customer.
    double ST = .07; // Tax rate.
    double PShirt = 20.00, XXLShirt = 25.00; // Price of the shirts.
    double Ttl = 0, TTax = 0, GT = 0; // Amounts due.

    protected void Page_Load(object sender, EventArgs e) { } // Load the page.
    
    //******************************************************************************************************************
    // Field information.
    protected void FirstName_TextChanged(object sender, EventArgs e)
    {
        FN = FirstName.Text;
    }

    protected void LastName_TextChanged(object sender, EventArgs e)
    {
        LN = LastName.Text;
    }

    protected void PhoneNumber_TextChanged(object sender, EventArgs e)
    {
        PN = PhoneNumber.Text;
    }

    protected void Email_TextChanged(object sender, EventArgs e)
    {
        Em = Email.Text;
    }
    //******************************************************************************************************************

    //******************************************************************************************************************
    // Number of shirts that people will order.
    protected void SmallTshirt_TextChanged(object sender, EventArgs e)
    {
        S = Convert.ToInt32(SmallTshirt.Text);
    }

    protected void MediumTshirt_TextChanged(object sender, EventArgs e)
    {
        M = Convert.ToInt32(MediumTshirt.Text);
    }

    protected void LargeTshirt_TextChanged(object sender, EventArgs e)
    {
        L = Convert.ToInt32(LargeTshirt.Text);
    }

    protected void XLargeTshirt_TextChanged(object sender, EventArgs e)
    {
        XL = Convert.ToInt32(XLargeTshirt.Text);
    }

    protected void XXLargeTshirt_TextChanged(object sender, EventArgs e)
    {
        XXL = Convert.ToInt32(XXLargeTshirt.Text);
    }
    //******************************************************************************************************************

    protected void Button1_Click(object sender, EventArgs e) // What will happen when the information is submitted.
    {
        // Disable the form information.
        FirstName.Enabled = false;
        LastName.Enabled = false;
        PhoneNumber.Enabled = false;
        Email.Enabled = false;
        SmallTshirt.Enabled = false;
        MediumTshirt.Enabled = false;
        LargeTshirt.Enabled = false;
        XLargeTshirt.Enabled = false;
        XXLargeTshirt.Enabled = false;

        // Calculate totals due.
        Ttl = (S + M + L + XL) * PShirt + XXL * XXLShirt;
        TTax = Ttl * ST;
        GT = Ttl + TTax;

        // Display information entered and totals due.
        Information.Text = FN + " " + LN;
        Information2.Text = "Phone: " + PN + "          Email: " + Em;
        Total.Text = Ttl.ToString("C");
        Taxes.Text = TTax.ToString("C");
        GrandTotal.Text = GT.ToString("C");
    }
}
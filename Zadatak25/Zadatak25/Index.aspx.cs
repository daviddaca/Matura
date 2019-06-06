using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public class Korisnici
{
    public string ime;
    public string username;
    public string password;

    public Korisnici()
    {
        ime = String.Empty;
        username = String.Empty;
        password = String.Empty;
    }

    public Korisnici(string ime, string username, string password)
    {
        this.ime = ime;
        this.username = username;
        this.password = password;
    }
}

public partial class Index : System.Web.UI.Page
{
    private Korisnici[] kor;
    public static bool uspesno;
    public string poruka;

    protected void Page_Load(object sender, EventArgs e)
    {
        poruka = "";
        kor = new Korisnici[2]
        {
            new Korisnici("Petar", "pet", "pas"),
            new Korisnici("Mihajlo", "mih", "pas")
        };
    }

    protected void Button1_Click1(object sender, EventArgs e)
    {
        foreach (Korisnici k in kor)
        {
            if (k.username.ToLower() == TextBox1.Text.ToLower() && k.password.ToLower() == TextBox2.Text.ToLower())
            {
                Session["auth"] = k.username;
                error_message.Visible = false;
                break;
            }
            else
            {
                error_message.Visible = true;
                error_message.Text = "Pogresno korisnicko ime ili lozinka";
            }
        }
    }
}
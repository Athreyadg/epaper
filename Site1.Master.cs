using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Session["role"]==null)
                {
                    LinkButton1.Visible = true; //user login button
                    LinkButton2.Visible = true; //user sign-up button

                    LinkButton3.Visible = false; //logout button
                    LinkButton7.Visible = false; //user profile button

                    LinkButton6.Visible = true; //admin login button
                    LinkButton11.Visible = false; // authors link button
                    LinkButton12.Visible = false; //publishers link button
                    LinkButton8.Visible = false; //book inventory button
                    LinkButton9.Visible = false; //book issue button
                    LinkButton10.Visible = false; //members link button
                }

                else if (Session["role"].Equals("user"))
                {
                    LinkButton1.Visible = false; //user login button
                    LinkButton2.Visible = false; //user sign-up button

                    LinkButton3.Visible = true; //logout button
                    LinkButton7.Visible = true; //user profile button
                    LinkButton7.Text = "Hello " + Session["username"];

                    LinkButton6.Visible = false; //admin login button
                    LinkButton11.Visible = false; // authors link button
                    LinkButton12.Visible = false; //publishers link button
                    LinkButton8.Visible = false; //book inventory button
                    LinkButton9.Visible = false; //book issue button
                    LinkButton10.Visible = false; //members link button
                }

                else if (Session["role"].Equals("admin"))
                {
                    LinkButton1.Visible = false; //user login button
                    LinkButton2.Visible = false; //user sign-up button

                    LinkButton3.Visible = true; //logout button
                    LinkButton7.Visible = true; //user profile button
                    LinkButton7.Text = "Hello Admin ";

                    LinkButton6.Visible = false; //admin login button
                    LinkButton11.Visible = false; // authors link button
                    LinkButton12.Visible = false; //publishers link button
                    LinkButton8.Visible = false; //book inventory button
                    LinkButton9.Visible = false; //book issue button
                    LinkButton10.Visible = true; //members link button
                }

            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }

        protected void LinkButton6_Click(object sender, EventArgs e)
        {
            Response.Redirect("adminlogin.aspx");
        }

        protected void LinkButton11_Click(object sender, EventArgs e)
        {
            Response.Redirect("adminauthormanagement.aspx");
        }

        protected void LinkButton12_Click(object sender, EventArgs e)
        {
            Response.Redirect("adminpublishermanagement.aspx");
        }

        protected void LinkButton8_Click(object sender, EventArgs e)
        {
            Response.Redirect("adminbookinventory.aspx");
        }

        protected void LinkButton9_Click(object sender, EventArgs e)
        {
            Response.Redirect("adminbookissuing.aspx");
        }

        protected void LinkButton10_Click(object sender, EventArgs e)
        {
            Response.Redirect("adminmembermanagement.aspx");
        }

        protected void LinkButton4_Click(object sender, EventArgs e)
        {
            Response.Redirect("viewbooks.aspx");

        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("userlogin.aspx");

        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            Response.Redirect("usersignup.aspx");

        }

        protected void LinkButton7_Click(object sender, EventArgs e)
        {
            Response.Redirect("userprofile.aspx");

        }

        protected void LinkButton3_Click(object sender, EventArgs e)
        {
            Session["username"] = "";
            Session["full_name"] = "";
            Session["role"] = "";
            Session["status"] = "";

            LinkButton1.Visible = true; //user login button
            LinkButton2.Visible = true; //user sign-up button

            LinkButton3.Visible = false; //logout button
            LinkButton7.Visible = false; //user profile button

            LinkButton6.Visible = true; //admin login button
            LinkButton11.Visible = false; // authors link button
            LinkButton12.Visible = false; //publishers link button
            LinkButton8.Visible = false; //book inventory button
            LinkButton9.Visible = false; //book issue button
            LinkButton10.Visible = false; //members link button

            Response.Redirect("homepage.aspx");
        }
    }
}
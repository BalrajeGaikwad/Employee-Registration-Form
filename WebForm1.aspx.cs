using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Employee_Registration_Form
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            show();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                string a = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
                using (SqlConnection con = new SqlConnection(a))
                {
                    con.Open();
                    string query = "insert into information([Mr-Mrs],First_Name,Last_Name,Email,Contact,DBO,Country,State,City,IdentityCard,Identityno,Credit_Card_Number,Exp_Date,Holder_Name)values(@Mr_Mrs,@First_Name,@Last_Name,@Email,@Contact,@DBO,@Country,@State,@City,@IdentityCard,@Identityno,@Credit_Card_Number,@Exp_Date,@Holder_Name)";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Mr_Mrs", Mr_Mrs.SelectedValue);
                        cmd.Parameters.AddWithValue("@First_Name", First_Name.Text);
                        cmd.Parameters.AddWithValue("@Last_Name", Last_Name.Text);
                        cmd.Parameters.AddWithValue("@Email", Email.Text);
                        cmd.Parameters.AddWithValue("@Contact", Contact.Text);
                        cmd.Parameters.AddWithValue("@DBO", DBO.Text);
                        cmd.Parameters.AddWithValue("@Country", Country.SelectedValue);
                        cmd.Parameters.AddWithValue("@State", State.SelectedValue);
                        cmd.Parameters.AddWithValue("@City", City.SelectedValue);
                        cmd.Parameters.AddWithValue("@IdentityCard", IdentityCard.SelectedValue);
                        cmd.Parameters.AddWithValue("@Identityno", Identityno.Text);
                        cmd.Parameters.AddWithValue("@Credit_Card_Number", Credit_Card_Number.Text);
                        cmd.Parameters.AddWithValue("@Exp_Date", Exp_Date.Text);
                        cmd.Parameters.AddWithValue("@Holder_Name", Holder_Name.Text);

                        int count = cmd.ExecuteNonQuery();
                        if (count != 0)
                        {
                            Response.Write("<script> alert('Data Submitted Successfully') </script>");
                        }
                        else
                            Response.Write("<script> alert('Something Went to wrong') </script>");


                    }
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                Response.Write("<script> alert({ex}) <script>");
            }
            show();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                string a = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
                using (SqlConnection con = new SqlConnection(a))
                {
                    con.Open();
                    string query = "UPDATE information SET [Mr-Mrs]=@Mr_Mrs,First_Name=@First_Name,Last_Name=@Last_Name,Email=@Email,Contact=@Contact,DBO=@DBO,Country=@Country,State=@State,City=@City,IdentityCard=@IdentityCard,Identityno=@Identityno,Credit_Card_Number=@Credit_Card_Number,Exp_Date=@Exp_Date,Holder_Name=@Holder_Name where Email=@Email";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Mr_Mrs", Mr_Mrs.SelectedValue);
                        cmd.Parameters.AddWithValue("@First_Name", First_Name.Text);
                        cmd.Parameters.AddWithValue("@Last_Name", Last_Name.Text);
                        cmd.Parameters.AddWithValue("@Email", Email.Text);
                        cmd.Parameters.AddWithValue("@Contact", Contact.Text);
                        cmd.Parameters.AddWithValue("@DBO", DBO.Text);
                        cmd.Parameters.AddWithValue("@Country", Country.SelectedValue);
                        cmd.Parameters.AddWithValue("@State", State.SelectedValue);
                        cmd.Parameters.AddWithValue("@City", City.SelectedValue);
                        cmd.Parameters.AddWithValue("@IdentityCard", IdentityCard.SelectedValue);
                        cmd.Parameters.AddWithValue("@Identityno", Identityno.Text);
                        cmd.Parameters.AddWithValue("@Credit_Card_Number", Credit_Card_Number.Text);
                        cmd.Parameters.AddWithValue("@Exp_Date", Exp_Date.Text);
                        cmd.Parameters.AddWithValue("@Holder_Name", Holder_Name.Text);

                        int count = cmd.ExecuteNonQuery();
                        if (count != 0)
                        {
                            Response.Write("<script> alert('Data Updated Successfully') </script>");
                        }
                        else
                            Response.Write("<script> alert('Something Went to wrong') </script>");


                    }
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                Response.Write("<script> alert({ex}) <script>");
            }
            show();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            try
            {
                string a = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
                using (SqlConnection con = new SqlConnection(a))
                {
                    con.Open();
                    string query = "DELETE FROM information WHERE Email=@Email";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        /*cmd.Parameters.AddWithValue("@Mr_Mrs", Mr_Mrs.SelectedValue);
                        cmd.Parameters.AddWithValue("@First_Name", First_Name.Text);
                        cmd.Parameters.AddWithValue("@Last_Name", Last_Name.Text);
                        cmd.Parameters.AddWithValue("@Email", Email.Text);
                        cmd.Parameters.AddWithValue("@Contact", Contact.Text);
                        cmd.Parameters.AddWithValue("@DBO", DBO.Text);
                        cmd.Parameters.AddWithValue("@Country", Country.SelectedValue);
                        cmd.Parameters.AddWithValue("@State", State.SelectedValue);
                        cmd.Parameters.AddWithValue("@City", City.SelectedValue);
                        cmd.Parameters.AddWithValue("@IdentityCard", IdentityCard.SelectedValue);
                        cmd.Parameters.AddWithValue("@Identityno", Identityno.Text);
                        cmd.Parameters.AddWithValue("@Credit_Card_Number", Credit_Card_Number.Text);
                        cmd.Parameters.AddWithValue("@Exp_Date", Exp_Date.Text);
                        cmd.Parameters.AddWithValue("@Holder_Name", Holder_Name.Text);*/
                        cmd.Parameters.AddWithValue("@Email", Email.Text);

                        int count = cmd.ExecuteNonQuery();
                        if (count != 0)
                        {
                            Response.Write("<script> alert('Data Deleted Successfully') </script>");
                        }
                        else
                            Response.Write("<script> alert('Something Went to wrong') </script>");


                    }
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                Response.Write("<script> alert({ex}) <script>");
            }
            show();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {

            First_Name.Text = "";
            Last_Name.Text = "";
            Email.Text = "";
            Contact.Text = "";
            DBO.Text = "";
            Mr_Mrs.SelectedIndex = -1;
            Country.SelectedIndex = -1;
            State.SelectedIndex = -1;
            City.SelectedIndex = -1;
            IdentityCard.SelectedIndex = -1;
            Identityno.Text = "";
            Credit_Card_Number.Text = "";
            Exp_Date.Text = "";
            Holder_Name.Text = "";




        }


        protected void IdentityCard_SelectedIndexChanged(object sender, EventArgs e)
        {
            string a = IdentityCard.SelectedValue;
            if (a == "Aadhar Card")
            {
                Panel1.Visible = true;
                Panel2.Visible = false;
            }
            else if (a == "Pan Card")
            {
                Panel1.Visible = true;
                Panel2.Visible = false;
            }
            else if (a == "Credit Card")
            {
                Panel1.Visible = false;
                Panel2.Visible = true;
            }
        }

        public void show()
        {
            try
            {
                string a = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
                using (SqlConnection con = new SqlConnection(a))
                {
                    con.Open();
                    string query = "SELECT * FROM information";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        GridView1.DataSource = reader;
                        GridView1.DataBind();
                    }
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                Response.Write("<script> alert({ex}) <script>");
            }

        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            try
            {
                string a = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
                using (SqlConnection con = new SqlConnection(a))
                {
                    con.Open();
                    string query = "SELECT * FROM information where(DBO  BETWEEN @Start_Date AND @End_Date) OR (Email=@Email)";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Start_Date", Start_Date.Text);
                        cmd.Parameters.AddWithValue("@End_Date", End_Date.Text);
                        
                        cmd.Parameters.AddWithValue("@Email", Email.Text);


                        SqlDataReader reader = cmd.ExecuteReader();
                        GridView1.DataSource = reader;
                        GridView1.DataBind();

                    }
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                Response.Write("<script> alert({ex}) <script>");
            }
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            show();
        }
    }
}
using System;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace WebA
{
    public partial class Demo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnReg_Click(object sender, EventArgs e)
        {
           

            using (SqlConnection con = new SqlConnection("Data Source=MAYKR-DESK;Initial Catalog=A;Integrated Security=True"))
            {
                con.Open();

                string query = "INSERT INTO As_tbl (FullName, Address, Gender, Phone, Email, Username, Password) " +
                               "VALUES (@FullName, @Address, @Gender, @Phone, @Email, @Username, @Password)";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@FullName", txtName.Text);
                    cmd.Parameters.AddWithValue("@Address", txtAdd.Text);
                    cmd.Parameters.AddWithValue("@Gender",RadioButtonList1 .SelectedItem.Text);
                    cmd.Parameters.AddWithValue("@Phone", txtphone.Text);
                    cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@Username", txtUser.Text);
                    cmd.Parameters.AddWithValue("@Password", txtPass.Text);

                    cmd.ExecuteNonQuery();
                }
            }
        }

       
    }
}

using System.Data;
using System.Data.SqlClient;

namespace backend_.Models
{
    public class Dal
    {
        public Response Registration(Registration registration, SqlConnection connection)
        {
            Response response = new Response();
            SqlCommand cmd = new SqlCommand("INSER INTO Registration(Name,Email,Password,PhoneNo,IsActive,IsApproved) VALUES('"+registration.Name+ "','"+registration.Email+ "','"+registration.Password+ "','"+registration.PhoneNo+"',1,0)",connection);
            connection.Open();
            int i = cmd.ExecuteNonQuery();
            connection.Close();
            if(i > 0)
            {
                response.StatusCode = 200;
                response.StatusMessage = "Registration Successful";
            }
            else
            {
                response.StatusCode = 100;
                response.StatusMessage = "Registration Failed";
            }

            return response;
        }

        public Response Login(Registration registration, SqlConnection connection)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Registration WHERE Email = '"+registration.Email+"' AND Password = '"+registration.Password+"'",connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Response response = new Response();
            if(dt.Rows.Count > 0)
            {
                response.StatusCode = 200;
                response.StatusMessage = "Login Successful";
                Registration reg = new Registration();
                reg.Id = Convert.ToInt32(dt.Rows[0]["Id"]);
                reg.Name = Convert.ToString(dt.Rows[0]["Name"]);
                reg.Email = Convert.ToString(dt.Rows[0]["Email"]);
                response.Registration = reg;
            }
            else
            {
                response.StatusCode = 200;
                response.StatusMessage = "Login Failed";
                response.Registration = null;
            }
            return response;

        }
    }
}

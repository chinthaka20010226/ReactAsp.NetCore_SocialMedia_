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
    }
}

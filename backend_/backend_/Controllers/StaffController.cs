using backend_.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;

namespace backend_.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StaffController : ControllerBase
    {
        public readonly IConfiguration _configuration;

        public StaffController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpPost]
        [Route("StaffRegistration")]

        public Response StaffRegistartion(Staff staff)
        {
            Response response = new Response();
            SqlConnection connection = new SqlConnection(_configuration.GetConnectionString("sa").ToString());
            Dal dal = new Dal();
            response = dal.StaffRegistration(staff, connection);

            return response;
        }

        [HttpPost]
        [Route("DeleteStaff")]

        public Response DeleteStaff(Staff staff)
        {
            Response response = new Response();
            SqlConnection connection = new SqlConnection(_configuration.GetConnectionString("sa").ToString());
            Dal dal = new Dal();
            response = dal.DeleteStaff(staff, connection);

            return response;
        }
    }
}

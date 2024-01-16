using backend_.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;

namespace backend_.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventController : ControllerBase
    {
        public readonly IConfiguration _configuration;

        public EventController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpPost]
        [Route("AddEvent")]

        public Response AddEvent(Event events)
        {
            Response response = new Response();
            SqlConnection connection = new SqlConnection(_configuration.GetConnectionString("sa").ToString());
            Dal dal = new Dal();
            response = dal.AddEvent(events, connection);

            return response;
        }

        [HttpGet]
        [Route("EventsList")]

        public Response EventsList()
        {
            Response response = new Response();
            SqlConnection connection = new SqlConnection(_configuration.GetConnectionString("sa").ToString());
            Dal dal = new Dal();
            response = dal.EventsList(connection);

            return response;
        }
    }
}

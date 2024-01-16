using backend_.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;

namespace backend_.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArticleController : ControllerBase
    {
        public readonly IConfiguration _configuration;

        public ArticleController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpPost]
        [Route("AddArticles")]

        public Response AddArticles(Article article)
        {
            Response response = new Response();
            SqlConnection connection = new SqlConnection(_configuration.GetConnectionString("sa").ToString());
            Dal dal = new Dal();
            response = dal.AddArticles(article, connection);

            return response;
        }

        [HttpGet]
        [Route("ArticlesList")]

        public Response ArticlesList(Article article)
        {
            Response response = new Response();
            SqlConnection connection = new SqlConnection(_configuration.GetConnectionString("sa").ToString());
            Dal dal = new Dal();
            response = dal.ArticlesList(article,connection);

            return response;
        }

        [HttpPost]
        [Route("ArticleApproval")]

        public Response ArticleApproval(Article article)
        {
            Response response = new Response();
            SqlConnection connection = new SqlConnection(_configuration.GetConnectionString("sa").ToString());
            Dal dal = new Dal();
            response = dal.ArticleApproval(article, connection);

            return response;
        }
    }
}

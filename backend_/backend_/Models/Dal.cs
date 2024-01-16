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

        public Response UserApproval(Registration registration, SqlConnection connection)
        {
            Response response = new Response();
            SqlCommand cmd = new SqlCommand("UPDATE Registration SET IsApproved = 1 WHERE Id = '"+registration.Id+"' AND IsActive = 1", connection);
            connection.Open();
            int i = cmd.ExecuteNonQuery();
            connection.Close();
            if(i > 0)
            {
                response.StatusCode = 200;
                response.StatusMessage = "User Approved";
            }
            else
            {
                response.StatusCode = 100;
                response.StatusMessage = "User Approval Failed";
            }
            return response;
        }

        public Response AddNews(News news, SqlConnection connection)
        {
            Response response = new Response();
            SqlCommand cmd = new SqlCommand("INSERT INTO News(Title,Content,Email,IsAcctive,CreatedOn) VALUES('"+news.Title+"','"+news.Content+"','"+news.Email+"',1,GETDATE())", connection);
            connection.Open();
            int i = cmd.ExecuteNonQuery();
            connection.Close();
            if(i > 0)
            {
                response.StatusCode = 200;
                response.StatusMessage = "News Created";
            }
            else
            {
                response.StatusCode = 100;
                response.StatusMessage = "News Creation Failed";
            }

            return response;
        }

        public Response NewsList(SqlConnection connection)
        {
            Response response = new Response();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM News WHERE IsActive = 1", connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            List<News> lstNews = new List<News>();
            if (dt.Rows.Count > 0)
            {
                for(int i = 0; i < dt.Rows.Count; i++)
                {
                    News news = new News();
                    news.Id = Convert.ToInt32(dt.Rows[i]["Id"]);
                    news.Title = Convert.ToString(dt.Rows[i]["Title"]);
                    news.Content = Convert.ToString(dt.Rows[i]["Content"]);
                    news.Email = Convert.ToString(dt.Rows[i]["Email"]);
                    news.IsActive = Convert.ToInt32(dt.Rows[i]["IsActive"]);
                    news.CreatedOn = Convert.ToDateTime(dt.Rows[i]["CreatedOn"]);
                    lstNews.Add(news);
                }
                if(lstNews.Count > 0)
                {
                    response.StatusCode = 200;
                    response.StatusMessage = "News data found";
                    response.listNews = lstNews;
                }
                else
                {
                    response.StatusCode = 100;
                    response.StatusMessage = "News data not found";
                    response.listNews = null;
                }
            }
            else
            {
                response.StatusCode = 100;
                response.StatusMessage = "News data not found";
                response.listNews = null;
            }

            return response;
        }

        public Response AddArticles(Article article, SqlConnection connection)
        {
            Response response = new Response();
            SqlCommand cmd = new SqlCommand("INSERT INTO Article(Title,Content,Email,Image,IsActive,IsApproved) VALUES('"+article.Title+"','"+article.Content+"','"+article.Email+"','"+article.Image+"',1,0)",connection);
            connection.Open();
            int i = cmd.ExecuteNonQuery();
            connection.Close();
            if(i > 0)
            {
                response.StatusCode = 200;
                response.StatusMessage = "Article Created";
            }
            else
            {
                response.StatusCode = 100;
                response.StatusMessage = "Article Created Failed";
            }

            return response;
        }

        public Response ArticlesList(Article article, SqlConnection connection)
        {

            Response response = new Response();
            SqlDataAdapter da = null;
            if(article.type == "User")
            {
                da =new SqlDataAdapter("SELECT * FROM Article WHERE Email = '"+article.Email+"' AND IsActive = 1", connection);
            }
            if(article.type == "Page")
            {
                da = new SqlDataAdapter("SELECT * FROM Article WHERE IsActive = 1", connection);
            }
            DataTable dt = new DataTable();
            da.Fill(dt);
            List<Article> lstArticle = new List<Article>();
            if(dt.Rows.Count > 0)
            {
                for(int i = 0; i < dt.Rows.Count; i++)
                {
                    Article art = new Article();
                    art.Title = Convert.ToString(dt.Rows[i]["Title"]);
                    art.Content = Convert.ToString(dt.Rows[i]["Content"]);
                    art.Email = Convert.ToString(dt.Rows[i]["Email"]);
                    art.Image = Convert.ToString(dt.Rows[i]["Image"]);
                    art.IsActive = Convert.ToInt32(dt.Rows[i]["IsActive"]);
                    lstArticle.Add(art);
                }
                if(lstArticle.Count > 0)
                {
                    response.StatusCode = 200;
                    response.StatusMessage = "Article data found";
                    response.listArticle = lstArticle;
                }
                else
                {
                    response.StatusCode = 100;
                    response.StatusMessage = "Artcile data not found";
                    response.listArticle = null;
                }
            }
            else
            {
                response.StatusCode = 100;
                response.StatusMessage = "Artcile data not found";
                response.listArticle = null;
            }

            return response;
        }

        public Response ArticleApproval(Article article, SqlConnection connection)
        {
            Response response = new Response();
            SqlCommand cmd = new SqlCommand("UPDATE Article SET IsApproved = 1 WHERE Id = '" + article.Id + "' AND IsActive = 1", connection);
            connection.Open();
            int i = cmd.ExecuteNonQuery();
            connection.Close();
            if (i > 0) 
            {
                response.StatusCode = 200;
                response.StatusMessage = "Article Approved";
            }
            else
            {
                response.StatusCode = 100;
                response.StatusMessage = "Article Approval Failed";
            }

            return response;
        }

        public Response StaffRegistration(Staff staff,SqlConnection connection)
        {
            Response response = new Response();
            SqlCommand cmd = new SqlCommand("INSERT INTO Staff(Id,Name,Email,Password,IsActive) VALUES('"+staff.Id+"','"+staff.Name+"','"+staff.Email+"','"+staff.Password+"',1)",connection);
            connection.Open();
            int i = cmd.ExecuteNonQuery();
            connection.Close();
            if(i > 0)
            {
                response.StatusCode = 200;
                response.StatusMessage = "Registartion Succefull";
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

namespace backend_.Models
{
    public class Response
    {
        public int StatusCode { get; set; }
        public String StatusMessage { get; set; }
        public List<Registration> listRegistration { get; set; }
        public Registration Registration { get; set; }
        public List<Article> listArticle { get; set; }
        public List<News> listNews { get; set; }
        public List<Event> listEvent { get; set; }
    }
}

namespace backend_.Models
{
    public class Article
    {
        public int Id { get; set; }
        public String Title { get; set; }
        public String Content { get; set; }
        public String Email { get; set; }
        public String Image { get; set; }
        public int IsActive { get; set; }
        public int IsApproved { get; set; }
    }
}

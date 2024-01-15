namespace backend_.Models
{
    public class News
    {
        public int Id { get; set; }
        public String Title { get; set; }
        public String Content { get; set; }
        public String Email { get; set; }
        public int IsActive { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}

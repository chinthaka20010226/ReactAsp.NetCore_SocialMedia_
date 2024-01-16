using System.ComponentModel.DataAnnotations;

namespace backend_.Models
{
    public class Registration
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public String Email { get; set; }
        public String Password { get; set; }
        public String PhoneNo { get; set; }
        public int IsActive { get; set; }
        public int IsApproved { get; set; }
    }
}

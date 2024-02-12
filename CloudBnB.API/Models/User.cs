namespace CloudBnB.API.Models
{
    public class User
    {
        public User()
        {
            this.Id = Guid.NewGuid();    
        }

        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
    }
}

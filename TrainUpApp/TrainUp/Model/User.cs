namespace TrainUp.Model
{
    public class User
    {
        public int Id { get; set; }
        public string?  FirstName { get; set; }
        public string?  LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string? Email { get; set; }
        public string? Qualification { get; set; }
        public string? Password { get; set; }
        public bool IsActive { get; set; } = true;
        public string? InsertedBy { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime InsertedOn { get; set; }
        public DateTime LastUpdatedOn { get; set; }
        public Role? Role { get; set; }
    }
}

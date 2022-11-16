namespace MCV.Models
{
    public class Person
    {
        public string Id { get; set; }
        public string Name { get; set; }    
        public string City { get; set; }
        // Can be null
        public string? PhoneNumber { get; set; }
    }
}

namespace MCV.Models
{
    public class PersonViewModel
    {
        public static List<Person> listOfPeople = new List<Person>();

        public List<Person> tempList = new List<Person>();

        // public Person person { get; set; }

        public static void GeneratePeople()
        {
            listOfPeople.Add(new Person { Id = Guid.NewGuid().ToString(), Name ="Andreas Lyckholm", PhoneNumber="0738382888", City ="Gothenburg"});
            listOfPeople.Add(new Person { Id = Guid.NewGuid().ToString(), Name = "Sven Svensson", PhoneNumber = "8739493999", City = "Göteborg" });
            listOfPeople.Add(new Person { Id = Guid.NewGuid().ToString(), Name = "Sten Sture", PhoneNumber = "087172777", City = "Stockholm" });
            listOfPeople.Add(new Person { Id = Guid.NewGuid().ToString(), Name = "Hjalmar Platsen", PhoneNumber = "075150555", City = "Göteborg" });
        }
    }
}

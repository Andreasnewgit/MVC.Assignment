namespace MCV.Models
{
    public class PersonViewModel
    {
        public static List<PersonData> listOfPeople = new List<PersonData>();

        public List<PersonData> tempList = new List<PersonData>();

        public static void GeneratePeople()
        {
            listOfPeople.Add(new PersonData { Id = Guid.NewGuid().ToString(), Name = "Andreas Lyckholm", City = "Göteborg", PhoneNumber = "0768382888"});
            listOfPeople.Add(new PersonData { Id = Guid.NewGuid().ToString(), Name = "Christoffer Lyckholm", City = "Göteborg", PhoneNumber = "0761717777" });
            listOfPeople.Add(new PersonData { Id = Guid.NewGuid().ToString(), Name = "Sten Sture", City = "Stockholm", PhoneNumber = "0808807652" });
            listOfPeople.Add(new PersonData { Id = Guid.NewGuid().ToString(), Name = "Sven Svensson", City = "Stockholm", PhoneNumber = "085676832" });
        }



    }
}

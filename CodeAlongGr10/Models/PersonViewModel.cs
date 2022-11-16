namespace MCV.Models
{
    public class PersonViewModel
    {
        public static List<Person> ListOfPeople = new List<Person>();

        // Fills from the list above, tempList used for filtering(searching
        public List<Person> tempList = new List<Person>();

        public static void GeneratePeopleTest()
        {
            ListOfPeople.Add(new Person { Id = Guid.NewGuid().ToString(), Name="Andreas lyckholm", City="Göteborg", PhoneNumber="0768382888"});
            ListOfPeople.Add(new Person { Id = Guid.NewGuid().ToString(), Name="Test McTest", City="Stockholm", PhoneNumber="08123456"}); 
            ListOfPeople.Add(new Person { Id = Guid.NewGuid().ToString(), Name="Christoffer Lyckholm", City="Göteborg", PhoneNumber="0767771717" }); 
            ListOfPeople.Add(new Person { Id = Guid.NewGuid().ToString(), Name="Håkan Skeneby", City="Mora", PhoneNumber="031183439" });
        }
    }
}

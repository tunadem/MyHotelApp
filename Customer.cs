
namespace MyHotelApp
{
    public class Customer
{
    // Properties
    public int ID { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }

    // Constructor
    public Customer(int id, string name,string surname)
    {
        ID = id;
        Name = name;
        Surname = surname;
    }

    // Method
    public void Greet()
    {
        Console.WriteLine($"ID : {ID} , Name : {Name} , Surname : {Surname}");
    }
}

}
namespace MyHotelApp
{
    public class Room
{
    // Properties
    public int ID { get; set; }
    public int Floor { get; set; }
    public int Number { get; set; }
    public bool Available { get; set; }

    // Constructor
    public Room(int id, int floor,int number)
    {
        ID = id;
        Floor = floor;
        Number = number;
    }

    // Method
    public void Greet()
    {
        Console.WriteLine($"ID : {ID} , Floor : {Floor} , Number : {Number}");
    }
}

}

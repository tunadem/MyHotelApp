using System;

namespace MyHotelApp
{
    public class Reservation
{
    // Properties
    public int ID { get; set; }
    public int customerID { get; set; }
    public int RoomId { get; set; }
    public DateTime EnterDate { get; set; }
    public DateTime ExitDate { get; set; }
    //public DateTime specificDate = new DateTime(2024, 1, 1); // January 1, 2024


    // Constructor
    public Reservation(int id, int customerID,int customerID,DateTime enterDate,DateTime exitDate)
    {
        ID = id;
        CustomerID = customerID;
        RoomId = roomId;
        EnterDate = enterDate;
        ExitDate = exitDate;
    }

    // Method
    public void Greet()
    {
        Console.WriteLine($"ID : {ID} , CustomerID : {CustomerID} , RoomId : {RoomId}");
    }
}

}
using System;

namespace MyHotelApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string roomFilePath = "rooms.json";
            string customerFilePath = "customers.json";
            string reservationFilePath = @"C:\Users\msı\OneDrive\Masaüstü\MyHotelApp\rooms.json";

            // Initialize JsonDB and load RoomList
            JsonDB jsonDB = new JsonDB(roomFilePath,customerFilePath);

            // Iterate over the RoomList and print details
            foreach (var room in jsonDB.RoomList)
            {
                Console.WriteLine($"ID = {room.ID}, Floor = {room.Floor}, Number = {room.Number}");
            }
            foreach (var customer in jsonDB.CustomerList)
            {
                Console.WriteLine($"ID = {customer.ID}, Name = {customer.Name}, Surname = {customer.Surname}");
            }
        }
    }
}


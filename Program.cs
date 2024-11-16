using System;

namespace MyHotelApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string roomFilePath = "rooms.json";
            string customerFilePath = "customers.json";
            string reservationFilePath = "reservations.json";

            // Initialize JsonDB and load RoomList
            JsonDB jsonDB = new JsonDB(roomFilePath,customerFilePath,reservationFilePath);

            // Iterate over the RoomList and print details
            foreach (var room in jsonDB.RoomList)
            {
                Console.WriteLine($"ID = {room.ID}, Floor = {room.Floor}, Number = {room.Number}");
            }
            foreach (var customer in jsonDB.CustomerList)
            {
                Console.WriteLine($"ID = {customer.ID}, Name = {customer.Name}, Surname = {customer.Surname}");
            }
            foreach (var reservation in jsonDB.ReservationList)
            {
                Console.WriteLine($"ID = {reservation.ID}, CustomerID = {reservation.CustomerID}, CustomerID = {reservation.RoomId}, EnterDate = {reservation.EnterDate}, ExitDate = {reservation.ExitDate}");
            }
        }
    }
}


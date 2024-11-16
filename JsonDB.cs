using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace MyHotelApp
{
    public class JsonDB
    {
        public List<Room> RoomList { get; private set; }
        public List<Customer> CustomerList { get; private set; }
        public List<Reservation> ReservationList { get; private set; }

        public JsonDB(string roomFilePath,string customerFilePath)
        {
            RoomList = ReadRoom(roomFilePath); // Populate RoomList during initialization
            CustomerList = ReadCustomer(customerFilePath);
        }

        private static List<Room> ReadRoom(string filePath)
        {
            string jsonString = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<List<Room>>(jsonString);
        }

        private static List<Customer> ReadCustomer(string filePath)
        {
            string jsonString = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<List<Customer>>(jsonString);
        }

        private static List<Reservation> ReadReservation(string filePath)
        {
            string jsonString = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<List<Reservation>>(jsonString);
        }
    }

}


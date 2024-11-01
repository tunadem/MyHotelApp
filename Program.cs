using System;

namespace MyHotelApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer c1 = new Customer(1,"tunga","durmaz");
            Customer c2 = new Customer(2,"anne","baysal");
            Customer c3 = new Customer(3,"nu","gmail");

            Room r1 = new Room(1,0,1);
            Room r2 = new Room(2,0,2);
            Room r3 = new Room(3,0,3);
            Room r4 = new Room(4,1,1);
            Room r5 = new Room(5,1,2);
            Room r6 = new Room(6,1,3);

            r1.Greet();


        }
    }
}


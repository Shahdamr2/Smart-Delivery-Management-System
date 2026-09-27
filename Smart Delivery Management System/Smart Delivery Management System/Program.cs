using System;
using Assignment09.Entities;
using Assignment09.Inheritance;
using Assignment09.Utilities;
using Assignment09.Extensions;
namespace Smart_Delivery_Management_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 1

            // a) Assigning one object variable to another copies the reference,
            // so both variables refer to the same object

            // b) No, assigning one object variable to another does not create
            // a new object

            // c) Copying an object creates a new object,
            // while copying a reference makes two variables refer to the same object

            #endregion
            #region Question 2

            // a) Shallow Copy creates a new object but copies reference-type members
            // as references.

            // b) Deep Copy creates a new object and also creates new objects
            // for its reference-type members.

            // c) In a Shallow Copy, reference-type members still refer to
            // the same objects.

            // d) In a Deep Copy, reference-type members refer to new objects.

            // e) Deep Copy is safer when we need to change the copied object
            // without affecting the original object.

            #endregion
            #region Question 3

            // a) A static field belongs to the class and is shared by all objects,
            // while an instance field belongs to each object

            // b) A static method belongs to the class.
            // It cannot directly access instance members

            // c) A static constructor initializes static data and is executed
            // automatically once before the type is first used

            // d) A static class contains only static members
            // We cannot create an object from a static class

            #endregion
            #region Question 4

            // a) An Extension Method allows us to add a method to an existing type
            // without modifying the original class

            // b) The first parameter must use the this keyword

            // c) An Extension Method must be declared inside a static class

            // d) No, an Extension Method cannot directly access private members
            // of the class it extends

            #endregion
            #region Question 5

            // a) A Partial Class allows one class to be split into multiple files

            // b) A developer can split a class into multiple files to organize
            // large classes and separate responsibilities

            // c) A Partial Method is a method whose declaration and implementation
            // can be placed in different parts of the same partial class

            // d) If a partial method has no implementation, the compiler removes
            // its declaration and calls

            #endregion
            #region Practical Question 1 - Object Copying

            Shipment shipment1 = new StandardShipment(
                "SH001",
                "Laptop",
                3,
                80);

            Shipment shipment2 = shipment1;

            //Console.WriteLine("==========================================");
            //Console.WriteLine("Object Copying");
            //Console.WriteLine("==========================================");
            //Console.WriteLine();

            //Console.WriteLine($"Original Shipment  : {shipment1.TrackingCode}");
            //Console.WriteLine($"Assigned Shipment  : {shipment2.TrackingCode}");
            //Console.WriteLine();

            //Console.WriteLine($"Same Object : {ReferenceEquals(shipment1, shipment2)}");

            Shipment shipment3 = shipment1.CopyShipment();

            //Console.WriteLine();
            //Console.WriteLine($"Copied Shipment    : {shipment3.TrackingCode}");
            //Console.WriteLine($"Same Object : {ReferenceEquals(shipment1, shipment3)}");

            #endregion
            #region Practical Question 2 - Shallow Copy

            //Shipment shallowCopy = shipment1.ShallowCopy();

            //Console.WriteLine("------------------------------------------");
            //Console.WriteLine("Shallow Copy");
            //Console.WriteLine("------------------------------------------");
            //Console.WriteLine();

            //Console.WriteLine($"Original Shipment Address : {shipment1.Destination.City}");
            //Console.WriteLine($"Copied Shipment Address   : {shallowCopy.Destination.City}");

            //Console.WriteLine();
            //Console.WriteLine("Changing copied shipment address...");

            //shallowCopy.Destination.City = "Giza";

            //Console.WriteLine();
            //Console.WriteLine($"Original Shipment Address : {shipment1.Destination.City}");
            //Console.WriteLine($"Copied Shipment Address   : {shallowCopy.Destination.City}");

            //Console.WriteLine();
            //Console.WriteLine(
            //    $"Same DeliveryAddress Object : {ReferenceEquals(shipment1.Destination, shallowCopy.Destination)}");

            #endregion
            #region Practical Question 3 - Deep Copy

            //Shipment deepCopy = shipment1.DeepCopy();

            //Console.WriteLine("==========================================");
            //Console.WriteLine("Deep Copy");
            //Console.WriteLine("==========================================");
            //Console.WriteLine();

            //Console.WriteLine($"Original Shipment Address : {shipment1.Destination.City}");
            //Console.WriteLine($"Copied Shipment Address   : {deepCopy.Destination.City}");

            //Console.WriteLine();
            //Console.WriteLine("Changing copied shipment address...");

            //deepCopy.Destination.City = "Giza";

            //Console.WriteLine();
            //Console.WriteLine($"Original Shipment Address : {shipment1.Destination.City}");
            //Console.WriteLine($"Copied Shipment Address   : {deepCopy.Destination.City}");

            //Console.WriteLine();
            //Console.WriteLine(
            //    $"Same DeliveryAddress Object : {ReferenceEquals(shipment1.Destination, deepCopy.Destination)}");

            #endregion
            #region Practical Question 4 - Static Field

            //Console.WriteLine("==========================================");
            //Console.WriteLine("Static Field");
            //Console.WriteLine("==========================================");
            //Console.WriteLine();

            //Console.WriteLine($"Total Shipments Created : {Shipment.TotalShipmentsCreated}");

            #endregion
            #region Practical Question 5 - Static Constructor

            //Console.WriteLine("==========================================");
            //Console.WriteLine("Static Constructor");
            //Console.WriteLine("==========================================");
            //Console.WriteLine();

            #endregion
            #region Practical Question 6 - Static Method

            //Console.WriteLine("==========================================");
            //Console.WriteLine("Static Method");
            //Console.WriteLine("==========================================");
            //Console.WriteLine();

            //Console.WriteLine(
            //    $"Total Shipments Created : {Shipment.GetTotalShipmentsCreated()}");

            #endregion
            #region Practical Question 7 - Static Class

            //Console.WriteLine();
            //DeliveryUtilities.PrintSystemTitle();
            //Console.WriteLine();

            //DeliveryUtilities.PrintSeparator();
            //Console.WriteLine("Static Class");
            //DeliveryUtilities.PrintSeparator();

            #endregion
            #region Practical Question 8 - Extension Methods

            StandardShipment standardShipment = new StandardShipment(
                "SH001",
                "Laptop",
                3,
                80,
                new DeliveryAddress("Cairo", "Main Street", 10));

            ExpressShipment expressShipment = new ExpressShipment(
                "SH002",
                "Mobile",
                2,
                60,
                new DeliveryAddress("Cairo", "Main Street", 20),
                30);

            InternationalShipment internationalShipment = new InternationalShipment(
                "SH003",
                "Medical Equipment",
                8,
                100,
                new DeliveryAddress("Cairo", "Main Street", 30),
                "Germany",
                60);

            Console.WriteLine();
            Console.WriteLine("==========================================");
            Console.WriteLine("Extension Methods");
            Console.WriteLine("==========================================");
            Console.WriteLine();

            Console.WriteLine(standardShipment.GetSummary());
            Console.WriteLine(expressShipment.GetSummary());
            Console.WriteLine(internationalShipment.GetSummary());

            Console.WriteLine();

            Console.WriteLine($"SH001 Is Delivered : {standardShipment.IsDelivered()}");
            Console.WriteLine($"SH003 Is Delivered : {internationalShipment.IsDelivered()}");

            #endregion
        }
    }
}

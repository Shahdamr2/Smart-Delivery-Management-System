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
        }
    }
}

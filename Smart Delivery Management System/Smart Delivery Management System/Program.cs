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
        }
    }
}

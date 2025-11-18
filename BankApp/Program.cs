using System.Security.Cryptography.X509Certificates;

namespace BankApp
{
    // Data Types
    /// ///////////////////////////////////////////////////////
    // Numberic Data Types
    // (bit, short, int, long, float, double, decimal) - Value Types

    // Characters Data Types - Reference Types
    // Array Data Types - Reference Types

    // Creating a customer Data type
    // A structure is like a small container that holds related data together
    internal struct FullName
    {
        // These are variables inside the structure that store parts of a person's name
        public string firstName;       // Stores the first name
        public string middleInitial;   // Stores the middle initial
        public string lastName;        // Stores the last name
    }

    internal enum BankStatus
    { 
        silver,
        gold,
        platnium,
    }

    internal enum DaysOftheWeek
    { 
        Sun, Mon, Tue, Wed, Thurs, Fri, Sat
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a variable based on the FullName structure
            FullName fullName = new FullName();
            // Now "fullName" has three parts: firstName, middleInitial, lastName

            // Assign values to each part of the full name
            fullName.firstName = "Tony";   // Set the first name to Tony
            fullName.middleInitial = "L."; // Set the middle initial to L.
            fullName.lastName = "Bell";    // Set the last name to Bell

            // Display the full name using string interpolation
            Console.WriteLine($"FirstName: {fullName.firstName}, MiddleInitial: {fullName.middleInitial}, Lastname: {fullName.lastName}");
            // Output: FirstName: Tony, MiddleInitial: L., Lastname: Bell

            BankStatus bankStatus = BankStatus.gold;

            if (bankStatus == BankStatus.silver)
            {
                Console.WriteLine("Silver Level Account");

            }
            else
            {
                Console.WriteLine("Not Silver Level Account");
            }
        }
    }
}

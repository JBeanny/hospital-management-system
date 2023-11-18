namespace hospital_management_system.Utils
{
    internal class Util
    {
        public string generateRandomId(int length, string prefix)
        {
            // Initialize the random number generator
            Random random = new Random();

            // Generate a random number with 5 digits
            int minLength = 10000; // Minimum value for a 5-digit number
            int maxLength = 99999; // Maximum value for a 5-digit number
            int randomNumber = random.Next(minLength, maxLength + 1);

            return prefix + "_" + randomNumber;
        }
    }
}

namespace hospital_management_system.Utils
{
    public class Util
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

        // validate input
        public Boolean validateInput(string id, string name, string gender, string phone, string email, string birthdate, string specialty, string room)
        {
            return id != "" || name != "" || gender != "" || phone != "" || email != "" || birthdate != "" || specialty != "" || room != "";
        }

        // formatted string
        public string formattedFileData(string id, string name, string gender, string phone, string email, string birthdate, string specialty, string room)
        {
            return id + "/" + name + "/" + gender + "/" + phone + "/" + email + "/" + birthdate + "/" + specialty + "/" + room;
        }
    }
}

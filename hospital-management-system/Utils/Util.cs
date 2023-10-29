namespace hospital_management_system.Utils
{
    internal class Util
    {
        public int generateRandomId(int length)
        {
            Random random = new Random();
            string idString = "";

            for (int i = 0; i < length; i++)
            {
                idString += random.Next().ToString();
            }

            return (int)Int64.Parse(idString);
        }
    }
}

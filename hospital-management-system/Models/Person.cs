namespace hospital_management_system.Models
{
    internal class Person
    {
        private string name { get; set; }
        private string phone_number { get; set; }
        private string email { get; set; }
        private string gender { get; set; }
        private string birth_date { get; set; }

        public Person(string name, string phone_number, string email, string gender, string birth_date)
        {
            this.name = name;
            this.phone_number = phone_number;
            this.email = email;
            this.gender = gender;
            this.birth_date = birth_date;
        }

    }
}

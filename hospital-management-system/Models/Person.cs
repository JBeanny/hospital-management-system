namespace hospital_management_system.Models
{
    internal class Person
    {
        public string name { get; set; }
        public string phone_number { get; set; }
        public string email { get; set; }
        public string gender { get; set; }
        public string birth_date { get; set; }

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
